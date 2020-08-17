using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Lesotho Regions
    /// </summary>
    public static class LesothoRegions
    {
        #region Gets regions

        /// <summary>
        /// Maseru
        /// </summary>
        public static EnumValues Maseru => EnumValues.Maseru;

        /// <summary>
        /// Butha-Buthe
        /// </summary>
        public static EnumValues ButhaButhe => EnumValues.ButhaButhe;

        /// <summary>
        /// Leribe
        /// </summary>
        public static EnumValues Leribe => EnumValues.Leribe;

        /// <summary>
        /// Berea
        /// </summary>
        public static EnumValues Berea => EnumValues.Berea;

        /// <summary>
        /// Mafeteng
        /// </summary>
        public static EnumValues Mafeteng => EnumValues.Mafeteng;

        /// <summary>
        /// Mohale’s Hoek
        /// </summary>
        public static EnumValues MohalesHoek => EnumValues.MohalesHoek;

        /// <summary>
        /// Quthing
        /// </summary>
        public static EnumValues Quthing => EnumValues.Quthing;

        /// <summary>
        /// Qacha’s Nek
        /// </summary>
        public static EnumValues QachasNek => EnumValues.QachasNek;

        /// <summary>
        /// Mokhotlong
        /// </summary>
        public static EnumValues Mokhotlong => EnumValues.Mokhotlong;

        /// <summary>
        /// Thaba-Tseka
        /// </summary>
        public static EnumValues ThabaTseka => EnumValues.ThabaTseka;

        #endregion

        /// <summary>
        /// Enum values for Lesotho regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Maseru
            /// </summary>
            [AliasInShort("A")][RegionCode(3_00_131_0001)] Maseru,

            /// <summary>
            /// Butha-Buthe
            /// </summary>
            [AliasInShort("B")][RegionCode(3_00_131_0002)] ButhaButhe,

            /// <summary>
            /// Leribe
            /// </summary>
            [AliasInShort("C")][RegionCode(3_00_131_0003)] Leribe,

            /// <summary>
            /// Berea
            /// </summary>
            [AliasInShort("D")][RegionCode(3_00_131_0004)] Berea,

            /// <summary>
            /// Mafeteng
            /// </summary>
            [AliasInShort("E")][RegionCode(3_00_131_0005)] Mafeteng,

            /// <summary>
            /// Mohale’s Hoek
            /// </summary>
            [AliasInShort("F")][RegionCode(3_00_131_0006)] MohalesHoek,

            /// <summary>
            /// Quthing
            /// </summary>
            [AliasInShort("G")][RegionCode(3_00_131_0007)] Quthing,

            /// <summary>
            /// Qacha’s Nek
            /// </summary>
            [AliasInShort("H")][RegionCode(3_00_131_0008)] QachasNek,

            /// <summary>
            /// Mokhotlong
            /// </summary>
            [AliasInShort("J")][RegionCode(3_00_131_0009)] Mokhotlong,

            /// <summary>
            /// Thaba-Tseka
            /// </summary>
            [AliasInShort("K")][RegionCode(3_00_131_0010)] ThabaTseka,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="LesothoRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="LesothoRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"LS-{values.ToRegionCode()}";
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
            return Country.Lesotho;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.LS;
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