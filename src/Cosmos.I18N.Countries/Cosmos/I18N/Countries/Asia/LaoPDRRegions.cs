using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Regions of Lao People's Democratic Republic
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class LaoPDRRegions
    {
        #region Gets regions

        /// <summary>
        /// Attapeu
        /// </summary>
        public static EnumValues Attapeu => EnumValues.Attapeu;

        /// <summary>
        /// Bokeo
        /// </summary>
        public static EnumValues Bokeo => EnumValues.Bokeo;

        /// <summary>
        /// Bolikhamsai
        /// </summary>
        public static EnumValues Bolikhamsai => EnumValues.Bolikhamsai;

        /// <summary>
        /// Champasak
        /// </summary>
        public static EnumValues Champasak => EnumValues.Champasak;

        /// <summary>
        /// Houaphanh
        /// </summary>
        public static EnumValues Houaphanh => EnumValues.Houaphanh;

        /// <summary>
        /// Khammouane
        /// </summary>
        public static EnumValues Khammouane => EnumValues.Khammouane;

        /// <summary>
        /// Luang Namtha
        /// </summary>
        public static EnumValues LuangNamtha => EnumValues.LuangNamtha;

        /// <summary>
        /// Luang Prabang  
        /// </summary>
        public static EnumValues LuangPrabang => EnumValues.LuangPrabang;

        /// <summary>
        /// Oudomxay
        /// </summary>
        public static EnumValues Oudomxay => EnumValues.Oudomxay;

        /// <summary>
        /// Phongsaly
        /// </summary>
        public static EnumValues Phongsaly => EnumValues.Phongsaly;

        /// <summary>
        /// Salavan
        /// </summary>
        public static EnumValues Salavan => EnumValues.Salavan;

        /// <summary>
        /// Savannakhet
        /// </summary>
        public static EnumValues Savannakhet => EnumValues.Savannakhet;

        /// <summary>
        /// Vientiane Province
        /// </summary>
        public static EnumValues VientianeProvince => EnumValues.VientianeProvince;

        /// <summary>
        /// Vientiane
        /// </summary>
        public static EnumValues Vientiane => EnumValues.Vientiane;

        /// <summary>
        /// Sainyabuli
        /// </summary>
        public static EnumValues Sainyabuli => EnumValues.Sainyabuli;

        /// <summary>
        /// Sekong
        /// </summary>
        public static EnumValues Sekong => EnumValues.Sekong;

        /// <summary>
        /// Xiangkhouang
        /// </summary>
        public static EnumValues Xiangkhouang => EnumValues.Xiangkhouang;

        /// <summary>
        /// Xaisomboun
        /// </summary>
        public static EnumValues Xaisomboun => EnumValues.Xaisomboun;

        #endregion

        /// <summary>
        /// Enum values for LaoPDR regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Attapeu
            /// </summary>
            [AliasInShort("AT")][RegionCode(1_00_122_0001)] Attapeu,

            /// <summary>
            /// Bokeo
            /// </summary>
            [AliasInShort("BK")][RegionCode(1_00_122_0002)] Bokeo,

            /// <summary>
            /// Bolikhamsai
            /// </summary>
            [AliasInShort("BL")][RegionCode(1_00_122_0003)] Bolikhamsai,

            /// <summary>
            /// Babylon
            /// </summary>
            [AliasInShort("CH")][RegionCode(1_00_122_0004)] Champasak,

            /// <summary>
            /// Houaphanh
            /// </summary>
            [AliasInShort("HO")][RegionCode(1_00_122_0005)] Houaphanh,

            /// <summary>
            /// Khammouane
            /// </summary>
            [AliasInShort("KH")][RegionCode(1_00_122_0006)] Khammouane,

            /// <summary>
            /// Luang Namtha
            /// </summary>
            [AliasInShort("LM")][RegionCode(1_00_122_0007)] LuangNamtha,

            /// <summary>
            /// Luang Prabang
            /// </summary>
            [AliasInShort("LP")][RegionCode(1_00_122_0008)] LuangPrabang,

            /// <summary>
            /// Oudomxay
            /// </summary>
            [AliasInShort("OU")][RegionCode(1_00_122_0009)] Oudomxay,

            /// <summary>
            /// Phongsaly
            /// </summary>
            [AliasInShort("PH")][RegionCode(1_00_122_0010)] Phongsaly,

            /// <summary>
            /// Salavan
            /// </summary>
            [AliasInShort("SL")][RegionCode(1_00_122_0011)] Salavan,

            /// <summary>
            /// Savannakhet
            /// </summary>
            [AliasInShort("SV")][RegionCode(1_00_122_0012)] Savannakhet,

            /// <summary>
            /// Vientiane Province
            /// </summary>
            [AliasInShort("VI")][RegionCode(1_00_122_0013)] VientianeProvince,

            /// <summary>
            /// Vientiane
            /// </summary>
            [AliasInShort("VT")][RegionCode(1_00_122_0014)] Vientiane,

            /// <summary>
            /// Sainyabuli
            /// </summary>
            [AliasInShort("XA")][RegionCode(1_00_122_0015)] Sainyabuli,

            /// <summary>
            /// Sekong
            /// </summary>
            [AliasInShort("XE")][RegionCode(1_00_122_0016)] Sekong,

            /// <summary>
            /// Xiangkhouang
            /// </summary>
            [AliasInShort("XI")][RegionCode(1_00_122_0017)] Xiangkhouang,

            /// <summary>
            /// Xaisomboun
            /// </summary>
            [AliasInShort("XS")][RegionCode(1_00_122_0018)] Xaisomboun,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="LaoPDRRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="LaoPDRRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"LA-{values.ToRegionCode()}";
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
            return Country.LaoPDR;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.LA;
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