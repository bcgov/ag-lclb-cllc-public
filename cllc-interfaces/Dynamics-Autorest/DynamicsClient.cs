// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;

    /// <summary>
    /// This OData service is located at http://localhost
    /// </summary>
    public partial class DynamicsClient : ServiceClient<DynamicsClient>, IDynamicsClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        public System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        /// <summary>
        /// Show only the first n items
        /// </summary>
        public int? Top90 { get; set; }

        /// <summary>
        /// Skip the first n items
        /// </summary>
        public int? Skip17 { get; set; }

        /// <summary>
        /// Include count of items
        /// </summary>
        public bool? Count90 { get; set; }

        /// <summary>
        /// Filter items by property values
        /// </summary>
        public string Filter90 { get; set; }

        /// <summary>
        /// Search items by search phrases
        /// </summary>
        public string Search17 { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client subscription.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Gets the IAccounts.
        /// </summary>
        public virtual IAccounts Accounts { get; private set; }

        /// <summary>
        /// Gets the IAdoxiolicencetypeadoxioinvestigationset.
        /// </summary>
        public virtual IAdoxiolicencetypeadoxioinvestigationset Adoxiolicencetypeadoxioinvestigationset { get; private set; }

        /// <summary>
        /// Gets the IAliases.
        /// </summary>
        public virtual IAliases Aliases { get; private set; }

        /// <summary>
        /// Gets the IApplicationbpfmvpv2s.
        /// </summary>
        public virtual IApplicationbpfmvpv2s Applicationbpfmvpv2s { get; private set; }

        /// <summary>
        /// Gets the IApplicationbpfv3s.
        /// </summary>
        public virtual IApplicationbpfv3s Applicationbpfv3s { get; private set; }

        /// <summary>
        /// Gets the IApplicationinvoicehistories.
        /// </summary>
        public virtual IApplicationinvoicehistories Applicationinvoicehistories { get; private set; }

        /// <summary>
        /// Gets the IApplications.
        /// </summary>
        public virtual IApplications Applications { get; private set; }

        /// <summary>
        /// Gets the IApplicationtermsconditionslimitations.
        /// </summary>
        public virtual IApplicationtermsconditionslimitations Applicationtermsconditionslimitations { get; private set; }

        /// <summary>
        /// Gets the IApplicationtypecontents.
        /// </summary>
        public virtual IApplicationtypecontents Applicationtypecontents { get; private set; }

        /// <summary>
        /// Gets the IApplicationtypes.
        /// </summary>
        public virtual IApplicationtypes Applicationtypes { get; private set; }

        /// <summary>
        /// Gets the IAreas.
        /// </summary>
        public virtual IAreas Areas { get; private set; }

        /// <summary>
        /// Gets the IAuditlogrequests.
        /// </summary>
        public virtual IAuditlogrequests Auditlogrequests { get; private set; }

        /// <summary>
        /// Gets the IBusinessaccounts.
        /// </summary>
        public virtual IBusinessaccounts Businessaccounts { get; private set; }

        /// <summary>
        /// Gets the ICannabisinventoryreports.
        /// </summary>
        public virtual ICannabisinventoryreports Cannabisinventoryreports { get; private set; }

        /// <summary>
        /// Gets the ICannabismonthlyreports.
        /// </summary>
        public virtual ICannabismonthlyreports Cannabismonthlyreports { get; private set; }

        /// <summary>
        /// Gets the ICannabisproductadmins.
        /// </summary>
        public virtual ICannabisproductadmins Cannabisproductadmins { get; private set; }

        /// <summary>
        /// Gets the ICitydistricts.
        /// </summary>
        public virtual ICitydistricts Citydistricts { get; private set; }

        /// <summary>
        /// Gets the IComplaintpublicbpfs.
        /// </summary>
        public virtual IComplaintpublicbpfs Complaintpublicbpfs { get; private set; }

        /// <summary>
        /// Gets the IComplaints.
        /// </summary>
        public virtual IComplaints Complaints { get; private set; }

        /// <summary>
        /// Gets the IComplianceinvestigations.
        /// </summary>
        public virtual IComplianceinvestigations Complianceinvestigations { get; private set; }

        /// <summary>
        /// Gets the IInvestigationexhibits.
        /// </summary>
        public virtual IInvestigationexhibits Investigationexhibits { get; private set; }

        /// <summary>
        /// Gets the ICompliancemeetings.
        /// </summary>
        public virtual ICompliancemeetings Compliancemeetings { get; private set; }

        /// <summary>
        /// Gets the ICompliancemeetingrelatedparties.
        /// </summary>
        public virtual ICompliancemeetingrelatedparties Compliancemeetingrelatedparties { get; private set; }

        /// <summary>
        /// Gets the IContraventionadmins.
        /// </summary>
        public virtual IContraventionadmins Contraventionadmins { get; private set; }

        /// <summary>
        /// Gets the IContraventions.
        /// </summary>
        public virtual IContraventions Contraventions { get; private set; }

        /// <summary>
        /// Gets the ICorporatehistorysummaries.
        /// </summary>
        public virtual ICorporatehistorysummaries Corporatehistorysummaries { get; private set; }

        /// <summary>
        /// Gets the ICorporateroles.
        /// </summary>
        public virtual ICorporateroles Corporateroles { get; private set; }

        /// <summary>
        /// Gets the ICustomautonumberdefinitions.
        /// </summary>
        public virtual ICustomautonumberdefinitions Customautonumberdefinitions { get; private set; }

        /// <summary>
        /// Gets the ICustomautonumberrequests.
        /// </summary>
        public virtual ICustomautonumberrequests Customautonumberrequests { get; private set; }

        /// <summary>
        /// Gets the IDocumentadmins.
        /// </summary>
        public virtual IDocumentadmins Documentadmins { get; private set; }

        /// <summary>
        /// Gets the IDocuments.
        /// </summary>
        public virtual IDocuments Documents { get; private set; }

        /// <summary>
        /// Gets the IEstablishments.
        /// </summary>
        public virtual IEstablishments Establishments { get; private set; }

        /// <summary>
        /// Gets the IEstablishmentwatchwords.
        /// </summary>
        public virtual IEstablishmentwatchwords Establishmentwatchwords { get; private set; }

        /// <summary>
        /// Gets the IExhibits.
        /// </summary>
        public virtual IExhibits Exhibits { get; private set; }

        /// <summary>
        /// Gets the IExhibitasyncoperations.
        /// </summary>
        public virtual IExhibitasyncoperations Exhibitasyncoperations { get; private set; }

        /// <summary>
        /// Gets the IExhibitbulkdeletefailures.
        /// </summary>
        public virtual IExhibitbulkdeletefailures Exhibitbulkdeletefailures { get; private set; }

        /// <summary>
        /// Gets the IExhibitduplicatebaserecord.
        /// </summary>
        public virtual IExhibitduplicatebaserecord Exhibitduplicatebaserecord { get; private set; }

        /// <summary>
        /// Gets the IExhibitduplicatematchingrecord.
        /// </summary>
        public virtual IExhibitduplicatematchingrecord Exhibitduplicatematchingrecord { get; private set; }

        /// <summary>
        /// Gets the IExhibitsyncerrors.
        /// </summary>
        public virtual IExhibitsyncerrors Exhibitsyncerrors { get; private set; }

        /// <summary>
        /// Gets the IInvestigationid.
        /// </summary>
        public virtual IInvestigationid Investigationid { get; private set; }

        /// <summary>
        /// Gets the IFiainvestigationlogs.
        /// </summary>
        public virtual IFiainvestigationlogs Fiainvestigationlogs { get; private set; }

        /// <summary>
        /// Gets the IFundingsources.
        /// </summary>
        public virtual IFundingsources Fundingsources { get; private set; }

        /// <summary>
        /// Gets the IIncidentadoxiolicencetypeset.
        /// </summary>
        public virtual IIncidentadoxiolicencetypeset Incidentadoxiolicencetypeset { get; private set; }

        /// <summary>
        /// Gets the IInspectioninspectorsset.
        /// </summary>
        public virtual IInspectioninspectorsset Inspectioninspectorsset { get; private set; }

        /// <summary>
        /// Gets the IInspectionreactivationhistories.
        /// </summary>
        public virtual IInspectionreactivationhistories Inspectionreactivationhistories { get; private set; }

        /// <summary>
        /// Gets the IInspectorcommentsrollups.
        /// </summary>
        public virtual IInspectorcommentsrollups Inspectorcommentsrollups { get; private set; }

        /// <summary>
        /// Gets the IInterests.
        /// </summary>
        public virtual IInterests Interests { get; private set; }

        /// <summary>
        /// Gets the IInvestigationactivities.
        /// </summary>
        public virtual IInvestigationactivities Investigationactivities { get; private set; }

        /// <summary>
        /// Gets the IInvestigationreactivationhistories.
        /// </summary>
        public virtual IInvestigationreactivationhistories Investigationreactivationhistories { get; private set; }

        /// <summary>
        /// Gets the IInvestigations.
        /// </summary>
        public virtual IInvestigations Investigations { get; private set; }

        /// <summary>
        /// Gets the ILegalentities.
        /// </summary>
        public virtual ILegalentities Legalentities { get; private set; }

        /// <summary>
        /// Gets the ILegalentitytasklegalentity.
        /// </summary>
        public virtual ILegalentitytasklegalentity Legalentitytasklegalentity { get; private set; }

        /// <summary>
        /// Gets the ILicenceses.
        /// </summary>
        public virtual ILicenceses Licenceses { get; private set; }

        /// <summary>
        /// Gets the ILicencetypes.
        /// </summary>
        public virtual ILicencetypes Licencetypes { get; private set; }

        /// <summary>
        /// Gets the ILicencetypesapplicationtypesset.
        /// </summary>
        public virtual ILicencetypesapplicationtypesset Licencetypesapplicationtypesset { get; private set; }

        /// <summary>
        /// Gets the ILicenseechangelogs.
        /// </summary>
        public virtual ILicenseechangelogs Licenseechangelogs { get; private set; }

        /// <summary>
        /// Gets the ILoans.
        /// </summary>
        public virtual ILoans Loans { get; private set; }

        /// <summary>
        /// Gets the ILocalgovindigenousnations.
        /// </summary>
        public virtual ILocalgovindigenousnations Localgovindigenousnations { get; private set; }

        /// <summary>
        /// Gets the IPersonalhistorysummaries.
        /// </summary>
        public virtual IPersonalhistorysummaries Personalhistorysummaries { get; private set; }

        /// <summary>
        /// Gets the IPolicejurisdictions.
        /// </summary>
        public virtual IPolicejurisdictions Policejurisdictions { get; private set; }

        /// <summary>
        /// Gets the IPolicydocuments.
        /// </summary>
        public virtual IPolicydocuments Policydocuments { get; private set; }

        /// <summary>
        /// Gets the IPostalcodes.
        /// </summary>
        public virtual IPostalcodes Postalcodes { get; private set; }

        /// <summary>
        /// Gets the IPreviousaddresses.
        /// </summary>
        public virtual IPreviousaddresses Previousaddresses { get; private set; }

        /// <summary>
        /// Gets the IRegions.
        /// </summary>
        public virtual IRegions Regions { get; private set; }

        /// <summary>
        /// Gets the IRelatedparties.
        /// </summary>
        public virtual IRelatedparties Relatedparties { get; private set; }

        /// <summary>
        /// Gets the ICompliancemeetingid.
        /// </summary>
        public virtual ICompliancemeetingid Compliancemeetingid { get; private set; }

        /// <summary>
        /// Gets the ISettings.
        /// </summary>
        public virtual ISettings Settings { get; private set; }

        /// <summary>
        /// Gets the ISpddatarows.
        /// </summary>
        public virtual ISpddatarows Spddatarows { get; private set; }

        /// <summary>
        /// Gets the ISpdexportses.
        /// </summary>
        public virtual ISpdexportses Spdexportses { get; private set; }

        /// <summary>
        /// Gets the ITaxandaccountings.
        /// </summary>
        public virtual ITaxandaccountings Taxandaccountings { get; private set; }

        /// <summary>
        /// Gets the ITermsconditionslimitationspresets.
        /// </summary>
        public virtual ITermsconditionslimitationspresets Termsconditionslimitationspresets { get; private set; }

        /// <summary>
        /// Gets the ITerritories.
        /// </summary>
        public virtual ITerritories Territories { get; private set; }

        /// <summary>
        /// Gets the ITiedhouseassociations.
        /// </summary>
        public virtual ITiedhouseassociations Tiedhouseassociations { get; private set; }

        /// <summary>
        /// Gets the ITiedhouseconnections.
        /// </summary>
        public virtual ITiedhouseconnections Tiedhouseconnections { get; private set; }

        /// <summary>
        /// Gets the IWitnesses.
        /// </summary>
        public virtual IWitnesses Witnesses { get; private set; }

        /// <summary>
        /// Gets the IWorkerinvoicehistories.
        /// </summary>
        public virtual IWorkerinvoicehistories Workerinvoicehistories { get; private set; }

        /// <summary>
        /// Gets the IWorkers.
        /// </summary>
        public virtual IWorkers Workers { get; private set; }

        /// <summary>
        /// Gets the IRegardingobjectidadoxioexhibit.
        /// </summary>
        public virtual IRegardingobjectidadoxioexhibit Regardingobjectidadoxioexhibit { get; private set; }

        /// <summary>
        /// Gets the IBusinessunitadoxioexhibit.
        /// </summary>
        public virtual IBusinessunitadoxioexhibit Businessunitadoxioexhibit { get; private set; }

        /// <summary>
        /// Gets the IContacts.
        /// </summary>
        public virtual IContacts Contacts { get; private set; }

        /// <summary>
        /// Gets the IBaserecordidadoxioexhibit.
        /// </summary>
        public virtual IBaserecordidadoxioexhibit Baserecordidadoxioexhibit { get; private set; }

        /// <summary>
        /// Gets the IDuplicaterecordidadoxioexhibit.
        /// </summary>
        public virtual IDuplicaterecordidadoxioexhibit Duplicaterecordidadoxioexhibit { get; private set; }

        /// <summary>
        /// Gets the IEntitydefinitions.
        /// </summary>
        public virtual IEntitydefinitions Entitydefinitions { get; private set; }

        /// <summary>
        /// Gets the IGlobaloptionsetdefinitions.
        /// </summary>
        public virtual IGlobaloptionsetdefinitions Globaloptionsetdefinitions { get; private set; }

        /// <summary>
        /// Gets the IInvoices.
        /// </summary>
        public virtual IInvoices Invoices { get; private set; }

        /// <summary>
        /// Gets the ILeads.
        /// </summary>
        public virtual ILeads Leads { get; private set; }

        /// <summary>
        /// Gets the ISavedqueries.
        /// </summary>
        public virtual ISavedqueries Savedqueries { get; private set; }

        /// <summary>
        /// Gets the ISharepointdocumentlocations.
        /// </summary>
        public virtual ISharepointdocumentlocations Sharepointdocumentlocations { get; private set; }

        /// <summary>
        /// Gets the ISharepointsites.
        /// </summary>
        public virtual ISharepointsites Sharepointsites { get; private set; }

        /// <summary>
        /// Gets the ILkadoxioexhibitcreatedby.
        /// </summary>
        public virtual ILkadoxioexhibitcreatedby Lkadoxioexhibitcreatedby { get; private set; }

        /// <summary>
        /// Gets the ILkadoxioexhibitcreatedonbehalfby.
        /// </summary>
        public virtual ILkadoxioexhibitcreatedonbehalfby Lkadoxioexhibitcreatedonbehalfby { get; private set; }

        /// <summary>
        /// Gets the ILkadoxioexhibitmodifiedby.
        /// </summary>
        public virtual ILkadoxioexhibitmodifiedby Lkadoxioexhibitmodifiedby { get; private set; }

        /// <summary>
        /// Gets the ILkadoxioexhibitmodifiedonbehalfby.
        /// </summary>
        public virtual ILkadoxioexhibitmodifiedonbehalfby Lkadoxioexhibitmodifiedonbehalfby { get; private set; }

        /// <summary>
        /// Gets the IUseradoxioexhibit.
        /// </summary>
        public virtual IUseradoxioexhibit Useradoxioexhibit { get; private set; }

        /// <summary>
        /// Gets the ILegalentitytask.
        /// </summary>
        public virtual ILegalentitytask Legalentitytask { get; private set; }

        /// <summary>
        /// Gets the ITeamadoxioexhibit.
        /// </summary>
        public virtual ITeamadoxioexhibit Teamadoxioexhibit { get; private set; }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling DynamicsClient.Dispose(). False: will not dispose provided httpClient</param>
        protected DynamicsClient(HttpClient httpClient, bool disposeHttpClient) : base(httpClient, disposeHttpClient)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected DynamicsClient(params DelegatingHandler[] handlers) : base(handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected DynamicsClient(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers)
        {
            Initialize();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected DynamicsClient(System.Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        protected DynamicsClient(System.Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            BaseUri = baseUri;
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='httpClient'>
        /// HttpClient to be used
        /// </param>
        /// <param name='disposeHttpClient'>
        /// True: will dispose the provided httpClient on calling DynamicsClient.Dispose(). False: will not dispose provided httpClient</param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(ServiceClientCredentials credentials, HttpClient httpClient, bool disposeHttpClient) : this(httpClient, disposeHttpClient)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(System.Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the DynamicsClient class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when a required parameter is null
        /// </exception>
        public DynamicsClient(System.Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            if (baseUri == null)
            {
                throw new System.ArgumentNullException("baseUri");
            }
            if (credentials == null)
            {
                throw new System.ArgumentNullException("credentials");
            }
            BaseUri = baseUri;
            Credentials = credentials;
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// An optional partial-method to perform custom initialization.
        ///</summary>
        partial void CustomInitialize();
        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            Accounts = new Accounts(this);
            Adoxiolicencetypeadoxioinvestigationset = new Adoxiolicencetypeadoxioinvestigationset(this);
            Aliases = new Aliases(this);
            Applicationbpfmvpv2s = new Applicationbpfmvpv2s(this);
            Applicationbpfv3s = new Applicationbpfv3s(this);
            Applicationinvoicehistories = new Applicationinvoicehistories(this);
            Applications = new Applications(this);
            Applicationtermsconditionslimitations = new Applicationtermsconditionslimitations(this);
            Applicationtypecontents = new Applicationtypecontents(this);
            Applicationtypes = new Applicationtypes(this);
            Areas = new Areas(this);
            Auditlogrequests = new Auditlogrequests(this);
            Businessaccounts = new Businessaccounts(this);
            Cannabisinventoryreports = new Cannabisinventoryreports(this);
            Cannabismonthlyreports = new Cannabismonthlyreports(this);
            Cannabisproductadmins = new Cannabisproductadmins(this);
            Citydistricts = new Citydistricts(this);
            Complaintpublicbpfs = new Complaintpublicbpfs(this);
            Complaints = new Complaints(this);
            Complianceinvestigations = new Complianceinvestigations(this);
            Investigationexhibits = new Investigationexhibits(this);
            Compliancemeetings = new Compliancemeetings(this);
            Compliancemeetingrelatedparties = new Compliancemeetingrelatedparties(this);
            Contraventionadmins = new Contraventionadmins(this);
            Contraventions = new Contraventions(this);
            Corporatehistorysummaries = new Corporatehistorysummaries(this);
            Corporateroles = new Corporateroles(this);
            Customautonumberdefinitions = new Customautonumberdefinitions(this);
            Customautonumberrequests = new Customautonumberrequests(this);
            Documentadmins = new Documentadmins(this);
            Documents = new Documents(this);
            Establishments = new Establishments(this);
            Establishmentwatchwords = new Establishmentwatchwords(this);
            Exhibits = new Exhibits(this);
            Exhibitasyncoperations = new Exhibitasyncoperations(this);
            Exhibitbulkdeletefailures = new Exhibitbulkdeletefailures(this);
            Exhibitduplicatebaserecord = new Exhibitduplicatebaserecord(this);
            Exhibitduplicatematchingrecord = new Exhibitduplicatematchingrecord(this);
            Exhibitsyncerrors = new Exhibitsyncerrors(this);
            Investigationid = new Investigationid(this);
            Fiainvestigationlogs = new Fiainvestigationlogs(this);
            Fundingsources = new Fundingsources(this);
            Incidentadoxiolicencetypeset = new Incidentadoxiolicencetypeset(this);
            Inspectioninspectorsset = new Inspectioninspectorsset(this);
            Inspectionreactivationhistories = new Inspectionreactivationhistories(this);
            Inspectorcommentsrollups = new Inspectorcommentsrollups(this);
            Interests = new Interests(this);
            Investigationactivities = new Investigationactivities(this);
            Investigationreactivationhistories = new Investigationreactivationhistories(this);
            Investigations = new Investigations(this);
            Legalentities = new Legalentities(this);
            Legalentitytasklegalentity = new Legalentitytasklegalentity(this);
            Licenceses = new Licenceses(this);
            Licencetypes = new Licencetypes(this);
            Licencetypesapplicationtypesset = new Licencetypesapplicationtypesset(this);
            Licenseechangelogs = new Licenseechangelogs(this);
            Loans = new Loans(this);
            Localgovindigenousnations = new Localgovindigenousnations(this);
            Personalhistorysummaries = new Personalhistorysummaries(this);
            Policejurisdictions = new Policejurisdictions(this);
            Policydocuments = new Policydocuments(this);
            Postalcodes = new Postalcodes(this);
            Previousaddresses = new Previousaddresses(this);
            Regions = new Regions(this);
            Relatedparties = new Relatedparties(this);
            Compliancemeetingid = new Compliancemeetingid(this);
            Settings = new Settings(this);
            Spddatarows = new Spddatarows(this);
            Spdexportses = new Spdexportses(this);
            Taxandaccountings = new Taxandaccountings(this);
            Termsconditionslimitationspresets = new Termsconditionslimitationspresets(this);
            Territories = new Territories(this);
            Tiedhouseassociations = new Tiedhouseassociations(this);
            Tiedhouseconnections = new Tiedhouseconnections(this);
            Witnesses = new Witnesses(this);
            Workerinvoicehistories = new Workerinvoicehistories(this);
            Workers = new Workers(this);
            Regardingobjectidadoxioexhibit = new Regardingobjectidadoxioexhibit(this);
            Businessunitadoxioexhibit = new Businessunitadoxioexhibit(this);
            Contacts = new Contacts(this);
            Baserecordidadoxioexhibit = new Baserecordidadoxioexhibit(this);
            Duplicaterecordidadoxioexhibit = new Duplicaterecordidadoxioexhibit(this);
            Entitydefinitions = new Entitydefinitions(this);
            Globaloptionsetdefinitions = new Globaloptionsetdefinitions(this);
            Invoices = new Invoices(this);
            Leads = new Leads(this);
            Savedqueries = new Savedqueries(this);
            Sharepointdocumentlocations = new Sharepointdocumentlocations(this);
            Sharepointsites = new Sharepointsites(this);
            Lkadoxioexhibitcreatedby = new Lkadoxioexhibitcreatedby(this);
            Lkadoxioexhibitcreatedonbehalfby = new Lkadoxioexhibitcreatedonbehalfby(this);
            Lkadoxioexhibitmodifiedby = new Lkadoxioexhibitmodifiedby(this);
            Lkadoxioexhibitmodifiedonbehalfby = new Lkadoxioexhibitmodifiedonbehalfby(this);
            Useradoxioexhibit = new Useradoxioexhibit(this);
            Legalentitytask = new Legalentitytask(this);
            Teamadoxioexhibit = new Teamadoxioexhibit(this);
            BaseUri = new System.Uri("http://localhost");
            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new  List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Utc,
                NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                    {
                        new Iso8601TimeSpanConverter()
                    }
            };
            CustomInitialize();
        }
    }
}
