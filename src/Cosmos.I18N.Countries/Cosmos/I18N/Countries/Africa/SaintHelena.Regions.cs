using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// SaintHelena Regions
    /// </summary>
    public static  partial class SaintHelena
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Ascension Island
        /// </summary>
        public static EnumValues AscensionIsland => EnumValues.AscensionIsland;

        /// <summary>
        /// Saint Helena
        /// </summary>
        public static EnumValues SaintHelena => EnumValues.SaintHelena;

        /// <summary>
        /// Tristan da Cunha
        /// </summary>
        public static EnumValues TristanDaCunha => EnumValues.TristanDaCunha;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for SaintHelena regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ascension Island
            /// </summary>
            [AliasInShort("AC")][RegionCode(3_00_121_0001)] AscensionIsland,

            /// <summary>
            /// Saint Helena
            /// </summary>
            [AliasInShort("HL")][RegionCode(3_00_121_0002)] SaintHelena,

            /// <summary>
            /// Tristan da Cunha
            /// </summary>
            [AliasInShort("TA")][RegionCode(3_00_121_0003)] TristanDaCunha,

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