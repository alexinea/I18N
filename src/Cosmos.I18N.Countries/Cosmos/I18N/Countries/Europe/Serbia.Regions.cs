using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Serbia Regions
    /// </summary>
    public static partial class Serbia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Podunavlje
            /// </summary>
            public static EnumValues Podunavlje => EnumValues.Podunavlje;

            /// <summary>
            /// Braničevo
            /// </summary>
            public static EnumValues Braničevo => EnumValues.Braničevo;

            /// <summary>
            /// Šumadija
            /// </summary>
            public static EnumValues Šumadija => EnumValues.Šumadija;

            /// <summary>
            /// Pomoravlje
            /// </summary>
            public static EnumValues Pomoravlje => EnumValues.Pomoravlje;

            /// <summary>
            /// Bor
            /// </summary>
            public static EnumValues Bor => EnumValues.Bor;

            /// <summary>
            /// Zaječar
            /// </summary>
            public static EnumValues Zaječar => EnumValues.Zaječar;

            /// <summary>
            /// Zlatibor
            /// </summary>
            public static EnumValues Zlatibor => EnumValues.Zlatibor;

            /// <summary>
            /// Moravica
            /// </summary>
            public static EnumValues Moravica => EnumValues.Moravica;

            /// <summary>
            /// Raška
            /// </summary>
            public static EnumValues Raška => EnumValues.Raška;

            /// <summary>
            /// Rasina
            /// </summary>
            public static EnumValues Rasina => EnumValues.Rasina;

            /// <summary>
            /// Nišava
            /// </summary>
            public static EnumValues Nišava => EnumValues.Nišava;

            /// <summary>
            /// Toplica
            /// </summary>
            public static EnumValues Toplica => EnumValues.Toplica;

            /// <summary>
            /// Pirot
            /// </summary>
            public static EnumValues Pirot => EnumValues.Pirot;

            /// <summary>
            /// Jablanica
            /// </summary>
            public static EnumValues Jablanica => EnumValues.Jablanica;

            /// <summary>
            /// Pčinja
            /// </summary>
            public static EnumValues Pčinja => EnumValues.Pčinja;

            /// <summary>
            /// Beograd
            /// </summary>
            public static EnumValues Beograd => EnumValues.Beograd;

            /// <summary>
            /// Mačva
            /// </summary>
            public static EnumValues Mačva => EnumValues.Mačva;

            /// <summary>
            /// Wasit
            /// </summary>
            public static EnumValues Wasit => EnumValues.Wasit;

            /// <summary>
            /// Kosovo-Metohija
            /// </summary>
            public static EnumValues KosovoMetohija => EnumValues.KosovoMetohija;

            /// <summary>
            /// Vojvodina
            /// </summary>
            public static EnumValues Vojvodina => EnumValues.Vojvodina;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Serbia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Podunavlje
            /// </summary>
            [AliasInShort("10")]
            [RegionCode(2_00_136_0010)]
            Podunavlje,

            /// <summary>
            /// Braničevo
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(2_00_136_0011)]
            Braničevo,

            /// <summary>
            /// Šumadija
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(2_00_136_0012)]
            Šumadija,

            /// <summary>
            /// Pomoravlje
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(2_00_136_0013)]
            Pomoravlje,

            /// <summary>
            /// Bor
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(2_00_136_0014)]
            Bor,

            /// <summary>
            /// Zaječar
            /// </summary>
            [AliasInShort("15")]
            [RegionCode(2_00_136_0015)]
            Zaječar,

            /// <summary>
            /// Zlatibor
            /// </summary>
            [AliasInShort("16")]
            [RegionCode(2_00_136_0016)]
            Zlatibor,

            /// <summary>
            /// Moravica
            /// </summary>
            [AliasInShort("17")]
            [RegionCode(2_00_136_0017)]
            Moravica,

            /// <summary>
            /// Raška
            /// </summary>
            [AliasInShort("18")]
            [RegionCode(2_00_136_0018)]
            Raška,

            /// <summary>
            /// Rasina
            /// </summary>
            [AliasInShort("19")]
            [RegionCode(2_00_136_0019)]
            Rasina,

            /// <summary>
            /// Nišava
            /// </summary>
            [AliasInShort("20")]
            [RegionCode(2_00_136_0020)]
            Nišava,

            /// <summary>
            /// Toplica
            /// </summary>
            [AliasInShort("21")]
            [RegionCode(2_00_136_0021)]
            Toplica,

            /// <summary>
            /// Pirot
            /// </summary>
            [AliasInShort("22")]
            [RegionCode(2_00_136_0022)]
            Pirot,

            /// <summary>
            /// Jablanica
            /// </summary>
            [AliasInShort("23")]
            [RegionCode(2_00_136_0023)]
            Jablanica,

            /// <summary>
            /// Pčinja
            /// </summary>
            [AliasInShort("24")]
            [RegionCode(2_00_136_0024)]
            Pčinja,

            /// <summary>
            /// Beograd
            /// </summary>
            [AliasInShort("00")]
            [RegionCode(2_00_136_0000)]
            Beograd,

            /// <summary>
            /// Mačva
            /// </summary>
            [AliasInShort("08")]
            [RegionCode(2_00_136_0008)]
            Mačva,

            /// <summary>
            /// Kolubara
            /// </summary>
            [AliasInShort("09")]
            [RegionCode(2_00_136_0009)]
            Wasit,

            /// <summary>
            /// Kosovo-Metohija
            /// </summary>
            [AliasInShort("KM")]
            [RegionCode(2_00_136_1001)]
            KosovoMetohija,

            /// <summary>
            /// Vojvodina
            /// </summary>
            [AliasInShort("VO")]
            [RegionCode(2_00_136_1002)]
            Vojvodina,

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