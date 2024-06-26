/*
 * Telstra Messaging API
 *
 * The Telstra Messaging API specification
 *
 * The version of the OpenAPI document: 2.2.9
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
using OpenAPIDateConverter = Telstra.Messaging.Client.OpenAPIDateConverter;

namespace Telstra.Messaging.Model
{
    /// <summary>
    /// GetSubscriptionResponse
    /// </summary>
    [DataContract(Name = "GetSubscriptionResponse")]
    public partial class GetSubscriptionResponse : IEquatable<GetSubscriptionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="activeDays">Number of active days.</param>
        /// <param name="notifyURL">Notify url configured.</param>
        /// <param name="destinationAddress">The mobile phone number that was allocated.</param>
        public GetSubscriptionResponse(string activeDays = default(string), string notifyURL = default(string), string destinationAddress = default(string))
        {
            this.ActiveDays = activeDays;
            this.NotifyURL = notifyURL;
            this.DestinationAddress = destinationAddress;
        }

        /// <summary>
        /// Number of active days
        /// </summary>
        /// <value>Number of active days</value>
        [DataMember(Name = "activeDays", EmitDefaultValue = false)]
        public string ActiveDays { get; set; }

        /// <summary>
        /// Notify url configured
        /// </summary>
        /// <value>Notify url configured</value>
        [DataMember(Name = "notifyURL", EmitDefaultValue = false)]
        public string NotifyURL { get; set; }

        /// <summary>
        /// The mobile phone number that was allocated
        /// </summary>
        /// <value>The mobile phone number that was allocated</value>
        [DataMember(Name = "destinationAddress", EmitDefaultValue = false)]
        public string DestinationAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSubscriptionResponse {\n");
            sb.Append("  ActiveDays: ").Append(ActiveDays).Append("\n");
            sb.Append("  NotifyURL: ").Append(NotifyURL).Append("\n");
            sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetSubscriptionResponse);
        }

        /// <summary>
        /// Returns true if GetSubscriptionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSubscriptionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSubscriptionResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActiveDays == input.ActiveDays ||
                    (this.ActiveDays != null &&
                    this.ActiveDays.Equals(input.ActiveDays))
                ) && 
                (
                    this.NotifyURL == input.NotifyURL ||
                    (this.NotifyURL != null &&
                    this.NotifyURL.Equals(input.NotifyURL))
                ) && 
                (
                    this.DestinationAddress == input.DestinationAddress ||
                    (this.DestinationAddress != null &&
                    this.DestinationAddress.Equals(input.DestinationAddress))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ActiveDays != null)
                {
                    hashCode = (hashCode * 59) + this.ActiveDays.GetHashCode();
                }
                if (this.NotifyURL != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyURL.GetHashCode();
                }
                if (this.DestinationAddress != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationAddress.GetHashCode();
                }
                return hashCode;
            }
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
