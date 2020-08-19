using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Fiji Regions
    /// </summary>
    public static partial class Fiji
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Namosi
            /// </summary>
            public static EnumValues Namosi => EnumValues.Namosi;

            /// <summary>
            /// Ra
            /// </summary>
            public static EnumValues Ra => EnumValues.Ra;

            /// <summary>
            /// Rewa
            /// </summary>
            public static EnumValues Rewa => EnumValues.Rewa;

            /// <summary>
            /// Serua
            /// </summary>
            public static EnumValues Serua => EnumValues.Serua;

            /// <summary>
            /// Tailevu
            /// </summary>
            public static EnumValues Tailevu => EnumValues.Tailevu;

            /// <summary>
            /// Ba
            /// </summary>
            public static EnumValues Ba => EnumValues.Ba;

            /// <summary>
            /// Bua
            /// </summary>
            public static EnumValues Bua => EnumValues.Bua;

            /// <summary>
            /// Cakaudrove
            /// </summary>
            public static EnumValues Cakaudrove => EnumValues.Cakaudrove;

            /// <summary>
            /// Kadavu
            /// </summary>
            public static EnumValues Kadavu => EnumValues.Kadavu;

            /// <summary>
            /// Lau
            /// </summary>
            public static EnumValues Lau => EnumValues.Lau;

            /// <summary>
            /// Lomaiviti
            /// </summary>
            public static EnumValues Lomaiviti => EnumValues.Lomaiviti;

            /// <summary>
            /// Valparaíso
            /// </summary>
            public static EnumValues Macuata => EnumValues.Macuata;

            /// <summary>
            /// Nadroga-Navosa
            /// </summary>
            public static EnumValues NadrogaNavosa => EnumValues.NadrogaNavosa;

            /// <summary>
            /// Naitasiri
            /// </summary>
            public static EnumValues Naitasiri => EnumValues.Naitasiri;

            /// <summary>
            /// Central
            /// </summary>
            public static EnumValues Central => EnumValues.Central;

            /// <summary>
            /// Eastern
            /// </summary>
            public static EnumValues Eastern => EnumValues.Eastern;

            /// <summary>
            /// Northern
            /// </summary>
            public static EnumValues Northern => EnumValues.Northern;

            /// <summary>
            /// Rotuma
            /// </summary>
            public static EnumValues Rotuma => EnumValues.Rotuma;

            /// <summary>
            /// Western
            /// </summary>
            public static EnumValues Western => EnumValues.Western;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Fiji regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Namosi
            /// </summary>
            [AliasInShort("10")]
            [RegionCode(6_00_103_0010)]
            Namosi,

            /// <summary>
            /// Ra
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(6_00_103_0011)]
            Ra,

            /// <summary>
            /// Rewa
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(6_00_103_0012)]
            Rewa,

            /// <summary>
            /// Serua
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(6_00_103_0013)]
            Serua,

            /// <summary>
            /// Tailevu
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(6_00_103_0014)]
            Tailevu,

            /// <summary>
            /// Ba
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(6_00_103_0001)]
            Ba,

            /// <summary>
            /// Bua
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(6_00_103_0002)]
            Bua,

            /// <summary>
            /// Cakaudrove
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(6_00_103_0003)]
            Cakaudrove,

            /// <summary>
            /// Kadavu
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(6_00_103_0004)]
            Kadavu,

            /// <summary>
            /// Lau
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(6_00_103_0005)]
            Lau,

            /// <summary>
            /// Lomaiviti
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(6_00_103_0006)]
            Lomaiviti,

            /// <summary>
            /// Macuata
            /// </summary>
            [AliasInShort("07")]
            [RegionCode(6_00_103_0007)]
            Macuata,

            /// <summary>
            /// Nadroga-Navosa
            /// </summary>
            [AliasInShort("08")]
            [RegionCode(6_00_103_0008)]
            NadrogaNavosa,

            /// <summary>
            /// Naitasiri
            /// </summary>
            [AliasInShort("09")]
            [RegionCode(6_00_103_0009)]
            Naitasiri,

            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("C")]
            [RegionCode(6_00_103_0020)]
            Central,

            /// <summary>
            /// Eastern
            /// </summary>
            [AliasInShort("E")]
            [RegionCode(6_00_103_0021)]
            Eastern,

            /// <summary>
            /// Northern
            /// </summary>
            [AliasInShort("N")]
            [RegionCode(6_00_103_0022)]
            Northern,

            /// <summary>
            /// Rotuma
            /// </summary>
            [AliasInShort("R")]
            [RegionCode(6_00_103_0023)]
            Rotuma,

            /// <summary>
            /// Western
            /// </summary>
            [AliasInShort("W")]
            [RegionCode(6_00_103_0024)]
            Western,

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