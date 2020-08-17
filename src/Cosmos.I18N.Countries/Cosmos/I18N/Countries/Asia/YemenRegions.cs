using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Yemen regions
    /// </summary>
    public static class YemenRegions
    {
        #region Gets regions

        /// <summary>
        /// Abyan
        /// </summary>
        public static EnumValues Abyan => EnumValues.Abyan;

        /// <summary>
        /// 'Adan
        /// </summary>
        public static EnumValues Adan => EnumValues.Adan;

        /// <summary>
        /// Amran
        /// </summary>
        public static EnumValues Amran => EnumValues.Amran;

        /// <summary>
        /// Al Bayda
        /// </summary>
        public static EnumValues AlBayda => EnumValues.AlBayda;

        /// <summary>
        /// Dhale
        /// </summary>
        public static EnumValues Dhale => EnumValues.Dhale;

        /// <summary>
        /// Dhamar
        /// </summary>
        public static EnumValues Dhamar => EnumValues.Dhamar;

        /// <summary>
        /// Hadramaut
        /// </summary>
        public static EnumValues Hadramaut => EnumValues.Hadramaut;

        /// <summary>
        /// Hajjah
        /// </summary>
        public static EnumValues Hajjah => EnumValues.Hajjah;

        /// <summary>
        /// Al Hudaydah
        /// </summary>
        public static EnumValues AlHudaydah => EnumValues.AlHudaydah;

        /// <summary>
        /// Ibb
        /// </summary>
        public static EnumValues Ibb => EnumValues.Ibb;

        /// <summary>
        /// Al Jawf
        /// </summary>
        public static EnumValues AlJawf => EnumValues.AlJawf;

        /// <summary>
        /// Lahij
        /// </summary>
        public static EnumValues Lahij => EnumValues.Lahij;

        /// <summary>
        /// Ma'rib
        /// </summary>
        public static EnumValues MaRib => EnumValues.MaRib;

        /// <summary>
        /// Al Mahrah
        /// </summary>
        public static EnumValues AlMahrah => EnumValues.AlMahrah;

        /// <summary>
        /// Al Mahwit
        /// </summary>
        public static EnumValues AlMahwit => EnumValues.AlMahwit;

        /// <summary>
        /// Raymah
        /// </summary>
        public static EnumValues Raymah => EnumValues.Raymah;


        /// <summary>
        /// Amanat Al Asimah
        /// </summary>
        public static EnumValues AmanatAlAsimah => EnumValues.AmanatAlAsimah;

        /// <summary>
        /// Sa'dah
        /// </summary>
        public static EnumValues SaDah => EnumValues.SaDah;

        /// <summary>
        /// Shabwah
        /// </summary>
        public static EnumValues Shabwah => EnumValues.Shabwah;

        /// <summary>
        /// Sana'a
        /// </summary>
        public static EnumValues SanaA => EnumValues.SanaA;

        /// <summary>
        /// Arkhabil Suqutra
        /// </summary>
        public static EnumValues ArkhabilSuqutra => EnumValues.ArkhabilSuqutra;

        /// <summary>
        /// Taiz
        /// </summary>
        public static EnumValues Taiz => EnumValues.Taiz;

        #endregion

        /// <summary>
        /// Enum values for Yemen regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Abyan
            /// </summary>
            [AliasInShort("AB")] [RegionCode(1_00_142_0001)]
            Abyan,

            /// <summary>
            /// 'Adan
            /// </summary>
            [AliasInShort("AD")] [RegionCode(1_00_142_0002)]
            Adan,

            /// <summary>
            /// Amran
            /// </summary>
            [AliasInShort("AM")] [RegionCode(1_00_142_0003)]
            Amran,

            /// <summary>
            /// Al Bayda
            /// </summary>
            [AliasInShort("BA")] [RegionCode(1_00_142_0004)]
            AlBayda,

            /// <summary>
            /// Dhale
            /// </summary>
            [AliasInShort("DA")] [RegionCode(1_00_142_0005)]
            Dhale,

            /// <summary>
            /// Dhamar
            /// </summary>
            [AliasInShort("DH")] [RegionCode(1_00_142_0006)]
            Dhamar,

            /// <summary>
            /// Hadramaut
            /// </summary>
            [AliasInShort("HD")] [RegionCode(1_00_142_0007)]
            Hadramaut,

            /// <summary>
            /// Hajjah
            /// </summary>
            [AliasInShort("HJ")] [RegionCode(1_00_142_0008)]
            Hajjah,

            /// <summary>
            /// Al Hudaydah
            /// </summary>
            [AliasInShort("HU")] [RegionCode(1_00_142_0009)]
            AlHudaydah,

            /// <summary>
            /// Ibb
            /// </summary>
            [AliasInShort("IB")] [RegionCode(1_00_142_0010)]
            Ibb,

            /// <summary>
            /// Al Jawf
            /// </summary>
            [AliasInShort("JA")] [RegionCode(1_00_142_0011)]
            AlJawf,

            /// <summary>
            /// Lahij
            /// </summary>
            [AliasInShort("LA")] [RegionCode(1_00_142_0012)]
            Lahij,

            /// <summary>
            /// Ma'rib
            /// </summary>
            [AliasInShort("MA")] [RegionCode(1_00_142_0013)]
            MaRib,

            /// <summary>
            /// Al Mahrah
            /// </summary>
            [AliasInShort("MR")] [RegionCode(1_00_142_0014)]
            AlMahrah,

            /// <summary>
            /// Al Mahwit
            /// </summary>
            [AliasInShort("MW")] [RegionCode(1_00_142_0015)]
            AlMahwit,

            /// <summary>
            /// Raymah
            /// </summary>
            [AliasInShort("RA")] [RegionCode(1_00_142_0016)]
            Raymah,

            /// <summary>
            /// Amanat Al Asimah
            /// </summary>
            [AliasInShort("SA")] [RegionCode(1_00_142_0017)]
            AmanatAlAsimah,

            /// <summary>
            /// Sa'dah
            /// </summary>
            [AliasInShort("SD")] [RegionCode(1_00_142_0018)]
            SaDah,

            /// <summary>
            /// Shabwah
            /// </summary>
            [AliasInShort("SH")] [RegionCode(1_00_142_0019)]
            Shabwah,

            /// <summary>
            /// Sana'a
            /// </summary>
            [AliasInShort("SN")] [RegionCode(1_00_142_0020)]
            SanaA,

            /// <summary>
            /// Arkhabil Suqutra
            /// </summary>
            [AliasInShort("SU")] [RegionCode(1_00_142_0021)]
            ArkhabilSuqutra,

            /// <summary>
            /// Taiz
            /// </summary>
            [AliasInShort("TA")] [RegionCode(1_00_142_0022)]
            Taiz,

            /// <summary>
            /// Unknown<br />未知
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="YemenRegions.EnumValues"/> to region code likes 'AD'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="YemenRegions.EnumValues"/> to full region code likes 'YE-AD'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"YE-{values.ToRegionCode()}";
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
            return Country.Yemen;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.YE;
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