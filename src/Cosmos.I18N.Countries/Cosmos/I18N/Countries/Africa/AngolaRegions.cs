using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Angola regions
    /// </summary>
    public static class AngolaRegions
    {
        #region Gets region

        /// <summary>
        /// Bengo
        /// </summary>
        public static EnumValues Bengo => EnumValues.Bengo;

        /// <summary>
        /// Benguela
        /// </summary>
        public static EnumValues Benguela => EnumValues.Benguela;

        /// <summary>
        /// Bié
        /// </summary>
        public static EnumValues Bié => EnumValues.Bié;

        /// <summary>
        /// Cabinda
        /// </summary>
        public static EnumValues Cabinda => EnumValues.Cabinda;

        /// <summary>
        /// Cuando Cubango
        /// </summary>
        public static EnumValues CuandoCubango => EnumValues.CuandoCubango;

        /// <summary>
        /// Cunene
        /// </summary>
        public static EnumValues Cunene => EnumValues.Cunene;

        /// <summary>
        /// Cuanza Norte
        /// </summary>
        public static EnumValues CuanzaNorte => EnumValues.CuanzaNorte;

        /// <summary>
        /// Cuanza Sul    
        /// </summary>
        public static EnumValues CuanzaSul => EnumValues.CuanzaSul;

        /// <summary>
        /// Huambo
        /// </summary>
        public static EnumValues Huambo => EnumValues.Huambo;

        /// <summary>
        /// Huíla
        /// </summary>
        public static EnumValues Huíla => EnumValues.Huíla;

        /// <summary>
        /// Lunda Norte
        /// </summary>
        public static EnumValues LundaNorte => EnumValues.LundaNorte;

        /// <summary>
        /// Lunda Sul
        /// </summary>
        public static EnumValues LundaSul => EnumValues.LundaSul;

        /// <summary>
        /// Luanda
        /// </summary>
        public static EnumValues Luanda => EnumValues.Luanda;

        /// <summary>
        /// Malanje
        /// </summary>
        public static EnumValues Malanje => EnumValues.Malanje;

        /// <summary>
        /// Moxico
        /// </summary>
        public static EnumValues Moxico => EnumValues.Moxico;

        /// <summary>
        /// Namibe
        /// </summary>
        public static EnumValues Namibe => EnumValues.Namibe;

        /// <summary>
        /// Uíge
        /// </summary>
        public static EnumValues Uíge => EnumValues.Uíge;

        /// <summary>
        /// Zaire
        /// </summary>
        public static EnumValues Zaire => EnumValues.Zaire;

        #endregion

        /// <summary>
        /// Enum values for Angola regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bengo
            /// </summary>
            [AliasInShort("BGO")][RegionCode(3_00_102_0001)] Bengo,

            /// <summary>
            /// Benguela
            /// </summary>
            [AliasInShort("BGU")][RegionCode(3_00_102_0002)] Benguela,

            /// <summary>
            /// Bié
            /// </summary>
            [AliasInShort("BIE")][RegionCode(3_00_102_0003)] Bié,

            /// <summary>
            /// Cabinda
            /// </summary>
            [AliasInShort("CAB")][RegionCode(3_00_102_0004)] Cabinda,

            /// <summary>
            /// Cuando Cubango
            /// </summary>
            [AliasInShort("CCU")][RegionCode(3_00_102_0005)] CuandoCubango,

            /// <summary>
            /// Cunene
            /// </summary>
            [AliasInShort("CNN")][RegionCode(3_00_102_0006)] Cunene,

            /// <summary>
            /// Cuanza Norte
            /// </summary>
            [AliasInShort("CNO")][RegionCode(3_00_102_0007)] CuanzaNorte,

            /// <summary>
            /// Cuanza Sul    
            /// </summary>
            [AliasInShort("CUS")][RegionCode(3_00_102_0008)] CuanzaSul,

            /// <summary>
            /// Huambo
            /// </summary>
            [AliasInShort("HUA")][RegionCode(3_00_102_0009)] Huambo,

            /// <summary>
            /// Huíla
            /// </summary>
            [AliasInShort("HUI")][RegionCode(3_00_102_0010)] Huíla,

            /// <summary>
            /// Lunda Norte
            /// </summary>
            [AliasInShort("LNO")][RegionCode(3_00_102_0011)] LundaNorte,

            /// <summary>
            /// Lunda Sul
            /// </summary>
            [AliasInShort("LSU")][RegionCode(3_00_102_0012)] LundaSul,

            /// <summary>
            /// Luanda
            /// </summary>
            [AliasInShort("LUA")][RegionCode(3_00_102_0013)] Luanda,

            /// <summary>
            /// Malanje
            /// </summary>
            [AliasInShort("MAL")][RegionCode(3_00_102_0014)] Malanje,

            /// <summary>
            /// Moxico
            /// </summary>
            [AliasInShort("MOX")][RegionCode(3_00_102_0015)] Moxico,

            /// <summary>
            /// Namibe
            /// </summary>
            [AliasInShort("NAM")][RegionCode(3_00_102_0016)] Namibe,

            /// <summary>
            /// Uíge
            /// </summary>
            [AliasInShort("UIG")][RegionCode(3_00_102_0017)] Uíge,

            /// <summary>
            /// Zaire
            /// </summary>
            [AliasInShort("ZAI")][RegionCode(3_00_102_0018)] Zaire,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="AngolaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="AngolaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"AO-{values.ToRegionCode()}";
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
            return Country.Angola;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.AO;
        }

        #endregion

        #region Getters

        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(member => !member.HasAttr<EnumValues, IgnoreRegionAttribute>()).ToList();

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