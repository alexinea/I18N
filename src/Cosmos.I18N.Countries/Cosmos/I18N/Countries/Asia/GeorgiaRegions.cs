using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Georgia regions
    /// </summary>
    public static class GeorgiaRegions
    {
        #region Gets regions

        /// <summary>
        /// Abkhazia
        /// </summary>
        public static EnumValues Abkhazia => EnumValues.Abkhazia;

        /// <summary>
        /// Adjara
        /// </summary>
        public static EnumValues Adjara => EnumValues.Adjara;

        /// <summary>
        /// Guria
        /// </summary>
        public static EnumValues Guria => EnumValues.Guria;

        /// <summary>
        /// Imereti
        /// </summary>
        public static EnumValues Imereti => EnumValues.Imereti;

        /// <summary>
        /// Kakheti
        /// </summary>
        public static EnumValues Kakheti => EnumValues.Kakheti;

        /// <summary>
        /// Kvemo Kartli
        /// </summary>
        public static EnumValues KvemoKartli => EnumValues.KvemoKartli;

        /// <summary>
        /// Mtskheta-Mtianeti
        /// </summary>
        public static EnumValues MtskhetaMtianeti => EnumValues.MtskhetaMtianeti;

        /// <summary>
        /// Racha-Lechkhumi and Kvemo Svaneti
        /// </summary>
        public static EnumValues RachaLechkhumiAndKvemoSvaneti => EnumValues.RachaLechkhumiAndKvemoSvaneti;

        /// <summary>
        /// Samtskhe-Javakheti
        /// </summary>
        public static EnumValues SamtskheJavakheti => EnumValues.SamtskheJavakheti;

        /// <summary>
        /// Shida Kartli
        /// </summary>
        public static EnumValues ShidaKartli => EnumValues.ShidaKartli;

        /// <summary>
        /// Samegrelo-Zemo Svaneti
        /// </summary>
        public static EnumValues SamegreloZemoSvaneti => EnumValues.SamegreloZemoSvaneti;

        /// <summary>
        /// Tbilisi
        /// </summary>
        public static EnumValues Tbilisi => EnumValues.Tbilisi;

        #endregion

        /// <summary>
        /// Enum values for Georgia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Abkhazia
            /// </summary>
            [AliasInShort("AB")][RegionCode(1_00_115_0001)] Abkhazia,

            /// <summary>
            /// Adjara
            /// </summary>
            [AliasInShort("AJ")][RegionCode(1_00_115_0002)] Adjara,

            /// <summary>
            /// Guria
            /// </summary>
            [AliasInShort("GU")][RegionCode(1_00_115_0003)] Guria,

            /// <summary>
            /// Imereti
            /// </summary>
            [AliasInShort("IM")][RegionCode(1_00_115_0004)] Imereti,

            /// <summary>
            /// Kakheti 
            /// </summary>
            [AliasInShort("KA")][RegionCode(1_00_115_0005)] Kakheti,

            /// <summary>
            /// Kvemo Kartli
            /// </summary>
            [AliasInShort("KK")][RegionCode(1_00_115_0006)] KvemoKartli,

            /// <summary>
            /// Mtskheta-Mtianeti
            /// </summary>
            [AliasInShort("MM")][RegionCode(1_00_115_0007)] MtskhetaMtianeti,

            /// <summary>
            /// Racha-Lechkhumi and Kvemo Svaneti
            /// </summary>
            [AliasInShort("RL")][RegionCode(1_00_115_0008)] RachaLechkhumiAndKvemoSvaneti,

            /// <summary>
            /// Samtskhe-Javakheti
            /// </summary>
            [AliasInShort("SJ")][RegionCode(1_00_115_0009)] SamtskheJavakheti,

            /// <summary>
            /// Shida Kartli
            /// </summary>
            [AliasInShort("SK")][RegionCode(1_00_115_0010)] ShidaKartli,

            /// <summary>
            /// Samegrelo-Zemo Svaneti
            /// </summary>
            [AliasInShort("SZ")][RegionCode(1_00_115_0011)] SamegreloZemoSvaneti,

            /// <summary>
            /// Tbilisi
            /// </summary>
            [AliasInShort("TB")][RegionCode(1_00_115_0012)] Tbilisi,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GeorgiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GeorgiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"GE-{values.ToRegionCode()}";
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
            return Country.Georgia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.GE;
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