// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Additional Data Lake Store parameters.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AddDataLakeStoreParameters
    {
        /// <summary>
        /// Initializes a new instance of the AddDataLakeStoreParameters class.
        /// </summary>
        public AddDataLakeStoreParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddDataLakeStoreParameters class.
        /// </summary>
        /// <param name="suffix">the optional suffix for the Data Lake Store
        /// account.</param>
        public AddDataLakeStoreParameters(string suffix = default(string))
        {
            Suffix = suffix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the optional suffix for the Data Lake Store account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.suffix")]
        public string Suffix { get; set; }

    }
}
