// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class WordDelimiterTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(GenerateWordParts))
            {
                writer.WritePropertyName("generateWordParts");
                writer.WriteBooleanValue(GenerateWordParts.Value);
            }
            if (Optional.IsDefined(GenerateNumberParts))
            {
                writer.WritePropertyName("generateNumberParts");
                writer.WriteBooleanValue(GenerateNumberParts.Value);
            }
            if (Optional.IsDefined(CatenateWords))
            {
                writer.WritePropertyName("catenateWords");
                writer.WriteBooleanValue(CatenateWords.Value);
            }
            if (Optional.IsDefined(CatenateNumbers))
            {
                writer.WritePropertyName("catenateNumbers");
                writer.WriteBooleanValue(CatenateNumbers.Value);
            }
            if (Optional.IsDefined(CatenateAll))
            {
                writer.WritePropertyName("catenateAll");
                writer.WriteBooleanValue(CatenateAll.Value);
            }
            if (Optional.IsDefined(SplitOnCaseChange))
            {
                writer.WritePropertyName("splitOnCaseChange");
                writer.WriteBooleanValue(SplitOnCaseChange.Value);
            }
            if (Optional.IsDefined(PreserveOriginal))
            {
                writer.WritePropertyName("preserveOriginal");
                writer.WriteBooleanValue(PreserveOriginal.Value);
            }
            if (Optional.IsDefined(SplitOnNumerics))
            {
                writer.WritePropertyName("splitOnNumerics");
                writer.WriteBooleanValue(SplitOnNumerics.Value);
            }
            if (Optional.IsDefined(StemEnglishPossessive))
            {
                writer.WritePropertyName("stemEnglishPossessive");
                writer.WriteBooleanValue(StemEnglishPossessive.Value);
            }
            if (Optional.IsCollectionDefined(ProtectedWords))
            {
                writer.WritePropertyName("protectedWords");
                writer.WriteStartArray();
                foreach (var item in ProtectedWords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static WordDelimiterTokenFilter DeserializeWordDelimiterTokenFilter(JsonElement element)
        {
            Optional<bool> generateWordParts = default;
            Optional<bool> generateNumberParts = default;
            Optional<bool> catenateWords = default;
            Optional<bool> catenateNumbers = default;
            Optional<bool> catenateAll = default;
            Optional<bool> splitOnCaseChange = default;
            Optional<bool> preserveOriginal = default;
            Optional<bool> splitOnNumerics = default;
            Optional<bool> stemEnglishPossessive = default;
            Optional<IList<string>> protectedWords = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("generateWordParts"))
                {
                    generateWordParts = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("generateNumberParts"))
                {
                    generateNumberParts = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("catenateWords"))
                {
                    catenateWords = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("catenateNumbers"))
                {
                    catenateNumbers = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("catenateAll"))
                {
                    catenateAll = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("splitOnCaseChange"))
                {
                    splitOnCaseChange = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("preserveOriginal"))
                {
                    preserveOriginal = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("splitOnNumerics"))
                {
                    splitOnNumerics = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("stemEnglishPossessive"))
                {
                    stemEnglishPossessive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("protectedWords"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    protectedWords = array;
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new WordDelimiterTokenFilter(odataType, name, Optional.ToNullable(generateWordParts), Optional.ToNullable(generateNumberParts), Optional.ToNullable(catenateWords), Optional.ToNullable(catenateNumbers), Optional.ToNullable(catenateAll), Optional.ToNullable(splitOnCaseChange), Optional.ToNullable(preserveOriginal), Optional.ToNullable(splitOnNumerics), Optional.ToNullable(stemEnglishPossessive), Optional.ToList(protectedWords));
        }
    }
}