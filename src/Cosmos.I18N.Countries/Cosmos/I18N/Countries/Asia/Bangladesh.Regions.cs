using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Bangladesh Regions
    /// </summary>
    public static partial class Bangladesh
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Barisal
            /// </summary>
            public static EnumValues Barisal => EnumValues.Barisal;

            /// <summary>
            /// Chittagong Division
            /// </summary>
            public static EnumValues ChittagongDivision => EnumValues.ChittagongDivision;

            /// <summary>
            /// Dhaka Division
            /// </summary>
            public static EnumValues DhakaDivision => EnumValues.DhakaDivision;

            /// <summary>
            /// Khulna Division
            /// </summary>
            public static EnumValues KhulnaDivision => EnumValues.KhulnaDivision;

            /// <summary>
            /// Rajshahi Division
            /// </summary>
            public static EnumValues RajshahiDivision => EnumValues.RajshahiDivision;

            /// <summary>
            /// Rangpur Division
            /// </summary>
            public static EnumValues RangpurDivision => EnumValues.RangpurDivision;

            /// <summary>
            /// Sylhet Division
            /// </summary>
            public static EnumValues SylhetDivision => EnumValues.SylhetDivision;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Bangladesh regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Barisal
            /// </summary>
            [AliasInShort("A")]
            [RegionCode(1_00_105_0001)]
            Barisal,

            /// <summary>
            /// Chittagong Division
            /// </summary>
            [AliasInShort("B")]
            [RegionCode(1_00_105_0002)]
            ChittagongDivision,

            /// <summary>
            /// Dhaka Division
            /// </summary>
            [AliasInShort("C")]
            [RegionCode(1_00_105_0003)]
            DhakaDivision,

            /// <summary>
            /// Khulna Division
            /// </summary>
            [AliasInShort("D")]
            [RegionCode(1_00_105_0004)]
            KhulnaDivision,

            /// <summary>
            /// Rajshahi Division
            /// </summary>
            [AliasInShort("E")]
            [RegionCode(1_00_105_0005)]
            RajshahiDivision,

            /// <summary>
            /// Rangpur Division
            /// </summary>
            [AliasInShort("F")]
            [RegionCode(1_00_105_0006)]
            RangpurDivision,

            /// <summary>
            /// Sylhet Division
            /// </summary>
            [AliasInShort("G")]
            [RegionCode(1_00_105_0007)]
            SylhetDivision,

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