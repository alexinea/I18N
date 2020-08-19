using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// EastTimor Regions
    /// </summary>
    public static partial class EastTimor
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Aileu
            /// </summary>
            public static EnumValues Aileu => EnumValues.Aileu;

            /// <summary>
            /// Ainaro
            /// </summary>
            public static EnumValues Ainaro => EnumValues.Ainaro;

            /// <summary>
            /// Baucau
            /// </summary>
            public static EnumValues Baucau => EnumValues.Baucau;

            /// <summary>
            /// Bobonaro
            /// </summary>
            public static EnumValues Bobonaro => EnumValues.Bobonaro;

            /// <summary>
            /// Cova Lima
            /// </summary>
            public static EnumValues CovaLima => EnumValues.CovaLima;

            /// <summary>
            /// Dili
            /// </summary>
            public static EnumValues Dili => EnumValues.Dili;

            /// <summary>
            /// Ermera
            /// </summary>
            public static EnumValues Ermera => EnumValues.Ermera;

            /// <summary>
            /// Lautém
            /// </summary>
            public static EnumValues Lautém => EnumValues.Lautém;

            /// <summary>
            /// Liquiçá
            /// </summary>
            public static EnumValues Liquiçá => EnumValues.Liquiçá;

            /// <summary>
            /// Manufahi
            /// </summary>
            public static EnumValues Manufahi => EnumValues.Manufahi;

            /// <summary>
            /// Manatuto
            /// </summary>
            public static EnumValues Manatuto => EnumValues.Manatuto;

            /// <summary>
            /// Oecusse
            /// </summary>
            public static EnumValues Oecusse => EnumValues.Oecusse;

            /// <summary>
            /// Viqueque
            /// </summary>
            public static EnumValues Viqueque => EnumValues.Viqueque;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for EastTimor regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Aileu
            /// </summary>
            [AliasInShort("AL")]
            [RegionCode(1_00_114_0001)]
            Aileu,

            /// <summary>
            /// Ainaro
            /// </summary>
            [AliasInShort("AN")]
            [RegionCode(1_00_114_0002)]
            Ainaro,

            /// <summary>
            /// Baucau
            /// </summary>
            [AliasInShort("BA")]
            [RegionCode(1_00_114_0003)]
            Baucau,

            /// <summary>
            /// Bobonaro
            /// </summary>
            [AliasInShort("BO")]
            [RegionCode(1_00_114_0004)]
            Bobonaro,

            /// <summary>
            /// Cova Lima
            /// </summary>
            [AliasInShort("CO")]
            [RegionCode(1_00_114_0005)]
            CovaLima,

            /// <summary>
            /// Dili
            /// </summary>
            [AliasInShort("DI")]
            [RegionCode(1_00_114_0006)]
            Dili,

            /// <summary>
            /// Ermera
            /// </summary>
            [AliasInShort("ER")]
            [RegionCode(1_00_114_0007)]
            Ermera,

            /// <summary>
            /// Lautém
            /// </summary>
            [AliasInShort("LA")]
            [RegionCode(1_00_114_0008)]
            Lautém,

            /// <summary>
            /// Liquiçá
            /// </summary>
            [AliasInShort("LI")]
            [RegionCode(1_00_114_0009)]
            Liquiçá,

            /// <summary>
            /// Manufahi
            /// </summary>
            [AliasInShort("MF")]
            [RegionCode(1_00_114_0010)]
            Manufahi,

            /// <summary>
            /// Manatuto
            /// </summary>
            [AliasInShort("MT")]
            [RegionCode(1_00_114_0011)]
            Manatuto,

            /// <summary>
            /// Oecusse
            /// </summary>
            [AliasInShort("OE")]
            [RegionCode(1_00_114_0012)]
            Oecusse,

            /// <summary>
            /// Viqueque
            /// </summary>
            [AliasInShort("VI")]
            [RegionCode(1_00_114_0013)]
            Viqueque,

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