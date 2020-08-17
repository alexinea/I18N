namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 斯洛伐克（The Slovak Republic，欧洲，SK，SVK，703），斯洛伐克共和国 <br />
    /// Cosmos i18n code: i18n_country_siluofake <br />
    /// Cosmos region code: 200137
    /// </summary>
    public static class Slovakia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Slovakia() {
            _country = new CountryInfo {
                Country = Country.Slovakia,
                CountryCode = CountryCode.SK,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Slovakia,
                M49Code = "703",
                CRCode = 2_00_137,
                Alpha2Code = "SK",
                Alpha3Code = "SVK",
                Name = "The Slovak Republic",
                ShorterForm = "Slovakia",
                ChineseName = "斯洛伐克共和国",
                ChineseShorterForm = "斯洛伐克",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 斯洛伐克（The Slovak Republic，欧洲，SK，SVK，703），斯洛伐克共和国 <br />
        /// Cosmos i18n code: i18n_country_siluofake <br />
        /// Cosmos region code: 200137
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_siluofake";

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