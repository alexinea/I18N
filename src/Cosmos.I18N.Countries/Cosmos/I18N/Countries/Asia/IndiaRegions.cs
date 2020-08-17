using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// India Regions
    /// </summary>
    public static class IndiaRegions
    {
        #region Gets regions

        /// <summary>
        /// Andaman and Nicobar Islands
        /// </summary>
        public static EnumValues AndamanAndNicobarIslands => EnumValues.AndamanAndNicobarIslands;

        /// <summary>
        /// Andhra Pradesh
        /// </summary>
        public static EnumValues AndhraPradesh => EnumValues.AndhraPradesh;

        /// <summary>
        /// Arunachal Pradesh
        /// </summary>
        public static EnumValues ArunachalPradesh => EnumValues.ArunachalPradesh;

        /// <summary>
        /// Assam
        /// </summary>
        public static EnumValues Assam => EnumValues.Assam;

        /// <summary>
        /// Bihar
        /// </summary>
        public static EnumValues Bihar => EnumValues.Bihar;

        /// <summary>
        /// Chandigarh
        /// </summary>
        public static EnumValues Chandigarh => EnumValues.Chandigarh;

        /// <summary>
        /// Chhattisgarh
        /// </summary>
        public static EnumValues Chhattisgarh => EnumValues.Chhattisgarh;

        /// <summary>
        /// Daman and Diu
        /// </summary>
        public static EnumValues DamanAndDiu => EnumValues.DamanAndDiu;

        /// <summary>
        /// Delhi
        /// </summary>
        public static EnumValues Delhi => EnumValues.Delhi;

        /// <summary>
        /// Dadra and Nagar Haveli
        /// </summary>
        public static EnumValues DadraAndNagarHaveli => EnumValues.DadraAndNagarHaveli;

        /// <summary>
        /// Goa
        /// </summary>
        public static EnumValues Goa => EnumValues.Goa;

        /// <summary>
        /// Gujarat
        /// </summary>
        public static EnumValues Gujarat => EnumValues.Gujarat;

        /// <summary>
        /// Himachal Pradesh
        /// </summary>
        public static EnumValues HimachalPradesh => EnumValues.HimachalPradesh;

        /// <summary>
        /// Haryana
        /// </summary>
        public static EnumValues Haryana => EnumValues.Haryana;

        /// <summary>
        /// Jharkhand
        /// </summary>
        public static EnumValues Jharkhand => EnumValues.Jharkhand;

        /// <summary>
        /// Jammu and Kashmir
        /// </summary>
        public static EnumValues JammuAndKashmir => EnumValues.JammuAndKashmir;

        /// <summary>
        /// Karnataka
        /// </summary>
        public static EnumValues Karnataka => EnumValues.Karnataka;

        /// <summary>
        /// Kerala
        /// </summary>
        public static EnumValues Kerala => EnumValues.Kerala;

        /// <summary>
        /// Lakshadweep
        /// </summary>
        public static EnumValues Lakshadweep => EnumValues.Lakshadweep;

        /// <summary>
        /// Maharashtra
        /// </summary>
        public static EnumValues Maharashtra => EnumValues.Maharashtra;

        /// <summary>
        /// Meghalaya
        /// </summary>
        public static EnumValues Meghalaya => EnumValues.Meghalaya;

        /// <summary>
        /// Manipur
        /// </summary>
        public static EnumValues Manipur => EnumValues.Manipur;

        /// <summary>
        /// Madhya Pradesh
        /// </summary>
        public static EnumValues MadhyaPradesh => EnumValues.MadhyaPradesh;

        /// <summary>
        /// Mizoram
        /// </summary>
        public static EnumValues Mizoram => EnumValues.Mizoram;

        /// <summary>
        /// Nagaland
        /// </summary>
        public static EnumValues Nagaland => EnumValues.Nagaland;

        /// <summary>
        /// Odisha
        /// </summary>
        public static EnumValues Odisha => EnumValues.Odisha;

        /// <summary>
        /// Punjab
        /// </summary>
        public static EnumValues Punjab => EnumValues.Punjab;

        /// <summary>
        /// Puducherry
        /// </summary>
        public static EnumValues Puducherry => EnumValues.Puducherry;

        /// <summary>
        /// Rajasthan
        /// </summary>
        public static EnumValues Rajasthan => EnumValues.Rajasthan;

        /// <summary>
        /// Sikkim
        /// </summary>
        public static EnumValues Sikkim => EnumValues.Sikkim;

        /// <summary>
        /// Telangana
        /// </summary>
        public static EnumValues Telangana => EnumValues.Telangana;

        /// <summary>
        /// Tamil Nadu
        /// </summary>
        public static EnumValues TamilNadu => EnumValues.TamilNadu;

        /// <summary>
        /// Tripura
        /// </summary>
        public static EnumValues Tripura => EnumValues.Tripura;

        /// <summary>
        /// Uttar Pradesh
        /// </summary>
        public static EnumValues UttarPradesh => EnumValues.UttarPradesh;

        /// <summary>
        /// Uttarakhand
        /// </summary>
        public static EnumValues Uttarakhand => EnumValues.Uttarakhand;

        /// <summary>
        /// West Bengal
        /// </summary>
        public static EnumValues WestBengal => EnumValues.WestBengal;

        #endregion

        /// <summary>
        /// Enum values for India regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Andaman and Nicobar Islands
            /// </summary>
            [AliasInShort("AN")] [RegionCode(1_00_013_0001)]
            AndamanAndNicobarIslands,

            /// <summary>
            /// Andhra Pradesh
            /// </summary>
            [AliasInShort("AP")] [RegionCode(1_00_013_0002)]
            AndhraPradesh,

            /// <summary>
            /// Arunachal Pradesh
            /// </summary>
            [AliasInShort("AR")] [RegionCode(1_00_013_0003)]
            ArunachalPradesh,

            /// <summary>
            /// Assam
            /// </summary>
            [AliasInShort("AS")] [RegionCode(1_00_013_0004)]
            Assam,

            /// <summary>
            /// Bihar
            /// </summary>
            [AliasInShort("BR")] [RegionCode(1_00_013_0005)]
            Bihar,

            /// <summary>
            /// Chandigarh
            /// </summary>
            [AliasInShort("CH")] [RegionCode(1_00_013_0006)]
            Chandigarh,

            /// <summary>
            /// Chhattisgarh
            /// </summary>
            [AliasInShort("CT")] [RegionCode(1_00_013_0007)]
            Chhattisgarh,

            /// <summary>
            /// Daman and Diu
            /// </summary>
            [AliasInShort("DD")] [RegionCode(1_00_013_0008)]
            DamanAndDiu,

            /// <summary>
            /// Delhi
            /// </summary>
            [AliasInShort("DL")] [RegionCode(1_00_013_0009)]
            Delhi,

            /// <summary>
            /// Dadra and Nagar Haveli
            /// </summary>
            [AliasInShort("DN")] [RegionCode(1_00_013_0010)]
            DadraAndNagarHaveli,

            /// <summary>
            /// Goa
            /// </summary>
            [AliasInShort("GA")] [RegionCode(1_00_013_0011)]
            Goa,

            /// <summary>
            /// Gujarat
            /// </summary>
            [AliasInShort("GJ")] [RegionCode(1_00_013_0012)]
            Gujarat,

            /// <summary>
            /// Himachal Pradesh
            /// </summary>
            [AliasInShort("HP")] [RegionCode(1_00_013_0013)]
            HimachalPradesh,

            /// <summary>
            /// Haryana
            /// </summary>
            [AliasInShort("HR")] [RegionCode(1_00_013_0014)]
            Haryana,

            /// <summary>
            /// Jharkhand
            /// </summary>
            [AliasInShort("JH")] [RegionCode(1_00_013_0015)]
            Jharkhand,

            /// <summary>
            /// Jammu and Kashmir
            /// </summary>
            [AliasInShort("JK")] [RegionCode(1_00_013_0016)]
            JammuAndKashmir,

            /// <summary>
            /// Karnataka
            /// </summary>
            [AliasInShort("KA")] [RegionCode(1_00_013_0017)]
            Karnataka,

            /// <summary>
            /// Kerala
            /// </summary>
            [AliasInShort("KL")] [RegionCode(1_00_013_0018)]
            Kerala,

            /// <summary>
            /// Lakshadweep
            /// </summary>
            [AliasInShort("LD")] [RegionCode(1_00_013_0019)]
            Lakshadweep,

            /// <summary>
            /// Maharashtra
            /// </summary>
            [AliasInShort("MH")] [RegionCode(1_00_013_0020)]
            Maharashtra,

            /// <summary>
            /// Meghalaya
            /// </summary>
            [AliasInShort("ML")] [RegionCode(1_00_013_0021)]
            Meghalaya,

            /// <summary>
            /// Manipur
            /// </summary>
            [AliasInShort("MN")] [RegionCode(1_00_013_0022)]
            Manipur,

            /// <summary>
            /// Madhya Pradesh
            /// </summary>
            [AliasInShort("MP")] [RegionCode(1_00_013_0023)]
            MadhyaPradesh,

            /// <summary>
            /// Mizoram
            /// </summary>
            [AliasInShort("MZ")] [RegionCode(1_00_013_0024)]
            Mizoram,

            /// <summary>
            /// Nagaland
            /// </summary>
            [AliasInShort("NL")] [RegionCode(1_00_013_0025)]
            Nagaland,

            /// <summary>
            /// Odisha
            /// </summary>
            [AliasInShort("OR")] [RegionCode(1_00_013_0026)]
            Odisha,

            /// <summary>
            /// Punjab
            /// </summary>
            [AliasInShort("PB")] [RegionCode(1_00_013_0027)]
            Punjab,

            /// <summary>
            /// Puducherry
            /// </summary>
            [AliasInShort("PY")] [RegionCode(1_00_013_0028)]
            Puducherry,

            /// <summary>
            /// Rajasthan
            /// </summary>
            [AliasInShort("RJ")] [RegionCode(1_00_013_0029)]
            Rajasthan,

            /// <summary>
            /// Sikkim
            /// </summary>
            [AliasInShort("SK")] [RegionCode(1_00_013_0030)]
            Sikkim,

            /// <summary>
            /// Telangana
            /// </summary>
            [AliasInShort("TG")] [RegionCode(1_00_013_0031)]
            Telangana,

            /// <summary>
            /// Tamil Nadu
            /// </summary>
            [AliasInShort("TN")] [RegionCode(1_00_013_0032)]
            TamilNadu,

            /// <summary>
            /// Tripura
            /// </summary>
            [AliasInShort("TR")] [RegionCode(1_00_013_0033)]
            Tripura,

            /// <summary>
            /// Uttar Pradesh
            /// </summary>
            [AliasInShort("UP")] [RegionCode(1_00_013_0034)]
            UttarPradesh,

            /// <summary>
            /// Uttarakhand
            /// </summary>
            [AliasInShort("UT")] [RegionCode(1_00_013_0035)]
            Uttarakhand,

            /// <summary>
            /// West Bengal
            /// </summary>
            [AliasInShort("WB")] [RegionCode(1_00_013_0036)]
            WestBengal,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="IndiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="IndiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"IN-{values.ToRegionCode()}";
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
            return Country.India;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.IN;
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