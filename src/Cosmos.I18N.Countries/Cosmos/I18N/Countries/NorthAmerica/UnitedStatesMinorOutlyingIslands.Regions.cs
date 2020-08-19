using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// United States Minor Outlying Islands Regions
    /// </summary>
    public static partial class UnitedStatesMinorOutlyingIslands
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Johnston Atoll
            /// </summary>
            public static EnumValues JohnstonAtoll => EnumValues.JohnstonAtoll;

            /// <summary>
            /// Midway Atoll
            /// </summary>
            public static EnumValues MidwayAtoll => EnumValues.MidwayAtoll;

            /// <summary>
            /// Navassa Island
            /// </summary>
            public static EnumValues NavassaIsland => EnumValues.NavassaIsland;

            /// <summary>
            /// Wake Island
            /// </summary>
            public static EnumValues WakeIsland => EnumValues.WakeIsland;

            /// <summary>
            /// Baker Island
            /// </summary>
            public static EnumValues BakerIsland => EnumValues.BakerIsland;

            /// <summary>
            /// Howland Island
            /// </summary>
            public static EnumValues HowlandIsland => EnumValues.HowlandIsland;

            /// <summary>
            /// Jarvis Island
            /// </summary>
            public static EnumValues JarvisIsland => EnumValues.JarvisIsland;

            /// <summary>
            /// Kingman Reef
            /// </summary>
            public static EnumValues KingmanReef => EnumValues.KingmanReef;

            /// <summary>
            /// Palmyra Atoll
            /// </summary>
            public static EnumValues PalmyraAtoll => EnumValues.PalmyraAtoll;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for UnitedStatesMinorOutlyingIslands regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Johnston Atoll
            /// </summary>
            [AliasInShort("67")]
            [RegionCode(4_00_136_0067)]
            JohnstonAtoll,

            /// <summary>
            /// Midway Atoll
            /// </summary>
            [AliasInShort("71")]
            [RegionCode(4_00_136_0071)]
            MidwayAtoll,

            /// <summary>
            /// Navassa Island
            /// </summary>
            [AliasInShort("76")]
            [RegionCode(4_00_136_0076)]
            NavassaIsland,

            /// <summary>
            /// Wake Island
            /// </summary>
            [AliasInShort("79")]
            [RegionCode(4_00_136_0079)]
            WakeIsland,

            /// <summary>
            /// Baker Island
            /// </summary>
            [AliasInShort("81")]
            [RegionCode(4_00_136_0081)]
            BakerIsland,

            /// <summary>
            /// Howland Island
            /// </summary>
            [AliasInShort("84")]
            [RegionCode(4_00_136_0084)]
            HowlandIsland,

            /// <summary>
            /// Jarvis Island
            /// </summary>
            [AliasInShort("86")]
            [RegionCode(4_00_136_0086)]
            JarvisIsland,

            /// <summary>
            /// Kingman Reef
            /// </summary>
            [AliasInShort("89")]
            [RegionCode(4_00_136_0089)]
            KingmanReef,

            /// <summary>
            /// Palmyra Atoll
            /// </summary>
            [AliasInShort("95")]
            [RegionCode(4_00_136_0095)]
            PalmyraAtoll,

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