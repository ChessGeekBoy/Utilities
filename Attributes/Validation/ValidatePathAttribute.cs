using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.Attributes.Validation
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public class ValidatePathAttribute : Attribute
    {
        /// <summary>
        /// The property to be validated.
        /// </summary>
        [ValidatePattern(@"^(.+(\\|/))+")]
        public PropertyInfo PositionalProperty { get; set; }

        public ValidatePathAttribute(PropertyInfo positionalProperty)
        {
            this.PositionalProperty = positionalProperty;
        }

    }
}
