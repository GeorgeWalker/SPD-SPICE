// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Jag.Spice.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ComplexMoneyAttributeMetadata
    /// </summary>
    public partial class MicrosoftDynamicsCRMComplexMoneyAttributeMetadata
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexMoneyAttributeMetadata class.
        /// </summary>
        public MicrosoftDynamicsCRMComplexMoneyAttributeMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMComplexMoneyAttributeMetadata class.
        /// </summary>
        /// <param name="imeMode">Possible values include: 'Auto', 'Inactive',
        /// 'Active', 'Disabled'</param>
        public MicrosoftDynamicsCRMComplexMoneyAttributeMetadata(string imeMode = default(string), double? maxValue = default(double?), double? minValue = default(double?), int? precision = default(int?), int? precisionSource = default(int?), string calculationOf = default(string), string formulaDefinition = default(string), int? sourceTypeMask = default(int?), bool? isBaseCurrency = default(bool?))
        {
            ImeMode = imeMode;
            MaxValue = maxValue;
            MinValue = minValue;
            Precision = precision;
            PrecisionSource = precisionSource;
            CalculationOf = calculationOf;
            FormulaDefinition = formulaDefinition;
            SourceTypeMask = sourceTypeMask;
            IsBaseCurrency = isBaseCurrency;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'Auto', 'Inactive', 'Active',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "ImeMode")]
        public string ImeMode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MaxValue")]
        public double? MaxValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "MinValue")]
        public double? MinValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Precision")]
        public int? Precision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PrecisionSource")]
        public int? PrecisionSource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "CalculationOf")]
        public string CalculationOf { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FormulaDefinition")]
        public string FormulaDefinition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SourceTypeMask")]
        public int? SourceTypeMask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsBaseCurrency")]
        public bool? IsBaseCurrency { get; set; }

    }
}
