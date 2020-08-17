namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 乍得（Republic of Chad，非洲，TD，TCD，148），乍得共和国 <br />
    /// Cosmos i18n code: i18n_country_zhade <br />
    /// Cosmos region code: 300110
    /// </summary>
    public static class Chad {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Chad() {
            _country = new CountryInfo {
                Country = Country.Chad,
                CountryCode = CountryCode.TD,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Chad,
                M49Code = "148",
                CRCode = 3_00_110,
                Alpha2Code = "TD",
                Alpha3Code = "TCD",
                Name = "Republic of Chad",
                ShorterForm = "Chad",
                ChineseName = "乍得共和国",
                ChineseShorterForm = "乍得",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 乍得（Republic of Chad，非洲，TD，TCD，148），乍得共和国 <br />
        /// Cosmos i18n code: i18n_country_zhade <br />
        /// Cosmos region code: 300110
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_zhade";

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