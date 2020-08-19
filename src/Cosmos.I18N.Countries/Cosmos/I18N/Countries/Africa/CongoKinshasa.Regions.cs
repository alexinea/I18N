using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Congo Kinshasa regions
    /// </summary>
    public static partial class CongoKinshasa
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Bas-Congo
            /// </summary>
            public static EnumValues BasCongo => EnumValues.BasCongo;

            /// <summary>
            /// Bandundu
            /// </summary>
            public static EnumValues Bandundu => EnumValues.Bandundu;

            /// <summary>
            /// Équateur
            /// </summary>
            public static EnumValues Équateur => EnumValues.Équateur;

            /// <summary>
            /// Katanga
            /// </summary>
            public static EnumValues Katanga => EnumValues.Katanga;

            /// <summary>
            /// Kasaï-Oriental
            /// </summary>
            public static EnumValues KasaïOriental => EnumValues.KasaïOriental;

            /// <summary>
            /// Kinshasa
            /// </summary>
            public static EnumValues Kinshasa => EnumValues.Kinshasa;

            /// <summary>
            /// Kasaï-Occidental
            /// </summary>
            public static EnumValues KasaïOccidental => EnumValues.KasaïOccidental;

            /// <summary>
            /// Maniema
            /// </summary>
            public static EnumValues Maniema => EnumValues.Maniema;

            /// <summary>
            /// North Kivu
            /// </summary>
            public static EnumValues NorthKivu => EnumValues.NorthKivu;

            /// <summary>
            /// Orientale
            /// </summary>
            public static EnumValues Orientale => EnumValues.Orientale;

            /// <summary>
            /// South Kivu
            /// </summary>
            public static EnumValues SouthKivu => EnumValues.SouthKivu;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Congo Kinshasa regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bas-Congo
            /// </summary>
            [AliasInShort("BC")]
            [RegionCode(3_00_113_0001)]
            BasCongo,

            /// <summary>
            /// Bandundu
            /// </summary>
            [AliasInShort("BN")]
            [RegionCode(3_00_113_0002)]
            Bandundu,

            /// <summary>
            /// Équateur
            /// </summary>
            [AliasInShort("EQ")]
            [RegionCode(3_00_113_0003)]
            Équateur,

            /// <summary>
            /// Katanga
            /// </summary>
            [AliasInShort("KA")]
            [RegionCode(3_00_113_0004)]
            Katanga,

            /// <summary>
            /// Kasaï-Oriental
            /// </summary>
            [AliasInShort("KE")]
            [RegionCode(3_00_113_0005)]
            KasaïOriental,

            /// <summary>
            /// Kinshasa
            /// </summary>
            [AliasInShort("KN")]
            [RegionCode(3_00_113_0006)]
            Kinshasa,

            /// <summary>
            /// Kasaï-Occidental
            /// </summary>
            [AliasInShort("KW")]
            [RegionCode(3_00_113_0007)]
            KasaïOccidental,

            /// <summary>
            /// Maniema
            /// </summary>
            [AliasInShort("MA")]
            [RegionCode(3_00_113_0008)]
            Maniema,

            /// <summary>
            /// North Kivu
            /// </summary>
            [AliasInShort("NK")]
            [RegionCode(3_00_113_0009)]
            NorthKivu,

            /// <summary>
            /// Orientale
            /// </summary>
            [AliasInShort("OR")]
            [RegionCode(3_00_113_0010)]
            Orientale,

            /// <summary>
            /// South Kivu
            /// </summary>
            [AliasInShort("SK")]
            [RegionCode(3_00_113_0011)]
            SouthKivu,

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