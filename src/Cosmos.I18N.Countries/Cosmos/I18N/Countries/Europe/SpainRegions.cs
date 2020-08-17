using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Spain
    /// </summary>
    public static class SpainRegions
    {
        #region Gets regions

        /// <summary>
        /// Comunidad de Madrid
        /// </summary>
        public static EnumValues ComunidadDeMadrid => EnumValues.ComunidadDeMadrid;

        /// <summary>
        /// Andalucía
        /// </summary>
        public static EnumValues Andalucía => EnumValues.Andalucía;

        /// <summary>
        /// Aragón
        /// </summary>
        public static EnumValues Aragón => EnumValues.Aragón;

        /// <summary>
        /// Asturias
        /// </summary>
        public static EnumValues Asturias => EnumValues.Asturias;

        /// <summary>
        /// Cantabria
        /// </summary>
        public static EnumValues Cantabria => EnumValues.Cantabria;

        /// <summary>
        /// Ceuta
        /// </summary>
        public static EnumValues Ceuta => EnumValues.Ceuta;

        /// <summary>
        /// Castile and León
        /// </summary>
        public static EnumValues CastileAndLeón => EnumValues.CastileAndLeón;

        /// <summary>
        /// Castile-La Mancha
        /// </summary>
        public static EnumValues CastileLaMancha => EnumValues.CastileLaMancha;

        /// <summary>
        /// Canary Islands
        /// </summary>
        public static EnumValues CanaryIslands => EnumValues.CanaryIslands;

        /// <summary>
        /// Catalonia
        /// </summary>
        public static EnumValues Catalonia => EnumValues.Catalonia;

        /// <summary>
        /// Extremadura
        /// </summary>
        public static EnumValues Extremadura => EnumValues.Extremadura;

        /// <summary>
        /// Galicia
        /// </summary>
        public static EnumValues Galicia => EnumValues.Galicia;

        /// <summary>
        /// Balearic Islands
        /// </summary>
        public static EnumValues BalearicIslands => EnumValues.BalearicIslands;

        /// <summary>
        /// Murcia Region
        /// </summary>
        public static EnumValues MurciaRegion => EnumValues.MurciaRegion;

        /// <summary>
        /// Melilla
        /// </summary>
        public static EnumValues Melilla => EnumValues.Melilla;

        /// <summary>
        /// Navarra Chartered Community
        /// </summary>
        public static EnumValues NavarraCharteredCommunity => EnumValues.NavarraCharteredCommunity;

        /// <summary>
        /// Basque Country
        /// </summary>
        public static EnumValues BasqueCountry => EnumValues.BasqueCountry;

        /// <summary>
        /// La Rioja
        /// </summary>
        public static EnumValues LaRioja => EnumValues.LaRioja;

        /// <summary>
        /// Valencian Community
        /// </summary>
        public static EnumValues ValencianCommunity => EnumValues.ValencianCommunity;

        #endregion

        /// <summary>
        /// Enum values for Spain regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Comunidad de Madrid
            /// </summary>
            [AliasInShort("MD")][RegionCode(2_00_015_0001)]  ComunidadDeMadrid,

            /// <summary>
            /// Andalucía
            /// </summary>
            [AliasInShort("AN")][RegionCode(2_00_015_0002)]  Andalucía,

            /// <summary>
            /// Aragón
            /// </summary>
            [AliasInShort("AR")][RegionCode(2_00_015_0003)]  Aragón,

            /// <summary>
            /// Asturias
            /// </summary>
            [AliasInShort("AS")][RegionCode(2_00_015_0004)]  Asturias,

            /// <summary>
            /// Cantabria
            /// </summary>
            [AliasInShort("CB")] [RegionCode(2_00_015_0005)] Cantabria,

            /// <summary>
            /// Ceuta
            /// </summary>
            [AliasInShort("CE")][RegionCode(2_00_015_0006)]  Ceuta,

            /// <summary>
            /// Castile and León
            /// </summary>
            [AliasInShort("CL")][RegionCode(2_00_015_0007)]  CastileAndLeón,

            /// <summary>
            /// Castile-La Mancha
            /// </summary>
            [AliasInShort("CM")][RegionCode(2_00_015_0008)]  CastileLaMancha,

            /// <summary>
            /// Canary Islands
            /// </summary>
            [AliasInShort("CN")] [RegionCode(2_00_015_0009)] CanaryIslands,

            /// <summary>
            /// Catalonia
            /// </summary>
            [AliasInShort("CT")][RegionCode(2_00_015_0010)]  Catalonia,

            /// <summary>
            /// Extremadura
            /// </summary>
            [AliasInShort("EX")][RegionCode(2_00_015_0011)]  Extremadura,

            /// <summary>
            /// Galicia
            /// </summary>
            [AliasInShort("GA")][RegionCode(2_00_015_0012)]  Galicia,

            /// <summary>
            /// Balearic Islands
            /// </summary>
            [AliasInShort("IB")][RegionCode(2_00_015_0013)]  BalearicIslands,

            /// <summary>
            /// Murcia Region
            /// </summary>
            [AliasInShort("MC")] [RegionCode(2_00_015_0014)] MurciaRegion,

            /// <summary>
            /// Melilla
            /// </summary>
            [AliasInShort("ML")] [RegionCode(2_00_015_0015)] Melilla,

            /// <summary>
            /// Navarra Chartered Community
            /// </summary>
            [AliasInShort("NC")][RegionCode(2_00_015_0016)]  NavarraCharteredCommunity,

            /// <summary>
            /// Basque Country
            /// </summary>
            [AliasInShort("PV")][RegionCode(2_00_015_0017)]  BasqueCountry,

            /// <summary>
            /// La Rioja
            /// </summary>
            [AliasInShort("RI")][RegionCode(2_00_015_0018)]  LaRioja,

            /// <summary>
            /// Valencian Community
            /// </summary>
            [AliasInShort("VC")] [RegionCode(2_00_015_0019)] ValencianCommunity,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SpainRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SpainRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"ES-{values.ToRegionCode()}";
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
            return Country.Spain;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.ES;
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