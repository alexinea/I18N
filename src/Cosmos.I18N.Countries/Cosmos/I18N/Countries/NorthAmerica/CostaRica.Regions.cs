using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// CostaRica regions
    /// </summary>
    public static partial class CostaRica
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Alajuela
            /// </summary>
            public static EnumValues Alajuela => EnumValues.Alajuela;

            /// <summary>
            /// Cartago
            /// </summary>
            public static EnumValues Cartago => EnumValues.Cartago;

            /// <summary>
            /// Guanacaste
            /// </summary>
            public static EnumValues Guanacaste => EnumValues.Guanacaste;

            /// <summary>
            /// Heredia
            /// </summary>
            public static EnumValues Heredia => EnumValues.Heredia;

            /// <summary>
            /// Limón
            /// </summary>
            public static EnumValues Limón => EnumValues.Limón;

            /// <summary>
            /// Puntarenas
            /// </summary>
            public static EnumValues Puntarenas => EnumValues.Puntarenas;

            /// <summary>
            /// San José
            /// </summary>
            public static EnumValues SanJosé => EnumValues.SanJosé;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for CostaRica regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Alajuela
            /// </summary>
            [AliasInShort("A")]
            [RegionCode(4_00_111_0001)]
            Alajuela,

            /// <summary>
            /// Cartago
            /// </summary>
            [AliasInShort("C")]
            [RegionCode(4_00_111_0002)]
            Cartago,

            /// <summary>
            /// Guanacaste
            /// </summary>
            [AliasInShort("G")]
            [RegionCode(4_00_111_0003)]
            Guanacaste,

            /// <summary>
            /// Heredia
            /// </summary>
            [AliasInShort("H")]
            [RegionCode(4_00_111_0004)]
            Heredia,

            /// <summary>
            /// Limón
            /// </summary>
            [AliasInShort("L")]
            [RegionCode(4_00_111_0005)]
            Limón,

            /// <summary>
            /// Puntarenas
            /// </summary>
            [AliasInShort("P")]
            [RegionCode(4_00_111_0006)]
            Puntarenas,

            /// <summary>
            /// San José
            /// </summary>
            [AliasInShort("SJ")]
            [RegionCode(4_00_111_0007)]
            SanJosé,

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