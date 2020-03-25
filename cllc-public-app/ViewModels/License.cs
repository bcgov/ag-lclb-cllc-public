﻿using System;

namespace Gov.Lclb.Cllb.Public.ViewModels
{
    public enum LicenceStatusCodes
    {
        Active = 1,
        Inactive = 2,
        Expired = 845280000,
        Cancelled = 845280001,
        Suspended = 845280002,
        Dormant = 845280003,
        TransferRequested = 845280004,
        PendingFistYearFee = 845280005,
    }

    public class License
    {
        public string id { get; set; }
        public string establishmentId { get; set; }
        public string establishmentName { get; set; }
        public string establishmentEmail { get; set; }
        public string establishmentPhone { get; set; }
        public string establishmentAddress { get; set; }

        public string establishmentAddressStreet { get; set; }
        public string establishmentAddressCity { get; set; }
        public string establishmentAddressPostalCode { get; set; }
        public string establishmentParcelId { get; set; }

        public string licenseStatus { get; set; }
        public string licenseType { get; set; }
        public string licenseNumber { get; set; }
        public string licenseSubCategory {get; set;}
        public DateTimeOffset? expiryDate { get; set; }
    }
}
