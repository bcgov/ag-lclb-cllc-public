﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

namespace Gov.Lclb.Cllb.Public.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class FeaturesController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public FeaturesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        /// <summary>
        /// Get a list of enabled features
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public List<string> GetFeatureList()
        {
            var features = new List<string>();
            if (!string.IsNullOrEmpty(_configuration["FEATURE_CRS_RENEWAL"]))
            {
                features.Add("CRS-Renewal");
                features.Add("Liquor-Licence-Renewal");
            }

            if (!string.IsNullOrEmpty(_configuration["FEATURE_INDIGENOUS_NATION"]))
            {
                features.Add("IndigenousNation");
            }

            if (!string.IsNullOrEmpty(_configuration["FEATURE_MAPS"]))
            {
                features.Add("Maps");
            }

            if (!String.IsNullOrEmpty(_configuration["FEATURE_LICENCE_TRANSFER"]))
            {
                features.Add("LicenceTransfer");
            }
            if (!String.IsNullOrEmpty(_configuration["FEATURE_LICENSEE_CHANGES"]))
            {
                features.Add("LicenseeChanges");
            }

            if (!string.IsNullOrEmpty(_configuration["FEATURE_FEDERAL_REPORTING"]))
            {
                features.Add("FederalReporting");
            }

            if (!string.IsNullOrEmpty(_configuration["FEATURE_NO_WET_SIGNATURE"]))
            {
                features.Add("NoWetSignature");
            }

            if (!string.IsNullOrEmpty(_configuration["FEATURE_SECURITY_SCREENING"]))
            {
                features.Add("SecurityScreening");
            }

            if (!string.IsNullOrEmpty(_configuration["FEATURE_DISABLE_LOGIN"]))
            {
                features.Add("DisableLogin");
            }

            if (!string.IsNullOrEmpty(_configuration["FEATURE_LIQUOR_ONE"]))
            {
                features.Add("LiquorOne");
            }

            return features;
        }

    }
}
