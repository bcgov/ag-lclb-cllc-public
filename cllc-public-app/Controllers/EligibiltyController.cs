using Gov.Lclb.Cllb.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Gov.Lclb.Cllb.Public.Authentication;
using Newtonsoft.Json;
using Gov.Lclb.Cllb.Interfaces.Models;
using System;

namespace Gov.Lclb.Cllb.Public.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EligibilityController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IDynamicsClient _dynamicsClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger _logger;
        private readonly IWebHostEnvironment _env;

        public EligibilityController(IConfiguration configuration, IDynamicsClient dynamicsClient, IHttpContextAccessor httpContextAccessor, ILoggerFactory loggerFactory, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _dynamicsClient = dynamicsClient;
            _httpContextAccessor = httpContextAccessor;
            _logger = loggerFactory.CreateLogger(typeof(EligibilityController));
            _env = env;
        }

        public static bool IsEligibilityCheckRequired(string userId, IConfiguration config, IDynamicsClient dynamics)
        {
            if (config["FEATURE_ELIGIBILITY"] == null)
            {
                return false;
            }

            MicrosoftDynamicsCRMaccount account = dynamics.Accounts.GetByKey(userId);
            return account.AdoxioIseligibilitycertified == null;
        }

        /// <summary>
        /// Submit the eligibility form
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        [HttpPost("submit")]
        public async Task<IActionResult> SubmitEligibilityForm([FromBody] ViewModels.EligibilityForm form)
        {
            string sessionSettings = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(sessionSettings);
            if (userSettings.AccountId != null && userSettings.AccountId.Length > 0)
            {
                Guid accountId = new Guid(userSettings.AccountId);
                MicrosoftDynamicsCRMaccount adoxioAccount = await _dynamicsClient.GetAccountByIdAsync(accountId);
                if (adoxioAccount == null)
                {
                    _logger.LogError("Account NOT found.");
                    return new NotFoundResult();
                }
                adoxioAccount = new MicrosoftDynamicsCRMaccount();
                if (form.IsEligibilityCertified)
                {
                    adoxioAccount.AdoxioIsconnectiontounlicensedstore = form.IsConnectedToUnlicencedStore;
                    adoxioAccount.AdoxioNamelocationunlicensedretailer = form.NameLocationUnlicencedRetailer;
                    adoxioAccount.AdoxioIsretailerstilloperating = form.IsRetailerStillOperating;
                    adoxioAccount.AdoxioDateoperationsceased = form.DateOperationsCeased;
                    adoxioAccount.AdoxioIsinvolvedillegaldistribution = form.IsInvolvedIllegalDistribution;
                    adoxioAccount.AdoxioIllegaldistributioninvolvementdetails = form.IllegalDistributionInvolvementDetails;
                    adoxioAccount.AdoxioNamelocationretailer = form.NameLocationRetailer;
                    adoxioAccount.AdoxioIsinvolvementcontinuing = form.IsInvolvementContinuing;
                    adoxioAccount.AdoxioDateinvolvementceased = form.DateInvolvementCeased;
                    adoxioAccount.AdoxioIseligibilitycertified = form.IsEligibilityCertified;
                    adoxioAccount.AdoxioEligibilitysignature = form.EligibilitySignature;
                    adoxioAccount.AdoxioDatesignordismissed = form.DateSignedOrDismissed;
                }
                else
                {
                    adoxioAccount.AdoxioIseligibilitycertified = false;
                    adoxioAccount.AdoxioDatesignordismissed = form.DateSignedOrDismissed;
                }
                _dynamicsClient.Accounts.Update(accountId.ToString(), adoxioAccount);
                return new JsonResult("Ok");
            }
            return new NotFoundResult();
        }
    }
}
