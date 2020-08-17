using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Guinea Regions
    /// </summary>
    public static class GuineaRegions
    {
        #region Gets regions

        /// <summary>
        /// Boké Region
        /// </summary>
        public static EnumValues BokéRegion => EnumValues.BokéRegion;

        /// <summary>
        /// Conakry
        /// </summary>
        public static EnumValues Conakry => EnumValues.Conakry;

        /// <summary>
        /// Kindia Region
        /// </summary>
        public static EnumValues KindiaRegion => EnumValues.KindiaRegion;

        /// <summary>
        /// Faranah Region
        /// </summary>
        public static EnumValues FaranahRegion => EnumValues.FaranahRegion;

        /// <summary>
        /// Kankan Region
        /// </summary>
        public static EnumValues KankanRegion => EnumValues.KankanRegion;

        /// <summary>
        /// Labé Region
        /// </summary>
        public static EnumValues LabéRegion => EnumValues.LabéRegion;

        /// <summary>
        /// Ogooué-Lolo
        /// </summary>
        public static EnumValues MamouRegion => EnumValues.MamouRegion;

        /// <summary>
        /// Nzérékoré Region
        /// </summary>
        public static EnumValues NzérékoréRegion => EnumValues.NzérékoréRegion;

        #endregion

        /// <summary>
        /// Enum values for Guinea regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Boké Region
            /// </summary>
            [AliasInShort("B")][RegionCode(3_00_129_0001)] BokéRegion,

            /// <summary>
            /// Conakry
            /// </summary>
            [AliasInShort("C")][RegionCode(3_00_129_0002)] Conakry,

            /// <summary>
            /// Kindia Region
            /// </summary>
            [AliasInShort("D")][RegionCode(3_00_129_0003)] KindiaRegion,

            /// <summary>
            /// Faranah Region
            /// </summary>
            [AliasInShort("F")][RegionCode(3_00_129_0004)] FaranahRegion,

            /// <summary>
            /// Kankan Region
            /// </summary>
            [AliasInShort("K")][RegionCode(3_00_129_0005)] KankanRegion,

            /// <summary>
            /// Labé Region
            /// </summary>
            [AliasInShort("L")][RegionCode(3_00_129_0006)] LabéRegion,

            /// <summary>
            /// Mamou Region
            /// </summary>
            [AliasInShort("M")][RegionCode(3_00_129_0007)] MamouRegion,

            /// <summary>
            /// Nzérékoré Region
            /// </summary>
            [AliasInShort("N")][RegionCode(3_00_129_0008)] NzérékoréRegion,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GuineaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GuineaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"GN-{values.ToRegionCode()}";
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
            return Country.Guinea;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.GN;
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