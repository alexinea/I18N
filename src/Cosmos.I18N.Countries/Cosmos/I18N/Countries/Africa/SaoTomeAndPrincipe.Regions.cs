using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// SaoTomeAndPrincipe Regions
    /// </summary>
    public static  partial class SaoTomeAndPrincipe
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Príncipe
        /// </summary>
        public static EnumValues Príncipe => EnumValues.Príncipe;

        /// <summary>
        /// São Tomé
        /// </summary>
        public static EnumValues SãoTomé => EnumValues.SãoTomé;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for SaoTomeAndPrincipe regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Príncipe
            /// </summary>
            [AliasInShort("P")][RegionCode(3_00_148_0001)] Príncipe,

            /// <summary>
            /// São Tomé
            /// </summary>
            [AliasInShort("S")][RegionCode(3_00_148_0002)] SãoTomé,

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