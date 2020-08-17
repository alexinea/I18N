namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 约旦（The Hashemite Kingdom of Jordan，亚洲，JO，JOR，400），约旦哈希姆王国 <br />
    /// Cosmos i18n code: i18n_country_yuedan <br />
    /// Cosmos region code: 100118
    /// </summary>
    public static class Jordan {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Jordan() {
            _country = new CountryInfo {
                Country = Country.Jordan,
                CountryCode = CountryCode.JO,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Jordan,
                M49Code = "400",
                CRCode = 1_00_118,
                Alpha2Code = "JO",
                Alpha3Code = "JOR",
                Name = "The Hashemite Kingdom of Jordan",
                ShorterForm = "Jordan",
                ChineseName = "约旦哈希姆王国",
                ChineseShorterForm = "约旦",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 约旦（The Hashemite Kingdom of Jordan，亚洲，JO，JOR，400），约旦哈希姆王国 <br />
        /// Cosmos i18n code: i18n_country_yuedan <br />
        /// Cosmos region code: 100118
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yuedan";

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