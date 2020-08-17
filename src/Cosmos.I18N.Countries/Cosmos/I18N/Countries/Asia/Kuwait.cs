namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 科威特（The State of Kuwait，亚洲，KW，KWT，414），科威特国 <br />
    /// Cosmos i18n code: i18n_country_keweite <br />
    /// Cosmos region code: 100120
    /// </summary>
    public static class Kuwait {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Kuwait() {
            _country = new CountryInfo {
                Country = Country.Kuwait,
                CountryCode = CountryCode.KW,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Kuwait,
                M49Code = "414",
                CRCode = 1_00_120,
                Alpha2Code = "KW",
                Alpha3Code = "KWT",
                Name = "The State of Kuwait",
                ShorterForm = "Kuwait",
                ChineseName = "科威特国",
                ChineseShorterForm = "科威特",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 科威特（The State of Kuwait，亚洲，KW，KWT，414），科威特国 <br />
        /// Cosmos i18n code: i18n_country_keweite <br />
        /// Cosmos region code: 100120
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_keweite";

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