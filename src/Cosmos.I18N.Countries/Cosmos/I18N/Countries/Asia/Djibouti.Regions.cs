using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Djibouti regions
    /// </summary>
    public static partial class Djibouti
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Arta
            /// </summary>
            public static EnumValues Arta => EnumValues.Arta;

            /// <summary>
            /// Ali Sabieh
            /// </summary>
            public static EnumValues AliSabieh => EnumValues.AliSabieh;

            /// <summary>
            /// Dikhil
            /// </summary>
            public static EnumValues Dikhil => EnumValues.Dikhil;

            /// <summary>
            /// Djibouti
            /// </summary>
            public static EnumValues Djibouti => EnumValues.Djibouti;

            /// <summary>
            /// Obock
            /// </summary>
            public static EnumValues Obock => EnumValues.Obock;

            /// <summary>
            /// Tadjourah
            /// </summary>
            public static EnumValues Tadjourah => EnumValues.Tadjourah;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Djibouti regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Arta
            /// </summary>
            [AliasInShort("AR")]
            [RegionCode(1_00_113_0001)]
            Arta,

            /// <summary>
            /// Ali Sabieh
            /// </summary>
            [AliasInShort("AS")]
            [RegionCode(1_00_113_0002)]
            AliSabieh,

            /// <summary>
            /// Dikhil
            /// </summary>
            [AliasInShort("DI")]
            [RegionCode(1_00_113_0003)]
            Dikhil,

            /// <summary>
            /// Djibouti
            /// </summary>
            [AliasInShort("DJ")]
            [RegionCode(1_00_113_0004)]
            Djibouti,

            /// <summary>
            /// Obock
            /// </summary>
            [AliasInShort("OB")]
            [RegionCode(1_00_113_0005)]
            Obock,

            /// <summary>
            /// Tadjourah
            /// </summary>
            [AliasInShort("TA")]
            [RegionCode(1_00_113_0006)]
            Tadjourah,

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