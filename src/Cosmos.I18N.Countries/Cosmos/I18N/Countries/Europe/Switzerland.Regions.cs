using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Switzerland regions
    /// </summary>
    public static partial class Switzerland
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Canton of Zürich
            /// </summary>
            public static EnumValues CantonOfZürich => EnumValues.CantonOfZürich;

            /// <summary>
            /// Canton of Bern
            /// </summary>
            public static EnumValues CantonOfBern => EnumValues.CantonOfBern;

            /// <summary>
            /// Canton of Lucerne
            /// </summary>
            public static EnumValues CantonOfLucerne => EnumValues.CantonOfLucerne;

            /// <summary>
            /// Canton of Uri
            /// </summary>
            public static EnumValues CantonOfUri => EnumValues.CantonOfUri;

            /// <summary>
            /// Canton of Schwyz
            /// </summary>
            public static EnumValues CantonOfSchwyz => EnumValues.CantonOfSchwyz;

            /// <summary>
            /// Canton of Obwalden
            /// </summary>
            public static EnumValues CantonOfObwalden => EnumValues.CantonOfObwalden;

            /// <summary>
            /// Canton of Nidwalden
            /// </summary>
            public static EnumValues CantonOfNidwalden => EnumValues.CantonOfNidwalden;

            /// <summary>
            /// Canton of Glarus, GL
            /// </summary>
            public static EnumValues CantonOfGlarus => EnumValues.CantonOfGlarus;

            /// <summary>
            /// Canton of Zug => EnumValues. ZG
            /// </summary>
            public static EnumValues CantonOfZug => EnumValues.CantonOfZug;

            /// <summary>
            /// Canton of Fribourg => EnumValues. FR
            /// </summary>
            public static EnumValues CantonOfFribourg => EnumValues.CantonOfFribourg;

            /// <summary>
            /// Canton of Solothurn => EnumValues. SO
            /// </summary>
            public static EnumValues CantonOfSolothurn => EnumValues.CantonOfSolothurn;

            /// <summary>
            /// Canton of Basel-City => EnumValues. BS
            /// </summary>
            public static EnumValues CantonOfBaselCity => EnumValues.CantonOfBaselCity;

            /// <summary>
            /// Canton of Basel-Country => EnumValues. BL
            /// </summary>
            public static EnumValues CantonOfBaselCountry => EnumValues.CantonOfBaselCountry;

            /// <summary>
            /// Canton of Schaffhausen => EnumValues. SH
            /// </summary>
            public static EnumValues CantonOfSchaffhausen => EnumValues.CantonOfSchaffhausen;

            /// <summary>
            /// Canton of Appenzell Outer Rhodes => EnumValues. AR
            /// </summary>
            public static EnumValues CantonOfAppenzellOuterRhodes => EnumValues.CantonOfAppenzellOuterRhodes;

            /// <summary>
            /// Canton of Appenzell Inner-Rhodes => EnumValues. AI
            /// </summary>
            public static EnumValues CantonOfAppenzellInnerRhodes => EnumValues.CantonOfAppenzellInnerRhodes;

            /// <summary>
            /// Canton of St. Gallen => EnumValues. SG
            /// </summary>
            public static EnumValues CantonOfStGallen => EnumValues.CantonOfStGallen;

            /// <summary>
            /// Canton of Grisons => EnumValues. GR
            /// </summary>
            public static EnumValues CantonOfGrisons => EnumValues.CantonOfGrisons;

            /// <summary>
            /// Canton of Aargau => EnumValues. AG
            /// </summary>
            public static EnumValues CantonOfAargau => EnumValues.CantonOfAargau;

            /// <summary>
            /// Canton of Thurgau => EnumValues. TG
            /// </summary>
            public static EnumValues CantonOfThurgau => EnumValues.CantonOfThurgau;

            /// <summary>
            /// Canton of Ticino => EnumValues. TI
            /// </summary>
            public static EnumValues CantonOfTicino => EnumValues.CantonOfTicino;

            /// <summary>
            /// Canton of Vaud => EnumValues. VD
            /// </summary>
            public static EnumValues CantonOfVaud => EnumValues.CantonOfVaud;

            /// <summary>
            /// Canton of Valais => EnumValues. VS
            /// </summary>
            public static EnumValues CantonOfValais => EnumValues.CantonOfValais;

            /// <summary>
            /// Canton of Neuchâtel => EnumValues. NE
            /// </summary>
            public static EnumValues CantonOfNeuchâtel => EnumValues.CantonOfNeuchâtel;

            /// <summary>
            /// Canton of Geneva => EnumValues. GE
            /// </summary>
            public static EnumValues CantonOfGeneva => EnumValues.CantonOfGeneva;

            /// <summary>
            /// Canton of Jura => EnumValues. JU
            /// </summary>
            public static EnumValues CantonOfJura => EnumValues.CantonOfJura;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Switzerland regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Canton of Zürich
            /// </summary>
            [AliasInShort("ZH")]
            [RegionCode(2_00_017_0001)]
            CantonOfZürich,

            /// <summary>
            /// Canton of Bern
            /// </summary>
            [AliasInShort("BE")]
            [RegionCode(2_00_017_0002)]
            CantonOfBern,

            /// <summary>
            /// Massana
            /// </summary>
            [AliasInShort("LO")]
            [RegionCode(2_00_017_0003)]
            CantonOfLucerne,

            /// <summary>
            /// Canton of Uri
            /// </summary>
            [AliasInShort("UR")]
            [RegionCode(2_00_017_0004)]
            CantonOfUri,

            /// <summary>
            /// Canton of Schwyz
            /// </summary>
            [AliasInShort("SZ")]
            [RegionCode(2_00_017_0005)]
            CantonOfSchwyz,

            /// <summary>
            /// Canton of Obwalden
            /// </summary>
            [AliasInShort("OW")]
            [RegionCode(2_00_017_0006)]
            CantonOfObwalden,

            /// <summary>
            /// Canton of Nidwalden
            /// </summary>
            [AliasInShort("NW")]
            [RegionCode(2_00_017_0007)]
            CantonOfNidwalden,

            /// <summary>
            /// Canton of Glarus, GL
            /// </summary>
            [AliasInShort("GL")]
            [RegionCode(2_00_017_0008)]
            CantonOfGlarus,

            /// <summary>
            /// Canton of Zug, ZG
            /// </summary>
            [AliasInShort("ZG")]
            [RegionCode(2_00_017_0009)]
            CantonOfZug,

            /// <summary>
            /// Canton of Fribourg, FR
            /// </summary>
            [AliasInShort("FR")]
            [RegionCode(2_00_017_0010)]
            CantonOfFribourg,

            /// <summary>
            /// Canton of Solothurn, SO
            /// </summary>
            [AliasInShort("SO")]
            [RegionCode(2_00_017_0011)]
            CantonOfSolothurn,

            /// <summary>
            /// Canton of Basel-City, BS
            /// </summary>
            [AliasInShort("BS")]
            [RegionCode(2_00_017_0012)]
            CantonOfBaselCity,

            /// <summary>
            /// Canton of Basel-Country, BL
            /// </summary>
            [AliasInShort("BL")]
            [RegionCode(2_00_017_0013)]
            CantonOfBaselCountry,

            /// <summary>
            /// Canton of Schaffhausen, SH
            /// </summary>
            [AliasInShort("SH")]
            [RegionCode(2_00_017_0014)]
            CantonOfSchaffhausen,

            /// <summary>
            /// Canton of Appenzell Outer Rhodes, AR
            /// </summary>
            [AliasInShort("AR")]
            [RegionCode(2_00_017_0015)]
            CantonOfAppenzellOuterRhodes,

            /// <summary>
            /// Canton of Appenzell Inner-Rhodes, AI
            /// </summary>
            [AliasInShort("AI")]
            [RegionCode(2_00_017_0016)]
            CantonOfAppenzellInnerRhodes,

            /// <summary>
            /// Canton of St. Gallen, SG
            /// </summary>
            [AliasInShort("SG")]
            [RegionCode(2_00_017_0017)]
            CantonOfStGallen,

            /// <summary>
            /// Canton of Grisons, GR
            /// </summary>
            [AliasInShort("GR")]
            [RegionCode(2_00_017_0018)]
            CantonOfGrisons,

            /// <summary>
            /// Canton of Aargau, AG
            /// </summary>
            [AliasInShort("AG")]
            [RegionCode(2_00_017_0019)]
            CantonOfAargau,

            /// <summary>
            /// Canton of Thurgau, TG
            /// </summary>
            [AliasInShort("TG")]
            [RegionCode(2_00_017_0020)]
            CantonOfThurgau,

            /// <summary>
            /// Canton of Ticino, TI
            /// </summary>
            [AliasInShort("TI")]
            [RegionCode(2_00_017_0021)]
            CantonOfTicino,

            /// <summary>
            /// Canton of Vaud, VD
            /// </summary>
            [AliasInShort("VD")]
            [RegionCode(2_00_017_0022)]
            CantonOfVaud,

            /// <summary>
            /// Canton of Valais, VS
            /// </summary>
            [AliasInShort("VS")]
            [RegionCode(2_00_017_0023)]
            CantonOfValais,

            /// <summary>
            /// Canton of Neuchâtel, NE
            /// </summary>
            [AliasInShort("NE")]
            [RegionCode(2_00_017_0024)]
            CantonOfNeuchâtel,

            /// <summary>
            /// Canton of Geneva, GE
            /// </summary>
            [AliasInShort("GE")]
            [RegionCode(2_00_017_0025)]
            CantonOfGeneva,

            /// <summary>
            /// Canton of Jura, JU
            /// </summary>
            [AliasInShort("JU")]
            [RegionCode(2_00_017_0026)]
            CantonOfJura,

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