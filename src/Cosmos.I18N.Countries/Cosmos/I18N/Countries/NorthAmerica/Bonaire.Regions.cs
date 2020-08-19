using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Bonaire Regions
    /// </summary>
    public static partial class Bonaire
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Bonaire
            /// </summary>
            public static EnumValues Bonaire => EnumValues.Bonaire;

            /// <summary>
            /// Saba
            /// </summary>
            public static EnumValues Saba => EnumValues.Saba;

            /// <summary>
            /// Sint Eustatius
            /// </summary>
            public static EnumValues SintEustatius => EnumValues.SintEustatius;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Bonaire regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bonaire
            /// </summary>
            [AliasInShort("BO")]
            [RegionCode(4_00_109_0001)]
            Bonaire,

            /// <summary>
            /// Saba
            /// </summary>
            [AliasInShort("SA")]
            [RegionCode(4_00_109_0002)]
            Saba,

            /// <summary>
            /// Sint Eustatius
            /// </summary>
            [AliasInShort("SE")]
            [RegionCode(4_00_109_0003)]
            SintEustatius,

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