using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Brunei Regions
    /// </summary>
    public static partial class Brunei
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Belait
            /// </summary>
            public static EnumValues Belait => EnumValues.Belait;

            /// <summary>
            /// Brunei-Muara
            /// </summary>
            public static EnumValues BruneiMuara => EnumValues.BruneiMuara;

            /// <summary>
            /// Temburong
            /// </summary>
            public static EnumValues Temburong => EnumValues.Temburong;

            /// <summary>
            /// Tutong
            /// </summary>
            public static EnumValues Tutong => EnumValues.Tutong;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Brunei regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Belait
            /// </summary>
            [AliasInShort("BE")]
            [RegionCode(1_00_108_0001)]
            Belait,

            /// <summary>
            /// Brunei-Muara
            /// </summary>
            [AliasInShort("BM")]
            [RegionCode(1_00_108_0002)]
            BruneiMuara,

            /// <summary>
            /// Temburong
            /// </summary>
            [AliasInShort("TE")]
            [RegionCode(1_00_108_0003)]
            Temburong,

            /// <summary>
            /// Tutong
            /// </summary>
            [AliasInShort("TU")]
            [RegionCode(1_00_108_0004)]
            Tutong,

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