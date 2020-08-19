using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Bahrain regions
    /// </summary>
    public static partial class Bahrain
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Capital
            /// </summary>
            public static EnumValues Capital => EnumValues.Capital;

            /// <summary>
            /// Southern
            /// </summary>
            public static EnumValues Southern => EnumValues.Southern;

            /// <summary>
            /// Muharraq
            /// </summary>
            public static EnumValues Muharraq => EnumValues.Muharraq;

            /// <summary>
            /// Northern
            /// </summary>
            public static EnumValues Northern => EnumValues.Northern;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Bahrain regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Capital
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(1_00_104_0013)]
            Capital,

            /// <summary>
            /// Southern
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(1_00_104_0014)]
            Southern,

            /// <summary>
            /// Muharraq
            /// </summary>
            [AliasInShort("15")]
            [RegionCode(1_00_104_0015)]
            Muharraq,

            /// <summary>
            /// Northern
            /// </summary>
            [AliasInShort("17")]
            [RegionCode(1_00_104_0016)]
            Northern,

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