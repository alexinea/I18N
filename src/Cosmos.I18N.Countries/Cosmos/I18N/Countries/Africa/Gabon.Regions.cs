using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Gabon Regions
    /// </summary>
    public static partial  class Gabon
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Estuaire
        /// </summary>
        public static EnumValues Estuaire => EnumValues.Estuaire;

        /// <summary>
        /// Haut-Ogooué
        /// </summary>
        public static EnumValues HautOgooué => EnumValues.HautOgooué;

        /// <summary>
        /// Moyen-Ogooué
        /// </summary>
        public static EnumValues MoyenOgooué => EnumValues.MoyenOgooué;

        /// <summary>
        /// Ngounié
        /// </summary>
        public static EnumValues Ngounié => EnumValues.Ngounié;

        /// <summary>
        /// Nyanga
        /// </summary>
        public static EnumValues Nyanga => EnumValues.Nyanga;

        /// <summary>
        /// Ogooué-Ivindo
        /// </summary>
        public static EnumValues OgoouéIvindo => EnumValues.OgoouéIvindo;

        /// <summary>
        /// Ogooué-Lolo
        /// </summary>
        public static EnumValues OgoouéLolo => EnumValues.OgoouéLolo;

        /// <summary>
        /// Ogooué-Maritime
        /// </summary>
        public static EnumValues OgoouéMaritime => EnumValues.OgoouéMaritime;

        /// <summary>
        /// Woleu-Ntem
        /// </summary>
        public static EnumValues WoleuNtem => EnumValues.WoleuNtem;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Gabon regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Estuaire
            /// </summary>
            [AliasInShort("1")] [RegionCode(3_00_126_0001)]
            Estuaire,

            /// <summary>
            /// Haut-Ogooué
            /// </summary>
            [AliasInShort("2")] [RegionCode(3_00_126_0002)]
            HautOgooué,

            /// <summary>
            /// Moyen-Ogooué
            /// </summary>
            [AliasInShort("3")] [RegionCode(3_00_126_0003)]
            MoyenOgooué,

            /// <summary>
            /// Ngounié
            /// </summary>
            [AliasInShort("4")] [RegionCode(3_00_126_0004)]
            Ngounié,

            /// <summary>
            /// Nyanga
            /// </summary>
            [AliasInShort("5")] [RegionCode(3_00_126_0005)]
            Nyanga,

            /// <summary>
            /// Ogooué-Ivindo
            /// </summary>
            [AliasInShort("6")] [RegionCode(3_00_126_0006)]
            OgoouéIvindo,

            /// <summary>
            /// Ogooué-Lolo
            /// </summary>
            [AliasInShort("7")] [RegionCode(3_00_126_0007)]
            OgoouéLolo,

            /// <summary>
            /// Ogooué-Maritime
            /// </summary>
            [AliasInShort("8")] [RegionCode(3_00_126_0008)]
            OgoouéMaritime,

            /// <summary>
            /// Woleu-Ntem
            /// </summary>
            [AliasInShort("9")] [RegionCode(3_00_126_0009)]
            WoleuNtem,

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