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
    /// Collection of connection
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.connectionCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMconnectionCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMconnectionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMconnectionCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMconnectionCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMconnectionCollection(IList<MicrosoftDynamicsCRMconnection> value = default(IList<MicrosoftDynamicsCRMconnection>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<MicrosoftDynamicsCRMconnection> Value { get; set; }

    }
}
