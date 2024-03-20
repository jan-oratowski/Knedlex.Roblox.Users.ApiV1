/*
 * Users Api v1
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Knedlex.Roblox.Users.ApiV1.Client.OpenAPIDateConverter;

namespace Knedlex.Roblox.Users.ApiV1.Model
{
    /// <summary>
    /// RobloxPagingExclusiveStartKeyCursorSystemNullableSystemInt64
    /// </summary>
    [DataContract(Name = "Roblox.Paging.ExclusiveStartKeyCursor[System.Nullable[System.Int64]]")]
    public partial class RobloxPagingExclusiveStartKeyCursorSystemNullableSystemInt64 : IValidatableObject
    {
        /// <summary>
        ///  [&#39;Asc&#39; &#x3D; 1, &#39;Desc&#39; &#x3D; 2]
        /// </summary>
        /// <value> [&#39;Asc&#39; &#x3D; 1, &#39;Desc&#39; &#x3D; 2]</value>
        public enum SortOrderEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2
        }


        /// <summary>
        ///  [&#39;Asc&#39; &#x3D; 1, &#39;Desc&#39; &#x3D; 2]
        /// </summary>
        /// <value> [&#39;Asc&#39; &#x3D; 1, &#39;Desc&#39; &#x3D; 2]</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        public SortOrderEnum? SortOrder { get; set; }
        /// <summary>
        ///  [&#39;Forward&#39; &#x3D; 1, &#39;Backward&#39; &#x3D; 2]
        /// </summary>
        /// <value> [&#39;Forward&#39; &#x3D; 1, &#39;Backward&#39; &#x3D; 2]</value>
        public enum PagingDirectionEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2
        }


        /// <summary>
        ///  [&#39;Forward&#39; &#x3D; 1, &#39;Backward&#39; &#x3D; 2]
        /// </summary>
        /// <value> [&#39;Forward&#39; &#x3D; 1, &#39;Backward&#39; &#x3D; 2]</value>
        [DataMember(Name = "pagingDirection", EmitDefaultValue = false)]
        public PagingDirectionEnum? PagingDirection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RobloxPagingExclusiveStartKeyCursorSystemNullableSystemInt64" /> class.
        /// </summary>
        /// <param name="key">key.</param>
        /// <param name="sortOrder"> [&#39;Asc&#39; &#x3D; 1, &#39;Desc&#39; &#x3D; 2].</param>
        /// <param name="pagingDirection"> [&#39;Forward&#39; &#x3D; 1, &#39;Backward&#39; &#x3D; 2].</param>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="discriminator">discriminator.</param>
        /// <param name="count">count.</param>
        public RobloxPagingExclusiveStartKeyCursorSystemNullableSystemInt64(long key = default(long), SortOrderEnum? sortOrder = default(SortOrderEnum?), PagingDirectionEnum? pagingDirection = default(PagingDirectionEnum?), int pageNumber = default(int), string discriminator = default(string), int count = default(int))
        {
            this.Key = key;
            this.SortOrder = sortOrder;
            this.PagingDirection = pagingDirection;
            this.PageNumber = pageNumber;
            this.Discriminator = discriminator;
            this.Count = count;
        }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public long Key { get; set; }

        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or Sets Discriminator
        /// </summary>
        [DataMember(Name = "discriminator", EmitDefaultValue = false)]
        public string Discriminator { get; set; }

        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RobloxPagingExclusiveStartKeyCursorSystemNullableSystemInt64 {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  PagingDirection: ").Append(PagingDirection).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Discriminator: ").Append(Discriminator).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}