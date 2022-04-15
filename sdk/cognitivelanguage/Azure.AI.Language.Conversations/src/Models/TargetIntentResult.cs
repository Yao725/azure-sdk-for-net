// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    /// <summary> This is the base class of an intent prediction. </summary>
    public partial class TargetIntentResult
    {
        /// <summary> This discriminator property specifies the type of the target project that returns the response. </summary>
        [CodeGenMember("TargetKind")]
        public TargetKind TargetKind { get; set; }
    }
}
