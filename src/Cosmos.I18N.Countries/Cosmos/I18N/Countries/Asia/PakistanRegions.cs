using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Pakistan Regions
    /// </summary>
    public static class PakistanRegions
    {
        #region Gets regions

        /// <summary>
        /// Balochistan
        /// </summary>
        public static EnumValues Balochistan => EnumValues.Balochistan;

        /// <summary>
        /// Gilgit-Baltistan
        /// </summary>
        public static EnumValues GilgitBaltistan => EnumValues.GilgitBaltistan;

        /// <summary>
        /// Islamabad
        /// </summary>
        public static EnumValues Islamabad => EnumValues.Islamabad;

        /// <summary>
        /// Azad Kashmir
        /// </summary>
        public static EnumValues AzadKashmir => EnumValues.AzadKashmir;

        /// <summary>
        /// Khyber Pakhtunkhwa
        /// </summary>
        public static EnumValues KhyberPakhtunkhwa => EnumValues.KhyberPakhtunkhwa;

        /// <summary>
        /// Punjab
        /// </summary>
        public static EnumValues Punjab => EnumValues.Punjab;

        /// <summary>
        /// Sindh
        /// </summary>
        public static EnumValues Sindh => EnumValues.Sindh;

        /// <summary>
        /// Federally Administered Tribal Areas
        /// </summary>
        public static EnumValues FederallyAdministeredTribalAreas => EnumValues.FederallyAdministeredTribalAreas;

        #endregion

        /// <summary>
        /// Enum values for Pakistan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Balochistan
            /// </summary>
            [AliasInShort("BA")][RegionCode(1_00_016_0001)] Balochistan,

            /// <summary>
            /// Gilgit-Baltistan
            /// </summary>
            [AliasInShort("GB")][RegionCode(1_00_016_0002)] GilgitBaltistan,

            /// <summary>
            /// Islamabad
            /// </summary>
            [AliasInShort("IS")][RegionCode(1_00_016_0003)] Islamabad,

            /// <summary>
            /// Azad Kashmir
            /// </summary>
            [AliasInShort("JK")][RegionCode(1_00_016_0004)] AzadKashmir,

            /// <summary>
            /// Khyber Pakhtunkhwa
            /// </summary>
            [AliasInShort("KP")][RegionCode(1_00_016_0005)] KhyberPakhtunkhwa,

            /// <summary>
            /// Punjab
            /// </summary>
            [AliasInShort("PB")][RegionCode(1_00_016_0006)] Punjab,

            /// <summary>
            /// Sindh
            /// </summary>
            [AliasInShort("SD")][RegionCode(1_00_016_0007)] Sindh,

            /// <summary>
            /// Federally Administered Tribal Areas
            /// </summary>
            [AliasInShort("TA")][RegionCode(1_00_016_0008)] FederallyAdministeredTribalAreas,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="PakistanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="PakistanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"PK-{values.ToRegionCode()}";
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
            return Country.Pakistan;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.PK;
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