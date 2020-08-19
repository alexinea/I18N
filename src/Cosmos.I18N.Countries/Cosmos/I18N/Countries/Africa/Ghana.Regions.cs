using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Ghana Regions
    /// </summary>
    public static  partial class Ghana
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Greater Accra
        /// </summary>
        public static EnumValues GreaterAccra => EnumValues.GreaterAccra;

        /// <summary>
        /// Ashanti
        /// </summary>
        public static EnumValues Ashanti => EnumValues.Ashanti;

        /// <summary>
        /// Brong-Ahafo
        /// </summary>
        public static EnumValues BrongAhafo => EnumValues.BrongAhafo;

        /// <summary>
        /// Central
        /// </summary>
        public static EnumValues Central => EnumValues.Central;

        /// <summary>
        /// Eastern
        /// </summary>
        public static EnumValues Eastern => EnumValues.Eastern;

        /// <summary>
        /// Northern
        /// </summary>
        public static EnumValues Northern => EnumValues.Northern;

        /// <summary>
        /// Volta
        /// </summary>
        public static EnumValues Volta => EnumValues.Volta;

        /// <summary>
        /// Upper East
        /// </summary>
        public static EnumValues UpperEast => EnumValues.UpperEast;

        /// <summary>
        /// Upper West
        /// </summary>
        public static EnumValues UpperWest => EnumValues.UpperWest;

        /// <summary>
        /// Western
        /// </summary>
        public static EnumValues Western => EnumValues.Western;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Ghana regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Greater Accra
            /// </summary>
            [AliasInShort("AA")][RegionCode(3_00_127_0001)] GreaterAccra,

            /// <summary>
            /// Ashanti
            /// </summary>
            [AliasInShort("AH")][RegionCode(3_00_127_0002)] Ashanti,

            /// <summary>
            /// Brong-Ahafo
            /// </summary>
            [AliasInShort("BA")][RegionCode(3_00_127_0003)] BrongAhafo,

            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("CP")][RegionCode(3_00_127_0004)] Central,

            /// <summary>
            /// Eastern
            /// </summary>
            [AliasInShort("EP")][RegionCode(3_00_127_0005)] Eastern,

            /// <summary>
            /// Northern
            /// </summary>
            [AliasInShort("NP")][RegionCode(3_00_127_0006)] Northern,

            /// <summary>
            /// Volta
            /// </summary>
            [AliasInShort("TV")][RegionCode(3_00_127_0007)] Volta,

            /// <summary>
            /// Upper East
            /// </summary>
            [AliasInShort("UE")][RegionCode(3_00_127_0008)] UpperEast,

            /// <summary>
            /// Upper West
            /// </summary>
            [AliasInShort("UW")][RegionCode(3_00_127_0009)] UpperWest,

            /// <summary>
            /// Western
            /// </summary>
            [AliasInShort("WP")][RegionCode(3_00_127_0010)] Western,

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