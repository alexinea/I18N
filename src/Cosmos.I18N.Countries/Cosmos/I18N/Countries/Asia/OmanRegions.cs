using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Oman Regions
    /// </summary>
    public static class OmanRegions
    {
        #region Gets regions

        /// <summary>
        /// Janub al Batinah
        /// </summary>
        public static EnumValues JanubAlBatinah => EnumValues.JanubAlBatinah;

        /// <summary>
        /// Shamal al Batinah
        /// </summary>
        public static EnumValues ShamalAlBatinah => EnumValues.ShamalAlBatinah;

        /// <summary>
        /// Al Buraimi
        /// </summary>
        public static EnumValues AlBuraimi => EnumValues.AlBuraimi;

        /// <summary>
        /// Ad Dakhiliyah
        /// </summary>
        public static EnumValues AdDakhiliyah => EnumValues.AdDakhiliyah;

        /// <summary>
        /// Muscat
        /// </summary>
        public static EnumValues Muscat => EnumValues.Muscat;

        /// <summary>
        /// Musandam
        /// </summary>
        public static EnumValues Musandam => EnumValues.Musandam;

        /// <summary>
        /// Janub ash Sharqiyah
        /// </summary>
        public static EnumValues JanubAshSharqiyah => EnumValues.JanubAshSharqiyah;

        /// <summary>
        /// Shamal ash Sharqiyah
        /// </summary>
        public static EnumValues ShamalAshSharqiyah => EnumValues.ShamalAshSharqiyah;

        /// <summary>
        /// Al Wusta
        /// </summary>
        public static EnumValues AlWusta => EnumValues.AlWusta;

        /// <summary>
        /// Ad Dhahirah
        /// </summary>
        public static EnumValues AdDhahirah => EnumValues.AdDhahirah;

        /// <summary>
        /// Dhofar
        /// </summary>
        public static EnumValues Dhofar => EnumValues.Dhofar;

        #endregion

        /// <summary>
        /// Enum values for Oman regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Janub al Batinah
            /// </summary>
            [AliasInShort("BJ")][RegionCode(1_00_129_0001)] JanubAlBatinah,

            /// <summary>
            /// Shamal al Batinah
            /// </summary>
            [AliasInShort("BS")][RegionCode(1_00_129_0002)] ShamalAlBatinah,

            /// <summary>
            /// Al Buraimi
            /// </summary>
            [AliasInShort("BU")][RegionCode(1_00_129_0003)] AlBuraimi,

            /// <summary>
            /// Ad Dakhiliyah
            /// </summary>
            [AliasInShort("DA")][RegionCode(1_00_129_0004)] AdDakhiliyah,

            /// <summary>
            /// Muscat
            /// </summary>
            [AliasInShort("MA")][RegionCode(1_00_129_0005)] Muscat,

            /// <summary>
            /// Musandam
            /// </summary>
            [AliasInShort("MU")][RegionCode(1_00_129_0006)] Musandam,

            /// <summary>
            /// Janub ash Sharqiyah
            /// </summary>
            [AliasInShort("SJ")][RegionCode(1_00_129_0007)] JanubAshSharqiyah,

            /// <summary>
            /// Shamal ash Sharqiyah
            /// </summary>
            [AliasInShort("SS")][RegionCode(1_00_129_0008)] ShamalAshSharqiyah,

            /// <summary>
            /// Al Wusta
            /// </summary>
            [AliasInShort("WU")][RegionCode(1_00_129_0009)] AlWusta,

            /// <summary>
            /// Ad Dhahirah
            /// </summary>
            [AliasInShort("ZA")][RegionCode(1_00_129_0010)] AdDhahirah,

            /// <summary>
            /// Dhofar
            /// </summary>
            [AliasInShort("ZU")][RegionCode(1_00_129_0011)] Dhofar,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="OmanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="OmanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"OM-{values.ToRegionCode()}";
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
            return Country.Oman;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.OM;
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