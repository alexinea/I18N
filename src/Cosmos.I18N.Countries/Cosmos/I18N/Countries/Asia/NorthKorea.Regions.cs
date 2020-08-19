using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// North Korea Regions
    /// </summary>
    public static partial class NorthKorea
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Ryanggang
            /// </summary>
            public static EnumValues Ryanggang => EnumValues.Ryanggang;

            /// <summary>
            /// Rason
            /// </summary>
            public static EnumValues Rason => EnumValues.Rason;

            /// <summary>
            /// Pyongyang
            /// </summary>
            public static EnumValues Pyongyang => EnumValues.Pyongyang;

            /// <summary>
            /// South Pyongan
            /// </summary>
            public static EnumValues SouthPyongan => EnumValues.SouthPyongan;

            /// <summary>
            /// North Pyongan
            /// </summary>
            public static EnumValues NorthPyongan => EnumValues.NorthPyongan;

            /// <summary>
            /// Chagang
            /// </summary>
            public static EnumValues Chagang => EnumValues.Chagang;

            /// <summary>
            /// South Hwanghae
            /// </summary>
            public static EnumValues SouthHwanghae => EnumValues.SouthHwanghae;

            /// <summary>
            /// North Hwanghae
            /// </summary>
            public static EnumValues NorthHwanghae => EnumValues.NorthHwanghae;

            /// <summary>
            /// Kangwon
            /// </summary>
            public static EnumValues Kangwon => EnumValues.Kangwon;

            /// <summary>
            /// South Hamgyong
            /// </summary>
            public static EnumValues SouthHamgyong => EnumValues.SouthHamgyong;

            /// <summary>
            /// North Hamgyong
            /// </summary>
            public static EnumValues NorthHamgyong => EnumValues.NorthHamgyong;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for NorthKorea regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ryanggang
            /// </summary>
            [AliasInShort("10")]
            [RegionCode(1_00_011_0010)]
            Ryanggang,

            /// <summary>
            /// Rason
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(1_00_011_0013)]
            Rason,

            /// <summary>
            /// Pyongyang
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(1_00_011_0001)]
            Pyongyang,

            /// <summary>
            /// South Pyongan
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(1_00_011_0002)]
            SouthPyongan,

            /// <summary>
            /// North Pyongan
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(1_00_011_0003)]
            NorthPyongan,

            /// <summary>
            /// Chagang
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(1_00_011_0004)]
            Chagang,

            /// <summary>
            /// South Hwanghae
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(1_00_011_0005)]
            SouthHwanghae,

            /// <summary>
            /// North Hwanghae
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(1_00_011_0006)]
            NorthHwanghae,

            /// <summary>
            /// Kangwon
            /// </summary>
            [AliasInShort("07")]
            [RegionCode(1_00_011_0007)]
            Kangwon,

            /// <summary>
            /// South Hamgyong
            /// </summary>
            [AliasInShort("08")]
            [RegionCode(1_00_011_0008)]
            SouthHamgyong,

            /// <summary>
            /// North Hamgyong
            /// </summary>
            [AliasInShort("09")]
            [RegionCode(1_00_011_0009)]
            NorthHamgyong,

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