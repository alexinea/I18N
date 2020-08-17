using System;

namespace Cosmos.I18N.Core
{
    /// <summary>
    /// Cosmos Region Code Attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class RegionCodeAttribute : Attribute
    {
        /// <summary>
        /// Cosmos Region Code
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public long CRCode { get; set; }

        /// <summary>
        /// Create a new instance of <see cref="RegionCodeAttribute"/>
        /// </summary>
        /// <param name="code"></param>
        public RegionCodeAttribute(long code) => CRCode = code;
    }
}