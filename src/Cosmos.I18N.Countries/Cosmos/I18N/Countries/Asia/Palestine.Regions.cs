using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Palestine Regions
    /// </summary>
    public static partial class Palestine
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Bethlehem
            /// </summary>
            public static EnumValues Bethlehem => EnumValues.Bethlehem;

            /// <summary>
            /// Deir al-Balah
            /// </summary>
            public static EnumValues DeirAlBalah => EnumValues.DeirAlBalah;

            /// <summary>
            /// Gaza
            /// </summary>
            public static EnumValues Gaza => EnumValues.Gaza;

            /// <summary>
            /// Hebron
            /// </summary>
            public static EnumValues Hebron => EnumValues.Hebron;

            /// <summary>
            /// Jerusalem
            /// </summary>
            public static EnumValues Jerusalem => EnumValues.Jerusalem;

            /// <summary>
            /// Jenin
            /// </summary>
            public static EnumValues Jenin => EnumValues.Jenin;

            /// <summary>
            /// Jericho
            /// </summary>
            public static EnumValues Jericho => EnumValues.Jericho;

            /// <summary>
            /// Khan Yunis    
            /// </summary>
            public static EnumValues KhanYunis => EnumValues.KhanYunis;

            /// <summary>
            /// Nablus
            /// </summary>
            public static EnumValues Nablus => EnumValues.Nablus;

            /// <summary>
            /// North Gaza
            /// </summary>
            public static EnumValues NorthGaza => EnumValues.NorthGaza;

            /// <summary>
            /// Qalqilya
            /// </summary>
            public static EnumValues Qalqilya => EnumValues.Qalqilya;

            /// <summary>
            /// Ramallah and al-Bireh
            /// </summary>
            public static EnumValues RamallahAndAlBireh => EnumValues.RamallahAndAlBireh;

            /// <summary>
            /// Rafah
            /// </summary>
            public static EnumValues Rafah => EnumValues.Rafah;

            /// <summary>
            /// Salfit
            /// </summary>
            public static EnumValues Salfit => EnumValues.Salfit;

            /// <summary>
            /// Tubas
            /// </summary>
            public static EnumValues Tubas => EnumValues.Tubas;

            /// <summary>
            /// Tulkarm
            /// </summary>
            public static EnumValues Tulkarm => EnumValues.Tulkarm;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Palestine regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bethlehem
            /// </summary>
            [AliasInShort("BTH")]
            [RegionCode(1_00_130_0001)]
            Bethlehem,

            /// <summary>
            /// Deir al-Balah
            /// </summary>
            [AliasInShort("DEB")]
            [RegionCode(1_00_130_0002)]
            DeirAlBalah,

            /// <summary>
            /// Gaza
            /// </summary>
            [AliasInShort("GZA")]
            [RegionCode(1_00_130_0003)]
            Gaza,

            /// <summary>
            /// Hebron
            /// </summary>
            [AliasInShort("HBN")]
            [RegionCode(1_00_130_0004)]
            Hebron,

            /// <summary>
            /// Jerusalem
            /// </summary>
            [AliasInShort("JEM")]
            [RegionCode(1_00_130_0005)]
            Jerusalem,

            /// <summary>
            /// Jenin
            /// </summary>
            [AliasInShort("JEN")]
            [RegionCode(1_00_130_0006)]
            Jenin,

            /// <summary>
            /// Jericho
            /// </summary>
            [AliasInShort("JRH")]
            [RegionCode(1_00_130_0007)]
            Jericho,

            /// <summary>
            /// Khan Yunis
            /// </summary>
            [AliasInShort("KYS")]
            [RegionCode(1_00_130_0008)]
            KhanYunis,

            /// <summary>
            /// Nablus
            /// </summary>
            [AliasInShort("NBS")]
            [RegionCode(1_00_130_0009)]
            Nablus,

            /// <summary>
            /// North Gaza
            /// </summary>
            [AliasInShort("MGZ")]
            [RegionCode(1_00_130_0010)]
            NorthGaza,

            /// <summary>
            /// Qalqilya
            /// </summary>
            [AliasInShort("QQA")]
            [RegionCode(1_00_130_0011)]
            Qalqilya,

            /// <summary>
            /// Ramallah and al-Bireh
            /// </summary>
            [AliasInShort("RBH")]
            [RegionCode(1_00_130_0012)]
            RamallahAndAlBireh,

            /// <summary>
            /// Rafah
            /// </summary>
            [AliasInShort("RFH")]
            [RegionCode(1_00_130_0013)]
            Rafah,

            /// <summary>
            /// Salfit
            /// </summary>
            [AliasInShort("SLT")]
            [RegionCode(1_00_130_0014)]
            Salfit,

            /// <summary>
            /// Tubas
            /// </summary>
            [AliasInShort("TBS")]
            [RegionCode(1_00_130_0015)]
            Tubas,

            /// <summary>
            /// Tulkarm
            /// </summary>
            [AliasInShort("TKM")]
            [RegionCode(1_00_130_0016)]
            Tulkarm,

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