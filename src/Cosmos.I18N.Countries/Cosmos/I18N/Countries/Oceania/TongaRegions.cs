using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Tonga regions
    /// </summary>
    public static class TongaRegions
    {
        #region Gets region

        /// <summary>
        /// ʻEua
        /// </summary>
        /// <returns></returns>
        public static EnumValues Eua => EnumValues.Eua;

        /// <summary>
        /// Haʻapai
        /// </summary>
        public static EnumValues HaApai => EnumValues.HaApai;

        /// <summary>
        /// Niuas
        /// </summary>
        public static EnumValues Niuas => EnumValues.Niuas;

        /// <summary>
        /// Tongatapu
        /// </summary>
        public static EnumValues Tongatapu => EnumValues.Tongatapu;

        /// <summary>
        /// Vavaʻu
        /// </summary>
        public static EnumValues VavaU => EnumValues.VavaU;

        #endregion

        /// <summary>
        /// Enum values for Tonga regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// ʻEua
            /// </summary>
            [AliasInShort("01")] [RegionCode(6_00_121_0001)]
            Eua,

            /// <summary>
            /// Haʻapai
            /// </summary>
            [AliasInShort("02")] [RegionCode(6_00_121_0002)]
            HaApai,

            /// <summary>
            /// Niuas
            /// </summary>
            [AliasInShort("03")] [RegionCode(6_00_121_0003)]
            Niuas,

            /// <summary>
            /// Tongatapu
            /// </summary>
            [AliasInShort("04")] [RegionCode(6_00_121_0004)]
            Tongatapu,

            /// <summary>
            /// Vavaʻu
            /// </summary>
            [AliasInShort("05")] [RegionCode(6_00_121_0005)]
            VavaU,

            /// <summary>
            /// Unknown<br />未知
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="TongaRegions.EnumValues"/> to region code likes 'MAP'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="TongaRegions.EnumValues"/> to full region code likes 'VU-MAP'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"TO-{values.ToRegionCode()}";
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
            return Country.Tonga;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.TO;
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