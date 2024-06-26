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
    /// A user response model specific to getting a user from user search.
    /// </summary>
    [DataContract(Name = "Roblox.Users.Api.UserSearchResponse")]
    public partial class RobloxUsersApiUserSearchResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RobloxUsersApiUserSearchResponse" /> class.
        /// </summary>
        /// <param name="previousUsernames">Previous usernames for a user..</param>
        /// <param name="hasVerifiedBadge">The user&#39;s verified badge status..</param>
        /// <param name="id">The user Id..</param>
        /// <param name="name">The user name..</param>
        /// <param name="displayName">The user DisplayName..</param>
        public RobloxUsersApiUserSearchResponse(List<string> previousUsernames = default(List<string>), bool hasVerifiedBadge = default(bool), long id = default(long), string name = default(string), string displayName = default(string))
        {
            this.PreviousUsernames = previousUsernames;
            this.HasVerifiedBadge = hasVerifiedBadge;
            this.Id = id;
            this.Name = name;
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Previous usernames for a user.
        /// </summary>
        /// <value>Previous usernames for a user.</value>
        [DataMember(Name = "previousUsernames", EmitDefaultValue = false)]
        public List<string> PreviousUsernames { get; set; }

        /// <summary>
        /// The user&#39;s verified badge status.
        /// </summary>
        /// <value>The user&#39;s verified badge status.</value>
        [DataMember(Name = "hasVerifiedBadge", EmitDefaultValue = true)]
        public bool HasVerifiedBadge { get; set; }

        /// <summary>
        /// The user Id.
        /// </summary>
        /// <value>The user Id.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// The user name.
        /// </summary>
        /// <value>The user name.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The user DisplayName.
        /// </summary>
        /// <value>The user DisplayName.</value>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RobloxUsersApiUserSearchResponse {\n");
            sb.Append("  PreviousUsernames: ").Append(PreviousUsernames).Append("\n");
            sb.Append("  HasVerifiedBadge: ").Append(HasVerifiedBadge).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
