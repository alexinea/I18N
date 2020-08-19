using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Croatia Regions
    /// </summary>
    public static partial class Croatia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Split-Dalmatia
            /// </summary>
            public static EnumValues SplitDalmatia => EnumValues.SplitDalmatia;

            /// <summary>
            /// Dubrovnik-Neretva
            /// </summary>
            public static EnumValues DubrovnikNeretva => EnumValues.DubrovnikNeretva;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Croatia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Split-Dalmatia
            /// </summary>
            [AliasInShort("17")]
            [RegionCode(2_00_109_0017)]
            SplitDalmatia,

            /// <summary>
            /// Dubrovnik-Neretva
            /// </summary>
            [AliasInShort("19")]
            [RegionCode(2_00_109_0019)]
            DubrovnikNeretva,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            [RegionCode(0)]
            Unknown,
        }

        #endregion

        #region All regions getter

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// Get all numeric region code(CEP-1 / Cosmos Region Code).
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetAllNumericRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToNumericRegionCode());

        #endregion
    }
}