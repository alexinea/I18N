using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Sudan Regions
    /// </summary>
    public static partial class Sudan
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Central Darfur
            /// </summary>
            public static EnumValues CentralDarfur => EnumValues.CentralDarfur;

            /// <summary>
            /// East Darfur
            /// </summary>
            public static EnumValues EastDarfur => EnumValues.EastDarfur;

            /// <summary>
            /// North Darfur
            /// </summary>
            public static EnumValues NorthDarfur => EnumValues.NorthDarfur;

            /// <summary>
            /// South Darfur
            /// </summary>
            public static EnumValues SouthDarfur => EnumValues.SouthDarfur;

            /// <summary>
            /// West Darfur
            /// </summary>
            public static EnumValues WestDarfur => EnumValues.WestDarfur;

            /// <summary>
            /// Al Qadarif
            /// </summary>
            public static EnumValues AlQadarif => EnumValues.AlQadarif;

            /// <summary>
            /// West Kurdufan
            /// </summary>
            public static EnumValues WestKurdufan => EnumValues.WestKurdufan;

            /// <summary>
            /// Al Jazirah
            /// </summary>
            public static EnumValues AlJazirah => EnumValues.AlJazirah;

            /// <summary>
            /// Kassala
            /// </summary>
            public static EnumValues Kassala => EnumValues.Kassala;

            /// <summary>
            /// Khartoum
            /// </summary>
            public static EnumValues Khartoum => EnumValues.Khartoum;

            /// <summary>
            /// North Kurdufan
            /// </summary>
            public static EnumValues NorthKurdufan => EnumValues.NorthKurdufan;

            /// <summary>
            /// South Kurdufan
            /// </summary>
            public static EnumValues SouthKurdufan => EnumValues.SouthKurdufan;

            /// <summary>
            /// Blue Nile
            /// </summary>
            public static EnumValues BlueNile => EnumValues.BlueNile;

            /// <summary>
            /// Northern
            /// </summary>
            public static EnumValues Northern => EnumValues.Northern;

            /// <summary>
            /// River Nile
            /// </summary>
            public static EnumValues RiverNile => EnumValues.RiverNile;

            /// <summary>
            /// White Nile
            /// </summary>
            public static EnumValues WhiteNile => EnumValues.WhiteNile;

            /// <summary>
            /// Red Sea
            /// </summary>
            public static EnumValues RedSea => EnumValues.RedSea;

            /// <summary>
            /// Sennar
            /// </summary>
            public static EnumValues Sennar => EnumValues.Sennar;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Sudan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Central Darfur
            /// </summary>
            [AliasInShort("DC")]
            [RegionCode(3_00_146_0001)]
            CentralDarfur,

            /// <summary>
            /// East Darfur
            /// </summary>
            [AliasInShort("DE")]
            [RegionCode(3_00_146_0002)]
            EastDarfur,

            /// <summary>
            /// North Darfur
            /// </summary>
            [AliasInShort("DN")]
            [RegionCode(3_00_146_0003)]
            NorthDarfur,

            /// <summary>
            /// South Darfur
            /// </summary>
            [AliasInShort("DS")]
            [RegionCode(3_00_146_0004)]
            SouthDarfur,

            /// <summary>
            /// West Darfur
            /// </summary>
            [AliasInShort("DW")]
            [RegionCode(3_00_146_0005)]
            WestDarfur,

            /// <summary>
            /// Al Qadarif
            /// </summary>
            [AliasInShort("GD")]
            [RegionCode(3_00_146_0006)]
            AlQadarif,

            /// <summary>
            /// West Kurdufan
            /// </summary>
            [AliasInShort("GK")]
            [RegionCode(3_00_146_0007)]
            WestKurdufan,

            /// <summary>
            /// Al Jazirah
            /// </summary>
            [AliasInShort("GZ")]
            [RegionCode(3_00_146_0008)]
            AlJazirah,

            /// <summary>
            /// Kassala
            /// </summary>
            [AliasInShort("KA")]
            [RegionCode(3_00_146_0009)]
            Kassala,

            /// <summary>
            /// Khartoum
            /// </summary>
            [AliasInShort("KH")]
            [RegionCode(3_00_146_0010)]
            Khartoum,

            /// <summary>
            /// North Kurdufan
            /// </summary>
            [AliasInShort("KN")]
            [RegionCode(3_00_146_0011)]
            NorthKurdufan,

            /// <summary>
            /// South Kurdufan
            /// </summary>
            [AliasInShort("KS")]
            [RegionCode(3_00_146_0012)]
            SouthKurdufan,

            /// <summary>
            /// Blue Nile
            /// </summary>
            [AliasInShort("NB")]
            [RegionCode(3_00_146_0013)]
            BlueNile,

            /// <summary>
            /// Northern
            /// </summary>
            [AliasInShort("NO")]
            [RegionCode(3_00_146_0014)]
            Northern,

            /// <summary>
            /// River Nile
            /// </summary>
            [AliasInShort("NR")]
            [RegionCode(3_00_146_0015)]
            RiverNile,

            /// <summary>
            /// White Nile
            /// </summary>
            [AliasInShort("NW")]
            [RegionCode(3_00_146_0016)]
            WhiteNile,

            /// <summary>
            /// Red Sea
            /// </summary>
            [AliasInShort("RS")]
            [RegionCode(3_00_146_0017)]
            RedSea,

            /// <summary>
            /// Sennar
            /// </summary>
            [AliasInShort("SI")]
            [RegionCode(3_00_146_0018)]
            Sennar,

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