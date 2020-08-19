using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Iraq Regions
    /// </summary>
    public static partial class Iraq
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Al Anbar
            /// </summary>
            public static EnumValues AlAnbar => EnumValues.AlAnbar;

            /// <summary>
            /// Erbil
            /// </summary>
            public static EnumValues Erbil => EnumValues.Erbil;

            /// <summary>
            /// Basra
            /// </summary>
            public static EnumValues Basra => EnumValues.Basra;

            /// <summary>
            /// Babylon
            /// </summary>
            public static EnumValues Babylon => EnumValues.Babylon;

            /// <summary>
            /// Baghdad
            /// </summary>
            public static EnumValues Baghdad => EnumValues.Baghdad;

            /// <summary>
            /// Dohuk
            /// </summary>
            public static EnumValues Dohuk => EnumValues.Dohuk;

            /// <summary>
            /// Diyala
            /// </summary>
            public static EnumValues Diyala => EnumValues.Diyala;

            /// <summary>
            /// Dhi Qar    
            /// </summary>
            public static EnumValues DhiQar => EnumValues.DhiQar;

            /// <summary>
            /// Karbala
            /// </summary>
            public static EnumValues Karbala => EnumValues.Karbala;

            /// <summary>
            /// Kirkuk
            /// </summary>
            public static EnumValues Kirkuk => EnumValues.Kirkuk;

            /// <summary>
            /// Maysan
            /// </summary>
            public static EnumValues Maysan => EnumValues.Maysan;

            /// <summary>
            /// Al Muthanna
            /// </summary>
            public static EnumValues AlMuthanna => EnumValues.AlMuthanna;

            /// <summary>
            /// Najaf
            /// </summary>
            public static EnumValues Najaf => EnumValues.Najaf;

            /// <summary>
            /// Nineveh
            /// </summary>
            public static EnumValues Nineveh => EnumValues.Nineveh;

            /// <summary>
            /// Al-Qādisiyyah
            /// </summary>
            public static EnumValues AlQādisiyyah => EnumValues.AlQādisiyyah;

            /// <summary>
            /// Saladin
            /// </summary>
            public static EnumValues Saladin => EnumValues.Saladin;

            /// <summary>
            /// Sulaymaniyah
            /// </summary>
            public static EnumValues Sulaymaniyah => EnumValues.Sulaymaniyah;

            /// <summary>
            /// Wasit
            /// </summary>
            public static EnumValues Wasit => EnumValues.Wasit;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Iraq regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Al Anbar
            /// </summary>
            [AliasInShort("AN")]
            [RegionCode(1_00_117_0001)]
            AlAnbar,

            /// <summary>
            /// Erbil
            /// </summary>
            [AliasInShort("AR")]
            [RegionCode(1_00_117_0002)]
            Erbil,

            /// <summary>
            /// Basra
            /// </summary>
            [AliasInShort("BA")]
            [RegionCode(1_00_117_0003)]
            Basra,

            /// <summary>
            /// Babylon
            /// </summary>
            [AliasInShort("BB")]
            [RegionCode(1_00_117_0004)]
            Babylon,

            /// <summary>
            /// Baghdad
            /// </summary>
            [AliasInShort("BG")]
            [RegionCode(1_00_117_0005)]
            Baghdad,

            /// <summary>
            /// Dohuk
            /// </summary>
            [AliasInShort("DA")]
            [RegionCode(1_00_117_0006)]
            Dohuk,

            /// <summary>
            /// Diyala
            /// </summary>
            [AliasInShort("DI")]
            [RegionCode(1_00_117_0007)]
            Diyala,

            /// <summary>
            /// Dhi Qar
            /// </summary>
            [AliasInShort("DQ")]
            [RegionCode(1_00_117_0008)]
            DhiQar,

            /// <summary>
            /// Karbala
            /// </summary>
            [AliasInShort("KA")]
            [RegionCode(1_00_117_0009)]
            Karbala,

            /// <summary>
            /// Kirkuk
            /// </summary>
            [AliasInShort("KI")]
            [RegionCode(1_00_117_0010)]
            Kirkuk,

            /// <summary>
            /// Maysan
            /// </summary>
            [AliasInShort("MA")]
            [RegionCode(1_00_117_0011)]
            Maysan,

            /// <summary>
            /// Al Muthanna
            /// </summary>
            [AliasInShort("MU")]
            [RegionCode(1_00_117_0012)]
            AlMuthanna,

            /// <summary>
            /// Najaf
            /// </summary>
            [AliasInShort("NA")]
            [RegionCode(1_00_117_0013)]
            Najaf,

            /// <summary>
            /// Nineveh
            /// </summary>
            [AliasInShort("NI")]
            [RegionCode(1_00_117_0014)]
            Nineveh,

            /// <summary>
            /// Al-Qādisiyyah
            /// </summary>
            [AliasInShort("QA")]
            [RegionCode(1_00_117_0015)]
            AlQādisiyyah,

            /// <summary>
            /// Saladin
            /// </summary>
            [AliasInShort("SD")]
            [RegionCode(1_00_117_0016)]
            Saladin,

            /// <summary>
            /// Sulaymaniyah
            /// </summary>
            [AliasInShort("SU")]
            [RegionCode(1_00_117_0017)]
            Sulaymaniyah,

            /// <summary>
            /// Wasit
            /// </summary>
            [AliasInShort("WA")]
            [RegionCode(1_00_117_0018)]
            Wasit,

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