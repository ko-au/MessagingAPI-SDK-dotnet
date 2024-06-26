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
    /// Poll for incoming messages returning the latest. Only works if no callback url was specified when provisioning a number. 
    /// </summary>
    [DataContract(Name = "InboundPollResponse")]
    public partial class InboundPollResponse : IEquatable<InboundPollResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboundPollResponse" /> class.
        /// </summary>
        /// <param name="status">message status.</param>
        /// <param name="destinationAddress">The phone number (recipient) that the message was sent to (in E.164 format). .</param>
        /// <param name="senderAddress">The phone number (sender) that the message was sent from (in E.164 format). .</param>
        /// <param name="message">Text of the message that was sent.</param>
        /// <param name="messageId">Message Id.</param>
        /// <param name="sentTimestamp">The date and time when the message was sent by recipient..</param>
        public InboundPollResponse(string status = default(string), string destinationAddress = default(string), string senderAddress = default(string), string message = default(string), string messageId = default(string), string sentTimestamp = default(string))
        {
            this.Status = status;
            this.DestinationAddress = destinationAddress;
            this.SenderAddress = senderAddress;
            this.Message = message;
            this.MessageId = messageId;
            this.SentTimestamp = sentTimestamp;
        }

        /// <summary>
        /// message status
        /// </summary>
        /// <value>message status</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// The phone number (recipient) that the message was sent to (in E.164 format). 
        /// </summary>
        /// <value>The phone number (recipient) that the message was sent to (in E.164 format). </value>
        [DataMember(Name = "destinationAddress", EmitDefaultValue = false)]
        public string DestinationAddress { get; set; }

        /// <summary>
        /// The phone number (sender) that the message was sent from (in E.164 format). 
        /// </summary>
        /// <value>The phone number (sender) that the message was sent from (in E.164 format). </value>
        [DataMember(Name = "senderAddress", EmitDefaultValue = false)]
        public string SenderAddress { get; set; }

        /// <summary>
        /// Text of the message that was sent
        /// </summary>
        /// <value>Text of the message that was sent</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Message Id
        /// </summary>
        /// <value>Message Id</value>
        [DataMember(Name = "messageId", EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// The date and time when the message was sent by recipient.
        /// </summary>
        /// <value>The date and time when the message was sent by recipient.</value>
        [DataMember(Name = "sentTimestamp", EmitDefaultValue = false)]
        public string SentTimestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InboundPollResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  DestinationAddress: ").Append(DestinationAddress).Append("\n");
            sb.Append("  SenderAddress: ").Append(SenderAddress).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  SentTimestamp: ").Append(SentTimestamp).Append("\n");
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
            return this.Equals(input as InboundPollResponse);
        }

        /// <summary>
        /// Returns true if InboundPollResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InboundPollResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboundPollResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.DestinationAddress == input.DestinationAddress ||
                    (this.DestinationAddress != null &&
                    this.DestinationAddress.Equals(input.DestinationAddress))
                ) && 
                (
                    this.SenderAddress == input.SenderAddress ||
                    (this.SenderAddress != null &&
                    this.SenderAddress.Equals(input.SenderAddress))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.SentTimestamp == input.SentTimestamp ||
                    (this.SentTimestamp != null &&
                    this.SentTimestamp.Equals(input.SentTimestamp))
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
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.DestinationAddress != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationAddress.GetHashCode();
                }
                if (this.SenderAddress != null)
                {
                    hashCode = (hashCode * 59) + this.SenderAddress.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.MessageId != null)
                {
                    hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                }
                if (this.SentTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.SentTimestamp.GetHashCode();
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
