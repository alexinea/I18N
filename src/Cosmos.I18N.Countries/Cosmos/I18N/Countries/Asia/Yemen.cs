namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 也门（The Republic Of Yemen，亚洲，YE，YEM，887），也门共和国 <br />
    /// Cosmos i18n code: i18n_country_yemen <br />
    /// Cosmos region code: 100142
    /// </summary>
    public static class Yemen {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Yemen() {
            _country = new CountryInfo {
                Country = Country.Yemen,
                CountryCode = CountryCode.YE,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Yemen,
                M49Code = "887",
                CRCode = 1_00_142,
                Alpha2Code = "YE",
                Alpha3Code = "YEM",
                Name = "The Republic Of Yemen",
                ShorterForm = "Yemen",
                ChineseName = "也门共和国",
                ChineseShorterForm = "也门",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 也门（The Republic Of Yemen，亚洲，YE，YEM，887），也门共和国 <br />
        /// Cosmos i18n code: i18n_country_yemen <br />
        /// Cosmos region code: 100142
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yemen";

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