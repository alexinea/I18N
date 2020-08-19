using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// Brazil Regions
    /// </summary>
    public static partial class Brazil
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Acre
            /// </summary>
            public static EnumValues Acre => EnumValues.Acre;

            /// <summary>
            /// Alagoas
            /// </summary>
            public static EnumValues Alagoas => EnumValues.Alagoas;

            /// <summary>
            /// Amazonas
            /// </summary>
            public static EnumValues Amazonas => EnumValues.Amazonas;

            /// <summary>
            /// Amapá
            /// </summary>
            public static EnumValues Amapá => EnumValues.Amapá;

            /// <summary>
            /// Bahia
            /// </summary>
            public static EnumValues Bahia => EnumValues.Bahia;

            /// <summary>
            /// Ceará
            /// </summary>
            public static EnumValues Ceará => EnumValues.Ceará;

            /// <summary>
            /// Distrito Federal
            /// </summary>
            public static EnumValues DistritoFederal => EnumValues.DistritoFederal;

            /// <summary>
            /// Espírito Santo
            /// </summary>
            public static EnumValues EspíritoSanto => EnumValues.EspíritoSanto;

            /// <summary>
            /// Goiás
            /// </summary>
            public static EnumValues Goiás => EnumValues.Goiás;

            /// <summary>
            /// Maranhão
            /// </summary>
            public static EnumValues Maranhão => EnumValues.Maranhão;

            /// <summary>
            /// Minas Gerais
            /// </summary>
            public static EnumValues MinasGerais => EnumValues.MinasGerais;

            /// <summary>
            /// Mato Grosso do Sul
            /// </summary>
            public static EnumValues MatoGrossoDoSul => EnumValues.MatoGrossoDoSul;

            /// <summary>
            /// Mato Grosso
            /// </summary>
            public static EnumValues MatoGrosso => EnumValues.MatoGrosso;

            /// <summary>
            /// Pará
            /// </summary>
            public static EnumValues Pará => EnumValues.Pará;

            /// <summary>
            /// Paraíba
            /// </summary>
            public static EnumValues Paraíba => EnumValues.Paraíba;

            /// <summary>
            /// Pernambuco
            /// </summary>
            public static EnumValues Pernambuco => EnumValues.Pernambuco;

            /// <summary>
            /// Piauí
            /// </summary>
            public static EnumValues Piauí => EnumValues.Piauí;

            /// <summary>
            /// Paraná
            /// </summary>
            public static EnumValues Paraná => EnumValues.Paraná;

            /// <summary>
            /// Rio de Janeiro
            /// </summary>
            public static EnumValues RioDeJaneiro => EnumValues.RioDeJaneiro;

            /// <summary>
            /// Rio Grande do Norte
            /// </summary>
            public static EnumValues RioGrandeDoNorte => EnumValues.RioGrandeDoNorte;

            /// <summary>
            /// Rondônia
            /// </summary>
            public static EnumValues Rondônia => EnumValues.Rondônia;

            /// <summary>
            /// Roraima
            /// </summary>
            public static EnumValues Roraima => EnumValues.Roraima;

            /// <summary>
            /// Rio Grande do Sul
            /// </summary>
            public static EnumValues RioGrandeDoSul => EnumValues.RioGrandeDoSul;

            /// <summary>
            /// Santa Catarina
            /// </summary>
            public static EnumValues SantaCatarina => EnumValues.SantaCatarina;

            /// <summary>
            /// Sergipe
            /// </summary>
            public static EnumValues Sergipe => EnumValues.Sergipe;

            /// <summary>
            /// São Paulo
            /// </summary>
            public static EnumValues SãoPaulo => EnumValues.SãoPaulo;

            /// <summary>
            /// Tocantins
            /// </summary>
            public static EnumValues Tocantins => EnumValues.Tocantins;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Brazil regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Acre
            /// </summary>
            [AliasInShort("AC")]
            [RegionCode(5_00_001_0001)]
            Acre,

            /// <summary>
            /// Alagoas
            /// </summary>
            [AliasInShort("AL")]
            [RegionCode(5_00_001_0002)]
            Alagoas,

            /// <summary>
            /// Amazonas
            /// </summary>
            [AliasInShort("AM")]
            [RegionCode(5_00_001_0003)]
            Amazonas,

            /// <summary>
            /// Amapá
            /// </summary>
            [AliasInShort("AP")]
            [RegionCode(5_00_001_0004)]
            Amapá,

            /// <summary>
            /// Bahia
            /// </summary>
            [AliasInShort("BA")]
            [RegionCode(5_00_001_0005)]
            Bahia,

            /// <summary>
            /// Ceará
            /// </summary>
            [AliasInShort("CE")]
            [RegionCode(5_00_001_0006)]
            Ceará,

            /// <summary>
            /// Distrito Federal
            /// </summary>
            [AliasInShort("DF")]
            [RegionCode(5_00_001_0007)]
            DistritoFederal,

            /// <summary>
            /// Espírito Santo
            /// </summary>
            [AliasInShort("ES")]
            [RegionCode(5_00_001_0008)]
            EspíritoSanto,

            /// <summary>
            /// Goiás
            /// </summary>
            [AliasInShort("GO")]
            [RegionCode(5_00_001_0009)]
            Goiás,

            /// <summary>
            /// Maranhão
            /// </summary>
            [AliasInShort("MA")]
            [RegionCode(5_00_001_0010)]
            Maranhão,

            /// <summary>
            /// Minas Gerais
            /// </summary>
            [AliasInShort("MG")]
            [RegionCode(5_00_001_0011)]
            MinasGerais,

            /// <summary>
            /// Mato Grosso do Sul
            /// </summary>
            [AliasInShort("MS")]
            [RegionCode(5_00_001_0012)]
            MatoGrossoDoSul,

            /// <summary>
            /// Mato Grosso
            /// </summary>
            [AliasInShort("MT")]
            [RegionCode(5_00_001_0013)]
            MatoGrosso,

            /// <summary>
            /// Pará
            /// </summary>
            [AliasInShort("PA")]
            [RegionCode(5_00_001_0014)]
            Pará,

            /// <summary>
            /// Paraíba
            /// </summary>
            [AliasInShort("PB")]
            [RegionCode(5_00_001_0015)]
            Paraíba,

            /// <summary>
            /// Pernambuco
            /// </summary>
            [AliasInShort("PE")]
            [RegionCode(5_00_001_0016)]
            Pernambuco,

            /// <summary>
            /// Piauí
            /// </summary>
            [AliasInShort("PI")]
            [RegionCode(5_00_001_0017)]
            Piauí,

            /// <summary>
            /// Paraná
            /// </summary>
            [AliasInShort("PR")]
            [RegionCode(5_00_001_0018)]
            Paraná,

            /// <summary>
            /// Rio de Janeiro
            /// </summary>
            [AliasInShort("RJ")]
            [RegionCode(5_00_001_0019)]
            RioDeJaneiro,

            /// <summary>
            /// Rio Grande do Norte
            /// </summary>
            [AliasInShort("RN")]
            [RegionCode(5_00_001_0020)]
            RioGrandeDoNorte,

            /// <summary>
            /// Rondônia
            /// </summary>
            [AliasInShort("RO")]
            [RegionCode(5_00_001_0021)]
            Rondônia,

            /// <summary>
            /// Roraima
            /// </summary>
            [AliasInShort("RR")]
            [RegionCode(5_00_001_0022)]
            Roraima,

            /// <summary>
            /// Rio Grande do Sul
            /// </summary>
            [AliasInShort("RS")]
            [RegionCode(5_00_001_0023)]
            RioGrandeDoSul,

            /// <summary>
            /// Santa Catarina
            /// </summary>
            [AliasInShort("SC")]
            [RegionCode(5_00_001_0024)]
            SantaCatarina,

            /// <summary>
            /// Sergipe
            /// </summary>
            [AliasInShort("SE")]
            [RegionCode(5_00_001_0025)]
            Sergipe,

            /// <summary>
            /// São Paulo
            /// </summary>
            [AliasInShort("SP")]
            [RegionCode(5_00_001_0026)]
            SãoPaulo,

            /// <summary>
            /// Tocantins
            /// </summary>
            [AliasInShort("TO")]
            [RegionCode(5_00_001_0027)]
            Tocantins,

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