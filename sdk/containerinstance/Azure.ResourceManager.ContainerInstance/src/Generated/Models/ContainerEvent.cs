// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> A container group or container instance event. </summary>
    public partial class ContainerEvent
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerEvent"/>. </summary>
        internal ContainerEvent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerEvent"/>. </summary>
        /// <param name="count"> The count of the event. </param>
        /// <param name="firstTimestamp"> The date-time of the earliest logged event. </param>
        /// <param name="lastTimestamp"> The date-time of the latest logged event. </param>
        /// <param name="name"> The event name. </param>
        /// <param name="message"> The event message. </param>
        /// <param name="eventType"> The event type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerEvent(int? count, DateTimeOffset? firstTimestamp, DateTimeOffset? lastTimestamp, string name, string message, string eventType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Count = count;
            FirstTimestamp = firstTimestamp;
            LastTimestamp = lastTimestamp;
            Name = name;
            Message = message;
            EventType = eventType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The count of the event. </summary>
        public int? Count { get; }
        /// <summary> The date-time of the earliest logged event. </summary>
        public DateTimeOffset? FirstTimestamp { get; }
        /// <summary> The date-time of the latest logged event. </summary>
        public DateTimeOffset? LastTimestamp { get; }
        /// <summary> The event name. </summary>
        public string Name { get; }
        /// <summary> The event message. </summary>
        public string Message { get; }
        /// <summary> The event type. </summary>
        public string EventType { get; }
    }
}
