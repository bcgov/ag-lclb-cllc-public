namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Auto Generated
    /// </summary>
    public partial interface IDynamicsClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri NativeBaseUri { get; set; }

        string GetEntityURI(string entityType, string id);

        string GetCreatedRecord(HttpOperationException httpOperationException, string errorMessage);

        Task<MicrosoftDynamicsCRMadoxioApplication> GetApplicationById(Guid id);
        Task<MicrosoftDynamicsCRMadoxioApplication> GetApplicationById(string id);

        Task<MicrosoftDynamicsCRMadoxioApplication> GetApplicationByIdWithChildren(Guid id);
        Task<MicrosoftDynamicsCRMadoxioApplication> GetApplicationByIdWithChildren(string id);

        MicrosoftDynamicsCRMadoxioLicencetype GetAdoxioLicencetypeById(Guid id);
        MicrosoftDynamicsCRMadoxioLicencetype GetAdoxioLicencetypeById(string id);

        Task<MicrosoftDynamicsCRMaccount> GetAccountByIdAsync(Guid id);
        MicrosoftDynamicsCRMaccount GetAccountById(Guid id);
        MicrosoftDynamicsCRMaccount GetAccountById(string id);
        MicrosoftDynamicsCRMaccount GetAccountByIdWithChildren(string id);

        MicrosoftDynamicsCRMaccount GetAccountByNameWithEstablishments(string name);
        Task<MicrosoftDynamicsCRMcontact> GetContactById(Guid id);
        Task<MicrosoftDynamicsCRMcontact> GetContactById(string id);

        MicrosoftDynamicsCRMadoxioEstablishment GetEstablishmentById(Guid id);
        MicrosoftDynamicsCRMadoxioEstablishment GetEstablishmentById(string id);

        MicrosoftDynamicsCRMadoxioLocalgovindigenousnation GetLginById(string id);
        Task<MicrosoftDynamicsCRMadoxioWorker> GetWorkerById(string id);
        Task<MicrosoftDynamicsCRMadoxioWorker> GetWorkerById(Guid id);

        Task<MicrosoftDynamicsCRMadoxioWorker> GetWorkerByIdWithChildren(string id);

        MicrosoftDynamicsCRMadoxioLicences GetLicenceByIdWithChildren(Guid id);
        MicrosoftDynamicsCRMadoxioLicences GetLicenceByIdWithChildren(string id);

        MicrosoftDynamicsCRMadoxioEvent GetEventByIdWithChildren(string id);
        MicrosoftDynamicsCRMadoxioEvent GetEventById(string id);
        MicrosoftDynamicsCRMadoxioEvent GetEventById(Guid id);
        MicrosoftDynamicsCRMadoxioEventscheduleCollection GetEventSchedulesByEventId(string id);
       
    }
}
