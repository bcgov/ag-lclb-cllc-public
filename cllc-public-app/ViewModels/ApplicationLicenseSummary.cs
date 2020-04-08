﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Gov.Lclb.Cllb.Public.ViewModels
{

    public enum InspectionStatus
    {
        Pass = 845280000,
        Fail = 845280001,
        Deficient = 845280002,
        ContraventionsIdentified = 845280003,
        ComplianceDeficiency = 845280004,
        NoContraventions = 845280005,
        Attempted = 845280006,
    }

    public enum LicenseSubCategory
    {
        [EnumMember(Value = "Grocery Store")]
        GroceryStore = 845280000,
        [EnumMember(Value = "Independent Wine Store")]
        IndependentWineStore = 845280001,
        [EnumMember(Value = "Off Site Wine Store")]
        OffSiteWineStore = 845280002,
        [EnumMember(Value = "On Site Wine Store")]
        OnSiteWineStore = 845280003,
        [EnumMember(Value = "Sacramental Wine Store")]
        SacramentalWineStore = 845280004,
        [EnumMember(Value = "Special Wine Store")]
        SpecialWineStore = 845280005,
        [EnumMember(Value = "Tourist Wine Store")]
        TouristWineStore = 845280006,
        [EnumMember(Value = "Wine On Shelf")]
        WineOnShelf = 845280007,
        [EnumMember(Value = "BC VQA Store")]
        BCVQAStore = 845280008

    }

    public enum TransferRequested
    {
        Yes = 845280001,
        No = 845280000
    }

    public enum ApplicationTypeCategory{
        Cannabis = 845280000,
        Liquor = 845280001
    }

    public class ApplicationLicenseSummary
    {
        public string LicenseId { get; set; }
        public string ApplicationId { get; set; }
        public string ApplicationTypeName { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public ApplicationTypeCategory? ApplicationTypeCategory { get; set; }
        public string EstablishmentId {get; set; }
        public string EstablishmentName { get; set; }
        public string EstablishmentAddressStreet { get; set; }
        public string EstablishmentAddressCity { get; set; }
        public string EstablishmentAddressPostalCode { get; set; }

        public string EstablishmentPhoneNumber { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public LicenseSubCategory? LicenseSubCategory { get; set; }

        public string EstablishmentEmail { get; set; }
        public bool? EstablishmentIsOpen { get; set; }
        public string LicenseNumber { get; set; }
        public List<ApplicationType> AllowedActions { get; set; }
        public string LicenceTypeName { get; set; }
        public DateTimeOffset? ExpiryDate { get; set; }

        public string Status { get; set; }

        public bool StoreInspected { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public TransferRequested? TransferRequested { get; set; }

        public string ThirdPartyOperatorAccountName { get; set; }
    }
}
