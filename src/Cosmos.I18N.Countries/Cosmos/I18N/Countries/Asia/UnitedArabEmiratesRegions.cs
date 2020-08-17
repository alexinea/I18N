using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// United Arab Emirates Regions
    /// </summary>
    public static class UnitedArabEmiratesRegions
    {
        #region Gets region

        /// <summary>
        /// Ajman
        /// </summary>
        public static EnumValues Ajman => EnumValues.Ajman;

        /// <summary>
        /// Abu Dhabi
        /// </summary>
        public static EnumValues AbuDhabi => EnumValues.AbuDhabi;

        /// <summary>
        /// Dubai
        /// </summary>
        public static EnumValues Dubai => EnumValues.Dubai;

        /// <summary>
        /// Fujairah
        /// </summary>
        public static EnumValues Fujairah => EnumValues.Fujairah;

        /// <summary>
        /// Ras al-Khaimah
        /// </summary>
        public static EnumValues RasAlKhaimah => EnumValues.RasAlKhaimah;

        /// <summary>
        /// Sharjah
        /// </summary>
        public static EnumValues Sharjah => EnumValues.Sharjah;

        /// <summary>
        /// Umm al-Quwain
        /// </summary>
        public static EnumValues UmmAlQuwain => EnumValues.UmmAlQuwain;

        #endregion

        /// <summary>
        /// Enum values for United Arab Emirates regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ajman
            /// </summary>
            [AliasInShort("AJ")] [RegionCode(1_00_140_0001)]
            Ajman,

            /// <summary>
            /// Abu Dhabi
            /// </summary>
            [AliasInShort("AZ")] [RegionCode(1_00_140_0002)]
            AbuDhabi,

            /// <summary>
            /// Dubai
            /// </summary>
            [AliasInShort("DU")] [RegionCode(1_00_140_0003)]
            Dubai,

            /// <summary>
            /// Fujairah
            /// </summary>
            [AliasInShort("FU")] [RegionCode(1_00_140_0004)]
            Fujairah,

            /// <summary>
            /// Ras al-Khaimah
            /// </summary>
            [AliasInShort("RK")] [RegionCode(1_00_140_0005)]
            RasAlKhaimah,

            /// <summary>
            /// Sharjah
            /// </summary>
            [AliasInShort("SH")] [RegionCode(1_00_140_0006)]
            Sharjah,

            /// <summary>
            /// Umm al-Quwain
            /// </summary>
            [AliasInShort("UQ")] [RegionCode(1_00_140_0007)]
            UmmAlQuwain,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="UnitedArabEmiratesRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="UnitedArabEmiratesRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"AE-{values.ToRegionCode()}";
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
            return Country.UnitedArabEmirates;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.AE;
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