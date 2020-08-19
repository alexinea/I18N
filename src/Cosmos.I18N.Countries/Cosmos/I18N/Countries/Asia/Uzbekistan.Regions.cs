using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Uzbekistan Regions
    /// </summary>
    public static partial class Uzbekistan
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Andijan
            /// </summary>
            public static EnumValues Andijan => EnumValues.Andijan;

            /// <summary>
            /// Bukhara
            /// </summary>
            public static EnumValues Bukhara => EnumValues.Bukhara;

            /// <summary>
            /// Fergana
            /// </summary>
            public static EnumValues Fergana => EnumValues.Fergana;

            /// <summary>
            /// Jizzakh
            /// </summary>
            public static EnumValues Jizzakh => EnumValues.Jizzakh;

            /// <summary>
            /// Namangan
            /// </summary>
            public static EnumValues Namangan => EnumValues.Namangan;

            /// <summary>
            /// Navoiy
            /// </summary>
            public static EnumValues Navoiy => EnumValues.Navoiy;

            /// <summary>
            /// Qashqadaryo
            /// </summary>
            public static EnumValues Qashqadaryo => EnumValues.Qashqadaryo;

            /// <summary>
            /// Karakalpakstan
            /// </summary>
            public static EnumValues Karakalpakstan => EnumValues.Karakalpakstan;

            /// <summary>
            /// Sirdaryo
            /// </summary>
            public static EnumValues Sirdaryo => EnumValues.Sirdaryo;

            /// <summary>
            /// Surxondaryo
            /// </summary>
            public static EnumValues Surxondaryo => EnumValues.Surxondaryo;

            /// <summary>
            /// Tashkent
            /// </summary>
            public static EnumValues Tashkent => EnumValues.Tashkent;

            /// <summary>
            /// Tashkent Province
            /// </summary>
            public static EnumValues TashkentProvince => EnumValues.TashkentProvince;

            /// <summary>
            /// Xorazm
            /// </summary>
            public static EnumValues Xorazm => EnumValues.Xorazm;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Uzbekistan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Andijan
            /// </summary>
            [AliasInShort("AN")]
            [RegionCode(1_00_141_0001)]
            Andijan,

            /// <summary>
            /// Bukhara
            /// </summary>
            [AliasInShort("BU")]
            [RegionCode(1_00_141_0002)]
            Bukhara,

            /// <summary>
            /// Fergana
            /// </summary>
            [AliasInShort("FA")]
            [RegionCode(1_00_141_0003)]
            Fergana,

            /// <summary>
            /// Jizzakh
            /// </summary>
            [AliasInShort("JI")]
            [RegionCode(1_00_141_0004)]
            Jizzakh,

            /// <summary>
            /// Namangan
            /// </summary>
            [AliasInShort("NG")]
            [RegionCode(1_00_141_0005)]
            Namangan,

            /// <summary>
            /// Navoiy
            /// </summary>
            [AliasInShort("NW")]
            [RegionCode(1_00_141_0006)]
            Navoiy,

            /// <summary>
            /// Qashqadaryo
            /// </summary>
            [AliasInShort("QA")]
            [RegionCode(1_00_141_0007)]
            Qashqadaryo,

            /// <summary>
            /// Karakalpakstan
            /// </summary>
            [AliasInShort("QR")]
            [RegionCode(1_00_141_0008)]
            Karakalpakstan,

            /// <summary>
            /// Sirdaryo
            /// </summary>
            [AliasInShort("SI")]
            [RegionCode(1_00_141_0009)]
            Sirdaryo,

            /// <summary>
            /// Surxondaryo
            /// </summary>
            [AliasInShort("SU")]
            [RegionCode(1_00_141_0010)]
            Surxondaryo,

            /// <summary>
            /// Tashkent
            /// </summary>
            [AliasInShort("TK")]
            [RegionCode(1_00_141_0011)]
            Tashkent,

            /// <summary>
            /// Tashkent Province
            /// </summary>
            [AliasInShort("TO")]
            [RegionCode(1_00_141_0012)]
            TashkentProvince,

            /// <summary>
            /// Xorazm
            /// </summary>
            [AliasInShort("XO")]
            [RegionCode(1_00_141_0013)]
            Xorazm,

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