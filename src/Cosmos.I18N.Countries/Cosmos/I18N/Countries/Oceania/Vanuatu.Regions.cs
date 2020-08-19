using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Vanuatu regions
    /// </summary>
    public static partial class Vanuatu
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Malampa
            /// </summary>
            /// <returns></returns>
            public static EnumValues Malampa => EnumValues.Malampa;

            /// <summary>
            /// Penama
            /// </summary>
            public static EnumValues Penama => EnumValues.Penama;

            /// <summary>
            /// Sanma
            /// </summary>
            public static EnumValues Sanma => EnumValues.Sanma;

            /// <summary>
            /// Shefa
            /// </summary>
            public static EnumValues Shefa => EnumValues.Shefa;

            /// <summary>
            /// Tafea
            /// </summary>
            public static EnumValues Tafea => EnumValues.Tafea;

            /// <summary>
            /// Torba
            /// </summary>
            public static EnumValues Torba => EnumValues.Torba;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Vanuatu regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Malampa
            /// </summary>
            [AliasInShort("MAP")]
            [RegionCode(6_00_123_0001)]
            Malampa,

            /// <summary>
            /// Penama
            /// </summary>
            [AliasInShort("PAM")]
            [RegionCode(6_00_123_0002)]
            Penama,

            /// <summary>
            /// Sanma
            /// </summary>
            [AliasInShort("SAM")]
            [RegionCode(6_00_123_0003)]
            Sanma,

            /// <summary>
            /// Shefa
            /// </summary>
            [AliasInShort("SEE")]
            [RegionCode(6_00_123_0004)]
            Shefa,

            /// <summary>
            /// Tafea
            /// </summary>
            [AliasInShort("TAE")]
            [RegionCode(6_00_123_0005)]
            Tafea,

            /// <summary>
            /// Torba
            /// </summary>
            [AliasInShort("TOB")]
            [RegionCode(6_00_123_0006)]
            Torba,

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