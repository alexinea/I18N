using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Kiribati Regions
    /// </summary>
    public static partial class Kiribati
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Gilbert Islands
            /// </summary>
            public static EnumValues GilbertIslands => EnumValues.GilbertIslands;

            /// <summary>
            /// Line Islands
            /// </summary>
            public static EnumValues LineIslands => EnumValues.LineIslands;

            /// <summary>
            /// Phoenix Islands
            /// </summary>
            public static EnumValues PhoenixIslands => EnumValues.PhoenixIslands;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Kiribati regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Gilbert Islands
            /// </summary>
            [AliasInShort("G")]
            [RegionCode(6_00_105_0001)]
            GilbertIslands,

            /// <summary>
            /// Line Islands
            /// </summary>
            [AliasInShort("L")]
            [RegionCode(6_00_105_0002)]
            LineIslands,

            /// <summary>
            /// Phoenix Islands
            /// </summary>
            [AliasInShort("P")]
            [RegionCode(6_00_105_0003)]
            PhoenixIslands,

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