using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// Palau Regions
    /// </summary>
    public static partial class Palau
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Kayangel
            /// </summary>
            public static EnumValues Kayangel => EnumValues.Kayangel;

            /// <summary>
            /// Koror
            /// </summary>
            public static EnumValues Koror => EnumValues.Koror;

            /// <summary>
            /// Melekeok
            /// </summary>
            public static EnumValues Melekeok => EnumValues.Melekeok;

            /// <summary>
            /// Ngaraard
            /// </summary>
            public static EnumValues Ngaraard => EnumValues.Ngaraard;

            /// <summary>
            /// Ngarchelong
            /// </summary>
            public static EnumValues Ngarchelong => EnumValues.Ngarchelong;

            /// <summary>
            /// Dohuk
            /// </summary>
            public static EnumValues Ngardmau => EnumValues.Ngardmau;

            /// <summary>
            /// Ngatpang
            /// </summary>
            public static EnumValues Ngatpang => EnumValues.Ngatpang;

            /// <summary>
            /// Ngchesar  
            /// </summary>
            public static EnumValues Ngchesar => EnumValues.Ngchesar;

            /// <summary>
            /// Ngeremlengui
            /// </summary>
            public static EnumValues Ngeremlengui => EnumValues.Ngeremlengui;

            /// <summary>
            /// Ngiwal
            /// </summary>
            public static EnumValues Ngiwal => EnumValues.Ngiwal;

            /// <summary>
            /// Peleliu
            /// </summary>
            public static EnumValues Peleliu => EnumValues.Peleliu;

            /// <summary>
            /// Sonsorol
            /// </summary>
            public static EnumValues Sonsorol => EnumValues.Sonsorol;

            /// <summary>
            /// Aimeliik
            /// </summary>
            public static EnumValues Aimeliik => EnumValues.Aimeliik;

            /// <summary>
            /// Airai
            /// </summary>
            public static EnumValues Airai => EnumValues.Airai;

            /// <summary>
            /// Angaur
            /// </summary>
            public static EnumValues Angaur => EnumValues.Angaur;

            /// <summary>
            /// Hatohobei
            /// </summary>
            public static EnumValues Hatohobei => EnumValues.Hatohobei;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Palau regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Kayangel
            /// </summary>
            [AliasInShort("100")]
            [RegionCode(6_00_113_0100)]
            Kayangel,

            /// <summary>
            /// Koror
            /// </summary>
            [AliasInShort("150")]
            [RegionCode(6_00_113_0150)]
            Koror,

            /// <summary>
            /// Melekeok
            /// </summary>
            [AliasInShort("212")]
            [RegionCode(6_00_113_0212)]
            Melekeok,

            /// <summary>
            /// Ngaraard
            /// </summary>
            [AliasInShort("214")]
            [RegionCode(6_00_113_0214)]
            Ngaraard,

            /// <summary>
            /// Ngarchelong
            /// </summary>
            [AliasInShort("218")]
            [RegionCode(6_00_113_0218)]
            Ngarchelong,

            /// <summary>
            /// Ngardmau
            /// </summary>
            [AliasInShort("222")]
            [RegionCode(6_00_113_0222)]
            Ngardmau,

            /// <summary>
            /// Ngatpang
            /// </summary>
            [AliasInShort("224")]
            [RegionCode(6_00_113_0224)]
            Ngatpang,

            /// <summary>
            /// Ngchesar
            /// </summary>
            [AliasInShort("226")]
            [RegionCode(6_00_113_0226)]
            Ngchesar,

            /// <summary>
            /// Ngeremlengui
            /// </summary>
            [AliasInShort("227")]
            [RegionCode(6_00_113_0227)]
            Ngeremlengui,

            /// <summary>
            /// Ngiwal
            /// </summary>
            [AliasInShort("228")]
            [RegionCode(6_00_113_0228)]
            Ngiwal,

            /// <summary>
            /// Peleliu
            /// </summary>
            [AliasInShort("350")]
            [RegionCode(6_00_113_0350)]
            Peleliu,

            /// <summary>
            /// Sonsorol
            /// </summary>
            [AliasInShort("370")]
            [RegionCode(6_00_113_0370)]
            Sonsorol,

            /// <summary>
            /// Aimeliik
            /// </summary>
            [AliasInShort("002")]
            [RegionCode(6_00_113_0002)]
            Aimeliik,

            /// <summary>
            /// Airai
            /// </summary>
            [AliasInShort("004")]
            [RegionCode(6_00_113_0004)]
            Airai,

            /// <summary>
            /// Angaur
            /// </summary>
            [AliasInShort("010")]
            [RegionCode(6_00_113_0010)]
            Angaur,

            /// <summary>
            /// Hatohobei
            /// </summary>
            [AliasInShort("050")]
            [RegionCode(6_00_113_0050)]
            Hatohobei,

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