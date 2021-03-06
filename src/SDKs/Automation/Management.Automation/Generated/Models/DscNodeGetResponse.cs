// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The response model for the get dsc node operation.
    /// </summary>
    public partial class DscNodeGetResponse : AzureOperationResponse
    {
        private DscNode _node;
        
        /// <summary>
        /// Optional. Gets or sets a dsc node.
        /// </summary>
        public DscNode Node
        {
            get { return this._node; }
            set { this._node = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DscNodeGetResponse class.
        /// </summary>
        public DscNodeGetResponse()
        {
        }
    }
}
