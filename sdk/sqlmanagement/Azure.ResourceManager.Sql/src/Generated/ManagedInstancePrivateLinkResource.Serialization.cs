// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Sql
{
    public partial class ManagedInstancePrivateLinkResource : IJsonModel<ManagedInstancePrivateLinkData>
    {
        void IJsonModel<ManagedInstancePrivateLinkData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ManagedInstancePrivateLinkData>)Data).Write(writer, options);

        ManagedInstancePrivateLinkData IJsonModel<ManagedInstancePrivateLinkData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ManagedInstancePrivateLinkData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ManagedInstancePrivateLinkData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ManagedInstancePrivateLinkData IPersistableModel<ManagedInstancePrivateLinkData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ManagedInstancePrivateLinkData>(data, options);

        string IPersistableModel<ManagedInstancePrivateLinkData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ManagedInstancePrivateLinkData>)Data).GetFormatFromOptions(options);
    }
}
