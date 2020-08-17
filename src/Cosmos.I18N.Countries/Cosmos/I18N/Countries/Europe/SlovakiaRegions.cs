using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using Cosmos.I18N.Countries.Oceania;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Slovakia Regions
    /// </summary>
    public static class SlovakiaRegions
    {
        #region Gets regions

        /// <summary>
        /// Banská Bystrica
        /// </summary>
        public static EnumValues BanskáBystrica => EnumValues.BanskáBystrica;

        /// <summary>
        /// Bratislava
        /// </summary>
        public static EnumValues Bratislava => EnumValues.Bratislava;

        /// <summary>
        /// Košice
        /// </summary>
        public static EnumValues Košice => EnumValues.Košice;

        /// <summary>
        /// Nitra
        /// </summary>
        public static EnumValues Nitra => EnumValues.Nitra;

        /// <summary>
        /// Prešov
        /// </summary>
        public static EnumValues Prešov => EnumValues.Prešov;

        /// <summary>
        /// Trnava
        /// </summary>
        public static EnumValues Trnava => EnumValues.Trnava;

        /// <summary>
        /// Trenčín
        /// </summary>
        public static EnumValues Trenčín => EnumValues.Trenčín;

        /// <summary>
        /// Žilina
        /// </summary>
        public static EnumValues Žilina => EnumValues.Žilina;

        /// <summary>
        /// Žilina
        /// </summary>
        public static EnumValues Zilina => EnumValues.Žilina;

        #endregion

        /// <summary>
        /// Enum values for Tonga regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Banská Bystrica
            /// </summary>
            [AliasInShort("BC")] [RegionCode(2_00_137_0001)]
            BanskáBystrica,

            /// <summary>
            /// Bratislava
            /// </summary>
            [AliasInShort("BL")] [RegionCode(2_00_137_0002)]
            Bratislava,

            /// <summary>
            /// Košice
            /// </summary>
            [AliasInShort("KI")] [RegionCode(2_00_137_0003)]
            Košice,

            /// <summary>
            /// Nitra
            /// </summary>
            [AliasInShort("NI")] [RegionCode(2_00_137_0004)]
            Nitra,

            /// <summary>
            /// Prešov
            /// </summary>
            [AliasInShort("PV")] [RegionCode(2_00_137_0005)]
            Prešov,

            /// <summary>
            /// Trnava
            /// </summary>
            [AliasInShort("TA")] [RegionCode(2_00_137_0006)]
            Trnava,

            /// <summary>
            /// Trenčín
            /// </summary>
            [AliasInShort("TC")] [RegionCode(2_00_137_0007)]
            Trenčín,

            /// <summary>
            /// Žilina
            /// </summary>
            [AliasInShort("ZI")] [RegionCode(2_00_137_0008)]
            Žilina,

            /// <summary>
            /// Unknown<br />未知
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SlovakiaRegions.EnumValues"/> to region code likes 'ZI'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SlovakiaRegions.EnumValues"/> to full region code likes 'SK-ZI'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"SK-{values.ToRegionCode()}";
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
            return Country.Slovakia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.SK;
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