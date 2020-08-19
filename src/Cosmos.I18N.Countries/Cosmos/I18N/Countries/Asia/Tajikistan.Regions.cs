using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Tajikistan Regions
    /// </summary>
    public static partial class Tajikistan
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Dushanbe
            /// </summary>
            public static EnumValues Dushanbe => EnumValues.Dushanbe;

            /// <summary>
            /// Gorno-Badakhshan
            /// </summary>
            public static EnumValues GornoBadakhshan => EnumValues.GornoBadakhshan;

            /// <summary>
            /// Khatlon
            /// </summary>
            public static EnumValues Khatlon => EnumValues.Khatlon;

            /// <summary>
            /// Sughd
            /// </summary>
            public static EnumValues Sughd => EnumValues.Sughd;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Tajikistan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Dushanbe
            /// </summary>
            [AliasInShort("DU")]
            [RegionCode(1_00_137_0001)]
            Dushanbe,

            /// <summary>
            /// Gorno-Badakhshan
            /// </summary>
            [AliasInShort("GB")]
            [RegionCode(1_00_137_0002)]
            GornoBadakhshan,

            /// <summary>
            /// Khatlon
            /// </summary>
            [AliasInShort("KT")]
            [RegionCode(1_00_137_0003)]
            Khatlon,

            /// <summary>
            /// Sughd
            /// </summary>
            [AliasInShort("SU")]
            [RegionCode(1_00_137_0004)]
            Sughd,

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