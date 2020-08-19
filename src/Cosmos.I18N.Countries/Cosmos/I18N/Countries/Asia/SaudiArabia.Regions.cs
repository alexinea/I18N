using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// SaudiArabia Regions
    /// </summary>
    public static partial class SaudiArabia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Najran
            /// </summary>
            public static EnumValues Najran => EnumValues.Najran;

            /// <summary>
            /// Al Bahah
            /// </summary>
            public static EnumValues AlBahah => EnumValues.AlBahah;

            /// <summary>
            /// Al Jawf
            /// </summary>
            public static EnumValues AlJawf => EnumValues.AlJawf;

            /// <summary>
            /// Asir
            /// </summary>
            public static EnumValues Asir => EnumValues.Asir;

            /// <summary>
            /// Riyadh
            /// </summary>
            public static EnumValues Riyadh => EnumValues.Riyadh;

            /// <summary>
            /// Makkah
            /// </summary>
            public static EnumValues Makkah => EnumValues.Makkah;

            /// <summary>
            /// Al Madinah
            /// </summary>
            public static EnumValues AlMadinah => EnumValues.AlMadinah;

            /// <summary>
            /// Eastern
            /// </summary>
            public static EnumValues Eastern => EnumValues.Eastern;

            /// <summary>
            /// Al-Qassim
            /// </summary>
            public static EnumValues AlQassim => EnumValues.AlQassim;

            /// <summary>
            /// Ha’il
            /// </summary>
            public static EnumValues Hail => EnumValues.Hail;

            /// <summary>
            /// Tabuk
            /// </summary>
            public static EnumValues Tabuk => EnumValues.Tabuk;

            /// <summary>
            /// Northern Borders
            /// </summary>
            public static EnumValues NorthernBorders => EnumValues.NorthernBorders;

            /// <summary>
            /// Jizan
            /// </summary>
            public static EnumValues Jizan => EnumValues.Jizan;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for SaudiArabia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Najran
            /// </summary>
            [AliasInShort("10")]
            [RegionCode(1_00_133_0010)]
            Najran,

            /// <summary>
            /// Al Bahah
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(1_00_133_0011)]
            AlBahah,

            /// <summary>
            /// Al Jawf
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(1_00_133_0012)]
            AlJawf,

            /// <summary>
            /// Asir
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(1_00_133_0014)]
            Asir,

            /// <summary>
            /// Riyadh
            /// </summary>
            [AliasInShort("1")]
            [RegionCode(1_00_133_0001)]
            Riyadh,

            /// <summary>
            /// Makkah
            /// </summary>
            [AliasInShort("2")]
            [RegionCode(1_00_133_0002)]
            Makkah,

            /// <summary>
            /// Al Madinah
            /// </summary>
            [AliasInShort("3")]
            [RegionCode(1_00_133_0003)]
            AlMadinah,

            /// <summary>
            /// Eastern
            /// </summary>
            [AliasInShort("4")]
            [RegionCode(1_00_133_0004)]
            Eastern,

            /// <summary>
            /// Al-Qassim
            /// </summary>
            [AliasInShort("5")]
            [RegionCode(1_00_133_0005)]
            AlQassim,

            /// <summary>
            /// Ha’il
            /// </summary>
            [AliasInShort("6")]
            [RegionCode(1_00_133_0006)]
            Hail,

            /// <summary>
            /// Tabuk
            /// </summary>
            [AliasInShort("7")]
            [RegionCode(1_00_133_0007)]
            Tabuk,

            /// <summary>
            /// Northern Borders
            /// </summary>
            [AliasInShort("8")]
            [RegionCode(1_00_133_0008)]
            NorthernBorders,

            /// <summary>
            /// Jizan
            /// </summary>
            [AliasInShort("9")]
            [RegionCode(1_00_133_0009)]
            Jizan,

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