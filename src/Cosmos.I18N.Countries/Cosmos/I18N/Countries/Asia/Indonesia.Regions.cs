using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Indonesia Regions
    /// </summary>
    public static partial class Indonesia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Java
            /// </summary>
            public static EnumValues Java => EnumValues.Java;

            /// <summary>
            /// Kalimantan
            /// </summary>
            public static EnumValues Kalimantan => EnumValues.Kalimantan;

            /// <summary>
            /// Maluku Islands
            /// </summary>
            public static EnumValues MalukuIslands => EnumValues.MalukuIslands;

            /// <summary>
            /// Lesser Sunda Islands
            /// </summary>
            public static EnumValues LesserSundaIslands => EnumValues.LesserSundaIslands;

            /// <summary>
            /// Papua Islands
            /// </summary>
            public static EnumValues PapuaIslands => EnumValues.PapuaIslands;

            /// <summary>
            /// Sulawesi
            /// </summary>
            public static EnumValues Sulawesi => EnumValues.Sulawesi;

            /// <summary>
            /// Sumatra
            /// </summary>
            public static EnumValues Sumatra => EnumValues.Sumatra;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Indonesia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Java
            /// </summary>
            [AliasInShort("JW")]
            [RegionCode(1_00_115_0001)]
            Java,

            /// <summary>
            /// Kalimantan
            /// </summary>
            [AliasInShort("KA")]
            [RegionCode(1_00_115_0002)]
            Kalimantan,

            /// <summary>
            /// Maluku Islands
            /// </summary>
            [AliasInShort("ML")]
            [RegionCode(1_00_115_0003)]
            MalukuIslands,

            /// <summary>
            /// Lesser Sunda Islands
            /// </summary>
            [AliasInShort("MU")]
            [RegionCode(1_00_115_0004)]
            LesserSundaIslands,

            /// <summary>
            /// Papua Islands
            /// </summary>
            [AliasInShort("PP")]
            [RegionCode(1_00_115_0005)]
            PapuaIslands,

            /// <summary>
            /// Sulawesi
            /// </summary>
            [AliasInShort("SL")]
            [RegionCode(1_00_115_0006)]
            Sulawesi,

            /// <summary>
            /// Sumatra
            /// </summary>
            [AliasInShort("SM")]
            [RegionCode(1_00_115_0007)]
            Sumatra,

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