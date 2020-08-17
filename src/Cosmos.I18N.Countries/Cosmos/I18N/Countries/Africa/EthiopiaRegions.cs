using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Ethiopia regions
    /// </summary>
    public static class EthiopiaRegions
    {
        #region Gets regions

        /// <summary>
        /// Addis Ababa
        /// </summary>
        public static EnumValues AddisAbaba => EnumValues.AddisAbaba;

        /// <summary>
        /// Afar
        /// </summary>
        public static EnumValues Afar => EnumValues.Afar;

        /// <summary>
        /// Amhara
        /// </summary>
        public static EnumValues Amhara => EnumValues.Amhara;

        /// <summary>
        /// Benishangul-Gumuz
        /// </summary>
        public static EnumValues BenishangulGumuz => EnumValues.BenishangulGumuz;

        /// <summary>
        /// Dire Dawa
        /// </summary>
        public static EnumValues DireDawa => EnumValues.DireDawa;

        /// <summary>
        /// Gambela
        /// </summary>
        public static EnumValues Gambela => EnumValues.Gambela;

        /// <summary>
        /// Harari
        /// </summary>
        public static EnumValues Harari => EnumValues.Harari;

        /// <summary>
        /// Oromia
        /// </summary>
        public static EnumValues Oromia => EnumValues.Oromia;

        /// <summary>
        /// Southern Nations, Nationalities, and Peoples
        /// </summary>
        public static EnumValues SouthernNationsAndNationalitiesAndPeoples => EnumValues.SouthernNationsAndNationalitiesAndPeoples;

        /// <summary>
        /// Somali
        /// </summary>
        public static EnumValues Somali => EnumValues.Somali;

        /// <summary>
        /// Tigray
        /// </summary>
        public static EnumValues Tigray => EnumValues.Tigray;

        #endregion

        /// <summary>
        /// Enum values for Ethiopia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Addis Ababa
            /// </summary>
            [AliasInShort("AA")][RegionCode(3_00_123_0001)] AddisAbaba,

            /// <summary>
            /// Afar
            /// </summary>
            [AliasInShort("AF")][RegionCode(3_00_123_0002)] Afar,

            /// <summary>
            /// Amhara
            /// </summary>
            [AliasInShort("AM")][RegionCode(3_00_123_0003)] Amhara,

            /// <summary>
            /// Benishangul-Gumuz
            /// </summary>
            [AliasInShort("BE")][RegionCode(3_00_123_0004)] BenishangulGumuz,

            /// <summary>
            /// Dire Dawa
            /// </summary>
            [AliasInShort("DD")][RegionCode(3_00_123_0005)] DireDawa,

            /// <summary>
            /// Gambela
            /// </summary>
            [AliasInShort("GA")] [RegionCode(3_00_123_0006)]Gambela,

            /// <summary>
            /// Harari
            /// </summary>
            [AliasInShort("HA")][RegionCode(3_00_123_0007)] Harari,

            /// <summary>
            /// Oromia
            /// </summary>
            [AliasInShort("OR")][RegionCode(3_00_123_0008)] Oromia,

            /// <summary>
            /// Southern Nations, Nationalities, and Peoples
            /// </summary>
            [AliasInShort("SN")][RegionCode(3_00_123_0009)] SouthernNationsAndNationalitiesAndPeoples,

            /// <summary>
            /// Somali
            /// </summary>
            [AliasInShort("SO")][RegionCode(3_00_123_0010)] Somali,

            /// <summary>
            /// Tigray
            /// </summary>
            [AliasInShort("TI")][RegionCode(3_00_123_0011)] Tigray,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="EthiopiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="EthiopiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"ET-{values.ToRegionCode()}";
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
            return Country.Ethiopia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.ET;
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