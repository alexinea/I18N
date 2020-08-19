using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Estonia Regions
    /// </summary>
    public static partial class Estonia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Harju
            /// </summary>
            public static EnumValues Harju => EnumValues.Harju;

            /// <summary>
            /// Hiiu
            /// </summary>
            public static EnumValues Hiiu => EnumValues.Hiiu;

            /// <summary>
            /// Ida-Viru
            /// </summary>
            public static EnumValues IdaViru => EnumValues.IdaViru;

            /// <summary>
            /// Jõgeva
            /// </summary>
            public static EnumValues Jõgeva => EnumValues.Jõgeva;

            /// <summary>
            /// Järva
            /// </summary>
            public static EnumValues Järva => EnumValues.Järva;

            /// <summary>
            /// Lääne
            /// </summary>
            public static EnumValues Lääne => EnumValues.Lääne;

            /// <summary>
            /// Lääne-Viru
            /// </summary>
            public static EnumValues LääneViru => EnumValues.LääneViru;

            /// <summary>
            /// Põlva
            /// </summary>
            public static EnumValues Põlva => EnumValues.Põlva;

            /// <summary>
            /// Pärnu
            /// </summary>
            public static EnumValues Pärnu => EnumValues.Pärnu;

            /// <summary>
            /// Rapla
            /// </summary>
            public static EnumValues Rapla => EnumValues.Rapla;

            /// <summary>
            /// Saare
            /// </summary>
            public static EnumValues Saare => EnumValues.Saare;

            /// <summary>
            /// Tartu
            /// </summary>
            public static EnumValues Tartu => EnumValues.Tartu;

            /// <summary>
            /// Valga
            /// </summary>
            public static EnumValues Valga => EnumValues.Valga;

            /// <summary>
            /// Viljandi
            /// </summary>
            public static EnumValues Viljandi => EnumValues.Viljandi;

            /// <summary>
            /// Võru
            /// </summary>
            public static EnumValues Võru => EnumValues.Võru;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Estonia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Harju
            /// </summary>
            [AliasInShort("37")]
            [RegionCode(2_00_111_0037)]
            Harju,

            /// <summary>
            /// Hiiu
            /// </summary>
            [AliasInShort("39")]
            [RegionCode(2_00_111_0039)]
            Hiiu,

            /// <summary>
            /// Ida-Viru
            /// </summary>
            [AliasInShort("44")]
            [RegionCode(2_00_111_0044)]
            IdaViru,

            /// <summary>
            /// Jõgeva
            /// </summary>
            [AliasInShort("49")]
            [RegionCode(2_00_111_0049)]
            Jõgeva,

            /// <summary>
            /// Järva
            /// </summary>
            [AliasInShort("51")]
            [RegionCode(2_00_111_0051)]
            Järva,

            /// <summary>
            /// Lääne
            /// </summary>
            [AliasInShort("57")]
            [RegionCode(2_00_111_0057)]
            Lääne,

            /// <summary>
            /// Lääne-Viru
            /// </summary>
            [AliasInShort("59")]
            [RegionCode(2_00_111_0059)]
            LääneViru,

            /// <summary>
            /// Põlva
            /// </summary>
            [AliasInShort("65")]
            [RegionCode(2_00_111_0065)]
            Põlva,

            /// <summary>
            /// Pärnu
            /// </summary>
            [AliasInShort("67")]
            [RegionCode(2_00_111_0067)]
            Pärnu,

            /// <summary>
            /// Rapla
            /// </summary>
            [AliasInShort("70")]
            [RegionCode(2_00_111_0070)]
            Rapla,

            /// <summary>
            /// Saare
            /// </summary>
            [AliasInShort("74")]
            [RegionCode(2_00_111_0074)]
            Saare,

            /// <summary>
            /// Tartu
            /// </summary>
            [AliasInShort("78")]
            [RegionCode(2_00_111_0078)]
            Tartu,

            /// <summary>
            /// Valga
            /// </summary>
            [AliasInShort("82")]
            [RegionCode(2_00_111_0082)]
            Valga,

            /// <summary>
            /// Viljandi
            /// </summary>
            [AliasInShort("84")]
            [RegionCode(2_00_111_0084)]
            Viljandi,

            /// <summary>
            /// Võru
            /// </summary>
            [AliasInShort("86")]
            [RegionCode(2_00_111_0084)]
            Võru,

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