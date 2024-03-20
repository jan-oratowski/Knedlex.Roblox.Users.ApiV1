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
    /// The birthdate request
    /// </summary>
    [DataContract(Name = "Roblox.Users.Api.BirthdateRequest")]
    public partial class RobloxUsersApiBirthdateRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RobloxUsersApiBirthdateRequest" /> class.
        /// </summary>
        /// <param name="birthMonth">The birth month.</param>
        /// <param name="birthDay">The birth day.</param>
        /// <param name="birthYear">The birth year.</param>
        /// <param name="password">Password.</param>
        public RobloxUsersApiBirthdateRequest(int birthMonth = default(int), int birthDay = default(int), int birthYear = default(int), string password = default(string))
        {
            this.BirthMonth = birthMonth;
            this.BirthDay = birthDay;
            this.BirthYear = birthYear;
            this.Password = password;
        }

        /// <summary>
        /// The birth month
        /// </summary>
        /// <value>The birth month</value>
        [DataMember(Name = "birthMonth", EmitDefaultValue = false)]
        public int BirthMonth { get; set; }

        /// <summary>
        /// The birth day
        /// </summary>
        /// <value>The birth day</value>
        [DataMember(Name = "birthDay", EmitDefaultValue = false)]
        public int BirthDay { get; set; }

        /// <summary>
        /// The birth year
        /// </summary>
        /// <value>The birth year</value>
        [DataMember(Name = "birthYear", EmitDefaultValue = false)]
        public int BirthYear { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        /// <value>Password</value>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RobloxUsersApiBirthdateRequest {\n");
            sb.Append("  BirthMonth: ").Append(BirthMonth).Append("\n");
            sb.Append("  BirthDay: ").Append(BirthDay).Append("\n");
            sb.Append("  BirthYear: ").Append(BirthYear).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
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
