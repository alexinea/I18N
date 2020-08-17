using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Cuba regions
    /// </summary>
    public static class CubaRegions
    {
        #region Gets regions

        /// <summary>
        /// Pinar del Río
        /// </summary>
        public static EnumValues PinarDelRío => EnumValues.PinarDelRío;

        /// <summary>
        /// Havana
        /// </summary>
        public static EnumValues Havana => EnumValues.Havana;

        /// <summary>
        /// Matanzas
        /// </summary>
        public static EnumValues Matanzas => EnumValues.Matanzas;

        /// <summary>
        /// Villa Clara
        /// </summary>
        public static EnumValues VillaClara => EnumValues.VillaClara;

        /// <summary>
        /// Cienfuegos
        /// </summary>
        public static EnumValues Cienfuegos => EnumValues.Cienfuegos;

        /// <summary>
        /// Sancti Spíritus
        /// </summary>
        public static EnumValues SanctiSpíritus => EnumValues.SanctiSpíritus;

        /// <summary>
        /// Ciego de Ávila
        /// </summary>
        public static EnumValues CiegoDeÁvila => EnumValues.CiegoDeÁvila;

        /// <summary>
        /// Camagüey
        /// </summary>
        public static EnumValues Camagüey => EnumValues.Camagüey;

        /// <summary>
        /// Las Tunas
        /// </summary>
        public static EnumValues LasTunas => EnumValues.LasTunas;

        /// <summary>
        /// Holguín
        /// </summary>
        public static EnumValues Holguín => EnumValues.Holguín;

        /// <summary>
        /// Granma
        /// </summary>
        public static EnumValues Granma => EnumValues.Granma;

        /// <summary>
        /// Santiago de Cuba
        /// </summary>
        public static EnumValues SantiagoDeCuba => EnumValues.SantiagoDeCuba;

        /// <summary>
        /// Guantánamo
        /// </summary>
        public static EnumValues Guantánamo => EnumValues.Guantánamo;

        /// <summary>
        /// Artemisa
        /// </summary>
        public static EnumValues Artemisa => EnumValues.Artemisa;

        /// <summary>
        /// Mayabeque
        /// </summary>
        public static EnumValues Mayabeque => EnumValues.Mayabeque;

        /// <summary>
        /// Isla de la Juventud 
        /// </summary>
        public static EnumValues IslaDeLaJuventud => EnumValues.IslaDeLaJuventud;

        #endregion

        /// <summary>
        /// Enum values for Cuba regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Pinar del Río
            /// </summary>
            [AliasInShort("01")] [RegionCode(4_00_101_0001)]
            PinarDelRío,

            /// <summary>
            /// Havana
            /// </summary>
            [AliasInShort("03")] [RegionCode(4_00_101_0003)]
            Havana,

            /// <summary>
            /// Matanzas
            /// </summary>
            [AliasInShort("04")] [RegionCode(4_00_101_0004)]
            Matanzas,

            /// <summary>
            /// Villa Clara
            /// </summary>
            [AliasInShort("05")] [RegionCode(4_00_101_0005)]
            VillaClara,

            /// <summary>
            /// Cienfuegos
            /// </summary>
            [AliasInShort("06")] [RegionCode(4_00_101_0006)]
            Cienfuegos,

            /// <summary>
            /// Sancti Spíritus
            /// </summary>
            [AliasInShort("07")] [RegionCode(4_00_101_0007)]
            SanctiSpíritus,

            /// <summary>
            /// Ciego de Ávila
            /// </summary>
            [AliasInShort("08")] [RegionCode(4_00_101_0008)]
            CiegoDeÁvila,

            /// <summary>
            /// Camagüey
            /// </summary>
            [AliasInShort("09")] [RegionCode(4_00_101_0009)]
            Camagüey,

            /// <summary>
            /// Las Tunas
            /// </summary>
            [AliasInShort("10")] [RegionCode(4_00_101_0010)]
            LasTunas,

            /// <summary>
            /// Holguín
            /// </summary>
            [AliasInShort("11")] [RegionCode(4_00_101_0011)]
            Holguín,

            /// <summary>
            /// Granma
            /// </summary>
            [AliasInShort("12")] [RegionCode(4_00_101_0012)]
            Granma,

            /// <summary>
            /// Santiago de Cuba
            /// </summary>
            [AliasInShort("13")] [RegionCode(4_00_101_0013)]
            SantiagoDeCuba,

            /// <summary>
            /// Guantánamo
            /// </summary>
            [AliasInShort("14")] [RegionCode(4_00_101_0014)]
            Guantánamo,

            /// <summary>
            /// Artemisa
            /// </summary>
            [AliasInShort("15")] [RegionCode(4_00_101_0015)]
            Artemisa,

            /// <summary>
            /// Mayabeque
            /// </summary>
            [AliasInShort("16")] [RegionCode(4_00_101_0016)]
            Mayabeque,

            /// <summary>
            /// Isla de la Juventud
            /// </summary>
            [AliasInShort("99")] IslaDeLaJuventud,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CubaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CubaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CU-{values.ToRegionCode()}";
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
            return Country.Cuba;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CU;
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