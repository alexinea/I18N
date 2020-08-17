using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Senegal regons
    /// </summary>
    public static class SenegalRegions
    {
        #region Gets regions

        /// <summary>
        /// Diourbel
        /// </summary>
        public static EnumValues Diourbel => EnumValues.Diourbel;

        /// <summary>
        /// Dakar
        /// </summary>
        public static EnumValues Dakar => EnumValues.Dakar;

        /// <summary>
        /// Fatick
        /// </summary>
        public static EnumValues Fatick => EnumValues.Fatick;

        /// <summary>
        /// Kaffrine
        /// </summary>
        public static EnumValues Kaffrine => EnumValues.Kaffrine;

        /// <summary>
        /// Kolda
        /// </summary>
        public static EnumValues Kolda => EnumValues.Kolda;

        /// <summary>
        /// Kédougou
        /// </summary>
        public static EnumValues Kédougou => EnumValues.Kédougou;

        /// <summary>
        /// Kaolack
        /// </summary>
        public static EnumValues Kaolack => EnumValues.Kaolack;

        /// <summary>
        /// Louga
        /// </summary>
        public static EnumValues Louga => EnumValues.Louga;

        /// <summary>
        /// Matam
        /// </summary>
        public static EnumValues Matam => EnumValues.Matam;

        /// <summary>
        /// Sédhiou
        /// </summary>
        public static EnumValues Sédhiou => EnumValues.Sédhiou;

        /// <summary>
        /// Saint-Louis
        /// </summary>
        public static EnumValues SaintLouis => EnumValues.SaintLouis;

        /// <summary>
        /// Tambacounda
        /// </summary>
        public static EnumValues Tambacounda => EnumValues.Tambacounda;

        /// <summary>
        /// Thiès
        /// </summary>
        public static EnumValues Thiès => EnumValues.Thiès;

        /// <summary>
        /// Ziguinchor
        /// </summary>
        public static EnumValues Ziguinchor => EnumValues.Ziguinchor;

        #endregion

        /// <summary>
        /// Enum values for Senegal regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Diourbel
            /// </summary>
            [AliasInShort("DB")][RegionCode(3_00_151_0001)] Diourbel,

            /// <summary>
            /// Dakar
            /// </summary>
            [AliasInShort("DK")][RegionCode(3_00_151_0002)] Dakar,

            /// <summary>
            /// Fatick
            /// </summary>
            [AliasInShort("FK")][RegionCode(3_00_151_0003)] Fatick,

            /// <summary>
            /// Kaffrine
            /// </summary>
            [AliasInShort("KA")][RegionCode(3_00_151_0004)] Kaffrine,

            /// <summary>
            /// Kolda
            /// </summary>
            [AliasInShort("KD")][RegionCode(3_00_151_0005)] Kolda,

            /// <summary>
            /// Kédougou
            /// </summary>
            [AliasInShort("KE")][RegionCode(3_00_151_0006)] Kédougou,

            /// <summary>
            /// Kaolack
            /// </summary>
            [AliasInShort("KL")][RegionCode(3_00_151_0007)] Kaolack,

            /// <summary>
            /// Louga
            /// </summary>
            [AliasInShort("LG")][RegionCode(3_00_151_0008)] Louga,

            /// <summary>
            /// Matam
            /// </summary>
            [AliasInShort("ML")][RegionCode(3_00_151_0009)] Matam,

            /// <summary>
            /// Sédhiou
            /// </summary>
            [AliasInShort("SE")][RegionCode(3_00_151_0010)] Sédhiou,

            /// <summary>
            /// Saint-Louis
            /// </summary>
            [AliasInShort("SL")][RegionCode(3_00_151_0011)] SaintLouis,

            /// <summary>
            /// Tambacounda
            /// </summary>
            [AliasInShort("TC")][RegionCode(3_00_151_0012)] Tambacounda,

            /// <summary>
            /// Thiès
            /// </summary>
            [AliasInShort("TH")][RegionCode(3_00_151_0013)] Thiès,

            /// <summary>
            /// Ziguinchor
            /// </summary>
            [AliasInShort("ZG")][RegionCode(3_00_151_0014)] Ziguinchor,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SenegalRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SenegalRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"SN-{values.ToRegionCode()}";
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
            return Country.Senegal;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.SN;
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