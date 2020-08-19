using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Benin region
    /// </summary>
    public static partial class Benin
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Atakora
            /// </summary>
            public static EnumValues Atakora => EnumValues.Atakora;

            /// <summary>
            /// Alibori
            /// </summary>
            public static EnumValues Alibori => EnumValues.Alibori;

            /// <summary>
            /// Atlantique
            /// </summary>
            public static EnumValues Atlantique => EnumValues.Atlantique;

            /// <summary>
            /// Borgou
            /// </summary>
            public static EnumValues Borgou => EnumValues.Borgou;

            /// <summary>
            /// Collines
            /// </summary>
            public static EnumValues Collines => EnumValues.Collines;

            /// <summary>
            /// Donga
            /// </summary>
            public static EnumValues Donga => EnumValues.Donga;

            /// <summary>
            /// Kouffo
            /// </summary>
            public static EnumValues Kouffo => EnumValues.Kouffo;

            /// <summary>
            /// Littoral
            /// </summary>
            public static EnumValues Littoral => EnumValues.Littoral;

            /// <summary>
            /// Mono
            /// </summary>
            public static EnumValues Mono => EnumValues.Mono;

            /// <summary>
            /// Ouémé
            /// </summary>
            public static EnumValues Ouémé => EnumValues.Ouémé;

            /// <summary>
            /// Plateau
            /// </summary>
            public static EnumValues Plateau => EnumValues.Plateau;

            /// <summary>
            /// Zou
            /// </summary>
            public static EnumValues Zou => EnumValues.Zou;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Benin regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Atakora
            /// </summary>
            [AliasInShort("AK")]
            [RegionCode(3_00_103_0001)]
            Atakora,

            /// <summary>
            /// Alibori
            /// </summary>
            [AliasInShort("AL")]
            [RegionCode(3_00_103_0002)]
            Alibori,

            /// <summary>
            /// Atlantique
            /// </summary>
            [AliasInShort("AQ")]
            [RegionCode(3_00_103_0003)]
            Atlantique,

            /// <summary>
            /// Borgou
            /// </summary>
            [AliasInShort("BO")]
            [RegionCode(3_00_103_0004)]
            Borgou,

            /// <summary>
            /// Collines
            /// </summary>
            [AliasInShort("CO")]
            [RegionCode(3_00_103_0005)]
            Collines,

            /// <summary>
            /// Donga
            /// </summary>
            [AliasInShort("DO")]
            [RegionCode(3_00_103_0006)]
            Donga,

            /// <summary>
            /// Kouffo
            /// </summary>
            [AliasInShort("KO")]
            [RegionCode(3_00_103_0007)]
            Kouffo,

            /// <summary>
            /// Littoral
            /// </summary>
            [AliasInShort("LI")]
            [RegionCode(3_00_103_0008)]
            Littoral,

            /// <summary>
            /// Mono
            /// </summary>
            [AliasInShort("MO")]
            [RegionCode(3_00_103_0009)]
            Mono,

            /// <summary>
            /// Ouémé
            /// </summary>
            [AliasInShort("OU")]
            [RegionCode(3_00_103_0010)]
            Ouémé,

            /// <summary>
            /// Plateau
            /// </summary>
            [AliasInShort("PL")]
            [RegionCode(3_00_103_0011)]
            Plateau,

            /// <summary>
            /// Zou
            /// </summary>
            [AliasInShort("ZO")]
            [RegionCode(3_00_103_0012)]
            Zou,

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