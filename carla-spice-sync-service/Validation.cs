﻿using System.Collections.Generic;
using System.Text.RegularExpressions;
using Gov.Lclb.Cllb.Interfaces;
using Gov.Lclb.Cllb.Interfaces.Spice.Models;
using Microsoft.Extensions.Logging;

namespace Gov.Lclb.Cllb.CarlaSpiceSync
{
    public class Validation
    {
        public static bool ValidatePostalCode(string postalCode)
        {
            if(postalCode == null)
            {
                return false;
            }

            string canadianPattern = @"^[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]$";
            string usPattern = @"^\d{5}(?:[-\s]\d{4})?$";

            bool valid = Regex.IsMatch(postalCode, canadianPattern, RegexOptions.IgnoreCase);
            if (!valid)
            {
                valid = Regex.IsMatch(postalCode, usPattern);
            }
            return valid;
        }

        /// <summary>
        /// Validates the consent of a legal entity list (including all of its children)
        /// </summary>
        /// <returns><c>true</c>, if associate consent was validated, <c>false</c> otherwise.</returns>
        /// <param name="associates">Associates.</param>
        public static bool ValidateAssociateConsent(IDynamicsClient dynamicsClient, List<LegalEntity> associates, ILogger logger)
        {
            /* Validate consent for all associates */
            bool consentValidated = true;
            foreach (var entity in associates)
            {
                if ((bool)entity.IsIndividual)
                {
                    var id = entity.Contact.ContactId;
                    var contact = dynamicsClient.Contacts.Get(filter: "contactid eq " + id).Value[0];
                    if (contact.AdoxioConsentvalidated == null)
                    {
                        consentValidated = false;
                        continue;
                    }

                    if (contact.AdoxioConsentvalidated.HasValue && (ConsentValidated)contact.AdoxioConsentvalidated != ConsentValidated.YES)
                    {
                        logger.LogError($"Consent not validated for associate: {contact.Contactid}");
                        consentValidated = false;
                    }
                }
                else
                {
                    if (!ValidateAssociateConsent(dynamicsClient, (List<LegalEntity>)entity.Account.Associates, logger))
                    {
                        consentValidated = false;
                    }
                }
            }
            return consentValidated;
        }
    }
}
