using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// SanMarino Regions
    /// </summary>
    public static partial class SanMarino
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Acquaviva
            /// </summary>
            public static EnumValues Acquaviva => EnumValues.Acquaviva;

            /// <summary>
            /// Chiesanuova
            /// </summary>
            public static EnumValues Chiesanuova => EnumValues.Chiesanuova;

            /// <summary>
            /// Domagnano
            /// </summary>
            public static EnumValues Domagnano => EnumValues.Domagnano;

            /// <summary>
            /// Faetano
            /// </summary>
            public static EnumValues Faetano => EnumValues.Faetano;

            /// <summary>
            /// Fiorentino
            /// </summary>
            public static EnumValues Fiorentino => EnumValues.Fiorentino;

            /// <summary>
            /// Borgo Maggiore
            /// </summary>
            public static EnumValues BorgoMaggiore => EnumValues.BorgoMaggiore;

            /// <summary>
            /// San Marino
            /// </summary>
            public static EnumValues SanMarinoCity => EnumValues.SanMarino;

            /// <summary>
            /// Montegiardino 
            /// </summary>
            public static EnumValues Montegiardino => EnumValues.Montegiardino;

            /// <summary>
            /// Serravalle
            /// </summary>
            public static EnumValues Serravalle => EnumValues.Serravalle;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for SanMarino regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Acquaviva
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(2_00_135_0001)]
            Acquaviva,

            /// <summary>
            /// Chiesanuova
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(2_00_135_0002)]
            Chiesanuova,

            /// <summary>
            /// Domagnano
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(2_00_135_0003)]
            Domagnano,

            /// <summary>
            /// Faetano
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(2_00_135_0004)]
            Faetano,

            /// <summary>
            /// Fiorentino
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(2_00_135_0005)]
            Fiorentino,

            /// <summary>
            /// Borgo Maggiore
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(2_00_135_0006)]
            BorgoMaggiore,

            /// <summary>
            /// San Marino
            /// </summary>
            [AliasInShort("07")]
            [RegionCode(2_00_135_0007)]
            SanMarino,

            /// <summary>
            /// Montegiardino
            /// </summary>
            [AliasInShort("08")]
            [RegionCode(2_00_135_0008)]
            Montegiardino,

            /// <summary>
            /// Serravalle
            /// </summary>
            [AliasInShort("09")]
            [RegionCode(2_00_135_0009)]
            Serravalle,

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