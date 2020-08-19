using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// Bolivia regions
    /// </summary>
    public static partial class Bolivia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Beni
            /// </summary>
            public static EnumValues Beni => EnumValues.Beni;

            /// <summary>
            /// Cochabamba
            /// </summary>
            public static EnumValues Cochabamba => EnumValues.Cochabamba;

            /// <summary>
            /// Chuquisaca
            /// </summary>
            public static EnumValues Chuquisaca => EnumValues.Chuquisaca;

            /// <summary>
            /// La Paz
            /// </summary>
            public static EnumValues LaPaz => EnumValues.LaPaz;

            /// <summary>
            /// Pando
            /// </summary>
            public static EnumValues Pando => EnumValues.Pando;

            /// <summary>
            /// Oruro
            /// </summary>
            public static EnumValues Oruro => EnumValues.Oruro;

            /// <summary>
            /// Potosí
            /// </summary>
            public static EnumValues Potosí => EnumValues.Potosí;

            /// <summary>
            /// Santa Cruz
            /// </summary>
            public static EnumValues SantaCruz => EnumValues.SantaCruz;

            /// <summary>
            /// Tarija
            /// </summary>
            public static EnumValues Tarija => EnumValues.Tarija;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Bolivia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Beni
            /// </summary>
            [AliasInShort("B")]
            [RegionCode(5_00_101_0001)]
            Beni,

            /// <summary>
            /// Cochabamba
            /// </summary>
            [AliasInShort("C")]
            [RegionCode(5_00_101_0002)]
            Cochabamba,

            /// <summary>
            /// Chuquisaca
            /// </summary>
            [AliasInShort("H")]
            [RegionCode(5_00_101_0003)]
            Chuquisaca,

            /// <summary>
            /// La Paz
            /// </summary>
            [AliasInShort("L")]
            [RegionCode(5_00_101_0004)]
            LaPaz,

            /// <summary>
            /// Pando
            /// </summary>
            [AliasInShort("N")]
            [RegionCode(5_00_101_0005)]
            Pando,

            /// <summary>
            /// Oruro
            /// </summary>
            [AliasInShort("O")]
            [RegionCode(5_00_101_0006)]
            Oruro,

            /// <summary>
            /// Potosí
            /// </summary>
            [AliasInShort("P")]
            [RegionCode(5_00_101_0007)]
            Potosí,

            /// <summary>
            /// Santa Cruz
            /// </summary>
            [AliasInShort("S")]
            [RegionCode(5_00_101_0008)]
            SantaCruz,

            /// <summary>
            /// Tarija
            /// </summary>
            [AliasInShort("T")]
            [RegionCode(5_00_101_0009)]
            Tarija,

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