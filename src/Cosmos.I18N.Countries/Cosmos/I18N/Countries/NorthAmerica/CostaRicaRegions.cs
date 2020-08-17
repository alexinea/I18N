using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// CostaRica regions
    /// </summary>
    public static class CostaRicaRegions
    {
        #region Gets regions

        /// <summary>
        /// Alajuela
        /// </summary>
        public static EnumValues Alajuela => EnumValues.Alajuela;

        /// <summary>
        /// Cartago
        /// </summary>
        public static EnumValues Cartago => EnumValues.Cartago;

        /// <summary>
        /// Guanacaste
        /// </summary>
        public static EnumValues Guanacaste => EnumValues.Guanacaste;

        /// <summary>
        /// Heredia
        /// </summary>
        public static EnumValues Heredia => EnumValues.Heredia;

        /// <summary>
        /// Limón
        /// </summary>
        public static EnumValues Limón => EnumValues.Limón;

        /// <summary>
        /// Puntarenas
        /// </summary>
        public static EnumValues Puntarenas => EnumValues.Puntarenas;

        /// <summary>
        /// San José
        /// </summary>
        public static EnumValues SanJosé => EnumValues.SanJosé;

        #endregion

        /// <summary>
        /// Enum values for CostaRica regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Alajuela
            /// </summary>
            [AliasInShort("A")] [RegionCode(4_00_111_0001)]
            Alajuela,

            /// <summary>
            /// Cartago
            /// </summary>
            [AliasInShort("C")] [RegionCode(4_00_111_0002)]
            Cartago,

            /// <summary>
            /// Guanacaste
            /// </summary>
            [AliasInShort("G")] [RegionCode(4_00_111_0003)]
            Guanacaste,

            /// <summary>
            /// Heredia
            /// </summary>
            [AliasInShort("H")] [RegionCode(4_00_111_0004)]
            Heredia,

            /// <summary>
            /// Limón
            /// </summary>
            [AliasInShort("L")] [RegionCode(4_00_111_0005)]
            Limón,

            /// <summary>
            /// Puntarenas
            /// </summary>
            [AliasInShort("P")] [RegionCode(4_00_111_0006)]
            Puntarenas,

            /// <summary>
            /// San José
            /// </summary>
            [AliasInShort("SJ")] [RegionCode(4_00_111_0007)]
            SanJosé,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CostaRicaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CostaRicaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CR-{values.ToRegionCode()}";
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
            return Country.CostaRica;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CR;
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