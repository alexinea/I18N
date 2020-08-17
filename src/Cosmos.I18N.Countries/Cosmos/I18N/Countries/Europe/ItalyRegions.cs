using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Italy Regions
    /// </summary>
    public static class ItalyRegions
    {
        #region Gets regions

        /// <summary>
        /// Piedmont
        /// </summary>
        public static EnumValues Piedmont => EnumValues.Piedmont;

        /// <summary>
        /// Aosta Valley
        /// </summary>
        public static EnumValues AostaValley => EnumValues.AostaValley;

        /// <summary>
        /// Lombardy
        /// </summary>
        public static EnumValues Lombardy => EnumValues.Lombardy;

        /// <summary>
        /// Südtirol, Alto Adige
        /// </summary>
        public static EnumValues SüdtirolAltoAdige => EnumValues.SüdtirolAltoAdige;

        /// <summary>
        /// Veneto
        /// </summary>
        public static EnumValues Veneto => EnumValues.Veneto;

        /// <summary>
        /// Friuli–Venezia Giulia
        /// </summary>
        public static EnumValues FriuliVeneziaGiulia => EnumValues.FriuliVeneziaGiulia;

        /// <summary>
        /// Liguria
        /// </summary>
        public static EnumValues Liguria => EnumValues.Liguria;

        /// <summary>
        /// Emilia-Romagna
        /// </summary>
        public static EnumValues EmiliaRomagna => EnumValues.EmiliaRomagna;

        /// <summary>
        /// Tuscany
        /// </summary>
        public static EnumValues Tuscany => EnumValues.Tuscany;

        /// <summary>
        /// Umbria
        /// </summary>
        public static EnumValues Umbria => EnumValues.Umbria;

        /// <summary>
        /// Marche
        /// </summary>
        public static EnumValues Marche => EnumValues.Marche;

        /// <summary>
        /// Lazio
        /// </summary>
        public static EnumValues Lazio => EnumValues.Lazio;

        /// <summary>
        /// Abruzzo
        /// </summary>
        public static EnumValues Abruzzo => EnumValues.Abruzzo;

        /// <summary>
        /// Molise
        /// </summary>
        public static EnumValues Molise => EnumValues.Molise;

        /// <summary>
        /// Campania
        /// </summary>
        public static EnumValues Campania => EnumValues.Campania;

        /// <summary>
        /// Apulia
        /// </summary>
        public static EnumValues Apulia => EnumValues.Apulia;

        /// <summary>
        /// Basilicata
        /// </summary>
        public static EnumValues Basilicata => EnumValues.Basilicata;

        /// <summary>
        /// Calabria
        /// </summary>
        public static EnumValues Calabria => EnumValues.Calabria;


        /// <summary>
        /// Sicily
        /// </summary>
        public static EnumValues Sicily => EnumValues.Sicily;

        /// <summary>
        /// Sardinia
        /// </summary>
        public static EnumValues Sardinia => EnumValues.Sardinia;

        #endregion

        /// <summary>
        /// Enum values for Italy regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Piedmont
            /// </summary>
            [AliasInShort("21")] [RegionCode(2_00_003_0021)]
            Piedmont,

            /// <summary>
            /// Aosta Valley
            /// </summary>
            [AliasInShort("23")] [RegionCode(2_00_003_0023)]
            AostaValley,

            /// <summary>
            /// Lombardy
            /// </summary>
            [AliasInShort("25")] [RegionCode(2_00_003_0025)]
            Lombardy,

            /// <summary>
            /// Südtirol, Alto Adige
            /// </summary>
            [AliasInShort("32")] [RegionCode(2_00_003_0032)]
            SüdtirolAltoAdige,

            /// <summary>
            /// Veneto
            /// </summary>
            [AliasInShort("34")] [RegionCode(2_00_003_0034)]
            Veneto,

            /// <summary>
            /// Friuli–Venezia Giulia
            /// </summary>
            [AliasInShort("36")] [RegionCode(2_00_003_0036)]
            FriuliVeneziaGiulia,

            /// <summary>
            /// Liguria
            /// </summary>
            [AliasInShort("42")] [RegionCode(2_00_003_0042)]
            Liguria,

            /// <summary>
            /// Emilia-Romagna
            /// </summary>
            [AliasInShort("45")] [RegionCode(2_00_003_0045)]
            EmiliaRomagna,

            /// <summary>
            /// Tuscany
            /// </summary>
            [AliasInShort("52")] [RegionCode(2_00_003_0052)]
            Tuscany,

            /// <summary>
            /// Umbria
            /// </summary>
            [AliasInShort("55")] [RegionCode(2_00_003_0055)]
            Umbria,

            /// <summary>
            /// Marche
            /// </summary>
            [AliasInShort("57")] [RegionCode(2_00_003_0057)]
            Marche,

            /// <summary>
            /// Lazio
            /// </summary>
            [AliasInShort("62")] [RegionCode(2_00_003_0062)]
            Lazio,

            /// <summary>
            /// Abruzzo
            /// </summary>
            [AliasInShort("65")] [RegionCode(2_00_003_0065)]
            Abruzzo,

            /// <summary>
            /// Molise
            /// </summary>
            [AliasInShort("67")] [RegionCode(2_00_003_0067)]
            Molise,

            /// <summary>
            /// Campania
            /// </summary>
            [AliasInShort("72")] [RegionCode(2_00_003_0072)]
            Campania,

            /// <summary>
            /// Apulia
            /// </summary>
            [AliasInShort("75")] [RegionCode(2_00_003_0075)]
            Apulia,

            /// <summary>
            /// Basilicata
            /// </summary>
            [AliasInShort("77")] [RegionCode(2_00_003_0077)]
            Basilicata,

            /// <summary>
            /// Calabria
            /// </summary>
            [AliasInShort("78")] [RegionCode(2_00_003_0067)]
            Calabria,

            /// <summary>
            /// Sicily
            /// </summary>
            [AliasInShort("82")] [RegionCode(2_00_003_0082)]
            Sicily,

            /// <summary>
            /// Sardinia
            /// </summary>
            [AliasInShort("88")] [RegionCode(2_00_003_0088)]
            Sardinia,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="ItalyRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="ItalyRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"IT-{values.ToRegionCode()}";
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
            return Country.Italy;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.IT;
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