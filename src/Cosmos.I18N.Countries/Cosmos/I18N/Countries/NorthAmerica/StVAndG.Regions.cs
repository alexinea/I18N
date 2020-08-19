using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// StVAndG Regions
    /// </summary>
    public static partial class StVAndG
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Charlotte
            /// </summary>
            public static EnumValues Charlotte => EnumValues.Charlotte;

            /// <summary>
            /// Saint Andrew
            /// </summary>
            public static EnumValues SaintAndrew => EnumValues.SaintAndrew;

            /// <summary>
            /// Saint David
            /// </summary>
            public static EnumValues SaintDavid => EnumValues.SaintDavid;

            /// <summary>
            /// Saint George
            /// </summary>
            public static EnumValues SaintGeorge => EnumValues.SaintGeorge;

            /// <summary>
            /// Saint Patrick
            /// </summary>
            public static EnumValues SaintPatrick => EnumValues.SaintPatrick;

            /// <summary>
            /// Grenadines
            /// </summary>
            public static EnumValues Grenadines => EnumValues.Grenadines;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for StVAndG regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Charlotte
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(4_00_133_0001)]
            Charlotte,

            /// <summary>
            /// Saint Andrew
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(4_00_133_0002)]
            SaintAndrew,

            /// <summary>
            /// Saint David
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(4_00_133_0003)]
            SaintDavid,

            /// <summary>
            /// Saint George
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(4_00_133_0004)]
            SaintGeorge,

            /// <summary>
            /// Saint Patrick
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(4_00_133_0005)]
            SaintPatrick,

            /// <summary>
            /// Grenadines
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(4_00_133_0006)]
            Grenadines,

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