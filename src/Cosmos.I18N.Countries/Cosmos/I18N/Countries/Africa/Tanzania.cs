namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 坦桑尼亚（The United Republic of Tanzania，非洲，TZ，TZA，834），坦桑尼亚联合共和国 <br />
    /// Cosmos i18n code: i18n_country_tansangniya <br />
    /// Cosmos region code: 300014
    /// </summary>
    public static class Tanzania {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Tanzania() {
            _country = new CountryInfo {
                Country = Country.Tanzania,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Tanzania,
                M49Code = "834",
                CRCode = 3_00_014,
                Alpha2Code = "TZ",
                Alpha3Code = "TZA",
                Name = "The United Republic of Tanzania",
                ShorterForm = "Tanzania",
                ChineseName = "坦桑尼亚联合共和国",
                ChineseShorterForm = "坦桑尼亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 坦桑尼亚（The United Republic of Tanzania，非洲，TZ，TZA，834），坦桑尼亚联合共和国 <br />
        /// Cosmos i18n code: i18n_country_tansangniya <br />
        /// Cosmos region code: 300014
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tansangniya";

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