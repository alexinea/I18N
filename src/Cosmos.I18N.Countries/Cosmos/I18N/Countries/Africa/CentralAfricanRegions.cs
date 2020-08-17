using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Central African Regions
    /// </summary>
    public static class CentralAfricanRegions
    {
        #region Gets regions

        /// <summary>
        /// Ouham
        /// </summary>
        public static EnumValues Ouham => EnumValues.Ouham;

        /// <summary>
        /// Bamingui-Bangoran
        /// </summary>
        public static EnumValues BaminguiBangoran => EnumValues.BaminguiBangoran;

        /// <summary>
        /// Bangui
        /// </summary>
        public static EnumValues Bangui => EnumValues.Bangui;

        /// <summary>
        /// Basse-Kotto
        /// </summary>
        public static EnumValues BasseKotto => EnumValues.BasseKotto;

        /// <summary>
        /// Haute-Kotto
        /// </summary>
        public static EnumValues HauteKotto => EnumValues.HauteKotto;

        /// <summary>
        /// Haut-Mbomou
        /// </summary>
        public static EnumValues HautMbomou => EnumValues.HautMbomou;

        /// <summary>
        /// Mambéré-Kadéï
        /// </summary>
        public static EnumValues MambéréKadéï => EnumValues.MambéréKadéï;

        /// <summary>
        ///  Nana-Grébizi
        /// </summary>
        public static EnumValues NanaGrébizi => EnumValues.NanaGrébizi;

        /// <summary>
        /// Kémo
        /// </summary>
        public static EnumValues Kémo => EnumValues.Kémo;

        /// <summary>
        /// Lobaye
        /// </summary>
        public static EnumValues Lobaye => EnumValues.Lobaye;

        /// <summary>
        /// Mbomou
        /// </summary>
        public static EnumValues Mbomou => EnumValues.Mbomou;

        /// <summary>
        /// Ombella-M’Poko
        /// </summary>
        public static EnumValues OmbellaMPoko => EnumValues.OmbellaMPoko;

        /// <summary>
        /// Nana-Mambéré
        /// </summary>
        public static EnumValues NanaMambéré => EnumValues.NanaMambéré;

        /// <summary>
        /// Ouham-Pendé
        /// </summary>
        public static EnumValues OuhamPendé => EnumValues.OuhamPendé;

        /// <summary>
        /// Sangha-Mbaéré
        /// </summary>
        public static EnumValues SanghaMbaéré => EnumValues.SanghaMbaéré;

        /// <summary>
        /// Ouaka
        /// </summary>
        public static EnumValues Ouaka => EnumValues.Ouaka;

        /// <summary>
        /// Vakaga
        /// </summary>
        public static EnumValues Vakaga => EnumValues.Vakaga;

        #endregion

        /// <summary>
        /// Enum values for Central African regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ouham
            /// </summary>
            [AliasInShort("AC")][RegionCode(3_00_109_0001)] Ouham,

            /// <summary>
            /// Bamingui-Bangoran
            /// </summary>
            [AliasInShort("BB")][RegionCode(3_00_109_0002)] BaminguiBangoran,

            /// <summary>
            /// Bangui
            /// </summary>
            [AliasInShort("BGF")][RegionCode(3_00_109_0003)] Bangui,

            /// <summary>
            /// Basse-Kotto
            /// </summary>
            [AliasInShort("BK")][RegionCode(3_00_109_0004)] BasseKotto,

            /// <summary>
            /// Haute-Kotto
            /// </summary>
            [AliasInShort("HK")][RegionCode(3_00_109_0005)] HauteKotto,

            /// <summary>
            /// Haut-Mbomou
            /// </summary>
            [AliasInShort("HM")][RegionCode(3_00_109_0006)] HautMbomou,

            /// <summary>
            /// Mambéré-Kadéï
            /// </summary>
            [AliasInShort("HS")] [RegionCode(3_00_109_0007)]MambéréKadéï,

            /// <summary>
            ///  Nana-Grébizi
            /// </summary>
            [AliasInShort("KB")][RegionCode(3_00_109_0008)] NanaGrébizi,

            /// <summary>
            /// Kémo
            /// </summary>
            [AliasInShort("KG")][RegionCode(3_00_109_0009)] Kémo,

            /// <summary>
            /// Lobaye
            /// </summary>
            [AliasInShort("LB")][RegionCode(3_00_109_0010)] Lobaye,

            /// <summary>
            /// Mbomou
            /// </summary>
            [AliasInShort("MB")][RegionCode(3_00_109_0011)] Mbomou,

            /// <summary>
            /// Ombella-M’Poko
            /// </summary>
            [AliasInShort("MP")][RegionCode(3_00_109_0012)] OmbellaMPoko,

            /// <summary>
            /// Nana-Mambéré
            /// </summary>
            [AliasInShort("NM")][RegionCode(3_00_109_0013)] NanaMambéré,

            /// <summary>
            /// Ouham-Pendé
            /// </summary>
            [AliasInShort("OP")] [RegionCode(3_00_109_0014)]OuhamPendé,

            /// <summary>
            /// Sangha-Mbaéré
            /// </summary>
            [AliasInShort("SE")][RegionCode(3_00_109_0015)] SanghaMbaéré,

            /// <summary>
            /// Ouaka
            /// </summary>
            [AliasInShort("UK")][RegionCode(3_00_109_0016)] Ouaka,

            /// <summary>
            /// Vakaga
            /// </summary>
            [AliasInShort("VK")][RegionCode(3_00_109_0017)] Vakaga,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CentralAfricanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CentralAfricanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CF-{values.ToRegionCode()}";
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
            return Country.CentralAfrican;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CF;
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