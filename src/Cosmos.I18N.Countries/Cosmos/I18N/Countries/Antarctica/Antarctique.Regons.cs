using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Antarctica
{
    /// <summary>
    /// Antarctique regions
    /// </summary>
    public static partial class Antarctique
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

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

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Antarctique regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Casey
            /// </summary>
            [AliasInShort("CA")]
            [RegionCode(7_00_010_0001)]
            Casey,

            /// <summary>
            /// Davis
            /// </summary>
            [AliasInShort("DA")]
            [RegionCode(7_00_010_0002)]
            Davis,

            /// <summary>
            /// DumontDUrville
            /// </summary>
            [AliasInShort("DU")]
            [RegionCode(7_00_010_0003)]
            DumontDUrville,

            /// <summary>
            /// Mawson
            /// </summary>
            [AliasInShort("MA")]
            [RegionCode(7_00_010_0004)]
            Mawson,

            /// <summary>
            /// Palmer
            /// </summary>
            [AliasInShort("PA")]
            [RegionCode(7_00_010_0005)]
            Palmer,

            /// <summary>
            /// Rothera
            /// </summary>
            [AliasInShort("RO")]
            [RegionCode(7_00_010_0006)]
            Rothera,

            /// <summary>
            /// Syowa
            /// </summary>
            [AliasInShort("SY")]
            [RegionCode(7_00_010_0007)]
            Syowa,

            /// <summary>
            /// Troll
            /// </summary>
            [AliasInShort("TR")]
            [RegionCode(7_00_010_0008)]
            Troll,

            /// <summary>
            /// Vostok
            /// </summary>
            [AliasInShort("VO")]
            [RegionCode(7_00_010_0009)]
            Vostok,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            [RegionCode(0)]
            Unknown,
        }

        #endregion

        #region All regions getter

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