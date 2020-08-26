// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class IndexingPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Automatic))
            {
                writer.WritePropertyName("automatic");
                writer.WriteBooleanValue(Automatic.Value);
            }
            if (Optional.IsDefined(IndexingMode))
            {
                writer.WritePropertyName("indexingMode");
                writer.WriteStringValue(IndexingMode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IncludedPaths))
            {
                writer.WritePropertyName("includedPaths");
                writer.WriteStartArray();
                foreach (var item in IncludedPaths)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExcludedPaths))
            {
                writer.WritePropertyName("excludedPaths");
                writer.WriteStartArray();
                foreach (var item in ExcludedPaths)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(CompositeIndexes))
            {
                writer.WritePropertyName("compositeIndexes");
                writer.WriteStartArray();
                foreach (var item in CompositeIndexes)
                {
                    writer.WriteStartArray();
                    foreach (var item0 in item)
                    {
                        writer.WriteObjectValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SpatialIndexes))
            {
                writer.WritePropertyName("spatialIndexes");
                writer.WriteStartArray();
                foreach (var item in SpatialIndexes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static IndexingPolicy DeserializeIndexingPolicy(JsonElement element)
        {
            Optional<bool> automatic = default;
            Optional<IndexingMode> indexingMode = default;
            Optional<IList<IncludedPath>> includedPaths = default;
            Optional<IList<ExcludedPath>> excludedPaths = default;
            Optional<IList<IList<CompositePath>>> compositeIndexes = default;
            Optional<IList<SpatialSpec>> spatialIndexes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("automatic"))
                {
                    automatic = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("indexingMode"))
                {
                    indexingMode = new IndexingMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("includedPaths"))
                {
                    List<IncludedPath> array = new List<IncludedPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IncludedPath.DeserializeIncludedPath(item));
                    }
                    includedPaths = array;
                    continue;
                }
                if (property.NameEquals("excludedPaths"))
                {
                    List<ExcludedPath> array = new List<ExcludedPath>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExcludedPath.DeserializeExcludedPath(item));
                    }
                    excludedPaths = array;
                    continue;
                }
                if (property.NameEquals("compositeIndexes"))
                {
                    List<IList<CompositePath>> array = new List<IList<CompositePath>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        List<CompositePath> array0 = new List<CompositePath>();
                        foreach (var item0 in item.EnumerateArray())
                        {
                            array0.Add(CompositePath.DeserializeCompositePath(item0));
                        }
                        array.Add(array0);
                    }
                    compositeIndexes = array;
                    continue;
                }
                if (property.NameEquals("spatialIndexes"))
                {
                    List<SpatialSpec> array = new List<SpatialSpec>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpatialSpec.DeserializeSpatialSpec(item));
                    }
                    spatialIndexes = array;
                    continue;
                }
            }
            return new IndexingPolicy(Optional.ToNullable(automatic), Optional.ToNullable(indexingMode), Optional.ToList(includedPaths), Optional.ToList(excludedPaths), Optional.ToList(compositeIndexes), Optional.ToList(spatialIndexes));
        }
    }
}