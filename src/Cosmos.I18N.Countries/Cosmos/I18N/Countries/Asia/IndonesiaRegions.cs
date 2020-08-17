using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Indonesia Regions
    /// </summary>
    public static class IndonesiaRegions
    {
        #region Gets regions

        /// <summary>
        /// Java
        /// </summary>
        public static EnumValues Java => EnumValues.Java;

        /// <summary>
        /// Kalimantan
        /// </summary>
        public static EnumValues Kalimantan => EnumValues.Kalimantan;

        /// <summary>
        /// Maluku Islands
        /// </summary>
        public static EnumValues MalukuIslands => EnumValues.MalukuIslands;

        /// <summary>
        /// Lesser Sunda Islands
        /// </summary>
        public static EnumValues LesserSundaIslands => EnumValues.LesserSundaIslands;

        /// <summary>
        /// Papua Islands
        /// </summary>
        public static EnumValues PapuaIslands => EnumValues.PapuaIslands;

        /// <summary>
        /// Sulawesi
        /// </summary>
        public static EnumValues Sulawesi => EnumValues.Sulawesi;

        /// <summary>
        /// Sumatra
        /// </summary>
        public static EnumValues Sumatra => EnumValues.Sumatra;

        #endregion

        /// <summary>
        /// Enum values for Indonesia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Java
            /// </summary>
            [AliasInShort("JW")] [RegionCode(1_00_115_0001)]
            Java,

            /// <summary>
            /// Kalimantan
            /// </summary>
            [AliasInShort("KA")] [RegionCode(1_00_115_0002)]
            Kalimantan,

            /// <summary>
            /// Maluku Islands
            /// </summary>
            [AliasInShort("ML")] [RegionCode(1_00_115_0003)]
            MalukuIslands,

            /// <summary>
            /// Lesser Sunda Islands
            /// </summary>
            [AliasInShort("MU")] [RegionCode(1_00_115_0004)]
            LesserSundaIslands,

            /// <summary>
            /// Papua Islands
            /// </summary>
            [AliasInShort("PP")] [RegionCode(1_00_115_0005)]
            PapuaIslands,

            /// <summary>
            /// Sulawesi
            /// </summary>
            [AliasInShort("SL")] [RegionCode(1_00_115_0006)]
            Sulawesi,

            /// <summary>
            /// Sumatra
            /// </summary>
            [AliasInShort("SM")] [RegionCode(1_00_115_0007)]
            Sumatra,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="IndonesiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="IndonesiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"ID-{values.ToRegionCode()}";
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
            return Country.Indonesia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.ID;
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