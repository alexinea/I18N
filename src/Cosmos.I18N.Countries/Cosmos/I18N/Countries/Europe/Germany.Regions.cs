using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Germany Regions
    /// </summary>
    public static partial class Germany
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Baden-Württemberg
            /// </summary>
            public static EnumValues BadenWürttemberg => EnumValues.BadenWürttemberg;

            /// <summary>
            /// Bayern, Bavaria
            /// </summary>
            public static EnumValues Bayern => EnumValues.Bayern;

            /// <summary>
            /// Berlin
            /// </summary>
            public static EnumValues Berlin => EnumValues.Berlin;

            /// <summary>
            /// Brandenburg
            /// </summary>
            public static EnumValues Brandenburg => EnumValues.Brandenburg;

            /// <summary>
            /// Bremen
            /// </summary>
            public static EnumValues Bremen => EnumValues.Bremen;

            /// <summary>
            /// Hamburg
            /// </summary>
            public static EnumValues Hamburg => EnumValues.Hamburg;

            /// <summary>
            /// Hessen, Hesse
            /// </summary>
            public static EnumValues Hessen => EnumValues.Hessen;

            /// <summary>
            /// Mecklenburg-Vorpommern
            /// </summary>
            public static EnumValues MecklenburgVorpommern => EnumValues.MecklenburgVorpommern;

            /// <summary>
            /// Niedersachsen, Lower Saxony
            /// </summary>
            public static EnumValues Niedersachsen => EnumValues.Niedersachsen;

            /// <summary>
            /// Nordrhein-Westfalen, North Rhine-Westphalia
            /// </summary>
            public static EnumValues NordrheinWestfalen => EnumValues.NordrheinWestfalen;

            /// <summary>
            /// Rheinland-Pfalz, Rhineland-Palatinate
            /// </summary>
            public static EnumValues RheinlandPfalz => EnumValues.RheinlandPfalz;

            /// <summary>
            /// Saarland
            /// </summary>
            public static EnumValues Saarland => EnumValues.Saarland;

            /// <summary>
            /// Sachsen, Saxony
            /// </summary>
            public static EnumValues Sachsen => EnumValues.Sachsen;

            /// <summary>
            /// Sachsen-Anhalt
            /// </summary>
            public static EnumValues SachsenAnhalt => EnumValues.SachsenAnhalt;

            /// <summary>
            /// Schleswig-Holstein
            /// </summary>
            public static EnumValues SchleswigHolstein => EnumValues.SchleswigHolstein;

            /// <summary>
            /// Thüringen
            /// </summary>
            public static EnumValues Thüringen => EnumValues.Thüringen;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Germany regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Baden-Württemberg
            /// </summary>
            [AliasInShort("BW")]
            [RegionCode(2_00_002_0001)]
            BadenWürttemberg,

            /// <summary>
            /// Bayern, Bavaria
            /// </summary>
            [AliasInShort("BY")]
            [RegionCode(2_00_002_0002)]
            Bayern,

            /// <summary>
            /// Berlin
            /// </summary>
            [AliasInShort("BE")]
            [RegionCode(2_00_002_0003)]
            Berlin,

            /// <summary>
            /// Brandenburg
            /// </summary>
            [AliasInShort("BB")]
            [RegionCode(2_00_002_0004)]
            Brandenburg,

            /// <summary>
            /// Bremen
            /// </summary>
            [AliasInShort("HB")]
            [RegionCode(2_00_002_0005)]
            Bremen,

            /// <summary>
            /// Hamburg
            /// </summary>
            [AliasInShort("HH")]
            [RegionCode(2_00_002_0006)]
            Hamburg,

            /// <summary>
            /// Hessen, Hesse
            /// </summary>
            [AliasInShort("HE")]
            [RegionCode(2_00_002_0007)]
            Hessen,

            /// <summary>
            /// Mecklenburg-Vorpommern
            /// </summary>
            [AliasInShort("MV")]
            [RegionCode(2_00_002_0008)]
            MecklenburgVorpommern,

            /// <summary>
            /// Niedersachsen, Lower Saxony
            /// </summary>
            [AliasInShort("NI")]
            [RegionCode(2_00_002_0009)]
            Niedersachsen,

            /// <summary>
            /// Nordrhein-Westfalen, North Rhine-Westphalia
            /// </summary>
            [AliasInShort("NW")]
            [RegionCode(2_00_002_0010)]
            NordrheinWestfalen,

            /// <summary>
            /// Rheinland-Pfalz, Rhineland-Palatinate
            /// </summary>
            [AliasInShort("RP")]
            [RegionCode(2_00_002_0011)]
            RheinlandPfalz,

            /// <summary>
            /// Saarland
            /// </summary>
            [AliasInShort("SL")]
            [RegionCode(2_00_002_0012)]
            Saarland,

            /// <summary>
            /// Sachsen, Saxony
            /// </summary>
            [AliasInShort("SN")]
            [RegionCode(2_00_002_0013)]
            Sachsen,

            /// <summary>
            /// Sachsen-Anhalt
            /// </summary>
            [AliasInShort("ST")]
            [RegionCode(2_00_002_0014)]
            SachsenAnhalt,

            /// <summary>
            /// Schleswig-Holstein
            /// </summary>
            [AliasInShort("SH")]
            [RegionCode(2_00_002_0015)]
            SchleswigHolstein,

            /// <summary>
            /// Thüringen
            /// </summary>
            [AliasInShort("TH")]
            [RegionCode(2_00_002_0016)]
            Thüringen,

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