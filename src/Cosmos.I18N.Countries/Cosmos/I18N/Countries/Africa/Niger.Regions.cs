using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Niger Regions
    /// </summary>
    public static  partial class Niger
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Agadez
        /// </summary>
        public static EnumValues Agadez => EnumValues.Agadez;

        /// <summary>
        /// Diffa
        /// </summary>
        public static EnumValues Diffa => EnumValues.Diffa;

        /// <summary>
        /// Dosso
        /// </summary>
        public static EnumValues Dosso => EnumValues.Dosso;

        /// <summary>
        /// Maradi
        /// </summary>
        public static EnumValues Maradi => EnumValues.Maradi;

        /// <summary>
        /// Tahoua
        /// </summary>
        public static EnumValues Tahoua => EnumValues.Tahoua;

        /// <summary>
        /// Tillabéri
        /// </summary>
        public static EnumValues Tillabéri => EnumValues.Tillabéri;

        /// <summary>
        /// Zinder
        /// </summary>
        public static EnumValues Zinder => EnumValues.Zinder;

        /// <summary>
        /// Niamey   
        /// </summary>
        public static EnumValues Niamey => EnumValues.Niamey;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Niger regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Agadez
            /// </summary>
            [AliasInShort("1")][RegionCode(3_00_143_0001)] Agadez,

            /// <summary>
            /// Diffa
            /// </summary>
            [AliasInShort("2")][RegionCode(3_00_143_0002)] Diffa,

            /// <summary>
            /// Dosso
            /// </summary>
            [AliasInShort("3")][RegionCode(3_00_143_0003)] Dosso,

            /// <summary>
            /// Maradi
            /// </summary>
            [AliasInShort("4")][RegionCode(3_00_143_0004)] Maradi,

            /// <summary>
            /// Tahoua
            /// </summary>
            [AliasInShort("5")][RegionCode(3_00_143_0005)] Tahoua,

            /// <summary>
            /// Tillabéri
            /// </summary>
            [AliasInShort("6")][RegionCode(3_00_143_0006)] Tillabéri,

            /// <summary>
            /// Zinder
            /// </summary>
            [AliasInShort("7")][RegionCode(3_00_143_0007)] Zinder,

            /// <summary>
            /// Niamey
            /// </summary>
            [AliasInShort("8")][RegionCode(3_00_143_0008)] Niamey,

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