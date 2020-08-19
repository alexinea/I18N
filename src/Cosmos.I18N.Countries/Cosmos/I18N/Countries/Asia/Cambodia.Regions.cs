using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Cambodia Regions
    /// </summary>
    public static partial class Cambodia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Banteay Meanchey
            /// </summary>
            public static EnumValues BanteayMeanchey => EnumValues.BanteayMeanchey;

            /// <summary>
            /// Battambang
            /// </summary>
            public static EnumValues Battambang => EnumValues.Battambang;

            /// <summary>
            /// Kampong Cham
            /// </summary>
            public static EnumValues KampongCham => EnumValues.KampongCham;

            /// <summary>
            /// Kampong Chhnang
            /// </summary>
            public static EnumValues KampongChhnang => EnumValues.KampongChhnang;

            /// <summary>
            /// Kampong Speu
            /// </summary>
            public static EnumValues KampongSpeu => EnumValues.KampongSpeu;

            /// <summary>
            /// Kampong Thom
            /// </summary>
            public static EnumValues KampongThom => EnumValues.KampongThom;

            /// <summary>
            /// Kampot
            /// </summary>
            public static EnumValues Kampot => EnumValues.Kampot;

            /// <summary>
            /// Kandal
            /// </summary>
            public static EnumValues Kandal => EnumValues.Kandal;

            /// <summary>
            /// Koh Kong
            /// </summary>
            public static EnumValues KohKong => EnumValues.KohKong;

            /// <summary>
            /// Kratié
            /// </summary>
            public static EnumValues Kratié => EnumValues.Kratié;

            /// <summary>
            /// Mondulkiri
            /// </summary>
            public static EnumValues Mondulkiri => EnumValues.Mondulkiri;

            /// <summary>
            /// Phnom Penh
            /// </summary>
            public static EnumValues PhnomPenh => EnumValues.PhnomPenh;

            /// <summary>
            /// Preah Vihear
            /// </summary>
            public static EnumValues PreahVihear => EnumValues.PreahVihear;

            /// <summary>
            /// Prey Veng
            /// </summary>
            public static EnumValues PreyVeng => EnumValues.PreyVeng;

            /// <summary>
            /// Pursat
            /// </summary>
            public static EnumValues Pursat => EnumValues.Pursat;

            /// <summary>
            /// Ratanakiri
            /// </summary>
            public static EnumValues Ratanakiri => EnumValues.Ratanakiri;

            /// <summary>
            /// Siem Reap
            /// </summary>
            public static EnumValues SiemReap => EnumValues.SiemReap;

            /// <summary>
            /// Sihanoukville
            /// </summary>
            public static EnumValues Sihanoukville => EnumValues.Sihanoukville;

            /// <summary>
            /// Stung Treng
            /// </summary>
            public static EnumValues StungTreng => EnumValues.StungTreng;

            /// <summary>
            /// Svay Rieng
            /// </summary>
            public static EnumValues SvayRieng => EnumValues.SvayRieng;

            /// <summary>
            /// Takéo
            /// </summary>
            public static EnumValues Takéo => EnumValues.Takéo;

            /// <summary>
            /// Oddar Meanchey
            /// </summary>
            public static EnumValues OddarMeanchey => EnumValues.OddarMeanchey;

            /// <summary>
            /// Kep
            /// </summary>
            public static EnumValues Kep => EnumValues.Kep;

            /// <summary>
            /// Pailin
            /// </summary>
            public static EnumValues Pailin => EnumValues.Pailin;

            /// <summary>
            /// Tbong Khmum
            /// </summary>
            public static EnumValues TbongKhmum => EnumValues.TbongKhmum;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Cambodia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Banteay Meanchey
            /// </summary>
            [AliasInShort("1")]
            [RegionCode(1_00_109_0001)]
            BanteayMeanchey,

            /// <summary>
            /// Battambang
            /// </summary>
            [AliasInShort("2")]
            [RegionCode(1_00_109_0002)]
            Battambang,

            /// <summary>
            /// Kampong Cham
            /// </summary>
            [AliasInShort("3")]
            [RegionCode(1_00_109_0003)]
            KampongCham,

            /// <summary>
            /// Kampong Chhnang
            /// </summary>
            [AliasInShort("4")]
            [RegionCode(1_00_109_0004)]
            KampongChhnang,

            /// <summary>
            /// Kampong Speu
            /// </summary>
            [AliasInShort("5")]
            [RegionCode(1_00_109_0005)]
            KampongSpeu,

            /// <summary>
            /// Kampong Thom
            /// </summary>
            [AliasInShort("6")]
            [RegionCode(1_00_109_0006)]
            KampongThom,

            /// <summary>
            /// Kampot
            /// </summary>
            [AliasInShort("7")]
            [RegionCode(1_00_109_0007)]
            Kampot,

            /// <summary>
            /// Kandal
            /// </summary>
            [AliasInShort("8")]
            [RegionCode(1_00_109_0008)]
            Kandal,

            /// <summary>
            /// Koh Kong
            /// </summary>
            [AliasInShort("9")]
            [RegionCode(1_00_109_0009)]
            KohKong,

            /// <summary>
            /// Kratié
            /// </summary>
            [AliasInShort("10")]
            [RegionCode(1_00_109_0010)]
            Kratié,

            /// <summary>
            /// Mondulkiri
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(1_00_109_0011)]
            Mondulkiri,

            /// <summary>
            /// Phnom Penh
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(1_00_109_0012)]
            PhnomPenh,

            /// <summary>
            /// Preah Vihear
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(1_00_109_0013)]
            PreahVihear,

            /// <summary>
            /// Prey Veng
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(1_00_109_0014)]
            PreyVeng,

            /// <summary>
            /// Pursat
            /// </summary>
            [AliasInShort("15")]
            [RegionCode(1_00_109_0015)]
            Pursat,

            /// <summary>
            /// Ratanakiri
            /// </summary>
            [AliasInShort("16")]
            [RegionCode(1_00_109_0016)]
            Ratanakiri,

            /// <summary>
            /// Siem Reap
            /// </summary>
            [AliasInShort("17")]
            [RegionCode(1_00_109_0017)]
            SiemReap,

            /// <summary>
            /// Sihanoukville
            /// </summary>
            [AliasInShort("18")]
            [RegionCode(1_00_109_0018)]
            Sihanoukville,

            /// <summary>
            /// Stung Treng
            /// </summary>
            [AliasInShort("19")]
            [RegionCode(1_00_109_0019)]
            StungTreng,

            /// <summary>
            /// Svay Rieng
            /// </summary>
            [AliasInShort("20")]
            [RegionCode(1_00_109_0020)]
            SvayRieng,

            /// <summary>
            /// Takéo
            /// </summary>
            [AliasInShort("21")]
            [RegionCode(1_00_109_0021)]
            Takéo,

            /// <summary>
            /// Oddar Meanchey
            /// </summary>
            [AliasInShort("22")]
            [RegionCode(1_00_109_0022)]
            OddarMeanchey,

            /// <summary>
            /// Kep
            /// </summary>
            [AliasInShort("23")]
            [RegionCode(1_00_109_0023)]
            Kep,

            /// <summary>
            /// Pailin
            /// </summary>
            [AliasInShort("24")]
            [RegionCode(1_00_109_0024)]
            Pailin,

            /// <summary>
            /// Tbong Khmum
            /// </summary>
            [AliasInShort("25")]
            [RegionCode(1_00_109_0025)]
            TbongKhmum,

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