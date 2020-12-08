﻿using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Interfaces.Models;
using Gov.Lclb.Cllb.Public.Authentication;
using Gov.Lclb.Cllb.Public.Models;
using Gov.Lclb.Cllb.Public.Utils;
using Gov.Lclb.Cllb.Public.ViewModels;
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
using System.Threading.Tasks;

namespace Gov.Lclb.Cllb.Public.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class InvoiceController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IDynamicsClient _dynamicsClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger _logger;

        public InvoiceController(IConfiguration configuration, IHttpContextAccessor httpContextAccessor, ILoggerFactory loggerFactory, IDynamicsClient dynamicsClient)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _dynamicsClient = dynamicsClient;
            _logger = loggerFactory.CreateLogger(typeof(InvoiceController));
        }

        /// <summary>
        /// Get all Invoices
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetInvoices()
        {
            if (TestUtility.InUnitTestMode())
            {
                List<Invoice> result = new List<Invoice>();
                IEnumerable<MicrosoftDynamicsCRMinvoice> invoices = null;

                invoices = _dynamicsClient.Invoices.Get().Value;

                foreach (var invoice in invoices)
                {
                    result.Add(invoice.ToViewModel());
                }

                return new JsonResult(result);
            }
            return new NotFoundResult();
        }


        /// <summary>
        /// Get a specific invoice
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInvoice(string id)
        {
            if (TestUtility.InUnitTestMode())
            {
                Invoice result = null;
                // query the Dynamics system to get the invoice record.
                if (string.IsNullOrEmpty(id))
                {
                    return new NotFoundResult();
                }

                // get the current user.
                UserSettings userSettings = UserSettings.CreateFromHttpContext(_httpContextAccessor);

                Guid adoxio_legalentityid = new Guid(id);
                MicrosoftDynamicsCRMinvoice invoice = await _dynamicsClient.GetInvoiceById(adoxio_legalentityid);
                if (invoice == null)
                {
                    return new NotFoundResult();
                }

                // setup the related account.
                if (invoice._accountidValue != null)
                {
                    Guid accountId = Guid.Parse(invoice._accountidValue);
                    invoice.CustomeridAccount = await _dynamicsClient.GetAccountByIdAsync(accountId);
                }

                result = invoice.ToViewModel();

                return new JsonResult(result);
            }
            return new NotFoundResult();
        }


        /// <summary>
        /// Create a invoice
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateInvoice([FromBody] Invoice item)
        {
            if (TestUtility.InUnitTestMode())
            {
                // create a new invoice.
                MicrosoftDynamicsCRMinvoice invoice = new MicrosoftDynamicsCRMinvoice();

                // get the current user.
                UserSettings userSettings = UserSettings.CreateFromHttpContext(_httpContextAccessor);
                // check that the session is setup correctly.
                userSettings.Validate();
                // copy received values to Dynamics LegalEntity
                invoice.CopyValues(item);
                try
                {
                    invoice = await _dynamicsClient.Invoices.CreateAsync(invoice);
                }
                catch (HttpOperationException httpOperationException)
                {
                    _logger.LogError(httpOperationException, "Error creating invoice");
                    throw new Exception("Unable to create invoice");
                }

                // setup navigation properties.
                MicrosoftDynamicsCRMinvoice patchEntity = new MicrosoftDynamicsCRMinvoice();
                Guid accountId = Guid.Parse(userSettings.AccountId);
                var userAccount = await _dynamicsClient.GetAccountByIdAsync(accountId);
                patchEntity.CustomerIdAccountODataBind = _dynamicsClient.GetEntityURI("accounts", accountId.ToString());

                // patch the record.
                try
                {
                    await _dynamicsClient.Invoices.UpdateAsync(invoice.Invoiceid, patchEntity);
                    // setup the view model.
                    invoice.CustomeridAccount = userAccount;
                }
                catch (HttpOperationException httpOperationException)
                {
                    _logger.LogError(httpOperationException, "Error patching invoice");
                }

                return new JsonResult(invoice.ToViewModel());
            }
            return new NotFoundResult();
        }

        /// <summary>
        /// Update a invoice
        /// </summary>
        /// <param name="item"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateInvoice([FromBody] Invoice item, string id)
        {
            if (TestUtility.InUnitTestMode())
            {
                if (id != item.id)
                {
                    return BadRequest();
                }

                // get the invoice.
                Guid adoxio_legalentityid = new Guid(id);

                MicrosoftDynamicsCRMinvoice invoice = await _dynamicsClient.GetInvoiceById(adoxio_legalentityid);
                if (invoice == null)
                {
                    return new NotFoundResult();
                }

                // we are doing a patch, so wipe out the record.
                invoice = new MicrosoftDynamicsCRMinvoice();

                // copy values over from the data provided
                invoice.CopyValues(item);

                await _dynamicsClient.Invoices.UpdateAsync(adoxio_legalentityid.ToString(), invoice);
                return new JsonResult(invoice.ToViewModel());
            }
            return new NotFoundResult();
        }

        /// <summary>
        /// Delete a invoice.  Using a HTTP Post to avoid Siteminder issues with DELETE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}/delete")]
        public async Task<IActionResult> DeleteInvoice(string id)
        {
            if (TestUtility.InUnitTestMode())
            {
                // get the invoice.
                Guid adoxio_legalentityid = new Guid(id);
                MicrosoftDynamicsCRMinvoice legalEntity = await _dynamicsClient.GetInvoiceById(adoxio_legalentityid);
                if (legalEntity == null)
                {
                    return new NotFoundResult();
                }
                try
                {
                    await _dynamicsClient.Invoices.DeleteAsync(adoxio_legalentityid.ToString());
                    return NoContent(); // 204
                }
                catch (HttpOperationException httpOperationException)
                {
                    _logger.LogError(httpOperationException, "Error deleteing invoice");
                }
            }
            return new NotFoundResult();
        }
    }
}
