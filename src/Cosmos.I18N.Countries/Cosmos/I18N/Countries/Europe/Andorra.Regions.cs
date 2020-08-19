using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Andorra Regions
    /// </summary>
    public static partial class Andorra
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Andorra la Vella
            /// </summary>
            public static EnumValues AndorraLaVella => EnumValues.AndorraLaVella;

            /// <summary>
            /// Canillo
            /// </summary>
            public static EnumValues Canillo => EnumValues.Canillo;

            /// <summary>
            /// Massana
            /// </summary>
            public static EnumValues Massana => EnumValues.Massana;

            /// <summary>
            /// Sant Julia de Loria
            /// </summary>
            public static EnumValues SantJuliaDeLoria => EnumValues.SantJuliaDeLoria;

            /// <summary>
            /// Encamp
            /// </summary>
            public static EnumValues Encamp => EnumValues.Encamp;

            /// <summary>
            /// Les Escaldes-Engordany
            /// </summary>
            public static EnumValues LesEscaldesEngordany => EnumValues.LesEscaldesEngordany;

            /// <summary>
            /// Ordino
            /// </summary>
            public static EnumValues Ordino => EnumValues.Ordino;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Andorra regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Andorra la Vella
            /// </summary>
            [AliasInShort("07")]
            [RegionCode(2_00_103_0007)]
            AndorraLaVella,

            /// <summary>
            /// Canillo
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(2_00_103_0002)]
            Canillo,

            /// <summary>
            /// Massana
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(2_00_103_0004)]
            Massana,

            /// <summary>
            /// Sant Julia de Loria
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(2_00_103_0006)]
            SantJuliaDeLoria,

            /// <summary>
            /// Encamp
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(2_00_103_0003)]
            Encamp,

            /// <summary>
            /// Les Escaldes-Engordany
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(2_00_103_0001)]
            LesEscaldesEngordany,

            /// <summary>
            /// Ordino
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(2_00_103_0005)]
            Ordino,

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