using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Qatar Regons
    /// </summary>
    public static partial class Qatar
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Doha
            /// </summary>
            public static EnumValues Doha => EnumValues.Doha;

            /// <summary>
            /// Al Khor
            /// </summary>
            public static EnumValues AlKhor => EnumValues.AlKhor;

            /// <summary>
            /// Madinat ash Shamal
            /// </summary>
            public static EnumValues MadinatAshShamal => EnumValues.MadinatAshShamal;

            /// <summary>
            /// Al Rayyan
            /// </summary>
            public static EnumValues AlRayyan => EnumValues.AlRayyan;

            /// <summary>
            /// Umm Salal
            /// </summary>
            public static EnumValues UmmSalal => EnumValues.UmmSalal;

            /// <summary>
            /// Al Wakrah
            /// </summary>
            public static EnumValues AlWakrah => EnumValues.AlWakrah;

            /// <summary>
            /// Al Daayen    
            /// </summary>
            public static EnumValues AlDaayen => EnumValues.AlDaayen;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Qatar regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Doha
            /// </summary>
            [AliasInShort("DA")]
            [RegionCode(1_00_132_0001)]
            Doha,

            /// <summary>
            /// Al Khor
            /// </summary>
            [AliasInShort("KN")]
            [RegionCode(1_00_132_0002)]
            AlKhor,

            /// <summary>
            /// Madinat ash Shamal
            /// </summary>
            [AliasInShort("MS")]
            [RegionCode(1_00_132_0003)]
            MadinatAshShamal,

            /// <summary>
            /// Al Rayyan
            /// </summary>
            [AliasInShort("RA")]
            [RegionCode(1_00_132_0004)]
            AlRayyan,

            /// <summary>
            /// Umm Salal
            /// </summary>
            [AliasInShort("US")]
            [RegionCode(1_00_132_0005)]
            UmmSalal,

            /// <summary>
            /// Al Wakrah
            /// </summary>
            [AliasInShort("WA")]
            [RegionCode(1_00_132_0006)]
            AlWakrah,

            /// <summary>
            /// Al Daayen
            /// </summary>
            [AliasInShort("ZA")]
            [RegionCode(1_00_132_0007)]
            AlDaayen,

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