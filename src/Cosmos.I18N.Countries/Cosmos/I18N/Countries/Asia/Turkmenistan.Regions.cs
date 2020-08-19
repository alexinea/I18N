using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Turkmenistan Regions
    /// </summary>
    public static partial class Turkmenistan
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Ahal
            /// </summary>
            public static EnumValues Ahal => EnumValues.Ahal;

            /// <summary>
            /// Balkan
            /// </summary>
            public static EnumValues Balkan => EnumValues.Balkan;

            /// <summary>
            /// Daşoguz
            /// </summary>
            public static EnumValues Daşoguz => EnumValues.Daşoguz;

            /// <summary>
            /// Lebap
            /// </summary>
            public static EnumValues Lebap => EnumValues.Lebap;

            /// <summary>
            /// Mary
            /// </summary>
            public static EnumValues Mary => EnumValues.Mary;

            /// <summary>
            /// Aşgabat
            /// </summary>
            public static EnumValues Aşgabat => EnumValues.Aşgabat;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Turkmenistan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ahal
            /// </summary>
            [AliasInShort("A")]
            [RegionCode(1_00_139_0001)]
            Ahal,

            /// <summary>
            /// Balkan
            /// </summary>
            [AliasInShort("B")]
            [RegionCode(1_00_139_0002)]
            Balkan,

            /// <summary>
            /// Daşoguz
            /// </summary>
            [AliasInShort("D")]
            [RegionCode(1_00_139_0003)]
            Daşoguz,

            /// <summary>
            /// Lebap
            /// </summary>
            [AliasInShort("L")]
            [RegionCode(1_00_139_0004)]
            Lebap,

            /// <summary>
            /// Mary
            /// </summary>
            [AliasInShort("M")]
            [RegionCode(1_00_139_0005)]
            Mary,

            /// <summary>
            /// Aşgabat
            /// </summary>
            [AliasInShort("S")]
            [RegionCode(1_00_139_0006)]
            Aşgabat,

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