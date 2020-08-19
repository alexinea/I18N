using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Dominican region
    /// </summary>
    public static partial class Dominican
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Cibao Nordeste
            /// </summary>
            public static EnumValues CibaoNordeste => EnumValues.CibaoNordeste;

            /// <summary>
            /// Cibao Noroeste
            /// </summary>
            public static EnumValues CibaoNoroeste => EnumValues.CibaoNoroeste;

            /// <summary>
            /// Cibao Norte
            /// </summary>
            public static EnumValues CibaoNorte => EnumValues.CibaoNorte;

            /// <summary>
            /// Cibao Sur
            /// </summary>
            public static EnumValues CibaoSur => EnumValues.CibaoSur;

            /// <summary>
            /// El Valle
            /// </summary>
            public static EnumValues ElValle => EnumValues.ElValle;

            /// <summary>
            /// Enriquillo
            /// </summary>
            public static EnumValues Enriquillo => EnumValues.Enriquillo;

            /// <summary>
            /// Higüamo
            /// </summary>
            public static EnumValues Higüamo => EnumValues.Higüamo;

            /// <summary>
            /// Ozama
            /// </summary>
            public static EnumValues Ozama => EnumValues.Ozama;

            /// <summary>
            /// Valdesia
            /// </summary>
            public static EnumValues Valdesia => EnumValues.Valdesia;

            /// <summary>
            /// Yuma
            /// </summary>
            public static EnumValues Yuma => EnumValues.Yuma;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Dominican regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Cibao Nordeste
            /// </summary>
            [AliasInShort("33")]
            [RegionCode(4_00_114_0033)]
            CibaoNordeste,

            /// <summary>
            /// Cibao Noroeste
            /// </summary>
            [AliasInShort("34")]
            [RegionCode(4_00_114_0034)]
            CibaoNoroeste,

            /// <summary>
            /// Cibao Norte
            /// </summary>
            [AliasInShort("35")]
            [RegionCode(4_00_114_0035)]
            CibaoNorte,

            /// <summary>
            /// Cibao Sur
            /// </summary>
            [AliasInShort("36")]
            [RegionCode(4_00_114_0036)]
            CibaoSur,

            /// <summary>
            /// El Valle
            /// </summary>
            [AliasInShort("37")]
            [RegionCode(4_00_114_0037)]
            ElValle,

            /// <summary>
            /// Enriquillo
            /// </summary>
            [AliasInShort("38")]
            [RegionCode(4_00_114_0038)]
            Enriquillo,

            /// <summary>
            /// Higüamo
            /// </summary>
            [AliasInShort("39")]
            [RegionCode(4_00_114_0039)]
            Higüamo,

            /// <summary>
            /// Ozama
            /// </summary>
            [AliasInShort("40")]
            [RegionCode(4_00_114_0040)]
            Ozama,

            /// <summary>
            /// Valdesia
            /// </summary>
            [AliasInShort("41")]
            [RegionCode(4_00_114_0041)]
            Valdesia,

            /// <summary>
            /// Yuma
            /// </summary>
            [AliasInShort("42")]
            [RegionCode(4_00_114_0042)]
            Yuma,

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