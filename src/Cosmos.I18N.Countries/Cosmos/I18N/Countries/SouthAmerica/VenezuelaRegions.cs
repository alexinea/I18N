using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// Venezuela Regions
    /// </summary>
    public static class VenezuelaRegions
    {
        #region Gets regions

        /// <summary>
        /// Anzoátegui
        /// </summary>
        public static EnumValues Anzoátegui => EnumValues.Anzoátegui;

        /// <summary>
        /// Carabobo
        /// </summary>
        public static EnumValues Carabobo => EnumValues.Carabobo;

        /// <summary>
        /// Lara
        /// </summary>
        public static EnumValues Lara => EnumValues.Lara;

        /// <summary>
        /// Miranda
        /// </summary>
        public static EnumValues Miranda => EnumValues.Miranda;

        /// <summary>
        /// Monagas
        /// </summary>
        public static EnumValues Monagas => EnumValues.Monagas;

        /// <summary>
        /// Táchira
        /// </summary>
        public static EnumValues Táchira => EnumValues.Táchira;

        /// <summary>
        /// Zulia
        /// </summary>
        public static EnumValues Zulia => EnumValues.Zulia;

        #endregion

        /// <summary>
        /// Enum values for Venezuela regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Anzoátegui
            /// </summary>
            [AliasInShort("B")] [RegionCode(5_00_013_0001)]
            Anzoátegui,

            /// <summary>
            /// Carabobo
            /// </summary>
            [AliasInShort("G")] [RegionCode(5_00_013_0002)]
            Carabobo,

            /// <summary>
            /// Lara
            /// </summary>
            [AliasInShort("K")] [RegionCode(5_00_013_0003)]
            Lara,

            /// <summary>
            /// Miranda
            /// </summary>
            [AliasInShort("M")] [RegionCode(5_00_013_0004)]
            Miranda,

            /// <summary>
            /// Monagas
            /// </summary>
            [AliasInShort("N")] [RegionCode(5_00_013_0005)]
            Monagas,

            /// <summary>
            /// Táchira
            /// </summary>
            [AliasInShort("S")] [RegionCode(5_00_013_0006)]
            Táchira,

            /// <summary>
            /// Zulia
            /// </summary>
            [AliasInShort("V")] [RegionCode(5_00_013_0007)]
            Zulia,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="VenezuelaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="VenezuelaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"VE-{values.ToRegionCode()}";
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
            return Country.Venezuela;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.VE;
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