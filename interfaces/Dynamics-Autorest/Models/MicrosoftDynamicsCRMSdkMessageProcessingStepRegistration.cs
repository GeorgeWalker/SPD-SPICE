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
    /// SdkMessageProcessingStepRegistration
    /// </summary>
    public partial class MicrosoftDynamicsCRMSdkMessageProcessingStepRegistration
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMSdkMessageProcessingStepRegistration class.
        /// </summary>
        public MicrosoftDynamicsCRMSdkMessageProcessingStepRegistration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMSdkMessageProcessingStepRegistration class.
        /// </summary>
        public MicrosoftDynamicsCRMSdkMessageProcessingStepRegistration(string messageName = default(string), string primaryEntityName = default(string), string secondaryEntityName = default(string), string description = default(string), int? stage = default(int?), int? mode = default(int?), string impersonatingUserId = default(string), int? supportedDeployment = default(int?), string filteringAttributes = default(string), string pluginTypeFriendlyName = default(string), string pluginTypeName = default(string), string customConfiguration = default(string), int? invocationSource = default(int?), IList<MicrosoftDynamicsCRMSdkMessageProcessingStepImageRegistration> images = default(IList<MicrosoftDynamicsCRMSdkMessageProcessingStepImageRegistration>))
        {
            MessageName = messageName;
            PrimaryEntityName = primaryEntityName;
            SecondaryEntityName = secondaryEntityName;
            Description = description;
            Stage = stage;
            Mode = mode;
            ImpersonatingUserId = impersonatingUserId;
            SupportedDeployment = supportedDeployment;
            FilteringAttributes = filteringAttributes;
            PluginTypeFriendlyName = pluginTypeFriendlyName;
            PluginTypeName = pluginTypeName;
            CustomConfiguration = customConfiguration;
            InvocationSource = invocationSource;
            Images = images;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MessageName")]
        public string MessageName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrimaryEntityName")]
        public string PrimaryEntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SecondaryEntityName")]
        public string SecondaryEntityName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Stage")]
        public int? Stage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Mode")]
        public int? Mode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImpersonatingUserId")]
        public string ImpersonatingUserId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SupportedDeployment")]
        public int? SupportedDeployment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FilteringAttributes")]
        public string FilteringAttributes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PluginTypeFriendlyName")]
        public string PluginTypeFriendlyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PluginTypeName")]
        public string PluginTypeName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CustomConfiguration")]
        public string CustomConfiguration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "InvocationSource")]
        public int? InvocationSource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Images")]
        public IList<MicrosoftDynamicsCRMSdkMessageProcessingStepImageRegistration> Images { get; set; }

    }
}