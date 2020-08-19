using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Cyprus regions
    /// </summary>
    public static partial class Cyprus
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Nicosia
            /// </summary>
            public static EnumValues Nicosia => EnumValues.Nicosia;

            /// <summary>
            /// Limassol
            /// </summary>
            public static EnumValues Limassol => EnumValues.Limassol;

            /// <summary>
            /// Larnaca
            /// </summary>
            public static EnumValues Larnaca => EnumValues.Larnaca;

            /// <summary>
            /// Famagusta
            /// </summary>
            public static EnumValues Famagusta => EnumValues.Famagusta;

            /// <summary>
            /// Paphos
            /// </summary>
            public static EnumValues Paphos => EnumValues.Paphos;

            /// <summary>
            /// Kyrenia
            /// </summary>
            public static EnumValues Kyrenia => EnumValues.Kyrenia;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Cyprus regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Nicosia
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(1_00_112_0001)]
            Nicosia,

            /// <summary>
            /// Limassol
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(1_00_112_0002)]
            Limassol,

            /// <summary>
            /// Larnaca
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(1_00_112_0003)]
            Larnaca,

            /// <summary>
            /// Famagusta
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(1_00_112_0004)]
            Famagusta,

            /// <summary>
            /// Paphos
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(1_00_112_0005)]
            Paphos,

            /// <summary>
            /// Kyrenia
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(1_00_112_0006)]
            Kyrenia,

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