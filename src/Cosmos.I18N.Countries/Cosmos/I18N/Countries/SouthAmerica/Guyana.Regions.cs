using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// Guyana Regions
    /// </summary>
    public static partial class Guyana
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Barima-Waini
            /// </summary>
            public static EnumValues BarimaWaini => EnumValues.BarimaWaini;

            /// <summary>
            /// Cuyuni-Mazaruni
            /// </summary>
            public static EnumValues CuyuniMazaruni => EnumValues.CuyuniMazaruni;

            /// <summary>
            /// Demerara-Mahaica
            /// </summary>
            public static EnumValues DemeraraMahaica => EnumValues.DemeraraMahaica;

            /// <summary>
            /// East Berbice-Corentyne
            /// </summary>
            public static EnumValues EastBerbiceCorentyne => EnumValues.EastBerbiceCorentyne;

            /// <summary>
            /// Essequibo Islands-West Demerara
            /// </summary>
            public static EnumValues EssequiboIslandsWestDemerara => EnumValues.EssequiboIslandsWestDemerara;

            /// <summary>
            /// Mahaica-Berbice
            /// </summary>
            public static EnumValues MahaicaBerbice => EnumValues.MahaicaBerbice;

            /// <summary>
            /// Pomeroon-Supenaam
            /// </summary>
            public static EnumValues PomeroonSupenaam => EnumValues.PomeroonSupenaam;

            /// <summary>
            /// Potaro-Siparuni
            /// </summary>
            public static EnumValues PotaroSiparuni => EnumValues.PotaroSiparuni;

            /// <summary>
            /// Upper Demerara-Berbice
            /// </summary>
            public static EnumValues UpperDemeraraBerbice => EnumValues.UpperDemeraraBerbice;

            /// <summary>
            /// Upper Takutu-Upper Essequibo
            /// </summary>
            public static EnumValues UpperTakutuUpperEssequibo => EnumValues.UpperTakutuUpperEssequibo;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Guyana regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Barima-Waini
            /// </summary>
            [AliasInShort("BA")]
            [RegionCode(5_00_106_0001)]
            BarimaWaini,

            /// <summary>
            /// Cuyuni-Mazaruni
            /// </summary>
            [AliasInShort("CU")]
            [RegionCode(5_00_106_0002)]
            CuyuniMazaruni,

            /// <summary>
            /// Demerara-Mahaica
            /// </summary>
            [AliasInShort("DE")]
            [RegionCode(5_00_106_0003)]
            DemeraraMahaica,

            /// <summary>
            /// East Berbice-Corentyne
            /// </summary>
            [AliasInShort("EB")]
            [RegionCode(5_00_106_0004)]
            EastBerbiceCorentyne,

            /// <summary>
            /// Essequibo Islands-West Demerara
            /// </summary>
            [AliasInShort("ES")]
            [RegionCode(5_00_106_0005)]
            EssequiboIslandsWestDemerara,

            /// <summary>
            /// Mahaica-Berbice
            /// </summary>
            [AliasInShort("MA")]
            [RegionCode(5_00_106_0006)]
            MahaicaBerbice,

            /// <summary>
            /// Pomeroon-Supenaam
            /// </summary>
            [AliasInShort("PM")]
            [RegionCode(5_00_106_0007)]
            PomeroonSupenaam,

            /// <summary>
            /// Potaro-Siparuni
            /// </summary>
            [AliasInShort("PT")]
            [RegionCode(5_00_106_0008)]
            PotaroSiparuni,

            /// <summary>
            /// Upper Demerara-Berbice
            /// </summary>
            [AliasInShort("UD")]
            [RegionCode(5_00_106_0009)]
            UpperDemeraraBerbice,

            /// <summary>
            /// Upper Takutu-Upper Essequibo
            /// </summary>
            [AliasInShort("UT")]
            [RegionCode(5_00_106_0010)]
            UpperTakutuUpperEssequibo,

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