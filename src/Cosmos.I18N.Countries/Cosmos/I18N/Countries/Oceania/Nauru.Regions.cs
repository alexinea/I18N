using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Nauru Regions
    /// </summary>
    public static partial class Nauru
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Ijuw
            /// </summary>
            public static EnumValues Ijuw => EnumValues.Ijuw;

            /// <summary>
            /// Meneng
            /// </summary>
            public static EnumValues Meneng => EnumValues.Meneng;

            /// <summary>
            /// Nibok
            /// </summary>
            public static EnumValues Nibok => EnumValues.Nibok;

            /// <summary>
            /// Uaboe
            /// </summary>
            public static EnumValues Uaboe => EnumValues.Uaboe;

            /// <summary>
            /// Yaren
            /// </summary>
            public static EnumValues Yaren => EnumValues.Yaren;

            /// <summary>
            /// Aiwo
            /// </summary>
            public static EnumValues Aiwo => EnumValues.Aiwo;

            /// <summary>
            /// Anabar
            /// </summary>
            public static EnumValues Anabar => EnumValues.Anabar;

            /// <summary>
            /// Anetan
            /// </summary>
            public static EnumValues Anetan => EnumValues.Anetan;

            /// <summary>
            /// Anibare
            /// </summary>
            public static EnumValues Anibare => EnumValues.Anibare;

            /// <summary>
            /// Baiti
            /// </summary>
            public static EnumValues Baiti => EnumValues.Baiti;

            /// <summary>
            /// Boe
            /// </summary>
            public static EnumValues Boe => EnumValues.Boe;

            /// <summary>
            /// Buada
            /// </summary>
            public static EnumValues Buada => EnumValues.Buada;

            /// <summary>
            /// Denigomodu
            /// </summary>
            public static EnumValues Denigomodu => EnumValues.Denigomodu;

            /// <summary>
            /// Ewa
            /// </summary>
            public static EnumValues Ewa => EnumValues.Ewa;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Nauru regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ijuw
            /// </summary>
            [AliasInShort("10")]
            [RegionCode(6_00_108_0010)]
            Ijuw,

            /// <summary>
            /// Meneng
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(6_00_108_0011)]
            Meneng,

            /// <summary>
            /// Nibok
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(6_00_108_0012)]
            Nibok,

            /// <summary>
            /// Uaboe
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(6_00_108_0013)]
            Uaboe,

            /// <summary>
            /// Yaren
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(6_00_108_0014)]
            Yaren,

            /// <summary>
            /// Aiwo
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(6_00_108_0001)]
            Aiwo,

            /// <summary>
            /// Anabar
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(6_00_108_0002)]
            Anabar,

            /// <summary>
            /// Anetan
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(6_00_108_0003)]
            Anetan,

            /// <summary>
            /// Anibare
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(6_00_108_0004)]
            Anibare,

            /// <summary>
            /// Baiti
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(6_00_108_0005)]
            Baiti,

            /// <summary>
            /// Boe
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(6_00_108_0006)]
            Boe,

            /// <summary>
            /// Buada
            /// </summary>
            [AliasInShort("07")]
            [RegionCode(6_00_108_0007)]
            Buada,

            /// <summary>
            /// Denigomodu
            /// </summary>
            [AliasInShort("08")]
            [RegionCode(6_00_108_0008)]
            Denigomodu,

            /// <summary>
            /// Ewa
            /// </summary>
            [AliasInShort("09")]
            [RegionCode(6_00_108_0009)]
            Ewa,

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