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
    /// Defines Status
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Status
    {
        /// <summary>
        /// Enum PEND for value: PEND
        /// </summary>
        [EnumMember(Value = "PEND")]
        PEND = 1,

        /// <summary>
        /// Enum SENT for value: SENT
        /// </summary>
        [EnumMember(Value = "SENT")]
        SENT = 2,

        /// <summary>
        /// Enum DELIVRD for value: DELIVRD
        /// </summary>
        [EnumMember(Value = "DELIVRD")]
        DELIVRD = 3,

        /// <summary>
        /// Enum EXPIRED for value: EXPIRED
        /// </summary>
        [EnumMember(Value = "EXPIRED")]
        EXPIRED = 4,

        /// <summary>
        /// Enum DELETED for value: DELETED
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED = 5,

        /// <summary>
        /// Enum UNDVBL for value: UNDVBL
        /// </summary>
        [EnumMember(Value = "UNDVBL")]
        UNDVBL = 6,

        /// <summary>
        /// Enum REJECTED for value: REJECTED
        /// </summary>
        [EnumMember(Value = "REJECTED")]
        REJECTED = 7,

        /// <summary>
        /// Enum READ for value: READ
        /// </summary>
        [EnumMember(Value = "READ")]
        READ = 8

    }

}
