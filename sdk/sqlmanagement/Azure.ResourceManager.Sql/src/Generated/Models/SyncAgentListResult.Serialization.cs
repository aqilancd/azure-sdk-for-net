// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SyncAgentListResult
    {
        internal static SyncAgentListResult DeserializeSyncAgentListResult(JsonElement element)
        {
            Optional<IReadOnlyList<SyncAgent>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<SyncAgent> array = new List<SyncAgent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncAgent.DeserializeSyncAgent(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SyncAgentListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}