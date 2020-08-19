using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// Venezuela Regions
    /// </summary>
    public static partial class Venezuela
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Anzoátegui
            /// </summary>
            public static EnumValues Anzoátegui => EnumValues.Anzoátegui;

            /// <summary>
            /// Carabobo
            /// </summary>
            public static EnumValues Carabobo => EnumValues.Carabobo;

            /// <summary>
            /// Lara
            /// </summary>
            public static EnumValues Lara => EnumValues.Lara;

            /// <summary>
            /// Miranda
            /// </summary>
            public static EnumValues Miranda => EnumValues.Miranda;

            /// <summary>
            /// Monagas
            /// </summary>
            public static EnumValues Monagas => EnumValues.Monagas;

            /// <summary>
            /// Táchira
            /// </summary>
            public static EnumValues Táchira => EnumValues.Táchira;

            /// <summary>
            /// Zulia
            /// </summary>
            public static EnumValues Zulia => EnumValues.Zulia;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Venezuela regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Anzoátegui
            /// </summary>
            [AliasInShort("B")]
            [RegionCode(5_00_013_0001)]
            Anzoátegui,

            /// <summary>
            /// Carabobo
            /// </summary>
            [AliasInShort("G")]
            [RegionCode(5_00_013_0002)]
            Carabobo,

            /// <summary>
            /// Lara
            /// </summary>
            [AliasInShort("K")]
            [RegionCode(5_00_013_0003)]
            Lara,

            /// <summary>
            /// Miranda
            /// </summary>
            [AliasInShort("M")]
            [RegionCode(5_00_013_0004)]
            Miranda,

            /// <summary>
            /// Monagas
            /// </summary>
            [AliasInShort("N")]
            [RegionCode(5_00_013_0005)]
            Monagas,

            /// <summary>
            /// Táchira
            /// </summary>
            [AliasInShort("S")]
            [RegionCode(5_00_013_0006)]
            Táchira,

            /// <summary>
            /// Zulia
            /// </summary>
            [AliasInShort("V")]
            [RegionCode(5_00_013_0007)]
            Zulia,

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