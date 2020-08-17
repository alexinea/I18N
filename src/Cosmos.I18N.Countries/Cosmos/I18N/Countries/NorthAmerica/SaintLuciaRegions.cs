using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// SaintLucia Regions
    /// </summary>
    public static class SaintLuciaRegions
    {
        #region Gets regions

        /// <summary>
        /// Soufrière
        /// </summary>
        public static EnumValues Soufrière => EnumValues.Soufrière;

        /// <summary>
        /// Vieux Fort
        /// </summary>
        public static EnumValues VieuxFort => EnumValues.VieuxFort;

        /// <summary>
        /// Canaries
        /// </summary>
        public static EnumValues Canaries => EnumValues.Canaries;

        /// <summary>
        /// Anse la Raye
        /// </summary>
        public static EnumValues AnseLaRaye => EnumValues.AnseLaRaye;

        /// <summary>
        /// Castries
        /// </summary>
        public static EnumValues Castries => EnumValues.Castries;

        /// <summary>
        /// Choiseul
        /// </summary>
        public static EnumValues Choiseul => EnumValues.Choiseul;

        /// <summary>
        /// Dennery
        /// </summary>
        public static EnumValues Dennery => EnumValues.Dennery;

        /// <summary>
        /// Gros Islet
        /// </summary>
        public static EnumValues GrosIslet => EnumValues.GrosIslet;

        /// <summary>
        /// Laborie
        /// </summary>
        public static EnumValues Laborie => EnumValues.Laborie;

        /// <summary>
        /// Micoud
        /// </summary>
        public static EnumValues Micoud => EnumValues.Micoud;

        #endregion

        /// <summary>
        /// Enum values for SaintLucia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Soufrière
            /// </summary>
            [AliasInShort("10")] [RegionCode(4_00_129_0010)]
            Soufrière,

            /// <summary>
            /// Vieux Fort
            /// </summary>
            [AliasInShort("11")] [RegionCode(4_00_129_0011)]
            VieuxFort,

            /// <summary>
            /// Canaries
            /// </summary>
            [AliasInShort("12")] [RegionCode(4_00_129_0012)]
            Canaries,

            /// <summary>
            /// Anse la Raye
            /// </summary>
            [AliasInShort("01")] [RegionCode(4_00_129_0001)]
            AnseLaRaye,

            /// <summary>
            /// Castries
            /// </summary>
            [AliasInShort("02")] [RegionCode(4_00_129_0002)]
            Castries,

            /// <summary>
            /// Choiseul
            /// </summary>
            [AliasInShort("03")] [RegionCode(4_00_129_0003)]
            Choiseul,

            /// <summary>
            /// Dennery
            /// </summary>
            [AliasInShort("05")] [RegionCode(4_00_129_0005)]
            Dennery,

            /// <summary>
            /// Gros Islet
            /// </summary>
            [AliasInShort("06")] [RegionCode(4_00_129_0006)]
            GrosIslet,

            /// <summary>
            /// Laborie
            /// </summary>
            [AliasInShort("07")] [RegionCode(4_00_129_0007)]
            Laborie,

            /// <summary>
            /// Micoud
            /// </summary>
            [AliasInShort("08")] [RegionCode(4_00_129_0008)]
            Micoud,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SaintLuciaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SaintLuciaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CL-{values.ToRegionCode()}";
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
            return Country.SaintLucia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.LC;
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