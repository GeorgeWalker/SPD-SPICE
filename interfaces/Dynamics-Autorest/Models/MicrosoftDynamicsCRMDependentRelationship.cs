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
    /// DependentRelationship
    /// </summary>
    public partial class MicrosoftDynamicsCRMDependentRelationship
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentRelationship class.
        /// </summary>
        public MicrosoftDynamicsCRMDependentRelationship()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMDependentRelationship class.
        /// </summary>
        /// <param name="entityRelationshipType">Possible values include:
        /// 'OneToManyRelationship', 'ManyToManyRelationship'</param>
        public MicrosoftDynamicsCRMDependentRelationship(string entityRelationshipType = default(string), string referencingAttribute = default(string), string referencedAttribute = default(string), string relationshipEntity = default(string), bool? isValidForAdvancedFind = default(bool?), bool? hasReadPrivilege = default(bool?), MicrosoftDynamicsCRMDependentManyToManyRelationshipMetadata manyToManyRelationshipMetadata = default(MicrosoftDynamicsCRMDependentManyToManyRelationshipMetadata))
        {
            EntityRelationshipType = entityRelationshipType;
            ReferencingAttribute = referencingAttribute;
            ReferencedAttribute = referencedAttribute;
            RelationshipEntity = relationshipEntity;
            IsValidForAdvancedFind = isValidForAdvancedFind;
            HasReadPrivilege = hasReadPrivilege;
            ManyToManyRelationshipMetadata = manyToManyRelationshipMetadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'OneToManyRelationship',
        /// 'ManyToManyRelationship'
        /// </summary>
        [JsonProperty(PropertyName = "EntityRelationshipType")]
        public string EntityRelationshipType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferencingAttribute")]
        public string ReferencingAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ReferencedAttribute")]
        public string ReferencedAttribute { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RelationshipEntity")]
        public string RelationshipEntity { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IsValidForAdvancedFind")]
        public bool? IsValidForAdvancedFind { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "HasReadPrivilege")]
        public bool? HasReadPrivilege { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ManyToManyRelationshipMetadata")]
        public MicrosoftDynamicsCRMDependentManyToManyRelationshipMetadata ManyToManyRelationshipMetadata { get; set; }

    }
}