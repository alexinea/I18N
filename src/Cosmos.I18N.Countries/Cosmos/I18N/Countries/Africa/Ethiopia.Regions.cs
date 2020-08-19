using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Ethiopia regions
    /// </summary>
    public static partial  class Ethiopia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Addis Ababa
        /// </summary>
        public static EnumValues AddisAbaba => EnumValues.AddisAbaba;

        /// <summary>
        /// Afar
        /// </summary>
        public static EnumValues Afar => EnumValues.Afar;

        /// <summary>
        /// Amhara
        /// </summary>
        public static EnumValues Amhara => EnumValues.Amhara;

        /// <summary>
        /// Benishangul-Gumuz
        /// </summary>
        public static EnumValues BenishangulGumuz => EnumValues.BenishangulGumuz;

        /// <summary>
        /// Dire Dawa
        /// </summary>
        public static EnumValues DireDawa => EnumValues.DireDawa;

        /// <summary>
        /// Gambela
        /// </summary>
        public static EnumValues Gambela => EnumValues.Gambela;

        /// <summary>
        /// Harari
        /// </summary>
        public static EnumValues Harari => EnumValues.Harari;

        /// <summary>
        /// Oromia
        /// </summary>
        public static EnumValues Oromia => EnumValues.Oromia;

        /// <summary>
        /// Southern Nations, Nationalities, and Peoples
        /// </summary>
        public static EnumValues SouthernNationsAndNationalitiesAndPeoples => EnumValues.SouthernNationsAndNationalitiesAndPeoples;

        /// <summary>
        /// Somali
        /// </summary>
        public static EnumValues Somali => EnumValues.Somali;

        /// <summary>
        /// Tigray
        /// </summary>
        public static EnumValues Tigray => EnumValues.Tigray;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Ethiopia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Addis Ababa
            /// </summary>
            [AliasInShort("AA")][RegionCode(3_00_123_0001)] AddisAbaba,

            /// <summary>
            /// Afar
            /// </summary>
            [AliasInShort("AF")][RegionCode(3_00_123_0002)] Afar,

            /// <summary>
            /// Amhara
            /// </summary>
            [AliasInShort("AM")][RegionCode(3_00_123_0003)] Amhara,

            /// <summary>
            /// Benishangul-Gumuz
            /// </summary>
            [AliasInShort("BE")][RegionCode(3_00_123_0004)] BenishangulGumuz,

            /// <summary>
            /// Dire Dawa
            /// </summary>
            [AliasInShort("DD")][RegionCode(3_00_123_0005)] DireDawa,

            /// <summary>
            /// Gambela
            /// </summary>
            [AliasInShort("GA")] [RegionCode(3_00_123_0006)]Gambela,

            /// <summary>
            /// Harari
            /// </summary>
            [AliasInShort("HA")][RegionCode(3_00_123_0007)] Harari,

            /// <summary>
            /// Oromia
            /// </summary>
            [AliasInShort("OR")][RegionCode(3_00_123_0008)] Oromia,

            /// <summary>
            /// Southern Nations, Nationalities, and Peoples
            /// </summary>
            [AliasInShort("SN")][RegionCode(3_00_123_0009)] SouthernNationsAndNationalitiesAndPeoples,

            /// <summary>
            /// Somali
            /// </summary>
            [AliasInShort("SO")][RegionCode(3_00_123_0010)] Somali,

            /// <summary>
            /// Tigray
            /// </summary>
            [AliasInShort("TI")][RegionCode(3_00_123_0011)] Tigray,

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