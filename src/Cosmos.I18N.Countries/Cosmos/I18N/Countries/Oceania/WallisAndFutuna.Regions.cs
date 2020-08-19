using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Wallis And Futuna regions
    /// </summary>
    public static partial class WallisAndFutuna
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Alo
            /// </summary>
            public static EnumValues Alo => EnumValues.Alo;

            /// <summary>
            /// Sigave
            /// </summary>
            public static EnumValues Sigave => EnumValues.Sigave;

            /// <summary>
            /// Uvea
            /// </summary>
            public static EnumValues Uvea => EnumValues.Uvea;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Wallis And Futuna regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Alo
            /// </summary>
            [AliasInShort("AL")]
            [RegionCode(6_00_116_0001)]
            Alo,

            /// <summary>
            /// Sigave
            /// </summary>
            [AliasInShort("SG")]
            [RegionCode(6_00_116_0002)]
            Sigave,

            /// <summary>
            /// Uvea
            /// </summary>
            [AliasInShort("UV")]
            [RegionCode(6_00_116_0003)]
            Uvea,

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