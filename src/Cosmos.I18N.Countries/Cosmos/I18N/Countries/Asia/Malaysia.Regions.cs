using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Malaysia Regions
    /// </summary>
    public static partial class Malaysia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Selangor
            /// </summary>
            public static EnumValues Selangor => EnumValues.Selangor;

            /// <summary>
            /// Terengganu
            /// </summary>
            public static EnumValues Terengganu => EnumValues.Terengganu;

            /// <summary>
            /// Sabah
            /// </summary>
            public static EnumValues Sabah => EnumValues.Sabah;

            /// <summary>
            /// Sarawak
            /// </summary>
            public static EnumValues Sarawak => EnumValues.Sarawak;

            /// <summary>
            /// Kuala Lumpur
            /// </summary>
            public static EnumValues KualaLumpur => EnumValues.KualaLumpur;

            /// <summary>
            /// Labuan
            /// </summary>
            public static EnumValues Labuan => EnumValues.Labuan;

            /// <summary>
            /// Putrajaya
            /// </summary>
            public static EnumValues Putrajaya => EnumValues.Putrajaya;

            /// <summary>
            /// Johor   
            /// </summary>
            public static EnumValues Johor => EnumValues.Johor;

            /// <summary>
            /// Kedah
            /// </summary>
            public static EnumValues Kedah => EnumValues.Kedah;

            /// <summary>
            /// Kelantan
            /// </summary>
            public static EnumValues Kelantan => EnumValues.Kelantan;

            /// <summary>
            /// Malacca
            /// </summary>
            public static EnumValues Malacca => EnumValues.Malacca;

            /// <summary>
            /// Negeri Sembilan
            /// </summary>
            public static EnumValues NegeriSembilan => EnumValues.NegeriSembilan;

            /// <summary>
            /// Pahang
            /// </summary>
            public static EnumValues Pahang => EnumValues.Pahang;

            /// <summary>
            /// Penang
            /// </summary>
            public static EnumValues Penang => EnumValues.Penang;

            /// <summary>
            /// Perak
            /// </summary>
            public static EnumValues Perak => EnumValues.Perak;

            /// <summary>
            /// Perlis
            /// </summary>
            public static EnumValues Perlis => EnumValues.Perlis;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Malaysia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Selangor
            /// </summary>
            [AliasInShort("10")]
            [RegionCode(1_00_124_0010)]
            Selangor,

            /// <summary>
            /// Terengganu
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(1_00_124_0011)]
            Terengganu,

            /// <summary>
            /// Sabah
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(1_00_124_0012)]
            Sabah,

            /// <summary>
            /// Sarawak
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(1_00_124_0013)]
            Sarawak,

            /// <summary>
            /// Kuala Lumpur
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(1_00_124_0014)]
            KualaLumpur,

            /// <summary>
            /// Labuan
            /// </summary>
            [AliasInShort("15")]
            [RegionCode(1_00_124_0015)]
            Labuan,

            /// <summary>
            /// Putrajaya
            /// </summary>
            [AliasInShort("16")]
            [RegionCode(1_00_124_0016)]
            Putrajaya,

            /// <summary>
            /// Johor
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(1_00_124_0001)]
            Johor,

            /// <summary>
            /// Kedah
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(1_00_124_0002)]
            Kedah,

            /// <summary>
            /// Kelantan
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(1_00_124_0003)]
            Kelantan,

            /// <summary>
            /// Malacca
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(1_00_124_0004)]
            Malacca,

            /// <summary>
            /// Negeri Sembilan
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(1_00_124_0005)]
            NegeriSembilan,

            /// <summary>
            /// Pahang
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(1_00_124_0006)]
            Pahang,

            /// <summary>
            /// Penang
            /// </summary>
            [AliasInShort("07")]
            [RegionCode(1_00_124_0007)]
            Penang,

            /// <summary>
            /// Perak
            /// </summary>
            [AliasInShort("08")]
            [RegionCode(1_00_124_0008)]
            Perak,

            /// <summary>
            /// Perlis
            /// </summary>
            [AliasInShort("09")]
            [RegionCode(1_00_124_0009)]
            Perlis,

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