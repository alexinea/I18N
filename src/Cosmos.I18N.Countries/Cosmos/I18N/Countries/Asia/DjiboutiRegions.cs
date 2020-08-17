using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Djibouti regions
    /// </summary>
    public static class DjiboutiRegions
    {
        #region Gets regions

        /// <summary>
        /// Arta
        /// </summary>
        public static EnumValues Arta => EnumValues.Arta;

        /// <summary>
        /// Ali Sabieh
        /// </summary>
        public static EnumValues AliSabieh => EnumValues.AliSabieh;

        /// <summary>
        /// Dikhil
        /// </summary>
        public static EnumValues Dikhil => EnumValues.Dikhil;

        /// <summary>
        /// Djibouti
        /// </summary>
        public static EnumValues Djibouti => EnumValues.Djibouti;

        /// <summary>
        /// Obock
        /// </summary>
        public static EnumValues Obock => EnumValues.Obock;

        /// <summary>
        /// Tadjourah
        /// </summary>
        public static EnumValues Tadjourah => EnumValues.Tadjourah;

        #endregion

        /// <summary>
        /// Enum values for Djibouti regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Arta
            /// </summary>
            [AliasInShort("AR")] [RegionCode(1_00_113_0001)]
            Arta,

            /// <summary>
            /// Ali Sabieh
            /// </summary>
            [AliasInShort("AS")] [RegionCode(1_00_113_0002)]
            AliSabieh,

            /// <summary>
            /// Dikhil
            /// </summary>
            [AliasInShort("DI")] [RegionCode(1_00_113_0003)]
            Dikhil,

            /// <summary>
            /// Djibouti
            /// </summary>
            [AliasInShort("DJ")] [RegionCode(1_00_113_0004)]
            Djibouti,

            /// <summary>
            /// Obock
            /// </summary>
            [AliasInShort("OB")] [RegionCode(1_00_113_0005)]
            Obock,

            /// <summary>
            /// Tadjourah
            /// </summary>
            [AliasInShort("TA")] [RegionCode(1_00_113_0006)]
            Tadjourah,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="DjiboutiRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="DjiboutiRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"DJ-{values.ToRegionCode()}";
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
            return Country.Djibouti;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.DJ;
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