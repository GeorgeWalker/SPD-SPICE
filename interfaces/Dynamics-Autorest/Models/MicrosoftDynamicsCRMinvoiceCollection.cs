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
    /// Collection of invoice
    /// </summary>
    /// <remarks>
    /// Microsoft.Dynamics.CRM.invoiceCollection
    /// </remarks>
    public partial class MicrosoftDynamicsCRMinvoiceCollection
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMinvoiceCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMinvoiceCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMinvoiceCollection class.
        /// </summary>
        public MicrosoftDynamicsCRMinvoiceCollection(IList<MicrosoftDynamicsCRMinvoice> value = default(IList<MicrosoftDynamicsCRMinvoice>))
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
        public IList<MicrosoftDynamicsCRMinvoice> Value { get; set; }

    }
}
