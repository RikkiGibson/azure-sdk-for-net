// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using Azure;
    using Management;
    using Compute;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes scaling information of a SKU.
    /// </summary>
    public partial class ResourceSkuCapacity
    {
        /// <summary>
        /// Initializes a new instance of the ResourceSkuCapacity class.
        /// </summary>
        public ResourceSkuCapacity() { }

        /// <summary>
        /// Initializes a new instance of the ResourceSkuCapacity class.
        /// </summary>
        /// <param name="minimum">The minimum capacity.</param>
        /// <param name="maximum">The maximum capacity that can be set.</param>
        /// <param name="defaultProperty">The default capacity.</param>
        /// <param name="scaleType">The scale type applicable to the sku.
        /// Possible values include: 'Automatic', 'Manual', 'None'</param>
        public ResourceSkuCapacity(long? minimum = default(long?), long? maximum = default(long?), long? defaultProperty = default(long?), ResourceSkuCapacityScaleType? scaleType = default(ResourceSkuCapacityScaleType?))
        {
            Minimum = minimum;
            Maximum = maximum;
            DefaultProperty = defaultProperty;
            ScaleType = scaleType;
        }

        /// <summary>
        /// Gets the minimum capacity.
        /// </summary>
        [JsonProperty(PropertyName = "minimum")]
        public long? Minimum { get; protected set; }

        /// <summary>
        /// Gets the maximum capacity that can be set.
        /// </summary>
        [JsonProperty(PropertyName = "maximum")]
        public long? Maximum { get; protected set; }

        /// <summary>
        /// Gets the default capacity.
        /// </summary>
        [JsonProperty(PropertyName = "default")]
        public long? DefaultProperty { get; protected set; }

        /// <summary>
        /// Gets the scale type applicable to the sku. Possible values include:
        /// 'Automatic', 'Manual', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "scaleType")]
        public ResourceSkuCapacityScaleType? ScaleType { get; protected set; }

    }
}

