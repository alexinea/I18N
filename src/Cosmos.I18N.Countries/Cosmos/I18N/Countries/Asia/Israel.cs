namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 以色列（The State of Israel，亚洲，IL，ISR，376），以色列国 <br />
    /// Cosmos i18n code: i18n_country_yiselie <br />
    /// Cosmos region code: 100015
    /// </summary>
    public static class Israel {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Israel() {
            _country = new CountryInfo {
                Country = Country.Israel,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Israel,
                M49Code = "376",
                CRCode = 1_00_015,
                Alpha2Code = "IL",
                Alpha3Code = "ISR",
                Name = "The State of Israel",
                ShorterForm = "Israel",
                ChineseName = "以色列国",
                ChineseShorterForm = "以色列",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 以色列（The State of Israel，亚洲，IL，ISR，376），以色列国 <br />
        /// Cosmos i18n code: i18n_country_yiselie
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yiselie";

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