using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// SolomonIslands Regions
    /// </summary>
    public static partial class SolomonIslands
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
            /// Choiseul
            /// </summary>
            public static EnumValues Choiseul => EnumValues.Choiseul;

            /// <summary>
            /// Honiara
            /// </summary>
            public static EnumValues Honiara => EnumValues.Honiara;

            /// <summary>
            /// Guadalcanal
            /// </summary>
            public static EnumValues Guadalcanal => EnumValues.Guadalcanal;

            /// <summary>
            /// Isabel
            /// </summary>
            public static EnumValues Isabel => EnumValues.Isabel;

            /// <summary>
            /// Makira-Ulawa
            /// </summary>
            public static EnumValues MakiraUlawa => EnumValues.MakiraUlawa;

            /// <summary>
            /// Malaita
            /// </summary>
            public static EnumValues Malaita => EnumValues.Malaita;

            /// <summary>
            /// Rennell and Bellona
            /// </summary>
            public static EnumValues RennellAndBellona => EnumValues.RennellAndBellona;

            /// <summary>
            /// Temotu
            /// </summary>
            public static EnumValues Temotu => EnumValues.Temotu;

            /// <summary>
            /// Western
            /// </summary>
            public static EnumValues Western => EnumValues.Western;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for SolomonIslands regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("CE")]
            [RegionCode(6_00_115_0001)]
            Central,

            /// <summary>
            /// Choiseul
            /// </summary>
            [AliasInShort("CH")]
            [RegionCode(6_00_115_0002)]
            Choiseul,

            /// <summary>
            /// Honiara
            /// </summary>
            [AliasInShort("CT")]
            [RegionCode(6_00_115_0003)]
            Honiara,

            /// <summary>
            /// Guadalcanal
            /// </summary>
            [AliasInShort("GU")]
            [RegionCode(6_00_115_0004)]
            Guadalcanal,

            /// <summary>
            /// Isabel
            /// </summary>
            [AliasInShort("IS")]
            [RegionCode(6_00_115_0005)]
            Isabel,

            /// <summary>
            /// Makira-Ulawa
            /// </summary>
            [AliasInShort("MK")]
            [RegionCode(6_00_115_0006)]
            MakiraUlawa,

            /// <summary>
            /// Malaita
            /// </summary>
            [AliasInShort("ML")]
            [RegionCode(6_00_115_0007)]
            Malaita,

            /// <summary>
            /// Rennell and Bellona
            /// </summary>
            [AliasInShort("RB")]
            [RegionCode(6_00_115_0008)]
            RennellAndBellona,

            /// <summary>
            /// Temotu
            /// </summary>
            [AliasInShort("TE")]
            [RegionCode(6_00_115_0009)]
            Temotu,

            /// <summary>
            /// Western
            /// </summary>
            [AliasInShort("WE")]
            [RegionCode(6_00_115_0020)]
            Western,

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