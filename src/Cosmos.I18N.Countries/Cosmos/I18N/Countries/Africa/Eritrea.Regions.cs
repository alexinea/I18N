using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Eritrea regions
    /// </summary>
    public static partial  class Eritrea
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Anseba
        /// </summary>
        public static EnumValues Anseba => EnumValues.Anseba;

        /// <summary>
        /// Southern Red Sea
        /// </summary>
        public static EnumValues SouthernRedSea => EnumValues.SouthernRedSea;

        /// <summary>
        /// Debub
        /// </summary>
        public static EnumValues Debub => EnumValues.Debub;

        /// <summary>
        /// Gash-Barka
        /// </summary>
        public static EnumValues GashBarka => EnumValues.GashBarka;

        /// <summary>
        /// Maekel
        /// </summary>
        public static EnumValues Maekel => EnumValues.Maekel;

        /// <summary>
        /// Northern Red Sea
        /// </summary>
        public static EnumValues NorthernRedSea => EnumValues.NorthernRedSea;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Eritrea regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Anseba
            /// </summary>
            [AliasInShort("AN")][RegionCode(3_00_116_0001)] Anseba,

            /// <summary>
            /// Southern Red Sea
            /// </summary>
            [AliasInShort("DX")][RegionCode(3_00_116_0002)] SouthernRedSea,

            /// <summary>
            /// Debub
            /// </summary>
            [AliasInShort("DU")][RegionCode(3_00_116_0003)] Debub,

            /// <summary>
            /// Gash-Barka
            /// </summary>
            [AliasInShort("GB")][RegionCode(3_00_116_0004)] GashBarka,

            /// <summary>
            /// Maekel
            /// </summary>
            [AliasInShort("MA")][RegionCode(3_00_116_0005)] Maekel,

            /// <summary>
            /// Northern Red Sea
            /// </summary>
            [AliasInShort("SK")][RegionCode(3_00_116_0006)] NorthernRedSea,

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