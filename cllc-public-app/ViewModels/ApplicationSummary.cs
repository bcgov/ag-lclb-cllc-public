﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Gov.Lclb.Cllb.Public.ViewModels
{

    public class ApplicationSummary
    {
        public string Id { get; set; }
        public string ApplicationStatus { get; set; }
        public string EstablishmentName { get; set; } //adoxio_establishmentpropsedname
        public string Name { get; set; } //adoxio_name
        public string JobNumber { get; set; } //adoxio_jobnumber
        public string ApplicationTypeName { get; set; }
        
        [JsonConverter(typeof(StringEnumConverter))]
        public ApplicationTypeCategory? ApplicationTypeCategory { get; set; }
        public bool IsIndigenousNation { get; set; }
        public bool IsPaid { get; set; }
        public string LicenceId { get; set; }
        public string Portallabel { get; set; }
    }
}
