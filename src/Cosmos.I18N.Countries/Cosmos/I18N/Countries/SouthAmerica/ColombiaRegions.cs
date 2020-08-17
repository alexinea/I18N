using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// Colombia regions
    /// </summary>
    public static class ColombiaRegions
    {
        #region Gets regions

        /// <summary>
        /// Amazonas
        /// </summary>
        public static EnumValues Amazonas => EnumValues.Amazonas;

        /// <summary>
        /// Antioquia
        /// </summary>
        public static EnumValues Antioquia => EnumValues.Antioquia;

        /// <summary>
        /// Arauca
        /// </summary>
        public static EnumValues Arauca => EnumValues.Arauca;

        /// <summary>
        /// Atlántico
        /// </summary>
        public static EnumValues Atlántico => EnumValues.Atlántico;

        /// <summary>
        /// Bolívar
        /// </summary>
        public static EnumValues Bolívar => EnumValues.Bolívar;

        /// <summary>
        /// Boyacá
        /// </summary>
        public static EnumValues Boyacá => EnumValues.Boyacá;

        /// <summary>
        /// Caldas
        /// </summary>
        public static EnumValues Caldas => EnumValues.Caldas;

        /// <summary>
        /// Caquetá
        /// </summary>
        public static EnumValues Caquetá => EnumValues.Caquetá;

        /// <summary>
        /// Casanare
        /// </summary>
        public static EnumValues Casanare => EnumValues.Casanare;

        /// <summary>
        /// Cauca
        /// </summary>
        public static EnumValues Cauca => EnumValues.Cauca;

        /// <summary>
        /// Cesar
        /// </summary>
        public static EnumValues Cesar => EnumValues.Cesar;

        /// <summary>
        /// Chocó
        /// </summary>
        public static EnumValues Chocó => EnumValues.Chocó;

        /// <summary>
        /// Córdoba, COR
        /// </summary>
        public static EnumValues Córdoba => EnumValues.Córdoba;

        /// <summary>
        /// Cundinamarca
        /// </summary>
        public static EnumValues Cundinamarca => EnumValues.Cundinamarca;

        /// <summary>
        /// Capital District 
        /// </summary>
        public static EnumValues CapitalDistrict => EnumValues.CapitalDistrict;

        /// <summary>
        /// Guainía 
        /// </summary>
        public static EnumValues Guainía => EnumValues.Guainía;

        /// <summary>
        /// Guaviare
        /// </summary>
        public static EnumValues Guaviare => EnumValues.Guaviare;

        /// <summary>
        /// Huila 
        /// </summary>
        public static EnumValues Huila => EnumValues.Huila;

        /// <summary>
        /// La Guajira 
        /// </summary>
        public static EnumValues LaGuajira => EnumValues.LaGuajira;

        /// <summary>
        /// Magdalena 
        /// </summary>
        public static EnumValues Magdalena => EnumValues.Magdalena;

        /// <summary>
        /// Meta 
        /// </summary>
        public static EnumValues Meta => EnumValues.Meta;

        /// <summary>
        /// Nariño 
        /// </summary>
        public static EnumValues Nariño => EnumValues.Nariño;

        /// <summary>
        /// Norte de Santander 
        /// </summary>
        public static EnumValues NorteDeSantander => EnumValues.NorteDeSantander;

        /// <summary>
        /// Putumayo 
        /// </summary>
        public static EnumValues Putumayo => EnumValues.Putumayo;

        /// <summary>
        /// Quindío
        /// </summary>
        public static EnumValues Quindío => EnumValues.Quindío;

        /// <summary>
        /// Risaralda 
        /// </summary>
        public static EnumValues Risaralda => EnumValues.Risaralda;

        /// <summary>
        /// Santander 
        /// </summary>
        public static EnumValues Santander => EnumValues.Santander;

        /// <summary>
        /// San Andrés and Providencia
        /// </summary>
        public static EnumValues SanAndrésAndProvidencia => EnumValues.SanAndrésAndProvidencia;

        /// <summary>
        /// Sucre 
        /// </summary>
        public static EnumValues Sucre => EnumValues.Sucre;

        /// <summary>
        /// Tolima 
        /// </summary>
        public static EnumValues Tolima => EnumValues.Tolima;

        /// <summary>
        /// Valle del Cauca 
        /// </summary>
        public static EnumValues ValleDelCauca => EnumValues.ValleDelCauca;

        /// <summary>
        /// Vaupés 
        /// </summary>
        public static EnumValues Vaupés => EnumValues.Vaupés;

        /// <summary>
        /// Vichada 
        /// </summary>
        public static EnumValues Vichada => EnumValues.Vichada;

        #endregion

        /// <summary>
        /// Enum values for Colombia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Amazonas
            /// </summary>
            [AliasInShort("AMA")] [RegionCode(5_00_102_0001)]
            Amazonas,

            /// <summary>
            /// Antioquia
            /// </summary>
            [AliasInShort("ANT")] [RegionCode(5_00_102_0002)]
            Antioquia,

            /// <summary>
            /// Arauca
            /// </summary>
            [AliasInShort("ARA")] [RegionCode(5_00_102_0003)]
            Arauca,

            /// <summary>
            /// Atlántico
            /// </summary>
            [AliasInShort("ATL")] [RegionCode(5_00_102_0004)]
            Atlántico,

            /// <summary>
            /// Bolívar
            /// </summary>
            [AliasInShort("BOL")] [RegionCode(5_00_102_0005)]
            Bolívar,

            /// <summary>
            /// Boyacá
            /// </summary>
            [AliasInShort("BOY")] [RegionCode(5_00_102_0006)]
            Boyacá,

            /// <summary>
            /// Caldas
            /// </summary>
            [AliasInShort("CAL")] [RegionCode(5_00_102_0007)]
            Caldas,

            /// <summary>
            /// Caquetá
            /// </summary>
            [AliasInShort("CAQ")] [RegionCode(5_00_102_0008)]
            Caquetá,

            /// <summary>
            /// Casanare
            /// </summary>
            [AliasInShort("CAS")] [RegionCode(5_00_102_0009)]
            Casanare,

            /// <summary>
            /// Cauca
            /// </summary>
            [AliasInShort("CAU")] [RegionCode(5_00_102_0010)]
            Cauca,

            /// <summary>
            /// Cesar
            /// </summary>
            [AliasInShort("CES")] [RegionCode(5_00_102_0011)]
            Cesar,

            /// <summary>
            /// Chocó
            /// </summary>
            [AliasInShort("CHO")] [RegionCode(5_00_102_0012)]
            Chocó,

            /// <summary>
            /// Córdoba, COR
            /// </summary>
            [AliasInShort("COR")] [RegionCode(5_00_102_0013)]
            Córdoba,

            /// <summary>
            /// Cundinamarca, CUN
            /// </summary>
            [AliasInShort("CUN")] [RegionCode(5_00_102_0014)]
            Cundinamarca,

            /// <summary>
            /// Capital District, DC
            /// </summary>
            [AliasInShort("DC")] [RegionCode(5_00_102_0015)]
            CapitalDistrict,

            /// <summary>
            /// Guainía, GUA
            /// </summary>
            [AliasInShort("GUA")] [RegionCode(5_00_102_0016)]
            Guainía,

            /// <summary>
            /// Guaviare, GUV
            /// </summary>
            [AliasInShort("GUV")] [RegionCode(5_00_102_0017)]
            Guaviare,

            /// <summary>
            /// Huila, HUI
            /// </summary>
            [AliasInShort("HUI")] [RegionCode(5_00_102_0018)]
            Huila,

            /// <summary>
            /// La Guajira, LAG
            /// </summary>
            [AliasInShort("LAG")] [RegionCode(5_00_102_0019)]
            LaGuajira,

            /// <summary>
            /// Magdalena, MAG
            /// </summary>
            [AliasInShort("MAG")] [RegionCode(5_00_102_0020)]
            Magdalena,

            /// <summary>
            /// Meta, MET
            /// </summary>
            [AliasInShort("MET")] [RegionCode(5_00_102_0021)]
            Meta,

            /// <summary>
            /// Nariño, NAR
            /// </summary>
            [AliasInShort("NAR")] [RegionCode(5_00_102_0022)]
            Nariño,

            /// <summary>
            /// Norte de Santander, NSA
            /// </summary>
            [AliasInShort("NSA")] [RegionCode(5_00_102_0023)]
            NorteDeSantander,

            /// <summary>
            /// Putumayo, PUT
            /// </summary>
            [AliasInShort("PUT")] [RegionCode(5_00_102_0024)]
            Putumayo,

            /// <summary>
            /// Quindío, QUI
            /// </summary>
            [AliasInShort("QUI")] [RegionCode(5_00_102_0025)]
            Quindío,

            /// <summary>
            /// Risaralda, RIS
            /// </summary>
            [AliasInShort("RIS")] [RegionCode(5_00_102_0026)]
            Risaralda,

            /// <summary>
            /// Santander, SAN
            /// </summary>
            [AliasInShort("SAN")] [RegionCode(5_00_102_0027)]
            Santander,

            /// <summary>
            /// San Andrés and Providencia, SAP
            /// </summary>
            [AliasInShort("SAP")] [RegionCode(5_00_102_0028)]
            SanAndrésAndProvidencia,

            /// <summary>
            /// Sucre, SUC
            /// </summary>
            [AliasInShort("SUC")] [RegionCode(5_00_102_0028)]
            Sucre,

            /// <summary>
            /// Tolima, TOL
            /// </summary>
            [AliasInShort("TOL")] [RegionCode(5_00_102_0030)]
            Tolima,

            /// <summary>
            /// Valle del Cauca, VAC
            /// </summary>
            [AliasInShort("VAC")] [RegionCode(5_00_102_0031)]
            ValleDelCauca,

            /// <summary>
            /// Vaupés, VAU
            /// </summary>
            [AliasInShort("VAU")] [RegionCode(5_00_102_0032)]
            Vaupés,

            /// <summary>
            /// Vichada, VID
            /// </summary>
            [AliasInShort("VID")] [RegionCode(5_00_102_0033)]
            Vichada,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="ColombiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="ColombiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CO-{values.ToRegionCode()}";
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
            return Country.Colombia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CO;
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