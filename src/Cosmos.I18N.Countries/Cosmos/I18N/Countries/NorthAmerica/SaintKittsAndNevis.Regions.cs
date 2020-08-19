using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// SaintKittsAndNevis Regions
    /// </summary>
    public static partial class SaintKittsAndNevis
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Saint Kitts
            /// </summary>
            public static EnumValues SaintKitts => EnumValues.SaintKitts;

            /// <summary>
            /// Nevis
            /// </summary>
            public static EnumValues Nevis => EnumValues.Nevis;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for SaintKittsAndNevis regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Saint Kitts
            /// </summary>
            [AliasInShort("K")]
            [RegionCode(4_00_128_0001)]
            SaintKitts,

            /// <summary>
            /// Nevis
            /// </summary>
            [AliasInShort("N")]
            [RegionCode(4_00_128_0002)]
            Nevis,

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