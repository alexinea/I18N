using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Syrian Regions
    /// </summary>
    public static class SyrianRegions
    {
        #region Gets regions

        /// <summary>
        /// Damascus
        /// </summary>
        public static EnumValues Damascus => EnumValues.Damascus;

        /// <summary>
        /// Daraa
        /// </summary>
        public static EnumValues Daraa => EnumValues.Daraa;

        /// <summary>
        /// Deir ez-Zor
        /// </summary>
        public static EnumValues DeirEzZor => EnumValues.DeirEzZor;

        /// <summary>
        /// Al-Hasakah
        /// </summary>
        public static EnumValues AlHasakah => EnumValues.AlHasakah;

        /// <summary>
        /// Homs
        /// </summary>
        public static EnumValues Homs => EnumValues.Homs;

        /// <summary>
        /// Aleppo
        /// </summary>
        public static EnumValues Aleppo => EnumValues.Aleppo;

        /// <summary>
        /// Hama
        /// </summary>
        public static EnumValues Hama => EnumValues.Hama;

        /// <summary>
        /// Idlib  
        /// </summary>
        public static EnumValues Idlib => EnumValues.Idlib;

        /// <summary>
        /// Latakia
        /// </summary>
        public static EnumValues Latakia => EnumValues.Latakia;

        /// <summary>
        /// Quneitra
        /// </summary>
        public static EnumValues Quneitra => EnumValues.Quneitra;

        /// <summary>
        /// Ar-Raqqah
        /// </summary>
        public static EnumValues ArRaqqah => EnumValues.ArRaqqah;

        /// <summary>
        /// Rif Dimashq
        /// </summary>
        public static EnumValues RifDimashq => EnumValues.RifDimashq;

        /// <summary>
        /// As-Suwayda
        /// </summary>
        public static EnumValues AsSuwayda => EnumValues.AsSuwayda;

        /// <summary>
        /// Tartus
        /// </summary>
        public static EnumValues Tartus => EnumValues.Tartus;

        #endregion

        /// <summary>
        /// Enum values for Syrian regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Damascus
            /// </summary>
            [AliasInShort("DI")][RegionCode(1_00_136_0001)] Damascus,

            /// <summary>
            /// Daraa
            /// </summary>
            [AliasInShort("DR")][RegionCode(1_00_136_0002)] Daraa,

            /// <summary>
            /// Deir ez-Zor
            /// </summary>
            [AliasInShort("DY")][RegionCode(1_00_136_0003)] DeirEzZor,

            /// <summary>
            /// Al-Hasakah
            /// </summary>
            [AliasInShort("HA")][RegionCode(1_00_136_0004)] AlHasakah,

            /// <summary>
            /// Homs
            /// </summary>
            [AliasInShort("HI")][RegionCode(1_00_136_0005)] Homs,

            /// <summary>
            /// Aleppo
            /// </summary>
            [AliasInShort("HL")][RegionCode(1_00_136_0006)] Aleppo,

            /// <summary>
            /// Hama
            /// </summary>
            [AliasInShort("HM")][RegionCode(1_00_136_0007)] Hama,

            /// <summary>
            /// Idlib
            /// </summary>
            [AliasInShort("ID")][RegionCode(1_00_136_0008)] Idlib,

            /// <summary>
            /// Latakia
            /// </summary>
            [AliasInShort("LA")][RegionCode(1_00_136_0009)] Latakia,

            /// <summary>
            /// Quneitra
            /// </summary>
            [AliasInShort("QU")][RegionCode(1_00_136_0010)] Quneitra,

            /// <summary>
            /// Ar-Raqqah
            /// </summary>
            [AliasInShort("RA")][RegionCode(1_00_136_0011)] ArRaqqah,

            /// <summary>
            /// Rif Dimashq
            /// </summary>
            [AliasInShort("RD")][RegionCode(1_00_136_0012)] RifDimashq,

            /// <summary>
            /// As-Suwayda
            /// </summary>
            [AliasInShort("SU")][RegionCode(1_00_136_0013)] AsSuwayda,

            /// <summary>
            /// Tartus
            /// </summary>
            [AliasInShort("TA")][RegionCode(1_00_136_0014)] Tartus,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SyrianRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SyrianRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"SY-{values.ToRegionCode()}";
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
            return Country.Syrian;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.SY;
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