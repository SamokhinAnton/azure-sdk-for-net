// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.Insights.Models;

namespace Microsoft.Azure.Management.Insights.Models
{
    /// <summary>
    /// A standard service response including an HTTP status code and request
    /// ID.
    /// </summary>
    public partial class SkuListResponse : AzureOperationResponse, IEnumerable<AvailableSkuResource>
    {
        private IList<AvailableSkuResource> _value;
        
        /// <summary>
        /// Optional. The values for the sku.
        /// </summary>
        public IList<AvailableSkuResource> Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SkuListResponse class.
        /// </summary>
        public SkuListResponse()
        {
            this.Value = new LazyList<AvailableSkuResource>();
        }
        
        /// <summary>
        /// Gets the sequence of Value.
        /// </summary>
        public IEnumerator<AvailableSkuResource> GetEnumerator()
        {
            return this.Value.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of Value.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
