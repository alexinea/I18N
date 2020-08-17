using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// StVAndG Regions
    /// </summary>
    public static class StVAndGRegions
    {
        #region Gets regions

        /// <summary>
        /// Charlotte
        /// </summary>
        public static EnumValues Charlotte => EnumValues.Charlotte;

        /// <summary>
        /// Saint Andrew
        /// </summary>
        public static EnumValues SaintAndrew => EnumValues.SaintAndrew;

        /// <summary>
        /// Saint David
        /// </summary>
        public static EnumValues SaintDavid => EnumValues.SaintDavid;

        /// <summary>
        /// Saint George
        /// </summary>
        public static EnumValues SaintGeorge => EnumValues.SaintGeorge;

        /// <summary>
        /// Saint Patrick
        /// </summary>
        public static EnumValues SaintPatrick => EnumValues.SaintPatrick;

        /// <summary>
        /// Grenadines
        /// </summary>
        public static EnumValues Grenadines => EnumValues.Grenadines;

        #endregion

        /// <summary>
        /// Enum values for StVAndG regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Charlotte
            /// </summary>
            [AliasInShort("01")] [RegionCode(4_00_133_0001)]
            Charlotte,

            /// <summary>
            /// Saint Andrew
            /// </summary>
            [AliasInShort("02")] [RegionCode(4_00_133_0002)]
            SaintAndrew,

            /// <summary>
            /// Saint David
            /// </summary>
            [AliasInShort("03")] [RegionCode(4_00_133_0003)]
            SaintDavid,

            /// <summary>
            /// Saint George
            /// </summary>
            [AliasInShort("04")] [RegionCode(4_00_133_0004)]
            SaintGeorge,

            /// <summary>
            /// Saint Patrick
            /// </summary>
            [AliasInShort("05")] [RegionCode(4_00_133_0005)]
            SaintPatrick,

            /// <summary>
            /// Grenadines
            /// </summary>
            [AliasInShort("06")] [RegionCode(4_00_133_0006)]
            Grenadines,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="StVAndGRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="StVAndGRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"VC-{values.ToRegionCode()}";
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
            return Country.StVAndG;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.VC;
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