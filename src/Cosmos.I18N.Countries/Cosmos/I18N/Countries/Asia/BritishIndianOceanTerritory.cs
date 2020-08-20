using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 英属印度洋领地（British Indian Ocean Territory，亚洲，IO，IOT，086） <br />
    /// Cosmos i18n code: i18n_country_yingshuying <br />
    /// Cosmos region code: 100107
    /// </summary>
    public static class BritishIndianOceanTerritory
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static BritishIndianOceanTerritory()
        {
            _country = new CountryInfo
            {
                Country = Country.BritishIndianOceanTerritory,
                CountryCode = CountryCode.IO,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "086",
                Cep1CrCode = 1_00_107,
                Alpha2Code = "IO",
                Alpha3Code = "IOT",
                Name = "British Indian Ocean Territory",
                ChineseName = "英属印度洋领地",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 英属印度洋领地（British Indian Ocean Territory，亚洲，IO，IOT，086） <br />
        /// Cosmos i18n code: i18n_country_yingshuying <br />
        /// Cosmos region code: 100107
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yingshuying";

        /// <summary>
        /// Get Cosmos Region Code (CEP-1/CRCode)
        /// </summary>
        public static long CosmosRegionCode => _country.Cep1CrCode;

        /// <summary>
        /// Get Cosmos Region Identity Code (CEP-1/IICode)
        /// </summary>
        public static string CosmosIdentityCode => _country.I18NIdentityCode;

        /// <summary>
        /// Get M49 code / ISO 3166-1 numeric
        /// </summary>
        public static string M49Code => _country.M49Code;

        /// <summary>
        /// Get Alpha2 code / ISO 3166-1 alpha-2
        /// </summary>
        public static string Alpha2Code => _country.Alpha2Code;

        /// <summary>
        /// Get Alpha3 code / ISO 3166-1 alpha-3
        /// </summary>
        public static string Alpha3Code => _country.Alpha3Code;
    }
}