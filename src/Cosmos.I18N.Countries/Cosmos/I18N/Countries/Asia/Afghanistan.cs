namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 阿富汗（Afghanistan，亚洲，AF，AFG，004），阿富汗伊斯兰国 <br />
    /// Cosmos i18n code: i18n_country_afuhan <br />
    /// Cosmos region code: 100101
    /// </summary>
    public static class Afghanistan {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Afghanistan() {
            _country = new CountryInfo {
                Country = Country.Afghanistan,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Afghanistan,
                M49Code = "004",
                CRCode = 1_00_101,
                Alpha2Code = "AF",
                Alpha3Code = "AFG",
                Name = "Afghanistan",
                ChineseName = "阿富汗伊斯兰国",
                ChineseShorterForm = "阿富汗",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 阿富汗（Afghanistan，亚洲，AF，AFG，004），阿富汗伊斯兰国 <br />
        /// Cosmos i18n code: i18n_country_afuhan <br />
        /// Cosmos region code: 100101
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_afuhan";

        /// <summary>
        /// Get Cosmos Region Code (CEP-1/CRCode)
        /// </summary>
        public static long CosmosRegionCode => _country.CRCode;

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