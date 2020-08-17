using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Ukraine Regions
    /// </summary>
    public static class UkraineRegions
    {
        #region Gets regions

        /// <summary>
        /// Vinnychchyna
        /// </summary>
        public static EnumValues Vinnychchyna => EnumValues.Vinnychchyna;

        /// <summary>
        /// Volyn
        /// </summary>
        public static EnumValues Volyn => EnumValues.Volyn;

        /// <summary>
        /// Luhanshchyna
        /// </summary>
        public static EnumValues Luhanshchyna => EnumValues.Luhanshchyna;

        /// <summary>
        /// Dnipropetrovshchyna
        /// </summary>
        public static EnumValues Dnipropetrovshchyna => EnumValues.Dnipropetrovshchyna;

        /// <summary>
        /// Baghdad
        /// </summary>
        public static EnumValues Donechchyna => EnumValues.Donechchyna;

        /// <summary>
        /// Zhytomyrshchyna
        /// </summary>
        public static EnumValues Zhytomyrshchyna => EnumValues.Zhytomyrshchyna;

        /// <summary>
        /// Zakarpattia
        /// </summary>
        public static EnumValues Zakarpattia => EnumValues.Zakarpattia;

        /// <summary>
        /// Zaporizhzhya
        /// </summary>
        public static EnumValues Zaporizhzhya => EnumValues.Zaporizhzhya;

        /// <summary>
        /// Prykarpattia
        /// </summary>
        public static EnumValues Prykarpattia => EnumValues.Prykarpattia;

        /// <summary>
        /// Kiev
        /// </summary>
        public static EnumValues Kiev => EnumValues.Kiev;

        /// <summary>
        /// Kyivshchyna
        /// </summary>
        public static EnumValues Kyivshchyna => EnumValues.Kyivshchyna;

        /// <summary>
        /// Kirovohradschyna
        /// </summary>
        public static EnumValues Kirovohradschyna => EnumValues.Kirovohradschyna;

        /// <summary>
        /// Sevastopol
        /// </summary>
        public static EnumValues Sevastopol => EnumValues.Sevastopol;

        /// <summary>
        /// Crimea
        /// </summary>
        public static EnumValues Crimea => EnumValues.Crimea;

        /// <summary>
        /// Lvivshchyna
        /// </summary>
        public static EnumValues Lvivshchyna => EnumValues.Lvivshchyna;

        /// <summary>
        /// Mykolayivschyna
        /// </summary>
        public static EnumValues Mykolayivschyna => EnumValues.Mykolayivschyna;

        /// <summary>
        /// Odeshchyna
        /// </summary>
        public static EnumValues Odeshchyna => EnumValues.Odeshchyna;

        /// <summary>
        /// Poltavshchyna
        /// </summary>
        public static EnumValues Poltavshchyna => EnumValues.Poltavshchyna;

        /// <summary>
        /// Rivnenshchyna
        /// </summary>
        public static EnumValues Rivnenshchyna => EnumValues.Rivnenshchyna;

        /// <summary>
        /// Sumshchyna
        /// </summary>
        public static EnumValues Sumshchyna => EnumValues.Sumshchyna;

        /// <summary>
        /// Ternopilshchyna
        /// </summary>
        public static EnumValues Ternopilshchyna => EnumValues.Ternopilshchyna;

        /// <summary>
        /// Kharkivshchyna
        /// </summary>
        public static EnumValues Kharkivshchyna => EnumValues.Kharkivshchyna;

        /// <summary>
        /// Khersonshchyna
        /// </summary>
        public static EnumValues Khersonshchyna => EnumValues.Khersonshchyna;

        /// <summary>
        /// Khmelnychchyna
        /// </summary>
        public static EnumValues Khmelnychchyna => EnumValues.Khmelnychchyna;

        /// <summary>
        /// Cherkashchyna
        /// </summary>
        public static EnumValues Cherkashchyna => EnumValues.Cherkashchyna;

        /// <summary>
        /// Chernihivshchyna
        /// </summary>
        public static EnumValues Chernihivshchyna => EnumValues.Chernihivshchyna;

        /// <summary>
        /// Chernivtsi Oblast
        /// </summary>
        public static EnumValues ChernivtsiOblast => EnumValues.ChernivtsiOblast;

        #endregion

        /// <summary>
        /// Enum values for Ukraine regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Vinnychchyna
            /// </summary>
            [AliasInShort("05")] [RegionCode(2_00_140_0005)]
            Vinnychchyna,

            /// <summary>
            /// Volyn
            /// </summary>
            [AliasInShort("07")] [RegionCode(2_00_140_0007)]
            Volyn,

            /// <summary>
            /// Luhanshchyna
            /// </summary>
            [AliasInShort("09")] [RegionCode(2_00_140_0009)]
            Luhanshchyna,

            /// <summary>
            /// Dnipropetrovshchyna
            /// </summary>
            [AliasInShort("12")] [RegionCode(2_00_140_0012)]
            Dnipropetrovshchyna,

            /// <summary>
            /// Donechchyna
            /// </summary>
            [AliasInShort("14")] [RegionCode(2_00_140_0014)]
            Donechchyna,

            /// <summary>
            /// Zhytomyrshchyna
            /// </summary>
            [AliasInShort("18")] [RegionCode(2_00_140_0018)]
            Zhytomyrshchyna,

            /// <summary>
            /// Zakarpattia
            /// </summary>
            [AliasInShort("21")] [RegionCode(2_00_140_0021)]
            Zakarpattia,

            /// <summary>
            /// Zaporizhzhya
            /// </summary>
            [AliasInShort("23")] [RegionCode(2_00_140_0023)]
            Zaporizhzhya,

            /// <summary>
            /// Prykarpattia
            /// </summary>
            [AliasInShort("26")] [RegionCode(2_00_140_0026)]
            Prykarpattia,

            /// <summary>
            /// Kiev
            /// </summary>
            [AliasInShort("30")] [RegionCode(2_00_140_0030)]
            Kiev,

            /// <summary>
            /// Kyivshchyna
            /// </summary>
            [AliasInShort("32")] [RegionCode(2_00_140_0032)]
            Kyivshchyna,

            /// <summary>
            /// Kirovohradschyna
            /// </summary>
            [AliasInShort("35")] [RegionCode(2_00_140_0035)]
            Kirovohradschyna,

            /// <summary>
            /// Sevastopol
            /// </summary>
            [AliasInShort("40")] [RegionCode(2_00_140_0040)]
            Sevastopol,

            /// <summary>
            /// Crimea
            /// </summary>
            [AliasInShort("43")] [RegionCode(2_00_140_0043)]
            Crimea,

            /// <summary>
            /// Lvivshchyna
            /// </summary>
            [AliasInShort("46")] [RegionCode(2_00_140_0046)]
            Lvivshchyna,

            /// <summary>
            /// Mykolayivschyna
            /// </summary>
            [AliasInShort("48")] [RegionCode(2_00_140_0048)]
            Mykolayivschyna,

            /// <summary>
            /// Odeshchyna
            /// </summary>
            [AliasInShort("51")] [RegionCode(2_00_140_0051)]
            Odeshchyna,

            /// <summary>
            /// Poltavshchyna
            /// </summary>
            [AliasInShort("53")] [RegionCode(2_00_140_0053)]
            Poltavshchyna,

            /// <summary>
            /// Rivnenshchyna
            /// </summary>
            [AliasInShort("56")] [RegionCode(2_00_140_0056)]
            Rivnenshchyna,

            /// <summary>
            /// Sumshchyna
            /// </summary>
            [AliasInShort("59")] [RegionCode(2_00_140_0059)]
            Sumshchyna,

            /// <summary>
            /// Ternopilshchyna
            /// </summary>
            [AliasInShort("61")] [RegionCode(2_00_140_0061)]
            Ternopilshchyna,

            /// <summary>
            /// Kharkivshchyna
            /// </summary>
            [AliasInShort("63")] [RegionCode(2_00_140_0062)]
            Kharkivshchyna,

            /// <summary>
            /// Khersonshchyna
            /// </summary>
            [AliasInShort("65")] [RegionCode(2_00_140_0065)]
            Khersonshchyna,

            /// <summary>
            /// Khmelnychchyna
            /// </summary>
            [AliasInShort("68")] [RegionCode(2_00_140_0068)]
            Khmelnychchyna,

            /// <summary>
            /// Cherkashchyna
            /// </summary>
            [AliasInShort("71")] [RegionCode(2_00_140_0071)]
            Cherkashchyna,

            /// <summary>
            /// Chernihivshchyna
            /// </summary>
            [AliasInShort("74")] [RegionCode(2_00_140_0074)]
            Chernihivshchyna,

            /// <summary>
            /// Chernivtsi Oblast
            /// </summary>
            [AliasInShort("77")] [RegionCode(2_00_140_0077)]
            ChernivtsiOblast,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="UkraineRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="UkraineRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"UA-{values.ToRegionCode()}";
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
            return Country.Ukraine;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.UA;
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