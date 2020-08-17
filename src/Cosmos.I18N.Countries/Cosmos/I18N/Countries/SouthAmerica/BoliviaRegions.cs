using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// Bolivia regions
    /// </summary>
    public static class BoliviaRegions
    {
        #region Gets region

        /// <summary>
        /// Beni
        /// </summary>
        public static EnumValues Beni => EnumValues.Beni;

        /// <summary>
        /// Cochabamba
        /// </summary>
        public static EnumValues Cochabamba => EnumValues.Cochabamba;

        /// <summary>
        /// Chuquisaca
        /// </summary>
        public static EnumValues Chuquisaca => EnumValues.Chuquisaca;

        /// <summary>
        /// La Paz
        /// </summary>
        public static EnumValues LaPaz => EnumValues.LaPaz;

        /// <summary>
        /// Pando
        /// </summary>
        public static EnumValues Pando => EnumValues.Pando;

        /// <summary>
        /// Oruro
        /// </summary>
        public static EnumValues Oruro => EnumValues.Oruro;

        /// <summary>
        /// Potosí
        /// </summary>
        public static EnumValues Potosí => EnumValues.Potosí;

        /// <summary>
        /// Santa Cruz
        /// </summary>
        public static EnumValues SantaCruz => EnumValues.SantaCruz;

        /// <summary>
        /// Tarija
        /// </summary>
        public static EnumValues Tarija => EnumValues.Tarija;

        #endregion

        /// <summary>
        /// Enum values for Bolivia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Beni
            /// </summary>
            [AliasInShort("B")] [RegionCode(5_00_101_0001)]
            Beni,

            /// <summary>
            /// Cochabamba
            /// </summary>
            [AliasInShort("C")] [RegionCode(5_00_101_0002)]
            Cochabamba,

            /// <summary>
            /// Chuquisaca
            /// </summary>
            [AliasInShort("H")] [RegionCode(5_00_101_0003)]
            Chuquisaca,

            /// <summary>
            /// La Paz
            /// </summary>
            [AliasInShort("L")] [RegionCode(5_00_101_0004)]
            LaPaz,

            /// <summary>
            /// Pando
            /// </summary>
            [AliasInShort("N")] [RegionCode(5_00_101_0005)]
            Pando,

            /// <summary>
            /// Oruro
            /// </summary>
            [AliasInShort("O")] [RegionCode(5_00_101_0006)]
            Oruro,

            /// <summary>
            /// Potosí
            /// </summary>
            [AliasInShort("P")] [RegionCode(5_00_101_0007)]
            Potosí,

            /// <summary>
            /// Santa Cruz
            /// </summary>
            [AliasInShort("S")] [RegionCode(5_00_101_0008)]
            SantaCruz,

            /// <summary>
            /// Tarija
            /// </summary>
            [AliasInShort("T")] [RegionCode(5_00_101_0009)]
            Tarija,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BoliviaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BoliviaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"BO-{values.ToRegionCode()}";
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
            return Country.Bolivia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.BO;
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