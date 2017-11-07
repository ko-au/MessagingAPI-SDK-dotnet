/*
 * TelstraMessagingAPI.Standard
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using TelstraMessagingAPI.Standard;
using TelstraMessagingAPI.Standard.Utilities;


namespace TelstraMessagingAPI.Standard.Models
{
    public class MessageSentResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private List<Models.Message> messages;
        private string messageType;
        private int numberSegments;
        private int numberDestinations;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("messages")]
        public List<Models.Message> Messages 
        { 
            get 
            {
                return this.messages; 
            } 
            set 
            {
                this.messages = value;
                onPropertyChanged("Messages");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("messageType")]
        public string MessageType 
        { 
            get 
            {
                return this.messageType; 
            } 
            set 
            {
                this.messageType = value;
                onPropertyChanged("MessageType");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("numberSegments")]
        public int NumberSegments 
        { 
            get 
            {
                return this.numberSegments; 
            } 
            set 
            {
                this.numberSegments = value;
                onPropertyChanged("NumberSegments");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("numberDestinations")]
        public int NumberDestinations 
        { 
            get 
            {
                return this.numberDestinations; 
            } 
            set 
            {
                this.numberDestinations = value;
                onPropertyChanged("NumberDestinations");
            }
        }
    }
} 