using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Cameroun Regions
    /// </summary>
    public static class CamerounRegions
    {
        #region Gets regions

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

        #endregion

        /// <summary>
        /// Enum values for Cameroun regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Adamawa
            /// </summary>
            [AliasInShort("AD")] [RegionCode(3_00_108_0001)]
            Adamawa,

            /// <summary>
            /// Centre
            /// </summary>
            [AliasInShort("CE")] [RegionCode(3_00_108_0002)]
            Centre,

            /// <summary>
            /// Far North
            /// </summary>
            [AliasInShort("EN")] [RegionCode(3_00_108_0003)]
            FarNorth,

            /// <summary>
            /// East
            /// </summary>
            [AliasInShort("ES")] [RegionCode(3_00_108_0004)]
            East,

            /// <summary>
            /// Littoral
            /// </summary>
            [AliasInShort("LT")] [RegionCode(3_00_108_0005)]
            Littoral,

            /// <summary>
            /// North
            /// </summary>
            [AliasInShort("NO")] [RegionCode(3_00_108_0006)]
            North,

            /// <summary>
            /// Northwest
            /// </summary>
            [AliasInShort("NW")] [RegionCode(3_00_108_0007)]
            Northwest,

            /// <summary>
            /// West
            /// </summary>
            [AliasInShort("OU")] [RegionCode(3_00_108_0008)]
            West,

            /// <summary>
            /// South
            /// </summary>
            [AliasInShort("SU")] [RegionCode(3_00_108_0009)]
            South,

            /// <summary>
            /// Southwest
            /// </summary>
            [AliasInShort("SW")] [RegionCode(3_00_108_0010)]
            Southwest,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CamerounRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CamerounRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CM-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Get CEP-1 / Cosmos Region Code.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static long ToNumericRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, RegionCodeAttribute>().CRCode;
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Cameroun;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CM;
        }

        #endregion

        #region Getters

        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(member => !member.HasAttr<EnumValues, IgnoreRegionAttribute>());

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