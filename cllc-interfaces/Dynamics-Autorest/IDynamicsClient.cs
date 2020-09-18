// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// This OData service is located at http://localhost
    /// </summary>
    public partial interface IDynamicsClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Show only the first n items
        /// </summary>
        int? Top181 { get; set; }

        /// <summary>
        /// Skip the first n items
        /// </summary>
        int? Skip181 { get; set; }

        /// <summary>
        /// Include count of items
        /// </summary>
        bool? Count181 { get; set; }

        /// <summary>
        /// Filter items by property values
        /// </summary>
        string Filter181 { get; set; }

        /// <summary>
        /// Search items by search phrases
        /// </summary>
        string Search181 { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IAccounts.
        /// </summary>
        IAccounts Accounts { get; }

        /// <summary>
        /// Gets the IPartyidadoxiolocalgovindigenousnation.
        /// </summary>
        IPartyidadoxiolocalgovindigenousnation Partyidadoxiolocalgovindigenousnation { get; }

        /// <summary>
        /// Gets the IAdoxiolicencetypeadoxioinvestigationset.
        /// </summary>
        IAdoxiolicencetypeadoxioinvestigationset Adoxiolicencetypeadoxioinvestigationset { get; }

        /// <summary>
        /// Gets the IAliases.
        /// </summary>
        IAliases Aliases { get; }

        /// <summary>
        /// Gets the IAnnualvolumes.
        /// </summary>
        IAnnualvolumes Annualvolumes { get; }

        /// <summary>
        /// Gets the IApplicationbpfv3s.
        /// </summary>
        IApplicationbpfv3s Applicationbpfv3s { get; }

        /// <summary>
        /// Gets the IApplicationcrsbpfv4s.
        /// </summary>
        IApplicationcrsbpfv4s Applicationcrsbpfv4s { get; }

        /// <summary>
        /// Gets the IApplicationinvoicehistories.
        /// </summary>
        IApplicationinvoicehistories Applicationinvoicehistories { get; }

        /// <summary>
        /// Gets the IApplicationlicenseechangesv10s.
        /// </summary>
        IApplicationlicenseechangesv10s Applicationlicenseechangesv10s { get; }

        /// <summary>
        /// Gets the IApplicationliquorbpfs.
        /// </summary>
        IApplicationliquorbpfs Applicationliquorbpfs { get; }

        /// <summary>
        /// Gets the IApplicationliquorbpfv2s.
        /// </summary>
        IApplicationliquorbpfv2s Applicationliquorbpfv2s { get; }

        /// <summary>
        /// Gets the IApplicationrelocationv1s.
        /// </summary>
        IApplicationrelocationv1s Applicationrelocationv1s { get; }

        /// <summary>
        /// Gets the IApplications.
        /// </summary>
        IApplications Applications { get; }

        /// <summary>
        /// Gets the IApplicationadoxiohoursofserviceapplication.
        /// </summary>
        IApplicationadoxiohoursofserviceapplication Applicationadoxiohoursofserviceapplication { get; }

        /// <summary>
        /// Gets the IPmuarea.
        /// </summary>
        IPmuarea Pmuarea { get; }

        /// <summary>
        /// Gets the IApplicationstructurechangev1s.
        /// </summary>
        IApplicationstructurechangev1s Applicationstructurechangev1s { get; }

        /// <summary>
        /// Gets the IApplicationtermsconditionslimitations.
        /// </summary>
        IApplicationtermsconditionslimitations Applicationtermsconditionslimitations { get; }

        /// <summary>
        /// Gets the IEndorsement.
        /// </summary>
        IEndorsement Endorsement { get; }

        /// <summary>
        /// Gets the IApplicationtransferownershipv1s.
        /// </summary>
        IApplicationtransferownershipv1s Applicationtransferownershipv1s { get; }

        /// <summary>
        /// Gets the IApplicationtypecontents.
        /// </summary>
        IApplicationtypecontents Applicationtypecontents { get; }

        /// <summary>
        /// Gets the IApplicationtypefeeschedules.
        /// </summary>
        IApplicationtypefeeschedules Applicationtypefeeschedules { get; }

        /// <summary>
        /// Gets the IApplicationtypes.
        /// </summary>
        IApplicationtypes Applicationtypes { get; }

        /// <summary>
        /// Gets the IApplicationtypeadoxiohoursofserviceapplicationtype.
        /// </summary>
        IApplicationtypeadoxiohoursofserviceapplicationtype Applicationtypeadoxiohoursofserviceapplicationtype { get; }

        /// <summary>
        /// Gets the IApplicationtypeadoxiohoursofservicesdefaultapplicationtype.
        /// </summary>
        IApplicationtypeadoxiohoursofservicesdefaultapplicationtype Applicationtypeadoxiohoursofservicesdefaultapplicationtype { get; }

        /// <summary>
        /// Gets the IApplicationtypeadoxioproratedlicencefeescheduleapplicationtype.
        /// </summary>
        IApplicationtypeadoxioproratedlicencefeescheduleapplicationtype Applicationtypeadoxioproratedlicencefeescheduleapplicationtype { get; }

        /// <summary>
        /// Gets the IApplicationtypeadoxiotermsconditionslimitationspresetapplicationtype.
        /// </summary>
        IApplicationtypeadoxiotermsconditionslimitationspresetapplicationtype Applicationtypeadoxiotermsconditionslimitationspresetapplicationtype { get; }

        /// <summary>
        /// Gets the IFylicencefeeproduct.
        /// </summary>
        IFylicencefeeproduct Fylicencefeeproduct { get; }

        /// <summary>
        /// Gets the IAreas.
        /// </summary>
        IAreas Areas { get; }

        /// <summary>
        /// Gets the IPmuareaid.
        /// </summary>
        IPmuareaid Pmuareaid { get; }

        /// <summary>
        /// Gets the IAuditlogrequests.
        /// </summary>
        IAuditlogrequests Auditlogrequests { get; }

        /// <summary>
        /// Gets the IBusinessaccounts.
        /// </summary>
        IBusinessaccounts Businessaccounts { get; }

        /// <summary>
        /// Gets the ICannabisinventoryreports.
        /// </summary>
        ICannabisinventoryreports Cannabisinventoryreports { get; }

        /// <summary>
        /// Gets the ICannabismonthlyreports.
        /// </summary>
        ICannabismonthlyreports Cannabismonthlyreports { get; }

        /// <summary>
        /// Gets the ICannabisproductadmins.
        /// </summary>
        ICannabisproductadmins Cannabisproductadmins { get; }

        /// <summary>
        /// Gets the ICitydistricts.
        /// </summary>
        ICitydistricts Citydistricts { get; }

        /// <summary>
        /// Gets the IComplaints.
        /// </summary>
        IComplaints Complaints { get; }

        /// <summary>
        /// Gets the IComplianceinvestigations.
        /// </summary>
        IComplianceinvestigations Complianceinvestigations { get; }

        /// <summary>
        /// Gets the ICompliancemeetings.
        /// </summary>
        ICompliancemeetings Compliancemeetings { get; }

        /// <summary>
        /// Gets the IContraventionadmins.
        /// </summary>
        IContraventionadmins Contraventionadmins { get; }

        /// <summary>
        /// Gets the IContraventions.
        /// </summary>
        IContraventions Contraventions { get; }

        /// <summary>
        /// Gets the ICorporatehistorysummaries.
        /// </summary>
        ICorporatehistorysummaries Corporatehistorysummaries { get; }

        /// <summary>
        /// Gets the ICorporateroles.
        /// </summary>
        ICorporateroles Corporateroles { get; }

        /// <summary>
        /// Gets the ICustomautonumberdefinitions.
        /// </summary>
        ICustomautonumberdefinitions Customautonumberdefinitions { get; }

        /// <summary>
        /// Gets the ICustomautonumberrequests.
        /// </summary>
        ICustomautonumberrequests Customautonumberrequests { get; }

        /// <summary>
        /// Gets the IDocumentadmins.
        /// </summary>
        IDocumentadmins Documentadmins { get; }

        /// <summary>
        /// Gets the IDocuments.
        /// </summary>
        IDocuments Documents { get; }

        /// <summary>
        /// Gets the IEndorsements.
        /// </summary>
        IEndorsements Endorsements { get; }

        /// <summary>
        /// Gets the IEndorsementadoxioapplicationtermsconditionslimitationendorsement.
        /// </summary>
        IEndorsementadoxioapplicationtermsconditionslimitationendorsement Endorsementadoxioapplicationtermsconditionslimitationendorsement { get; }

        /// <summary>
        /// Gets the IEndorsementadoxiohoursofserviceendorsement.
        /// </summary>
        IEndorsementadoxiohoursofserviceendorsement Endorsementadoxiohoursofserviceendorsement { get; }

        /// <summary>
        /// Gets the IEndorsementadoxioserviceareaendorsement.
        /// </summary>
        IEndorsementadoxioserviceareaendorsement Endorsementadoxioserviceareaendorsement { get; }

        /// <summary>
        /// Gets the IEnforcementactionbpfs.
        /// </summary>
        IEnforcementactionbpfs Enforcementactionbpfs { get; }

        /// <summary>
        /// Gets the IEnforcementactions.
        /// </summary>
        IEnforcementactions Enforcementactions { get; }

        /// <summary>
        /// Gets the IEstablishmentincidents.
        /// </summary>
        IEstablishmentincidents Establishmentincidents { get; }

        /// <summary>
        /// Gets the IEstablishments.
        /// </summary>
        IEstablishments Establishments { get; }

        /// <summary>
        /// Gets the IEstablishmentadoxiohoursofserviceestablishment.
        /// </summary>
        IEstablishmentadoxiohoursofserviceestablishment Establishmentadoxiohoursofserviceestablishment { get; }

        /// <summary>
        /// Gets the IEstablishmentwatchwords.
        /// </summary>
        IEstablishmentwatchwords Establishmentwatchwords { get; }

        /// <summary>
        /// Gets the IEvents.
        /// </summary>
        IEvents Events { get; }

        /// <summary>
        /// Gets the IEventschedules.
        /// </summary>
        IEventschedules Eventschedules { get; }

        /// <summary>
        /// Gets the IExhibits.
        /// </summary>
        IExhibits Exhibits { get; }

        /// <summary>
        /// Gets the IFederalreportexports.
        /// </summary>
        IFederalreportexports Federalreportexports { get; }

        /// <summary>
        /// Gets the IFiainvestigationlogs.
        /// </summary>
        IFiainvestigationlogs Fiainvestigationlogs { get; }

        /// <summary>
        /// Gets the IFormelementuploadfields.
        /// </summary>
        IFormelementuploadfields Formelementuploadfields { get; }

        /// <summary>
        /// Gets the IFundingsources.
        /// </summary>
        IFundingsources Fundingsources { get; }

        /// <summary>
        /// Gets the IHoursofservices.
        /// </summary>
        IHoursofservices Hoursofservices { get; }

        /// <summary>
        /// Gets the IApplication.
        /// </summary>
        IApplication Application { get; }

        /// <summary>
        /// Gets the IApplicationtype.
        /// </summary>
        IApplicationtype Applicationtype { get; }

        /// <summary>
        /// Gets the IEstablishment.
        /// </summary>
        IEstablishment Establishment { get; }

        /// <summary>
        /// Gets the IHoursofserviceasyncoperations.
        /// </summary>
        IHoursofserviceasyncoperations Hoursofserviceasyncoperations { get; }

        /// <summary>
        /// Gets the IHoursofservicebulkdeletefailures.
        /// </summary>
        IHoursofservicebulkdeletefailures Hoursofservicebulkdeletefailures { get; }

        /// <summary>
        /// Gets the IHoursofserviceduplicatebaserecord.
        /// </summary>
        IHoursofserviceduplicatebaserecord Hoursofserviceduplicatebaserecord { get; }

        /// <summary>
        /// Gets the IHoursofserviceduplicatematchingrecord.
        /// </summary>
        IHoursofserviceduplicatematchingrecord Hoursofserviceduplicatematchingrecord { get; }

        /// <summary>
        /// Gets the IHoursofservicemailboxtrackingfolders.
        /// </summary>
        IHoursofservicemailboxtrackingfolders Hoursofservicemailboxtrackingfolders { get; }

        /// <summary>
        /// Gets the IHoursofserviceprincipalobjectattributeaccesses.
        /// </summary>
        IHoursofserviceprincipalobjectattributeaccesses Hoursofserviceprincipalobjectattributeaccesses { get; }

        /// <summary>
        /// Gets the IHoursofserviceprocesssession.
        /// </summary>
        IHoursofserviceprocesssession Hoursofserviceprocesssession { get; }

        /// <summary>
        /// Gets the IHoursofservicesyncerrors.
        /// </summary>
        IHoursofservicesyncerrors Hoursofservicesyncerrors { get; }

        /// <summary>
        /// Gets the IInspectionid.
        /// </summary>
        IInspectionid Inspectionid { get; }

        /// <summary>
        /// Gets the ILicence.
        /// </summary>
        ILicence Licence { get; }

        /// <summary>
        /// Gets the IHoursofservicesdefaults.
        /// </summary>
        IHoursofservicesdefaults Hoursofservicesdefaults { get; }

        /// <summary>
        /// Gets the IHoursofservicesdefaultasyncoperations.
        /// </summary>
        IHoursofservicesdefaultasyncoperations Hoursofservicesdefaultasyncoperations { get; }

        /// <summary>
        /// Gets the IHoursofservicesdefaultbulkdeletefailures.
        /// </summary>
        IHoursofservicesdefaultbulkdeletefailures Hoursofservicesdefaultbulkdeletefailures { get; }

        /// <summary>
        /// Gets the IHoursofservicesdefaultmailboxtrackingfolders.
        /// </summary>
        IHoursofservicesdefaultmailboxtrackingfolders Hoursofservicesdefaultmailboxtrackingfolders { get; }

        /// <summary>
        /// Gets the IHoursofservicesdefaultprincipalobjectattributeaccesses.
        /// </summary>
        IHoursofservicesdefaultprincipalobjectattributeaccesses Hoursofservicesdefaultprincipalobjectattributeaccesses { get; }

        /// <summary>
        /// Gets the IHoursofservicesdefaultprocesssession.
        /// </summary>
        IHoursofservicesdefaultprocesssession Hoursofservicesdefaultprocesssession { get; }

        /// <summary>
        /// Gets the IHoursofservicesdefaultsyncerrors.
        /// </summary>
        IHoursofservicesdefaultsyncerrors Hoursofservicesdefaultsyncerrors { get; }

        /// <summary>
        /// Gets the IIncidentadoxiolicencetypeset.
        /// </summary>
        IIncidentadoxiolicencetypeset Incidentadoxiolicencetypeset { get; }

        /// <summary>
        /// Gets the IInspectioninspectorsset.
        /// </summary>
        IInspectioninspectorsset Inspectioninspectorsset { get; }

        /// <summary>
        /// Gets the IInspectionreactivationhistories.
        /// </summary>
        IInspectionreactivationhistories Inspectionreactivationhistories { get; }

        /// <summary>
        /// Gets the IInspectorcommentsrollups.
        /// </summary>
        IInspectorcommentsrollups Inspectorcommentsrollups { get; }

        /// <summary>
        /// Gets the IInterests.
        /// </summary>
        IInterests Interests { get; }

        /// <summary>
        /// Gets the IInvestigationactivities.
        /// </summary>
        IInvestigationactivities Investigationactivities { get; }

        /// <summary>
        /// Gets the IInvestigationreactivationhistories.
        /// </summary>
        IInvestigationreactivationhistories Investigationreactivationhistories { get; }

        /// <summary>
        /// Gets the IInvestigations.
        /// </summary>
        IInvestigations Investigations { get; }

        /// <summary>
        /// Gets the ILdborders.
        /// </summary>
        ILdborders Ldborders { get; }

        /// <summary>
        /// Gets the ILegalentities.
        /// </summary>
        ILegalentities Legalentities { get; }

        /// <summary>
        /// Gets the ILicenceldbordertotalhistories.
        /// </summary>
        ILicenceldbordertotalhistories Licenceldbordertotalhistories { get; }

        /// <summary>
        /// Gets the ILicenceses.
        /// </summary>
        ILicenceses Licenceses { get; }

        /// <summary>
        /// Gets the ILicencesadoxiohoursofservicelicence.
        /// </summary>
        ILicencesadoxiohoursofservicelicence Licencesadoxiohoursofservicelicence { get; }

        /// <summary>
        /// Gets the ILicencesubcategories.
        /// </summary>
        ILicencesubcategories Licencesubcategories { get; }

        /// <summary>
        /// Gets the ILicencefeeproduct.
        /// </summary>
        ILicencefeeproduct Licencefeeproduct { get; }

        /// <summary>
        /// Gets the ILicencesubcategoryadoxioproratedlicencefeeschedulelicencesubcategory.
        /// </summary>
        ILicencesubcategoryadoxioproratedlicencefeeschedulelicencesubcategory Licencesubcategoryadoxioproratedlicencefeeschedulelicencesubcategory { get; }

        /// <summary>
        /// Gets the ILicencetypes.
        /// </summary>
        ILicencetypes Licencetypes { get; }

        /// <summary>
        /// Gets the ILicencetypesapplicationtypesset.
        /// </summary>
        ILicencetypesapplicationtypesset Licencetypesapplicationtypesset { get; }

        /// <summary>
        /// Gets the ILicenseechangelogs.
        /// </summary>
        ILicenseechangelogs Licenseechangelogs { get; }

        /// <summary>
        /// Gets the ILoans.
        /// </summary>
        ILoans Loans { get; }

        /// <summary>
        /// Gets the ILocalgovindigenousnations.
        /// </summary>
        ILocalgovindigenousnations Localgovindigenousnations { get; }

        /// <summary>
        /// Gets the ILocalgovindigenousnationactivityparties.
        /// </summary>
        ILocalgovindigenousnationactivityparties Localgovindigenousnationactivityparties { get; }

        /// <summary>
        /// Gets the IPersonalhistorysummaries.
        /// </summary>
        IPersonalhistorysummaries Personalhistorysummaries { get; }

        /// <summary>
        /// Gets the IPmuareas.
        /// </summary>
        IPmuareas Pmuareas { get; }

        /// <summary>
        /// Gets the IManufacturinginspectorid.
        /// </summary>
        IManufacturinginspectorid Manufacturinginspectorid { get; }

        /// <summary>
        /// Gets the IPmuareaadoxioapplicationpmuarea.
        /// </summary>
        IPmuareaadoxioapplicationpmuarea Pmuareaadoxioapplicationpmuarea { get; }

        /// <summary>
        /// Gets the IPmuareaareas.
        /// </summary>
        IPmuareaareas Pmuareaareas { get; }

        /// <summary>
        /// Gets the IPmuareaasyncoperations.
        /// </summary>
        IPmuareaasyncoperations Pmuareaasyncoperations { get; }

        /// <summary>
        /// Gets the IPmuareabulkdeletefailures.
        /// </summary>
        IPmuareabulkdeletefailures Pmuareabulkdeletefailures { get; }

        /// <summary>
        /// Gets the IPmuareaduplicatebaserecord.
        /// </summary>
        IPmuareaduplicatebaserecord Pmuareaduplicatebaserecord { get; }

        /// <summary>
        /// Gets the IPmuareaduplicatematchingrecord.
        /// </summary>
        IPmuareaduplicatematchingrecord Pmuareaduplicatematchingrecord { get; }

        /// <summary>
        /// Gets the IPmuareainspections.
        /// </summary>
        IPmuareainspections Pmuareainspections { get; }

        /// <summary>
        /// Gets the IPmuarealicences.
        /// </summary>
        IPmuarealicences Pmuarealicences { get; }

        /// <summary>
        /// Gets the IPmuareamailboxtrackingfolders.
        /// </summary>
        IPmuareamailboxtrackingfolders Pmuareamailboxtrackingfolders { get; }

        /// <summary>
        /// Gets the IPmuareamarketevents.
        /// </summary>
        IPmuareamarketevents Pmuareamarketevents { get; }

        /// <summary>
        /// Gets the IPmuareaprincipalobjectattributeaccesses.
        /// </summary>
        IPmuareaprincipalobjectattributeaccesses Pmuareaprincipalobjectattributeaccesses { get; }

        /// <summary>
        /// Gets the IPmuareaprocesssession.
        /// </summary>
        IPmuareaprocesssession Pmuareaprocesssession { get; }

        /// <summary>
        /// Gets the IPmuareasyncerrors.
        /// </summary>
        IPmuareasyncerrors Pmuareasyncerrors { get; }

        /// <summary>
        /// Gets the IPolicejurisdictions.
        /// </summary>
        IPolicejurisdictions Policejurisdictions { get; }

        /// <summary>
        /// Gets the IPolicydocuments.
        /// </summary>
        IPolicydocuments Policydocuments { get; }

        /// <summary>
        /// Gets the IPostalcodes.
        /// </summary>
        IPostalcodes Postalcodes { get; }

        /// <summary>
        /// Gets the IPreviousaddresses.
        /// </summary>
        IPreviousaddresses Previousaddresses { get; }

        /// <summary>
        /// Gets the IProratedlicencefeeschedules.
        /// </summary>
        IProratedlicencefeeschedules Proratedlicencefeeschedules { get; }

        /// <summary>
        /// Gets the ILicencesubcategory.
        /// </summary>
        ILicencesubcategory Licencesubcategory { get; }

        /// <summary>
        /// Gets the IProratedlicencefeescheduleasyncoperations.
        /// </summary>
        IProratedlicencefeescheduleasyncoperations Proratedlicencefeescheduleasyncoperations { get; }

        /// <summary>
        /// Gets the IProratedlicencefeeschedulebulkdeletefailures.
        /// </summary>
        IProratedlicencefeeschedulebulkdeletefailures Proratedlicencefeeschedulebulkdeletefailures { get; }

        /// <summary>
        /// Gets the IProratedlicencefeeschedulemailboxtrackingfolders.
        /// </summary>
        IProratedlicencefeeschedulemailboxtrackingfolders Proratedlicencefeeschedulemailboxtrackingfolders { get; }

        /// <summary>
        /// Gets the IProratedlicencefeescheduleprincipalobjectattributeaccesses.
        /// </summary>
        IProratedlicencefeescheduleprincipalobjectattributeaccesses Proratedlicencefeescheduleprincipalobjectattributeaccesses { get; }

        /// <summary>
        /// Gets the IProratedlicencefeescheduleprocesssession.
        /// </summary>
        IProratedlicencefeescheduleprocesssession Proratedlicencefeescheduleprocesssession { get; }

        /// <summary>
        /// Gets the IProratedlicencefeeschedulesyncerrors.
        /// </summary>
        IProratedlicencefeeschedulesyncerrors Proratedlicencefeeschedulesyncerrors { get; }

        /// <summary>
        /// Gets the IRegions.
        /// </summary>
        IRegions Regions { get; }

        /// <summary>
        /// Gets the IRelatedparties.
        /// </summary>
        IRelatedparties Relatedparties { get; }

        /// <summary>
        /// Gets the IRmreviews.
        /// </summary>
        IRmreviews Rmreviews { get; }

        /// <summary>
        /// Gets the IServiceareas.
        /// </summary>
        IServiceareas Serviceareas { get; }

        /// <summary>
        /// Gets the ISettings.
        /// </summary>
        ISettings Settings { get; }

        /// <summary>
        /// Gets the ISpddatarows.
        /// </summary>
        ISpddatarows Spddatarows { get; }

        /// <summary>
        /// Gets the ISpdexportses.
        /// </summary>
        ISpdexportses Spdexportses { get; }

        /// <summary>
        /// Gets the ITaxandaccountings.
        /// </summary>
        ITaxandaccountings Taxandaccountings { get; }

        /// <summary>
        /// Gets the ITermsconditionslimitationspresets.
        /// </summary>
        ITermsconditionslimitationspresets Termsconditionslimitationspresets { get; }

        /// <summary>
        /// Gets the ITerritories.
        /// </summary>
        ITerritories Territories { get; }

        /// <summary>
        /// Gets the ITiedhouseassociations.
        /// </summary>
        ITiedhouseassociations Tiedhouseassociations { get; }

        /// <summary>
        /// Gets the ITiedhouseconnections.
        /// </summary>
        ITiedhouseconnections Tiedhouseconnections { get; }

        /// <summary>
        /// Gets the IWitnesses.
        /// </summary>
        IWitnesses Witnesses { get; }

        /// <summary>
        /// Gets the IWorkerinvoicehistories.
        /// </summary>
        IWorkerinvoicehistories Workerinvoicehistories { get; }

        /// <summary>
        /// Gets the IWorkers.
        /// </summary>
        IWorkers Workers { get; }

        /// <summary>
        /// Gets the IRegardingobjectidadoxiohoursofservice.
        /// </summary>
        IRegardingobjectidadoxiohoursofservice Regardingobjectidadoxiohoursofservice { get; }

        /// <summary>
        /// Gets the IRegardingobjectidadoxiohoursofservicesdefault.
        /// </summary>
        IRegardingobjectidadoxiohoursofservicesdefault Regardingobjectidadoxiohoursofservicesdefault { get; }

        /// <summary>
        /// Gets the IRegardingobjectidadoxiopmuarea.
        /// </summary>
        IRegardingobjectidadoxiopmuarea Regardingobjectidadoxiopmuarea { get; }

        /// <summary>
        /// Gets the IRegardingobjectidadoxioproratedlicencefeeschedule.
        /// </summary>
        IRegardingobjectidadoxioproratedlicencefeeschedule Regardingobjectidadoxioproratedlicencefeeschedule { get; }

        /// <summary>
        /// Gets the IBusinessunitadoxiohoursofservice.
        /// </summary>
        IBusinessunitadoxiohoursofservice Businessunitadoxiohoursofservice { get; }

        /// <summary>
        /// Gets the IBusinessunitadoxiohoursofservicesdefault.
        /// </summary>
        IBusinessunitadoxiohoursofservicesdefault Businessunitadoxiohoursofservicesdefault { get; }

        /// <summary>
        /// Gets the IBusinessunitadoxiopmuarea.
        /// </summary>
        IBusinessunitadoxiopmuarea Businessunitadoxiopmuarea { get; }

        /// <summary>
        /// Gets the IBusinessunitadoxioproratedlicencefeeschedule.
        /// </summary>
        IBusinessunitadoxioproratedlicencefeeschedule Businessunitadoxioproratedlicencefeeschedule { get; }

        /// <summary>
        /// Gets the IContacts.
        /// </summary>
        IContacts Contacts { get; }

        /// <summary>
        /// Gets the IBaserecordidadoxiohoursofservice.
        /// </summary>
        IBaserecordidadoxiohoursofservice Baserecordidadoxiohoursofservice { get; }

        /// <summary>
        /// Gets the IBaserecordidadoxiopmuarea.
        /// </summary>
        IBaserecordidadoxiopmuarea Baserecordidadoxiopmuarea { get; }

        /// <summary>
        /// Gets the IDuplicaterecordidadoxiohoursofservice.
        /// </summary>
        IDuplicaterecordidadoxiohoursofservice Duplicaterecordidadoxiohoursofservice { get; }

        /// <summary>
        /// Gets the IDuplicaterecordidadoxiopmuarea.
        /// </summary>
        IDuplicaterecordidadoxiopmuarea Duplicaterecordidadoxiopmuarea { get; }

        /// <summary>
        /// Gets the IEntitydefinitions.
        /// </summary>
        IEntitydefinitions Entitydefinitions { get; }

        /// <summary>
        /// Gets the IGlobaloptionsetdefinitions.
        /// </summary>
        IGlobaloptionsetdefinitions Globaloptionsetdefinitions { get; }

        /// <summary>
        /// Gets the IInspectionhoursofservice.
        /// </summary>
        IInspectionhoursofservice Inspectionhoursofservice { get; }

        /// <summary>
        /// Gets the IInvoices.
        /// </summary>
        IInvoices Invoices { get; }

        /// <summary>
        /// Gets the ILeads.
        /// </summary>
        ILeads Leads { get; }

        /// <summary>
        /// Gets the ILists.
        /// </summary>
        ILists Lists { get; }

        /// <summary>
        /// Gets the IObjectidadoxiohoursofservice.
        /// </summary>
        IObjectidadoxiohoursofservice Objectidadoxiohoursofservice { get; }

        /// <summary>
        /// Gets the IObjectidadoxiohoursofservicesdefault.
        /// </summary>
        IObjectidadoxiohoursofservicesdefault Objectidadoxiohoursofservicesdefault { get; }

        /// <summary>
        /// Gets the IObjectidadoxiopmuarea.
        /// </summary>
        IObjectidadoxiopmuarea Objectidadoxiopmuarea { get; }

        /// <summary>
        /// Gets the IObjectidadoxioproratedlicencefeeschedule.
        /// </summary>
        IObjectidadoxioproratedlicencefeeschedule Objectidadoxioproratedlicencefeeschedule { get; }

        /// <summary>
        /// Gets the IProductadoxioapplicationtypefylicencefeeproduct.
        /// </summary>
        IProductadoxioapplicationtypefylicencefeeproduct Productadoxioapplicationtypefylicencefeeproduct { get; }

        /// <summary>
        /// Gets the IProductadoxiolicencesubcategorylicencefeeproduct.
        /// </summary>
        IProductadoxiolicencesubcategorylicencefeeproduct Productadoxiolicencesubcategorylicencefeeproduct { get; }

        /// <summary>
        /// Gets the ISavedqueries.
        /// </summary>
        ISavedqueries Savedqueries { get; }

        /// <summary>
        /// Gets the ISharepointdocumentlocations.
        /// </summary>
        ISharepointdocumentlocations Sharepointdocumentlocations { get; }

        /// <summary>
        /// Gets the ISharepointsites.
        /// </summary>
        ISharepointsites Sharepointsites { get; }

        /// <summary>
        /// Gets the ISystemforms.
        /// </summary>
        ISystemforms Systemforms { get; }

        /// <summary>
        /// Gets the ISystemusers.
        /// </summary>
        ISystemusers Systemusers { get; }

        /// <summary>
        /// Gets the IMfginspectorpmuareas.
        /// </summary>
        IMfginspectorpmuareas Mfginspectorpmuareas { get; }

        /// <summary>
        /// Gets the ILkadoxiohoursofservicecreatedby.
        /// </summary>
        ILkadoxiohoursofservicecreatedby Lkadoxiohoursofservicecreatedby { get; }

        /// <summary>
        /// Gets the ILkadoxiohoursofservicecreatedonbehalfby.
        /// </summary>
        ILkadoxiohoursofservicecreatedonbehalfby Lkadoxiohoursofservicecreatedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxiohoursofservicemodifiedby.
        /// </summary>
        ILkadoxiohoursofservicemodifiedby Lkadoxiohoursofservicemodifiedby { get; }

        /// <summary>
        /// Gets the ILkadoxiohoursofservicemodifiedonbehalfby.
        /// </summary>
        ILkadoxiohoursofservicemodifiedonbehalfby Lkadoxiohoursofservicemodifiedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxiohoursofservicesdefaultcreatedby.
        /// </summary>
        ILkadoxiohoursofservicesdefaultcreatedby Lkadoxiohoursofservicesdefaultcreatedby { get; }

        /// <summary>
        /// Gets the ILkadoxiohoursofservicesdefaultcreatedonbehalfby.
        /// </summary>
        ILkadoxiohoursofservicesdefaultcreatedonbehalfby Lkadoxiohoursofservicesdefaultcreatedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxiohoursofservicesdefaultmodifiedby.
        /// </summary>
        ILkadoxiohoursofservicesdefaultmodifiedby Lkadoxiohoursofservicesdefaultmodifiedby { get; }

        /// <summary>
        /// Gets the ILkadoxiohoursofservicesdefaultmodifiedonbehalfby.
        /// </summary>
        ILkadoxiohoursofservicesdefaultmodifiedonbehalfby Lkadoxiohoursofservicesdefaultmodifiedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxiopmuareacreatedby.
        /// </summary>
        ILkadoxiopmuareacreatedby Lkadoxiopmuareacreatedby { get; }

        /// <summary>
        /// Gets the ILkadoxiopmuareacreatedonbehalfby.
        /// </summary>
        ILkadoxiopmuareacreatedonbehalfby Lkadoxiopmuareacreatedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxiopmuareamodifiedby.
        /// </summary>
        ILkadoxiopmuareamodifiedby Lkadoxiopmuareamodifiedby { get; }

        /// <summary>
        /// Gets the ILkadoxiopmuareamodifiedonbehalfby.
        /// </summary>
        ILkadoxiopmuareamodifiedonbehalfby Lkadoxiopmuareamodifiedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioproratedlicencefeeschedulecreatedby.
        /// </summary>
        ILkadoxioproratedlicencefeeschedulecreatedby Lkadoxioproratedlicencefeeschedulecreatedby { get; }

        /// <summary>
        /// Gets the ILkadoxioproratedlicencefeeschedulecreatedonbehalfby.
        /// </summary>
        ILkadoxioproratedlicencefeeschedulecreatedonbehalfby Lkadoxioproratedlicencefeeschedulecreatedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioproratedlicencefeeschedulemodifiedby.
        /// </summary>
        ILkadoxioproratedlicencefeeschedulemodifiedby Lkadoxioproratedlicencefeeschedulemodifiedby { get; }

        /// <summary>
        /// Gets the ILkadoxioproratedlicencefeeschedulemodifiedonbehalfby.
        /// </summary>
        ILkadoxioproratedlicencefeeschedulemodifiedonbehalfby Lkadoxioproratedlicencefeeschedulemodifiedonbehalfby { get; }

        /// <summary>
        /// Gets the IUseradoxiohoursofservice.
        /// </summary>
        IUseradoxiohoursofservice Useradoxiohoursofservice { get; }

        /// <summary>
        /// Gets the IUseradoxiohoursofservicesdefault.
        /// </summary>
        IUseradoxiohoursofservicesdefault Useradoxiohoursofservicesdefault { get; }

        /// <summary>
        /// Gets the IUseradoxiopmuarea.
        /// </summary>
        IUseradoxiopmuarea Useradoxiopmuarea { get; }

        /// <summary>
        /// Gets the IUseradoxioproratedlicencefeeschedule.
        /// </summary>
        IUseradoxioproratedlicencefeeschedule Useradoxioproratedlicencefeeschedule { get; }

        /// <summary>
        /// Gets the ITeamadoxiohoursofservice.
        /// </summary>
        ITeamadoxiohoursofservice Teamadoxiohoursofservice { get; }

        /// <summary>
        /// Gets the ITeamadoxiohoursofservicesdefault.
        /// </summary>
        ITeamadoxiohoursofservicesdefault Teamadoxiohoursofservicesdefault { get; }

        /// <summary>
        /// Gets the ITeamadoxiopmuarea.
        /// </summary>
        ITeamadoxiopmuarea Teamadoxiopmuarea { get; }

        /// <summary>
        /// Gets the ITeamadoxioproratedlicencefeeschedule.
        /// </summary>
        ITeamadoxioproratedlicencefeeschedule Teamadoxioproratedlicencefeeschedule { get; }

        /// <summary>
        /// Gets the IWorkflows.
        /// </summary>
        IWorkflows Workflows { get; }

    }
}
