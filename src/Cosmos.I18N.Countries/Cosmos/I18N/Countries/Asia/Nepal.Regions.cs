using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Nepal Regions
    /// </summary>
    public static partial class Nepal
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Central
            /// </summary>
            public static EnumValues Central => EnumValues.Central;

            /// <summary>
            /// Madhya Pashchimanchal
            /// </summary>
            public static EnumValues MadhyaPashchimanchal => EnumValues.MadhyaPashchimanchal;

            /// <summary>
            /// Western
            /// </summary>
            public static EnumValues Western => EnumValues.Western;

            /// <summary>
            /// Purwanchal
            /// </summary>
            public static EnumValues Purwanchal => EnumValues.Purwanchal;

            /// <summary>
            /// Sudur Pashchimanchal
            /// </summary>
            public static EnumValues SudurPashchimanchal => EnumValues.SudurPashchimanchal;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Nepal regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("1")]
            [RegionCode(1_00_128_0001)]
            Central,

            /// <summary>
            /// Madhya Pashchimanchal
            /// </summary>
            [AliasInShort("2")]
            [RegionCode(1_00_128_0002)]
            MadhyaPashchimanchal,

            /// <summary>
            /// Western
            /// </summary>
            [AliasInShort("3")]
            [RegionCode(1_00_128_0003)]
            Western,

            /// <summary>
            /// Purwanchal
            /// </summary>
            [AliasInShort("4")]
            [RegionCode(1_00_128_0004)]
            Purwanchal,

            /// <summary>
            /// Sudur Pashchimanchal
            /// </summary>
            [AliasInShort("5")]
            [RegionCode(1_00_128_0005)]
            SudurPashchimanchal,

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