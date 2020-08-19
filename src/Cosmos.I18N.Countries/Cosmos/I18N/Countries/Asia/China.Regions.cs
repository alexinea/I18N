using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// China regions
    /// </summary>
    public static partial class China
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);


        private static IEnumerable<EnumMember<EnumValues>> Filter(string flag) => RegionEnumHelper.Filter(InternalEnumMembersCache, flag);


        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// 北京
            /// </summary>
            public static EnumValues Beijing => EnumValues.Beijing;

            /// <summary>
            /// 天津
            /// </summary>
            public static EnumValues Tianjin => EnumValues.Tianjin;

            /// <summary>
            /// 河北
            /// </summary>
            public static EnumValues Hebei => EnumValues.Hebei;

            /// <summary>
            /// 山西
            /// </summary>
            public static EnumValues Shanxi => EnumValues.Shanxi;

            /// <summary>
            /// 内蒙古
            /// </summary>
            public static EnumValues InnerMongoria => EnumValues.InnerMongoria;

            /// <summary>
            /// 内蒙古
            /// </summary>
            public static EnumValues Neimenggu => InnerMongoria;

            /// <summary>
            /// 辽宁
            /// </summary>
            public static EnumValues Liaoning => EnumValues.Liaoning;

            /// <summary>
            /// 吉林
            /// </summary>
            public static EnumValues Jilin => EnumValues.Jilin;

            /// <summary>
            /// 黑龙江
            /// </summary>
            public static EnumValues Heilongjiang => EnumValues.Heilongjiang;

            /// <summary>
            /// 上海
            /// </summary>
            public static EnumValues Shanghai => EnumValues.Shanghai;

            /// <summary>
            /// 江苏
            /// </summary>
            public static EnumValues Jiangsu => EnumValues.Jiangsu;

            /// <summary>
            /// 浙江
            /// </summary>
            public static EnumValues Zhejiang => EnumValues.Zhejiang;

            /// <summary>
            /// 安徽
            /// </summary>
            public static EnumValues Anhui => EnumValues.Anhui;

            /// <summary>
            /// 福建
            /// </summary>
            public static EnumValues Fjian => EnumValues.Fujian;

            /// <summary>
            /// 江西
            /// </summary>
            public static EnumValues Jianxi => EnumValues.Jiangxi;

            /// <summary>
            /// 河南
            /// </summary>
            public static EnumValues Henan => EnumValues.Henan;

            /// <summary>
            /// 山东
            /// </summary>
            public static EnumValues Shandong => EnumValues.Shandong;

            /// <summary>
            /// 湖北
            /// </summary>
            public static EnumValues Hubei => EnumValues.Hubei;

            /// <summary>
            /// 湖南
            /// </summary>
            public static EnumValues Hunan => EnumValues.Hunan;

            /// <summary>
            /// 广东
            /// </summary>
            public static EnumValues Guangdong => EnumValues.Guangdong;

            /// <summary>
            /// 广西
            /// </summary>
            public static EnumValues Guangxi => EnumValues.Guangxi;

            /// <summary>
            /// 海南
            /// </summary>
            public static EnumValues Hainan => EnumValues.Hainan;

            /// <summary>
            /// 重庆
            /// </summary>
            public static EnumValues Chongqing => EnumValues.Chongqing;

            /// <summary>
            /// 四川
            /// </summary>
            public static EnumValues Sichuan => EnumValues.Sichuan;

            /// <summary>
            /// 贵州
            /// </summary>
            public static EnumValues Guizhou => EnumValues.Guizhou;

            /// <summary>
            /// 云南
            /// </summary>
            public static EnumValues Yunnan => EnumValues.Yunnan;

            /// <summary>
            /// 西藏
            /// </summary>
            public static EnumValues Tibet => EnumValues.Tibet;

            /// <summary>
            /// 西藏
            /// </summary>
            public static EnumValues Xizang => Tibet;

            /// <summary>
            /// 陕西
            /// </summary>
            public static EnumValues Shaanxi => EnumValues.Shaanxi;

            /// <summary>
            /// 甘肃
            /// </summary>
            public static EnumValues Gansu => EnumValues.Gansu;

            /// <summary>
            /// 青海
            /// </summary>
            public static EnumValues Qinghai => EnumValues.Qinghai;

            /// <summary>
            /// 宁夏
            /// </summary>
            public static EnumValues Ningxia => EnumValues.Ningxia;

            /// <summary>
            /// 新疆
            /// </summary>
            public static EnumValues Xinjiang => EnumValues.Xinjiang;

            /// <summary>
            /// Taiwan, a part of China.
            /// </summary>
            public static EnumValues Taiwan => EnumValues.Taiwan;


            /// <summary>
            /// HongKong, a part of China.
            /// </summary>
            public static EnumValues HongKong => EnumValues.HongKong;

            /// <summary>
            /// 香港
            /// </summary>
            public static EnumValues Xianggang => HongKong;

            /// <summary>
            /// Macao, a part of China.
            /// </summary>
            public static EnumValues Macao => EnumValues.Macao;

            /// <summary>
            /// 澳门
            /// </summary>
            public static EnumValues Aomen => Macao;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special
        {
            /// <summary>
            /// HongKong, a part of China.
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country HongKong => Country.HongKong;

            /// <summary>
            /// Code of HongKong, a part of China.
            /// </summary>
            public static CountryCode HongKongCode => CountryCode.HK;

            /// <summary>
            /// Macao, a part of China.
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Macao => Country.Macao;

            /// <summary>
            /// Code of Macao, a part of China.
            /// </summary>
            public static CountryCode MacaoCode => CountryCode.MO;

            /// <summary>
            /// Taiwan, a part of China.
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Taiwan => Country.Taiwan;

            /// <summary>
            /// Code of Taiwan, a part of China.
            /// </summary>
            public static CountryCode TaiwanCode => CountryCode.TW;
        }

        /// <summary>
        /// Enum values for China regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// 北京
            /// </summary>
            [AliasInShort("BJ")]
            [RegionName("Beijing")]
            [LocalRegionName("zh_CN", "北京市")]
            [RegionCode(1_00_001_0001)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Beijing = 1,

            /// <summary>
            /// 天津
            /// </summary>
            [AliasInShort("TJ")]
            [RegionName("Tianjin")]
            [LocalRegionName("zh_CN", "天津市")]
            [RegionCode(1_00_001_0002)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Tianjin = 2,

            /// <summary>
            /// 河北
            /// </summary>
            [AliasInShort("HE")]
            [RegionName("Hebei")]
            [LocalRegionName("zh_CN", "河北省")]
            [RegionCode(1_00_001_0003)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Hebei = 3,

            /// <summary>
            /// 山西
            /// </summary>
            [AliasInShort("SX")]
            [RegionName("Shanxi")]
            [LocalRegionName("zh_CN", "山西省")]
            [RegionCode(1_00_001_0004)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Shanxi = 4,

            /// <summary>
            /// 内蒙古自治区
            /// </summary>
            [AliasInShort("NM")]
            [RegionName("InnerMongoria")]
            [LocalRegionName("zh_CN", "内蒙古自治区")]
            [RegionCode(1_00_001_0005)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            InnerMongoria = 5,

            /// <summary>
            /// 辽宁
            /// </summary>
            [AliasInShort("LN")]
            [RegionName("Liaoning")]
            [LocalRegionName("zh_CN", "辽宁省")]
            [RegionCode(1_00_001_0006)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Liaoning = 6,

            /// <summary>
            /// 吉林
            /// </summary>
            [AliasInShort("JL")]
            [RegionName("Jilin")]
            [LocalRegionName("zh_CN", "吉林省")]
            [RegionCode(1_00_001_0007)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Jilin = 7,

            /// <summary>
            /// 黑龙江
            /// </summary>
            [AliasInShort("HL")]
            [RegionName("Heilongjiang")]
            [LocalRegionName("zh_CN", "黑龙江省")]
            [RegionCode(1_00_001_0008)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Heilongjiang = 8,

            /// <summary>
            /// 上海
            /// </summary>
            [AliasInShort("SH")]
            [RegionName("Shanghai")]
            [LocalRegionName("zh_CN", "上海市")]
            [RegionCode(1_00_001_0009)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Shanghai = 9,

            /// <summary>
            /// 江苏
            /// </summary>
            [AliasInShort("JS")]
            [RegionName("Jiangsu")]
            [LocalRegionName("zh_CN", "江苏省")]
            [RegionCode(1_00_001_0010)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Jiangsu = 10,

            /// <summary>
            /// 浙江
            /// </summary>
            [AliasInShort("ZJ")]
            [RegionName("Zhejiang")]
            [LocalRegionName("zh_CN", "浙江省")]
            [RegionCode(1_00_001_0011)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Zhejiang = 11,

            /// <summary>
            /// 安徽
            /// </summary>
            [AliasInShort("AH")]
            [RegionName("Anhui")]
            [LocalRegionName("zh_CN", "安徽省")]
            [RegionCode(1_00_001_0012)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Anhui = 12,

            /// <summary>
            /// 福建
            /// </summary>
            [AliasInShort("FJ")]
            [RegionName("Fujian")]
            [LocalRegionName("zh_CN", "福建省")]
            [RegionCode(1_00_001_0013)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Fujian = 13,

            /// <summary>
            /// 江西
            /// </summary>
            [AliasInShort("JX")]
            [RegionName("Jiangxi")]
            [LocalRegionName("zh_CN", "江西省")]
            [RegionCode(1_00_001_0014)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Jiangxi = 14,

            /// <summary>
            /// 河南
            /// </summary>
            [AliasInShort("HA")]
            [RegionName("Henan")]
            [LocalRegionName("zh_CN", "河南省")]
            [RegionCode(1_00_001_0016)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Henan = 16,

            /// <summary>
            /// 山东
            /// </summary>
            [AliasInShort("SD")]
            [RegionName("Shandong")]
            [LocalRegionName("zh_CN", "山东省")]
            [RegionCode(1_00_001_0015)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Shandong = 15,

            /// <summary>
            /// 湖北
            /// </summary>
            [AliasInShort("HB")]
            [RegionName("Hubei")]
            [LocalRegionName("zh_CN", "湖北省")]
            [RegionCode(1_00_001_0017)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Hubei = 17,

            /// <summary>
            /// 湖南
            /// </summary>
            [AliasInShort("HN")]
            [RegionName("Hunan")]
            [LocalRegionName("zh_CN", "湖南省")]
            [RegionCode(1_00_001_0018)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Hunan = 18,

            /// <summary>
            /// 广东
            /// </summary>
            [AliasInShort("GD")]
            [RegionName("Guangdong")]
            [LocalRegionName("zh_CN", "广东省")]
            [RegionCode(1_00_001_0019)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Guangdong = 19,

            /// <summary>
            /// 广西
            /// </summary>
            [AliasInShort("GX")]
            [RegionName("Guangxi")]
            [LocalRegionName("zh_CN", "广西壮族自治区")]
            [RegionCode(1_00_001_0020)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Guangxi = 20,

            /// <summary>
            /// 海南
            /// </summary>
            [AliasInShort("HI")]
            [RegionName("海南")]
            [LocalRegionName("zh_CN", "海南省")]
            [RegionCode(1_00_001_0021)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Hainan = 21,

            /// <summary>
            /// 重庆
            /// </summary>
            [AliasInShort("CQ")]
            [RegionName("Chongqing")]
            [LocalRegionName("zh_CN", "重庆市")]
            [RegionCode(1_00_001_0022)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Chongqing = 22,

            /// <summary>
            /// 四川
            /// </summary>
            [AliasInShort("SC")]
            [RegionName("Sichuan")]
            [LocalRegionName("zh_CN", "四川省")]
            [RegionCode(1_00_001_0023)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Sichuan = 23,

            /// <summary>
            /// 贵州
            /// </summary>
            [AliasInShort("GZ")]
            [RegionName("Guizhou")]
            [LocalRegionName("zh_CN", "贵州省")]
            [RegionCode(1_00_001_0024)]
            [RegionFlag("mainland")]
            Guizhou = 24,

            /// <summary>
            /// 云南
            /// </summary>
            [AliasInShort("YN")]
            [RegionName("Yunnan")]
            [LocalRegionName("zh_CN", "云南省")]
            [RegionCode(1_00_001_0025)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Yunnan = 25,

            /// <summary>
            /// 西藏
            /// </summary>
            [AliasInShort("XZ")]
            [RegionName("Tibet")]
            [LocalRegionName("zh_CN", "西藏自治区")]
            [RegionCode(1_00_001_0026)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Tibet = 26,

            /// <summary>
            /// 陕西
            /// </summary>
            [AliasInShort("SN")]
            [RegionName("Shaanxi")]
            [LocalRegionName("zh_CN", "陕西省")]
            [RegionCode(1_00_001_0027)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Shaanxi = 27,


            /// <summary>
            /// 甘肃
            /// </summary>
            [AliasInShort("GS")]
            [RegionName("Gansu")]
            [LocalRegionName("zh_CN", "甘肃省")]
            [RegionCode(1_00_001_0028)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Gansu = 28,

            /// <summary>
            /// 青海
            /// </summary>
            [AliasInShort("QH")]
            [RegionName("Qinghai")]
            [LocalRegionName("zh_CN", "青海省")]
            [RegionCode(1_00_001_0029)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Qinghai = 29,

            /// <summary>
            /// 宁夏
            /// </summary>
            [AliasInShort("NX")]
            [RegionName("Ningxia")]
            [LocalRegionName("zh_CN", "宁夏回族自治区")]
            [RegionCode(1_00_001_0030)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Ningxia = 30,

            /// <summary>
            /// 新疆
            /// </summary>
            [AliasInShort("XJ")]
            [RegionName("Xinjiang")]
            [LocalRegionName("zh_CN", "新疆维吾尔族自治区")]
            [RegionCode(1_00_001_0031)]
            [RegionFlag("mainland")]
            [RegionFlag("endoland")]
            Xinjiang = 31,

            /// <summary>
            /// Taiwan, China<br />
            /// 中华人民共和国台湾省
            /// </summary>
            [AliasInShort("TW")]
            [RegionName("Taiwan")]
            [LocalRegionName("zh_CN", "中国台湾")]
            [RegionCode(1_00_001_0032)]
            Taiwan = 32,

            /// <summary>
            /// HongKong, China<br />
            /// 中华人民共和国香港特别行政区
            /// </summary>
            [AliasInShort("HK")]
            [RegionName("HongKong")]
            [LocalRegionName("zh_CN", "中华人民共和国香港特别行政区")]
            [RegionCode(1_00_001_0033)]
            [RegionFlag("mainland")]
            [RegionFlag(" special_district")]
            HongKong = 33,

            /// <summary>
            /// Macao, China<br />
            /// 中华人民共和国澳门特别行政区
            /// </summary>
            [AliasInShort("MO")]
            [RegionName("Macao")]
            [LocalRegionName("zh_CN", "中华人民共和国澳门特别行政区")]
            [RegionCode(1_00_001_0034)]
            [RegionFlag("mainland")]
            [RegionFlag(" special_district")]
            Macao = 34,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            [RegionCode(0)]
            Unknown = 99,
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Convert from special regions of China
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country)
        {
            switch (country)
            {
                case Country.HongKong:
                    return EnumValues.HongKong;
                case Country.Macao:
                    return EnumValues.Macao;
                case Country.Taiwan:
                    return EnumValues.Taiwan;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of China
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code)
        {
            switch (code)
            {
                case CountryCode.HK:
                    return EnumValues.HongKong;
                case CountryCode.MO:
                    return EnumValues.Macao;
                case CountryCode.TW:
                    return EnumValues.Taiwan;
                default:
                    return EnumValues.Unknown;
            }
        }

        #endregion

        #region Getters

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// 获得大陆地区的地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMainlandRegionCodes()
            => Filter("mainland").Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// 获得特别行政区地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetSpecialDistrictRegionCodes()
            => Filter("special_district").Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// 获得内陆地区的地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetEndolandRegionCodes()
            => Filter("endoland").Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// Get all numeric region code(CEP-1 / Cosmos Region Code).
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetAllNumericRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToNumericRegionCode());

        /// <summary>
        /// 获得大陆地区的地区 CEP-1 代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetNumericMainlandRegionCodes()
            => Filter("mainland").Select(member => member.Value.ToNumericRegionCode());

        /// <summary>
        /// 获得特别行政区地区 CEP-1 代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetNumericSpecialDistrictRegionCodes()
            => Filter("special_district").Select(member => member.Value.ToNumericRegionCode());

        /// <summary>
        /// 获得内陆地区的地区 CEP-1 代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetNumericEndolandRegionCodes()
            => Filter("endoland").Select(member => member.Value.ToNumericRegionCode());

        #endregion
    }
}