using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Israel Regions
    /// </summary>
    public static partial class Israel
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Southern District
            /// </summary>
            public static EnumValues SouthernDistrict => EnumValues.SouthernDistrict;

            /// <summary>
            /// Haifa District
            /// </summary>
            public static EnumValues HaifaDistrict => EnumValues.HaifaDistrict;

            /// <summary>
            /// Jerusalem
            /// </summary>
            public static EnumValues Jerusalem => EnumValues.Jerusalem;

            /// <summary>
            /// Central District
            /// </summary>
            public static EnumValues CentralDistrict => EnumValues.CentralDistrict;

            /// <summary>
            /// Tel Aviv District
            /// </summary>
            public static EnumValues TelAvivDistrict => EnumValues.TelAvivDistrict;

            /// <summary>
            /// Northern District
            /// </summary>
            public static EnumValues NorthernDistrict => EnumValues.NorthernDistrict;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Israel regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Southern District
            /// </summary>
            [AliasInShort("D")]
            [RegionCode(1_00_115_0001)]
            SouthernDistrict,

            /// <summary>
            /// Haifa District
            /// </summary>
            [AliasInShort("HA")]
            [RegionCode(1_00_115_0002)]
            HaifaDistrict,

            /// <summary>
            /// Jerusalem
            /// </summary>
            [AliasInShort("JM")]
            [RegionCode(1_00_115_0003)]
            Jerusalem,

            /// <summary>
            /// Central District
            /// </summary>
            [AliasInShort("M")]
            [RegionCode(1_00_115_0004)]
            CentralDistrict,

            /// <summary>
            /// Tel Aviv District
            /// </summary>
            [AliasInShort("TA")]
            [RegionCode(1_00_115_0005)]
            TelAvivDistrict,

            /// <summary>
            /// Northern District
            /// </summary>
            [AliasInShort("Z")]
            [RegionCode(1_00_115_0006)]
            NorthernDistrict,

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