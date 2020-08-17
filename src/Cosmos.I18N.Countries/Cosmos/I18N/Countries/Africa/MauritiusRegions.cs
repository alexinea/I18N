using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Mauritius Regions
    /// </summary>
    public static class MauritiusRegions
    {
        #region Gets regions

        /// <summary>
        /// Agaléga
        /// </summary>
        public static EnumValues Agaléga => EnumValues.Agaléga;

        /// <summary>
        /// Rivière Noire
        /// </summary>
        public static EnumValues RivièreNoire => EnumValues.RivièreNoire;

        /// <summary>
        /// Beau-Bassin Rose-Hill
        /// </summary>
        public static EnumValues BeauBassinRoseHill => EnumValues.BeauBassinRoseHill;

        /// <summary>
        /// Cargados Carajos
        /// </summary>
        public static EnumValues CargadosCarajos => EnumValues.CargadosCarajos;

        /// <summary>
        /// Curepipe
        /// </summary>
        public static EnumValues Curepipe => EnumValues.Curepipe;

        /// <summary>
        /// Flacq
        /// </summary>
        public static EnumValues Flacq => EnumValues.Flacq;

        /// <summary>
        /// Grand Port
        /// </summary>
        public static EnumValues GrandPort => EnumValues.GrandPort;

        /// <summary>
        /// Moka
        /// </summary>
        public static EnumValues Moka => EnumValues.Moka;

        /// <summary>
        /// Pamplemousses
        /// </summary>
        public static EnumValues Pamplemousses => EnumValues.Pamplemousses;

        /// <summary>
        /// Port Louis District
        /// </summary>
        public static EnumValues PortLouisDistrict => EnumValues.PortLouisDistrict;

        /// <summary>
        /// Port Louis
        /// </summary>
        public static EnumValues PortLouis => EnumValues.PortLouis;

        /// <summary>
        /// Al Muthanna
        /// </summary>
        public static EnumValues AlMuthanna => EnumValues.AlMuthanna;

        /// <summary>
        /// Plaines Wilhems
        /// </summary>
        public static EnumValues PlainesWilhems => EnumValues.PlainesWilhems;

        /// <summary>
        /// Quatre Bornes
        /// </summary>
        public static EnumValues QuatrBornes => EnumValues.QuatrBornes;

        /// <summary>
        /// Rodrigues
        /// </summary>
        public static EnumValues Rodrigues => EnumValues.Rodrigues;

        /// <summary>
        /// Rivière du Rempart
        /// </summary>
        public static EnumValues RivièreDuRempart => EnumValues.RivièreDuRempart;

        /// <summary>
        /// Savanne
        /// </summary>
        public static EnumValues Savanne => EnumValues.Savanne;

        /// <summary>
        /// Vacoas-Phoenix
        /// </summary>
        public static EnumValues VacoasPhoenix => EnumValues.VacoasPhoenix;

        #endregion

        /// <summary>
        /// Enum values for Mauritius regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Agaléga
            /// </summary>
            [AliasInShort("AG")][RegionCode(3_00_136_0001)] Agaléga,

            /// <summary>
            /// Rivière Noire
            /// </summary>
            [AliasInShort("BL")][RegionCode(3_00_136_0002)] RivièreNoire,

            /// <summary>
            /// Beau-Bassin Rose-Hill
            /// </summary>
            [AliasInShort("BR")][RegionCode(3_00_136_0003)] BeauBassinRoseHill,

            /// <summary>
            /// Cargados Carajos
            /// </summary>
            [AliasInShort("CC")][RegionCode(3_00_136_0004)] CargadosCarajos,

            /// <summary>
            /// Curepipe
            /// </summary>
            [AliasInShort("CU")][RegionCode(3_00_136_0005)] Curepipe,

            /// <summary>
            /// Flacq
            /// </summary>
            [AliasInShort("FL")][RegionCode(3_00_136_0006)] Flacq,

            /// <summary>
            /// Grand Port
            /// </summary>
            [AliasInShort("GP")][RegionCode(3_00_136_0007)] GrandPort,

            /// <summary>
            /// Moka
            /// </summary>
            [AliasInShort("MO")][RegionCode(3_00_136_0008)] Moka,

            /// <summary>
            /// Pamplemousses
            /// </summary>
            [AliasInShort("PA")][RegionCode(3_00_136_0009)] Pamplemousses,

            /// <summary>
            /// Port Louis District
            /// </summary>
            [AliasInShort("PL")][RegionCode(3_00_136_0010)] PortLouisDistrict,

            /// <summary>
            /// Port Louis
            /// </summary>
            [AliasInShort("PU")][RegionCode(3_00_136_0011)] PortLouis,

            /// <summary>
            /// Al Muthanna
            /// </summary>
            [AliasInShort("MU")][RegionCode(3_00_136_0012)] AlMuthanna,

            /// <summary>
            /// Plaines Wilhems
            /// </summary>
            [AliasInShort("PW")] [RegionCode(3_00_136_0013)]PlainesWilhems,

            /// <summary>
            /// Quatre Bornes
            /// </summary>
            [AliasInShort("QB")][RegionCode(3_00_136_0014)] QuatrBornes,

            /// <summary>
            /// Rodrigues
            /// </summary>
            [AliasInShort("RO")][RegionCode(3_00_136_0015)] Rodrigues,

            /// <summary>
            /// Rivière du Rempart
            /// </summary>
            [AliasInShort("RR")][RegionCode(3_00_136_0016)] RivièreDuRempart,

            /// <summary>
            /// Savanne
            /// </summary>
            [AliasInShort("SA")][RegionCode(3_00_136_0017)] Savanne,

            /// <summary>
            /// Vacoas-Phoenix
            /// </summary>
            [AliasInShort("VP")] [RegionCode(3_00_136_0018)]VacoasPhoenix,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="MauritiusRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="MauritiusRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"MU-{values.ToRegionCode()}";
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
            return Country.Mauritius;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.MU;
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