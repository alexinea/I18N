using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Senegal regons
    /// </summary>
    public static partial class Senegal
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Diourbel
        /// </summary>
        public static EnumValues Diourbel => EnumValues.Diourbel;

        /// <summary>
        /// Dakar
        /// </summary>
        public static EnumValues Dakar => EnumValues.Dakar;

        /// <summary>
        /// Fatick
        /// </summary>
        public static EnumValues Fatick => EnumValues.Fatick;

        /// <summary>
        /// Kaffrine
        /// </summary>
        public static EnumValues Kaffrine => EnumValues.Kaffrine;

        /// <summary>
        /// Kolda
        /// </summary>
        public static EnumValues Kolda => EnumValues.Kolda;

        /// <summary>
        /// Kédougou
        /// </summary>
        public static EnumValues Kédougou => EnumValues.Kédougou;

        /// <summary>
        /// Kaolack
        /// </summary>
        public static EnumValues Kaolack => EnumValues.Kaolack;

        /// <summary>
        /// Louga
        /// </summary>
        public static EnumValues Louga => EnumValues.Louga;

        /// <summary>
        /// Matam
        /// </summary>
        public static EnumValues Matam => EnumValues.Matam;

        /// <summary>
        /// Sédhiou
        /// </summary>
        public static EnumValues Sédhiou => EnumValues.Sédhiou;

        /// <summary>
        /// Saint-Louis
        /// </summary>
        public static EnumValues SaintLouis => EnumValues.SaintLouis;

        /// <summary>
        /// Tambacounda
        /// </summary>
        public static EnumValues Tambacounda => EnumValues.Tambacounda;

        /// <summary>
        /// Thiès
        /// </summary>
        public static EnumValues Thiès => EnumValues.Thiès;

        /// <summary>
        /// Ziguinchor
        /// </summary>
        public static EnumValues Ziguinchor => EnumValues.Ziguinchor;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Senegal regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Diourbel
            /// </summary>
            [AliasInShort("DB")][RegionCode(3_00_151_0001)] Diourbel,

            /// <summary>
            /// Dakar
            /// </summary>
            [AliasInShort("DK")][RegionCode(3_00_151_0002)] Dakar,

            /// <summary>
            /// Fatick
            /// </summary>
            [AliasInShort("FK")][RegionCode(3_00_151_0003)] Fatick,

            /// <summary>
            /// Kaffrine
            /// </summary>
            [AliasInShort("KA")][RegionCode(3_00_151_0004)] Kaffrine,

            /// <summary>
            /// Kolda
            /// </summary>
            [AliasInShort("KD")][RegionCode(3_00_151_0005)] Kolda,

            /// <summary>
            /// Kédougou
            /// </summary>
            [AliasInShort("KE")][RegionCode(3_00_151_0006)] Kédougou,

            /// <summary>
            /// Kaolack
            /// </summary>
            [AliasInShort("KL")][RegionCode(3_00_151_0007)] Kaolack,

            /// <summary>
            /// Louga
            /// </summary>
            [AliasInShort("LG")][RegionCode(3_00_151_0008)] Louga,

            /// <summary>
            /// Matam
            /// </summary>
            [AliasInShort("ML")][RegionCode(3_00_151_0009)] Matam,

            /// <summary>
            /// Sédhiou
            /// </summary>
            [AliasInShort("SE")][RegionCode(3_00_151_0010)] Sédhiou,

            /// <summary>
            /// Saint-Louis
            /// </summary>
            [AliasInShort("SL")][RegionCode(3_00_151_0011)] SaintLouis,

            /// <summary>
            /// Tambacounda
            /// </summary>
            [AliasInShort("TC")][RegionCode(3_00_151_0012)] Tambacounda,

            /// <summary>
            /// Thiès
            /// </summary>
            [AliasInShort("TH")][RegionCode(3_00_151_0013)] Thiès,

            /// <summary>
            /// Ziguinchor
            /// </summary>
            [AliasInShort("ZG")][RegionCode(3_00_151_0014)] Ziguinchor,

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