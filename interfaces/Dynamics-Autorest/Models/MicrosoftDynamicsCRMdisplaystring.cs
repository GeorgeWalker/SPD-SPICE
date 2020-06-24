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
    /// Microsoft.Dynamics.CRM.displaystring
    /// </summary>
    public partial class MicrosoftDynamicsCRMdisplaystring
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMdisplaystring
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMdisplaystring()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMdisplaystring
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMdisplaystring(string customdisplaystring = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _organizationidValue = default(string), int? languagecode = default(int?), bool? ismanaged = default(bool?), string displaystringid = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string customcomment = default(string), string displaystringidunique = default(string), int? formatparameters = default(int?), string _createdonbehalfbyValue = default(string), string publisheddisplaystring = default(string), string versionnumber = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? componentstate = default(int?), string displaystringkey = default(string), string _modifiedbyValue = default(string), string solutionid = default(string), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMasyncoperation> displayStringAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMbulkdeletefailure> displayStringBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Customdisplaystring = customdisplaystring;
            Modifiedon = modifiedon;
            this._organizationidValue = _organizationidValue;
            Languagecode = languagecode;
            Ismanaged = ismanaged;
            Displaystringid = displaystringid;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdon = createdon;
            Customcomment = customcomment;
            Displaystringidunique = displaystringidunique;
            Formatparameters = formatparameters;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Publisheddisplaystring = publisheddisplaystring;
            Versionnumber = versionnumber;
            Overwritetime = overwritetime;
            this._createdbyValue = _createdbyValue;
            Componentstate = componentstate;
            Displaystringkey = displaystringkey;
            this._modifiedbyValue = _modifiedbyValue;
            Solutionid = solutionid;
            Modifiedonbehalfby = modifiedonbehalfby;
            Createdby = createdby;
            Organizationid = organizationid;
            DisplayStringAsyncOperations = displayStringAsyncOperations;
            Createdonbehalfby = createdonbehalfby;
            DisplayStringBulkDeleteFailures = displayStringBulkDeleteFailures;
            Modifiedby = modifiedby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customdisplaystring")]
        public string Customdisplaystring { get; set; }

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
        [JsonProperty(PropertyName = "languagecode")]
        public int? Languagecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displaystringid")]
        public string Displaystringid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "customcomment")]
        public string Customcomment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displaystringidunique")]
        public string Displaystringidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "formatparameters")]
        public int? Formatparameters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publisheddisplaystring")]
        public string Publisheddisplaystring { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displaystringkey")]
        public string Displaystringkey { get; set; }

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
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayString_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> DisplayStringAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "DisplayString_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> DisplayStringBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

    }
}
