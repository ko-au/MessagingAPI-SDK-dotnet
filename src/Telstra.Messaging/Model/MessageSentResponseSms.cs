/* 
 * Telstra Messaging API
 *
 * The API specification for Telstra Messaging API
 *
 * The version of the OpenAPI document: 2.2.9
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Telstra.Messaging.Client.OpenAPIDateConverter;

namespace Telstra.Messaging.Model
{
    /// <summary>
    /// MessageSentResponseSms
    /// </summary>
    [DataContract]
    public partial class MessageSentResponseSms :  IEquatable<MessageSentResponseSms>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSentResponseSms" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MessageSentResponseSms() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSentResponseSms" /> class.
        /// </summary>
        /// <param name="messages">An array of messages. (required).</param>
        /// <param name="country">An array of the countries to which the destination MSISDNs belong..</param>
        /// <param name="messageType">This returns whether the message sent was a SMS or MMS. (required).</param>
        /// <param name="numberSegments">A message which has 160 GSM-7 characters or less will have numberSegments&#x3D;1. Note that multi-part messages which are over 160 GSM-7 characters will include the User Data Header as part of the numberSegments. The User Data Header is being used for the re-assembly of the messages.  (required).</param>
        public MessageSentResponseSms(List<Message> messages = default(List<Message>), List<Object> country = default(List<Object>), string messageType = default(string), int numberSegments = default(int))
        {
            // to ensure "messages" is required (not null)
            if (messages == null)
            {
                throw new InvalidDataException("messages is a required property for MessageSentResponseSms and cannot be null");
            }
            else
            {
                this.Messages = messages;
            }

            // to ensure "messageType" is required (not null)
            if (messageType == null)
            {
                throw new InvalidDataException("messageType is a required property for MessageSentResponseSms and cannot be null");
            }
            else
            {
                this.MessageType = messageType;
            }

            // to ensure "numberSegments" is required (not null)
            if (numberSegments == null)
            {
                throw new InvalidDataException("numberSegments is a required property for MessageSentResponseSms and cannot be null");
            }
            else
            {
                this.NumberSegments = numberSegments;
            }

            this.Country = country;
        }
        
        /// <summary>
        /// An array of messages.
        /// </summary>
        /// <value>An array of messages.</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<Message> Messages { get; set; }

        /// <summary>
        /// An array of the countries to which the destination MSISDNs belong.
        /// </summary>
        /// <value>An array of the countries to which the destination MSISDNs belong.</value>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public List<Object> Country { get; set; }

        /// <summary>
        /// This returns whether the message sent was a SMS or MMS.
        /// </summary>
        /// <value>This returns whether the message sent was a SMS or MMS.</value>
        [DataMember(Name="messageType", EmitDefaultValue=false)]
        public string MessageType { get; set; }

        /// <summary>
        /// A message which has 160 GSM-7 characters or less will have numberSegments&#x3D;1. Note that multi-part messages which are over 160 GSM-7 characters will include the User Data Header as part of the numberSegments. The User Data Header is being used for the re-assembly of the messages. 
        /// </summary>
        /// <value>A message which has 160 GSM-7 characters or less will have numberSegments&#x3D;1. Note that multi-part messages which are over 160 GSM-7 characters will include the User Data Header as part of the numberSegments. The User Data Header is being used for the re-assembly of the messages. </value>
        [DataMember(Name="numberSegments", EmitDefaultValue=false)]
        public int NumberSegments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MessageSentResponseSms {\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
            sb.Append("  NumberSegments: ").Append(NumberSegments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MessageSentResponseSms);
        }

        /// <summary>
        /// Returns true if MessageSentResponseSms instances are equal
        /// </summary>
        /// <param name="input">Instance of MessageSentResponseSms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MessageSentResponseSms input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    input.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.Country == input.Country ||
                    this.Country != null &&
                    input.Country != null &&
                    this.Country.SequenceEqual(input.Country)
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
                ) && 
                (
                    this.NumberSegments == input.NumberSegments ||
                    this.NumberSegments.Equals(input.NumberSegments)
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
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.MessageType != null)
                    hashCode = hashCode * 59 + this.MessageType.GetHashCode();
                hashCode = hashCode * 59 + this.NumberSegments.GetHashCode();
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