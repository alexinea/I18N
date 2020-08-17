using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Burundi regions
    /// </summary>
    public static class BurundiRegions
    {
        #region Gets regions

        /// <summary>
        /// Bubanza
        /// </summary>
        public static EnumValues Bubanza => EnumValues.Bubanza;

        /// <summary>
        /// Bujumbura Rural
        /// </summary>
        public static EnumValues BujumburaRural => EnumValues.BujumburaRural;

        /// <summary>
        /// Bujumbura
        /// </summary>
        public static EnumValues Bujumbura => EnumValues.Bujumbura;

        /// <summary>
        /// Bururi
        /// </summary>
        public static EnumValues Bururi => EnumValues.Bururi;

        /// <summary>
        /// Cankuzo
        /// </summary>
        public static EnumValues Cankuzo => EnumValues.Cankuzo;

        /// <summary>
        /// Cibitoke
        /// </summary>
        public static EnumValues Cibitoke => EnumValues.Cibitoke;

        /// <summary>
        /// Gitega
        /// </summary>
        public static EnumValues Gitega => EnumValues.Gitega;

        /// <summary>
        /// Kirundo
        /// </summary>
        public static EnumValues Kirundo => EnumValues.Kirundo;

        /// <summary>
        /// Karuzi
        /// </summary>
        public static EnumValues Karuzi => EnumValues.Karuzi;

        /// <summary>
        /// Kayanza
        /// </summary>
        public static EnumValues Kayanza => EnumValues.Kayanza;

        /// <summary>
        /// Makamba
        /// </summary>
        public static EnumValues Makamba => EnumValues.Makamba;

        /// <summary>
        /// Muramvya
        /// </summary>
        public static EnumValues Muramvya => EnumValues.Muramvya;

        /// <summary>
        /// Mwaro
        /// </summary>
        public static EnumValues Mwaro => EnumValues.Mwaro;

        /// <summary>
        /// Muyinga
        /// </summary>
        public static EnumValues Muyinga => EnumValues.Muyinga;

        /// <summary>
        /// Ngozi
        /// </summary>
        public static EnumValues Ngozi => EnumValues.Ngozi;

        /// <summary>
        /// Rumonge
        /// </summary>
        public static EnumValues Rumonge => EnumValues.Rumonge;

        /// <summary>
        /// Rutana
        /// </summary>
        public static EnumValues Rutana => EnumValues.Rutana;

        /// <summary>
        /// Ruyigi
        /// </summary>
        public static EnumValues Ruyigi => EnumValues.Ruyigi;

        #endregion

        /// <summary>
        /// Enum values for Burundi regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bubanza
            /// </summary>
            [AliasInShort("BB")][RegionCode(3_00_107_0001)] Bubanza,

            /// <summary>
            /// Bujumbura Rural
            /// </summary>
            [AliasInShort("BL")][RegionCode(3_00_107_0002)] BujumburaRural,

            /// <summary>
            /// Bujumbura
            /// </summary>
            [AliasInShort("BM")][RegionCode(3_00_107_0003)] Bujumbura,

            /// <summary>
            /// Bururi
            /// </summary>
            [AliasInShort("BR")][RegionCode(3_00_107_0004)] Bururi,

            /// <summary>
            /// Cankuzo
            /// </summary>
            [AliasInShort("CA")][RegionCode(3_00_107_0005)] Cankuzo,

            /// <summary>
            /// Cibitoke
            /// </summary>
            [AliasInShort("CI")][RegionCode(3_00_107_0006)] Cibitoke,

            /// <summary>
            /// Gitega
            /// </summary>
            [AliasInShort("GI")][RegionCode(3_00_107_0007)] Gitega,

            /// <summary>
            /// Kirundo
            /// </summary>
            [AliasInShort("KI")][RegionCode(3_00_107_0008)] Kirundo,

            /// <summary>
            /// Karuzi
            /// </summary>
            [AliasInShort("KR")][RegionCode(3_00_107_0009)] Karuzi,

            /// <summary>
            /// Kayanza
            /// </summary>
            [AliasInShort("KY")][RegionCode(3_00_107_0010)] Kayanza,

            /// <summary>
            /// Makamba
            /// </summary>
            [AliasInShort("MA")][RegionCode(3_00_107_0011)] Makamba,

            /// <summary>
            /// Muramvya
            /// </summary>
            [AliasInShort("MU")][RegionCode(3_00_107_0012)] Muramvya,

            /// <summary>
            /// Mwaro
            /// </summary>
            [AliasInShort("MW")][RegionCode(3_00_107_0013)] Mwaro,

            /// <summary>
            /// Muyinga
            /// </summary>
            [AliasInShort("MY")][RegionCode(3_00_107_0014)] Muyinga,

            /// <summary>
            /// Ngozi
            /// </summary>
            [AliasInShort("NG")][RegionCode(3_00_107_0015)] Ngozi,

            /// <summary>
            /// Rumonge
            /// </summary>
            [AliasInShort("RM")][RegionCode(3_00_107_0016)] Rumonge,

            /// <summary>
            /// Rutana
            /// </summary>
            [AliasInShort("RT")][RegionCode(3_00_107_0017)] Rutana,

            /// <summary>
            /// Ruyigi
            /// </summary>
            [AliasInShort("RY")][RegionCode(3_00_107_0018)] Ruyigi,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BurundiRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BurundiRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"BI-{values.ToRegionCode()}";
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
            return Country.Burundi;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.BI;
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