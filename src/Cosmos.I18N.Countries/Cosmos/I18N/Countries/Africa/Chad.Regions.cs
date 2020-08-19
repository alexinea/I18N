using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Chad Regions
    /// </summary>
    public static partial class Chad
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Batha
            /// </summary>
            public static EnumValues Batha => EnumValues.Batha;

            /// <summary>
            /// Bahr el Gazel
            /// </summary>
            public static EnumValues BahrElGazel => EnumValues.BahrElGazel;

            /// <summary>
            /// Borkou
            /// </summary>
            public static EnumValues Borkou => EnumValues.Borkou;

            /// <summary>
            /// Chari-Baguirmi
            /// </summary>
            public static EnumValues ChariBaguirmi => EnumValues.ChariBaguirmi;

            /// <summary>
            /// Ennedi-Est
            /// </summary>
            public static EnumValues EnnediEst => EnumValues.EnnediEst;

            /// <summary>
            /// Ennedi-Ouest
            /// </summary>
            public static EnumValues EnnediOuest => EnumValues.EnnediOuest;

            /// <summary>
            /// Guéra
            /// </summary>
            public static EnumValues Guéra => EnumValues.Guéra;

            /// <summary>
            /// Hadjer-Lamis
            /// </summary>
            public static EnumValues HadjerLamis => EnumValues.HadjerLamis;

            /// <summary>
            /// Kanem
            /// </summary>
            public static EnumValues Kanem => EnumValues.Kanem;

            /// <summary>
            /// Lac
            /// </summary>
            public static EnumValues Lac => EnumValues.Lac;

            /// <summary>
            /// Logone Occidental
            /// </summary>
            public static EnumValues LogoneOccidental => EnumValues.LogoneOccidental;

            /// <summary>
            /// Logone Oriental
            /// </summary>
            public static EnumValues LogoneOriental => EnumValues.LogoneOriental;

            /// <summary>
            /// Mandoul
            /// </summary>
            public static EnumValues Mandoul => EnumValues.Mandoul;

            /// <summary>
            /// Moyen-Chari
            /// </summary>
            public static EnumValues MoyenChari => EnumValues.MoyenChari;

            /// <summary>
            /// Mayo-Kebbi Est
            /// </summary>
            public static EnumValues MayoKebbiEst => EnumValues.MayoKebbiEst;

            /// <summary>
            /// Mayo-Kebbi Ouest
            /// </summary>
            public static EnumValues MayoKebbiOuest => EnumValues.MayoKebbiOuest;

            /// <summary>
            /// N’Djamena
            /// </summary>
            public static EnumValues NDjamena => EnumValues.NDjamena;

            /// <summary>
            /// Ouaddaï
            /// </summary>
            public static EnumValues Ouaddaï => EnumValues.Ouaddaï;

            /// <summary>
            /// Salamat
            /// </summary>
            public static EnumValues Salamat => EnumValues.Salamat;

            /// <summary>
            /// Sila
            /// </summary>
            public static EnumValues Sila => EnumValues.Sila;

            /// <summary>
            /// Tandjilé
            /// </summary>
            public static EnumValues Tandjilé => EnumValues.Tandjilé;

            /// <summary>
            /// Tibesti
            /// </summary>
            public static EnumValues Tibesti => EnumValues.Tibesti;


            /// <summary>
            /// Wadi Fira
            /// </summary>
            public static EnumValues WadiFira => EnumValues.WadiFira;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Chad regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Batha
            /// </summary>
            [AliasInShort("BA")]
            [RegionCode(3_00_110_0001)]
            Batha,

            /// <summary>
            /// Bahr el Gazel
            /// </summary>
            [AliasInShort("BG")]
            [RegionCode(3_00_110_0002)]
            BahrElGazel,

            /// <summary>
            /// Borkou
            /// </summary>
            [AliasInShort("BO")]
            [RegionCode(3_00_110_0003)]
            Borkou,

            /// <summary>
            /// Chari-Baguirmi
            /// </summary>
            [AliasInShort("CB")]
            [RegionCode(3_00_110_0004)]
            ChariBaguirmi,

            /// <summary>
            /// Ennedi-Est
            /// </summary>
            [AliasInShort("EE")]
            [RegionCode(3_00_110_0005)]
            EnnediEst,

            /// <summary>
            /// Ennedi-Ouest
            /// </summary>
            [AliasInShort("EO")]
            [RegionCode(3_00_110_0006)]
            EnnediOuest,

            /// <summary>
            /// Guéra
            /// </summary>
            [AliasInShort("GR")]
            [RegionCode(3_00_110_0007)]
            Guéra,

            /// <summary>
            ///  Hadjer-Lamis
            /// </summary>
            [AliasInShort("HL")]
            [RegionCode(3_00_110_0008)]
            HadjerLamis,

            /// <summary>
            /// Kanem
            /// </summary>
            [AliasInShort("KA")]
            [RegionCode(3_00_110_0009)]
            Kanem,

            /// <summary>
            /// Lac
            /// </summary>
            [AliasInShort("LC")]
            [RegionCode(3_00_110_0010)]
            Lac,

            /// <summary>
            /// Logone Occidental
            /// </summary>
            [AliasInShort("LO")]
            [RegionCode(3_00_110_0011)]
            LogoneOccidental,

            /// <summary>
            /// Logone Oriental
            /// </summary>
            [AliasInShort("LR")]
            [RegionCode(3_00_110_0012)]
            LogoneOriental,

            /// <summary>
            /// Mandoul
            /// </summary>
            [AliasInShort("MA")]
            [RegionCode(3_00_110_0013)]
            Mandoul,

            /// <summary>
            /// Moyen-Chari
            /// </summary>
            [AliasInShort("MC")]
            [RegionCode(3_00_110_0014)]
            MoyenChari,

            /// <summary>
            /// Mayo-Kebbi Est
            /// </summary>
            [AliasInShort("ME")]
            [RegionCode(3_00_110_0015)]
            MayoKebbiEst,

            /// <summary>
            /// Mayo-Kebbi Ouest
            /// </summary>
            [AliasInShort("MO")]
            [RegionCode(3_00_110_0016)]
            MayoKebbiOuest,

            /// <summary>
            /// N’Djamena
            /// </summary>
            [AliasInShort("ND")]
            [RegionCode(3_00_110_0017)]
            NDjamena,

            /// <summary>
            /// Ouaddaï
            /// </summary>
            [AliasInShort("OD")]
            [RegionCode(3_00_110_0018)]
            Ouaddaï,

            /// <summary>
            /// Salamat
            /// </summary>
            [AliasInShort("SA")]
            [RegionCode(3_00_110_0019)]
            Salamat,

            /// <summary>
            /// Sila
            /// </summary>
            [AliasInShort("SI")]
            [RegionCode(3_00_110_0020)]
            Sila,

            /// <summary>
            /// Tandjilé
            /// </summary>
            [AliasInShort("TA")]
            [RegionCode(3_00_110_0021)]
            Tandjilé,

            /// <summary>
            /// Tibesti
            /// </summary>
            [AliasInShort("TI")]
            [RegionCode(3_00_110_0022)]
            Tibesti,

            /// <summary>
            /// Wadi Fira
            /// </summary>
            [AliasInShort("WF")]
            [RegionCode(3_00_110_0023)]
            WadiFira,

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