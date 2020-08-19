using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Suriname Regions
    /// </summary>
    public static partial class Suriname
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Brokopondo
            /// </summary>
            public static EnumValues Brokopondo => EnumValues.Brokopondo;

            /// <summary>
            /// Commewijne
            /// </summary>
            public static EnumValues Commewijne => EnumValues.Commewijne;

            /// <summary>
            /// Coronie
            /// </summary>
            public static EnumValues Coronie => EnumValues.Coronie;

            /// <summary>
            /// Marowijne
            /// </summary>
            public static EnumValues Marowijne => EnumValues.Marowijne;

            /// <summary>
            /// Nickerie
            /// </summary>
            public static EnumValues Nickerie => EnumValues.Nickerie;

            /// <summary>
            /// Paramaribo
            /// </summary>
            public static EnumValues Paramaribo => EnumValues.Paramaribo;

            /// <summary>
            /// Para
            /// </summary>
            public static EnumValues Para => EnumValues.Para;

            /// <summary>
            /// Saramacca 
            /// </summary>
            public static EnumValues Saramacca => EnumValues.Saramacca;

            /// <summary>
            /// Sipaliwini
            /// </summary>
            public static EnumValues Sipaliwini => EnumValues.Sipaliwini;

            /// <summary>
            /// Wanica
            /// </summary>
            public static EnumValues Wanica => EnumValues.Wanica;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Suriname regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Brokopondo
            /// </summary>
            [AliasInShort("BR")]
            [RegionCode(3_00_150_0001)]
            Brokopondo,

            /// <summary>
            /// Commewijne
            /// </summary>
            [AliasInShort("CM")]
            [RegionCode(3_00_150_0002)]
            Commewijne,

            /// <summary>
            /// Coronie
            /// </summary>
            [AliasInShort("CR")]
            [RegionCode(3_00_150_0003)]
            Coronie,

            /// <summary>
            /// Marowijne
            /// </summary>
            [AliasInShort("MA")]
            [RegionCode(3_00_150_0004)]
            Marowijne,

            /// <summary>
            /// Nickerie
            /// </summary>
            [AliasInShort("NI")]
            [RegionCode(3_00_150_0005)]
            Nickerie,

            /// <summary>
            /// Paramaribo
            /// </summary>
            [AliasInShort("PA")]
            [RegionCode(3_00_150_0006)]
            Paramaribo,

            /// <summary>
            /// Para
            /// </summary>
            [AliasInShort("PR")]
            [RegionCode(3_00_150_0007)]
            Para,

            /// <summary>
            /// Saramacca
            /// </summary>
            [AliasInShort("SA")]
            [RegionCode(3_00_150_0008)]
            Saramacca,

            /// <summary>
            /// Sipaliwini
            /// </summary>
            [AliasInShort("SI")]
            [RegionCode(3_00_150_0009)]
            Sipaliwini,

            /// <summary>
            /// Wanica
            /// </summary>
            [AliasInShort("WA")]
            [RegionCode(3_00_150_0010)]
            Wanica,

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