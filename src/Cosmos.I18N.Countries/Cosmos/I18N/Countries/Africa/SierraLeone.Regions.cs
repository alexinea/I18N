using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Sierra Leone Regions
    /// </summary>
    public static partial class SierraLeone
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Eastern
        /// </summary>
        public static EnumValues Eastern => EnumValues.Eastern;

        /// <summary>
        /// Northern
        /// </summary>
        public static EnumValues Northern => EnumValues.Northern;

        /// <summary>
        /// Southern
        /// </summary>
        public static EnumValues Southern => EnumValues.Southern;

        /// <summary>
        /// Western Area
        /// </summary>
        public static EnumValues WesternArea => EnumValues.WesternArea;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Sierra Leone regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Eastern
            /// </summary>
            [AliasInShort("E")][RegionCode(3_00_153_0001)] Eastern,

            /// <summary>
            /// Northern
            /// </summary>
            [AliasInShort("N")][RegionCode(3_00_153_0002)] Northern,

            /// <summary>
            /// Southern
            /// </summary>
            [AliasInShort("S")][RegionCode(3_00_153_0003)] Southern,

            /// <summary>
            /// Western Area
            /// </summary>
            [AliasInShort("W")][RegionCode(3_00_153_0004)] WesternArea,

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