using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Vanuatu regions
    /// </summary>
    public static class VanuatuRegions
    {
        #region Gets region

        /// <summary>
        /// Malampa
        /// </summary>
        /// <returns></returns>
        public static EnumValues Malampa => EnumValues.Malampa;

        /// <summary>
        /// Penama
        /// </summary>
        public static EnumValues Penama => EnumValues.Penama;

        /// <summary>
        /// Sanma
        /// </summary>
        public static EnumValues Sanma => EnumValues.Sanma;

        /// <summary>
        /// Shefa
        /// </summary>
        public static EnumValues Shefa => EnumValues.Shefa;

        /// <summary>
        /// Tafea
        /// </summary>
        public static EnumValues Tafea => EnumValues.Tafea;

        /// <summary>
        /// Torba
        /// </summary>
        public static EnumValues Torba => EnumValues.Torba;

        #endregion

        /// <summary>
        /// Enum values for Vanuatu regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Malampa
            /// </summary>
            [AliasInShort("MAP")] [RegionCode(6_00_123_0001)]
            Malampa,

            /// <summary>
            /// Penama
            /// </summary>
            [AliasInShort("PAM")] [RegionCode(6_00_123_0002)]
            Penama,

            /// <summary>
            /// Sanma
            /// </summary>
            [AliasInShort("SAM")] [RegionCode(6_00_123_0003)]
            Sanma,

            /// <summary>
            /// Shefa
            /// </summary>
            [AliasInShort("SEE")] [RegionCode(6_00_123_0004)]
            Shefa,

            /// <summary>
            /// Tafea
            /// </summary>
            [AliasInShort("TAE")] [RegionCode(6_00_123_0005)]
            Tafea,

            /// <summary>
            /// Torba
            /// </summary>
            [AliasInShort("TOB")] [RegionCode(6_00_123_0006)]
            Torba,

            /// <summary>
            /// Unknown<br />未知
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="VanuatuRegions.EnumValues"/> to region code likes 'MAP'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="VanuatuRegions.EnumValues"/> to full region code likes 'VU-MAP'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"VU-{values.ToRegionCode()}";
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
            return Country.Vanuatu;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.VU;
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