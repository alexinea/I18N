using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// MarshallIslands Regions
    /// </summary>
    public static partial class MarshallIslands
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Ralik Chain
            /// </summary>
            public static EnumValues RalikChain => EnumValues.RalikChain;

            /// <summary>
            /// Ratak Chain
            /// </summary>
            public static EnumValues RatakChain => EnumValues.RatakChain;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for MarshallIslands regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ralik Chain
            /// </summary>
            [AliasInShort("L")]
            [RegionCode(6_00_106_0001)]
            RalikChain,

            /// <summary>
            /// Ratak Chain
            /// </summary>
            [AliasInShort("T")]
            [RegionCode(6_00_106_0002)]
            RatakChain,

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