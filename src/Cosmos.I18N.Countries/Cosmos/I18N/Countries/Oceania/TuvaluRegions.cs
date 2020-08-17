using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Tuvalu Regions
    /// </summary>
    public static class TuvaluRegions
    {
        #region Gets regions

        /// <summary>
        /// Funafuti
        /// </summary>
        public static EnumValues Funafuti => EnumValues.Funafuti;

        /// <summary>
        /// Niutao
        /// </summary>
        public static EnumValues Niutao => EnumValues.Niutao;

        /// <summary>
        /// Nukufetau
        /// </summary>
        public static EnumValues Nukufetau => EnumValues.Nukufetau;

        /// <summary>
        /// Nukulaelae
        /// </summary>
        public static EnumValues Nukulaelae => EnumValues.Nukulaelae;

        /// <summary>
        /// Nanumea
        /// </summary>
        public static EnumValues Nanumea => EnumValues.Nanumea;

        /// <summary>
        /// Nanumanga
        /// </summary>
        public static EnumValues Nanumanga => EnumValues.Nanumanga;

        /// <summary>
        /// Nui
        /// </summary>
        public static EnumValues Nui => EnumValues.Nui;

        /// <summary>
        /// Vaitupu
        /// </summary>
        public static EnumValues Vaitupu => EnumValues.Vaitupu;

        #endregion

        /// <summary>
        /// Enum values for Tuvalu regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Funafuti
            /// </summary>
            [AliasInShort("FUN")] [RegionCode(6_00_122_0001)]
            Funafuti,

            /// <summary>
            /// Niutao
            /// </summary>
            [AliasInShort("NIT")] [RegionCode(6_00_122_0002)]
            Niutao,

            /// <summary>
            /// Nukufetau
            /// </summary>
            [AliasInShort("NKF")] [RegionCode(6_00_122_0003)]
            Nukufetau,

            /// <summary>
            /// Nukulaelae
            /// </summary>
            [AliasInShort("NKL")] [RegionCode(6_00_122_0004)]
            Nukulaelae,

            /// <summary>
            /// Nanumea
            /// </summary>
            [AliasInShort("NMA")] [RegionCode(6_00_122_0005)]
            Nanumea,

            /// <summary>
            /// Nanumanga
            /// </summary>
            [AliasInShort("NMG")] [RegionCode(6_00_122_0006)]
            Nanumanga,

            /// <summary>
            /// Nui
            /// </summary>
            [AliasInShort("NUI")] [RegionCode(6_00_122_0007)]
            Nui,

            /// <summary>
            /// Vaitupu
            /// </summary>
            [AliasInShort("VAI")] [RegionCode(6_00_122_0008)]
            Vaitupu,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="TuvaluRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="TuvaluRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"TV-{values.ToRegionCode()}";
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
            return Country.Tuvalu;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.TV;
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