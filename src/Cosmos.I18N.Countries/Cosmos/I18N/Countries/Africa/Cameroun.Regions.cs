using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Cameroun Regions
    /// </summary>
    public static partial class Cameroun
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

            /// <summary>
            /// Adamawa
            /// </summary>
            public static EnumValues Adamawa => EnumValues.Adamawa;

            /// <summary>
            /// Centre
            /// </summary>
            public static EnumValues Centre => EnumValues.Centre;

            /// <summary>
            /// Far North
            /// </summary>
            public static EnumValues FarNorth => EnumValues.FarNorth;

            /// <summary>
            /// East
            /// </summary>
            public static EnumValues East => EnumValues.East;

            /// <summary>
            /// Littoral
            /// </summary>
            public static EnumValues Littoral => EnumValues.Littoral;

            /// <summary>
            /// North
            /// </summary>
            public static EnumValues North => EnumValues.North;

            /// <summary>
            /// Northwest
            /// </summary>
            public static EnumValues Northwest => EnumValues.Northwest;

            /// <summary>
            /// West
            /// </summary>
            public static EnumValues West => EnumValues.West;

            /// <summary>
            /// South
            /// </summary>
            public static EnumValues South => EnumValues.South;

            /// <summary>
            /// Southwest
            /// </summary>
            public static EnumValues Southwest => EnumValues.Southwest;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Cameroun regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Adamawa
            /// </summary>
            [AliasInShort("AD")]
            [RegionCode(3_00_108_0001)]
            Adamawa,

            /// <summary>
            /// Centre
            /// </summary>
            [AliasInShort("CE")]
            [RegionCode(3_00_108_0002)]
            Centre,

            /// <summary>
            /// Far North
            /// </summary>
            [AliasInShort("EN")]
            [RegionCode(3_00_108_0003)]
            FarNorth,

            /// <summary>
            /// East
            /// </summary>
            [AliasInShort("ES")]
            [RegionCode(3_00_108_0004)]
            East,

            /// <summary>
            /// Littoral
            /// </summary>
            [AliasInShort("LT")]
            [RegionCode(3_00_108_0005)]
            Littoral,

            /// <summary>
            /// North
            /// </summary>
            [AliasInShort("NO")]
            [RegionCode(3_00_108_0006)]
            North,

            /// <summary>
            /// Northwest
            /// </summary>
            [AliasInShort("NW")]
            [RegionCode(3_00_108_0007)]
            Northwest,

            /// <summary>
            /// West
            /// </summary>
            [AliasInShort("OU")]
            [RegionCode(3_00_108_0008)]
            West,

            /// <summary>
            /// South
            /// </summary>
            [AliasInShort("SU")]
            [RegionCode(3_00_108_0009)]
            South,

            /// <summary>
            /// Southwest
            /// </summary>
            [AliasInShort("SW")]
            [RegionCode(3_00_108_0010)]
            Southwest,

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