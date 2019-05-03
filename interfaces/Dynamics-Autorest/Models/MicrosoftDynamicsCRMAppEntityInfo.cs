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
    /// AppEntityInfo
    /// </summary>
    public partial class MicrosoftDynamicsCRMAppEntityInfo
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMAppEntityInfo
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMAppEntityInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMAppEntityInfo
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMAppEntityInfo(string entityId = default(string), IList<string> chartIds = default(IList<string>), IList<MicrosoftDynamicsCRMArtifactIdType> forms = default(IList<MicrosoftDynamicsCRMArtifactIdType>), IList<MicrosoftDynamicsCRMArtifactIdType> views = default(IList<MicrosoftDynamicsCRMArtifactIdType>), IList<MicrosoftDynamicsCRMArtifactIdType> entityDashboards = default(IList<MicrosoftDynamicsCRMArtifactIdType>))
        {
            EntityId = entityId;
            ChartIds = chartIds;
            Forms = forms;
            Views = views;
            EntityDashboards = entityDashboards;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityId")]
        public string EntityId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ChartIds")]
        public IList<string> ChartIds { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Forms")]
        public IList<MicrosoftDynamicsCRMArtifactIdType> Forms { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Views")]
        public IList<MicrosoftDynamicsCRMArtifactIdType> Views { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EntityDashboards")]
        public IList<MicrosoftDynamicsCRMArtifactIdType> EntityDashboards { get; set; }

    }
}