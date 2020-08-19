using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Australia regions
    /// </summary>
    public static partial class Australia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        private static IEnumerable<EnumMember<EnumValues>> Filter(string flag) => RegionEnumHelper.Filter(InternalEnumMembersCache, flag);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Australian Capital Territory
            /// </summary>
            public static EnumValues AustralianCapitalTerritory => EnumValues.AustralianCapitalTerritory;

            /// <summary>
            /// New South Wales
            /// </summary>
            public static EnumValues NewSouthWales => EnumValues.NewSouthWales;

            /// <summary>
            /// Northern Territory
            /// </summary>
            public static EnumValues NorthernTerritory => EnumValues.NorthernTerritory;

            /// <summary>
            /// Queensland
            /// </summary>
            public static EnumValues Queensland => EnumValues.Queensland;

            /// <summary>
            /// South Australia
            /// </summary>
            public static EnumValues SouthAustralia => EnumValues.SouthAustralia;

            /// <summary>
            /// Tasmania
            /// </summary>
            public static EnumValues Tasmania => EnumValues.Tasmania;

            /// <summary>
            /// Victoria
            /// </summary>
            public static EnumValues Victoria => EnumValues.Victoria;

            /// <summary>
            /// Western Australia
            /// </summary>
            public static EnumValues WesternAustralia => EnumValues.WesternAustralia;

            /// <summary>
            /// 删除海群岛
            /// </summary>
            public static EnumValues CoralSeaIslands => EnumValues.CoralSeaIslands;

            /// <summary>
            /// 阿什莫尔和卡捷岛
            /// </summary>
            public static EnumValues AshmoreAndCartierIslands => EnumValues.AshmoreAndCartierIslands;

            /// <summary>
            /// 科科斯群岛
            /// </summary>
            public static EnumValues CocosIslands => EnumValues.CocosIslands;

            /// <summary>
            /// 赫德岛及麦唐纳群岛
            /// </summary>
            public static EnumValues HeardIslandAndMcDonaldIslands => EnumValues.HeardIslandAndMcDonaldIslands;

            /// <summary>
            /// Christmas Island
            /// </summary>
            public static EnumValues ChristmasIsland => EnumValues.ChristmasIsland;

            /// <summary>
            /// Norfolk Island
            /// </summary>
            public static EnumValues NorfolkIsland => EnumValues.NorfolkIsland;
        }

        #endregion

        #region Special regions getter

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special
        {
            /// <summary>
            /// NorfolkIsland
            /// </summary>
            public static Country NorfolkIsland => Country.NorfolkIsland;

            /// <summary>
            /// NorfolkIsland
            /// </summary>
            public static CountryCode NorfolkIslandCode => CountryCode.NF;

            /// <summary>
            /// ChristmasIsland
            /// </summary>
            public static Country ChristmasIsland => Country.ChristmasIsland;

            /// <summary>
            /// ChristmasIsland
            /// </summary>
            public static CountryCode ChristmasIslandCode => CountryCode.CX;

            /// <summary>
            /// CocosIslands
            /// </summary>
            public static Country CocosIslands => Country.CocosIslands;

            /// <summary>
            /// CocosIslands
            /// </summary>
            public static CountryCode CocosIslandsCode => CountryCode.CC;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Australia regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Australian Capital Territory
            /// </summary>
            [AliasInShort("ACT")]
            [RegionCode(6_00_011_0001)]
            [RegionFlag("mainland")]
            AustralianCapitalTerritory,

            /// <summary>
            /// New South Wales
            /// </summary>
            [AliasInShort("NSW")]
            [RegionCode(6_00_011_0002)]
            [RegionFlag("mainland")]
            NewSouthWales,

            /// <summary>
            /// Northern Territory
            /// </summary>
            [AliasInShort("NT")]
            [RegionCode(6_00_011_0003)]
            [RegionFlag("mainland")]
            NorthernTerritory,

            /// <summary>
            /// Queensland
            /// </summary>
            [AliasInShort("QLD")]
            [RegionCode(6_00_011_0004)]
            [RegionFlag("mainland")]
            Queensland,

            /// <summary>
            /// South Australia
            /// </summary>
            [AliasInShort("SA")]
            [RegionCode(6_00_011_0005)]
            [RegionFlag("mainland")]
            SouthAustralia,

            /// <summary>
            /// Tasmania
            /// </summary>
            [AliasInShort("TAS")]
            [RegionCode(6_00_011_0006)]
            [RegionFlag("mainland")]
            Tasmania,

            /// <summary>
            /// Victoria
            /// </summary>
            [AliasInShort("VIC")]
            [RegionCode(6_00_011_0007)]
            [RegionFlag("mainland")]
            Victoria,

            /// <summary>
            /// Western Australia
            /// </summary>
            [AliasInShort("WA")]
            [RegionCode(6_00_011_0008)]
            [RegionFlag("mainland")]
            WesternAustralia,

            /// <summary>
            /// 删除海群岛
            /// </summary>
            [AliasInShort("CSI")]
            [RegionCode(6_00_011_0009)]
            [RegionFlag("overseas")]
            CoralSeaIslands,

            /// <summary>
            /// 阿什莫尔和卡捷岛
            /// </summary>
            [AliasInShort("ACI")]
            [RegionCode(6_00_011_0010)]
            [RegionFlag("overseas")]
            AshmoreAndCartierIslands,

            /// <summary>
            /// 科科斯群岛
            /// </summary>
            [AliasInShort("CC")]
            [RegionCode(6_00_011_0011)]
            [RegionFlag("overseas")]
            CocosIslands,

            /// <summary>
            /// 赫德岛及麦唐纳群岛
            /// </summary>
            [AliasInShort("HMD")]
            [RegionCode(6_00_011_0012)]
            [RegionFlag("overseas")]
            HeardIslandAndMcDonaldIslands,

            /// <summary>
            /// Christmas Island
            /// </summary>
            [AliasInShort("CX")]
            [RegionCode(6_00_011_0013)]
            [RegionFlag("overseas")]
            ChristmasIsland,

            /// <summary>
            /// Norfolk Island
            /// </summary>
            [AliasInShort("NF")]
            [RegionCode(6_00_011_0014)]
            [RegionFlag("overseas")]
            NorfolkIsland,

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
        /// Convert from special regions of Australia
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country)
        {
            switch (country)
            {
                case Country.CocosIslands:
                    return EnumValues.CocosIslands;
                case Country.ChristmasIsland:
                    return EnumValues.ChristmasIsland;
                case Country.NorfolkIsland:
                    return EnumValues.NorfolkIsland;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of Australia
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code)
        {
            switch (code)
            {
                case CountryCode.CC:
                    return EnumValues.CocosIslands;
                case CountryCode.CX:
                    return EnumValues.ChristmasIsland;
                case CountryCode.NF:
                    return EnumValues.NorfolkIsland;
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
        /// 获得本土地区的地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMainlandRegionCodes()
            => Filter("mainland").Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// 获得海外属地地区代号
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