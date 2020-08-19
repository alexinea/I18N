using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Singapore Regions
    /// </summary>
    public static partial class Singapore
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Central Singapore
            /// </summary>
            public static EnumValues CentralSingapore => EnumValues.CentralSingapore;

            /// <summary>
            /// North East
            /// </summary>
            public static EnumValues NorthEast => EnumValues.NorthEast;

            /// <summary>
            /// North West
            /// </summary>
            public static EnumValues NorthWest => EnumValues.NorthWest;

            /// <summary>
            /// South East
            /// </summary>
            public static EnumValues SouthEast => EnumValues.SouthEast;

            /// <summary>
            /// South West
            /// </summary>
            public static EnumValues SouthWest => EnumValues.SouthWest;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Singapore regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Central Singapore
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(1_00_134_0001)]
            CentralSingapore,

            /// <summary>
            /// North East
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(1_00_134_0002)]
            NorthEast,

            /// <summary>
            /// North West
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(1_00_134_0003)]
            NorthWest,

            /// <summary>
            /// South East
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(1_00_134_0004)]
            SouthEast,

            /// <summary>
            /// South West
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(1_00_134_0005)]
            SouthWest,

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