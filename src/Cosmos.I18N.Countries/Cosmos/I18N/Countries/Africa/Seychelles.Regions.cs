using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Seychelles Regions
    /// </summary>
    public static partial class Seychelles 
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Bel Ombre
        /// </summary>
        public static EnumValues BelOmbre => EnumValues.BelOmbre;

        /// <summary>
        /// Cascade
        /// </summary>
        public static EnumValues Cascade => EnumValues.Cascade;

        /// <summary>
        /// Glacis
        /// </summary>
        public static EnumValues Glacis => EnumValues.Glacis;

        /// <summary>
        /// Grand’Anse Mahé
        /// </summary>
        public static EnumValues GrandAnseMahé => EnumValues.GrandAnseMahé;

        /// <summary>
        /// Grand’Anse Praslin
        /// </summary>
        public static EnumValues GrandAnsePraslin => EnumValues.GrandAnsePraslin;

        /// <summary>
        /// La Digue
        /// </summary>
        public static EnumValues LaDigue => EnumValues.LaDigue;

        /// <summary>
        /// La Rivière Anglaise
        /// </summary>
        public static EnumValues LaRivièreAnglaise => EnumValues.LaRivièreAnglaise;

        /// <summary>
        /// Mont Buxton
        /// </summary>
        public static EnumValues MontBuxton => EnumValues.MontBuxton;

        /// <summary>
        /// Mont Fleuri
        /// </summary>
        public static EnumValues MontFleuri => EnumValues.MontFleuri;

        /// <summary>
        /// Plaisance
        /// </summary>
        public static EnumValues Plaisance => EnumValues.Plaisance;

        /// <summary>
        /// Pointe La Rue
        /// </summary>
        public static EnumValues PointeLaRue => EnumValues.PointeLaRue;

        /// <summary>
        /// Port Glaud
        /// </summary>
        public static EnumValues PortGlaud => EnumValues.PortGlaud;

        /// <summary>
        /// Saint Louis
        /// </summary>
        public static EnumValues SaintLouis => EnumValues.SaintLouis;

        /// <summary>
        /// Takamaka
        /// </summary>
        public static EnumValues Takamaka => EnumValues.Takamaka;

        /// <summary>
        /// Les Mamelles
        /// </summary>
        public static EnumValues LesMamelles => EnumValues.LesMamelles;

        /// <summary>
        /// Roche Caiman
        /// </summary>
        public static EnumValues RocheCaiman => EnumValues.RocheCaiman;

        /// <summary>
        /// Anse aux Pins
        /// </summary>
        public static EnumValues AnseAuxPins => EnumValues.AnseAuxPins;

        /// <summary>
        /// Tungurahua
        /// </summary>
        public static EnumValues AnseBoileau => EnumValues.AnseBoileau;

        /// <summary>
        /// Anse Etoile
        /// </summary>
        public static EnumValues AnseEtoile => EnumValues.AnseEtoile;

        /// <summary>
        /// Au Cap
        /// </summary>
        public static EnumValues AuCap => EnumValues.AuCap;

        /// <summary>
        /// Anse Royale
        /// </summary>
        public static EnumValues AnseRoyale => EnumValues.AnseRoyale;

        /// <summary>
        /// Baie Lazare
        /// </summary>
        public static EnumValues BaieLazare => EnumValues.BaieLazare;

        /// <summary>
        /// Baie Sainte Anne
        /// </summary>
        public static EnumValues BaieSainteAnne => EnumValues.BaieSainteAnne;

        /// <summary>
        /// Beau Vallon
        /// </summary>
        public static EnumValues BeauVallon => EnumValues.BeauVallon;

        /// <summary>
        /// Bel Air
        /// </summary>
        public static EnumValues BelAir => EnumValues.BelAir;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Seychelles regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bel Ombre
            /// </summary>
            [AliasInShort("10")][RegionCode(3_00_145_0010)] BelOmbre,

            /// <summary>
            /// Cascade
            /// </summary>
            [AliasInShort("11")][RegionCode(3_00_145_0011)] Cascade,

            /// <summary>
            /// Glacis
            /// </summary>
            [AliasInShort("12")][RegionCode(3_00_145_0012)] Glacis,

            /// <summary>
            /// Grand’Anse Mahé
            /// </summary>
            [AliasInShort("13")][RegionCode(3_00_145_0013)] GrandAnseMahé,

            /// <summary>
            /// Grand’Anse Praslin
            /// </summary>
            [AliasInShort("14")][RegionCode(3_00_145_0014)] GrandAnsePraslin,

            /// <summary>
            /// La Digue
            /// </summary>
            [AliasInShort("15")][RegionCode(3_00_145_0015)] LaDigue,

            /// <summary>
            /// La Rivière Anglaise
            /// </summary>
            [AliasInShort("16")][RegionCode(3_00_145_0016)] LaRivièreAnglaise,

            /// <summary>
            /// Mont Buxton
            /// </summary>
            [AliasInShort("17")][RegionCode(3_00_145_0017)] MontBuxton,

            /// <summary>
            /// Mont Fleuri
            /// </summary>
            [AliasInShort("18")][RegionCode(3_00_145_0018)] MontFleuri,

            /// <summary>
            /// Plaisance
            /// </summary>
            [AliasInShort("19")][RegionCode(3_00_145_0019)] Plaisance,

            /// <summary>
            /// Pointe La Rue
            /// </summary>
            [AliasInShort("20")][RegionCode(3_00_145_0020)] PointeLaRue,

            /// <summary>
            /// Port Glaud
            /// </summary>
            [AliasInShort("21")][RegionCode(3_00_145_0021)] PortGlaud,

            /// <summary>
            /// Saint Louis
            /// </summary>
            [AliasInShort("22")][RegionCode(3_00_145_0022)] SaintLouis,

            /// <summary>
            /// Takamaka
            /// </summary>
            [AliasInShort("23")][RegionCode(3_00_145_0023)] Takamaka,

            /// <summary>
            /// Les Mamelles
            /// </summary>
            [AliasInShort("24")][RegionCode(3_00_145_0024)] LesMamelles,

            /// <summary>
            /// Roche Caiman
            /// </summary>
            [AliasInShort("25")][RegionCode(3_00_145_0025)] RocheCaiman,

            /// <summary>
            /// Anse aux Pins
            /// </summary>
            [AliasInShort("01")][RegionCode(3_00_145_0001)] AnseAuxPins,

            /// <summary>
            /// Anse Boileau
            /// </summary>
            [AliasInShort("02")][RegionCode(3_00_145_0002)] AnseBoileau,

            /// <summary>
            /// Anse Etoile
            /// </summary>
            [AliasInShort("03")][RegionCode(3_00_145_0003)] AnseEtoile,

            /// <summary>
            /// Au Cap
            /// </summary>
            [AliasInShort("04")][RegionCode(3_00_145_0004)] AuCap,

            /// <summary>
            /// Anse Royale
            /// </summary>
            [AliasInShort("05")][RegionCode(3_00_145_0005)] AnseRoyale,

            /// <summary>
            /// Baie Lazare
            /// </summary>
            [AliasInShort("06")][RegionCode(3_00_145_0006)] BaieLazare,

            /// <summary>
            /// Baie Sainte Anne
            /// </summary>
            [AliasInShort("07")][RegionCode(3_00_145_0007)] BaieSainteAnne,

            /// <summary>
            /// Beau Vallon
            /// </summary>
            [AliasInShort("08")][RegionCode(3_00_145_0008)] BeauVallon,

            /// <summary>
            /// Bel Air
            /// </summary>
            [AliasInShort("09")][RegionCode(3_00_145_0009)] BelAir,

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