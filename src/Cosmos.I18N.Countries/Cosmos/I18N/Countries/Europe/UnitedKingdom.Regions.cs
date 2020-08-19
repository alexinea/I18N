using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// United Kingdom Regions
    /// </summary>
    public static partial class UnitedKingdom
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        private static IEnumerable<EnumMember<EnumValues>> Filter(string flag) => RegionEnumHelper.Filter(InternalEnumMembersCache, flag);


        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// 英格兰
            /// </summary>
            public static EnumValues England => EnumValues.England;

            /// <summary>
            /// 北爱尔兰
            /// </summary>
            public static EnumValues NorthernIreland => EnumValues.NorthernIreland;

            /// <summary>
            /// 苏格兰
            /// </summary>
            public static EnumValues Scottland => EnumValues.Scottland;

            /// <summary>
            /// 威尔士
            /// </summary>
            public static EnumValues Wales => EnumValues.Wales;

            /// <summary>
            /// 奥尔德尼岛
            /// </summary>
            public static EnumValues Alderney => EnumValues.Alderney;

            /// <summary>
            /// Bailiwick of Guernsey
            /// <br />
            /// 根西岛
            /// </summary>
            public static EnumValues Guernsey => EnumValues.Guernsey;

            /// <summary>
            /// Bailiwick of Jersey
            /// <br />
            /// 泽西
            /// </summary>
            public static EnumValues Jersey => EnumValues.Jersey;

            /// <summary>
            /// Isle of Man
            /// <br />
            /// 英属马恩岛
            /// </summary>
            public static EnumValues Mann => EnumValues.Mann;

            /// <summary>
            /// Gibraltar
            /// <br />
            /// 直布罗陀
            /// </summary>
            public static EnumValues Gibraltar => EnumValues.Gibraltar;

            /// <summary>
            /// The Bermuda Islands
            /// <br />
            /// 百慕大群岛
            /// </summary>
            public static EnumValues Bermuda => EnumValues.Bermuda;

            /// <summary>
            /// Cayman Islands
            /// <br />
            /// 开曼群岛
            /// </summary>
            public static EnumValues CaymanIslands => EnumValues.CaymanIslands;

            /// <summary>
            /// The Turks and Caicos Islands
            /// <br />
            /// 特克斯和凯科斯群岛
            /// </summary>
            public static EnumValues TurksAndCaicosIslands => EnumValues.TurksAndCaicosIslands;

            /// <summary>
            /// The British Virgin Islands
            /// <br />
            /// 英属维尔金群岛
            /// </summary>
            public static EnumValues BritishVirginIslands => EnumValues.BritishVirginIslands;

            /// <summary>
            /// Anguilla
            /// <br />
            /// 安圭拉
            /// </summary>
            public static EnumValues Anguilla => EnumValues.Anguilla;

            /// <summary>
            /// Montserrat
            /// <br />
            /// 蒙特塞拉特
            /// </summary>
            public static EnumValues Montserrat => EnumValues.Montserrat;

            /// <summary>
            /// Saint Helena, Ascension and Tristan da Cunha
            /// <br />
            /// 圣赫勒拿、阿森松与特里斯坦达库尼亚
            /// </summary>
            public static EnumValues SaintHelena => EnumValues.SaintHelena;

            /// <summary>
            /// South Georgia and The South Sandwich Islands
            /// <br />
            /// 南乔治亚岛和南桑威奇群岛
            /// </summary>
            // ReSharper disable once InconsistentNaming
            public static EnumValues SGSSI => EnumValues.SGSSI;

            /// <summary>
            /// British Indian Ocean Territory
            /// <br />
            /// 英属印度洋领地
            /// </summary>
            public static EnumValues BritishIndianOceanTerritory => EnumValues.BritishIndianOceanTerritory;

            /// <summary>
            /// Pitcairn Islands
            /// <br />
            /// 皮特凯恩群岛
            /// </summary>
            public static EnumValues Pitcairn => EnumValues.Pitcairn;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special
        {
            /// <summary>
            /// Bailiwick of Guernsey
            /// <br />
            /// 根西岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Guernsey => Country.Guernsey;

            /// <summary>
            /// Bailiwick of Guernsey
            /// <br />
            /// 根西岛
            /// </summary>
            public static CountryCode GuernseyCode => CountryCode.GG;

            /// <summary>
            /// Bailiwick of Jersey
            /// <br />
            /// 泽西
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Jersey => Country.Jersey;

            /// <summary>
            /// Bailiwick of Jersey
            /// <br />
            /// 泽西
            /// </summary>
            public static CountryCode JerseyCode => CountryCode.JE;

            /// <summary>
            /// Isle of Man
            /// <br />
            /// 英属马恩岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Mann = Country.Mann;

            /// <summary>
            /// Isle of Man
            /// <br />
            /// 英属马恩岛
            /// </summary>
            public static CountryCode MannCode => CountryCode.IM;

            /// <summary>
            /// Gibraltar
            /// <br />
            /// 直布罗陀
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Gibraltar => Country.Gibraltar;

            /// <summary>
            /// Gibraltar
            /// <br />
            /// 直布罗陀
            /// </summary>
            public static CountryCode GibraltarCode => CountryCode.GI;

            /// <summary>
            /// The Bermuda Islands
            /// <br />
            /// 百慕大群岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Bermuda => Country.Bermuda;

            /// <summary>
            /// The Bermuda Islands
            /// <br />
            /// 百慕大群岛
            /// </summary>
            public static CountryCode BermudaCode => CountryCode.BM;

            /// <summary>
            /// Cayman Islands
            /// <br />
            /// 开曼群岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country CaymanIslands => Country.CaymanIslands;

            /// <summary>
            /// Cayman Islands
            /// <br />
            /// 开曼群岛
            /// </summary>
            public static CountryCode CaymanIslandsCode => CountryCode.KY;

            /// <summary>
            /// The Turks and Caicos Islands
            /// <br />
            /// 特克斯和凯科斯群岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country TurksAndCaicosIslands => Country.TurksAndCaicosIslands;

            /// <summary>
            /// The Turks and Caicos Islands
            /// <br />
            /// 特克斯和凯科斯群岛
            /// </summary>
            public static CountryCode TurksAndCaicosIslandsCode => CountryCode.TC;

            /// <summary>
            /// The British Virgin Islands
            /// <br />
            /// 英属维尔金群岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country BritishVirginIslands => Country.VirginIslandsBritish;

            /// <summary>
            /// The British Virgin Islands
            /// <br />
            /// 英属维尔金群岛
            /// </summary>
            public static CountryCode BritishVirginIslandsCode => CountryCode.VG;

            /// <summary>
            /// Anguilla
            /// <br />
            /// 安圭拉
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Anguilla => Country.Anguilla;

            /// <summary>
            /// Anguilla
            /// <br />
            /// 安圭拉
            /// </summary>
            public static CountryCode AnguillaCode => CountryCode.AI;

            /// <summary>
            /// Montserrat
            /// <br />
            /// 蒙特塞拉特
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Montserrat => Country.Montserrat;

            /// <summary>
            /// Montserrat
            /// <br />
            /// 蒙特塞拉特
            /// </summary>
            public static CountryCode MontserratCode => CountryCode.MS;

            /// <summary>
            /// Saint Helena, Ascension and Tristan da Cunha
            /// <br />
            /// 圣赫勒拿、阿森松与特里斯坦达库尼亚
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country SaintHelena => Country.SaintHelena;

            /// <summary>
            /// Saint Helena, Ascension and Tristan da Cunha
            /// <br />
            /// 圣赫勒拿、阿森松与特里斯坦达库尼亚
            /// </summary>
            public static CountryCode SaintHelenaCode => CountryCode.SH;

            /// <summary>
            /// South Georgia and The South Sandwich Islands
            /// <br />
            /// 南乔治亚岛和南桑威奇群岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            // ReSharper disable once InconsistentNaming
            public static Country SGSSI => Country.SGSSI;

            /// <summary>
            /// South Georgia and The South Sandwich Islands
            /// <br />
            /// 南乔治亚岛和南桑威奇群岛
            /// </summary>
            // ReSharper disable once InconsistentNaming
            public static CountryCode SGSSICode => CountryCode.GS;

            /// <summary>
            /// British Indian Ocean Territory
            /// <br />
            /// 英属印度洋领地
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country BritishIndianOceanTerritory => Country.BritishIndianOceanTerritory;

            /// <summary>
            /// British Indian Ocean Territory
            /// <br />
            /// 英属印度洋领地
            /// </summary>
            public static CountryCode BritishIndianOceanTerritoryCode => CountryCode.IO;

            /// <summary>
            /// Pitcairn Islands
            /// <br />
            /// 皮特凯恩群岛
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Pitcairn => Country.Pitcairn;

            /// <summary>
            /// Pitcairn Islands
            /// <br />
            /// 皮特凯恩群岛
            /// </summary>
            public static CountryCode PitcairnCode => CountryCode.PN;
        }

        /// <summary>
        /// Enum values for United Kingdom regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// 英格兰
            /// </summary>
            [AliasInShort("ENG")]
            [RegionCode(2_00_005_0001)]
            [RegionFlag("main")]
            England,

            /// <summary>
            /// 北爱尔兰
            /// </summary>
            [AliasInShort("NIR")]
            [RegionCode(2_00_005_0002)]
            [RegionFlag("main")]
            NorthernIreland,

            /// <summary>
            /// 苏格兰
            /// </summary>
            [AliasInShort("SCT")]
            [RegionCode(2_00_005_0003)]
            [RegionFlag("main")]
            Scottland,

            /// <summary>
            /// 威尔士
            /// </summary>
            [AliasInShort("WLS")]
            [RegionCode(2_00_005_0004)]
            [RegionFlag("main")]
            Wales,

            /// <summary>
            /// 奥尔德尼岛
            /// </summary>
            [AliasInShort("ALD")]
            [RegionCode(2_00_005_0005)]
            [RegionFlag("overseas")]
            Alderney,

            /// <summary>
            /// Bailiwick of Guernsey
            /// <br />
            /// 根西岛
            /// </summary>
            [AliasInShort("GG")]
            [RegionCode(2_00_116)]
            [RegionFlag("overseas")]
            Guernsey,

            /// <summary>
            /// Bailiwick of Jersey
            /// <br />
            /// 泽西
            /// </summary>
            [AliasInShort("JE")]
            [RegionCode(2_00_119)]
            [RegionFlag("overseas")]
            Jersey,

            /// <summary>
            /// Isle of Man
            /// <br />
            /// 英属马恩岛
            /// </summary>
            [AliasInShort("IM")]
            [RegionCode(2_00_127)]
            [RegionFlag("overseas")]
            Mann,

            /// <summary>
            /// Gibraltar
            /// <br />
            /// 直布罗陀
            /// </summary>
            [AliasInShort("GI")]
            [RegionCode(2_00_114)]
            [RegionFlag("overseas")]
            Gibraltar,

            /// <summary>
            /// The Bermuda Islands
            /// <br />
            /// 百慕大群岛
            /// </summary>
            [AliasInShort("BM")]
            [RegionCode(4_00_108)]
            [RegionFlag("overseas")]
            Bermuda,

            /// <summary>
            /// Cayman Islands
            /// <br />
            /// 开曼群岛
            /// </summary>
            [AliasInShort("KY")]
            [RegionCode(4_00_110)]
            [RegionFlag("overseas")]
            CaymanIslands,

            /// <summary>
            /// The Turks and Caicos Islands
            /// <br />
            /// 特克斯和凯科斯群岛
            /// </summary>
            [AliasInShort("TC")]
            [RegionCode(4_00_135)]
            [RegionFlag("overseas")]
            TurksAndCaicosIslands,

            /// <summary>
            /// The British Virgin Islands
            /// <br />
            /// 英属维尔金群岛
            /// </summary>
            [AliasInShort("VG")]
            [RegionCode(4_00_137)]
            [RegionFlag("overseas")]
            BritishVirginIslands,

            /// <summary>
            /// Anguilla
            /// <br />
            /// 安圭拉
            /// </summary>
            [AliasInShort("AI")]
            [RegionCode(4_00_102)]
            [RegionFlag("overseas")]
            Anguilla,

            /// <summary>
            /// Montserrat
            /// <br />
            /// 蒙特塞拉特
            /// </summary>
            [AliasInShort("MS")]
            [RegionCode(4_00_124)]
            [RegionFlag("overseas")]
            Montserrat,

            /// <summary>
            /// Saint Helena, Ascension and Tristan da Cunha
            /// <br />
            /// 圣赫勒拿、阿森松与特里斯坦达库尼亚
            /// </summary>
            [AliasInShort("SH")]
            [RegionCode(3_00_121)]
            [RegionFlag("overseas")]
            SaintHelena,

            /// <summary>
            /// South Georgia and The South Sandwich Islands
            /// <br />
            /// 南乔治亚岛和南桑威奇群岛
            /// </summary>
            [AliasInShort("GS")]
            [RegionCode(5_00_111)]
            [RegionFlag("overseas")]
            // ReSharper disable once InconsistentNaming
            SGSSI,

            /// <summary>
            /// British Indian Ocean Territory
            /// <br />
            /// 英属印度洋领地
            /// </summary>
            [AliasInShort("IO")]
            [RegionCode(1_00_107)]
            [RegionFlag("overseas")]
            BritishIndianOceanTerritory,

            /// <summary>
            /// Pitcairn Islands
            /// <br />
            /// 皮特凯恩群岛
            /// </summary>
            [AliasInShort("PN")]
            [RegionCode(6_00_117)]
            [RegionFlag("overseas")]
            Pitcairn,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            [RegionCode(0)]
            Unknown,
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Convert from special regions of United States
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country)
        {
            switch (country)
            {
                case Country.Guernsey:
                    return EnumValues.Guernsey;
                case Country.Jersey:
                    return EnumValues.Jersey;
                case Country.Mann:
                    return EnumValues.Mann;
                case Country.Gibraltar:
                    return EnumValues.Gibraltar;
                case Country.Bermuda:
                    return EnumValues.Bermuda;
                case Country.CaymanIslands:
                    return EnumValues.CaymanIslands;
                case Country.TurksAndCaicosIslands:
                    return EnumValues.TurksAndCaicosIslands;
                case Country.VirginIslandsBritish:
                    return EnumValues.BritishVirginIslands;
                case Country.Anguilla:
                    return EnumValues.Anguilla;
                case Country.Montserrat:
                    return EnumValues.Montserrat;
                case Country.SaintHelena:
                    return EnumValues.SaintHelena;
                case Country.SGSSI:
                    return EnumValues.SGSSI;
                case Country.BritishIndianOceanTerritory:
                    return EnumValues.BritishIndianOceanTerritory;
                case Country.Pitcairn:
                    return EnumValues.Pitcairn;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of United States
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code)
        {
            switch (code)
            {
                case CountryCode.GG:
                    return EnumValues.Guernsey;
                case CountryCode.JE:
                    return EnumValues.Jersey;
                case CountryCode.IM:
                    return EnumValues.Mann;
                case CountryCode.GI:
                    return EnumValues.Gibraltar;
                case CountryCode.BM:
                    return EnumValues.Bermuda;
                case CountryCode.KY:
                    return EnumValues.CaymanIslands;
                case CountryCode.TC:
                    return EnumValues.TurksAndCaicosIslands;
                case CountryCode.VG:
                    return EnumValues.BritishVirginIslands;
                case CountryCode.AI:
                    return EnumValues.Anguilla;
                case CountryCode.MS:
                    return EnumValues.Montserrat;
                case CountryCode.SH:
                    return EnumValues.SaintHelena;
                case CountryCode.GS:
                    return EnumValues.SGSSI;
                case CountryCode.IO:
                    return EnumValues.BritishIndianOceanTerritory;
                case CountryCode.PN:
                    return EnumValues.Pitcairn;
                default:
                    return EnumValues.Unknown;
            }
        }

        #endregion

        #region All regions getter

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// Get overseas region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetOverseasRegionCodes()
            => Filter("overseas").Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// Get main region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMainRegionCodes()
            => Filter("main").Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// Get all numeric region code(CEP-1 / Cosmos Region Code).
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetAllNumericRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToNumericRegionCode());

        #endregion
    }
}