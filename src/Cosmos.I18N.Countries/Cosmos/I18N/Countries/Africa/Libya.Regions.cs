using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Libya Regions
    /// </summary>
    public static partial  class Libya
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Benghazi
        /// </summary>
        public static EnumValues Benghazi => EnumValues.Benghazi;

        /// <summary>
        /// Butnan
        /// </summary>
        public static EnumValues Butnan => EnumValues.Butnan;

        /// <summary>
        /// Derna
        /// </summary>
        public static EnumValues Derna => EnumValues.Derna;

        /// <summary>
        /// Ghat
        /// </summary>
        public static EnumValues Ghat => EnumValues.Ghat;

        /// <summary>
        /// Jabal al Akhdar
        /// </summary>
        public static EnumValues JabalAlAkhdar => EnumValues.JabalAlAkhdar;

        /// <summary>
        /// Jabal al Gharbi
        /// </summary>
        public static EnumValues JabalAlGharbi => EnumValues.JabalAlGharbi;

        /// <summary>
        /// Jafara
        /// </summary>
        public static EnumValues Jafara => EnumValues.Jafara;

        /// <summary>
        /// Jufra
        /// </summary>
        public static EnumValues Jufra => EnumValues.Jufra;

        /// <summary>
        /// Kufra
        /// </summary>
        public static EnumValues Kufra => EnumValues.Kufra;

        /// <summary>
        /// Murqub
        /// </summary>
        public static EnumValues Murqub => EnumValues.Murqub;

        /// <summary>
        /// Misrata
        /// </summary>
        public static EnumValues Misrata => EnumValues.Misrata;

        /// <summary>
        /// Marj
        /// </summary>
        public static EnumValues Marj => EnumValues.Marj;

        /// <summary>
        /// Murzuq
        /// </summary>
        public static EnumValues Murzuq => EnumValues.Murzuq;

        /// <summary>
        /// Nalut
        /// </summary>
        public static EnumValues Nalut => EnumValues.Nalut;

        /// <summary>
        /// Nuqat al Khams
        /// </summary>
        public static EnumValues NuqatAlKhams => EnumValues.NuqatAlKhams;

        /// <summary>
        /// Sabha
        /// </summary>
        public static EnumValues Sabha => EnumValues.Sabha;

        /// <summary>
        /// Sirte
        /// </summary>
        public static EnumValues Sirte => EnumValues.Sirte;

        /// <summary>
        /// Tripoli
        /// </summary>
        public static EnumValues Tripoli => EnumValues.Tripoli;

        /// <summary>
        /// Al Wahat
        /// </summary>
        public static EnumValues AlWahat => EnumValues.AlWahat;

        /// <summary>
        /// Wadi al Hayaa
        /// </summary>
        public static EnumValues WadiAlHayaa => EnumValues.WadiAlHayaa;

        /// <summary>
        /// Wadi al Shatii
        /// </summary>
        public static EnumValues WadiAlShatii => EnumValues.WadiAlShatii;

        /// <summary>
        /// Zawiya
        /// </summary>
        public static EnumValues Zawiya => EnumValues.Zawiya;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Libya regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Benghazi
            /// </summary>
            [AliasInShort("BA")][RegionCode(3_00_133_0001)] Benghazi,

            /// <summary>
            /// Butnan
            /// </summary>
            [AliasInShort("BU")][RegionCode(3_00_133_0002)] Butnan,

            /// <summary>
            /// Derna
            /// </summary>
            [AliasInShort("DR")][RegionCode(3_00_133_0003)] Derna,

            /// <summary>
            /// Ghat
            /// </summary>
            [AliasInShort("GT")][RegionCode(3_00_133_0004)] Ghat,

            /// <summary>
            /// Jabal al Akhdar
            /// </summary>
            [AliasInShort("JA")][RegionCode(3_00_133_0005)] JabalAlAkhdar,

            /// <summary>
            /// Jabal al Gharbi
            /// </summary>
            [AliasInShort("JG")][RegionCode(3_00_133_0006)] JabalAlGharbi,

            /// <summary>
            /// Jafara
            /// </summary>
            [AliasInShort("JI")][RegionCode(3_00_133_0007)] Jafara,

            /// <summary>
            /// Jufra
            /// </summary>
            [AliasInShort("JU")][RegionCode(3_00_133_0008)] Jufra,

            /// <summary>
            /// Kufra
            /// </summary>
            [AliasInShort("KF")][RegionCode(3_00_133_0009)] Kufra,

            /// <summary>
            /// Murqub
            /// </summary>
            [AliasInShort("MB")][RegionCode(3_00_133_0010)] Murqub,

            /// <summary>
            /// Misrata
            /// </summary>
            [AliasInShort("MI")][RegionCode(3_00_133_0011)] Misrata,

            /// <summary>
            /// Marj
            /// </summary>
            [AliasInShort("MJ")][RegionCode(3_00_133_0012)] Marj,

            /// <summary>
            /// Murzuq
            /// </summary>
            [AliasInShort("MQ")][RegionCode(3_00_133_0013)] Murzuq,

            /// <summary>
            /// Nalut
            /// </summary>
            [AliasInShort("NL")][RegionCode(3_00_133_0014)] Nalut,

            /// <summary>
            /// Nuqat al Khams
            /// </summary>
            [AliasInShort("NQ")][RegionCode(3_00_133_0015)] NuqatAlKhams,

            /// <summary>
            /// Sabha
            /// </summary>
            [AliasInShort("SB")][RegionCode(3_00_133_0016)] Sabha,

            /// <summary>
            /// Sirte
            /// </summary>
            [AliasInShort("SR")][RegionCode(3_00_133_0017)] Sirte,

            /// <summary>
            /// Tripoli
            /// </summary>
            [AliasInShort("TB")][RegionCode(3_00_133_0018)] Tripoli,

            /// <summary>
            /// Al Wahat
            /// </summary>
            [AliasInShort("WA")][RegionCode(3_00_133_0019)] AlWahat,

            /// <summary>
            /// Wadi al Hayaa
            /// </summary>
            [AliasInShort("WD")][RegionCode(3_00_133_0020)] WadiAlHayaa,

            /// <summary>
            /// Wadi al Shatii
            /// </summary>
            [AliasInShort("WS")][RegionCode(3_00_133_0021)] WadiAlShatii,

            /// <summary>
            /// Zawiya
            /// </summary>
            [AliasInShort("ZA")][RegionCode(3_00_133_0022)] Zawiya,

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