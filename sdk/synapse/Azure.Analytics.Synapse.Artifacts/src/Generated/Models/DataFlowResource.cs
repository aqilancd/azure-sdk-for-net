// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Data flow resource type. </summary>
    public partial class DataFlowResource : SubResource
    {
        /// <summary> Initializes a new instance of DataFlowResource. </summary>
        /// <param name="properties"> Data flow properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DataFlowResource(DataFlow properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of DataFlowResource. </summary>
        /// <param name="id"> The resource identifier. </param>
        /// <param name="name"> The resource name. </param>
        /// <param name="type"> The resource type. </param>
        /// <param name="etag"> Etag identifies change in the resource. </param>
        /// <param name="properties"> Data flow properties. </param>
        internal DataFlowResource(string id, string name, string type, string etag, DataFlow properties) : base(id, name, type, etag)
        {
            Properties = properties;
        }

        /// <summary> Data flow properties. </summary>
        public DataFlow Properties { get; set; }
    }
}