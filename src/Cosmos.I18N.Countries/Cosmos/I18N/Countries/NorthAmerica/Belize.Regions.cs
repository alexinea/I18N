using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Belize regions
    /// </summary>
    public static partial class Belize
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Belize
            /// </summary>
            public static EnumValues Belize => EnumValues.Belize;

            /// <summary>
            /// Cayo
            /// </summary>
            public static EnumValues Cayo => EnumValues.Cayo;

            /// <summary>
            /// Corozal
            /// </summary>
            public static EnumValues Corozal => EnumValues.Corozal;

            /// <summary>
            /// Orange Walk    
            /// </summary>
            public static EnumValues OrangeWalk => EnumValues.OrangeWalk;

            /// <summary>
            /// Stann Creek
            /// </summary>
            public static EnumValues StannCreek => EnumValues.StannCreek;

            /// <summary>
            /// Toledo
            /// </summary>
            public static EnumValues Toledo => EnumValues.Toledo;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Belize regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Belize
            /// </summary>
            [AliasInShort("BZ")]
            [RegionCode(4_00_107_0001)]
            Belize,

            /// <summary>
            /// Cayo
            /// </summary>
            [AliasInShort("CY")]
            [RegionCode(4_00_107_0002)]
            Cayo,

            /// <summary>
            /// Corozal
            /// </summary>
            [AliasInShort("CZL")]
            [RegionCode(4_00_107_0003)]
            Corozal,

            /// <summary>
            /// Orange Walk    
            /// </summary>
            [AliasInShort("OW")]
            [RegionCode(4_00_107_0004)]
            OrangeWalk,

            /// <summary>
            /// Stann Creek
            /// </summary>
            [AliasInShort("SC")]
            [RegionCode(4_00_107_0005)]
            StannCreek,

            /// <summary>
            /// Toledo
            /// </summary>
            [AliasInShort("TOL")]
            [RegionCode(4_00_107_0006)]
            Toledo,

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