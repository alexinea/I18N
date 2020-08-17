using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Niger Regions
    /// </summary>
    public static class NigerRegions
    {
        #region Gets regions

        /// <summary>
        /// Agadez
        /// </summary>
        public static EnumValues Agadez => EnumValues.Agadez;

        /// <summary>
        /// Diffa
        /// </summary>
        public static EnumValues Diffa => EnumValues.Diffa;

        /// <summary>
        /// Dosso
        /// </summary>
        public static EnumValues Dosso => EnumValues.Dosso;

        /// <summary>
        /// Maradi
        /// </summary>
        public static EnumValues Maradi => EnumValues.Maradi;

        /// <summary>
        /// Tahoua
        /// </summary>
        public static EnumValues Tahoua => EnumValues.Tahoua;

        /// <summary>
        /// Tillabéri
        /// </summary>
        public static EnumValues Tillabéri => EnumValues.Tillabéri;

        /// <summary>
        /// Zinder
        /// </summary>
        public static EnumValues Zinder => EnumValues.Zinder;

        /// <summary>
        /// Niamey   
        /// </summary>
        public static EnumValues Niamey => EnumValues.Niamey;

        #endregion

        /// <summary>
        /// Enum values for Niger regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Agadez
            /// </summary>
            [AliasInShort("1")][RegionCode(3_00_143_0001)] Agadez,

            /// <summary>
            /// Diffa
            /// </summary>
            [AliasInShort("2")][RegionCode(3_00_143_0002)] Diffa,

            /// <summary>
            /// Dosso
            /// </summary>
            [AliasInShort("3")][RegionCode(3_00_143_0003)] Dosso,

            /// <summary>
            /// Maradi
            /// </summary>
            [AliasInShort("4")][RegionCode(3_00_143_0004)] Maradi,

            /// <summary>
            /// Tahoua
            /// </summary>
            [AliasInShort("5")][RegionCode(3_00_143_0005)] Tahoua,

            /// <summary>
            /// Tillabéri
            /// </summary>
            [AliasInShort("6")][RegionCode(3_00_143_0006)] Tillabéri,

            /// <summary>
            /// Zinder
            /// </summary>
            [AliasInShort("7")][RegionCode(3_00_143_0007)] Zinder,

            /// <summary>
            /// Niamey
            /// </summary>
            [AliasInShort("8")][RegionCode(3_00_143_0008)] Niamey,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="NigerRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="NigerRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"NE-{values.ToRegionCode()}";
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
            return Country.Niger;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.NE;
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