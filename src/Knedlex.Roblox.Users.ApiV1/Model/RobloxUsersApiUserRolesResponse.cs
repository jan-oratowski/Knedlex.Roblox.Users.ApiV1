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
    /// A user roles response model.
    /// </summary>
    [DataContract(Name = "Roblox.Users.Api.UserRolesResponse")]
    public partial class RobloxUsersApiUserRolesResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RobloxUsersApiUserRolesResponse" /> class.
        /// </summary>
        /// <param name="roles">The roles of the user..</param>
        public RobloxUsersApiUserRolesResponse(List<string> roles = default(List<string>))
        {
            this.Roles = roles;
        }

        /// <summary>
        /// The roles of the user.
        /// </summary>
        /// <value>The roles of the user.</value>
        [DataMember(Name = "roles", EmitDefaultValue = false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RobloxUsersApiUserRolesResponse {\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
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