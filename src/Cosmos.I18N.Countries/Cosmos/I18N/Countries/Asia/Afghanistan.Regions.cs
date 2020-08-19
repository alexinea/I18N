using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Afghanistan Regions
    /// </summary>
    public static partial class Afghanistan
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Balkh
            /// </summary>
            public static EnumValues Balkh => EnumValues.Balkh;

            /// <summary>
            /// Bamyan
            /// </summary>
            public static EnumValues Bamyan => EnumValues.Bamyan;

            /// <summary>
            /// Badghis
            /// </summary>
            public static EnumValues Badghis => EnumValues.Badghis;

            /// <summary>
            /// Badakhshan
            /// </summary>
            public static EnumValues Badakhshan => EnumValues.Badakhshan;

            /// <summary>
            /// Baghlan
            /// </summary>
            public static EnumValues Baghlan => EnumValues.Baghlan;

            /// <summary>
            /// Daykundi
            /// </summary>
            public static EnumValues Daykundi => EnumValues.Daykundi;

            /// <summary>
            /// Farah
            /// </summary>
            public static EnumValues Farah => EnumValues.Farah;

            /// <summary>
            /// Faryab
            /// </summary>
            public static EnumValues Faryab => EnumValues.Faryab;

            /// <summary>
            /// Ghazni
            /// </summary>
            public static EnumValues Ghazni => EnumValues.Ghazni;

            /// <summary>
            /// Ghōr
            /// </summary>
            public static EnumValues Ghōr => EnumValues.Ghōr;

            /// <summary>
            /// Helmand
            /// </summary>
            public static EnumValues Helmand => EnumValues.Helmand;

            /// <summary>
            /// Herat
            /// </summary>
            public static EnumValues Herat => EnumValues.Herat;

            /// <summary>
            /// Jowzjan
            /// </summary>
            public static EnumValues Jowzjan => EnumValues.Jowzjan;

            /// <summary>
            /// Kabul
            /// </summary>
            public static EnumValues Kabul => EnumValues.Kabul;

            /// <summary>
            /// Kandahar
            /// </summary>
            public static EnumValues Kandahar => EnumValues.Kandahar;

            /// <summary>
            /// Kapisa
            /// </summary>
            public static EnumValues Kapisa => EnumValues.Kapisa;

            /// <summary>
            /// Kunduz
            /// </summary>
            public static EnumValues Kunduz => EnumValues.Kunduz;

            /// <summary>
            /// Khost
            /// </summary>
            public static EnumValues Khost => EnumValues.Khost;

            /// <summary>
            /// Kunar
            /// </summary>
            public static EnumValues Kunar => EnumValues.Kunar;

            /// <summary>
            /// Laghman
            /// </summary>
            public static EnumValues Laghman => EnumValues.Laghman;

            /// <summary>
            /// Logar
            /// </summary>
            public static EnumValues Logar => EnumValues.Logar;

            /// <summary>
            /// Nangarhar
            /// </summary>
            public static EnumValues Nangarhar => EnumValues.Nangarhar;

            /// <summary>
            /// Nimruz
            /// </summary>
            public static EnumValues Nimruz => EnumValues.Nimruz;

            /// <summary>
            /// Nuristan
            /// </summary>
            public static EnumValues Nuristan => EnumValues.Nuristan;

            /// <summary>
            /// Panjshir
            /// </summary>
            public static EnumValues Panjshir => EnumValues.Panjshir;

            /// <summary>
            /// Parwan
            /// </summary>
            public static EnumValues Parwan => EnumValues.Parwan;

            /// <summary>
            /// Paktia
            /// </summary>
            public static EnumValues Paktia => EnumValues.Paktia;

            /// <summary>
            /// Paktika
            /// </summary>
            public static EnumValues Paktika => EnumValues.Paktika;

            /// <summary>
            /// Samangan
            /// </summary>
            public static EnumValues Samangan => EnumValues.Samangan;

            /// <summary>
            /// Sar-e Pol
            /// </summary>
            public static EnumValues SarEPol => EnumValues.SarEPol;

            /// <summary>
            /// Takhar
            /// </summary>
            public static EnumValues Takhar => EnumValues.Takhar;

            /// <summary>
            /// Urozgan
            /// </summary>
            public static EnumValues Urozgan => EnumValues.Urozgan;

            /// <summary>
            /// Maidan Wardak
            /// </summary>
            public static EnumValues MaidanWardak => EnumValues.MaidanWardak;

            /// <summary>
            /// Zabul
            /// </summary>
            public static EnumValues Zabul => EnumValues.Zabul;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Afghanistan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Balkh
            /// </summary>
            [AliasInShort("BAL")]
            [RegionCode(1_00_101_0001)]
            Balkh,

            /// <summary>
            /// Bamyan
            /// </summary>
            [AliasInShort("BAM")]
            [RegionCode(1_00_101_0002)]
            Bamyan,

            /// <summary>
            /// Badghis
            /// </summary>
            [AliasInShort("BDG")]
            [RegionCode(1_00_101_0003)]
            Badghis,

            /// <summary>
            /// Badakhshan
            /// </summary>
            [AliasInShort("BDS")]
            [RegionCode(1_00_101_0004)]
            Badakhshan,

            /// <summary>
            /// Baghlan
            /// </summary>
            [AliasInShort("BGL")]
            [RegionCode(1_00_101_0005)]
            Baghlan,

            /// <summary>
            /// Daykundi
            /// </summary>
            [AliasInShort("DAY")]
            [RegionCode(1_00_101_0006)]
            Daykundi,

            /// <summary>
            /// Farah
            /// </summary>
            [AliasInShort("FRA")]
            [RegionCode(1_00_101_0007)]
            Farah,

            /// <summary>
            /// Faryab
            /// </summary>
            [AliasInShort("FYB")]
            [RegionCode(1_00_101_0008)]
            Faryab,

            /// <summary>
            /// Ghazni
            /// </summary>
            [AliasInShort("GHA")]
            [RegionCode(1_00_101_0009)]
            Ghazni,

            /// <summary>
            /// Ghōr
            /// </summary>
            [AliasInShort("GHO")]
            [RegionCode(1_00_101_0010)]
            Ghōr,

            /// <summary>
            /// Helmand
            /// </summary>
            [AliasInShort("HEL")]
            [RegionCode(1_00_101_0011)]
            Helmand,

            /// <summary>
            /// Herat
            /// </summary>
            [AliasInShort("HER")]
            [RegionCode(1_00_101_0012)]
            Herat,

            /// <summary>
            /// Jowzjan
            /// </summary>
            [AliasInShort("JOW")]
            [RegionCode(1_00_101_0013)]
            Jowzjan,

            /// <summary>
            /// Kabul
            /// </summary>
            [AliasInShort("KAB")]
            [RegionCode(1_00_101_0014)]
            Kabul,

            /// <summary>
            /// Kandahar
            /// </summary>
            [AliasInShort("KAN")]
            [RegionCode(1_00_101_0015)]
            Kandahar,

            /// <summary>
            /// Kapisa
            /// </summary>
            [AliasInShort("KAP")]
            [RegionCode(1_00_101_0016)]
            Kapisa,

            /// <summary>
            /// Kunduz
            /// </summary>
            [AliasInShort("KDZ")]
            [RegionCode(1_00_101_0017)]
            Kunduz,

            /// <summary>
            /// Khost
            /// </summary>
            [AliasInShort("KHO")]
            [RegionCode(1_00_101_0018)]
            Khost,

            /// <summary>
            /// Kunar
            /// </summary>
            [AliasInShort("KNR")]
            [RegionCode(1_00_101_0019)]
            Kunar,

            /// <summary>
            /// Laghman
            /// </summary>
            [AliasInShort("LAG")]
            [RegionCode(1_00_101_0020)]
            Laghman,

            /// <summary>
            /// Logar
            /// </summary>
            [AliasInShort("LOG")]
            [RegionCode(1_00_101_0021)]
            Logar,

            /// <summary>
            /// Nangarhar
            /// </summary>
            [AliasInShort("NAN")]
            [RegionCode(1_00_101_0022)]
            Nangarhar,

            /// <summary>
            /// Nimruz
            /// </summary>
            [AliasInShort("NIM")]
            [RegionCode(1_00_101_0023)]
            Nimruz,

            /// <summary>
            /// Nuristan
            /// </summary>
            [AliasInShort("NUR")]
            [RegionCode(1_00_101_0024)]
            Nuristan,

            /// <summary>
            /// Panjshir
            /// </summary>
            [AliasInShort("PAN")]
            [RegionCode(1_00_101_0025)]
            Panjshir,

            /// <summary>
            /// Parwan
            /// </summary>
            [AliasInShort("PAR")]
            [RegionCode(1_00_101_0026)]
            Parwan,

            /// <summary>
            /// Paktia
            /// </summary>
            [AliasInShort("PIA")]
            [RegionCode(1_00_101_0027)]
            Paktia,

            /// <summary>
            /// Paktika
            /// </summary>
            [AliasInShort("PKA")]
            [RegionCode(1_00_101_0027)]
            Paktika,

            /// <summary>
            /// Samangan
            /// </summary>
            [AliasInShort("SAM")]
            [RegionCode(1_00_101_0028)]
            Samangan,

            /// <summary>
            /// Sar-e Pol
            /// </summary>
            [AliasInShort("SAR")]
            [RegionCode(1_00_101_0029)]
            SarEPol,

            /// <summary>
            /// Takhar
            /// </summary>
            [AliasInShort("TAK")]
            [RegionCode(1_00_101_0030)]
            Takhar,

            /// <summary>
            /// Urozgan
            /// </summary>
            [AliasInShort("URU")]
            [RegionCode(1_00_101_0031)]
            Urozgan,

            /// <summary>
            /// Maidan Wardak
            /// </summary>
            [AliasInShort("WAR")]
            [RegionCode(1_00_101_0032)]
            MaidanWardak,

            /// <summary>
            /// Zabul
            /// </summary>
            [AliasInShort("ZAB")]
            [RegionCode(1_00_101_0033)]
            Zabul,

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