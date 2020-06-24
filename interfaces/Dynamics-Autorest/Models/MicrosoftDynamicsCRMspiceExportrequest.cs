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
    /// Microsoft.Dynamics.CRM.spice_exportrequest
    /// </summary>
    public partial class MicrosoftDynamicsCRMspiceExportrequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceExportrequest class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceExportrequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMspiceExportrequest class.
        /// </summary>
        public MicrosoftDynamicsCRMspiceExportrequest(bool? spiceToobtainoldestrecords = default(bool?), int? timezoneruleversionnumber = default(int?), string spiceDescription = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdbyValue = default(string), string _owningteamValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), int? spiceChecktype = default(int?), string versionnumber = default(string), string spiceName = default(string), int? statuscode = default(int?), string _owningbusinessunitValue = default(string), string _owninguserValue = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), int? spiceNumberrecordstoretrieve = default(int?), string spiceExportrequestid = default(string), string _modifiedonbehalfbyValue = default(string), int? utcconversiontimezonecode = default(int?), string _owneridValue = default(string), int? statecode = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> spiceExportrequestActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> spiceExportrequestSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> spiceExportrequestDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> spiceExportrequestDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> spiceExportrequestAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> spiceExportrequestMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> spiceExportrequestProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> spiceExportrequestBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> spiceExportrequestPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> spiceExportrequestAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> spiceExportrequestEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> spiceExportrequestFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> spiceExportrequestLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> spiceExportrequestPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> spiceExportrequestTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> spiceExportrequestRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> spiceExportrequestSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMserviceappointment> spiceExportrequestServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMspiceRequiredchecks> spiceExportrequestSpiceRequiredcheckses = default(IList<MicrosoftDynamicsCRMspiceRequiredchecks>), IList<MicrosoftDynamicsCRMincident> spiceExportrequestIncident = default(IList<MicrosoftDynamicsCRMincident>))
        {
            SpiceToobtainoldestrecords = spiceToobtainoldestrecords;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            SpiceDescription = spiceDescription;
            Createdon = createdon;
            this._createdbyValue = _createdbyValue;
            this._owningteamValue = _owningteamValue;
            Overriddencreatedon = overriddencreatedon;
            Importsequencenumber = importsequencenumber;
            SpiceChecktype = spiceChecktype;
            Versionnumber = versionnumber;
            SpiceName = spiceName;
            Statuscode = statuscode;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owninguserValue = _owninguserValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            SpiceNumberrecordstoretrieve = spiceNumberrecordstoretrieve;
            SpiceExportrequestid = spiceExportrequestid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            this._owneridValue = _owneridValue;
            Statecode = statecode;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            SpiceExportrequestActivityPointers = spiceExportrequestActivityPointers;
            SpiceExportrequestSyncErrors = spiceExportrequestSyncErrors;
            SpiceExportrequestDuplicateMatchingRecord = spiceExportrequestDuplicateMatchingRecord;
            SpiceExportrequestDuplicateBaseRecord = spiceExportrequestDuplicateBaseRecord;
            SpiceExportrequestAsyncOperations = spiceExportrequestAsyncOperations;
            SpiceExportrequestMailboxTrackingFolders = spiceExportrequestMailboxTrackingFolders;
            SpiceExportrequestProcessSession = spiceExportrequestProcessSession;
            SpiceExportrequestBulkDeleteFailures = spiceExportrequestBulkDeleteFailures;
            SpiceExportrequestPrincipalObjectAttributeAccesses = spiceExportrequestPrincipalObjectAttributeAccesses;
            SpiceExportrequestAppointments = spiceExportrequestAppointments;
            SpiceExportrequestEmails = spiceExportrequestEmails;
            SpiceExportrequestFaxes = spiceExportrequestFaxes;
            SpiceExportrequestLetters = spiceExportrequestLetters;
            SpiceExportrequestPhoneCalls = spiceExportrequestPhoneCalls;
            SpiceExportrequestTasks = spiceExportrequestTasks;
            SpiceExportrequestRecurringAppointmentMasters = spiceExportrequestRecurringAppointmentMasters;
            SpiceExportrequestSocialActivities = spiceExportrequestSocialActivities;
            SpiceExportrequestServiceAppointments = spiceExportrequestServiceAppointments;
            SpiceExportrequestSpiceRequiredcheckses = spiceExportrequestSpiceRequiredcheckses;
            SpiceExportrequestIncident = spiceExportrequestIncident;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_toobtainoldestrecords")]
        public bool? SpiceToobtainoldestrecords { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_description")]
        public string SpiceDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_checktype")]
        public int? SpiceChecktype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_name")]
        public string SpiceName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_numberrecordstoretrieve")]
        public int? SpiceNumberrecordstoretrieve { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequestid")]
        public string SpiceExportrequestid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

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
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> SpiceExportrequestActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> SpiceExportrequestSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SpiceExportrequestDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> SpiceExportrequestDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> SpiceExportrequestAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> SpiceExportrequestMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> SpiceExportrequestProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> SpiceExportrequestBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> SpiceExportrequestPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> SpiceExportrequestAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_Emails")]
        public IList<MicrosoftDynamicsCRMemail> SpiceExportrequestEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> SpiceExportrequestFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_Letters")]
        public IList<MicrosoftDynamicsCRMletter> SpiceExportrequestLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> SpiceExportrequestPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> SpiceExportrequestTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> SpiceExportrequestRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> SpiceExportrequestSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> SpiceExportrequestServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_spice_requiredcheckses")]
        public IList<MicrosoftDynamicsCRMspiceRequiredchecks> SpiceExportrequestSpiceRequiredcheckses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "spice_exportrequest_incident")]
        public IList<MicrosoftDynamicsCRMincident> SpiceExportrequestIncident { get; set; }

    }
}
