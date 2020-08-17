using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Barbados Regions
    /// </summary>
    public static class BarbadosRegions
    {
        #region Gets regions

        /// <summary>
        /// Saint Philip
        /// </summary>
        public static EnumValues SaintPhilip => EnumValues.SaintPhilip;

        /// <summary>
        /// Saint Thomas
        /// </summary>
        public static EnumValues SaintThomas => EnumValues.SaintThomas;

        /// <summary>
        /// Christ Church
        /// </summary>
        public static EnumValues ChristChurch => EnumValues.ChristChurch;

        /// <summary>
        /// Saint Andrew
        /// </summary>
        public static EnumValues SaintAndrew => EnumValues.SaintAndrew;

        /// <summary>
        /// Saint George
        /// </summary>
        public static EnumValues SaintGeorge => EnumValues.SaintGeorge;

        /// <summary>
        /// Saint James
        /// </summary>
        public static EnumValues SaintJames => EnumValues.SaintJames;

        /// <summary>
        /// Saint John
        /// </summary>
        public static EnumValues SaintJohn => EnumValues.SaintJohn;

        /// <summary>
        /// Saint Joseph
        /// </summary>
        public static EnumValues SaintJoseph => EnumValues.SaintJoseph;

        /// <summary>
        /// Saint Lucy
        /// </summary>
        public static EnumValues SaintLucy => EnumValues.SaintLucy;

        /// <summary>
        /// Saint Michael
        /// </summary>
        public static EnumValues SaintMichael => EnumValues.SaintMichael;

        /// <summary>
        /// Saint Peter
        /// </summary>
        public static EnumValues SaintPeter => EnumValues.SaintPeter;

        #endregion

        /// <summary>
        /// Enum values for Andorra regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Saint Philip
            /// </summary>
            [AliasInShort("10")] [RegionCode(4_00_106_0010)]
            SaintPhilip,

            /// <summary>
            /// Canillo
            /// </summary>
            [AliasInShort("11")] [RegionCode(4_00_106_0011)]
            SaintThomas,

            /// <summary>
            /// Christ Church
            /// </summary>
            [AliasInShort("01")] [RegionCode(4_00_106_0001)]
            ChristChurch,

            /// <summary>
            /// Saint Andrew
            /// </summary>
            [AliasInShort("02")] [RegionCode(4_00_106_0002)]
            SaintAndrew,

            /// <summary>
            /// Saint George
            /// </summary>
            [AliasInShort("03")] [RegionCode(4_00_106_0003)]
            SaintGeorge,

            /// <summary>
            /// Les Escaldes-Engordany
            /// </summary>
            [AliasInShort("04")] [RegionCode(4_00_106_0004)]
            SaintJames,

            /// <summary>
            /// Saint John
            /// </summary>
            [AliasInShort("05")] [RegionCode(4_00_106_0005)]
            SaintJohn,

            /// <summary>
            /// Saint Joseph
            /// </summary>
            [AliasInShort("06")] [RegionCode(4_00_106_0006)]
            SaintJoseph,

            /// <summary>
            /// Saint Lucy
            /// </summary>
            [AliasInShort("07")] [RegionCode(4_00_106_0007)]
            SaintLucy,

            /// <summary>
            /// Saint Michael
            /// </summary>
            [AliasInShort("08")] [RegionCode(4_00_106_0008)]
            SaintMichael,

            /// <summary>
            /// Saint Peter
            /// </summary>
            [AliasInShort("09")] [RegionCode(4_00_106_0009)]
            SaintPeter,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BarbadosRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BarbadosRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"BB-{values.ToRegionCode()}";
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
            return Country.Barbados;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.BB;
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