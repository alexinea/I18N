using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Antarctica
{
    /// <summary>
    /// Antarctique regions
    /// </summary>
    public static class AntarctiqueRegons
    {
        #region Gets regions

        /// <summary>
        /// Casey
        /// </summary>
        public static EnumValues Casey => EnumValues.Casey;

        /// <summary>
        /// Davis
        /// </summary>
        public static EnumValues Davis => EnumValues.Davis;

        /// <summary>
        /// DumontDUrville
        /// </summary>
        public static EnumValues DumontDUrville => EnumValues.DumontDUrville;

        /// <summary>
        /// Mawson
        /// </summary>
        public static EnumValues Mawson => EnumValues.Mawson;

        /// <summary>
        /// Palmer
        /// </summary>
        public static EnumValues Palmer => EnumValues.Palmer;

        /// <summary>
        /// Rothera
        /// </summary>
        public static EnumValues Rothera => EnumValues.Rothera;

        /// <summary>
        /// Syowa
        /// </summary>
        public static EnumValues Syowa => EnumValues.Syowa;

        /// <summary>
        /// Troll
        /// </summary>
        public static EnumValues Troll => EnumValues.Troll;

        /// <summary>
        /// Vostok
        /// </summary>
        public static EnumValues Vostok => EnumValues.Vostok;

        #endregion

        /// <summary>
        /// Enum values for Antarctique regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Casey
            /// </summary>
            [AliasInShort("CA")] [RegionCode(7_00_010_0001)]
            Casey,

            /// <summary>
            /// Davis
            /// </summary>
            [AliasInShort("DA")] [RegionCode(7_00_010_0002)]
            Davis,

            /// <summary>
            /// DumontDUrville
            /// </summary>
            [AliasInShort("DU")] [RegionCode(7_00_010_0003)]
            DumontDUrville,

            /// <summary>
            /// Mawson
            /// </summary>
            [AliasInShort("MA")] [RegionCode(7_00_010_0004)]
            Mawson,

            /// <summary>
            /// Palmer
            /// </summary>
            [AliasInShort("PA")] [RegionCode(7_00_010_0005)]
            Palmer,

            /// <summary>
            /// Rothera
            /// </summary>
            [AliasInShort("RO")] [RegionCode(7_00_010_0006)]
            Rothera,

            /// <summary>
            /// Syowa
            /// </summary>
            [AliasInShort("SY")] [RegionCode(7_00_010_0007)]
            Syowa,

            /// <summary>
            /// Troll
            /// </summary>
            [AliasInShort("TR")] [RegionCode(7_00_010_0008)]
            Troll,

            /// <summary>
            /// Vostok
            /// </summary>
            [AliasInShort("VO")] [RegionCode(7_00_010_0009)]
            Vostok,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="AntarctiqueRegons.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="AntarctiqueRegons.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"AQ-{values.ToRegionCode()}";
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
            return Country.Antarctique;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.AQ;
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