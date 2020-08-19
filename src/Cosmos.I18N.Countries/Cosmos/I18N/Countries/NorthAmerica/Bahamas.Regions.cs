using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Bahamas Regions
    /// </summary>
    public static partial class Bahamas
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Acklins
            /// </summary>
            public static EnumValues Acklins => EnumValues.Acklins;

            /// <summary>
            /// Bimini
            /// </summary>
            public static EnumValues Bimini => EnumValues.Bimini;

            /// <summary>
            /// Black Point
            /// </summary>
            public static EnumValues BlackPoint => EnumValues.BlackPoint;

            /// <summary>
            /// Berry Islands
            /// </summary>
            public static EnumValues BerryIslands => EnumValues.BerryIslands;

            /// <summary>
            /// Central Eleuthera
            /// </summary>
            public static EnumValues CentralEleuthera => EnumValues.CentralEleuthera;

            /// <summary>
            /// Cat Island
            /// </summary>
            public static EnumValues CatIsland => EnumValues.CatIsland;

            /// <summary>
            /// Crooked Island
            /// </summary>
            public static EnumValues CrookedIsland => EnumValues.CrookedIsland;

            /// <summary>
            /// Central Abaco
            /// </summary>
            public static EnumValues CentralAbaco => EnumValues.CentralAbaco;

            /// <summary>
            /// Central Andros
            /// </summary>
            public static EnumValues CentralAndros => EnumValues.CentralAndros;

            /// <summary>
            /// East Grand Bahama
            /// </summary>
            public static EnumValues EastGrandBahama => EnumValues.EastGrandBahama;

            /// <summary>
            /// Exuma
            /// </summary>
            public static EnumValues Exuma => EnumValues.Exuma;

            /// <summary>
            /// Freeport
            /// </summary>
            public static EnumValues Freeport => EnumValues.Freeport;

            /// <summary>
            /// Grand Cay
            /// </summary>
            public static EnumValues GrandCay => EnumValues.GrandCay;

            /// <summary>
            /// Harbour Island
            /// </summary>
            public static EnumValues HarbourIsland => EnumValues.HarbourIsland;

            /// <summary>
            /// Hope Town
            /// </summary>
            public static EnumValues HopeTown => EnumValues.HopeTown;

            /// <summary>
            /// Inagua
            /// </summary>
            public static EnumValues Inagua => EnumValues.Inagua;

            /// <summary>
            /// Long Island
            /// </summary>
            public static EnumValues LongIsland => EnumValues.LongIsland;

            /// <summary>
            /// Mangrove Cay
            /// </summary>
            public static EnumValues MangroveCay => EnumValues.MangroveCay;

            /// <summary>
            /// Mayaguana
            /// </summary>
            public static EnumValues Mayaguana => EnumValues.Mayaguana;

            /// <summary>
            /// Moore’s Island
            /// </summary>
            public static EnumValues MooresIsland => EnumValues.MooresIsland;

            /// <summary>
            /// North Eleuthera
            /// </summary>
            public static EnumValues NorthEleuthera => EnumValues.NorthEleuthera;

            /// <summary>
            /// North Abaco
            /// </summary>
            public static EnumValues NorthAbaco => EnumValues.NorthAbaco;

            /// <summary>
            /// North Andros
            /// </summary>
            public static EnumValues NorthAndros => EnumValues.NorthAndros;

            /// <summary>
            /// Rum Cay
            /// </summary>
            public static EnumValues RumCay => EnumValues.RumCay;

            /// <summary>
            /// Ragged Island
            /// </summary>
            public static EnumValues RaggedIsland => EnumValues.RaggedIsland;

            /// <summary>
            /// South Andros
            /// </summary>
            public static EnumValues SouthAndros => EnumValues.SouthAndros;

            /// <summary>
            /// South Eleuthera
            /// </summary>
            public static EnumValues SouthEleuthera => EnumValues.SouthEleuthera;

            /// <summary>
            /// South Abaco
            /// </summary>
            public static EnumValues SouthAbaco => EnumValues.SouthAbaco;


            /// <summary>
            /// San Salvador
            /// </summary>
            public static EnumValues SanSalvador => EnumValues.SanSalvador;

            /// <summary>
            /// Spanish Wells
            /// </summary>
            public static EnumValues SpanishWells => EnumValues.SpanishWells;

            /// <summary>
            /// West Grand Bahama
            /// </summary>
            public static EnumValues WestGrandBahama => EnumValues.WestGrandBahama;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Bahamas regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Acklins
            /// </summary>
            [AliasInShort("AK")]
            [RegionCode(4_00_105_0001)]
            Acklins,

            /// <summary>
            /// Bimini
            /// </summary>
            [AliasInShort("BI")]
            [RegionCode(4_00_105_0002)]
            Bimini,

            /// <summary>
            /// Black Point
            /// </summary>
            [AliasInShort("BP")]
            [RegionCode(4_00_105_0003)]
            BlackPoint,

            /// <summary>
            /// Berry Islands
            /// </summary>
            [AliasInShort("BY")]
            [RegionCode(4_00_105_0004)]
            BerryIslands,

            /// <summary>
            /// Central Eleuthera
            /// </summary>
            [AliasInShort("CE")]
            [RegionCode(4_00_105_0005)]
            CentralEleuthera,

            /// <summary>
            /// Cat Island
            /// </summary>
            [AliasInShort("CI")]
            [RegionCode(4_00_105_0006)]
            CatIsland,

            /// <summary>
            /// Crooked Island
            /// </summary>
            [AliasInShort("CK")]
            [RegionCode(4_00_105_0007)]
            CrookedIsland,

            /// <summary>
            /// Central Abaco
            /// </summary>
            [AliasInShort("CO")]
            [RegionCode(4_00_105_0008)]
            CentralAbaco,

            /// <summary>
            /// Central Andros
            /// </summary>
            [AliasInShort("CS")]
            [RegionCode(4_00_105_0009)]
            CentralAndros,

            /// <summary>
            /// East Grand Bahama
            /// </summary>
            [AliasInShort("EG")]
            [RegionCode(4_00_105_0010)]
            EastGrandBahama,

            /// <summary>
            /// Exuma
            /// </summary>
            [AliasInShort("EX")]
            [RegionCode(4_00_105_0011)]
            Exuma,

            /// <summary>
            /// Freeport
            /// </summary>
            [AliasInShort("FP")]
            [RegionCode(4_00_105_0012)]
            Freeport,

            /// <summary>
            /// Grand Cay
            /// </summary>
            [AliasInShort("GC")]
            [RegionCode(4_00_105_0013)]
            GrandCay,

            /// <summary>
            /// Harbour Island
            /// </summary>
            [AliasInShort("HI")]
            [RegionCode(4_00_105_0014)]
            HarbourIsland,

            /// <summary>
            /// Hope Town
            /// </summary>
            [AliasInShort("HT")]
            [RegionCode(4_00_105_0015)]
            HopeTown,

            /// <summary>
            /// Inagua
            /// </summary>
            [AliasInShort("IN")]
            [RegionCode(4_00_105_0016)]
            Inagua,

            /// <summary>
            /// Long Island
            /// </summary>
            [AliasInShort("LI")]
            [RegionCode(4_00_105_0017)]
            LongIsland,

            /// <summary>
            /// Mangrove Cay
            /// </summary>
            [AliasInShort("MC")]
            [RegionCode(4_00_105_0018)]
            MangroveCay,

            /// <summary>
            /// Mayaguana
            /// </summary>
            [AliasInShort("MG")]
            [RegionCode(4_00_105_0019)]
            Mayaguana,

            /// <summary>
            /// Moore’s Island
            /// </summary>
            [AliasInShort("MI")]
            [RegionCode(4_00_105_0020)]
            MooresIsland,

            /// <summary>
            /// North Eleuthera
            /// </summary>
            [AliasInShort("NE")]
            [RegionCode(4_00_105_0021)]
            NorthEleuthera,

            /// <summary>
            /// North Abaco
            /// </summary>
            [AliasInShort("NO")]
            [RegionCode(4_00_105_0022)]
            NorthAbaco,

            /// <summary>
            /// North Andros
            /// </summary>
            [AliasInShort("NS")]
            [RegionCode(4_00_105_0023)]
            NorthAndros,

            /// <summary>
            /// Rum Cay
            /// </summary>
            [AliasInShort("RC")]
            [RegionCode(4_00_105_0024)]
            RumCay,

            /// <summary>
            /// Ragged Island
            /// </summary>
            [AliasInShort("RI")]
            [RegionCode(4_00_105_0025)]
            RaggedIsland,

            /// <summary>
            /// South Andros
            /// </summary>
            [AliasInShort("SA")]
            [RegionCode(4_00_105_0026)]
            SouthAndros,

            /// <summary>
            /// South Eleuthera
            /// </summary>
            [AliasInShort("SE")]
            [RegionCode(4_00_105_0027)]
            SouthEleuthera,

            /// <summary>
            /// South Abaco
            /// </summary>
            [AliasInShort("SO")]
            [RegionCode(4_00_105_0028)]
            SouthAbaco,


            /// <summary>
            /// San Salvador
            /// </summary>
            [AliasInShort("SS")]
            [RegionCode(4_00_105_0029)]
            SanSalvador,

            /// <summary>
            /// Spanish Wells
            /// </summary>
            [AliasInShort("SW")]
            [RegionCode(4_00_105_0030)]
            SpanishWells,

            /// <summary>
            /// West Grand Bahama
            /// </summary>
            [AliasInShort("WG")]
            [RegionCode(4_00_105_0031)]
            WestGrandBahama,

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