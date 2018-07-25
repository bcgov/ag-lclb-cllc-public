﻿using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Interfaces.Models;
using Gov.Lclb.Cllb.Public.Authentication;
using Gov.Lclb.Cllb.Public.Models;
using Gov.Lclb.Cllb.Public.Utils;
using Gov.Lclb.Cllb.Public.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gov.Lclb.Cllb.Public.Controllers
{
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly BCeIDBusinessQuery _bceid;
        private readonly IConfiguration Configuration;
        private readonly IDynamicsClient _dynamicsClient;
        private readonly SharePointFileManager _sharePointFileManager;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger _logger;



        public AccountController(IConfiguration configuration, SharePointFileManager sharePointFileManager, IHttpContextAccessor httpContextAccessor, BCeIDBusinessQuery bceid, ILoggerFactory loggerFactory, IDynamicsClient dynamicsClient)
        {
            Configuration = configuration;
            _bceid = bceid;
            _dynamicsClient = dynamicsClient;
            _httpContextAccessor = httpContextAccessor;
            _sharePointFileManager = sharePointFileManager;
            _logger = loggerFactory.CreateLogger(typeof(AccountController));
        }

        /// GET account in Dynamics for the current user
        [HttpGet("current")]
        public async Task<IActionResult> GetCurrentAccount()
        {
            ViewModels.Account result = null;

            // get the current user.
            string temp = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(temp);

            // query the Dynamics system to get the account record.
            if (userSettings.AccountId != null && userSettings.AccountId.Length > 0)
            {
                var accountId = Guid.Parse(userSettings.AccountId);
                MicrosoftDynamicsCRMaccount account = await _dynamicsClient.GetAccountById(accountId);
                if (account == null)
                {
                    return new NotFoundResult();
                }

                result = account.ToViewModel();
            }
            else
            {
                return new NotFoundResult();
            }

            return Json(result);
        }

        /// GET account in Dynamics for the current user
        [HttpGet("bceid")]
        public async Task<IActionResult> GetCurrentBCeIDBusiness()
        {
            // get the current user.
            string temp = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(temp);

            // query the BCeID API to get the business record.
            var business = await _bceid.ProcessBusinessQuery(userSettings.SiteMinderGuid);

            if (business == null)
            {
                return new NotFoundResult();
            }

            return Json(business);
        }

        /// <summary>
        /// Get a specific legal entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAccount(string id)
        {
            ViewModels.Account result = null;

            // query the Dynamics system to get the account record.
            if (id != null)
            {
                // verify the currently logged in user has access to this account
                Guid accountId = new Guid(id);
                if (!DynamicsExtensions.CurrentUserHasAccessToAccount(accountId, _httpContextAccessor, _dynamicsClient))
                {
                    return new NotFoundResult();
                }

                MicrosoftDynamicsCRMaccount account = await _dynamicsClient.GetAccountById(accountId);
                if (account == null)
                {
                    return new NotFoundResult();
                }
                result = account.ToViewModel();
            }
            else
            {
                return BadRequest();
            }

            return Json(result);
        }

        [HttpGet("business-profile/{accountId}")]
        public async Task<IActionResult> GetBusinessProfile(string accountId)
        {
            var account = (await _dynamicsClient.GetAccountById(new Guid(accountId))).ToViewModel();
            // get legal entities
            var entityFilter = $"_adoxio_account_value eq {accountId}";
            var expandList = new List<string> { "adoxio_ShareholderAccountID" };
            var legalEntities = _dynamicsClient.Adoxiolegalentities.Get(filter: entityFilter, expand: expandList).Value
                .Select(le =>
                {
                    var legalEntity = le.ToViewModel();
                    var entity = new ViewModels.LegalEntity
                    {
                        AdoxioLegalEntity = legalEntity,
                        Account = le.AdoxioShareholderAccountID == null ? account : le.AdoxioShareholderAccountID.ToViewModel(),
                    };
                    entity.corporateDetailsFilesExists = FileUploadExists(entity.Account.id, entity.Account.name, "Corporate Information").Result;
                    entity.organizationStructureFilesExists = FileUploadExists(entity.Account.id, entity.Account.name, "Organization Structure").Result;
                    entity.keyPersonnelFilesExists = FileUploadExists(entity.Account.id, entity.Account.name, "Key Personnel").Result;
                    entity.financialInformationFilesExists = FileUploadExists(entity.Account.id, entity.Account.name, "Financial Information").Result;
                    entity.shareholderFilesExists = FileUploadExists(entity.Account.id, entity.Account.name, "Central Securities Register").Result;
                    var tiedHouse = _dynamicsClient.AdoxioTiedhouseconnections
                        .Get(filter: $"_adoxio_accountid_value eq {entity.Account.id}")
                        .Value.FirstOrDefault();
                    if (tiedHouse != null)
                    {
                        entity.TiedHouse = tiedHouse.ToViewModel();
                    }
                    entity.ChildEntities = GetLegalEntityChildren(entity.AdoxioLegalEntity.id);
                    return entity;
                })
                .ToList();

            var profile = new BusinessProfile
            {
                Account = account,
                LegalEntities = legalEntities
            };

            var isComplete = legalEntities.Select(le =>
            {
                var valid = new ProfileValidation
                {
                    LegalEntityId = le.AdoxioLegalEntity.id,
                    IsComplete = (le.IsComplete())
                };
                return valid;
            }).ToList();

            return Json(isComplete);
        }

        private List<ViewModels.LegalEntity> GetLegalEntityChildren(string parentLegalEntityId)
        {
            List<ViewModels.LegalEntity> children = null;
            var childEntitiesFilter = $"_adoxio_legalentityowned_value eq {parentLegalEntityId}";
            var expandList = new List<string> { "adoxio_ShareholderAccountID", "adoxio_Account" };
            children = _dynamicsClient.Adoxiolegalentities
                .Get(filter: childEntitiesFilter, expand: expandList).Value
                .Select(le =>
                {
                    var legalEntity = le.ToViewModel();
                    var entity = new ViewModels.LegalEntity
                    {
                        AdoxioLegalEntity = legalEntity,
                        Account = le.AdoxioShareholderAccountID == null ? le.AdoxioAccount.ToViewModel() : le.AdoxioShareholderAccountID.ToViewModel()
                    };
                    var tiedHouse = _dynamicsClient.AdoxioTiedhouseconnections
                        .Get(filter: $"_adoxio_accountid_value eq {entity.Account.id}")
                        .Value.FirstOrDefault();
                    if (tiedHouse != null)
                    {
                        entity.TiedHouse = tiedHouse.ToViewModel();
                    }
                    if (entity.AdoxioLegalEntity.isShareholder == true && entity.AdoxioLegalEntity.isindividual == false)
                    {
                        entity.ChildEntities = GetLegalEntityChildren(entity.AdoxioLegalEntity.id);
                    }
                    return entity;
                })
                .ToList();
            return children;
        }

        private async Task<bool> FileUploadExists(string accountId, string accountName, string documentType)
        {
            var exists = false;
            var accountIdCleaned = accountId.ToUpper().Replace("-", "");
            var folderName = $"{accountName}_{accountIdCleaned}";
            var fileDetailsList = await _sharePointFileManager.GetFileDetailsListInFolder(SharePointFileManager.DefaultDocumentListTitle, folderName, documentType);
            if (fileDetailsList != null)
            {
                exists = fileDetailsList.Count() > 0;
            }
            return exists;
        }

        [HttpPost()]
        public async Task<IActionResult> CreateDynamicsAccount([FromBody] ViewModels.Account item)
        {

            ViewModels.Account result = null;
            Boolean updateIfNull = true;

            // get UserSettings from the session
            string temp = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(temp);

            // get account Siteminder GUID
            string accountSiteminderGuid = userSettings.SiteMinderBusinessGuid;
            if (accountSiteminderGuid == null || accountSiteminderGuid.Length == 0)
                throw new Exception("Oops no accountSiteminderGuid exernal id");

            // first check to see that a contact exists.
            string contactSiteminderGuid = userSettings.SiteMinderGuid;
            if (contactSiteminderGuid == null || contactSiteminderGuid.Length == 0)
                throw new Exception("Oops no ContactSiteminderGuid exernal id");

            // get BCeID record for the current user
            Gov.Lclb.Cllb.Interfaces.BCeIDBusiness bceidBusiness = await _bceid.ProcessBusinessQuery(userSettings.SiteMinderGuid);

            // get the contact record.
            MicrosoftDynamicsCRMcontact userContact = null;

            // see if the contact exists.
            userContact = await _dynamicsClient.GetContactBySiteminderGuid(contactSiteminderGuid);

            if (userContact == null)
            {
                // create the user contact record.
                userContact = new MicrosoftDynamicsCRMcontact();
                // Adoxio_externalid is where we will store the guid from siteminder.
                string sanitizedContactSiteminderId = GuidUtility.SanitizeGuidString(contactSiteminderGuid);
                userContact.AdoxioExternalid = sanitizedContactSiteminderId;
                userContact.Fullname = userSettings.UserDisplayName;
                userContact.Nickname = userSettings.UserDisplayName;
                userContact.Employeeid = userSettings.UserId;

                if (bceidBusiness != null)
                {
                    // set contact according to item
                    userContact.Firstname = bceidBusiness.individualFirstname;
                    userContact.Middlename = bceidBusiness.individualMiddlename;
                    userContact.Lastname = bceidBusiness.individualSurname;
                    userContact.Emailaddress1 = bceidBusiness.contactEmail;
                    userContact.Telephone1 = bceidBusiness.contactPhone;
                }
                else
                {
                    userContact.Firstname = userSettings.UserDisplayName.GetFirstName();
                    userContact.Lastname = userSettings.UserDisplayName.GetLastName();
                }
                userContact.Statuscode = 1;
            }
            // this may be an existing account, as this service is used during the account confirmation process.
            MicrosoftDynamicsCRMaccount account = await _dynamicsClient.GetAccountBySiteminderBusinessGuid(accountSiteminderGuid);

            if (account == null) // do a deep create.  create 3 objects at once.
            {
                // create a new account
                account = new MicrosoftDynamicsCRMaccount();
                account.CopyValues(item, updateIfNull);
                // business type must be set only during creation, not in update (removed from copyValues() )
                account.AdoxioBusinesstype = (int)Enum.Parse(typeof(ViewModels.AdoxioApplicantTypeCodes), item.businessType, true);
                // ensure that we create an account for the current user.

                // by convention we strip out any dashes present in the guid, and force it to uppercase.
                string sanitizedAccountSiteminderId = GuidUtility.SanitizeGuidString(accountSiteminderGuid); 

                account.AdoxioExternalid = sanitizedAccountSiteminderId;
                account.Primarycontactid = userContact;
                account.AdoxioAccounttype = (int)AdoxioAccountTypeCodes.Applicant;

                if (bceidBusiness != null)
                {
                    account.Emailaddress1 = bceidBusiness.contactEmail;
                    account.Telephone1 = bceidBusiness.contactPhone;
                    account.Address1City = bceidBusiness.addressCity;
                    account.Address1Postalcode = bceidBusiness.addressPostal;
                    account.Address1Line1 = bceidBusiness.addressLine1;
                    account.Address1Line2 = bceidBusiness.addressLine2;
                    account.Address1Postalcode = bceidBusiness.addressPostal;
                }

                // sets Business type with numerical value found in Adoxio_applicanttypecodes
                // using account.businessType which is set in bceid-confirmation.component.ts
                account.AdoxioBusinesstype = (int)Enum.Parse(typeof(AdoxioApplicantTypeCodes), item.businessType, true);

                var legalEntity = new MicrosoftDynamicsCRMadoxioLegalentity()
                {
                    AdoxioAccount = account,
                    AdoxioName = item.name,
                    AdoxioIsindividual = 0,
                    AdoxioIsapplicant = true,
                    AdoxioLegalentitytype = account.AdoxioBusinesstype
                };

                string legalEntityString = JsonConvert.SerializeObject(legalEntity);
                _logger.LogError("Legal Entity Before --> " + legalEntityString);

                legalEntity = await _dynamicsClient.Adoxiolegalentities.CreateAsync(legalEntity);

                account.Accountid = legalEntity._adoxioAccountValue;

                // fetch the account and get the created contact.
                if (legalEntity.AdoxioAccount == null)
                {
                    legalEntity.AdoxioAccount = await _dynamicsClient.GetAccountById(Guid.Parse(account.Accountid));
                }

                if (legalEntity.AdoxioAccount.Primarycontactid == null)
                {
                    legalEntity.AdoxioAccount.Primarycontactid = await _dynamicsClient.GetContactById(Guid.Parse(legalEntity.AdoxioAccount._primarycontactidValue));
                }

                userContact.Contactid = legalEntity.AdoxioAccount._primarycontactidValue;

                legalEntityString = JsonConvert.SerializeObject(legalEntity);
                _logger.LogError("Legal Entity After --> " + legalEntityString);

                var tiedHouse = new MicrosoftDynamicsCRMadoxioTiedhouseconnection() { };
                tiedHouse.AccountODataBind = _dynamicsClient.GetEntityURI("accounts", account.Accountid);

                var res = await _dynamicsClient.AdoxioTiedhouseconnections.CreateAsync(tiedHouse);

            }
            else // it is a new user only.
            {
                userContact = await _dynamicsClient.Contacts.CreateAsync(userContact);
            }

            // always patch the userContact so it relates to the account.

            // parent customer id relationship will be created using the method here:
            //https://msdn.microsoft.com/en-us/library/mt607875.aspx
            MicrosoftDynamicsCRMcontact patchUserContact = new MicrosoftDynamicsCRMcontact();
            patchUserContact.ParentCustomerIdAccountODataBind = _dynamicsClient.GetEntityURI("accounts", account.Accountid);
            try
            {
                await _dynamicsClient.Contacts.UpdateAsync(userContact.Contactid, patchUserContact);
            }
            catch (OdataerrorException odee)
            {
                _logger.LogError("Error binding contact to account");
                _logger.LogError("Request:");
                _logger.LogError(odee.Request.Content);
                _logger.LogError("Response:");
                _logger.LogError(odee.Response.Content);
            }

            // if we have not yet authenticated, then this is the new record for the user.
            if (userSettings.IsNewUserRegistration)
            {
                userSettings.AccountId = account.Accountid.ToString();
                userSettings.ContactId = userContact.Contactid.ToString();

                // we can now authenticate.
                if (userSettings.AuthenticatedUser == null)
                {
                    Models.User user = new Models.User();
                    user.Active = true;
                    user.AccountId = Guid.Parse(userSettings.AccountId);
                    user.ContactId = Guid.Parse(userSettings.ContactId);
                    user.SmUserId = userSettings.UserId;
                    userSettings.AuthenticatedUser = user;
                }

                userSettings.IsNewUserRegistration = false;

                string userSettingsString = JsonConvert.SerializeObject(userSettings);
                _logger.LogError("AccountController --> " + userSettingsString);

                // add the user to the session.
                _httpContextAccessor.HttpContext.Session.SetString("UserSettings", userSettingsString);
            }
            else
            {
                throw new Exception("Oops not a new user registration");
            }

            //account.accountId = id;
            result = account.ToViewModel();

            return Json(result);
        }

        /// <summary>
        /// Update a legal entity
        /// </summary>
        /// <param name="item"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDynamicsAccount([FromBody] ViewModels.Account item, string id)
        {
            if (id != item.id)
            {
                return BadRequest();
            }

            // get the legal entity.
            Guid accountId = new Guid(id);

            if (!DynamicsExtensions.CurrentUserHasAccessToAccount(accountId, _httpContextAccessor, _dynamicsClient))
            {
                return NotFound();
            }

            MicrosoftDynamicsCRMaccount adoxioAccount = await _dynamicsClient.GetAccountById(accountId);
            if (adoxioAccount == null)
            {
                return new NotFoundResult();
            }

            // we are doing a patch, so wipe out the record.
            adoxioAccount = new MicrosoftDynamicsCRMaccount();

            // copy values over from the data provided
            adoxioAccount.CopyValues(item);

            await _dynamicsClient.Accounts.UpdateAsync(accountId.ToString(), adoxioAccount);
            return Json(adoxioAccount.ToViewModel());
        }

        /// <summary>
        /// Delete a legal entity.  Using a HTTP Post to avoid Siteminder issues with DELETE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}/delete")]
        public async Task<IActionResult> DeleteDynamicsAccount(string id)
        {
            // verify the currently logged in user has access to this account
            Guid accountId = new Guid(id);
            if (!DynamicsExtensions.CurrentUserHasAccessToAccount(accountId, _httpContextAccessor, _dynamicsClient))
            {
                return new NotFoundResult();
            }

            // get the account
            MicrosoftDynamicsCRMaccount account = await _dynamicsClient.GetAccountById(accountId);
            if (account == null)
            {
                return new NotFoundResult();
            }

            // delete the associated LegalEntity
            string accountFilter = "_adoxio_account_value eq " + id.ToString();
            var legalEntities = _dynamicsClient.Adoxiolegalentities.Get(filter: accountFilter).Value.ToList();
            legalEntities.ForEach(le =>
            {
                _dynamicsClient.Adoxiolegalentities.Delete(le.AdoxioLegalentityid);
            });

            await _dynamicsClient.Accounts.DeleteAsync(accountId.ToString());

            return NoContent(); // 204 
        }
    }
}