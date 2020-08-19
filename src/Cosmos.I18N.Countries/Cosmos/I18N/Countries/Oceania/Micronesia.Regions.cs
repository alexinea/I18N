using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Micronesia Regions
    /// </summary>
    public static partial class Micronesia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Kosrae
            /// </summary>
            public static EnumValues Kosrae => EnumValues.Kosrae;

            /// <summary>
            /// Pohnpei
            /// </summary>
            public static EnumValues Pohnpei => EnumValues.Pohnpei;

            /// <summary>
            /// Chuuk
            /// </summary>
            public static EnumValues Chuuk => EnumValues.Chuuk;

            /// <summary>
            /// Yap
            /// </summary>
            public static EnumValues Yap => EnumValues.Yap;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Micronesia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Kosrae
            /// </summary>
            [AliasInShort("KSA")]
            [RegionCode(6_00_107_0001)]
            Kosrae,

            /// <summary>
            /// Pohnpei
            /// </summary>
            [AliasInShort("PNI")]
            [RegionCode(6_00_107_0002)]
            Pohnpei,

            /// <summary>
            /// Chuuk
            /// </summary>
            [AliasInShort("TRK")]
            [RegionCode(6_00_107_0003)]
            Chuuk,

            /// <summary>
            /// Yap
            /// </summary>
            [AliasInShort("YAP")]
            [RegionCode(6_00_107_0004)]
            Yap,

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