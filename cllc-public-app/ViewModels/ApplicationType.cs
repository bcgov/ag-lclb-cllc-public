﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace Gov.Lclb.Cllb.Public.ViewModels
{
    public enum FormControlState
    {
        No,
        Yes,
        Readonly
    }

    public class ApplicationType
    {
        public string Id { get; set; }
        public string ActionText { get; set; }
        public string Name { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ApplicationTypeCategory? Category { get; set; }
        public string Title { get; set; }

        public bool? ShowPropertyDetails { get; set; }
        public bool? ShowCurrentProperty { get; set; }
        public bool? ShowHoursOfSale { get; set; }
        public bool? ShowAssociatesFormUpload { get; set; }
        public bool? ShowFinancialIntegrityFormUpload { get; set; }
        public bool? ShowSupportingDocuments { get; set; }
        public bool? ShowDeclarations { get; set; }
        public bool? EstablishmetNameIsReadOnly { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? StoreContactInfo { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? EstablishmentName { get; set; }
        /// <summary>
        /// Reference to the Systemform entity in Dynamics that holds the meta data for the form.
        /// </summary>
        public string FormReference { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? NewEstablishmentAddress { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? CurrentEstablishmentAddress { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? Signage { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? ValidInterest { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? FloorPlan { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? SitePlan { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? ShowLiquorSitePlan { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? SitePhotos { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? ConnectedGroceryStore { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? ProofofZoning { get; set; }


        [JsonConverter(typeof(StringEnumConverter))]
        public FormControlState? PublicCooler { get; set; }

        public bool? ShowLiquorDeclarations { get; set; }
        
        public bool? ShowDescription1 { get; set; }

        public LicenseType LicenseType { get; set; }

        public List<ApplicationTypeContent> ContentTypes { get; set; }

        public bool? IsFree { get; set; }

        public Form DynamicsForm { get; set; }
    }
}
