using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Nigeria Regions
    /// </summary>
    public static partial  class Nigeria
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Abia
        /// </summary>
        public static EnumValues Abia => EnumValues.Abia;

        /// <summary>
        /// Adamawa
        /// </summary>
        public static EnumValues Adamawa => EnumValues.Adamawa;

        /// <summary>
        /// Akwa Ibom
        /// </summary>
        public static EnumValues AkwaIbom => EnumValues.AkwaIbom;

        /// <summary>
        /// Anambra
        /// </summary>
        public static EnumValues Anambra => EnumValues.Anambra;

        /// <summary>
        /// Bauchi
        /// </summary>
        public static EnumValues Bauchi => EnumValues.Bauchi;

        /// <summary>
        /// Benue
        /// </summary>
        public static EnumValues Benue => EnumValues.Benue;

        /// <summary>
        /// Borno
        /// </summary>
        public static EnumValues Borno => EnumValues.Borno;

        /// <summary>
        /// Bayelsa
        /// </summary>
        public static EnumValues Bayelsa => EnumValues.Bayelsa;

        /// <summary>
        /// Cross River
        /// </summary>
        public static EnumValues CrossRiver => EnumValues.CrossRiver;

        /// <summary>
        /// Delta
        /// </summary>
        public static EnumValues Delta => EnumValues.Delta;

        /// <summary>
        /// Ebonyi
        /// </summary>
        public static EnumValues Ebonyi => EnumValues.Ebonyi;

        /// <summary>
        /// Edo
        /// </summary>
        public static EnumValues Edo => EnumValues.Edo;

        /// <summary>
        /// Ekiti
        /// </summary>
        public static EnumValues Ekiti => EnumValues.Ekiti;

        /// <summary>
        /// Enugu
        /// </summary>
        public static EnumValues Enugu => EnumValues.Enugu;

        /// <summary>
        /// Federal Capital Territory
        /// </summary>
        public static EnumValues FederalCapitalTerritory => EnumValues.FederalCapitalTerritory;

        /// <summary>
        /// Gombe 
        /// </summary>
        public static EnumValues Gombe => EnumValues.Gombe;

        /// <summary>
        /// Imo
        /// </summary>
        public static EnumValues Imo => EnumValues.Imo;

        /// <summary>
        /// Jigawa 
        /// </summary>
        public static EnumValues Jigawa => EnumValues.Jigawa;

        /// <summary>
        /// Kaduna
        /// </summary>
        public static EnumValues Kaduna => EnumValues.Kaduna;

        /// <summary>
        /// Kebbi
        /// </summary>
        public static EnumValues Kebbi => EnumValues.Kebbi;

        /// <summary>
        /// Kano
        /// </summary>
        public static EnumValues Kano => EnumValues.Kano;

        /// <summary>
        /// Kogi 
        /// </summary>
        public static EnumValues Kogi => EnumValues.Kogi;

        /// <summary>
        /// Katsina
        /// </summary>
        public static EnumValues Katsina => EnumValues.Katsina;

        /// <summary>
        /// Kwara 
        /// </summary>
        public static EnumValues Kwara => EnumValues.Kwara;

        /// <summary>
        /// Lagos
        /// </summary>
        public static EnumValues Lagos => EnumValues.Lagos;

        /// <summary>
        /// Nasarawa
        /// </summary>
        public static EnumValues Nasarawa => EnumValues.Nasarawa;

        /// <summary>
        /// Niger 
        /// </summary>
        public static EnumValues Niger => EnumValues.Niger;

        /// <summary>
        /// Ogun
        /// </summary>
        public static EnumValues Ogun => EnumValues.Ogun;

        /// <summary>
        /// Ondo 
        /// </summary>
        public static EnumValues Ondo => EnumValues.Ondo;

        /// <summary>
        /// Osun 
        /// </summary>
        public static EnumValues Osun => EnumValues.Osun;

        /// <summary>
        /// Oyo
        /// </summary>
        public static EnumValues Oyo => EnumValues.Oyo;

        /// <summary>
        /// Plateau 
        /// </summary>
        public static EnumValues Plateau => EnumValues.Plateau;

        /// <summary>
        /// Rivers
        /// </summary>
        public static EnumValues Rivers => EnumValues.Rivers;

        /// <summary>
        /// Sokoto
        /// </summary>
        public static EnumValues Sokoto => EnumValues.Sokoto;

        /// <summary>
        /// Taraba
        /// </summary>
        public static EnumValues Taraba => EnumValues.Taraba;

        /// <summary>
        /// Yobe
        /// </summary>
        public static EnumValues Yobe => EnumValues.Yobe;

        /// <summary>
        /// Zamfara
        /// </summary>
        public static EnumValues Zamfara => EnumValues.Zamfara;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Nigeria regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Abia
            /// </summary>
            [AliasInShort("AB")][RegionCode(3_00_142_0001)] Abia,

            /// <summary>
            /// Adamawa
            /// </summary>
            [AliasInShort("AD")][RegionCode(3_00_142_0002)] Adamawa,

            /// <summary>
            /// Akwa Ibom
            /// </summary>
            [AliasInShort("AK")][RegionCode(3_00_142_0003)] AkwaIbom,

            /// <summary>
            /// Anambra
            /// </summary>
            [AliasInShort("AN")][RegionCode(3_00_142_0004)] Anambra,

            /// <summary>
            /// Bauchi
            /// </summary>
            [AliasInShort("BA")][RegionCode(3_00_142_0005)] Bauchi,

            /// <summary>
            /// Benue
            /// </summary>
            [AliasInShort("BE")][RegionCode(3_00_142_0006)] Benue,

            /// <summary>
            /// Borno
            /// </summary>
            [AliasInShort("BO")][RegionCode(3_00_142_0007)] Borno,

            /// <summary>
            /// Bayelsa
            /// </summary>
            [AliasInShort("BY")][RegionCode(3_00_142_0008)] Bayelsa,

            /// <summary>
            /// Cross River
            /// </summary>
            [AliasInShort("CR")][RegionCode(3_00_142_0009)] CrossRiver,

            /// <summary>
            /// Delta
            /// </summary>
            [AliasInShort("DE")][RegionCode(3_00_142_0010)] Delta,

            /// <summary>
            /// Ebonyi
            /// </summary>
            [AliasInShort("EB")][RegionCode(3_00_142_0011)] Ebonyi,

            /// <summary>
            /// Edo
            /// </summary>
            [AliasInShort("ED")][RegionCode(3_00_142_0012)] Edo,

            /// <summary>
            /// Ekiti
            /// </summary>
            [AliasInShort("EK")][RegionCode(3_00_142_0013)] Ekiti,

            /// <summary>
            /// Enugu
            /// </summary>
            [AliasInShort("EN")][RegionCode(3_00_142_0014)] Enugu,

            /// <summary>
            /// Federal Capital Territory
            /// </summary>
            [AliasInShort("FC")][RegionCode(3_00_142_0015)] FederalCapitalTerritory,

            /// <summary>
            /// Gombe
            /// </summary>
            [AliasInShort("GO")][RegionCode(3_00_142_0016)] Gombe,

            /// <summary>
            /// Imo
            /// </summary>
            [AliasInShort("IM")][RegionCode(3_00_142_0017)] Imo,

            /// <summary>
            /// Jigawa
            /// </summary>
            [AliasInShort("JI")][RegionCode(3_00_142_0018)] Jigawa,

            /// <summary>
            /// Kaduna
            /// </summary>
            [AliasInShort("KD")][RegionCode(3_00_142_0019)] Kaduna,

            /// <summary>
            /// Kebbi
            /// </summary>
            [AliasInShort("KE")][RegionCode(3_00_142_0020)] Kebbi,

            /// <summary>
            /// Kano
            /// </summary>
            [AliasInShort("KN")][RegionCode(3_00_142_0021)] Kano,

            /// <summary>
            /// Kogi
            /// </summary>
            [AliasInShort("KO")][RegionCode(3_00_142_0022)] Kogi,

            /// <summary>
            /// Katsina
            /// </summary>
            [AliasInShort("KT")][RegionCode(3_00_142_0023)] Katsina,

            /// <summary>
            /// Kwara
            /// </summary>
            [AliasInShort("KW")][RegionCode(3_00_142_0024)] Kwara,

            /// <summary>
            /// Lagos
            /// </summary>
            [AliasInShort("LA")] [RegionCode(3_00_142_0025)]Lagos,

            /// <summary>
            /// Nasarawa
            /// </summary>
            [AliasInShort("NA")][RegionCode(3_00_142_0026)] Nasarawa,

            /// <summary>
            /// Niger
            /// </summary>
            [AliasInShort("NI")][RegionCode(3_00_142_0027)] Niger,

            /// <summary>
            /// Ogun
            /// </summary>
            [AliasInShort("OG")][RegionCode(3_00_142_0028)] Ogun,

            /// <summary>
            /// Ondo
            /// </summary>
            [AliasInShort("ON")][RegionCode(3_00_142_0029)] Ondo,

            /// <summary>
            /// Osun
            /// </summary>
            [AliasInShort("OS")][RegionCode(3_00_142_0030)] Osun,

            /// <summary>
            /// Oyo
            /// </summary>
            [AliasInShort("OY")][RegionCode(3_00_142_0031)] Oyo,

            /// <summary>
            /// Plateau
            /// </summary>
            [AliasInShort("PL")][RegionCode(3_00_142_0032)] Plateau,

            /// <summary>
            /// Rivers
            /// </summary>
            [AliasInShort("RI")][RegionCode(3_00_142_0033)] Rivers,

            /// <summary>
            /// Sokoto
            /// </summary>
            [AliasInShort("SO")][RegionCode(3_00_142_0034)] Sokoto,

            /// <summary>
            /// Taraba
            /// </summary>
            [AliasInShort("TA")][RegionCode(3_00_142_0035)] Taraba,

            /// <summary>
            /// Yobe
            /// </summary>
            [AliasInShort("YO")][RegionCode(3_00_142_0036)] Yobe,

            /// <summary>
            /// Zamfara
            /// </summary>
            [AliasInShort("ZA")][RegionCode(3_00_142_0037)] Zamfara,

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