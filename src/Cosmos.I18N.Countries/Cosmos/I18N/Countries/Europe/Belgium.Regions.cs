using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Belgium Regions
    /// </summary>
    public static partial class Belgium
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Bruxelles
            /// </summary>
            public static EnumValues Bruxelles => EnumValues.Bruxelles;

            /// <summary>
            /// Deutschsprachige Gemeinschaft
            /// </summary>
            public static EnumValues DeutschsprachigeGemeinschaft => EnumValues.DeutschsprachigeGemeinschaft;

            /// <summary>
            /// Vlaamse Gemeenschap
            /// </summary>
            public static EnumValues VlaamseGemeenschap => EnumValues.VlaamseGemeenschap;

            /// <summary>
            /// Communauté Française
            /// </summary>
            public static EnumValues CommunautéFrançaise => EnumValues.CommunautéFrançaise;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Belgium regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bruxelles
            /// </summary>
            [AliasInShort("BRU")]
            [RegionCode(2_00_105_0001)]
            Bruxelles,

            /// <summary>
            /// Deutschsprachige Gemeinschaft
            /// </summary>
            [AliasInShort("DE")]
            [RegionCode(2_00_105_0002)]
            DeutschsprachigeGemeinschaft,

            /// <summary>
            /// Vlaamse Gemeenschap
            /// </summary>
            [AliasInShort("VLG")]
            [RegionCode(2_00_105_0003)]
            VlaamseGemeenschap,

            /// <summary>
            /// Communauté Française
            /// </summary>
            [AliasInShort("WAL")]
            [RegionCode(2_00_105_0004)]
            CommunautéFrançaise,

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