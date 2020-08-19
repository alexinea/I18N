using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Belarus regions
    /// </summary>
    public static partial class Belarus
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Brest
            /// </summary>
            public static EnumValues Brest => EnumValues.Brest;

            /// <summary>
            /// Minsk
            /// </summary>
            public static EnumValues Minsk => EnumValues.Minsk;

            /// <summary>
            /// Homel
            /// </summary>
            public static EnumValues Homel => EnumValues.Homel;

            /// <summary>
            /// Hrodna
            /// </summary>
            public static EnumValues Hrodna => EnumValues.Hrodna;

            /// <summary>
            /// Magileu
            /// </summary>
            public static EnumValues Magileu => EnumValues.Magileu;

            /// <summary>
            /// Minsk Region
            /// </summary>
            public static EnumValues MinskRegion => EnumValues.MinskRegion;

            /// <summary>
            /// Vitebsk
            /// </summary>
            public static EnumValues Vitebsk => EnumValues.Vitebsk;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Belarus regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Brest
            /// </summary>
            [AliasInShort("BR")]
            [RegionCode(2_00_104_0001)]
            Brest,

            /// <summary>
            /// Minsk
            /// </summary>
            [AliasInShort("HM")]
            [RegionCode(2_00_104_0002)]
            Minsk,

            /// <summary>
            /// Homel
            /// </summary>
            [AliasInShort("HO")]
            [RegionCode(2_00_104_0003)]
            Homel,

            /// <summary>
            /// Hrodna
            /// </summary>
            [AliasInShort("HR")]
            [RegionCode(2_00_104_0004)]
            Hrodna,

            /// <summary>
            /// Magileu
            /// </summary>
            [AliasInShort("MA")]
            [RegionCode(2_00_104_0005)]
            Magileu,

            /// <summary>
            /// Minsk Region
            /// </summary>
            [AliasInShort("MI")]
            [RegionCode(2_00_104_0006)]
            MinskRegion,

            /// <summary>
            /// Vitebsk
            /// </summary>
            [AliasInShort("VI")]
            [RegionCode(2_00_104_0007)]
            Vitebsk,

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