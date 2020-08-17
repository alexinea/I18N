using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Gambia Regions
    /// </summary>
    public static class GambiaRegions
    {
        #region Gets regions

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

        #endregion

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
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GambiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GambiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"GM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Get CEP-1 / Cosmos Region Code.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static long ToNumericRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, RegionCodeAttribute>().CRCode;
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Gambia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.GM;
        }

        #endregion

        #region Getters

        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(member => !member.HasAttr<EnumValues, IgnoreRegionAttribute>());

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