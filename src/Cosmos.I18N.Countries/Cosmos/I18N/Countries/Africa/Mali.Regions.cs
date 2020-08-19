using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Mali Regions
    /// </summary>
    public static partial  class Mali
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Kayes
        /// </summary>
        public static EnumValues Kayes => EnumValues.Kayes;

        /// <summary>
        /// Koulikoro
        /// </summary>
        public static EnumValues Koulikoro => EnumValues.Koulikoro;

        /// <summary>
        /// Sikasso
        /// </summary>
        public static EnumValues Sikasso => EnumValues.Sikasso;

        /// <summary>
        /// Ségou
        /// </summary>
        public static EnumValues Ségou => EnumValues.Ségou;

        /// <summary>
        /// Tombouctou
        /// </summary>
        public static EnumValues Tombouctou => EnumValues.Tombouctou;

        /// <summary>
        /// Gao
        /// </summary>
        public static EnumValues Gao => EnumValues.Gao;

        /// <summary>
        /// Kidal
        /// </summary>
        public static EnumValues Kidal => EnumValues.Kidal;

        /// <summary>
        /// Bamako
        /// </summary>
        public static EnumValues Bamako => EnumValues.Bamako;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Mali regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Kayes
            /// </summary>
            [AliasInShort("1")][RegionCode(3_00_122_0001)] Kayes,

            /// <summary>
            /// Koulikoro
            /// </summary>
            [AliasInShort("2")][RegionCode(3_00_122_0002)] Koulikoro,

            /// <summary>
            /// Sikasso
            /// </summary>
            [AliasInShort("3")][RegionCode(3_00_122_0003)] Sikasso,

            /// <summary>
            /// Ségou
            /// </summary>
            [AliasInShort("4")][RegionCode(3_00_122_0004)] Ségou,

            /// <summary>
            /// Tombouctou
            /// </summary>
            [AliasInShort("6")][RegionCode(3_00_122_0006)] Tombouctou,

            /// <summary>
            /// Gao
            /// </summary>
            [AliasInShort("7")][RegionCode(3_00_122_0007)] Gao,

            /// <summary>
            /// Kidal
            /// </summary>
            [AliasInShort("8")][RegionCode(3_00_122_0008)] Kidal,

            /// <summary>
            /// Bamako
            /// </summary>
            [AliasInShort("BKO")][RegionCode(3_00_122_0100)] Bamako,

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