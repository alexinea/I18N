using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Bhutan regions
    /// </summary>
    public static partial class Bhutan
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Paro
            /// </summary>
            public static EnumValues Paro => EnumValues.Paro;

            /// <summary>
            /// Chukha
            /// </summary>
            public static EnumValues Chukha => EnumValues.Chukha;

            /// <summary>
            /// Haa
            /// </summary>
            public static EnumValues Haa => EnumValues.Haa;

            /// <summary>
            /// Samtse
            /// </summary>
            public static EnumValues Samtse => EnumValues.Samtse;

            /// <summary>
            /// Thimphu
            /// </summary>
            public static EnumValues Thimphu => EnumValues.Thimphu;

            /// <summary>
            /// Tsirang
            /// </summary>
            public static EnumValues Tsirang => EnumValues.Tsirang;

            /// <summary>
            /// Dagana
            /// </summary>
            public static EnumValues Dagana => EnumValues.Dagana;

            /// <summary>
            /// Punakha
            /// </summary>
            public static EnumValues Punakha => EnumValues.Punakha;

            /// <summary>
            /// Wangdue Phodrang
            /// </summary>
            public static EnumValues WangduePhodrang => EnumValues.WangduePhodrang;

            /// <summary>
            /// Sarpang
            /// </summary>
            public static EnumValues Sarpang => EnumValues.Sarpang;

            /// <summary>
            /// Trongsa
            /// </summary>
            public static EnumValues Trongsa => EnumValues.Trongsa;

            /// <summary>
            /// Bumthang
            /// </summary>
            public static EnumValues Bumthang => EnumValues.Bumthang;

            /// <summary>
            /// Zhemgang
            /// </summary>
            public static EnumValues Zhemgang => EnumValues.Zhemgang;

            /// <summary>
            /// Trashigang
            /// </summary>
            public static EnumValues Trashigang => EnumValues.Trashigang;

            /// <summary>
            /// Mongar
            /// </summary>
            public static EnumValues Mongar => EnumValues.Mongar;

            /// <summary>
            /// Pemagatshel
            /// </summary>
            public static EnumValues Pemagatshel => EnumValues.Pemagatshel;

            /// <summary>
            /// Lhuntse
            /// </summary>
            public static EnumValues Lhuntse => EnumValues.Lhuntse;

            /// <summary>
            /// Samdrup Jongkhar
            /// </summary>
            public static EnumValues SamdrupJongkhar => EnumValues.SamdrupJongkhar;

            /// <summary>
            /// Gasa
            /// </summary>
            public static EnumValues Gasa => EnumValues.Gasa;

            /// <summary>
            /// Trashiyangtse
            /// </summary>
            public static EnumValues Trashiyangtse => EnumValues.Trashiyangtse;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Bhutan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Paro
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(1_00_106_0011)]
            Paro,

            /// <summary>
            /// Chukha
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(1_00_106_0012)]
            Chukha,

            /// <summary>
            /// Haa
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(1_00_106_0013)]
            Haa,

            /// <summary>
            /// Samtse
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(1_00_106_0014)]
            Samtse,

            /// <summary>
            /// Thimphu
            /// </summary>
            [AliasInShort("15")]
            [RegionCode(1_00_106_0015)]
            Thimphu,

            /// <summary>
            /// Tsirang
            /// </summary>
            [AliasInShort("21")]
            [RegionCode(1_00_106_0021)]
            Tsirang,

            /// <summary>
            /// Dagana
            /// </summary>
            [AliasInShort("22")]
            [RegionCode(1_00_106_0022)]
            Dagana,

            /// <summary>
            /// Punakha
            /// </summary>
            [AliasInShort("23")]
            [RegionCode(1_00_106_0023)]
            Punakha,

            /// <summary>
            /// Wangdue Phodrang
            /// </summary>
            [AliasInShort("24")]
            [RegionCode(1_00_106_0024)]
            WangduePhodrang,

            /// <summary>
            /// Sarpang
            /// </summary>
            [AliasInShort("31")]
            [RegionCode(1_00_106_0031)]
            Sarpang,

            /// <summary>
            /// Trongsa
            /// </summary>
            [AliasInShort("32")]
            [RegionCode(1_00_106_0032)]
            Trongsa,

            /// <summary>
            /// Bumthang
            /// </summary>
            [AliasInShort("33")]
            [RegionCode(1_00_106_0033)]
            Bumthang,

            /// <summary>
            /// Zhemgang
            /// </summary>
            [AliasInShort("34")]
            [RegionCode(1_00_106_0034)]
            Zhemgang,

            /// <summary>
            /// Trashigang
            /// </summary>
            [AliasInShort("41")]
            [RegionCode(1_00_106_0041)]
            Trashigang,

            /// <summary>
            /// Mongar
            /// </summary>
            [AliasInShort("42")]
            [RegionCode(1_00_106_0042)]
            Mongar,

            /// <summary>
            /// Pemagatshel
            /// </summary>
            [AliasInShort("43")]
            [RegionCode(1_00_106_0043)]
            Pemagatshel,

            /// <summary>
            /// Lhuntse
            /// </summary>
            [AliasInShort("44")]
            [RegionCode(1_00_106_0044)]
            Lhuntse,

            /// <summary>
            /// Samdrup Jongkhar
            /// </summary>
            [AliasInShort("45")]
            [RegionCode(1_00_106_0045)]
            SamdrupJongkhar,

            /// <summary>
            /// Gasa
            /// </summary>
            [AliasInShort("GA")]
            [RegionCode(1_00_106_0101)]
            Gasa,

            /// <summary>
            /// Trashiyangtse
            /// </summary>
            [AliasInShort("TY")]
            [RegionCode(1_00_106_0102)]
            Trashiyangtse,

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