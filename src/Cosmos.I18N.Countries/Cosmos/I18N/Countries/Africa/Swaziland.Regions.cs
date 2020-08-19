using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Swaziland Regions
    /// </summary>
    public static partial class Swaziland
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Hhohho
            /// </summary>
            public static EnumValues Hhohho => EnumValues.Hhohho;

            /// <summary>
            /// Lubombo
            /// </summary>
            public static EnumValues Lubombo => EnumValues.Lubombo;

            /// <summary>
            /// Manzini
            /// </summary>
            public static EnumValues Manzini => EnumValues.Manzini;

            /// <summary>
            /// Shiselweni
            /// </summary>
            public static EnumValues Shiselweni => EnumValues.Shiselweni;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Swaziland regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Hhohho
            /// </summary>
            [AliasInShort("HH")]
            [RegionCode(3_00_155_0001)]
            Hhohho,

            /// <summary>
            /// Lubombo
            /// </summary>
            [AliasInShort("LU")]
            [RegionCode(3_00_155_0002)]
            Lubombo,

            /// <summary>
            /// Manzini
            /// </summary>
            [AliasInShort("MA")]
            [RegionCode(3_00_155_0003)]
            Manzini,

            /// <summary>
            /// Shiselweni
            /// </summary>
            [AliasInShort("SH")]
            [RegionCode(3_00_155_0004)]
            Shiselweni,

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