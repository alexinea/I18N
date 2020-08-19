using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Tonga regions
    /// </summary>
    public static partial class Tonga
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// ʻEua
            /// </summary>
            /// <returns></returns>
            public static EnumValues Eua => EnumValues.Eua;

            /// <summary>
            /// Haʻapai
            /// </summary>
            public static EnumValues HaApai => EnumValues.HaApai;

            /// <summary>
            /// Niuas
            /// </summary>
            public static EnumValues Niuas => EnumValues.Niuas;

            /// <summary>
            /// Tongatapu
            /// </summary>
            public static EnumValues Tongatapu => EnumValues.Tongatapu;

            /// <summary>
            /// Vavaʻu
            /// </summary>
            public static EnumValues VavaU => EnumValues.VavaU;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Tonga regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// ʻEua
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(6_00_121_0001)]
            Eua,

            /// <summary>
            /// Haʻapai
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(6_00_121_0002)]
            HaApai,

            /// <summary>
            /// Niuas
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(6_00_121_0003)]
            Niuas,

            /// <summary>
            /// Tongatapu
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(6_00_121_0004)]
            Tongatapu,

            /// <summary>
            /// Vavaʻu
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(6_00_121_0005)]
            VavaU,

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