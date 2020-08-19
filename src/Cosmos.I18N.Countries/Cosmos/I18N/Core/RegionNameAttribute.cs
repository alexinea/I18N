using System;

namespace Cosmos.I18N.Core
{
    /// <summary>
    /// Region Name Attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class RegionNameAttribute : Attribute
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Short form
        /// </summary>
        public string ShortForm { get; }

        /// <summary>
        /// Create a new instance of <see cref="RegionFlagAttribute"/>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="shortForm"></param>
        public RegionNameAttribute(string name, string shortForm = null)
        {
            Name = name;
            ShortForm = shortForm;
        }
    }
}