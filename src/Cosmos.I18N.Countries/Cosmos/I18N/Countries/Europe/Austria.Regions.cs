using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Austria regions
    /// </summary>
    public static partial class Austria
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Burgenland
            /// </summary>
            public static EnumValues Burgenland => EnumValues.Burgenland;

            /// <summary>
            /// Carinthia
            /// </summary>
            public static EnumValues Kärnten => EnumValues.Kärnten;

            /// <summary>
            /// Lower Austria
            /// </summary>
            public static EnumValues Niederösterreich => EnumValues.Niederösterreich;

            /// <summary>
            /// Upper Austria
            /// </summary>
            public static EnumValues Oberösterreich => EnumValues.Oberösterreich;

            /// <summary>
            /// Salzburg
            /// </summary>
            public static EnumValues Salzburg => EnumValues.Salzburg;

            /// <summary>
            /// Styria
            /// </summary>
            public static EnumValues Steiermark => EnumValues.Steiermark;

            /// <summary>
            /// Tyrol
            /// </summary>
            public static EnumValues Tirol => EnumValues.Tirol;

            /// <summary>
            /// Vorarlberg
            /// </summary>
            public static EnumValues Vorarlberg => EnumValues.Vorarlberg;

            /// <summary>
            /// Vienna
            /// </summary>
            public static EnumValues Wien => EnumValues.Wien;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Austria regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Burgenland
            /// </summary>
            [AliasInShort("1")]
            [RegionCode(2_00_011_0001)]
            Burgenland,

            /// <summary>
            /// Carinthia
            /// </summary>
            [AliasInShort("2")]
            [RegionCode(2_00_011_0002)]
            Kärnten,

            /// <summary>
            /// Lower Austria
            /// </summary>
            [AliasInShort("3")]
            [RegionCode(2_00_011_0003)]
            Niederösterreich,

            /// <summary>
            /// Upper Austria
            /// </summary>
            [AliasInShort("4")]
            [RegionCode(2_00_011_0004)]
            Oberösterreich,

            /// <summary>
            /// Salzburg
            /// </summary>
            [AliasInShort("5")]
            [RegionCode(2_00_011_0005)]
            Salzburg,

            /// <summary>
            /// Styria
            /// </summary>
            [AliasInShort("6")]
            [RegionCode(2_00_011_0006)]
            Steiermark,

            /// <summary>
            /// Tyrol
            /// </summary>
            [AliasInShort("7")]
            [RegionCode(2_00_011_0007)]
            Tirol,

            /// <summary>
            /// Vorarlberg
            /// </summary>
            [AliasInShort("8")]
            [RegionCode(2_00_011_0008)]
            Vorarlberg,

            /// <summary>
            /// Vienna
            /// </summary>
            [AliasInShort("9")]
            [RegionCode(2_00_011_0009)]
            Wien,

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