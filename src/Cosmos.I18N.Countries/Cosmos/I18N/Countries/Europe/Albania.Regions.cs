using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Albania regions
    /// </summary>
    public static partial class Albania
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Berat 
            /// </summary>
            public static EnumValues Berat => EnumValues.Berat;

            /// <summary>
            /// Durrës 
            /// </summary>
            public static EnumValues Durrës => EnumValues.Durrës;

            /// <summary>
            /// Elbasan 
            /// </summary>
            public static EnumValues Elbasan => EnumValues.Elbasan;

            /// <summary>
            /// Fier 
            /// </summary>
            public static EnumValues Fier => EnumValues.Fier;

            /// <summary>
            /// Gjirokastër 
            /// </summary>
            public static EnumValues Gjirokastër => EnumValues.Gjirokastër;

            /// <summary>
            /// Korçë 
            /// </summary>
            public static EnumValues Korçë => EnumValues.Korçë;

            /// <summary>
            /// Kukës 
            /// </summary>
            public static EnumValues Kukës => EnumValues.Kukës;

            /// <summary>
            /// Lezhë 
            /// </summary>
            public static EnumValues Lezhë => EnumValues.Lezhë;

            /// <summary>
            /// Dibër 
            /// </summary>
            public static EnumValues Dibër => EnumValues.Dibër;

            /// <summary>
            /// Shkodër 
            /// </summary>
            public static EnumValues Shkodër => EnumValues.Shkodër;

            /// <summary>
            /// Tirana 
            /// </summary>
            public static EnumValues Tirana => EnumValues.Tirana;

            /// <summary>
            /// Vlorë 
            /// </summary>
            public static EnumValues Vlorë => EnumValues.Vlorë;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Albania regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Berat 
            /// </summary>
            [AliasInShort("1")]
            [RegionCode(2_00_102_0001)]
            Berat,

            /// <summary>
            /// Durrës 
            /// </summary>
            [AliasInShort("2")]
            [RegionCode(2_00_102_0002)]
            Durrës,

            /// <summary>
            /// Elbasan 
            /// </summary>
            [AliasInShort("3")]
            [RegionCode(2_00_102_0003)]
            Elbasan,

            /// <summary>
            /// Fier 
            /// </summary>
            [AliasInShort("4")]
            [RegionCode(2_00_102_0004)]
            Fier,

            /// <summary>
            /// Gjirokastër 
            /// </summary>
            [AliasInShort("5")]
            [RegionCode(2_00_102_0005)]
            Gjirokastër,

            /// <summary>
            /// Korçë 
            /// </summary>
            [AliasInShort("6")]
            [RegionCode(2_00_102_0006)]
            Korçë,

            /// <summary>
            /// Kukës 
            /// </summary>
            [AliasInShort("7")]
            [RegionCode(2_00_102_0007)]
            Kukës,

            /// <summary>
            /// Lezhë 
            /// </summary>
            [AliasInShort("8")]
            [RegionCode(2_00_102_0008)]
            Lezhë,

            /// <summary>
            /// Dibër 
            /// </summary>
            [AliasInShort("9")]
            [RegionCode(2_00_102_0009)]
            Dibër,

            /// <summary>
            /// Shkodër 
            /// </summary>
            [AliasInShort("10")]
            [RegionCode(2_00_102_0010)]
            Shkodër,

            /// <summary>
            /// Tirana 
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(2_00_102_0011)]
            Tirana,

            /// <summary>
            /// Vlorë 
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(2_00_102_0012)]
            Vlorë,

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