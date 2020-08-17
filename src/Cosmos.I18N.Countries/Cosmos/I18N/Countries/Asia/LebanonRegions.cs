using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Lebanon regions
    /// </summary>
    public static class LebanonRegions
    {
        #region Gets regions

        /// <summary>
        /// Akkar
        /// </summary>
        public static EnumValues Akkar => EnumValues.Akkar;

        /// <summary>
        /// North
        /// </summary>
        public static EnumValues North => EnumValues.North;

        /// <summary>
        /// Beirut
        /// </summary>
        public static EnumValues Beirut => EnumValues.Beirut;

        /// <summary>
        /// Baalbek-Hermel
        /// </summary>
        public static EnumValues BaalbekHermel => EnumValues.BaalbekHermel;

        /// <summary>
        /// Beqaa
        /// </summary>
        public static EnumValues Beqaa => EnumValues.Beqaa;

        /// <summary>
        /// South
        /// </summary>
        public static EnumValues South => EnumValues.South;

        /// <summary>
        /// Mount Lebanon
        /// </summary>
        public static EnumValues MountLebanon => EnumValues.MountLebanon;

        /// <summary>
        /// Nabatieh
        /// </summary>
        public static EnumValues Nabatieh => EnumValues.Nabatieh;

        #endregion

        /// <summary>
        /// Enum values for Lebanon regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Akkar
            /// </summary>
            [AliasInShort("AK")][RegionCode(1_00_123_0001)] Akkar,

            /// <summary>
            /// North
            /// </summary>
            [AliasInShort("AS")][RegionCode(1_00_123_0002)] North,

            /// <summary>
            /// Beirut
            /// </summary>
            [AliasInShort("BA")][RegionCode(1_00_123_0003)] Beirut,

            /// <summary>
            /// Baalbek-Hermel
            /// </summary>
            [AliasInShort("BH")][RegionCode(1_00_123_0004)] BaalbekHermel,

            /// <summary>
            /// Beqaa
            /// </summary>
            [AliasInShort("BI")][RegionCode(1_00_123_0005)] Beqaa,

            /// <summary>
            /// South
            /// </summary>
            [AliasInShort("JA")][RegionCode(1_00_123_0006)] South,

            /// <summary>
            /// Mount Lebanon
            /// </summary>
            [AliasInShort("JL")][RegionCode(1_00_123_0007)] MountLebanon,

            /// <summary>
            /// Nabatieh
            /// </summary>
            [AliasInShort("NA")][RegionCode(1_00_123_0008)] Nabatieh,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="LebanonRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="LebanonRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"LB-{values.ToRegionCode()}";
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
            return Country.Lebanon;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.LB;
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