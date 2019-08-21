/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
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
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// SlackNotificationRuleBase
    /// </summary>
    [DataContract]
    public partial class SlackNotificationRuleBase :  IEquatable<SlackNotificationRuleBase>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Slack for value: slack
            /// </summary>
            [EnumMember(Value = "slack")]
            Slack = 1

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SlackNotificationRuleBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SlackNotificationRuleBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SlackNotificationRuleBase" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="channel">channel.</param>
        /// <param name="messageTemplate">messageTemplate (required).</param>
        public SlackNotificationRuleBase(TypeEnum type = default(TypeEnum), string channel = default(string), string messageTemplate = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for SlackNotificationRuleBase and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "messageTemplate" is required (not null)
            if (messageTemplate == null)
            {
                throw new InvalidDataException("messageTemplate is a required property for SlackNotificationRuleBase and cannot be null");
            }
            else
            {
                this.MessageTemplate = messageTemplate;
            }
            this.Channel = channel;
        }


        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name="channel", EmitDefaultValue=false)]
        public string Channel { get; set; }

        /// <summary>
        /// Gets or Sets MessageTemplate
        /// </summary>
        [DataMember(Name="messageTemplate", EmitDefaultValue=false)]
        public string MessageTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SlackNotificationRuleBase {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  MessageTemplate: ").Append(MessageTemplate).Append("\n");
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
            return this.Equals(input as SlackNotificationRuleBase);
        }

        /// <summary>
        /// Returns true if SlackNotificationRuleBase instances are equal
        /// </summary>
        /// <param name="input">Instance of SlackNotificationRuleBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SlackNotificationRuleBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.MessageTemplate == input.MessageTemplate ||
                    (this.MessageTemplate != null &&
                    this.MessageTemplate.Equals(input.MessageTemplate))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Channel != null)
                    hashCode = hashCode * 59 + this.Channel.GetHashCode();
                if (this.MessageTemplate != null)
                    hashCode = hashCode * 59 + this.MessageTemplate.GetHashCode();
                return hashCode;
            }
        }

    }

}