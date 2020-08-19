using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Comoros Regions
    /// </summary>
    public static partial class Comoros
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

            /// <summary>
            /// Anjouan
            /// </summary>
            public static EnumValues Anjouan => EnumValues.Anjouan;

            /// <summary>
            /// Grande Comore
            /// </summary>
            public static EnumValues GrandeComore => EnumValues.GrandeComore;

            /// <summary>
            /// Mohéli
            /// </summary>
            public static EnumValues Mohéli => EnumValues.Mohéli;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Comoros regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Gilbert Islands
            /// </summary>
            [AliasInShort("A")]
            [RegionCode(3_00_111_0001)]
            Anjouan,

            /// <summary>
            /// Grande Comore
            /// </summary>
            [AliasInShort("G")]
            [RegionCode(3_00_111_0002)]
            GrandeComore,

            /// <summary>
            /// Mohéli
            /// </summary>
            [AliasInShort("M")]
            [RegionCode(3_00_111_0003)]
            Mohéli,

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