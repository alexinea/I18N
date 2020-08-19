using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Coted Ivoire regions
    /// </summary>
    public static partial class CotedIvoire
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Abidjan
            /// </summary>
            public static EnumValues Abidjan => EnumValues.Abidjan;

            /// <summary>
            /// Bas-Sassandra
            /// </summary>
            public static EnumValues BasSassandra => EnumValues.BasSassandra;

            /// <summary>
            /// Comoé
            /// </summary>
            public static EnumValues Comoé => EnumValues.Comoé;

            /// <summary>
            /// Denguélé
            /// </summary>
            public static EnumValues Denguélé => EnumValues.Denguélé;

            /// <summary>
            /// Gôh-Djiboua
            /// </summary>
            public static EnumValues GôhDjiboua => EnumValues.GôhDjiboua;

            /// <summary>
            /// Lacs
            /// </summary>
            public static EnumValues Lacs => EnumValues.Lacs;

            /// <summary>
            /// Lagunes
            /// </summary>
            public static EnumValues Lagunes => EnumValues.Lagunes;

            /// <summary>
            /// Montagnes
            /// </summary>
            public static EnumValues Montagnes => EnumValues.Montagnes;

            /// <summary>
            /// Sassandra-Marahoué
            /// </summary>
            public static EnumValues SassandraMarahoué => EnumValues.SassandraMarahoué;

            /// <summary>
            /// Savanes
            /// </summary>
            public static EnumValues Savanes => EnumValues.Savanes;

            /// <summary>
            /// Vallée du Bandama
            /// </summary>
            public static EnumValues ValléeDuBandama => EnumValues.ValléeDuBandama;

            /// <summary>
            /// Woroba
            /// </summary>
            public static EnumValues Woroba => EnumValues.Woroba;

            /// <summary>
            /// Yamoussoukro
            /// </summary>
            public static EnumValues Yamoussoukro => EnumValues.Yamoussoukro;

            /// <summary>
            /// Zanzan
            /// </summary>
            public static EnumValues Zanzan => EnumValues.Zanzan;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for CotedIvoire regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Abidjan
            /// </summary>
            [AliasInShort("AB")]
            [RegionCode(3_00_114_0001)]
            Abidjan,

            /// <summary>
            /// Bas-Sassandra
            /// </summary>
            [AliasInShort("BS")]
            [RegionCode(3_00_114_0002)]
            BasSassandra,

            /// <summary>
            /// Comoé
            /// </summary>
            [AliasInShort("CM")]
            [RegionCode(3_00_114_0003)]
            Comoé,

            /// <summary>
            /// Denguélé
            /// </summary>
            [AliasInShort("DN")]
            [RegionCode(3_00_114_0004)]
            Denguélé,

            /// <summary>
            /// Gôh-Djiboua
            /// </summary>
            [AliasInShort("GD")]
            [RegionCode(3_00_114_0005)]
            GôhDjiboua,

            /// <summary>
            /// Lacs
            /// </summary>
            [AliasInShort("LC")]
            [RegionCode(3_00_114_0006)]
            Lacs,

            /// <summary>
            /// Lagunes
            /// </summary>
            [AliasInShort("LG")]
            [RegionCode(3_00_114_0007)]
            Lagunes,

            /// <summary>
            /// Montagnes
            /// </summary>
            [AliasInShort("MG")]
            [RegionCode(3_00_114_0008)]
            Montagnes,

            /// <summary>
            /// Sassandra-Marahoué
            /// </summary>
            [AliasInShort("SM")]
            [RegionCode(3_00_114_0009)]
            SassandraMarahoué,

            /// <summary>
            /// Savanes
            /// </summary>
            [AliasInShort("SV")]
            [RegionCode(3_00_114_0010)]
            Savanes,

            /// <summary>
            /// Vallée du Bandama
            /// </summary>
            [AliasInShort("VB")]
            [RegionCode(3_00_114_0011)]
            ValléeDuBandama,

            /// <summary>
            /// Woroba
            /// </summary>
            [AliasInShort("WR")]
            [RegionCode(3_00_114_0012)]
            Woroba,

            /// <summary>
            /// Yamoussoukro
            /// </summary>
            [AliasInShort("YM")]
            [RegionCode(3_00_114_0013)]
            Yamoussoukro,

            /// <summary>
            /// Zanzan
            /// </summary>
            [AliasInShort("ZZ")]
            [RegionCode(3_00_114_0014)]
            Zanzan,

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