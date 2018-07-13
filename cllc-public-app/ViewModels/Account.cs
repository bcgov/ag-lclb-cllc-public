﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Gov.Lclb.Cllb.Public.ViewModels
{

    public enum Adoxio_stateprovince
    {
        [Display(Name = "Alberta")]
        AB = 845280000,
        [Display(Name = "British Columbia")]
        BC,
        [Display(Name = "Manitoba")]
        MN,
        [Display(Name = "New Brunswick")]
        NB,
        [Display(Name = "Newfoundland and Labrador")]
        NL,
        [Display(Name = "Northwest Territories")]
        NT,
        [Display(Name = "Nova Scotia")]
        NS,
        [Display(Name = "Nunavut")]
        NU,
        [Display(Name = "Ontario")]
        ON,
        [Display(Name = "Prince Edward Island")]
        PE,
        [Display(Name = "Quebec")]
        QC,
        [Display(Name = "Saskatchewan")]
        SK,
        [Display(Name = "Yukon")]
        YT
    }

    public class Account
    {
        public string id { get; set; }
        public string name { get; set; } //dynamics = name
        public string description { get; set; } //dynamics = description
        public string externalId { get; set; }
        public string bcIncorporationNumber { get; set; } //dynamics = adoxio_bcincorporationnumber
        public DateTimeOffset? dateOfIncorporationInBC { get; set; } //dynamics = adoxio_dateofincorporationinbc
        public string businessNumber { get; set; } //dynamics = accountnumber
        public string pstNumber { get; set; } //dynamics = adoxio_pstnumber
        public string contactEmail { get; set; } //dynamics = emailaddress1
        public string contactPhone { get; set; } //dynamics = telephone1
        public string mailingAddressName { get; set; } //dynamics = address1_name
        public string mailingAddressStreet { get; set; } //dynamics = address1_line1
        public string mailingAddressCity { get; set; } //dynamics = address1_city
        public string mailingAddressCountry { get; set; } //dynamics = address1_country
        [JsonConverter(typeof(StringEnumConverter))]
        public Adoxio_stateprovince mailingAddressProvince { get; set; } //dynamics = adoxio_stateprovince
        public string mailingAddresPostalCode { get; set; } //dynamics = address1_postalcode

        public ViewModels.Contact primarycontact { get; set; }

        public string businessType { get; set; }

        public bool isCorporateDetailsComplete(Adoxio_applicanttypecodes? legalentitytype)
        {
            var isComplete = false;
            var tiedHouse = new ViewModels.TiedHouseConnection();
            switch (legalentitytype)
            {
                case Adoxio_applicanttypecodes.PrivateCorporation:
                case Adoxio_applicanttypecodes.PublicCorporation:
                case Adoxio_applicanttypecodes.UnlimitedLiabilityCorporation:
                case Adoxio_applicanttypecodes.LimitedLiabilityCorporation:
                case Adoxio_applicanttypecodes.Society:
                    isComplete = !string.IsNullOrEmpty(bcIncorporationNumber) &&
                        !string.IsNullOrEmpty(businessNumber) &&
                        (dateOfIncorporationInBC != null) &&
                        !string.IsNullOrEmpty(contactEmail) &&
                        !string.IsNullOrEmpty(contactPhone) &&
                        !string.IsNullOrEmpty(mailingAddressName) &&
                        !string.IsNullOrEmpty(mailingAddressStreet) &&
                        !string.IsNullOrEmpty(mailingAddressCity) &&
                        !string.IsNullOrEmpty(mailingAddressCountry) &&
                        (mailingAddressProvince != null) // TODO: This field should be a string(by Moffat)
                        &&
                        !string.IsNullOrEmpty(mailingAddresPostalCode);
                    break;
                case Adoxio_applicanttypecodes.SoleProprietor:
                    isComplete = !string.IsNullOrEmpty(businessNumber) &&
                        !string.IsNullOrEmpty(contactEmail) &&
                        !string.IsNullOrEmpty(contactPhone) &&
                        !string.IsNullOrEmpty(mailingAddressName) &&
                        !string.IsNullOrEmpty(mailingAddressStreet) &&
                        !string.IsNullOrEmpty(mailingAddressCity) &&
                        !string.IsNullOrEmpty(mailingAddressCountry) &&
                        (mailingAddressProvince != null) &&
                        !string.IsNullOrEmpty(mailingAddresPostalCode);
                    break;
                case Adoxio_applicanttypecodes.GeneralPartnership:
                case Adoxio_applicanttypecodes.LimitedLiabilityPartnership:
                case Adoxio_applicanttypecodes.LimitedPartnership:
                    isComplete = !string.IsNullOrEmpty(businessNumber) &&
                        !string.IsNullOrEmpty(contactEmail) &&
                        !string.IsNullOrEmpty(contactPhone) &&
                        !string.IsNullOrEmpty(mailingAddressName) &&
                        !string.IsNullOrEmpty(mailingAddressStreet) &&
                        !string.IsNullOrEmpty(mailingAddressCity) &&
                        !string.IsNullOrEmpty(mailingAddressCountry) &&
                        (mailingAddressProvince != null) &&
                        !string.IsNullOrEmpty(mailingAddresPostalCode);
                    break;
                default:
                    isComplete = false;
                    break;
            }
            return isComplete;
        }

    }
}