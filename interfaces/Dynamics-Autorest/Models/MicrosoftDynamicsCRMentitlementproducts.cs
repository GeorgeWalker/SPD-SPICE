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
    /// Microsoft.Dynamics.CRM.entitlementproducts
    /// </summary>
    public partial class MicrosoftDynamicsCRMentitlementproducts
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementproducts class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementproducts()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMentitlementproducts class.
        /// </summary>
        public MicrosoftDynamicsCRMentitlementproducts(string name = default(string), string entitlementproductid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string entitlementid = default(string), int? utcconversiontimezonecode = default(int?), int? importsequencenumber = default(int?), int? timezoneruleversionnumber = default(int?), string productid = default(string), string versionnumber = default(string), IList<MicrosoftDynamicsCRMasyncoperation> entitlementproductsAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> entitlementproductsMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMbulkdeletefailure> entitlementproductsBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> entitlementproductsPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            Name = name;
            Entitlementproductid = entitlementproductid;
            Overriddencreatedon = overriddencreatedon;
            Entitlementid = entitlementid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Importsequencenumber = importsequencenumber;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Productid = productid;
            Versionnumber = versionnumber;
            EntitlementproductsAsyncOperations = entitlementproductsAsyncOperations;
            EntitlementproductsMailboxTrackingFolders = entitlementproductsMailboxTrackingFolders;
            EntitlementproductsBulkDeleteFailures = entitlementproductsBulkDeleteFailures;
            EntitlementproductsPrincipalObjectAttributeAccesses = entitlementproductsPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementproductid")]
        public string Entitlementproductid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementid")]
        public string Entitlementid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "productid")]
        public string Productid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementproducts_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> EntitlementproductsAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementproducts_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> EntitlementproductsMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementproducts_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> EntitlementproductsBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitlementproducts_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> EntitlementproductsPrincipalObjectAttributeAccesses { get; set; }

    }
}
