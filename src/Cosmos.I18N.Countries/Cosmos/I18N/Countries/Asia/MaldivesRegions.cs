using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Maldives Regions
    /// </summary>
    public static class MaldivesRegions
    {
        #region Gets regions

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

        #endregion

        /// <summary>
        /// Enum values for Maldives regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Central Province
            /// </summary>
            [AliasInShort("CE")][RegionCode(1_00_125_0001)] CentralProvince,

            /// <summary>
            /// Malé
            /// </summary>
            [AliasInShort("MLE")][RegionCode(1_00_125_0002)] Malé,

            /// <summary>
            /// North Central Province
            /// </summary>
            [AliasInShort("NC")] [RegionCode(1_00_125_0003)]NorthCentralProvince,

            /// <summary>
            /// North Province
            /// </summary>
            [AliasInShort("NO")][RegionCode(1_00_125_0004)] NorthProvince,

            /// <summary>
            /// South Central Province
            /// </summary>
            [AliasInShort("SC")] [RegionCode(1_00_125_0005)]SouthCentralProvince,

            /// <summary>
            /// South Province
            /// </summary>
            [AliasInShort("SU")][RegionCode(1_00_125_0006)] SouthProvince,

            /// <summary>
            /// Upper North Province
            /// </summary>
            [AliasInShort("UN")][RegionCode(1_00_125_0007)] UpperNorthProvince,

            /// <summary>
            /// Upper South Province
            /// </summary>
            [AliasInShort("US")][RegionCode(1_00_125_0008)] UpperSouthProvince,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="MaldivesRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="MaldivesRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"MV-{values.ToRegionCode()}";
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
            return Country.Maldives;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.MV;
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