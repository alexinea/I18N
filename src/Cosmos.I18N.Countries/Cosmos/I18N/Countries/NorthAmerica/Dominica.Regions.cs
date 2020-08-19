using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Dominica regions
    /// </summary>
    public static partial class Dominica
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
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
            /// Saint John
            /// </summary>
            public static EnumValues SaintJohn => EnumValues.SaintJohn;

            /// <summary>
            /// Saint Joseph
            /// </summary>
            public static EnumValues SaintJoseph => EnumValues.SaintJoseph;

            /// <summary>
            /// Saint Luke
            /// </summary>
            public static EnumValues SaintLuke => EnumValues.SaintLuke;

            /// <summary>
            /// Saint Mark
            /// </summary>
            public static EnumValues SaintMark => EnumValues.SaintMark;

            /// <summary>
            /// Saint Patrick
            /// </summary>
            public static EnumValues SaintPatrick => EnumValues.SaintPatrick;

            /// <summary>
            /// Saint Paul
            /// </summary>
            public static EnumValues SaintPaul => EnumValues.SaintPaul;

            /// <summary>
            /// Saint Peter
            /// </summary>
            public static EnumValues SaintPeter => EnumValues.SaintPeter;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Dominica regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Saint Andrew
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(4_00_113_0002)]
            SaintAndrew,

            /// <summary>
            /// Saint David
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(4_00_113_0003)]
            SaintDavid,

            /// <summary>
            /// Saint George
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(4_00_113_0004)]
            SaintGeorge,

            /// <summary>
            /// Saint John
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(4_00_113_0005)]
            SaintJohn,

            /// <summary>
            /// Saint Joseph
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(4_00_113_0006)]
            SaintJoseph,

            /// <summary>
            /// Saint Luke
            /// </summary>
            [AliasInShort("07")]
            [RegionCode(4_00_113_0007)]
            SaintLuke,

            /// <summary>
            /// Saint Mark
            /// </summary>
            [AliasInShort("08")]
            [RegionCode(4_00_113_0008)]
            SaintMark,

            /// <summary>
            /// Saint Patrick
            /// </summary>
            [AliasInShort("09")]
            [RegionCode(4_00_113_0009)]
            SaintPatrick,

            /// <summary>
            /// Saint Paul
            /// </summary>
            [AliasInShort("10")]
            [RegionCode(4_00_113_0010)]
            SaintPaul,

            /// <summary>
            /// Saint Peter
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(4_00_113_0011)]
            SaintPeter,

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