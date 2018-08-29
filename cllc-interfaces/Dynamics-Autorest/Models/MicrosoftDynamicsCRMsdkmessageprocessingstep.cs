// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMsdkmessageprocessingstep
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessageprocessingstep class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessageprocessingstep()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMsdkmessageprocessingstep class.
        /// </summary>
        public MicrosoftDynamicsCRMsdkmessageprocessingstep(string _modifiedonbehalfbyValue = default(string), string _organizationidValue = default(string), string sdkmessageprocessingstepid = default(string), string _sdkmessagefilteridValue = default(string), string introducedversion = default(string), string _sdkmessageidValue = default(string), int? componentstate = default(int?), string configuration = default(string), int? customizationlevel = default(int?), int? statecode = default(int?), int? mode = default(int?), string _createdonbehalfbyValue = default(string), object overwritetime = default(object), string _modifiedbyValue = default(string), string solutionid = default(string), bool? asyncautodelete = default(bool?), object createdon = default(object), bool? canusereadonlyconnection = default(bool?), MicrosoftDynamicsCRMBooleanManagedProperty ishidden = default(MicrosoftDynamicsCRMBooleanManagedProperty), string _sdkmessageprocessingstepsecureconfigidValue = default(string), string name = default(string), object modifiedon = default(object), int? stage = default(int?), string filteringattributes = default(string), string versionnumber = default(string), int? supporteddeployment = default(int?), bool? ismanaged = default(bool?), string sdkmessageprocessingstepidunique = default(string), string _eventhandlerValue = default(string), int? rank = default(int?), string _impersonatinguseridValue = default(string), int? statuscode = default(int?), string _createdbyValue = default(string), MicrosoftDynamicsCRMBooleanManagedProperty iscustomizable = default(MicrosoftDynamicsCRMBooleanManagedProperty), string description = default(string), MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig sdkmessageprocessingstepsecureconfigid = default(MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig), MicrosoftDynamicsCRMsdkmessage sdkmessageid = default(MicrosoftDynamicsCRMsdkmessage), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsdkmessagefilter sdkmessagefilterid = default(MicrosoftDynamicsCRMsdkmessagefilter), MicrosoftDynamicsCRMsystemuser impersonatinguserid = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMplugintype plugintypeid = default(MicrosoftDynamicsCRMplugintype), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMplugintype eventhandlerPlugintype = default(MicrosoftDynamicsCRMplugintype), IList<MicrosoftDynamicsCRMasyncoperation> sdkMessageProcessingStepAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMsdkmessageprocessingstepimage> sdkmessageprocessingstepidSdkmessageprocessingstepimage = default(IList<MicrosoftDynamicsCRMsdkmessageprocessingstepimage>), MicrosoftDynamicsCRMserviceendpoint eventhandlerServiceendpoint = default(MicrosoftDynamicsCRMserviceendpoint))
        {
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._organizationidValue = _organizationidValue;
            Sdkmessageprocessingstepid = sdkmessageprocessingstepid;
            this._sdkmessagefilteridValue = _sdkmessagefilteridValue;
            Introducedversion = introducedversion;
            this._sdkmessageidValue = _sdkmessageidValue;
            Componentstate = componentstate;
            Configuration = configuration;
            Customizationlevel = customizationlevel;
            Statecode = statecode;
            Mode = mode;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Overwritetime = overwritetime;
            this._modifiedbyValue = _modifiedbyValue;
            Solutionid = solutionid;
            Asyncautodelete = asyncautodelete;
            Createdon = createdon;
            Canusereadonlyconnection = canusereadonlyconnection;
            Ishidden = ishidden;
            this._sdkmessageprocessingstepsecureconfigidValue = _sdkmessageprocessingstepsecureconfigidValue;
            Name = name;
            Modifiedon = modifiedon;
            Stage = stage;
            Filteringattributes = filteringattributes;
            Versionnumber = versionnumber;
            Supporteddeployment = supporteddeployment;
            Ismanaged = ismanaged;
            Sdkmessageprocessingstepidunique = sdkmessageprocessingstepidunique;
            this._eventhandlerValue = _eventhandlerValue;
            Rank = rank;
            this._impersonatinguseridValue = _impersonatinguseridValue;
            Statuscode = statuscode;
            this._createdbyValue = _createdbyValue;
            Iscustomizable = iscustomizable;
            Description = description;
            Sdkmessageprocessingstepsecureconfigid = sdkmessageprocessingstepsecureconfigid;
            Sdkmessageid = sdkmessageid;
            Createdonbehalfby = createdonbehalfby;
            Sdkmessagefilterid = sdkmessagefilterid;
            Impersonatinguserid = impersonatinguserid;
            Organizationid = organizationid;
            Plugintypeid = plugintypeid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            EventhandlerPlugintype = eventhandlerPlugintype;
            SdkMessageProcessingStepAsyncOperations = sdkMessageProcessingStepAsyncOperations;
            Createdby = createdby;
            SdkmessageprocessingstepidSdkmessageprocessingstepimage = sdkmessageprocessingstepidSdkmessageprocessingstepimage;
            EventhandlerServiceendpoint = eventhandlerServiceendpoint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepid")]
        public string Sdkmessageprocessingstepid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_sdkmessagefilterid_value")]
        public string _sdkmessagefilteridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_sdkmessageid_value")]
        public string _sdkmessageidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "configuration")]
        public string Configuration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customizationlevel")]
        public int? Customizationlevel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public int? Mode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public object Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asyncautodelete")]
        public bool? Asyncautodelete { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public object Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "canusereadonlyconnection")]
        public bool? Canusereadonlyconnection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ishidden")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Ishidden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_sdkmessageprocessingstepsecureconfigid_value")]
        public string _sdkmessageprocessingstepsecureconfigidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public object Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stage")]
        public int? Stage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "filteringattributes")]
        public string Filteringattributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "supporteddeployment")]
        public int? Supporteddeployment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepidunique")]
        public string Sdkmessageprocessingstepidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_eventhandler_value")]
        public string _eventhandlerValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_impersonatinguserid_value")]
        public string _impersonatinguseridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iscustomizable")]
        public MicrosoftDynamicsCRMBooleanManagedProperty Iscustomizable { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepsecureconfigid")]
        public MicrosoftDynamicsCRMsdkmessageprocessingstepsecureconfig Sdkmessageprocessingstepsecureconfigid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageid")]
        public MicrosoftDynamicsCRMsdkmessage Sdkmessageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessagefilterid")]
        public MicrosoftDynamicsCRMsdkmessagefilter Sdkmessagefilterid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "impersonatinguserid")]
        public MicrosoftDynamicsCRMsystemuser Impersonatinguserid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "plugintypeid")]
        public MicrosoftDynamicsCRMplugintype Plugintypeid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "eventhandler_plugintype")]
        public MicrosoftDynamicsCRMplugintype EventhandlerPlugintype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SdkMessageProcessingStep_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SdkMessageProcessingStepAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sdkmessageprocessingstepid_sdkmessageprocessingstepimage")]
        public IList<MicrosoftDynamicsCRMsdkmessageprocessingstepimage> SdkmessageprocessingstepidSdkmessageprocessingstepimage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "eventhandler_serviceendpoint")]
        public MicrosoftDynamicsCRMserviceendpoint EventhandlerServiceendpoint { get; set; }

    }
}
