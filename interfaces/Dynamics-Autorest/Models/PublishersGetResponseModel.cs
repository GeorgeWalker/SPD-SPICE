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
    /// Collection of publishers
    /// </summary>
    public partial class PublishersGetResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the PublishersGetResponseModel class.
        /// </summary>
        public PublishersGetResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublishersGetResponseModel class.
        /// </summary>
        public PublishersGetResponseModel(IList<MicrosoftDynamicsCRMpublisher> value = default(IList<MicrosoftDynamicsCRMpublisher>))
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
        public IList<MicrosoftDynamicsCRMpublisher> Value { get; set; }

    }
}
