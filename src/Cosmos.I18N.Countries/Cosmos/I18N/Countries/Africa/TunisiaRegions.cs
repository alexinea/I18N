using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Tunisia Regions
    /// </summary>
    public static class TunisiaRegions
    {
        #region Gets regions

        /// <summary>
        /// Tunis
        /// </summary>
        public static EnumValues Tunis => EnumValues.Tunis;

        /// <summary>
        /// Ariana
        /// </summary>
        public static EnumValues Ariana => EnumValues.Ariana;

        /// <summary>
        /// Ben Arous
        /// </summary>
        public static EnumValues BenArous => EnumValues.BenArous;

        /// <summary>
        /// Manouba
        /// </summary>
        public static EnumValues Manouba => EnumValues.Manouba;

        /// <summary>
        /// Nabeul
        /// </summary>
        public static EnumValues Nabeul => EnumValues.Nabeul;

        /// <summary>
        /// Zaghouan
        /// </summary>
        public static EnumValues Zaghouan => EnumValues.Zaghouan;

        /// <summary>
        /// Bizerte
        /// </summary>
        public static EnumValues Bizerte => EnumValues.Bizerte;

        /// <summary>
        /// Béja
        /// </summary>
        public static EnumValues Béja => EnumValues.Béja;

        /// <summary>
        /// Jendouba
        /// </summary>
        public static EnumValues Jendouba => EnumValues.Jendouba;

        /// <summary>
        /// Kef
        /// </summary>
        public static EnumValues Kef => EnumValues.Kef;

        /// <summary>
        /// Siliana
        /// </summary>
        public static EnumValues Siliana => EnumValues.Siliana;

        /// <summary>
        /// Kairouan
        /// </summary>
        public static EnumValues Kairouan => EnumValues.Kairouan;

        /// <summary>
        /// Kasserine
        /// </summary>
        public static EnumValues Kasserine => EnumValues.Kasserine;

        /// <summary>
        /// Sidi Bouzid
        /// </summary>
        public static EnumValues SidiBouzid => EnumValues.SidiBouzid;

        /// <summary>
        /// Sousse
        /// </summary>
        public static EnumValues Sousse => EnumValues.Sousse;

        /// <summary>
        /// Monastir
        /// </summary>
        public static EnumValues Monastir => EnumValues.Monastir;

        /// <summary>
        /// Mahdia
        /// </summary>
        public static EnumValues Mahdia => EnumValues.Mahdia;

        /// <summary>
        /// Sfax
        /// </summary>
        public static EnumValues Sfax => EnumValues.Sfax;

        /// <summary>
        /// Gafsa
        /// </summary>
        public static EnumValues Gafsa => EnumValues.Gafsa;

        /// <summary>
        /// Tozeur
        /// </summary>
        public static EnumValues Tozeur => EnumValues.Tozeur;

        /// <summary>
        /// Kebili
        /// </summary>
        public static EnumValues Kebili => EnumValues.Kebili;

        /// <summary>
        /// Gabès
        /// </summary>
        public static EnumValues Gabès => EnumValues.Gabès;

        /// <summary>
        /// Medenine
        /// </summary>
        public static EnumValues Medenine => EnumValues.Medenine;

        /// <summary>
        /// Tataouine
        /// </summary>
        public static EnumValues Tataouine => EnumValues.Tataouine;

        #endregion

        /// <summary>
        /// Enum values for Tunisia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Tunis
            /// </summary>
            [AliasInShort("11")][RegionCode(3_00_120_0011)] Tunis,

            /// <summary>
            /// Ariana
            /// </summary>
            [AliasInShort("12")][RegionCode(3_00_120_0012)] Ariana,

            /// <summary>
            /// Ben Arous
            /// </summary>
            [AliasInShort("13")][RegionCode(3_00_120_0013)] BenArous,

            /// <summary>
            /// Manouba
            /// </summary>
            [AliasInShort("14")][RegionCode(3_00_120_0014)] Manouba,

            /// <summary>
            /// Nabeul
            /// </summary>
            [AliasInShort("21")][RegionCode(3_00_120_0021)] Nabeul,

            /// <summary>
            /// Zaghouan
            /// </summary>
            [AliasInShort("22")][RegionCode(3_00_120_0022)] Zaghouan,

            /// <summary>
            /// Bizerte
            /// </summary>
            [AliasInShort("23")][RegionCode(3_00_120_0023)] Bizerte,

            /// <summary>
            /// Béja
            /// </summary>
            [AliasInShort("31")][RegionCode(3_00_120_0031)] Béja,

            /// <summary>
            /// Jendouba
            /// </summary>
            [AliasInShort("32")][RegionCode(3_00_120_0032)] Jendouba,

            /// <summary>
            /// Kef
            /// </summary>
            [AliasInShort("33")][RegionCode(3_00_120_0033)] Kef,

            /// <summary>
            /// Siliana
            /// </summary>
            [AliasInShort("34")][RegionCode(3_00_120_0034)] Siliana,

            /// <summary>
            /// Kairouan
            /// </summary>
            [AliasInShort("41")][RegionCode(3_00_120_0041)] Kairouan,

            /// <summary>
            /// Kasserine
            /// </summary>
            [AliasInShort("42")][RegionCode(3_00_120_0042)] Kasserine,

            /// <summary>
            /// Sidi Bouzid
            /// </summary>
            [AliasInShort("43")][RegionCode(3_00_120_0043)] SidiBouzid,

            /// <summary>
            /// Sousse
            /// </summary>
            [AliasInShort("51")][RegionCode(3_00_120_0051)] Sousse,

            /// <summary>
            /// Monastir
            /// </summary>
            [AliasInShort("52")][RegionCode(3_00_120_0052)] Monastir,

            /// <summary>
            /// Mahdia
            /// </summary>
            [AliasInShort("53")][RegionCode(3_00_120_0053)] Mahdia,

            /// <summary>
            /// Sfax
            /// </summary>
            [AliasInShort("61")][RegionCode(3_00_120_0061)] Sfax,

            /// <summary>
            /// Gafsa
            /// </summary>
            [AliasInShort("71")][RegionCode(3_00_120_0071)] Gafsa,

            /// <summary>
            /// Tozeur
            /// </summary>
            [AliasInShort("72")][RegionCode(3_00_120_0072)] Tozeur,

            /// <summary>
            /// Kebili
            /// </summary>
            [AliasInShort("73")][RegionCode(3_00_120_0073)] Kebili,

            /// <summary>
            /// Gabès
            /// </summary>
            [AliasInShort("81")][RegionCode(3_00_120_0081)] Gabès,

            /// <summary>
            /// Medenine
            /// </summary>
            [AliasInShort("82")][RegionCode(3_00_120_0082)] Medenine,

            /// <summary>
            /// Tataouine
            /// </summary>
            [AliasInShort("83")][RegionCode(3_00_120_0083)] Tataouine,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="TunisiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="TunisiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"TN-{values.ToRegionCode()}";
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
            return Country.Tunisia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.TN;
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