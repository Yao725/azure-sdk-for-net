// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Describes scaling information of a sku. </summary>
    public partial class SkuCapacity
    {
        /// <summary> Initializes a new instance of SkuCapacity. </summary>
        internal SkuCapacity()
        {
            AllowedValues = new ChangeTrackingList<int>();
        }

        /// <summary> Initializes a new instance of SkuCapacity. </summary>
        /// <param name="minimum"> The lowest permitted capacity for this resource. </param>
        /// <param name="maximum"> The highest permitted capacity for this resource. </param>
        /// <param name="default"> The default capacity. </param>
        /// <param name="allowedValues"> Allows capacity value list. </param>
        /// <param name="scaleType"> The scale type applicable to the sku. </param>
        internal SkuCapacity(int? minimum, int? maximum, int? @default, IReadOnlyList<int> allowedValues, ScaleType? scaleType)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            AllowedValues = allowedValues;
            ScaleType = scaleType;
        }

        /// <summary> The lowest permitted capacity for this resource. </summary>
        public int? Minimum { get; }
        /// <summary> The highest permitted capacity for this resource. </summary>
        public int? Maximum { get; }
        /// <summary> The default capacity. </summary>
        public int? Default { get; }
        /// <summary> Allows capacity value list. </summary>
        public IReadOnlyList<int> AllowedValues { get; }
        /// <summary> The scale type applicable to the sku. </summary>
        public ScaleType? ScaleType { get; }
    }
}
