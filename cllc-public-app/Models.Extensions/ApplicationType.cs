﻿using Gov.Lclb.Cllb.Interfaces.Models;
using Gov.Lclb.Cllb.Public.ViewModels;
using System.Collections.Generic;

namespace Gov.Lclb.Cllb.Public.Models
{
    /// <summary>
    /// ViewModel transforms.
    /// </summary>
    public static class ApplicationTypeExtensions
    {

        public static ApplicationType ToViewModel(this MicrosoftDynamicsCRMadoxioApplicationtype applicationType)
        {
            ApplicationType result = null;
            if (applicationType != null)
            {
                result = new ApplicationType()
                {
                    ActionText = applicationType.AdoxioActiontext,
                    Category = (ApplicationTypeCategory?)applicationType.AdoxioCategory,
                    ConnectedGroceryStore = (FormControlState?)applicationType.AdoxioConnectedgrocerystore,
                    LGandPoliceSelectors = (FormControlState?)applicationType.AdoxioLgandpoliceselectors,
                    CurrentEstablishmentAddress = (FormControlState?)applicationType.AdoxioCurrentestablishmentaddress,
                    EstablishmentName = (FormControlState?)applicationType.AdoxioEstablishmentname,
                    EstablishmetNameIsReadOnly = applicationType.AdoxioIslockestablishmentname,
                    FloorPlan = (FormControlState?)applicationType.AdoxioFloorplan,
                    FormReference = applicationType.AdoxioFormreference,
                    Id = applicationType.AdoxioApplicationtypeid,
                    
                    Name = applicationType.AdoxioName,
                    NewEstablishmentAddress = (FormControlState?)applicationType.AdoxioNewestablishmentaddress,
                    ProofofZoning = (FormControlState?)applicationType.AdoxioProofofzoning,
                    PublicCooler = (FormControlState?)applicationType.AdoxioPubliccoolerspace,
                    ShowAssociatesFormUpload = applicationType.AdoxioIsshowassociatesformupload,
                    ShowCurrentProperty = applicationType.AdoxioIsshowcurrentproperty,
                    ShowDeclarations = applicationType.AdoxioIsshowdeclarations,
                    ShowDescription1 = applicationType.AdoxioShowdescription1,
                    IsShowLGINApproval = applicationType.AdoxioIsshowlginapproval,
                    ShowFinancialIntegrityFormUpload = applicationType.AdoxioIsshowfinancialintegrityformupload,
                    ShowHoursOfSale = applicationType.AdoxioIsshowhoursofsale,
                    ShowLiquorDeclarations = applicationType.AdoxioIsshowliquordeclarations,
                    ShowLiquorSitePlan = (FormControlState?)applicationType.AdoxioLiquorsiteplan,
                    ShowPropertyDetails = applicationType.AdoxioIsshowpropertydetails,
                    ShowSupportingDocuments = applicationType.AdoxioIsshowsupportingdocuments,
                    Signage = (FormControlState?)applicationType.AdoxioSignage,
                    SitePhotos = (FormControlState?)applicationType.AdoxioSitephotographs,
                    SitePlan = (FormControlState?)applicationType.AdoxioSiteplan,
                    StoreContactInfo = (FormControlState?)applicationType.AdoxioStorecontactinfo,
                    Title = applicationType.AdoxioTitletext,
                    ValidInterest = (FormControlState?)applicationType.AdoxioValidinterest,
                    IsEndorsement = applicationType.AdoxioIsendorsement        
                };

                if (applicationType.AdoxioApplicationtypeAdoxioApplicationtypecontentApplicationType != null)
                {
                    result.ContentTypes = new List<ApplicationTypeContent>();
                    foreach (var content in applicationType.AdoxioApplicationtypeAdoxioApplicationtypecontentApplicationType)
                    {
                        result.ContentTypes.Add(content.ToViewModel());
                    }
                }

                // Normalize is free.
                if (applicationType.AdoxioIsfree != null)
                {
                    if (applicationType.AdoxioIsfree == 845280000)
                    {
                        result.IsFree = true;
                    }
                    else
                    {
                        result.IsFree = false;
                    }
                }




                /*
                if (dynamicsApplicationType.AdoxioLicenceTypeId != null)
                {
                    result.LicenseType = dynamicsApplicationType.AdoxioLicenceTypeId.ToViewModel();
                }
                */
            }


            return result;
        }
    }
}
