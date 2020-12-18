﻿using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Interfaces.Models;
using Gov.Lclb.Cllb.Public.Authentication;
using Gov.Lclb.Cllb.Public.Models;
using Gov.Lclb.Cllb.Public.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Rest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Gov.Lclb.Cllb.Services.FileManager.FileManager;

namespace Gov.Lclb.Cllb.Public.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class WorkerController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IDynamicsClient _dynamicsClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger _logger;
        private readonly IPdfService _pdfClient;
        private readonly FileManagerClient _fileManagerClient;

        public WorkerController(IConfiguration configuration, IDynamicsClient dynamicsClient, IHttpContextAccessor httpContextAccessor, ILoggerFactory loggerFactory, IPdfService pdfClient, FileManagerClient fileClient)
        {
            _configuration = configuration;
            _dynamicsClient = dynamicsClient;
            _httpContextAccessor = httpContextAccessor;
            _logger = loggerFactory.CreateLogger(typeof(WorkerController));
            _pdfClient = pdfClient;
            _fileManagerClient = fileClient;
        }

        /// <summary>
        /// Get a  workers  associated with the contactId
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        [HttpGet("contact/{contactId}")]
        public async Task<IActionResult> GetWorkers(string contactId)
        {
            List<ViewModels.Worker> results = new List<ViewModels.Worker>();

            if (!CurrentUserHasAccessToContactWorkerApplicationOwnedBy(contactId))
            {
                return NotFound("No access to contact");
            }

            if (!string.IsNullOrEmpty(contactId))
            {
                Guid id = Guid.Parse(contactId);
                // query the Dynamics system to get the contact record.
                string filter = $"_adoxio_contactid_value eq {contactId}";
                var fields = new List<string> { "adoxio_ContactId" };
                List<MicrosoftDynamicsCRMadoxioWorker> workers = _dynamicsClient.Workers.Get(filter: filter, expand: fields).Value.ToList();
                if (workers != null)
                {
                    workers.ForEach(w =>
                    {
                        results.Add(w.ToViewModel());
                    });

                    // if there is not worker verification record, create one
                    if (results.Count() == 0)
                    {

                        // query the Dynamics system to get the contact record.
                        var contact = await _dynamicsClient.GetContactById(id);

                        if (contact != null)
                        {
                            var worker = new ViewModels.Worker
                            {
                                firstname = contact.Firstname,
                                middlename = contact.Middlename,
                                lastname = contact.Lastname,
                                contact = new ViewModels.Contact()
                                {
                                    id = contactId
                                }
                            };
                            worker = await this.CreateWorkerRecord(worker);
                            worker.contact = contact.ToViewModel();
                            results.Add(worker);
                        }
                    }
                }
                else
                {
                    return new NotFoundResult();
                }
            }
            else
            {
                return BadRequest();
            }
            return new JsonResult(results);
        }


        /// <summary>
        /// Get a specific worker
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetWorker(string id)
        {
            ViewModels.Worker result = null;
            if (!string.IsNullOrEmpty(id))
            {
                Guid workerId = Guid.Parse(id);
                // query the Dynamics system to get the contact record.
                string filter = $"adoxio_workerid eq {id}";
                var fields = new List<string> { "adoxio_ContactId" };
                MicrosoftDynamicsCRMadoxioWorker worker = _dynamicsClient.Workers.Get(filter: filter, expand: fields).Value.FirstOrDefault();
                if (worker != null)
                {
                    if (!CurrentUserHasAccessToContactWorkerApplicationOwnedBy(worker?.AdoxioContactId?.Contactid))
                    {
                        return NotFound("No access to worker");
                    }
                    result = worker.ToViewModel();
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return BadRequest();
            }
            return new JsonResult(result);
        }

        /// <summary>
        /// Update a worker
        /// </summary>
        /// <param name="item"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWorker([FromBody] ViewModels.Worker item, string id)
        {
            if (id != null && item.id != null && id != item.id)
            {
                return BadRequest();
            }

            // get the contact
            Guid workerId = Guid.Parse(id);
            string filter = $"adoxio_workerid eq {id}";
            var fields = new List<string> { "adoxio_ContactId" };
            MicrosoftDynamicsCRMadoxioWorker worker = _dynamicsClient.Workers.Get(filter: filter, expand: fields).Value.FirstOrDefault();

            if (worker == null)
            {
                return new NotFoundResult();
            }

            if (!CurrentUserHasAccessToContactWorkerApplicationOwnedBy(worker?.AdoxioContactId?.Contactid))
            {
                return NotFound("No access to worker");
            }

            if (worker.Statuscode != (int)ViewModels.StatusCode.NotSubmitted)
            {
                return BadRequest("Applications with this status cannot be updated");
            }
            MicrosoftDynamicsCRMadoxioWorker patchWorker = new MicrosoftDynamicsCRMadoxioWorker();
            patchWorker.CopyValues(item);
            try
            {
                await _dynamicsClient.Workers.UpdateAsync(worker.AdoxioWorkerid, patchWorker);
            }
            catch (HttpOperationException httpOperationException)
            {
                _logger.LogError(httpOperationException, "Error updating contact");
                throw httpOperationException;
            }
            worker = await _dynamicsClient.GetWorkerById(workerId);
            return new JsonResult(worker.ToViewModel());
        }

        /// <summary>
        /// Create a worker    
        /// </summary>
        /// <param name="viewModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateWorker([FromBody] ViewModels.Worker item)
        {

            if (item?.contact?.id == null)
            {
                return BadRequest();
            }

            ViewModels.Worker worker = await CreateWorkerRecord(item);

            return new JsonResult(worker);
        }

        // creates a worker record and links it to the contact with id = item.contact.id
        private async Task<ViewModels.Worker> CreateWorkerRecord(ViewModels.Worker item)
        {

            if (item?.contact?.id == null)
            {
                throw new ArgumentNullException(nameof(item.contact.id));
            }

            MicrosoftDynamicsCRMadoxioWorker worker = new MicrosoftDynamicsCRMadoxioWorker();
            try
            {
                // create the worker 
                worker.AdoxioIsmanual = 0; // 0 for false - is a portal user.
                worker.CopyValues(item);
                worker = await _dynamicsClient.Workers.CreateAsync(worker).ConfigureAwait(true);

                // add contact reference to the worker record
                var patchWorker = new MicrosoftDynamicsCRMadoxioWorker();
                patchWorker.ContactIdAccountODataBind = _dynamicsClient.GetEntityURI("contacts", item.contact.id);
                await _dynamicsClient.Workers.UpdateAsync(worker.AdoxioWorkerid, patchWorker).ConfigureAwait(true);
                
            }
            catch (HttpOperationException httpOperationException)
            {
                _logger.LogError(httpOperationException, "Error updating worker. ");
                throw;
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Error updating worker.");
                throw;
            }

            var result = worker.ToViewModel();
            return worker.ToViewModel();
        }


        /// <summary>
        /// Delete a Worker.  Using a HTTP Post to avoid Siteminder issues with DELETE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}/delete")]
        public async Task<IActionResult> DeleteWorker(string id)
        {
            string filter = $"adoxio_workerid eq {id}";
            var fields = new List<string> { "adoxio_ContactId" };
            MicrosoftDynamicsCRMadoxioWorker worker = _dynamicsClient.Workers.Get(filter: filter, expand: fields).Value.FirstOrDefault();
            if (worker == null)
            {
                return new NotFoundResult();
            }

            if (!CurrentUserHasAccessToContactWorkerApplicationOwnedBy(worker?.AdoxioContactId?.Contactid))
            {
                return NotFound("No access to worker");
            }
            try
            {
                await _dynamicsClient.Workers.DeleteAsync(id);
            }
            catch (HttpOperationException httpOperationException)
            {
                _logger.LogError(httpOperationException, "Error updating worker. ");
            }


            return NoContent(); // 204
        }

        /// GET a licence as PDF.
        [HttpGet("{workerId}/pdf")]
        public async Task<IActionResult> GetLicencePDF(string workerId)
        {

            var expand = new List<string> {
               "adoxio_ContactId"
            };

            MicrosoftDynamicsCRMadoxioWorker adoxioWorker = _dynamicsClient.Workers.GetByKey(workerId, expand: expand);
            if (adoxioWorker == null)
            {
                _logger.LogError($"Unable to send Worker Qualification Letter for worker {workerId} - unable to get worker record");
                throw new Exception("Error getting worker.");
            }

            if (!CurrentUserHasAccessToContactWorkerApplicationOwnedBy(adoxioWorker?.AdoxioContactId?.Contactid))
            {
                _logger.LogError($"Unable to send Worker Qualification Letter for worker {workerId} - current user does not have access to worker");
                return NotFound("No access to worker");
            }

            try
            {
                var dateOfBirthParam = "";
                if (adoxioWorker.AdoxioDateofbirth.HasValue)
                {
                    DateTime dateOfBirth = adoxioWorker.AdoxioDateofbirth.Value.DateTime;
                    dateOfBirthParam = dateOfBirth.ToString("dd/MM/yyyy");
                }

                var effectiveDateParam = "";
                if (adoxioWorker.AdoxioSecuritycompletedon != null)
                {
                    DateTime effectiveDate = adoxioWorker.AdoxioSecuritycompletedon.Value.DateTime;
                    effectiveDateParam = effectiveDate.ToString("dd/MM/yyyy");
                }

                var expiryDateParam = "";
                if (adoxioWorker.AdoxioExpirydate != null)
                {
                    DateTime expiryDate = adoxioWorker.AdoxioExpirydate.Value.DateTime;
                    expiryDateParam = expiryDate.ToString("dd/MM/yyyy");
                }

                var parameters = new Dictionary<string, string>
                {
                    { "title", "Worker_Qualification" },
                    { "currentDate", DateTime.Now.ToLongDateString() },
                    { "firstName", adoxioWorker.AdoxioFirstname },
                    { "middleName", adoxioWorker.AdoxioMiddlename },
                    { "lastName", adoxioWorker.AdoxioLastname },
                    { "dateOfBirth", dateOfBirthParam },
                    { "address", adoxioWorker.AdoxioContactId.Address1Line1 },
                    { "city", adoxioWorker.AdoxioContactId.Address1City },
                    { "province", adoxioWorker.AdoxioContactId.Address1Stateorprovince},
                    { "postalCode", adoxioWorker.AdoxioContactId.Address1Postalcode},
                    { "effectiveDate", effectiveDateParam },
                    { "expiryDate", expiryDateParam },
                    { "border", "{ \"top\": \"40px\", \"right\": \"40px\", \"bottom\": \"0px\", \"left\": \"40px\" }" }
                };

                byte[] data = await _pdfClient.GetPdf(parameters, "worker_qualification_letter");

                // Save copy of generated licence PDF for auditing/logging purposes
                try
                {
                    var hash = await _pdfClient.GetPdfHash(parameters, "worker_qualification_letter");
                    var entityName = "worker";
                    var entityId = adoxioWorker.AdoxioWorkerid;
                    var folderName = await _dynamicsClient.GetFolderName(entityName, entityId).ConfigureAwait(true);
                    var documentType = "WorkerQualification";
                    _fileManagerClient.UploadPdfIfChanged(_logger, entityName, entityId, folderName, documentType, data, hash);
                }
                catch (Exception e)
                {
                    _logger.LogError(e, "Error uploading PDF");
                }

                _logger.LogInformation($"Sending Worker Qualification Letter for worker {workerId}");
                return File(data, "application/pdf", "WorkerQualificationLetter.pdf");
            }
            catch (Exception e)
            {
                string basePath = string.IsNullOrEmpty(_configuration["BASE_PATH"]) ? "" : _configuration["BASE_PATH"];
                basePath += "/worker-qualification/dashboard";
                _logger.LogError(e, $"Unable to send Worker Qualification Letter for worker {workerId}");
                return Redirect(basePath);
            }
        }

        /// <summary>
        /// Verify whether currently logged in user has access to this account id
        /// </summary>
        /// <returns>boolean</returns>
        private bool CurrentUserHasAccessToWorkerApplicationOwnedBy(string accountId)
        {
            // get the current user.
            UserSettings userSettings = UserSettings.CreateFromHttpContext(_httpContextAccessor);

            // For now, check if the account id matches the user's account.
            // TODO there may be some account relationships in the future
            if (userSettings.AccountId != null && userSettings.AccountId.Length > 0)
            {
                return userSettings.AccountId == accountId;
            }

            // if current user doesn't have an account they are probably not logged in
            return false;
        }

        /// <summary>
        /// Verify whether currently logged in user has access to this account id
        /// </summary>
        /// <returns>boolean</returns>
        private bool CurrentUserHasAccessToContactWorkerApplicationOwnedBy(string contactid)
        {
            // get the current user.
            UserSettings userSettings = UserSettings.CreateFromHttpContext(_httpContextAccessor);

            // For now, check if the account id matches the user's account.
            // TODO there may be some account relationships in the future
            if (userSettings.ContactId != null && userSettings.ContactId.Length > 0)
            {
                return userSettings.ContactId == contactid;
            }

            // if current user doesn't have an account they are probably not logged in
            return false;
        }
    }
}
