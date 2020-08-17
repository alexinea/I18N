using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Somalia Regions
    /// </summary>
    public static class SomaliaRegions
    {
        #region Gets regions

        /// <summary>
        /// Awdal
        /// </summary>
        public static EnumValues Awdal => EnumValues.Awdal;

        /// <summary>
        /// Sanaag
        /// </summary>
        public static EnumValues Sanaag => EnumValues.Sanaag;

        /// <summary>
        /// Sool
        /// </summary>
        public static EnumValues Sool => EnumValues.Sool;

        /// <summary>
        /// Babylon
        /// </summary>
        public static EnumValues Togdheer => EnumValues.Togdheer;

        /// <summary>
        /// Woqooyi Galbeed
        /// </summary>
        public static EnumValues WoqooyiGalbeed => EnumValues.WoqooyiGalbeed;

        #endregion

        /// <summary>
        /// Enum values for Somalia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Awdal
            /// </summary>
            [AliasInShort("AW")] [RegionCode(3_00_152_0001)]Awdal,

            /// <summary>
            /// Sanaag
            /// </summary>
            [AliasInShort("SA")] [RegionCode(3_00_152_0002)]Sanaag,

            /// <summary>
            /// Sool
            /// </summary>
            [AliasInShort("SO")] [RegionCode(3_00_152_0003)]Sool,

            /// <summary>
            /// Togdheer
            /// </summary>
            [AliasInShort("TO")] [RegionCode(3_00_152_0004)]Togdheer,

            /// <summary>
            /// Woqooyi Galbeed
            /// </summary>
            [AliasInShort("WO")] [RegionCode(3_00_152_0005)]WoqooyiGalbeed,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SomaliaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SomaliaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"SO-{values.ToRegionCode()}";
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
            return Country.Somalia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.SO;
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