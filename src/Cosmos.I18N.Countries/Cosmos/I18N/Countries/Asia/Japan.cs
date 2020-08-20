using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 日本（Japan，亚洲，JP，JPN，392），日本国 <br />
    /// Cosmos i18n code: i18n_country_riben <br />
    /// Cosmos region code: 100002
    /// </summary>
    public static class Japan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Japan()
        {
            _country = new CountryInfo
            {
                Country = Country.Japan,
                CountryCode = CountryCode.JP,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Japan,
                M49Code = "302",
                Cep1CrCode = 1_00_002,
                Alpha2Code = "JP",
                Alpha3Code = "JPN",
                Name = "Japan",
                ChineseName = "日本国",
                ChineseShorterForm = "日本",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 日本（Japan，亚洲，JP，JPN，392），日本国 <br />
        /// Cosmos i18n code: i18n_country_riben <br />
        /// Cosmos region code: 100002
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_riben";

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