using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// NewZealand Regions
    /// </summary>
    public static class NewZealandRegions
    {
        #region Gets regions

        /// <summary>
        /// Auckland Province
        /// </summary>
        public static EnumValues AucklandProvince => EnumValues.AucklandProvince;

        /// <summary>
        /// Canterbury
        /// </summary>
        public static EnumValues Canterbury => EnumValues.Canterbury;

        /// <summary>
        /// Chatham Islands
        /// </summary>
        public static EnumValues ChathamIslands => EnumValues.ChathamIslands;

        /// <summary>
        /// Hawke's Bay
        /// </summary>
        public static EnumValues HawkesBay => EnumValues.HawkesBay;

        /// <summary>
        /// Marlborough
        /// </summary>
        public static EnumValues Marlborough => EnumValues.Marlborough;

        /// <summary>
        /// Nelson
        /// </summary>
        public static EnumValues Nelson => EnumValues.Nelson;

        /// <summary>
        /// Northland
        /// </summary>
        public static EnumValues Northland => EnumValues.Northland;

        /// <summary>
        /// Otago Province
        /// </summary>
        public static EnumValues OtagoProvince => EnumValues.OtagoProvince;

        /// <summary>
        /// Southland
        /// </summary>
        public static EnumValues Southland => EnumValues.Southland;

        /// <summary>
        /// Taranaki
        /// </summary>
        public static EnumValues Taranaki => EnumValues.Taranaki;

        /// <summary>
        /// Wellington Province
        /// </summary>
        public static EnumValues WellingtonProvince => EnumValues.WellingtonProvince;

        /// <summary>
        /// Westland
        /// </summary>
        public static EnumValues Westland => EnumValues.Westland;

        #endregion

        /// <summary>
        /// Enum values for NewZealand regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Auckland Province
            /// </summary>
            [AliasInShort("AUK")] [RegionCode(6_00_012_0001)]
            AucklandProvince,

            /// <summary>
            /// Canterbury
            /// </summary>
            [AliasInShort("CAN")] [RegionCode(6_00_012_0002)]
            Canterbury,

            /// <summary>
            /// Chatham Islands
            /// </summary>
            [AliasInShort("CIT")] [RegionCode(6_00_012_0003)]
            ChathamIslands,

            /// <summary>
            /// Hawke's Bay
            /// </summary>
            [AliasInShort("HKB")] [RegionCode(6_00_012_0004)]
            HawkesBay,

            /// <summary>
            /// Marlborough
            /// </summary>
            [AliasInShort("MBH")] [RegionCode(6_00_012_0005)]
            Marlborough,

            /// <summary>
            /// Nelson
            /// </summary>
            [AliasInShort("NSN")] [RegionCode(6_00_012_00026)]
            Nelson,

            /// <summary>
            /// Northland
            /// </summary>
            [AliasInShort("NTL")] [RegionCode(6_00_012_0007)]
            Northland,

            /// <summary>
            /// Otago Province
            /// </summary>
            [AliasInShort("OTA")] [RegionCode(6_00_012_0008)]
            OtagoProvince,

            /// <summary>
            /// Southland
            /// </summary>
            [AliasInShort("STL")] [RegionCode(6_00_012_0009)]
            Southland,

            /// <summary>
            /// Taranaki
            /// </summary>
            [AliasInShort("TKI")] [RegionCode(6_00_012_0010)]
            Taranaki,

            /// <summary>
            /// Wellington Province
            /// </summary>
            [AliasInShort("WGN")] [RegionCode(6_00_012_0011)]
            WellingtonProvince,

            /// <summary>
            /// Westland
            /// </summary>
            [AliasInShort("WTC")] [RegionCode(6_00_012_0012)]
            Westland,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="NewZealandRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="NewZealandRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"NZ-{values.ToRegionCode()}";
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
            return Country.NewZealand;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.NZ;
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