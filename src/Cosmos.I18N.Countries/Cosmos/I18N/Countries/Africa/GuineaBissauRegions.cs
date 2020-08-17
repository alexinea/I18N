using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Guinea Bissau regions
    /// </summary>
    public static class GuineaBissauRegions
    {
        #region Gets regions

        /// <summary>
        /// Bissau
        /// </summary>
        public static EnumValues Bissau => EnumValues.Bissau;

        /// <summary>
        /// Leste
        /// </summary>
        public static EnumValues Leste => EnumValues.Leste;

        /// <summary>
        /// Norte
        /// </summary>
        public static EnumValues Norte => EnumValues.Norte;

        /// <summary>
        /// Sul
        /// </summary>
        public static EnumValues Sul => EnumValues.Sul;

        #endregion

        /// <summary>
        /// Enum values for GuineaBissau regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bissau
            /// </summary>
            [AliasInShort("BS")] [RegionCode(3_00_130_0001)]
            Bissau,

            /// <summary>
            /// Leste
            /// </summary>
            [AliasInShort("L")] [RegionCode(3_00_130_0002)]
            Leste,

            /// <summary>
            /// Norte
            /// </summary>
            [AliasInShort("N")] [RegionCode(3_00_130_0003)]
            Norte,

            /// <summary>
            /// Sul
            /// </summary>
            [AliasInShort("S")] [RegionCode(3_00_130_0004)]
            Sul,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GuineaBissauRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GuineaBissauRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"GW-{values.ToRegionCode()}";
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
            return Country.GuineaBissau;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.GW;
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