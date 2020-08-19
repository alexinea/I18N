using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Botswana regions
    /// </summary>
    public static partial class Botswana
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Central
            /// </summary>
            public static EnumValues Central => EnumValues.Central;

            /// <summary>
            /// Chobe
            /// </summary>
            public static EnumValues Chobe => EnumValues.Chobe;

            /// <summary>
            /// Francistown
            /// </summary>
            public static EnumValues Francistown => EnumValues.Francistown;

            /// <summary>
            /// Gaborone
            /// </summary>
            public static EnumValues Gaborone => EnumValues.Gaborone;

            /// <summary>
            /// Ghanzi
            /// </summary>
            public static EnumValues Ghanzi => EnumValues.Ghanzi;

            /// <summary>
            /// Jwaneng
            /// </summary>
            public static EnumValues Jwaneng => EnumValues.Jwaneng;

            /// <summary>
            /// Kgalagadi
            /// </summary>
            public static EnumValues Kgalagadi => EnumValues.Kgalagadi;

            /// <summary>
            /// Kgatleng
            /// </summary>
            public static EnumValues Kgatleng => EnumValues.Kgatleng;

            /// <summary>
            /// Kweneng
            /// </summary>
            public static EnumValues Kweneng => EnumValues.Kweneng;

            /// <summary>
            /// Lobatse
            /// </summary>
            public static EnumValues Lobatse => EnumValues.Lobatse;

            /// <summary>
            ///  North East
            /// </summary>
            public static EnumValues NorthEast => EnumValues.NorthEast;

            /// <summary>
            /// North West
            /// </summary>
            public static EnumValues NorthWest => EnumValues.NorthWest;

            /// <summary>
            /// South East
            /// </summary>
            public static EnumValues SouthEast => EnumValues.SouthEast;

            /// <summary>
            /// Southern
            /// </summary>
            public static EnumValues Southern => EnumValues.Southern;

            /// <summary>
            /// Selibe Phikwe
            /// </summary>
            public static EnumValues SelibePhikwe => EnumValues.SelibePhikwe;

            /// <summary>
            ///  Sowa Town
            /// </summary>
            public static EnumValues SowaTown => EnumValues.SowaTown;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Botswana regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("CE")]
            [RegionCode(3_00_104_0001)]
            Central,

            /// <summary>
            /// Chobe
            /// </summary>
            [AliasInShort("CH")]
            [RegionCode(3_00_104_0002)]
            Chobe,

            /// <summary>
            /// Francistown
            /// </summary>
            [AliasInShort("FR")]
            [RegionCode(3_00_104_0003)]
            Francistown,

            /// <summary>
            /// Gaborone
            /// </summary>
            [AliasInShort("GA")]
            [RegionCode(3_00_104_0004)]
            Gaborone,

            /// <summary>
            /// Ghanzi
            /// </summary>
            [AliasInShort("GH")]
            [RegionCode(3_00_104_0005)]
            Ghanzi,

            /// <summary>
            /// Jwaneng
            /// </summary>
            [AliasInShort("JW")]
            [RegionCode(3_00_104_0006)]
            Jwaneng,

            /// <summary>
            /// Kgalagadi
            /// </summary>
            [AliasInShort("KG")]
            [RegionCode(3_00_104_0007)]
            Kgalagadi,

            /// <summary>
            /// Kgatleng
            /// </summary>
            [AliasInShort("KL")]
            [RegionCode(3_00_104_0008)]
            Kgatleng,

            /// <summary>
            /// Kweneng
            /// </summary>
            [AliasInShort("KW")]
            [RegionCode(3_00_104_0009)]
            Kweneng,

            /// <summary>
            /// Lobatse
            /// </summary>
            [AliasInShort("LO")]
            [RegionCode(3_00_104_0010)]
            Lobatse,

            /// <summary>
            ///  North East
            /// </summary>
            [AliasInShort("NE")]
            [RegionCode(3_00_104_0011)]
            NorthEast,

            /// <summary>
            /// North West
            /// </summary>
            [AliasInShort("NW")]
            [RegionCode(3_00_104_0012)]
            NorthWest,

            /// <summary>
            /// South East
            /// </summary>
            [AliasInShort("SE")]
            [RegionCode(3_00_104_0013)]
            SouthEast,

            /// <summary>
            /// Southern
            /// </summary>
            [AliasInShort("SO")]
            [RegionCode(3_00_104_0014)]
            Southern,


            /// <summary>
            /// Selibe Phikwe
            /// </summary>
            [AliasInShort("SP")]
            [RegionCode(3_00_104_000)]
            SelibePhikwe,


            /// <summary>
            ///  Sowa Town
            /// </summary>
            [AliasInShort("ST")]
            [RegionCode(3_00_104_000)]
            SowaTown,

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