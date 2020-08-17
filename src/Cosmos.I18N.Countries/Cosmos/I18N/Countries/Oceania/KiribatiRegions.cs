using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Kiribati Regions
    /// </summary>
    public static class KiribatiRegions
    {
        #region Gets regions

        /// <summary>
        /// Gilbert Islands
        /// </summary>
        public static EnumValues GilbertIslands => EnumValues.GilbertIslands;

        /// <summary>
        /// Line Islands
        /// </summary>
        public static EnumValues LineIslands => EnumValues.LineIslands;

        /// <summary>
        /// Phoenix Islands
        /// </summary>
        public static EnumValues PhoenixIslands => EnumValues.PhoenixIslands;

        #endregion

        /// <summary>
        /// Enum values for Kiribati regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Gilbert Islands
            /// </summary>
            [AliasInShort("G")] [RegionCode(6_00_105_0001)]
            GilbertIslands,

            /// <summary>
            /// Line Islands
            /// </summary>
            [AliasInShort("L")] [RegionCode(6_00_105_0002)]
            LineIslands,

            /// <summary>
            /// Phoenix Islands
            /// </summary>
            [AliasInShort("P")] [RegionCode(6_00_105_0003)]
            PhoenixIslands,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="KiribatiRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="KiribatiRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"KI-{values.ToRegionCode()}";
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
            return Country.Kiribati;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.KI;
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