using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Antigua And Barbuda regions
    /// </summary>
    public static class AntiguaAndBarbudaRegions
    {
        #region Gets region

        /// <summary>
        /// Saint George
        /// </summary>
        public static EnumValues SaintGeorge => EnumValues.SaintGeorge;

        /// <summary>
        /// Saint John
        /// </summary>
        public static EnumValues SaintJohn => EnumValues.SaintJohn;

        /// <summary>
        /// Saint Mary
        /// </summary>
        public static EnumValues SaintMary => EnumValues.SaintMary;

        /// <summary>
        /// Saint Paul
        /// </summary>
        public static EnumValues SaintPaul => EnumValues.SaintPaul;

        /// <summary>
        /// Saint Peter
        /// </summary>
        public static EnumValues SaintPeter => EnumValues.SaintPeter;

        /// <summary>
        /// Saint Philip
        /// </summary>
        public static EnumValues SaintPhilip => EnumValues.SaintPhilip;

        /// <summary>
        /// Barbuda
        /// </summary>
        public static EnumValues Barbuda => EnumValues.Barbuda;

        /// <summary>
        /// Redonda
        /// </summary>
        public static EnumValues Redonda => EnumValues.Redonda;

        #endregion

        /// <summary>
        /// Enum values for Antigua And Barbuda regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Saint George
            /// </summary>
            [AliasInShort("3")] [RegionCode(4_00_103_0003)]
            SaintGeorge,

            /// <summary>
            /// Saint John
            /// </summary>
            [AliasInShort("4")] [RegionCode(4_00_103_0004)]
            SaintJohn,

            /// <summary>
            /// Saint Mary
            /// </summary>
            [AliasInShort("5")] [RegionCode(4_00_103_0005)]
            SaintMary,

            /// <summary>
            /// Saint Paul
            /// </summary>
            [AliasInShort("6")] [RegionCode(4_00_103_0006)]
            SaintPaul,

            /// <summary>
            /// Saint Peter
            /// </summary>
            [AliasInShort("7")] [RegionCode(4_00_103_0007)]
            SaintPeter,

            /// <summary>
            /// Saint Philip
            /// </summary>
            [AliasInShort("8")] [RegionCode(4_00_103_0008)]
            SaintPhilip,

            /// <summary>
            /// Barbuda
            /// </summary>
            [AliasInShort("10")] [RegionCode(4_00_103_0010)]
            Barbuda,

            /// <summary>
            /// Redonda
            /// </summary>
            [AliasInShort("11")] [RegionCode(4_00_103_0011)]
            Redonda,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="AntiguaAndBarbudaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="AntiguaAndBarbudaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"AG-{values.ToRegionCode()}";
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
            return Country.AntiguaAndBarbuda;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.AG;
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