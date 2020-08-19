using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// NewZealand Regions
    /// </summary>
    public static partial class NewZealand
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Auckland Province
            /// </summary>
            public static EnumValues AucklandProvince => EnumValues.AucklandProvince;

            /// <summary>
            /// Canterbury
            /// </summary>
            public static EnumValues Canterbury => EnumValues.Canterbury;

            /// <summary>
            /// Chatham Islands
            /// </summary>
            public static EnumValues ChathamIslands => EnumValues.ChathamIslands;

            /// <summary>
            /// Hawke's Bay
            /// </summary>
            public static EnumValues HawkesBay => EnumValues.HawkesBay;

            /// <summary>
            /// Marlborough
            /// </summary>
            public static EnumValues Marlborough => EnumValues.Marlborough;

            /// <summary>
            /// Nelson
            /// </summary>
            public static EnumValues Nelson => EnumValues.Nelson;

            /// <summary>
            /// Northland
            /// </summary>
            public static EnumValues Northland => EnumValues.Northland;

            /// <summary>
            /// Otago Province
            /// </summary>
            public static EnumValues OtagoProvince => EnumValues.OtagoProvince;

            /// <summary>
            /// Southland
            /// </summary>
            public static EnumValues Southland => EnumValues.Southland;

            /// <summary>
            /// Taranaki
            /// </summary>
            public static EnumValues Taranaki => EnumValues.Taranaki;

            /// <summary>
            /// Wellington Province
            /// </summary>
            public static EnumValues WellingtonProvince => EnumValues.WellingtonProvince;

            /// <summary>
            /// Westland
            /// </summary>
            public static EnumValues Westland => EnumValues.Westland;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for NewZealand regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Auckland Province
            /// </summary>
            [AliasInShort("AUK")]
            [RegionCode(6_00_012_0001)]
            AucklandProvince,

            /// <summary>
            /// Canterbury
            /// </summary>
            [AliasInShort("CAN")]
            [RegionCode(6_00_012_0002)]
            Canterbury,

            /// <summary>
            /// Chatham Islands
            /// </summary>
            [AliasInShort("CIT")]
            [RegionCode(6_00_012_0003)]
            ChathamIslands,

            /// <summary>
            /// Hawke's Bay
            /// </summary>
            [AliasInShort("HKB")]
            [RegionCode(6_00_012_0004)]
            HawkesBay,

            /// <summary>
            /// Marlborough
            /// </summary>
            [AliasInShort("MBH")]
            [RegionCode(6_00_012_0005)]
            Marlborough,

            /// <summary>
            /// Nelson
            /// </summary>
            [AliasInShort("NSN")]
            [RegionCode(6_00_012_00026)]
            Nelson,

            /// <summary>
            /// Northland
            /// </summary>
            [AliasInShort("NTL")]
            [RegionCode(6_00_012_0007)]
            Northland,

            /// <summary>
            /// Otago Province
            /// </summary>
            [AliasInShort("OTA")]
            [RegionCode(6_00_012_0008)]
            OtagoProvince,

            /// <summary>
            /// Southland
            /// </summary>
            [AliasInShort("STL")]
            [RegionCode(6_00_012_0009)]
            Southland,

            /// <summary>
            /// Taranaki
            /// </summary>
            [AliasInShort("TKI")]
            [RegionCode(6_00_012_0010)]
            Taranaki,

            /// <summary>
            /// Wellington Province
            /// </summary>
            [AliasInShort("WGN")]
            [RegionCode(6_00_012_0011)]
            WellingtonProvince,

            /// <summary>
            /// Westland
            /// </summary>
            [AliasInShort("WTC")]
            [RegionCode(6_00_012_0012)]
            Westland,

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