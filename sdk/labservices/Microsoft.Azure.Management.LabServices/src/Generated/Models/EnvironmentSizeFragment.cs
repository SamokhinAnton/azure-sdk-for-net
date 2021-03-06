// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a size category supported by this Lab Account (small, medium
    /// or large)
    /// </summary>
    public partial class EnvironmentSizeFragment
    {
        /// <summary>
        /// Initializes a new instance of the EnvironmentSizeFragment class.
        /// </summary>
        public EnvironmentSizeFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnvironmentSizeFragment class.
        /// </summary>
        /// <param name="name">The size category. Possible values include:
        /// 'Basic', 'Standard', 'Performance'</param>
        /// <param name="vmSizes">Represents a set of compute sizes that can
        /// serve this given size type</param>
        public EnvironmentSizeFragment(string name = default(string), IList<SizeInfoFragment> vmSizes = default(IList<SizeInfoFragment>))
        {
            Name = name;
            VmSizes = vmSizes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the size category. Possible values include: 'Basic',
        /// 'Standard', 'Performance'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets represents a set of compute sizes that can serve this
        /// given size type
        /// </summary>
        [JsonProperty(PropertyName = "vmSizes")]
        public IList<SizeInfoFragment> VmSizes { get; set; }

    }
}
