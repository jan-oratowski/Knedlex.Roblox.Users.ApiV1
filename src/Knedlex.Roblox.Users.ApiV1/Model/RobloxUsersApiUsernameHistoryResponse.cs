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
    /// RobloxUsersApiUsernameHistoryResponse
    /// </summary>
    [DataContract(Name = "Roblox.Users.Api.UsernameHistoryResponse")]
    public partial class RobloxUsersApiUsernameHistoryResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RobloxUsersApiUsernameHistoryResponse" /> class.
        /// </summary>
        /// <param name="name">A past username belonging to a particular userId.</param>
        public RobloxUsersApiUsernameHistoryResponse(string name = default(string))
        {
            this.Name = name;
        }

        /// <summary>
        /// A past username belonging to a particular userId
        /// </summary>
        /// <value>A past username belonging to a particular userId</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RobloxUsersApiUsernameHistoryResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
