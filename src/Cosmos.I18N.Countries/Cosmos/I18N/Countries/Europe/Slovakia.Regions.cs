using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using Cosmos.I18N.Countries.Oceania;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Slovakia Regions
    /// </summary>
    public static partial class Slovakia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Banská Bystrica
            /// </summary>
            public static EnumValues BanskáBystrica => EnumValues.BanskáBystrica;

            /// <summary>
            /// Bratislava
            /// </summary>
            public static EnumValues Bratislava => EnumValues.Bratislava;

            /// <summary>
            /// Košice
            /// </summary>
            public static EnumValues Košice => EnumValues.Košice;

            /// <summary>
            /// Nitra
            /// </summary>
            public static EnumValues Nitra => EnumValues.Nitra;

            /// <summary>
            /// Prešov
            /// </summary>
            public static EnumValues Prešov => EnumValues.Prešov;

            /// <summary>
            /// Trnava
            /// </summary>
            public static EnumValues Trnava => EnumValues.Trnava;

            /// <summary>
            /// Trenčín
            /// </summary>
            public static EnumValues Trenčín => EnumValues.Trenčín;

            /// <summary>
            /// Žilina
            /// </summary>
            public static EnumValues Žilina => EnumValues.Žilina;

            /// <summary>
            /// Žilina
            /// </summary>
            public static EnumValues Zilina => EnumValues.Žilina;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Tonga regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Banská Bystrica
            /// </summary>
            [AliasInShort("BC")]
            [RegionCode(2_00_137_0001)]
            BanskáBystrica,

            /// <summary>
            /// Bratislava
            /// </summary>
            [AliasInShort("BL")]
            [RegionCode(2_00_137_0002)]
            Bratislava,

            /// <summary>
            /// Košice
            /// </summary>
            [AliasInShort("KI")]
            [RegionCode(2_00_137_0003)]
            Košice,

            /// <summary>
            /// Nitra
            /// </summary>
            [AliasInShort("NI")]
            [RegionCode(2_00_137_0004)]
            Nitra,

            /// <summary>
            /// Prešov
            /// </summary>
            [AliasInShort("PV")]
            [RegionCode(2_00_137_0005)]
            Prešov,

            /// <summary>
            /// Trnava
            /// </summary>
            [AliasInShort("TA")]
            [RegionCode(2_00_137_0006)]
            Trnava,

            /// <summary>
            /// Trenčín
            /// </summary>
            [AliasInShort("TC")]
            [RegionCode(2_00_137_0007)]
            Trenčín,

            /// <summary>
            /// Žilina
            /// </summary>
            [AliasInShort("ZI")]
            [RegionCode(2_00_137_0008)]
            Žilina,

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