using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Utilities.Attributes.Validation
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public class ValidatePathAttribute : Attribute
    {
        /// <summary>
        /// The property to be validated.
        /// </summary>
        public PropertyInfo PositionalProperty { get; set; }

        public ValidatePathAttribute(PropertyInfo positionalProperty)
        {
            this.PositionalProperty = positionalProperty;
            Regex pathPattern1 = new Regex(@"^(.+(\\|/))+$");
            Regex pathPattern2 = new Regex(@"^(([a-zA-Z]:|\\)\\)?(((\.)|(\.\.)|([^\\\/:\*\?""\|<>\. ](([^\\\/:\*\?""\|<>\. ])|([^\\\/:\*\?""\|<>]*[^\\\/:\*\?""\|<>\. ]))?))\\)*[^\\\/:\*\?""\|<>\. ](([^\\\/:\*\?""\|<>\. ])|([^\\\/:\*\?""\|<>]*[^\\\/:\*\?""\|<>\. ]))?$");
            string input = this.PositionalProperty.GetConstantValue().ToString();

            switch (pathPattern1.IsMatch(input) || pathPattern2.IsMatch(input))
            {
                case true:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(this.PositionalProperty.Name, $"{this.PositionalProperty.Name} is not a valid path.");
                    break;
            }
        }

    }
}
