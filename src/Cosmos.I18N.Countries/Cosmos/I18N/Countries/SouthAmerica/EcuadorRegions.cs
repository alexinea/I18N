using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// Ecuador Regions
    /// </summary>
    public static class EcuadorRegions
    {
        #region Gets regions

        /// <summary>
        /// Azuay
        /// </summary>
        public static EnumValues Azuay => EnumValues.Azuay;

        /// <summary>
        /// Bolívar
        /// </summary>
        public static EnumValues Bolívar => EnumValues.Bolívar;

        /// <summary>
        /// Carchi
        /// </summary>
        public static EnumValues Carchi => EnumValues.Carchi;

        /// <summary>
        /// Orellana
        /// </summary>
        public static EnumValues Orellana => EnumValues.Orellana;

        /// <summary>
        /// Esmeraldas
        /// </summary>
        public static EnumValues Esmeraldas => EnumValues.Esmeraldas;

        /// <summary>
        /// Cañar
        /// </summary>
        public static EnumValues Cañar => EnumValues.Cañar;

        /// <summary>
        /// Guayas
        /// </summary>
        public static EnumValues Guayas => EnumValues.Guayas;

        /// <summary>
        /// Chimborazo
        /// </summary>
        public static EnumValues Chimborazo => EnumValues.Chimborazo;

        /// <summary>
        /// Imbabura
        /// </summary>
        public static EnumValues Imbabura => EnumValues.Imbabura;

        /// <summary>
        /// Loja
        /// </summary>
        public static EnumValues Loja => EnumValues.Loja;

        /// <summary>
        /// Manabí
        /// </summary>
        public static EnumValues Manabí => EnumValues.Manabí;

        /// <summary>
        /// Napo
        /// </summary>
        public static EnumValues Napo => EnumValues.Napo;

        /// <summary>
        /// El Oro
        /// </summary>
        public static EnumValues ElOro => EnumValues.ElOro;

        /// <summary>
        /// Pichincha
        /// </summary>
        public static EnumValues Pichincha => EnumValues.Pichincha;

        /// <summary>
        /// Los Ríos
        /// </summary>
        public static EnumValues LosRíos => EnumValues.LosRíos;

        /// <summary>
        /// Morona-Santiago
        /// </summary>
        public static EnumValues MoronaSantiago => EnumValues.MoronaSantiago;

        /// <summary>
        /// Santo Domingo de los Tsáchilas
        /// </summary>
        public static EnumValues SantoDomingoDeLosTsáchilas => EnumValues.SantoDomingoDeLosTsáchilas;

        /// <summary>
        /// Santa Elena
        /// </summary>
        public static EnumValues SantaElena => EnumValues.SantaElena;

        /// <summary>
        /// Tungurahua
        /// </summary>
        public static EnumValues Tungurahua => EnumValues.Tungurahua;

        /// <summary>
        /// Sucumbíos
        /// </summary>
        public static EnumValues Sucumbíos => EnumValues.Sucumbíos;

        /// <summary>
        /// Galápagos
        /// </summary>
        public static EnumValues Galápagos => EnumValues.Galápagos;

        /// <summary>
        /// Cotopaxi
        /// </summary>
        public static EnumValues Cotopaxi => EnumValues.Cotopaxi;

        /// <summary>
        /// Pastaza
        /// </summary>
        public static EnumValues Pastaza => EnumValues.Pastaza;

        /// <summary>
        /// Zamora-Chinchipe
        /// </summary>
        public static EnumValues ZamoraChinchipe => EnumValues.ZamoraChinchipe;

        #endregion

        /// <summary>
        /// Enum values for Ecuador regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Azuay
            /// </summary>
            [AliasInShort("A")] [RegionCode(5_00_103_0001)]
            Azuay,

            /// <summary>
            /// Bolívar
            /// </summary>
            [AliasInShort("B")] [RegionCode(5_00_103_0002)]
            Bolívar,

            /// <summary>
            /// Carchi
            /// </summary>
            [AliasInShort("C")] [RegionCode(5_00_103_0003)]
            Carchi,

            /// <summary>
            /// Orellana
            /// </summary>
            [AliasInShort("D")] [RegionCode(5_00_103_0004)]
            Orellana,

            /// <summary>
            /// Esmeraldas
            /// </summary>
            [AliasInShort("E")] [RegionCode(5_00_103_0005)]
            Esmeraldas,

            /// <summary>
            /// Cañar
            /// </summary>
            [AliasInShort("F")] [RegionCode(5_00_103_0006)]
            Cañar,

            /// <summary>
            /// Guayas
            /// </summary>
            [AliasInShort("G")] [RegionCode(5_00_103_0007)]
            Guayas,

            /// <summary>
            /// Chimborazo
            /// </summary>
            [AliasInShort("H")] [RegionCode(5_00_103_0008)]
            Chimborazo,

            /// <summary>
            /// Imbabura
            /// </summary>
            [AliasInShort("I")] [RegionCode(5_00_103_0009)]
            Imbabura,

            /// <summary>
            /// Loja
            /// </summary>
            [AliasInShort("L")] [RegionCode(5_00_103_0010)]
            Loja,

            /// <summary>
            /// Manabí
            /// </summary>
            [AliasInShort("M")] [RegionCode(5_00_103_0011)]
            Manabí,

            /// <summary>
            /// Napo
            /// </summary>
            [AliasInShort("N")] [RegionCode(5_00_103_0012)]
            Napo,

            /// <summary>
            /// El Oro
            /// </summary>
            [AliasInShort("O")] [RegionCode(5_00_103_0013)]
            ElOro,

            /// <summary>
            /// Pichincha
            /// </summary>
            [AliasInShort("P")] [RegionCode(5_00_103_0014)]
            Pichincha,

            /// <summary>
            /// Los Ríos
            /// </summary>
            [AliasInShort("R")] [RegionCode(5_00_103_0015)]
            LosRíos,

            /// <summary>
            /// Morona-Santiago
            /// </summary>
            [AliasInShort("S")] [RegionCode(5_00_103_0016)]
            MoronaSantiago,

            /// <summary>
            /// Santo Domingo de los Tsáchilas
            /// </summary>
            [AliasInShort("SD")] [RegionCode(5_00_103_0017)]
            SantoDomingoDeLosTsáchilas,

            /// <summary>
            /// Santa Elena
            /// </summary>
            [AliasInShort("SE")] [RegionCode(5_00_103_0018)]
            SantaElena,

            /// <summary>
            /// Tungurahua
            /// </summary>
            [AliasInShort("T")] [RegionCode(5_00_103_0019)]
            Tungurahua,

            /// <summary>
            /// Sucumbíos
            /// </summary>
            [AliasInShort("U")] [RegionCode(5_00_103_0020)]
            Sucumbíos,

            /// <summary>
            /// Galápagos
            /// </summary>
            [AliasInShort("W")] [RegionCode(5_00_103_0021)]
            Galápagos,

            /// <summary>
            /// Cotopaxi
            /// </summary>
            [AliasInShort("X")] [RegionCode(5_00_103_0022)]
            Cotopaxi,

            /// <summary>
            /// Pastaza
            /// </summary>
            [AliasInShort("Y")] [RegionCode(5_00_103_0023)]
            Pastaza,

            /// <summary>
            /// Zamora-Chinchipe
            /// </summary>
            [AliasInShort("Z")] [RegionCode(5_00_103_0024)]
            ZamoraChinchipe,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="EcuadorRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="EcuadorRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"EC-{values.ToRegionCode()}";
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
            return Country.Ecuador;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.EC;
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