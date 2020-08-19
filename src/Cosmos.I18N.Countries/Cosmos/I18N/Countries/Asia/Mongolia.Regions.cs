using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Mongolia Regions
    /// </summary>
    public static partial class Mongolia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Ulaanbaatar
            /// </summary>
            public static EnumValues Ulaanbaatar => EnumValues.Ulaanbaatar;

            /// <summary>
            /// Orkhon
            /// </summary>
            public static EnumValues Orkhon => EnumValues.Orkhon;

            /// <summary>
            /// Darkhan-Uul
            /// </summary>
            public static EnumValues DarkhanUul => EnumValues.DarkhanUul;

            /// <summary>
            /// Khentii
            /// </summary>
            public static EnumValues Khentii => EnumValues.Khentii;

            /// <summary>
            /// Khövsgöl
            /// </summary>
            public static EnumValues Khövsgöl => EnumValues.Khövsgöl;

            /// <summary>
            /// Khovd
            /// </summary>
            public static EnumValues Khovd => EnumValues.Khovd;

            /// <summary>
            /// Uvs
            /// </summary>
            public static EnumValues Uvs => EnumValues.Uvs;

            /// <summary>
            /// Töv
            /// </summary>
            public static EnumValues Töv => EnumValues.Töv;

            /// <summary>
            /// Selenge
            /// </summary>
            public static EnumValues Selenge => EnumValues.Selenge;

            /// <summary>
            /// Loja
            /// </summary>
            public static EnumValues Sükhbaatar => EnumValues.Sükhbaatar;

            /// <summary>
            /// Ömnögovi
            /// </summary>
            public static EnumValues Ömnögovi => EnumValues.Ömnögovi;

            /// <summary>
            /// Övörkhangai
            /// </summary>
            public static EnumValues Övörkhangai => EnumValues.Övörkhangai;

            /// <summary>
            /// Zavkhan
            /// </summary>
            public static EnumValues Zavkhan => EnumValues.Zavkhan;

            /// <summary>
            /// Dundgovi
            /// </summary>
            public static EnumValues Dundgovi => EnumValues.Dundgovi;

            /// <summary>
            /// Dornod
            /// </summary>
            public static EnumValues Dornod => EnumValues.Dornod;

            /// <summary>
            /// Dornogovi
            /// </summary>
            public static EnumValues Dornogovi => EnumValues.Dornogovi;

            /// <summary>
            /// Govisümber
            /// </summary>
            public static EnumValues Govisümber => EnumValues.Govisümber;

            /// <summary>
            /// Govi-Altai
            /// </summary>
            public static EnumValues GoviAltai => EnumValues.GoviAltai;

            /// <summary>
            /// Bulgan
            /// </summary>
            public static EnumValues Bulgan => EnumValues.Bulgan;

            /// <summary>
            /// Bayankhongor
            /// </summary>
            public static EnumValues Bayankhongor => EnumValues.Bayankhongor;

            /// <summary>
            /// Bayan-Ölgii
            /// </summary>
            public static EnumValues BayanÖlgii => EnumValues.BayanÖlgii;

            /// <summary>
            /// Arkhangai
            /// </summary>
            public static EnumValues Arkhangai => EnumValues.Arkhangai;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Mongolia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ulaanbaatar
            /// </summary>
            [AliasInShort("1")]
            [RegionCode(1_00_126_0001)]
            Ulaanbaatar,

            /// <summary>
            /// Orkhon
            /// </summary>
            [AliasInShort("035")]
            [RegionCode(1_00_126_0035)]
            Orkhon,

            /// <summary>
            /// Darkhan-Uul
            /// </summary>
            [AliasInShort("037")]
            [RegionCode(1_00_126_0037)]
            DarkhanUul,

            /// <summary>
            /// Khentii
            /// </summary>
            [AliasInShort("039")]
            [RegionCode(1_00_126_0039)]
            Khentii,

            /// <summary>
            /// Khövsgöl
            /// </summary>
            [AliasInShort("041")]
            [RegionCode(1_00_126_0041)]
            Khövsgöl,

            /// <summary>
            /// Khovd
            /// </summary>
            [AliasInShort("043")]
            [RegionCode(1_00_126_0043)]
            Khovd,

            /// <summary>
            /// Uvs
            /// </summary>
            [AliasInShort("046")]
            [RegionCode(1_00_126_0046)]
            Uvs,

            /// <summary>
            /// Töv
            /// </summary>
            [AliasInShort("047")]
            [RegionCode(1_00_126_0047)]
            Töv,

            /// <summary>
            /// Selenge
            /// </summary>
            [AliasInShort("049")]
            [RegionCode(1_00_126_0049)]
            Selenge,

            /// <summary>
            /// Sükhbaatar
            /// </summary>
            [AliasInShort("051")]
            [RegionCode(1_00_126_0051)]
            Sükhbaatar,

            /// <summary>
            /// Ömnögovi
            /// </summary>
            [AliasInShort("053")]
            [RegionCode(1_00_126_0053)]
            Ömnögovi,

            /// <summary>
            /// Övörkhangai
            /// </summary>
            [AliasInShort("055")]
            [RegionCode(1_00_126_0055)]
            Övörkhangai,

            /// <summary>
            /// Zavkhan
            /// </summary>
            [AliasInShort("057")]
            [RegionCode(1_00_126_0057)]
            Zavkhan,

            /// <summary>
            /// Dundgovi
            /// </summary>
            [AliasInShort("059")]
            [RegionCode(1_00_126_0059)]
            Dundgovi,

            /// <summary>
            /// Dornod
            /// </summary>
            [AliasInShort("061")]
            [RegionCode(1_00_126_0061)]
            Dornod,

            /// <summary>
            /// Dornogovi
            /// </summary>
            [AliasInShort("063")]
            [RegionCode(1_00_126_0063)]
            Dornogovi,

            /// <summary>
            /// Govisümber
            /// </summary>
            [AliasInShort("064")]
            [RegionCode(1_00_126_0064)]
            Govisümber,

            /// <summary>
            /// Govi-Altai
            /// </summary>
            [AliasInShort("065")]
            [RegionCode(1_00_126_0065)]
            GoviAltai,

            /// <summary>
            /// Bulgan
            /// </summary>
            [AliasInShort("067")]
            [RegionCode(1_00_126_0067)]
            Bulgan,

            /// <summary>
            /// Bayankhongor
            /// </summary>
            [AliasInShort("069")]
            [RegionCode(1_00_126_0069)]
            Bayankhongor,

            /// <summary>
            /// Bayan-Ölgii
            /// </summary>
            [AliasInShort("071")]
            [RegionCode(1_00_126_0071)]
            BayanÖlgii,

            /// <summary>
            /// Arkhangai
            /// </summary>
            [AliasInShort("073")]
            [RegionCode(1_00_126_0073)]
            Arkhangai,

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