using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Finland Regions
    /// </summary>
    public static class FinlandRegions
    {
        #region Gets regions

        /// <summary>
        /// South Karelia
        /// </summary>
        public static EnumValues SouthKarelia => EnumValues.SouthKarelia;

        /// <summary>
        /// Southern Ostrobothnia
        /// </summary>
        public static EnumValues SouthernOstrobothnia => EnumValues.SouthernOstrobothnia;

        /// <summary>
        /// Southern Savonia
        /// </summary>
        public static EnumValues SouthernSavonia => EnumValues.SouthernSavonia;

        /// <summary>
        /// Kainuu
        /// </summary>
        public static EnumValues Kainuu => EnumValues.Kainuu;

        /// <summary>
        /// Tavastia Proper
        /// </summary>
        public static EnumValues TavastiaProper => EnumValues.TavastiaProper;

        /// <summary>
        /// Central Ostrobothnia
        /// </summary>
        public static EnumValues CentralOstrobothnia => EnumValues.CentralOstrobothnia;

        /// <summary>
        /// Central Finland
        /// </summary>
        public static EnumValues CentralFinland => EnumValues.CentralFinland;

        /// <summary>
        /// Kymenlaakso
        /// </summary>
        public static EnumValues Kymenlaakso => EnumValues.Kymenlaakso;

        /// <summary>
        /// Lapland
        /// </summary>
        public static EnumValues Lapland => EnumValues.Lapland;

        /// <summary>
        /// Pirkanmaa
        /// </summary>
        public static EnumValues Pirkanmaa => EnumValues.Pirkanmaa;

        /// <summary>
        /// Ostrobothnia
        /// </summary>
        public static EnumValues Ostrobothnia => EnumValues.Ostrobothnia;

        /// <summary>
        /// North Karelia
        /// </summary>
        public static EnumValues NorthKarelia => EnumValues.NorthKarelia;

        /// <summary>
        /// Northern Ostrobothnia
        /// </summary>
        public static EnumValues NorthernOstrobothnia => EnumValues.NorthernOstrobothnia;

        /// <summary>
        /// Northern Savonia
        /// </summary>
        public static EnumValues NorthernSavonia => EnumValues.NorthernSavonia;

        /// <summary>
        /// Päijänne Tavastia
        /// </summary>
        public static EnumValues PäijänneTavastia => EnumValues.PäijänneTavastia;

        /// <summary>
        /// Satakunta
        /// </summary>
        public static EnumValues Satakunta => EnumValues.Satakunta;

        /// <summary>
        /// Uusimaa
        /// </summary>
        public static EnumValues Uusimaa => EnumValues.Uusimaa;

        /// <summary>
        /// Southwest Finland
        /// </summary>
        public static EnumValues SouthwestFinland => EnumValues.SouthwestFinland;

        /// <summary>
        /// Aland Islands
        /// </summary>
        public static EnumValues AlandIslands => EnumValues.Aland;

        #endregion

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special
        {
            /// <summary>
            /// Aland Island
            /// </summary>
            public static Country Aland => Country.AlandIslands;

            /// <summary>
            /// Aland Island
            /// </summary>
            public static CountryCode AlandCode => CountryCode.AX;
        }

        /// <summary>
        /// Cnum values for China regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// South Karelia
            /// </summary>
            [AliasInShort("02")] [RegionCode(2_00_113_0002)] [RegionFlag("main")]
            SouthKarelia,

            /// <summary>
            /// Southern Ostrobothnia
            /// </summary>
            [AliasInShort("03")] [RegionCode(2_00_113_0003)] [RegionFlag("main")]
            SouthernOstrobothnia,

            /// <summary>
            /// Southern Savonia
            /// </summary>
            [AliasInShort("04")] [RegionCode(2_00_113_0004)] [RegionFlag("main")]
            SouthernSavonia,

            /// <summary>
            /// Kainuu
            /// </summary>
            [AliasInShort("05")] [RegionCode(2_00_113_0005)] [RegionFlag("main")]
            Kainuu,

            /// <summary>
            /// Tavastia Proper
            /// </summary>
            [AliasInShort("06")] [RegionCode(2_00_113_0006)] [RegionFlag("main")]
            TavastiaProper,

            /// <summary>
            /// Central Ostrobothnia
            /// </summary>
            [AliasInShort("07")] [RegionCode(2_00_113_0007)] [RegionFlag("main")]
            CentralOstrobothnia,

            /// <summary>
            /// Central Finland
            /// </summary>
            [AliasInShort("08")] [RegionCode(2_00_113_0008)] [RegionFlag("main")]
            CentralFinland,

            /// <summary>
            /// Kymenlaakso
            /// </summary>
            [AliasInShort("09")] [RegionCode(2_00_113_0009)] [RegionFlag("main")]
            Kymenlaakso,

            /// <summary>
            /// Lapland
            /// </summary>
            [AliasInShort("10")] [RegionCode(2_00_113_0010)] [RegionFlag("main")]
            Lapland,

            /// <summary>
            /// Pirkanmaa
            /// </summary>
            [AliasInShort("11")] [RegionCode(2_00_113_0011)] [RegionFlag("main")]
            Pirkanmaa,

            /// <summary>
            /// Ostrobothnia
            /// </summary>
            [AliasInShort("12")] [RegionCode(2_00_113_0012)] [RegionFlag("main")]
            Ostrobothnia,

            /// <summary>
            /// North Karelia
            /// </summary>
            [AliasInShort("13")] [RegionCode(2_00_113_0013)] [RegionFlag("main")]
            NorthKarelia,

            /// <summary>
            /// Northern Ostrobothnia
            /// </summary>
            [AliasInShort("14")] [RegionCode(2_00_113_0014)] [RegionFlag("main")]
            NorthernOstrobothnia,

            /// <summary>
            /// Northern Savonia
            /// </summary>
            [AliasInShort("15")] [RegionCode(2_00_113_0015)] [RegionFlag("main")]
            NorthernSavonia,

            /// <summary>
            /// Päijänne Tavastia
            /// </summary>
            [AliasInShort("16")] [RegionCode(2_00_113_0016)] [RegionFlag("main")]
            PäijänneTavastia,

            /// <summary>
            /// Satakunta
            /// </summary>
            [AliasInShort("17")] [RegionCode(2_00_113_0017)] [RegionFlag("main")]
            Satakunta,

            /// <summary>
            /// Uusimaa
            /// </summary>
            [AliasInShort("18")] [RegionCode(2_00_113_0018)] [RegionFlag("main")]
            Uusimaa,

            /// <summary>
            /// Southwest Finland
            /// </summary>
            [AliasInShort("19")] [RegionCode(2_00_113_0019)] [RegionFlag("main")]
            SouthwestFinland,

            /// <summary>
            /// Aland Island
            /// <br />
            /// FI-AX, also, FI-01
            /// </summary>
            [AliasInShort("AX")] [RegionCode(2_00_101)] [RegionFlag("overseas")]
            Aland,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="FinlandRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="FinlandRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"FI-{values.ToRegionCode()}";
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
            switch (value)
            {
                case EnumValues.Aland:
                    return Country.AlandIslands;
                default:
                    return Country.Finland;
            }
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            switch (value)
            {
                case EnumValues.Aland:
                    return CountryCode.AX;
                default:
                    return CountryCode.FI;
            }
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Convert from special regions of Finland
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country)
        {
            switch (country)
            {
                case Country.AlandIslands:
                    return EnumValues.Aland;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of Finland
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code)
        {
            switch (code)
            {
                case CountryCode.AX:
                    return EnumValues.Aland;
                default:
                    return EnumValues.Unknown;
            }
        }

        #endregion

        #region Getters

        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(member => !member.HasAttr<EnumValues, IgnoreRegionAttribute>());

        private static IEnumerable<EnumMember<EnumValues>> Filter(string flag) =>
            InternalEnumMembersCache.Where(x => x.Attributes.GetAll<RegionFlagAttribute>().Any(attr => attr.Flag == flag));

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// 获得主要地区的地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMainRegionCodes()
            => Filter("main").Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// 获得海外地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetOverseasRegionCodes()
            => Filter("overseas").Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// Get all numeric region code(CEP-1 / Cosmos Region Code).
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetAllNumericRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToNumericRegionCode());

        #endregion
    }
}