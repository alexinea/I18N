using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Belgium Regions
    /// </summary>
    public static class BelgiumRegions
    {
        #region Gets regions

        /// <summary>
        /// Bruxelles
        /// </summary>
        public static EnumValues Bruxelles => EnumValues.Bruxelles;

        /// <summary>
        /// Deutschsprachige Gemeinschaft
        /// </summary>
        public static EnumValues DeutschsprachigeGemeinschaft => EnumValues.DeutschsprachigeGemeinschaft;

        /// <summary>
        /// Vlaamse Gemeenschap
        /// </summary>
        public static EnumValues VlaamseGemeenschap => EnumValues.VlaamseGemeenschap;

        /// <summary>
        /// Communauté Française
        /// </summary>
        public static EnumValues CommunautéFrançaise => EnumValues.CommunautéFrançaise;

        #endregion

        /// <summary>
        /// Enum values for Belgium regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bruxelles
            /// </summary>
            [AliasInShort("BRU")] [RegionCode(2_00_105_0001)]
            Bruxelles,

            /// <summary>
            /// Deutschsprachige Gemeinschaft
            /// </summary>
            [AliasInShort("DE")] [RegionCode(2_00_105_0002)]
            DeutschsprachigeGemeinschaft,

            /// <summary>
            /// Vlaamse Gemeenschap
            /// </summary>
            [AliasInShort("VLG")] [RegionCode(2_00_105_0003)]
            VlaamseGemeenschap,

            /// <summary>
            /// Communauté Française
            /// </summary>
            [AliasInShort("WAL")] [RegionCode(2_00_105_0004)]
            CommunautéFrançaise,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BelgiumRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BelgiumRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"BE-{values.ToRegionCode()}";
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
            return Country.Belgium;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.BE;
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