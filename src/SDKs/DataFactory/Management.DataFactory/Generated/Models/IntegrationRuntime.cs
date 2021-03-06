// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure Data Factory nested object which serves as a compute resource for
    /// activities.
    /// </summary>
    public partial class IntegrationRuntime
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationRuntime class.
        /// </summary>
        public IntegrationRuntime()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationRuntime class.
        /// </summary>
        /// <param name="description">Integration runtime description.</param>
        public IntegrationRuntime(string description = default(string))
        {
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets integration runtime description.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
