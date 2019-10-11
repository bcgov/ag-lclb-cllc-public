﻿using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Interfaces.Models;
using Gov.Lclb.Cllb.Public.Authentication;
using Gov.Lclb.Cllb.Public.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
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
    public class PreviousAddressController : ControllerBase
    {
        private readonly IDynamicsClient _dynamicsClient;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger _logger;

        public PreviousAddressController(IDynamicsClient dynamicsClient, IHttpContextAccessor httpContextAccessor, ILoggerFactory loggerFactory)
        {
            _dynamicsClient = dynamicsClient;
            _httpContextAccessor = httpContextAccessor;
            _logger = loggerFactory.CreateLogger(typeof(PreviousAddressController));
        }


        // /// <summary>
        // /// Get a specific previous address
        // /// </summary>
        // /// <param name="contactId"></param>
        // /// <returns></returns>
        [HttpGet("by-contactid/{contactId}")]
        public IActionResult GetAddressesByContactId(string contactId)
        {
            List<ViewModels.PreviousAddress> result = new List<ViewModels.PreviousAddress>();

            if (!string.IsNullOrEmpty(contactId))
            {
                // query the Dynamics system to get the Address record.
                List<MicrosoftDynamicsCRMadoxioPreviousaddress> addresses = _dynamicsClient.GetPreviousAddressByContactId(contactId);
                addresses.Sort((a, b) =>
                {
                    var res = 0;
                    if (a.AdoxioFromdate < b.AdoxioFromdate)
                    {
                        res = 1;
                    }
                    if (a.AdoxioFromdate > b.AdoxioFromdate)
                    {
                        res = -1;
                    }
                    return res;
                });

                if (addresses != null)
                {
                    addresses.ForEach(a =>
                    {
                        result.Add(a.ToViewModel());
                    });
                }
            }
            else
            {
                return BadRequest();
            }

            return new JsonResult(result);
        }


        // /// <summary>
        // /// Update a legal entity
        // /// </summary>
        // /// <param name="item"></param>
        // /// <param name="id"></param>
        // /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAddress([FromBody] ViewModels.PreviousAddress item, string id)
        {
            if (id != null && item.id != null && id != item.id)
            {
                return BadRequest();
            }

            // get the Address
            MicrosoftDynamicsCRMadoxioPreviousaddress Address = await _dynamicsClient.GetPreviousAddressById(id);
            if (Address == null)
            {
                return new NotFoundResult();
            }
            MicrosoftDynamicsCRMadoxioPreviousaddress patchAddress = new MicrosoftDynamicsCRMadoxioPreviousaddress();
            patchAddress.CopyValues(item);
            try
            {
                await _dynamicsClient.Previousaddresses.UpdateAsync(id, patchAddress);
            }
            catch (HttpOperationException httpOperationException)
            {
                _logger.LogError(httpOperationException, "Error updating Address");
            }

            Address = await _dynamicsClient.GetPreviousAddressById(id);
            return new JsonResult(Address.ToViewModel());
        }

        // /// <summary>
        // /// Create a Address
        // /// </summary>
        // /// <param name="viewModel"></param>
        // /// <returns></returns>
        [HttpPost()]
        public async Task<IActionResult> CreateAddress([FromBody] ViewModels.PreviousAddress item)
        {

            // for association with current user
            string userJson = _httpContextAccessor.HttpContext.Session.GetString("UserSettings");
            UserSettings userSettings = JsonConvert.DeserializeObject<UserSettings>(userJson);

            MicrosoftDynamicsCRMadoxioPreviousaddress address = new MicrosoftDynamicsCRMadoxioPreviousaddress();
            // copy received values to Dynamics Application
            address.CopyValues(item);
            try
            {
                address = _dynamicsClient.Previousaddresses.Create(address);
            }
            catch (HttpOperationException httpOperationException)
            {
                _logger.LogError(httpOperationException, "Error creating application");
                // fail if we can't create.
                throw (httpOperationException);
            }


            MicrosoftDynamicsCRMadoxioPreviousaddress patchAddress = new MicrosoftDynamicsCRMadoxioPreviousaddress();

            // set contact and worker associations
            try
            {
                var contact = _dynamicsClient.GetContactById(Guid.Parse(item.contactId));
                patchAddress.ContactIdODataBind = _dynamicsClient.GetEntityURI("contacts", item.contactId);

                var worker = _dynamicsClient.GetWorkerById(Guid.Parse(item.workerId));
                patchAddress.WorkerIdODataBind = _dynamicsClient.GetEntityURI("adoxio_workers", item.workerId);

                await _dynamicsClient.Previousaddresses.UpdateAsync(address.AdoxioPreviousaddressid, patchAddress);
            }
            catch (HttpOperationException httpOperationException)
            {
                _logger.LogError(httpOperationException, "Error updating application");
                // fail if we can't create.
                throw (httpOperationException);
            }

            return new JsonResult(address.ToViewModel());
        }

        /// <summary>
        /// Delete an Address.  Using a HTTP Post to avoid Siteminder issues with DELETE
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("{id}/delete")]
        public async Task<IActionResult> DeleteAddress(string id)
        {
            MicrosoftDynamicsCRMadoxioPreviousaddress address = await _dynamicsClient.GetPreviousAddressById(id);
            if (address == null)
            {
                return new NotFoundResult();
            }

            await _dynamicsClient.Previousaddresses.DeleteAsync(id);

            return NoContent(); // 204
        }
    }
}
