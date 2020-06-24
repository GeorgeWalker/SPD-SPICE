// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.entitlementchannel
    /// </summary>
    public partial class MicrosoftDynamicsCRMentitlementchannel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementchannel class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementchannel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementchannel class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementchannel(string _createdbyValue = default(string), decimal? remainingterms = default(decimal?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _organizationidValue = default(string), string _owneridValue = default(string), string _modifiedonbehalfbyValue = default(string), string _transactioncurrencyidValue = default(string), int? timezoneruleversionnumber = default(int?), string _owningbusinessunitValue = default(string), string _modifiedbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string entitlementchannelid = default(string), decimal? exchangerate = default(decimal?), int? channel = default(int?), string _createdonbehalfbyValue = default(string), string name = default(string), decimal? totalterms = default(decimal?), string _owninguserValue = default(string), string _owningteamValue = default(string), string _entitlementidValue = default(string), string versionnumber = default(string), int? importsequencenumber = default(int?), int? utcconversiontimezonecode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), IList<MicrosoftDynamicsCRMsyncerror> entitlementchannelSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMasyncoperation> entitlementchannelAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> entitlementchannelMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> entitlementchannelBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> entitlementchannelPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMconnection> entitlementchannelConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMconnection> entitlementchannelConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMannotation> entitlementchannelAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), MicrosoftDynamicsCRMentitlement entitlementid = default(MicrosoftDynamicsCRMentitlement), IList<MicrosoftDynamicsCRMprocesssession> entitlementchannelProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMduplicaterecord> entitlementchannelDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> entitlementchannelDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>))
        {
            this._createdbyValue = _createdbyValue;
            Remainingterms = remainingterms;
            Modifiedon = modifiedon;
            this._organizationidValue = _organizationidValue;
            this._owneridValue = _owneridValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._modifiedbyValue = _modifiedbyValue;
            Overriddencreatedon = overriddencreatedon;
            Createdon = createdon;
            Entitlementchannelid = entitlementchannelid;
            Exchangerate = exchangerate;
            Channel = channel;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Name = name;
            Totalterms = totalterms;
            this._owninguserValue = _owninguserValue;
            this._owningteamValue = _owningteamValue;
            this._entitlementidValue = _entitlementidValue;
            Versionnumber = versionnumber;
            Importsequencenumber = importsequencenumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            EntitlementchannelSyncErrors = entitlementchannelSyncErrors;
            EntitlementchannelAsyncOperations = entitlementchannelAsyncOperations;
            EntitlementchannelMailboxTrackingFolders = entitlementchannelMailboxTrackingFolders;
            EntitlementchannelBulkDeleteFailures = entitlementchannelBulkDeleteFailures;
            EntitlementchannelPrincipalObjectAttributeAccesses = entitlementchannelPrincipalObjectAttributeAccesses;
            EntitlementchannelConnections1 = entitlementchannelConnections1;
            EntitlementchannelConnections2 = entitlementchannelConnections2;
            EntitlementchannelAnnotations = entitlementchannelAnnotations;
            Entitlementid = entitlementid;
            EntitlementchannelProcessSession = entitlementchannelProcessSession;
            Organizationid = organizationid;
            Transactioncurrencyid = transactioncurrencyid;
            EntitlementchannelDuplicateBaseRecord = entitlementchannelDuplicateBaseRecord;
            EntitlementchannelDuplicateMatchingRecord = entitlementchannelDuplicateMatchingRecord;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "remainingterms")]
        public decimal? Remainingterms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannelid")]
        public string Entitlementchannelid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "channel")]
        public int? Channel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalterms")]
        public decimal? Totalterms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_entitlementid_value")]
        public string _entitlementidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> EntitlementchannelSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> EntitlementchannelAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> EntitlementchannelMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> EntitlementchannelBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> EntitlementchannelPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> EntitlementchannelConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> EntitlementchannelConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> EntitlementchannelAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementid")]
        public MicrosoftDynamicsCRMentitlement Entitlementid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> EntitlementchannelProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EntitlementchannelDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementchannel_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> EntitlementchannelDuplicateMatchingRecord { get; set; }

    }
}
