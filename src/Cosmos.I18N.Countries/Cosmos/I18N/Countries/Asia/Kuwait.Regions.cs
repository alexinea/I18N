using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Kuwait Regions
    /// </summary>
    public static partial class Kuwait
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Al Ahmadi
            /// </summary>
            public static EnumValues AlAhmadi => EnumValues.AlAhmadi;

            /// <summary>
            /// Al Farwaniyah
            /// </summary>
            public static EnumValues AlFarwaniyah => EnumValues.AlFarwaniyah;

            /// <summary>
            /// Hawalli
            /// </summary>
            public static EnumValues Hawalli => EnumValues.Hawalli;

            /// <summary>
            /// Al Jahra
            /// </summary>
            public static EnumValues AlJahra => EnumValues.AlJahra;

            /// <summary>
            /// Al Asimah
            /// </summary>
            public static EnumValues AlAsimah => EnumValues.AlAsimah;

            /// <summary>
            /// Mubarak Al-Kabeer
            /// </summary>
            public static EnumValues MubarakAlKabeer => EnumValues.MubarakAlKabeer;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Kuwait regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Al Ahmadi
            /// </summary>
            [AliasInShort("AH")]
            [RegionCode(1_00_120_0001)]
            AlAhmadi,

            /// <summary>
            /// Al Farwaniyah
            /// </summary>
            [AliasInShort("FA")]
            [RegionCode(1_00_120_0002)]
            AlFarwaniyah,

            /// <summary>
            /// Hawalli
            /// </summary>
            [AliasInShort("HA")]
            [RegionCode(1_00_120_0003)]
            Hawalli,

            /// <summary>
            /// Al Jahra
            /// </summary>
            [AliasInShort("JA")]
            [RegionCode(1_00_120_0004)]
            AlJahra,

            /// <summary>
            /// Al Asimah
            /// </summary>
            [AliasInShort("KU")]
            [RegionCode(1_00_120_0005)]
            AlAsimah,

            /// <summary>
            /// Mubarak Al-Kabeer
            /// </summary>
            [AliasInShort("MU")]
            [RegionCode(1_00_120_0006)]
            MubarakAlKabeer,

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