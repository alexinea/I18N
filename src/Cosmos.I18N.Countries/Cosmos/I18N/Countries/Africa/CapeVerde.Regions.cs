using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// CapeVerde regions
    /// </summary>
    public static partial class CapeVerde
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

            /// <summary>
            /// Barlavento Islands
            /// </summary>
            public static EnumValues BarlaventoIslands => EnumValues.BarlaventoIslands;

            /// <summary>
            /// Sotavento Islands
            /// </summary>
            public static EnumValues SotaventoIslands => EnumValues.SotaventoIslands;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for CapeVerde regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Barlavento Islands
            /// </summary>
            [AliasInShort("B")]
            [RegionCode(3_00_106_0001)]
            BarlaventoIslands,

            /// <summary>
            /// Sotavento Islands
            /// </summary>
            [AliasInShort("S")]
            [RegionCode(3_00_106_0002)]
            SotaventoIslands,

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