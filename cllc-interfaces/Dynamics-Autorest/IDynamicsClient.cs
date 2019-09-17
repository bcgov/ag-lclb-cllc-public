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
    /// This OData service is located at
    /// https://wsgw.dev.jag.gov.bc.ca/clb/crmdev/api/data/v8.2/
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
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IAccounts.
        /// </summary>
        IAccounts Accounts { get; }

        /// <summary>
        /// Gets the ILicencetypeinvestigationset.
        /// </summary>
        ILicencetypeinvestigationset Licencetypeinvestigationset { get; }

        /// <summary>
        /// Gets the IAliases.
        /// </summary>
        IAliases Aliases { get; }

        /// <summary>
        /// Gets the IApplicationbpfmvpv2s.
        /// </summary>
        IApplicationbpfmvpv2s Applicationbpfmvpv2s { get; }

        /// <summary>
        /// Gets the IApplicationbpfv3s.
        /// </summary>
        IApplicationbpfv3s Applicationbpfv3s { get; }

        /// <summary>
        /// Gets the IApplicationinvoicehistories.
        /// </summary>
        IApplicationinvoicehistories Applicationinvoicehistories { get; }

        /// <summary>
        /// Gets the IApplications.
        /// </summary>
        IApplications Applications { get; }

        /// <summary>
        /// Gets the IApplicationtermsconditionslimitations.
        /// </summary>
        IApplicationtermsconditionslimitations Applicationtermsconditionslimitations { get; }

        /// <summary>
        /// Gets the IApplicationtypecontents.
        /// </summary>
        IApplicationtypecontents Applicationtypecontents { get; }

        /// <summary>
        /// Gets the IApplicationtypes.
        /// </summary>
        IApplicationtypes Applicationtypes { get; }

        /// <summary>
        /// Gets the IAreas.
        /// </summary>
        IAreas Areas { get; }

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
        /// Gets the IComplaintpublicbpfs.
        /// </summary>
        IComplaintpublicbpfs Complaintpublicbpfs { get; }

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
        /// Gets the IEstablishments.
        /// </summary>
        IEstablishments Establishments { get; }

        /// <summary>
        /// Gets the IEstablishmentwatchwords.
        /// </summary>
        IEstablishmentwatchwords Establishmentwatchwords { get; }

        /// <summary>
        /// Gets the IFiainvestigationlogs.
        /// </summary>
        IFiainvestigationlogs Fiainvestigationlogs { get; }

        /// <summary>
        /// Gets the IFundingsources.
        /// </summary>
        IFundingsources Fundingsources { get; }

        /// <summary>
        /// Gets the IIncidentlicencetypeset.
        /// </summary>
        IIncidentlicencetypeset Incidentlicencetypeset { get; }

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
        /// Gets the IInvestigations.
        /// </summary>
        IInvestigations Investigations { get; }

        /// <summary>
        /// Gets the ILegalentities.
        /// </summary>
        ILegalentities Legalentities { get; }

        /// <summary>
        /// Gets the ILicenceses.
        /// </summary>
        ILicenceses Licenceses { get; }

        /// <summary>
        /// Gets the ILicencetypes.
        /// </summary>
        ILicencetypes Licencetypes { get; }

        /// <summary>
        /// Gets the ILicencetypesapplicationtypesset.
        /// </summary>
        ILicencetypesapplicationtypesset Licencetypesapplicationtypesset { get; }

        /// <summary>
        /// Gets the ILoans.
        /// </summary>
        ILoans Loans { get; }

        /// <summary>
        /// Gets the ILocalgovindigenousnations.
        /// </summary>
        ILocalgovindigenousnations Localgovindigenousnations { get; }

        /// <summary>
        /// Gets the IPersonalhistorysummaries.
        /// </summary>
        IPersonalhistorysummaries Personalhistorysummaries { get; }

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
        /// Gets the IRegions.
        /// </summary>
        IRegions Regions { get; }

        /// <summary>
        /// Gets the IRelatedparties.
        /// </summary>
        IRelatedparties Relatedparties { get; }

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
        /// Gets the IContacts.
        /// </summary>
        IContacts Contacts { get; }

        /// <summary>
        /// Gets the IInvoices.
        /// </summary>
        IInvoices Invoices { get; }

        /// <summary>
        /// Gets the IMsdynapplicationknowledgearticleset.
        /// </summary>
        IMsdynapplicationknowledgearticleset Msdynapplicationknowledgearticleset { get; }

        /// <summary>
        /// Gets the IMsdynapplicationknowledgebaserecset.
        /// </summary>
        IMsdynapplicationknowledgebaserecset Msdynapplicationknowledgebaserecset { get; }

        /// <summary>
        /// Gets the IMsdynlicencetypeknowledgearticleset.
        /// </summary>
        IMsdynlicencetypeknowledgearticleset Msdynlicencetypeknowledgearticleset { get; }

        /// <summary>
        /// Gets the IMsdynlicencetypeknowledgebaserecset.
        /// </summary>
        IMsdynlicencetypeknowledgebaserecset Msdynlicencetypeknowledgebaserecset { get; }

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

    }
}
