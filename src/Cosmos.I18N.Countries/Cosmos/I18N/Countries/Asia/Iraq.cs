namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 伊拉克（Republic Of Iraq，亚洲，IQ，IRQ，368），伊拉克共和国 <br />
    /// Cosmos i18n code: i18n_country_yilake <br />
    /// Cosmos region code: 100117
    /// </summary>
    public static class Iraq {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Iraq() {
            _country = new CountryInfo {
                Country = Country.Iraq,
                CountryCode = CountryCode.IQ,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Iraq,
                M49Code = "368",
                CRCode = 1_00_117,
                Alpha2Code = "IQ",
                Alpha3Code = "IRQ",
                Name = "Republic Of Iraq",
                ShorterForm = "Iraq",
                ChineseName = "伊拉克共和国",
                ChineseShorterForm = "伊拉克",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 伊拉克（Republic Of Iraq，亚洲，IQ，IRQ，368），伊拉克共和国 <br />
        /// Cosmos i18n code: i18n_country_yilake <br />
        /// Cosmos region code: 100117
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yilake";

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