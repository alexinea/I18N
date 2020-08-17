using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Samoa regions
    /// </summary>
    public static class SamoaRegions
    {
        #region Gets regions

        /// <summary>
        /// A’ana
        /// </summary>
        public static EnumValues Aana => EnumValues.Aana;

        /// <summary>
        /// Aiga-i-le-Tai
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public static EnumValues Aiga_i_le_Tai => EnumValues.Aiga_i_le_Tai;

        /// <summary>
        /// Atua
        /// </summary>
        public static EnumValues Atua => EnumValues.Atua;

        /// <summary>
        /// Fa’asaleleaga
        /// </summary>
        public static EnumValues FaAsaleleaga => EnumValues.FaAsaleleaga;

        /// <summary>
        /// Gaga’emauga
        /// </summary>
        public static EnumValues GagaEmauga => EnumValues.GagaEmauga;

        /// <summary>
        /// Gaga’ifomauga
        /// </summary>
        public static EnumValues GagaIfomauga => EnumValues.GagaIfomauga;

        /// <summary>
        /// Palauli
        /// </summary>
        public static EnumValues Palauli => EnumValues.Palauli;

        /// <summary>
        /// Satupa’itea
        /// </summary>
        public static EnumValues SatupaItea => EnumValues.SatupaItea;

        /// <summary>
        /// Tuamasaga
        /// </summary>
        public static EnumValues Tuamasaga => EnumValues.Tuamasaga;

        /// <summary>
        /// Va’a-o-Fonoti
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public static EnumValues VaA_o_Fonoti => EnumValues.VaA_o_Fonoti;

        /// <summary>
        /// Vaisigano
        /// </summary>
        public static EnumValues Vaisigano => EnumValues.Vaisigano;

        #endregion

        /// <summary>
        /// Enum values for Samoa regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// A’ana
            /// </summary>
            [AliasInShort("AA")] [RegionCode(6_00_118_0001)]
            Aana,

            /// <summary>
            /// Aiga-i-le-Tai
            /// </summary>
            [AliasInShort("AL")] [RegionCode(6_00_118_0002)]
            // ReSharper disable once InconsistentNaming
            Aiga_i_le_Tai,

            /// <summary>
            /// Atua
            /// </summary>
            [AliasInShort("AT")] [RegionCode(6_00_118_0003)]
            Atua,

            /// <summary>
            /// Fa’asaleleaga
            /// </summary>
            [AliasInShort("FA")] [RegionCode(6_00_118_0004)]
            FaAsaleleaga,

            /// <summary>
            /// Gaga’emauga
            /// </summary>
            [AliasInShort("GE")] [RegionCode(6_00_118_0005)]
            GagaEmauga,

            /// <summary>
            /// Gaga’ifomauga
            /// </summary>
            [AliasInShort("GI")] [RegionCode(6_00_118_0006)]
            GagaIfomauga,

            /// <summary>
            /// Palauli
            /// </summary>
            [AliasInShort("PA")] [RegionCode(6_00_118_0007)]
            Palauli,

            /// <summary>
            /// Satupa’itea
            /// </summary>
            [AliasInShort("SA")] [RegionCode(6_00_118_0008)]
            SatupaItea,

            /// <summary>
            /// Tuamasaga
            /// </summary>
            [AliasInShort("TU")] [RegionCode(6_00_118_0009)]
            Tuamasaga,

            /// <summary>
            /// Va’a-o-Fonoti
            /// </summary>
            [AliasInShort("VF")] [RegionCode(6_00_118_0010)]
            // ReSharper disable once InconsistentNaming
            VaA_o_Fonoti,

            /// <summary>
            /// Vaisigano
            /// </summary>
            [AliasInShort("VS")] [RegionCode(6_00_118_0011)]
            Vaisigano,

            /// <summary>
            /// Unknown<br />未知
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SamoaRegions.EnumValues"/> to region code likes 'TW', 'SH'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SamoaRegions.EnumValues"/> to full region code likes 'CN-TW', 'CN-SH'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"WS-{values.ToRegionCode()}";
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
            return Country.Samoa;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.WS;
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