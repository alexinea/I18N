using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Moldova Regions
    /// </summary>
    public static partial class Moldova
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Anenii Noi
            /// </summary>
            public static EnumValues AneniiNoi => EnumValues.AneniiNoi;

            /// <summary>
            /// Bălţi
            /// </summary>
            public static EnumValues Bălţi => EnumValues.Bălţi;

            /// <summary>
            /// Bender
            /// </summary>
            public static EnumValues Bender => EnumValues.Bender;

            /// <summary>
            /// Briceni
            /// </summary>
            public static EnumValues Briceni => EnumValues.Briceni;

            /// <summary>
            /// Basarabeasca
            /// </summary>
            public static EnumValues Basarabeasca => EnumValues.Basarabeasca;

            /// <summary>
            /// Cahul
            /// </summary>
            public static EnumValues Cahul => EnumValues.Cahul;

            /// <summary>
            /// Călărași
            /// </summary>
            public static EnumValues Călărași => EnumValues.Călărași;

            /// <summary>
            /// Cimișlia
            /// </summary>
            public static EnumValues Cimișlia => EnumValues.Cimișlia;

            /// <summary>
            /// Criuleni
            /// </summary>
            public static EnumValues Criuleni => EnumValues.Criuleni;

            /// <summary>
            /// Căușeni
            /// </summary>
            public static EnumValues Căușeni => EnumValues.Căușeni;

            /// <summary>
            /// Cantemir
            /// </summary>
            public static EnumValues Cantemir => EnumValues.Cantemir;

            /// <summary>
            /// Chișinău
            /// </summary>
            public static EnumValues Chișinău => EnumValues.Chișinău;

            /// <summary>
            /// Dondușeni
            /// </summary>
            public static EnumValues Dondușeni => EnumValues.Dondușeni;

            /// <summary>
            /// Drochia
            /// </summary>
            public static EnumValues Drochia => EnumValues.Drochia;

            /// <summary>
            /// Dubăsari
            /// </summary>
            public static EnumValues Dubăsari => EnumValues.Dubăsari;

            /// <summary>
            /// Edineț
            /// </summary>
            public static EnumValues Edineț => EnumValues.Edineț;

            /// <summary>
            /// Fălești
            /// </summary>
            public static EnumValues Fălești => EnumValues.Fălești;

            /// <summary>
            /// Florești
            /// </summary>
            public static EnumValues Florești => EnumValues.Florești;

            /// <summary>
            /// Gagauzia
            /// </summary>
            public static EnumValues Gagauzia => EnumValues.Gagauzia;

            /// <summary>
            /// Glodeni
            /// </summary>
            public static EnumValues Glodeni => EnumValues.Glodeni;

            /// <summary>
            /// Hîncești
            /// </summary>
            public static EnumValues Hîncești => EnumValues.Hîncești;

            /// <summary>
            /// Ialoveni
            /// </summary>
            public static EnumValues Ialoveni => EnumValues.Ialoveni;

            /// <summary>
            /// Leova
            /// </summary>
            public static EnumValues Leova => EnumValues.Leova;

            /// <summary>
            /// Nisporeni
            /// </summary>
            public static EnumValues Nisporeni => EnumValues.Nisporeni;

            /// <summary>
            /// Ocniţa
            /// </summary>
            public static EnumValues Ocniţa => EnumValues.Ocniţa;

            /// <summary>
            /// Orhei
            /// </summary>
            public static EnumValues Orhei => EnumValues.Orhei;

            /// <summary>
            /// Rezina
            /// </summary>
            public static EnumValues Rezina => EnumValues.Rezina;

            /// <summary>
            /// Rîșcani
            /// </summary>
            public static EnumValues Rîșcani => EnumValues.Rîșcani;

            /// <summary>
            /// Șoldănești
            /// </summary>
            public static EnumValues Șoldănești => EnumValues.Șoldănești;

            /// <summary>
            /// Sîngerei
            /// </summary>
            public static EnumValues Sîngerei => EnumValues.Sîngerei;

            /// <summary>
            /// Transnistria
            /// </summary>
            public static EnumValues Transnistria => EnumValues.Transnistria;

            /// <summary>
            /// Soroca
            /// </summary>
            public static EnumValues Soroca => EnumValues.Soroca;

            /// <summary>
            /// Strășeni
            /// </summary>
            public static EnumValues Strășeni => EnumValues.Strășeni;

            /// <summary>
            /// Ştefan Vodă
            /// </summary>
            public static EnumValues ŞtefanVodă => EnumValues.ŞtefanVodă;

            /// <summary>
            /// Taraclia
            /// </summary>
            public static EnumValues Taraclia => EnumValues.Taraclia;

            /// <summary>
            /// Telenești
            /// </summary>
            public static EnumValues Telenești => EnumValues.Telenești;

            /// <summary>
            /// Ungheni
            /// </summary>
            public static EnumValues Ungheni => EnumValues.Ungheni;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Moldova regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Anenii Noi
            /// </summary>
            [AliasInShort("AN")]
            [RegionCode(2_00_128_0001)]
            AneniiNoi,

            /// <summary>
            /// Bălţi
            /// </summary>
            [AliasInShort("BA")]
            [RegionCode(2_00_128_0002)]
            Bălţi,

            /// <summary>
            /// Bender
            /// </summary>
            [AliasInShort("BD")]
            [RegionCode(2_00_128_0003)]
            Bender,

            /// <summary>
            /// Briceni
            /// </summary>
            [AliasInShort("BR")]
            [RegionCode(2_00_128_0004)]
            Briceni,

            /// <summary>
            /// Basarabeasca
            /// </summary>
            [AliasInShort("BS")]
            [RegionCode(2_00_128_0005)]
            Basarabeasca,

            /// <summary>
            /// Cahul
            /// </summary>
            [AliasInShort("CA")]
            [RegionCode(2_00_128_0006)]
            Cahul,

            /// <summary>
            /// Călărași
            /// </summary>
            [AliasInShort("CL")]
            [RegionCode(2_00_128_0007)]
            Călărași,

            /// <summary>
            /// Cimișlia
            /// </summary>
            [AliasInShort("CM")]
            [RegionCode(2_00_128_0008)]
            Cimișlia,

            /// <summary>
            /// Criuleni
            /// </summary>
            [AliasInShort("CR")]
            [RegionCode(2_00_128_0009)]
            Criuleni,

            /// <summary>
            /// Căușeni
            /// </summary>
            [AliasInShort("CS")]
            [RegionCode(2_00_128_0010)]
            Căușeni,

            /// <summary>
            /// Cantemir
            /// </summary>
            [AliasInShort("CT")]
            [RegionCode(2_00_128_0011)]
            Cantemir,

            /// <summary>
            /// Chișinău
            /// </summary>
            [AliasInShort("CU")]
            [RegionCode(2_00_128_0012)]
            Chișinău,

            /// <summary>
            /// Dondușeni
            /// </summary>
            [AliasInShort("DO")]
            [RegionCode(2_00_128_0013)]
            Dondușeni,

            /// <summary>
            /// Drochia
            /// </summary>
            [AliasInShort("DR")]
            [RegionCode(2_00_128_0014)]
            Drochia,

            /// <summary>
            /// Dubăsari
            /// </summary>
            [AliasInShort("DU")]
            [RegionCode(2_00_128_0015)]
            Dubăsari,

            /// <summary>
            /// Edineț
            /// </summary>
            [AliasInShort("ED")]
            [RegionCode(2_00_128_0016)]
            Edineț,

            /// <summary>
            /// Fălești
            /// </summary>
            [AliasInShort("FA")]
            [RegionCode(2_00_128_0017)]
            Fălești,

            /// <summary>
            /// Florești
            /// </summary>
            [AliasInShort("FL")]
            [RegionCode(2_00_128_0018)]
            Florești,

            /// <summary>
            /// Gagauzia
            /// </summary>
            [AliasInShort("GA")]
            [RegionCode(2_00_128_0019)]
            Gagauzia,

            /// <summary>
            /// Glodeni
            /// </summary>
            [AliasInShort("GL")]
            [RegionCode(2_00_128_0020)]
            Glodeni,

            /// <summary>
            /// Hîncești
            /// </summary>
            [AliasInShort("HI")]
            [RegionCode(2_00_128_0021)]
            Hîncești,

            /// <summary>
            /// Ialoveni
            /// </summary>
            [AliasInShort("IA")]
            [RegionCode(2_00_128_0022)]
            Ialoveni,

            /// <summary>
            /// Leova
            /// </summary>
            [AliasInShort("LE")]
            [RegionCode(2_00_128_0023)]
            Leova,

            /// <summary>
            /// Nisporeni
            /// </summary>
            [AliasInShort("NI")]
            [RegionCode(2_00_128_0024)]
            Nisporeni,

            /// <summary>
            /// Ocniţa
            /// </summary>
            [AliasInShort("OC")]
            [RegionCode(2_00_128_0025)]
            Ocniţa,

            /// <summary>
            /// Orhei
            /// </summary>
            [AliasInShort("OR")]
            [RegionCode(2_00_128_0026)]
            Orhei,

            /// <summary>
            /// Rezina
            /// </summary>
            [AliasInShort("RE")]
            [RegionCode(2_00_128_0027)]
            Rezina,

            /// <summary>
            /// Rîșcani
            /// </summary>
            [AliasInShort("RI")]
            [RegionCode(2_00_128_0028)]
            Rîșcani,

            /// <summary>
            /// Șoldănești
            /// </summary>
            [AliasInShort("SD")]
            [RegionCode(2_00_128_0029)]
            Șoldănești,

            /// <summary>
            /// Sîngerei
            /// </summary>
            [AliasInShort("SI")]
            [RegionCode(2_00_128_0030)]
            Sîngerei,

            /// <summary>
            /// Transnistria
            /// </summary>
            [AliasInShort("SM")]
            [RegionCode(2_00_128_0031)]
            Transnistria,

            /// <summary>
            /// Soroca
            /// </summary>
            [AliasInShort("SO")]
            [RegionCode(2_00_128_0032)]
            Soroca,

            /// <summary>
            /// Strășeni
            /// </summary>
            [AliasInShort("ST")]
            [RegionCode(2_00_128_0033)]
            Strășeni,

            /// <summary>
            /// Ştefan Vodă
            /// </summary>
            [AliasInShort("SV")]
            [RegionCode(2_00_128_0034)]
            ŞtefanVodă,

            /// <summary>
            /// Taraclia
            /// </summary>
            [AliasInShort("TA")]
            [RegionCode(2_00_128_0035)]
            Taraclia,

            /// <summary>
            /// Telenești
            /// </summary>
            [AliasInShort("TE")]
            [RegionCode(2_00_128_0036)]
            Telenești,

            /// <summary>
            /// Ungheni
            /// </summary>
            [AliasInShort("UN")]
            [RegionCode(2_00_128_0037)]
            Ungheni,

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