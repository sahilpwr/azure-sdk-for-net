// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SelfHelp.Models
{
    /// <summary> Filter criterion. </summary>
    public partial class Filter
    {
        /// <summary> Initializes a new instance of Filter. </summary>
        public Filter()
        {
        }

        /// <summary> Initializes a new instance of Filter. </summary>
        /// <param name="name"> Filter name. </param>
        /// <param name="values"> Filter values. </param>
        /// <param name="operator"> Filter operator. </param>
        internal Filter(string name, string values, string @operator)
        {
            Name = name;
            Values = values;
            Operator = @operator;
        }

        /// <summary> Filter name. </summary>
        public string Name { get; set; }
        /// <summary> Filter values. </summary>
        public string Values { get; set; }
        /// <summary> Filter operator. </summary>
        public string Operator { get; set; }
    }
}
