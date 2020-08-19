using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// Chile regions
    /// </summary>
    public static partial class Chile
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Aysén
            /// </summary>
            public static EnumValues Aysén => EnumValues.Aysén;

            /// <summary>
            /// Antofagasta
            /// </summary>
            public static EnumValues Antofagasta => EnumValues.Antofagasta;

            /// <summary>
            /// Araucanía
            /// </summary>
            public static EnumValues Araucanía => EnumValues.Araucanía;

            /// <summary>
            /// Atacama
            /// </summary>
            public static EnumValues Atacama => EnumValues.Atacama;

            /// <summary>
            /// Coquimbo
            /// </summary>
            public static EnumValues Coquimbo => EnumValues.Coquimbo;

            /// <summary>
            /// Libertador General Bernardo O’Higgins
            /// </summary>
            public static EnumValues LibertadorGeneralBernardoOHiggins => EnumValues.LibertadorGeneralBernardoOHiggins;

            /// <summary>
            /// Los Lagos
            /// </summary>
            public static EnumValues LosLagos => EnumValues.LosLagos;

            /// <summary>
            /// Los Ríos
            /// </summary>
            public static EnumValues LosRíos => EnumValues.LosRíos;

            /// <summary>
            /// Magallanes Region
            /// </summary>
            public static EnumValues MagallanesRegion => EnumValues.MagallanesRegion;

            /// <summary>
            /// Maule
            /// </summary>
            public static EnumValues Maule => EnumValues.Maule;

            /// <summary>
            /// Santiago Metropolitan
            /// </summary>
            public static EnumValues SantiagoMetropolitan => EnumValues.SantiagoMetropolitan;

            /// <summary>
            /// Valparaíso
            /// </summary>
            public static EnumValues Valparaíso => EnumValues.Valparaíso;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Chile regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Aysén
            /// </summary>
            [AliasInShort("AI")]
            [RegionCode(5_00_012_0001)]
            Aysén,

            /// <summary>
            /// Antofagasta
            /// </summary>
            [AliasInShort("AN")]
            [RegionCode(5_00_012_0002)]
            Antofagasta,

            /// <summary>
            /// Araucanía
            /// </summary>
            [AliasInShort("AR")]
            [RegionCode(5_00_012_0003)]
            Araucanía,

            /// <summary>
            /// Atacama
            /// </summary>
            [AliasInShort("AT")]
            [RegionCode(5_00_012_0004)]
            Atacama,

            /// <summary>
            /// Coquimbo
            /// </summary>
            [AliasInShort("CO")]
            [RegionCode(5_00_012_0005)]
            Coquimbo,

            /// <summary>
            /// Libertador General Bernardo O’Higgins
            /// </summary>
            [AliasInShort("LI")]
            [RegionCode(5_00_012_0006)]
            LibertadorGeneralBernardoOHiggins,

            /// <summary>
            /// Los Lagos
            /// </summary>
            [AliasInShort("LL")]
            [RegionCode(5_00_012_0007)]
            LosLagos,

            /// <summary>
            /// Los Ríos
            /// </summary>
            [AliasInShort("LR")]
            [RegionCode(5_00_012_0008)]
            LosRíos,

            /// <summary>
            /// Magallanes Region
            /// </summary>
            [AliasInShort("MA")]
            [RegionCode(5_00_012_0009)]
            MagallanesRegion,

            /// <summary>
            /// Maule
            /// </summary>
            [AliasInShort("ML")]
            [RegionCode(5_00_012_0010)]
            Maule,

            /// <summary>
            /// Santiago Metropolitan
            /// </summary>
            [AliasInShort("RM")]
            [RegionCode(5_00_012_0011)]
            SantiagoMetropolitan,

            /// <summary>
            /// Valparaíso
            /// </summary>
            [AliasInShort("VS")]
            [RegionCode(5_00_012_0012)]
            Valparaíso,

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