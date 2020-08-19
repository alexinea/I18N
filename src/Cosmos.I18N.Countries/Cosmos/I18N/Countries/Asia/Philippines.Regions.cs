using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Philippines Regions
    /// </summary>
    public static partial class Philippines
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Northern Mindanao
            /// </summary>
            public static EnumValues NorthernMindanao => EnumValues.NorthernMindanao;

            /// <summary>
            /// Davao
            /// </summary>
            public static EnumValues Davao => EnumValues.Davao;

            /// <summary>
            /// Soccsksargen
            /// </summary>
            public static EnumValues Soccsksargen => EnumValues.Soccsksargen;

            /// <summary>
            /// Caraga
            /// </summary>
            public static EnumValues Caraga => EnumValues.Caraga;

            /// <summary>
            /// Muslim Mindanao
            /// </summary>
            public static EnumValues MuslimMindanao => EnumValues.MuslimMindanao;

            /// <summary>
            /// Cordillera Administrative
            /// </summary>
            public static EnumValues CordilleraAdministrative => EnumValues.CordilleraAdministrative;

            /// <summary>
            /// Calabarzon
            /// </summary>
            public static EnumValues Calabarzon => EnumValues.Calabarzon;

            /// <summary>
            /// Mimaropa
            /// </summary>
            public static EnumValues Mimaropa => EnumValues.Mimaropa;

            /// <summary>
            /// Metro Manila 
            /// </summary>
            public static EnumValues MetroManila => EnumValues.MetroManila;

            /// <summary>
            /// Ilocos
            /// </summary>
            public static EnumValues Ilocos => EnumValues.Ilocos;

            /// <summary>
            /// Cagayan Valley 
            /// </summary>
            public static EnumValues CagayanValley => EnumValues.CagayanValley;

            /// <summary>
            /// Central Luzon
            /// </summary>
            public static EnumValues CentralLuzon => EnumValues.CentralLuzon;

            /// <summary>
            /// Bicol
            /// </summary>
            public static EnumValues Bicol => EnumValues.Bicol;

            /// <summary>
            /// Western Visayas
            /// </summary>
            public static EnumValues WesternVisayas => EnumValues.WesternVisayas;

            /// <summary>
            /// Central Visayas 
            /// </summary>
            public static EnumValues CentralVisayas => EnumValues.CentralVisayas;

            /// <summary>
            /// Eastern Visayas
            /// </summary>
            public static EnumValues EasternVisayas => EnumValues.EasternVisayas;

            /// <summary>
            /// Zamboanga Peninsula 
            /// </summary>
            public static EnumValues ZamboangaPeninsula => EnumValues.ZamboangaPeninsula;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Philippines regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Northern Mindanao
            /// </summary>
            [AliasInShort("10")]
            [RegionCode(1_00_131_0010)]
            NorthernMindanao,

            /// <summary>
            /// Davao
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(1_00_131_0011)]
            Davao,

            /// <summary>
            /// Soccsksargen
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(1_00_131_0012)]
            Soccsksargen,

            /// <summary>
            /// Caraga
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(1_00_131_0013)]
            Caraga,

            /// <summary>
            /// Muslim Mindanao
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(1_00_131_0014)]
            MuslimMindanao,

            /// <summary>
            /// Cordillera Administrative
            /// </summary>
            [AliasInShort("15")]
            [RegionCode(1_00_131_0015)]
            CordilleraAdministrative,

            /// <summary>
            /// Calabarzon
            /// </summary>
            [AliasInShort("40")]
            [RegionCode(1_00_131_0040)]
            Calabarzon,

            /// <summary>
            /// Mimaropa
            /// </summary>
            [AliasInShort("41")]
            [RegionCode(1_00_131_0041)]
            Mimaropa,

            /// <summary>
            /// Metro Manila
            /// </summary>
            [AliasInShort("00")]
            [RegionCode(1_00_131_0000)]
            MetroManila,

            /// <summary>
            /// Ilocos
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(1_00_131_0001)]
            Ilocos,

            /// <summary>
            /// Cagayan Valley
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(1_00_131_0002)]
            CagayanValley,

            /// <summary>
            /// Central Luzon
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(1_00_131_0003)]
            CentralLuzon,

            /// <summary>
            /// Bicol
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(1_00_131_0005)]
            Bicol,

            /// <summary>
            /// Western Visayas
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(1_00_131_0006)]
            WesternVisayas,

            /// <summary>
            /// Central Visayas
            /// </summary>
            [AliasInShort("07")]
            [RegionCode(1_00_131_0007)]
            CentralVisayas,

            /// <summary>
            /// Eastern Visayas
            /// </summary>
            [AliasInShort("08")]
            [RegionCode(1_00_131_0008)]
            EasternVisayas,

            /// <summary>
            /// Zamboanga Peninsula
            /// </summary>
            [AliasInShort("09")]
            [RegionCode(1_00_131_0009)]
            ZamboangaPeninsula,

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