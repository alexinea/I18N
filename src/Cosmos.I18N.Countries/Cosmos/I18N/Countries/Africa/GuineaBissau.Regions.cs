using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Guinea Bissau regions
    /// </summary>
    public static partial  class GuineaBissau
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Bissau
        /// </summary>
        public static EnumValues Bissau => EnumValues.Bissau;

        /// <summary>
        /// Leste
        /// </summary>
        public static EnumValues Leste => EnumValues.Leste;

        /// <summary>
        /// Norte
        /// </summary>
        public static EnumValues Norte => EnumValues.Norte;

        /// <summary>
        /// Sul
        /// </summary>
        public static EnumValues Sul => EnumValues.Sul;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for GuineaBissau regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bissau
            /// </summary>
            [AliasInShort("BS")] [RegionCode(3_00_130_0001)]
            Bissau,

            /// <summary>
            /// Leste
            /// </summary>
            [AliasInShort("L")] [RegionCode(3_00_130_0002)]
            Leste,

            /// <summary>
            /// Norte
            /// </summary>
            [AliasInShort("N")] [RegionCode(3_00_130_0003)]
            Norte,

            /// <summary>
            /// Sul
            /// </summary>
            [AliasInShort("S")] [RegionCode(3_00_130_0004)]
            Sul,

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