using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Gambia Regions
    /// </summary>
    public static partial  class Gambia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Banjul
        /// </summary>
        public static EnumValues Banjul => EnumValues.Banjul;

        /// <summary>
        /// Lower River Division
        /// </summary>
        public static EnumValues LowerRiverDivision => EnumValues.LowerRiverDivision;

        /// <summary>
        /// Central River Division
        /// </summary>
        public static EnumValues CentralRiverDivision => EnumValues.CentralRiverDivision;

        /// <summary>
        /// North Bank Division
        /// </summary>
        public static EnumValues NorthBankDivision => EnumValues.NorthBankDivision;

        /// <summary>
        /// Upper River Division
        /// </summary>
        public static EnumValues UpperRiverDivision => EnumValues.UpperRiverDivision;

        /// <summary>
        /// West Coast Division
        /// </summary>
        public static EnumValues WestCoastDivision => EnumValues.WestCoastDivision;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Gambia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Banjul
            /// </summary>
            [AliasInShort("B")] [RegionCode(3_00_128_0001)]
            Banjul,

            /// <summary>
            /// Lower River Division
            /// </summary>
            [AliasInShort("L")] [RegionCode(3_00_128_0002)]
            LowerRiverDivision,

            /// <summary>
            /// Central River Division
            /// </summary>
            [AliasInShort("M")] [RegionCode(3_00_128_0003)]
            CentralRiverDivision,

            /// <summary>
            /// North Bank Division
            /// </summary>
            [AliasInShort("N")] [RegionCode(3_00_128_0004)]
            NorthBankDivision,

            /// <summary>
            /// Upper River Division
            /// </summary>
            [AliasInShort("U")] [RegionCode(3_00_128_0005)]
            UpperRiverDivision,

            /// <summary>
            /// West Coast Division
            /// </summary>
            [AliasInShort("W")] [RegionCode(3_00_128_0006)]
            WestCoastDivision,

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