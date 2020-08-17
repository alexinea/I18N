using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Benin region
    /// </summary>
    public static class BeninRegions
    {
        #region Gets region

        /// <summary>
        /// Atakora
        /// </summary>
        public static EnumValues Atakora => EnumValues.Atakora;

        /// <summary>
        /// Alibori
        /// </summary>
        public static EnumValues Alibori => EnumValues.Alibori;

        /// <summary>
        /// Atlantique
        /// </summary>
        public static EnumValues Atlantique => EnumValues.Atlantique;

        /// <summary>
        /// Borgou
        /// </summary>
        public static EnumValues Borgou => EnumValues.Borgou;

        /// <summary>
        /// Collines
        /// </summary>
        public static EnumValues Collines => EnumValues.Collines;

        /// <summary>
        /// Donga
        /// </summary>
        public static EnumValues Donga => EnumValues.Donga;

        /// <summary>
        /// Kouffo
        /// </summary>
        public static EnumValues Kouffo => EnumValues.Kouffo;

        /// <summary>
        /// Littoral
        /// </summary>
        public static EnumValues Littoral => EnumValues.Littoral;

        /// <summary>
        /// Mono
        /// </summary>
        public static EnumValues Mono => EnumValues.Mono;

        /// <summary>
        /// Ouémé
        /// </summary>
        public static EnumValues Ouémé => EnumValues.Ouémé;

        /// <summary>
        /// Plateau
        /// </summary>
        public static EnumValues Plateau => EnumValues.Plateau;

        /// <summary>
        /// Zou
        /// </summary>
        public static EnumValues Zou => EnumValues.Zou;

        #endregion

        /// <summary>
        /// Enum values for Benin regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Atakora
            /// </summary>
            [AliasInShort("AK")][RegionCode(3_00_103_0001)] Atakora,

            /// <summary>
            /// Alibori
            /// </summary>
            [AliasInShort("AL")][RegionCode(3_00_103_0002)] Alibori,

            /// <summary>
            /// Atlantique
            /// </summary>
            [AliasInShort("AQ")][RegionCode(3_00_103_0003)] Atlantique,

            /// <summary>
            /// Borgou
            /// </summary>
            [AliasInShort("BO")][RegionCode(3_00_103_0004)] Borgou,

            /// <summary>
            /// Collines
            /// </summary>
            [AliasInShort("CO")][RegionCode(3_00_103_0005)] Collines,

            /// <summary>
            /// Donga
            /// </summary>
            [AliasInShort("DO")][RegionCode(3_00_103_0006)] Donga,

            /// <summary>
            /// Kouffo
            /// </summary>
            [AliasInShort("KO")][RegionCode(3_00_103_0007)] Kouffo,

            /// <summary>
            /// Littoral
            /// </summary>
            [AliasInShort("LI")][RegionCode(3_00_103_0008)] Littoral,

            /// <summary>
            /// Mono
            /// </summary>
            [AliasInShort("MO")][RegionCode(3_00_103_0009)] Mono,

            /// <summary>
            /// Ouémé
            /// </summary>
            [AliasInShort("OU")][RegionCode(3_00_103_0010)] Ouémé,

            /// <summary>
            /// Plateau
            /// </summary>
            [AliasInShort("PL")][RegionCode(3_00_103_0011)] Plateau,

            /// <summary>
            /// Zou
            /// </summary>
            [AliasInShort("ZO")][RegionCode(3_00_103_0012)] Zou,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BeninRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BeninRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"BJ-{values.ToRegionCode()}";
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
            return Country.Benin;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.BJ;
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