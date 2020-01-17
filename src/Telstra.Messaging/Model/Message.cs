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
    /// Message
    /// </summary>
    [DataContract]
    public partial class Message :  IEquatable<Message>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Message() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="to">Just a copy of the number the message is sent to. (required).</param>
        /// <param name="deliveryStatus">Gives an indication if the message has been accepted for delivery. The description field contains information on why a message may have been rejected.  (required).</param>
        /// <param name="messageId">For an accepted message, ths will be a unique reference that can be used to check the messages status. Please refer to the Delivery Notification section.  Note that &#x60;messageId&#x60; will be different for each number that the message was sent to.  (required).</param>
        /// <param name="messageStatusURL">For an accepted message, ths will be the URL that can be used to check the messages status. Please refer to the Delivery Notification section. .</param>
        public Message(string to = default(string), string deliveryStatus = default(string), string messageId = default(string), string messageStatusURL = default(string))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for Message and cannot be null");
            }
            else
            {
                this.To = to;
            }

            // to ensure "deliveryStatus" is required (not null)
            if (deliveryStatus == null)
            {
                throw new InvalidDataException("deliveryStatus is a required property for Message and cannot be null");
            }
            else
            {
                this.DeliveryStatus = deliveryStatus;
            }

            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new InvalidDataException("messageId is a required property for Message and cannot be null");
            }
            else
            {
                this.MessageId = messageId;
            }

            this.MessageStatusURL = messageStatusURL;
        }
        
        /// <summary>
        /// Just a copy of the number the message is sent to.
        /// </summary>
        /// <value>Just a copy of the number the message is sent to.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public string To { get; set; }

        /// <summary>
        /// Gives an indication if the message has been accepted for delivery. The description field contains information on why a message may have been rejected. 
        /// </summary>
        /// <value>Gives an indication if the message has been accepted for delivery. The description field contains information on why a message may have been rejected. </value>
        [DataMember(Name="deliveryStatus", EmitDefaultValue=false)]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// For an accepted message, ths will be a unique reference that can be used to check the messages status. Please refer to the Delivery Notification section.  Note that &#x60;messageId&#x60; will be different for each number that the message was sent to. 
        /// </summary>
        /// <value>For an accepted message, ths will be a unique reference that can be used to check the messages status. Please refer to the Delivery Notification section.  Note that &#x60;messageId&#x60; will be different for each number that the message was sent to. </value>
        [DataMember(Name="messageId", EmitDefaultValue=false)]
        public string MessageId { get; set; }

        /// <summary>
        /// For an accepted message, ths will be the URL that can be used to check the messages status. Please refer to the Delivery Notification section. 
        /// </summary>
        /// <value>For an accepted message, ths will be the URL that can be used to check the messages status. Please refer to the Delivery Notification section. </value>
        [DataMember(Name="messageStatusURL", EmitDefaultValue=false)]
        public string MessageStatusURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  DeliveryStatus: ").Append(DeliveryStatus).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  MessageStatusURL: ").Append(MessageStatusURL).Append("\n");
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
            return this.Equals(input as Message);
        }

        /// <summary>
        /// Returns true if Message instances are equal
        /// </summary>
        /// <param name="input">Instance of Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.DeliveryStatus == input.DeliveryStatus ||
                    (this.DeliveryStatus != null &&
                    this.DeliveryStatus.Equals(input.DeliveryStatus))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.MessageStatusURL == input.MessageStatusURL ||
                    (this.MessageStatusURL != null &&
                    this.MessageStatusURL.Equals(input.MessageStatusURL))
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
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.DeliveryStatus != null)
                    hashCode = hashCode * 59 + this.DeliveryStatus.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.MessageStatusURL != null)
                    hashCode = hashCode * 59 + this.MessageStatusURL.GetHashCode();
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