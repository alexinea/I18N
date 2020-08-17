using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Taiwan Regions <br />
    /// 台湾，中华人民共和国的一部分 <br />
    /// Taiwan, a part of China <br />
    /// </summary>
    public static class TaiwanRegions
    {
        #region Gets regions

        /// <summary>
        /// Changhua
        /// </summary>
        public static EnumValues Changhua => EnumValues.Changhua;

        /// <summary>
        /// Chiayi County
        /// </summary>
        public static EnumValues ChiayiCounty => EnumValues.ChiayiCounty;

        /// <summary>
        /// Chiayi
        /// </summary>
        public static EnumValues Chiayi => EnumValues.Chiayi;

        /// <summary>
        /// Hsinchu County
        /// </summary>
        public static EnumValues HsinchuCounty => EnumValues.HsinchuCounty;

        /// <summary>
        /// Hsinchu
        /// </summary>
        public static EnumValues Hsinchu => EnumValues.Hsinchu;

        /// <summary>
        /// Hualien
        /// </summary>
        public static EnumValues Hualien => EnumValues.Hualien;

        /// <summary>
        /// Yilan
        /// </summary>
        public static EnumValues Yilan => EnumValues.Yilan;

        /// <summary>
        /// Keelung
        /// </summary>
        public static EnumValues Keelung => EnumValues.Keelung;

        /// <summary>
        /// Kaohsiung
        /// </summary>
        public static EnumValues Kaohsiung => EnumValues.Kaohsiung;

        /// <summary>
        /// Kinmen
        /// </summary>
        public static EnumValues Kinmen => EnumValues.Kinmen;

        /// <summary>
        /// Lienchiang
        /// </summary>
        public static EnumValues Lienchiang => EnumValues.Lienchiang;

        /// <summary>
        /// Miaoli    
        /// </summary>
        public static EnumValues Miaoli => EnumValues.Miaoli;

        /// <summary>
        /// Nantou
        /// </summary>
        public static EnumValues Nantou => EnumValues.Nantou;

        /// <summary>
        /// New Taipei
        /// </summary>
        public static EnumValues NewTaipei => EnumValues.NewTaipei;

        /// <summary>
        /// Penghu
        /// </summary>
        public static EnumValues Penghu => EnumValues.Penghu;

        /// <summary>
        /// Pingtung
        /// </summary>
        public static EnumValues Pingtung => EnumValues.Pingtung;

        /// <summary>
        /// Taoyuan
        /// </summary>
        public static EnumValues Taoyuan => EnumValues.Taoyuan;

        /// <summary>
        /// Tainan
        /// </summary>
        public static EnumValues Tainan => EnumValues.Tainan;

        /// <summary>
        /// Taipei
        /// </summary>
        public static EnumValues Taipei => EnumValues.Taipei;

        /// <summary>
        /// Taitung
        /// </summary>
        public static EnumValues Taitung => EnumValues.Taitung;

        /// <summary>
        /// Taichung
        /// </summary>
        public static EnumValues Taichung => EnumValues.Taichung;

        /// <summary>
        /// Yunlin
        /// </summary>
        public static EnumValues Yunlin => EnumValues.Yunlin;

        #endregion

        /// <summary>
        /// Enum values for Iraq regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Changhua
            /// </summary>
            [AliasInShort("CHA")] [RegionCode(1_00_001_0032_1001)]
            Changhua,

            /// <summary>
            /// Chiayi County
            /// </summary>
            [AliasInShort("CYI")] [RegionCode(1_00_001_0032_1002)]
            ChiayiCounty,

            /// <summary>
            /// Chiayi
            /// </summary>
            [AliasInShort("CYQ")] [RegionCode(1_00_001_0032_1003)]
            Chiayi,

            /// <summary>
            /// Hsinchu County
            /// </summary>
            [AliasInShort("HSQ")] [RegionCode(1_00_001_0032_1004)]
            HsinchuCounty,

            /// <summary>
            /// Hsinchu
            /// </summary>
            [AliasInShort("HSZ")] [RegionCode(1_00_001_0032_1005)]
            Hsinchu,

            /// <summary>
            /// Hualien
            /// </summary>
            [AliasInShort("HUA")] [RegionCode(1_00_001_0032_1006)]
            Hualien,

            /// <summary>
            /// Yilan
            /// </summary>
            [AliasInShort("ILA")] [RegionCode(1_00_001_0032_1007)]
            Yilan,

            /// <summary>
            /// Keelung
            /// </summary>
            [AliasInShort("KEE")] [RegionCode(1_00_001_0032_1008)]
            Keelung,

            /// <summary>
            /// Kaohsiung
            /// <br />
            /// 高雄，中国台湾省的一部分
            /// </summary>
            [AliasInShort("KHH")] [RegionCode(1_00_001_0032_1009)]
            Kaohsiung,

            /// <summary>
            /// Kinmen
            /// <br />
            /// 金门，中国台湾省的一部分
            /// </summary>
            [AliasInShort("KIN")] [RegionCode(1_00_001_0032_1010)]
            Kinmen,

            /// <summary>
            /// Lienchiang
            /// </summary>
            [AliasInShort("LTE")] [RegionCode(1_00_001_0032_1011)]
            Lienchiang,

            /// <summary>
            /// Miaoli
            /// </summary>
            [AliasInShort("MIA")] [RegionCode(1_00_001_0032_1012)]
            Miaoli,

            /// <summary>
            /// Nantou
            /// </summary>
            [AliasInShort("NAN")] [RegionCode(1_00_001_0032_1013)]
            Nantou,

            /// <summary>
            /// New Taipei
            /// <br />
            /// 新北，中国台湾省的一部分
            /// </summary>
            [AliasInShort("NWT")] [RegionCode(1_00_001_0032_1014)]
            NewTaipei,

            /// <summary>
            /// Penghu
            /// <br />
            /// 澎湖，中国台湾省的一部分
            /// </summary>
            [AliasInShort("PEN")] [RegionCode(1_00_001_0032_1015)]
            Penghu,

            /// <summary>
            /// Pingtung
            /// </summary>
            [AliasInShort("PIF")] [RegionCode(1_00_001_0032_1016)]
            Pingtung,

            /// <summary>
            /// Taoyuan
            /// <br />
            /// 桃园，中国台湾省的一部分
            /// </summary>
            [AliasInShort("TAO")] [RegionCode(1_00_001_0032_1017)]
            Taoyuan,

            /// <summary>
            /// Tainan
            /// <br />
            /// 台南，中国台湾省的一部分
            /// </summary>
            [AliasInShort("TNN")] [RegionCode(1_00_001_0032_1018)]
            Tainan,

            /// <summary>
            /// Taipei
            /// <br />
            /// 台北，中国台湾省的一部分
            /// </summary>
            [AliasInShort("TPE")] [RegionCode(1_00_001_0032_1019)]
            Taipei,

            /// <summary>
            /// Taitung
            /// </summary>
            [AliasInShort("TTT")] [RegionCode(1_00_001_0032_1020)]
            Taitung,

            /// <summary>
            /// Taichung
            /// </summary>
            [AliasInShort("TXG")] [RegionCode(1_00_001_0032_1021)]
            Taichung,

            /// <summary>
            /// Yunlin
            /// <br />
            /// 榆林，中国台湾省的一部分
            /// </summary>
            [AliasInShort("YUN")] [RegionCode(1_00_001_0032_1022)]
            Yunlin,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="IraqRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="IraqRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CN-TW-{values.ToRegionCode()}";
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
            return Country.China;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CN;
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