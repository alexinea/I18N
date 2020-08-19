using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Liberia Regions
    /// </summary>
    public static partial  class Liberia 
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Bong
        /// </summary>
        public static EnumValues Bong => EnumValues.Bong;

        /// <summary>
        /// Bomi
        /// </summary>
        public static EnumValues Bomi => EnumValues.Bomi;

        /// <summary>
        /// Grand Cape Mount
        /// </summary>
        public static EnumValues GrandCapeMount => EnumValues.GrandCapeMount;

        /// <summary>
        /// Grand Bassa
        /// </summary>
        public static EnumValues GrandBassa => EnumValues.GrandBassa;

        /// <summary>
        /// Grand Gedeh
        /// </summary>
        public static EnumValues GrandGedeh => EnumValues.GrandGedeh;

        /// <summary>
        /// Grand Kru
        /// </summary>
        public static EnumValues GrandKru => EnumValues.GrandKru;

        /// <summary>
        /// Gbarpolu
        /// </summary>
        public static EnumValues Gbarpolu => EnumValues.Gbarpolu;

        /// <summary>
        /// Lofa 
        /// </summary>
        public static EnumValues Lofa => EnumValues.Lofa;

        /// <summary>
        /// Margibi
        /// </summary>
        public static EnumValues Margibi => EnumValues.Margibi;

        /// <summary>
        /// Montserrado
        /// </summary>
        public static EnumValues Montserrado => EnumValues.Montserrado;

        /// <summary>
        /// Maryland
        /// </summary>
        public static EnumValues Maryland => EnumValues.Maryland;

        /// <summary>
        /// Nimba
        /// </summary>
        public static EnumValues Nimba => EnumValues.Nimba;

        /// <summary>
        /// River Gee
        /// </summary>
        public static EnumValues RiverGee => EnumValues.RiverGee;

        /// <summary>
        /// Rivercess
        /// </summary>
        public static EnumValues Rivercess => EnumValues.Rivercess;

        /// <summary>
        /// Sinoe
        /// </summary>
        public static EnumValues Sinoe => EnumValues.Sinoe;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Liberia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bong
            /// </summary>
            [AliasInShort("BG")][RegionCode(3_00_132_0001)] Bong,

            /// <summary>
            /// Bomi
            /// </summary>
            [AliasInShort("BM")][RegionCode(3_00_132_0002)] Bomi,

            /// <summary>
            /// Grand Cape Mount
            /// </summary>
            [AliasInShort("CM")][RegionCode(3_00_132_0003)] GrandCapeMount,

            /// <summary>
            /// Grand Bassa
            /// </summary>
            [AliasInShort("GB")][RegionCode(3_00_132_0004)] GrandBassa,

            /// <summary>
            /// Grand Gedeh
            /// </summary>
            [AliasInShort("GG")][RegionCode(3_00_132_0005)] GrandGedeh,

            /// <summary>
            /// Grand Kru
            /// </summary>
            [AliasInShort("GK")][RegionCode(3_00_132_0006)] GrandKru,

            /// <summary>
            /// Gbarpolu
            /// </summary>
            [AliasInShort("GP")][RegionCode(3_00_132_0007)] Gbarpolu,

            /// <summary>
            /// Lofa
            /// </summary>
            [AliasInShort("LO")][RegionCode(3_00_132_0008)] Lofa,

            /// <summary>
            /// Margibi
            /// </summary>
            [AliasInShort("MG")][RegionCode(3_00_132_0009)] Margibi,

            /// <summary>
            /// Montserrado
            /// </summary>
            [AliasInShort("MO")][RegionCode(3_00_132_0010)] Montserrado,

            /// <summary>
            /// Maryland
            /// </summary>
            [AliasInShort("MY")][RegionCode(3_00_132_0011)] Maryland,

            /// <summary>
            /// Nimba
            /// </summary>
            [AliasInShort("NI")][RegionCode(3_00_132_0012)] Nimba,

            /// <summary>
            /// River Gee
            /// </summary>
            [AliasInShort("RG")][RegionCode(3_00_132_0013)] RiverGee,

            /// <summary>
            /// Rivercess
            /// </summary>
            [AliasInShort("RI")][RegionCode(3_00_132_0014)] Rivercess,

            /// <summary>
            /// Sinoe
            /// </summary>
            [AliasInShort("SI")][RegionCode(3_00_132_0015)] Sinoe,

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