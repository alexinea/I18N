using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Maldives Regions
    /// </summary>
    public static partial class Maldives
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Central Province
            /// </summary>
            public static EnumValues CentralProvince => EnumValues.CentralProvince;

            /// <summary>
            /// Malé
            /// </summary>
            public static EnumValues Malé => EnumValues.Malé;

            /// <summary>
            /// North Central Province
            /// </summary>
            public static EnumValues NorthCentralProvince => EnumValues.NorthCentralProvince;

            /// <summary>
            /// North Province
            /// </summary>
            public static EnumValues NorthProvince => EnumValues.NorthProvince;

            /// <summary>
            /// South Central Province
            /// </summary>
            public static EnumValues SouthCentralProvince => EnumValues.SouthCentralProvince;

            /// <summary>
            /// South Province
            /// </summary>
            public static EnumValues SouthProvince => EnumValues.SouthProvince;

            /// <summary>
            /// Upper North Province
            /// </summary>
            public static EnumValues UpperNorthProvince => EnumValues.UpperNorthProvince;

            /// <summary>
            /// Upper South Province
            /// </summary>
            public static EnumValues UpperSouthProvince => EnumValues.UpperSouthProvince;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Maldives regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Central Province
            /// </summary>
            [AliasInShort("CE")]
            [RegionCode(1_00_125_0001)]
            CentralProvince,

            /// <summary>
            /// Malé
            /// </summary>
            [AliasInShort("MLE")]
            [RegionCode(1_00_125_0002)]
            Malé,

            /// <summary>
            /// North Central Province
            /// </summary>
            [AliasInShort("NC")]
            [RegionCode(1_00_125_0003)]
            NorthCentralProvince,

            /// <summary>
            /// North Province
            /// </summary>
            [AliasInShort("NO")]
            [RegionCode(1_00_125_0004)]
            NorthProvince,

            /// <summary>
            /// South Central Province
            /// </summary>
            [AliasInShort("SC")]
            [RegionCode(1_00_125_0005)]
            SouthCentralProvince,

            /// <summary>
            /// South Province
            /// </summary>
            [AliasInShort("SU")]
            [RegionCode(1_00_125_0006)]
            SouthProvince,

            /// <summary>
            /// Upper North Province
            /// </summary>
            [AliasInShort("UN")]
            [RegionCode(1_00_125_0007)]
            UpperNorthProvince,

            /// <summary>
            /// Upper South Province
            /// </summary>
            [AliasInShort("US")]
            [RegionCode(1_00_125_0008)]
            UpperSouthProvince,

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