using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Egypt Regions
    /// </summary>
    public static partial class Egypt
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Alexandria
            /// </summary>
            public static EnumValues Alexandria => EnumValues.Alexandria;

            /// <summary>
            /// Aswan
            /// </summary>
            public static EnumValues Aswan => EnumValues.Aswan;

            /// <summary>
            /// Asyut
            /// </summary>
            public static EnumValues Asyut => EnumValues.Asyut;

            /// <summary>
            /// Red Sea
            /// </summary>
            public static EnumValues RedSea => EnumValues.RedSea;

            /// <summary>
            /// Beheira
            /// </summary>
            public static EnumValues Beheira => EnumValues.Beheira;

            /// <summary>
            /// Beni Suef
            /// </summary>
            public static EnumValues BeniSuef => EnumValues.BeniSuef;

            /// <summary>
            /// Cairo
            /// </summary>
            public static EnumValues Cairo => EnumValues.Cairo;

            /// <summary>
            /// Dakahlia
            /// </summary>
            public static EnumValues Dakahlia => EnumValues.Dakahlia;

            /// <summary>
            /// Damietta
            /// </summary>
            public static EnumValues Damietta => EnumValues.Damietta;

            /// <summary>
            /// Faiyum
            /// </summary>
            public static EnumValues Faiyum => EnumValues.Faiyum;

            /// <summary>
            /// Gharbia
            /// </summary>
            public static EnumValues Gharbia => EnumValues.Gharbia;

            /// <summary>
            /// Giza
            /// </summary>
            public static EnumValues Giza => EnumValues.Giza;

            /// <summary>
            /// Ismailia
            /// </summary>
            public static EnumValues Ismailia => EnumValues.Ismailia;

            /// <summary>
            /// South Sinai
            /// </summary>
            public static EnumValues SouthSinai => EnumValues.SouthSinai;

            /// <summary>
            /// Qalyubia
            /// </summary>
            public static EnumValues Qalyubia => EnumValues.Qalyubia;

            /// <summary>
            /// Kafr el-Sheikh
            /// </summary>
            public static EnumValues KafrElSheikh => EnumValues.KafrElSheikh;

            /// <summary>
            /// Qena
            /// </summary>
            public static EnumValues Qena => EnumValues.Qena;

            /// <summary>
            /// Luxor
            /// </summary>
            public static EnumValues Luxor => EnumValues.Luxor;

            /// <summary>
            /// Minya
            /// </summary>
            public static EnumValues Minya => EnumValues.Minya;

            /// <summary>
            /// Monufia
            /// </summary>
            public static EnumValues Monufia => EnumValues.Monufia;

            /// <summary>
            /// Matrouh
            /// </summary>
            public static EnumValues Matrouh => EnumValues.Matrouh;

            /// <summary>
            /// Port Said
            /// </summary>
            public static EnumValues PortSaid => EnumValues.PortSaid;

            /// <summary>
            /// Sohag
            /// </summary>
            public static EnumValues Sohag => EnumValues.Sohag;

            /// <summary>
            /// Al Sharqia
            /// </summary>
            public static EnumValues AlSharqia => EnumValues.AlSharqia;

            /// <summary>
            /// North Sinai
            /// </summary>
            public static EnumValues NorthSinai => EnumValues.NorthSinai;

            /// <summary>
            /// Suez
            /// </summary>
            public static EnumValues Suez => EnumValues.Suez;

            /// <summary>
            /// New Valley
            /// </summary>
            public static EnumValues NewValley => EnumValues.NewValley;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Egypt regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Alexandria
            /// </summary>
            [AliasInShort("ALX")]
            [RegionCode(3_00_011_0001)]
            Alexandria,

            /// <summary>
            /// Aswan
            /// </summary>
            [AliasInShort("ASN")]
            [RegionCode(3_00_011_0002)]
            Aswan,

            /// <summary>
            /// Asyut
            /// </summary>
            [AliasInShort("AST")]
            [RegionCode(3_00_011_0003)]
            Asyut,

            /// <summary>
            /// Red Sea
            /// </summary>
            [AliasInShort("BA")]
            [RegionCode(3_00_011_0004)]
            RedSea,

            /// <summary>
            /// Beheira
            /// </summary>
            [AliasInShort("BH")]
            [RegionCode(3_00_011_0005)]
            Beheira,

            /// <summary>
            /// Beni Suef
            /// </summary>
            [AliasInShort("BNS")]
            [RegionCode(3_00_011_0006)]
            BeniSuef,

            /// <summary>
            /// Cairo
            /// </summary>
            [AliasInShort("C")]
            [RegionCode(3_00_011_0007)]
            Cairo,

            /// <summary>
            /// Dakahlia
            /// </summary>
            [AliasInShort("DK")]
            [RegionCode(3_00_011_0008)]
            Dakahlia,

            /// <summary>
            /// Damietta
            /// </summary>
            [AliasInShort("DT")]
            [RegionCode(3_00_011_0009)]
            Damietta,

            /// <summary>
            /// Faiyum
            /// </summary>
            [AliasInShort("FYM")]
            [RegionCode(3_00_011_0010)]
            Faiyum,

            /// <summary>
            /// Gharbia
            /// </summary>
            [AliasInShort("GH")]
            [RegionCode(3_00_011_0011)]
            Gharbia,

            /// <summary>
            /// Giza
            /// </summary>
            [AliasInShort("GZ")]
            [RegionCode(3_00_011_0012)]
            Giza,

            /// <summary>
            /// Ismailia
            /// </summary>
            [AliasInShort("IS")]
            [RegionCode(3_00_011_0013)]
            Ismailia,

            /// <summary>
            /// South Sinai
            /// </summary>
            [AliasInShort("JS")]
            [RegionCode(3_00_011_0014)]
            SouthSinai,

            /// <summary>
            /// Qalyubia
            /// </summary>
            [AliasInShort("KB")]
            [RegionCode(3_00_011_0015)]
            Qalyubia,

            /// <summary>
            /// Kafr el-Sheikh
            /// </summary>
            [AliasInShort("KFS")]
            [RegionCode(3_00_011_0016)]
            KafrElSheikh,

            /// <summary>
            /// Qena
            /// </summary>
            [AliasInShort("KN")]
            [RegionCode(3_00_011_0017)]
            Qena,

            /// <summary>
            /// Luxor
            /// </summary>
            [AliasInShort("LX")]
            [RegionCode(3_00_011_0018)]
            Luxor,

            /// <summary>
            /// Minya
            /// </summary>
            [AliasInShort("MN")]
            [RegionCode(3_00_011_0019)]
            Minya,

            /// <summary>
            /// Monufia
            /// </summary>
            [AliasInShort("MNF")]
            [RegionCode(3_00_011_0020)]
            Monufia,

            /// <summary>
            /// Matrouh
            /// </summary>
            [AliasInShort("MT")]
            [RegionCode(3_00_011_0021)]
            Matrouh,

            /// <summary>
            /// Port Said
            /// </summary>
            [AliasInShort("PTS")]
            [RegionCode(3_00_011_0022)]
            PortSaid,

            /// <summary>
            /// Sohag
            /// </summary>
            [AliasInShort("SHG")]
            [RegionCode(3_00_011_0023)]
            Sohag,

            /// <summary>
            /// Al Sharqia
            /// </summary>
            [AliasInShort("SHR")]
            [RegionCode(3_00_011_0024)]
            AlSharqia,

            /// <summary>
            /// North Sinai
            /// </summary>
            [AliasInShort("SIN")]
            [RegionCode(3_00_011_0025)]
            NorthSinai,

            /// <summary>
            /// Suez
            /// </summary>
            [AliasInShort("SUZ")]
            [RegionCode(3_00_011_0026)]
            Suez,

            /// <summary>
            /// New Valley
            /// </summary>
            [AliasInShort("WAD")]
            [RegionCode(3_00_011_0027)]
            NewValley,

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