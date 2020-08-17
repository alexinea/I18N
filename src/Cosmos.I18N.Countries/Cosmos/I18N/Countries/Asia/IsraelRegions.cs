using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Israel Regions
    /// </summary>
    public static class IsraelRegions
    {
        #region Gets regions

        /// <summary>
        /// Southern District
        /// </summary>
        public static EnumValues SouthernDistrict => EnumValues.SouthernDistrict;

        /// <summary>
        /// Haifa District
        /// </summary>
        public static EnumValues HaifaDistrict => EnumValues.HaifaDistrict;

        /// <summary>
        /// Jerusalem
        /// </summary>
        public static EnumValues Jerusalem => EnumValues.Jerusalem;

        /// <summary>
        /// Central District
        /// </summary>
        public static EnumValues CentralDistrict => EnumValues.CentralDistrict;

        /// <summary>
        /// Tel Aviv District
        /// </summary>
        public static EnumValues TelAvivDistrict => EnumValues.TelAvivDistrict;

        /// <summary>
        /// Northern District
        /// </summary>
        public static EnumValues NorthernDistrict => EnumValues.NorthernDistrict;

        #endregion

        /// <summary>
        /// Enum values for Israel regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Southern District
            /// </summary>
            [AliasInShort("D")][RegionCode(1_00_115_0001)] SouthernDistrict,

            /// <summary>
            /// Haifa District
            /// </summary>
            [AliasInShort("HA")][RegionCode(1_00_115_0002)] HaifaDistrict,

            /// <summary>
            /// Jerusalem
            /// </summary>
            [AliasInShort("JM")][RegionCode(1_00_115_0003)] Jerusalem,

            /// <summary>
            /// Central District
            /// </summary>
            [AliasInShort("M")][RegionCode(1_00_115_0004)] CentralDistrict,

            /// <summary>
            /// Tel Aviv District
            /// </summary>
            [AliasInShort("TA")][RegionCode(1_00_115_0005)] TelAvivDistrict,

            /// <summary>
            /// Northern District
            /// </summary>
            [AliasInShort("Z")][RegionCode(1_00_115_0006)] NorthernDistrict,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="IsraelRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="IsraelRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"IL-{values.ToRegionCode()}";
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
            return Country.Israel;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.IL;
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