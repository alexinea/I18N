using System;
using Cosmos.I18N.Countries;

namespace Cosmos.I18N.Core
{
    /// <summary>
    /// Chinese Region Name Attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
    public class LocalRegionNameAttribute : Attribute
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
        /// LangTag
        /// </summary>
        public string LangTag { get; }

        /// <summary>
        /// Create a new instance of <see cref="RegionFlagAttribute"/>
        /// </summary>
        /// <param name="langTag"></param>
        /// <param name="name"></param>
        /// <param name="shortForm"></param>
        public LocalRegionNameAttribute(string langTag, string name, string shortForm = null)
        {
            Name = name;
            ShortForm = shortForm;
            LangTag = langTag;
        }
    }
}