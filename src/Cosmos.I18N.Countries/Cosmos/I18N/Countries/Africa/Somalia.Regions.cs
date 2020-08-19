using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Somalia Regions
    /// </summary>
    public static partial class Somalia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Awdal
            /// </summary>
            public static EnumValues Awdal => EnumValues.Awdal;

            /// <summary>
            /// Sanaag
            /// </summary>
            public static EnumValues Sanaag => EnumValues.Sanaag;

            /// <summary>
            /// Sool
            /// </summary>
            public static EnumValues Sool => EnumValues.Sool;

            /// <summary>
            /// Babylon
            /// </summary>
            public static EnumValues Togdheer => EnumValues.Togdheer;

            /// <summary>
            /// Woqooyi Galbeed
            /// </summary>
            public static EnumValues WoqooyiGalbeed => EnumValues.WoqooyiGalbeed;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Somalia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Awdal
            /// </summary>
            [AliasInShort("AW")]
            [RegionCode(3_00_152_0001)]
            Awdal,

            /// <summary>
            /// Sanaag
            /// </summary>
            [AliasInShort("SA")]
            [RegionCode(3_00_152_0002)]
            Sanaag,

            /// <summary>
            /// Sool
            /// </summary>
            [AliasInShort("SO")]
            [RegionCode(3_00_152_0003)]
            Sool,

            /// <summary>
            /// Togdheer
            /// </summary>
            [AliasInShort("TO")]
            [RegionCode(3_00_152_0004)]
            Togdheer,

            /// <summary>
            /// Woqooyi Galbeed
            /// </summary>
            [AliasInShort("WO")]
            [RegionCode(3_00_152_0005)]
            WoqooyiGalbeed,

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