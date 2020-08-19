using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Iran Regions
    /// </summary>
    public static partial class Iran
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Khuzestan
            /// </summary>
            public static EnumValues Khuzestan => EnumValues.Khuzestan;

            /// <summary>
            /// Zanjan
            /// </summary>
            public static EnumValues Zanjan => EnumValues.Zanjan;

            /// <summary>
            /// Semnan
            /// </summary>
            public static EnumValues Semnan => EnumValues.Semnan;

            /// <summary>
            /// Sistan and Baluchestan
            /// </summary>
            public static EnumValues SistanAndBaluchestan => EnumValues.SistanAndBaluchestan;

            /// <summary>
            /// Fars
            /// </summary>
            public static EnumValues Fars => EnumValues.Fars;

            /// <summary>
            /// Kerman
            /// </summary>
            public static EnumValues Kerman => EnumValues.Kerman;

            /// <summary>
            /// Kurdistan
            /// </summary>
            public static EnumValues Kurdistan => EnumValues.Kurdistan;

            /// <summary>
            /// Kermanshah
            /// </summary>
            public static EnumValues Kermanshah => EnumValues.Kermanshah;

            /// <summary>
            /// Kohgiluyeh and Boyer-Ahmad
            /// </summary>
            public static EnumValues KohgiluyehAndBoyerAhmad => EnumValues.KohgiluyehAndBoyerAhmad;

            /// <summary>
            /// Gilan
            /// </summary>
            public static EnumValues Gilan => EnumValues.Gilan;

            /// <summary>
            /// Lorestan
            /// </summary>
            public static EnumValues Lorestan => EnumValues.Lorestan;

            /// <summary>
            /// Mazandaran
            /// </summary>
            public static EnumValues Mazandaran => EnumValues.Mazandaran;

            /// <summary>
            /// Markazi
            /// </summary>
            public static EnumValues Markazi => EnumValues.Markazi;

            /// <summary>
            /// Hormozgan
            /// </summary>
            public static EnumValues Hormozgan => EnumValues.Hormozgan;

            /// <summary>
            /// Hamadan
            /// </summary>
            public static EnumValues Hamadan => EnumValues.Hamadan;

            /// <summary>
            /// Yazd
            /// </summary>
            public static EnumValues Yazd => EnumValues.Yazd;

            /// <summary>
            /// Qom
            /// </summary>
            public static EnumValues Qom => EnumValues.Qom;

            /// <summary>
            /// Golestan
            /// </summary>
            public static EnumValues Golestan => EnumValues.Golestan;

            /// <summary>
            /// Qazvin
            /// </summary>
            public static EnumValues Qazvin => EnumValues.Qazvin;

            /// <summary>
            /// South Khorasan
            /// </summary>
            public static EnumValues SouthKhorasan => EnumValues.SouthKhorasan;

            /// <summary>
            /// Razavi Khorasan
            /// </summary>
            public static EnumValues RazaviKhorasan => EnumValues.RazaviKhorasan;

            /// <summary>
            /// North Khorasan
            /// </summary>
            public static EnumValues NorthKhorasan => EnumValues.NorthKhorasan;

            /// <summary>
            /// Alborz
            /// </summary>
            public static EnumValues Alborz => EnumValues.Alborz;

            /// <summary>
            /// East Azerbaijan
            /// </summary>
            public static EnumValues EastAzerbaijan => EnumValues.EastAzerbaijan;

            /// <summary>
            /// West Azarbaijan
            /// </summary>
            public static EnumValues WestAzarbaijan => EnumValues.WestAzarbaijan;

            /// <summary>
            /// Ardabil
            /// </summary>
            public static EnumValues Ardabil => EnumValues.Ardabil;

            /// <summary>
            /// Isfahan
            /// </summary>
            public static EnumValues Isfahan => EnumValues.Isfahan;

            /// <summary>
            /// Ilam
            /// </summary>
            public static EnumValues Ilam => EnumValues.Ilam;

            /// <summary>
            /// Bushehr
            /// </summary>
            public static EnumValues Bushehr => EnumValues.Bushehr;

            /// <summary>
            /// Tehran
            /// </summary>
            public static EnumValues Tehran => EnumValues.Tehran;

            /// <summary>
            /// Chaharmahal and Bakhtiari
            /// </summary>
            public static EnumValues ChaharmahalAndBakhtiari => EnumValues.ChaharmahalAndBakhtiari;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Iran regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Khuzestan
            /// </summary>
            [AliasInShort("10")]
            [RegionCode(1_00_014_0010)]
            Khuzestan,

            /// <summary>
            /// Zanjan
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(1_00_014_0011)]
            Zanjan,

            /// <summary>
            /// Semnan
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(1_00_014_0012)]
            Semnan,

            /// <summary>
            /// Sistan and Baluchestan
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(1_00_014_0013)]
            SistanAndBaluchestan,

            /// <summary>
            /// Fars
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(1_00_014_0014)]
            Fars,

            /// <summary>
            /// Kerman
            /// </summary>
            [AliasInShort("15")]
            [RegionCode(1_00_014_0015)]
            Kerman,

            /// <summary>
            /// Kurdistan
            /// </summary>
            [AliasInShort("16")]
            [RegionCode(1_00_014_0016)]
            Kurdistan,

            /// <summary>
            /// Kermanshah
            /// </summary>
            [AliasInShort("17")]
            [RegionCode(1_00_014_0017)]
            Kermanshah,

            /// <summary>
            /// Kohgiluyeh and Boyer-Ahmad
            /// </summary>
            [AliasInShort("18")]
            [RegionCode(1_00_014_0018)]
            KohgiluyehAndBoyerAhmad,

            /// <summary>
            /// Gilan
            /// </summary>
            [AliasInShort("19")]
            [RegionCode(1_00_014_0019)]
            Gilan,

            /// <summary>
            /// Lorestan
            /// </summary>
            [AliasInShort("20")]
            [RegionCode(1_00_014_0020)]
            Lorestan,

            /// <summary>
            /// Mazandaran
            /// </summary>
            [AliasInShort("21")]
            [RegionCode(1_00_014_0021)]
            Mazandaran,

            /// <summary>
            /// Markazi
            /// </summary>
            [AliasInShort("22")]
            [RegionCode(1_00_014_0022)]
            Markazi,

            /// <summary>
            /// Hormozgan
            /// </summary>
            [AliasInShort("23")]
            [RegionCode(1_00_014_0023)]
            Hormozgan,

            /// <summary>
            /// Hamadan
            /// </summary>
            [AliasInShort("24")]
            [RegionCode(1_00_014_0024)]
            Hamadan,

            /// <summary>
            /// Yazd
            /// </summary>
            [AliasInShort("25")]
            [RegionCode(1_00_014_0025)]
            Yazd,

            /// <summary>
            /// Qom
            /// </summary>
            [AliasInShort("26")]
            [RegionCode(1_00_014_0026)]
            Qom,

            /// <summary>
            /// Golestan
            /// </summary>
            [AliasInShort("27")]
            [RegionCode(1_00_014_0027)]
            Golestan,

            /// <summary>
            /// Qazvin
            /// </summary>
            [AliasInShort("28")]
            [RegionCode(1_00_014_0028)]
            Qazvin,

            /// <summary>
            /// South Khorasan
            /// </summary>
            [AliasInShort("29")]
            [RegionCode(1_00_014_0029)]
            SouthKhorasan,

            /// <summary>
            /// Razavi Khorasan
            /// </summary>
            [AliasInShort("30")]
            [RegionCode(1_00_014_0030)]
            RazaviKhorasan,

            /// <summary>
            /// North Khorasan
            /// </summary>
            [AliasInShort("31")]
            [RegionCode(1_00_014_0031)]
            NorthKhorasan,

            /// <summary>
            /// Alborz
            /// </summary>
            [AliasInShort("32")]
            [RegionCode(1_00_014_0032)]
            Alborz,

            /// <summary>
            /// East Azerbaijan
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(1_00_014_0001)]
            EastAzerbaijan,

            /// <summary>
            /// West Azarbaijan
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(1_00_014_0002)]
            WestAzarbaijan,

            /// <summary>
            /// Ardabil
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(1_00_014_0003)]
            Ardabil,

            /// <summary>
            /// Isfahan
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(1_00_014_0004)]
            Isfahan,

            /// <summary>
            /// Ilam
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(1_00_014_0005)]
            Ilam,

            /// <summary>
            /// Bushehr
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(1_00_014_0006)]
            Bushehr,

            /// <summary>
            /// Tehran
            /// </summary>
            [AliasInShort("07")]
            [RegionCode(1_00_014_0007)]
            Tehran,

            /// <summary>
            /// Chaharmahal and Bakhtiari
            /// </summary>
            [AliasInShort("08")]
            [RegionCode(1_00_014_0008)]
            ChaharmahalAndBakhtiari,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            [RegionCode(0)]
            Unknown,
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
        /// Get all numeric region code(CEP-1 / Cosmos Region Code).
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetAllNumericRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToNumericRegionCode());

        #endregion
    }
}