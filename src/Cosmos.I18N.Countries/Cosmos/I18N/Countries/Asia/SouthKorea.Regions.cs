using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// South Korea Regions
    /// </summary>
    public static partial class SouthKorea
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Seoul
            /// </summary>
            public static EnumValues Seoul => EnumValues.Seoul;

            /// <summary>
            /// Busan
            /// </summary>
            public static EnumValues Busan => EnumValues.Busan;

            /// <summary>
            /// Daegu
            /// </summary>
            public static EnumValues Daegu => EnumValues.Daegu;

            /// <summary>
            /// Incheon
            /// </summary>
            public static EnumValues Incheon => EnumValues.Incheon;

            /// <summary>
            /// Gwangju City
            /// </summary>
            public static EnumValues GwangjuCity => EnumValues.GwangjuCity;

            /// <summary>
            /// Daejeon
            /// </summary>
            public static EnumValues Daejeon => EnumValues.Daejeon;

            /// <summary>
            /// Ulsan
            /// </summary>
            public static EnumValues Ulsan => EnumValues.Ulsan;

            /// <summary>
            /// Gyeonggi
            /// </summary>
            public static EnumValues Gyeonggi => EnumValues.Gyeonggi;

            /// <summary>
            /// Gangwon
            /// </summary>
            public static EnumValues Gangwon => EnumValues.Gangwon;

            /// <summary>
            /// North Chungcheong
            /// </summary>
            public static EnumValues NorthChungcheong => EnumValues.NorthChungcheong;

            /// <summary>
            /// South Chungcheong
            /// </summary>
            public static EnumValues SouthChungcheong => EnumValues.SouthChungcheong;

            /// <summary>
            /// North Jeolla
            /// </summary>
            public static EnumValues NorthJeolla => EnumValues.NorthJeolla;

            /// <summary>
            /// South Jeolla
            /// </summary>
            public static EnumValues SouthJeolla => EnumValues.SouthJeolla;

            /// <summary>
            /// North Gyeongsang
            /// </summary>
            public static EnumValues NorthGyeongsang => EnumValues.NorthGyeongsang;

            /// <summary>
            /// South Gyeongsang
            /// </summary>
            public static EnumValues SouthGyeongsang => EnumValues.SouthGyeongsang;

            /// <summary>
            /// Jeju
            /// </summary>
            public static EnumValues Jeju => EnumValues.Jeju;

            /// <summary>
            /// Sejong
            /// </summary>
            public static EnumValues Sejong => EnumValues.Sejong;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for SouthKorea regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Seoul
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(1_00_012_0011)]
            Seoul,

            /// <summary>
            /// Busan
            /// </summary>
            [AliasInShort("26")]
            [RegionCode(1_00_012_0026)]
            Busan,

            /// <summary>
            /// Daegu
            /// </summary>
            [AliasInShort("27")]
            [RegionCode(1_00_012_0027)]
            Daegu,

            /// <summary>
            /// Incheon
            /// </summary>
            [AliasInShort("28")]
            [RegionCode(1_00_012_0028)]
            Incheon,

            /// <summary>
            /// Gwangju City
            /// </summary>
            [AliasInShort("29")]
            [RegionCode(1_00_012_0029)]
            GwangjuCity,

            /// <summary>
            /// Daejeon
            /// </summary>
            [AliasInShort("30")]
            [RegionCode(1_00_012_0030)]
            Daejeon,

            /// <summary>
            /// Ulsan
            /// </summary>
            [AliasInShort("31")]
            [RegionCode(1_00_012_0031)]
            Ulsan,

            /// <summary>
            /// Gyeonggi
            /// </summary>
            [AliasInShort("41")]
            [RegionCode(1_00_012_0041)]
            Gyeonggi,

            /// <summary>
            /// Gangwon
            /// </summary>
            [AliasInShort("42")]
            [RegionCode(1_00_012_0042)]
            Gangwon,

            /// <summary>
            /// North Chungcheong
            /// </summary>
            [AliasInShort("43")]
            [RegionCode(1_00_012_0043)]
            NorthChungcheong,

            /// <summary>
            /// South Chungcheong
            /// </summary>
            [AliasInShort("44")]
            [RegionCode(1_00_012_0044)]
            SouthChungcheong,

            /// <summary>
            /// North Jeolla
            /// </summary>
            [AliasInShort("45")]
            [RegionCode(1_00_012_0045)]
            NorthJeolla,

            /// <summary>
            /// South Jeolla
            /// </summary>
            [AliasInShort("46")]
            [RegionCode(1_00_012_0046)]
            SouthJeolla,

            /// <summary>
            /// North Gyeongsang
            /// </summary>
            [AliasInShort("47")]
            [RegionCode(1_00_012_0047)]
            NorthGyeongsang,

            /// <summary>
            /// South Gyeongsang
            /// </summary>
            [AliasInShort("48")]
            [RegionCode(1_00_012_0048)]
            SouthGyeongsang,

            /// <summary>
            /// Jeju
            /// </summary>
            [AliasInShort("49")]
            [RegionCode(1_00_012_0049)]
            Jeju,

            /// <summary>
            /// Sejong
            /// </summary>
            [AliasInShort("50")]
            [RegionCode(1_00_012_0050)]
            Sejong,

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