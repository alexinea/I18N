using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Jordan Regions
    /// </summary>
    public static partial class Jordan
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Ajloun
            /// </summary>
            public static EnumValues Ajloun => EnumValues.Ajloun;

            /// <summary>
            /// Amman
            /// </summary>
            public static EnumValues Amman => EnumValues.Amman;

            /// <summary>
            /// Aqaba
            /// </summary>
            public static EnumValues Aqaba => EnumValues.Aqaba;

            /// <summary>
            /// Tafilah
            /// </summary>
            public static EnumValues Tafilah => EnumValues.Tafilah;

            /// <summary>
            /// Zarqa
            /// </summary>
            public static EnumValues Zarqa => EnumValues.Zarqa;

            /// <summary>
            /// Balqa
            /// </summary>
            public static EnumValues Balqa => EnumValues.Balqa;

            /// <summary>
            /// Irbid
            /// </summary>
            public static EnumValues Irbid => EnumValues.Irbid;

            /// <summary>
            /// Jerash
            /// </summary>
            public static EnumValues Jerash => EnumValues.Jerash;

            /// <summary>
            /// Karak
            /// </summary>
            public static EnumValues Karak => EnumValues.Karak;

            /// <summary>
            /// Mafraq
            /// </summary>
            public static EnumValues Mafraq => EnumValues.Mafraq;

            /// <summary>
            /// Madaba
            /// </summary>
            public static EnumValues Madaba => EnumValues.Madaba;

            /// <summary>
            /// Ma’an
            /// </summary>
            public static EnumValues Maan => EnumValues.Maan;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Jordan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ajloun
            /// </summary>
            [AliasInShort("AJ")]
            [RegionCode(1_00_118_0001)]
            Ajloun,

            /// <summary>
            /// Amman
            /// </summary>
            [AliasInShort("AM")]
            [RegionCode(1_00_118_0002)]
            Amman,

            /// <summary>
            /// Aqaba
            /// </summary>
            [AliasInShort("AQ")]
            [RegionCode(1_00_118_0003)]
            Aqaba,

            /// <summary>
            /// Tafilah
            /// </summary>
            [AliasInShort("AT")]
            [RegionCode(1_00_118_0004)]
            Tafilah,

            /// <summary>
            /// Zarqa
            /// </summary>
            [AliasInShort("AZ")]
            [RegionCode(1_00_118_0005)]
            Zarqa,

            /// <summary>
            /// Balqa
            /// </summary>
            [AliasInShort("BA")]
            [RegionCode(1_00_118_0006)]
            Balqa,

            /// <summary>
            /// Irbid
            /// </summary>
            [AliasInShort("IR")]
            [RegionCode(1_00_118_0007)]
            Irbid,

            /// <summary>
            /// Jerash
            /// </summary>
            [AliasInShort("JA")]
            [RegionCode(1_00_118_0008)]
            Jerash,

            /// <summary>
            /// Karak
            /// </summary>
            [AliasInShort("KA")]
            [RegionCode(1_00_118_0009)]
            Karak,

            /// <summary>
            /// Mafraq
            /// </summary>
            [AliasInShort("MA")]
            [RegionCode(1_00_118_0010)]
            Mafraq,

            /// <summary>
            /// Madaba
            /// </summary>
            [AliasInShort("MD")]
            [RegionCode(1_00_118_0011)]
            Madaba,

            /// <summary>
            /// Ma’an
            /// </summary>
            [AliasInShort("MN")]
            [RegionCode(1_00_118_0012)]
            Maan,

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