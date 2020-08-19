using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Myanmar Regions
    /// </summary>
    public static partial class Myanmar
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Kachin
            /// </summary>
            public static EnumValues Kachin => EnumValues.Kachin;

            /// <summary>
            /// Kayah
            /// </summary>
            public static EnumValues Kayah => EnumValues.Kayah;

            /// <summary>
            /// Kayin
            /// </summary>
            public static EnumValues Kayin => EnumValues.Kayin;

            /// <summary>
            /// Chin
            /// </summary>
            public static EnumValues Chin => EnumValues.Chin;

            /// <summary>
            /// Mon
            /// </summary>
            public static EnumValues Mon => EnumValues.Mon;

            /// <summary>
            /// Rakhine
            /// </summary>
            public static EnumValues Rakhine => EnumValues.Rakhine;

            /// <summary>
            /// Shan
            /// </summary>
            public static EnumValues Shan => EnumValues.Shan;

            /// <summary>
            /// Naypyidaw
            /// </summary>
            public static EnumValues Naypyidaw => EnumValues.Naypyidaw;

            /// <summary>
            /// Sagaing
            /// </summary>
            public static EnumValues Sagaing => EnumValues.Sagaing;

            /// <summary>
            /// Bago
            /// </summary>
            public static EnumValues Bago => EnumValues.Bago;

            /// <summary>
            /// Magway
            /// </summary>
            public static EnumValues Magway => EnumValues.Magway;

            /// <summary>
            /// Mandalay
            /// </summary>
            public static EnumValues Mandalay => EnumValues.Mandalay;

            /// <summary>
            /// Tanintharyi
            /// </summary>
            public static EnumValues Tanintharyi => EnumValues.Tanintharyi;

            /// <summary>
            /// Yangon
            /// </summary>
            public static EnumValues Yangon => EnumValues.Yangon;

            /// <summary>
            /// Ayeyarwady
            /// </summary>
            public static EnumValues Ayeyarwady => EnumValues.Ayeyarwady;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Myanmar regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Kachin
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(1_00_127_0011)]
            Kachin,

            /// <summary>
            /// Kayah
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(1_00_127_0012)]
            Kayah,

            /// <summary>
            /// Kayin
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(1_00_127_0013)]
            Kayin,

            /// <summary>
            /// Chin
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(1_00_127_0014)]
            Chin,

            /// <summary>
            /// Mon
            /// </summary>
            [AliasInShort("15")]
            [RegionCode(1_00_127_0015)]
            Mon,

            /// <summary>
            /// Rakhine
            /// </summary>
            [AliasInShort("16")]
            [RegionCode(1_00_127_0016)]
            Rakhine,

            /// <summary>
            /// Shan
            /// </summary>
            [AliasInShort("17")]
            [RegionCode(1_00_127_0017)]
            Shan,

            /// <summary>
            /// Naypyidaw
            /// </summary>
            [AliasInShort("18")]
            [RegionCode(1_00_127_0018)]
            Naypyidaw,

            /// <summary>
            /// Sagaing
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(1_00_127_0001)]
            Sagaing,

            /// <summary>
            /// Bago
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(1_00_127_0002)]
            Bago,

            /// <summary>
            /// Magway
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(1_00_127_0003)]
            Magway,

            /// <summary>
            /// Mandalay
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(1_00_127_0004)]
            Mandalay,

            /// <summary>
            /// Tanintharyi
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(1_00_127_0005)]
            Tanintharyi,

            /// <summary>
            /// Yangon
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(1_00_127_0006)]
            Yangon,

            /// <summary>
            /// Ayeyarwady
            /// </summary>
            [AliasInShort("07")]
            [RegionCode(1_00_127_0007)]
            Ayeyarwady,

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