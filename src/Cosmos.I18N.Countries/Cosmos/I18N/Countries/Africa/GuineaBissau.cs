namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 几内亚比绍（The Republic of Guinea-Bissau，非洲，GW，GNB，624），几内亚比绍共和国 <br />
    /// Cosmos i18n code: i18n_country_jineiyabishao <br />
    /// Cosmos region code: 300130
    /// </summary>
    public static class GuineaBissau {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static GuineaBissau() {
            _country = new CountryInfo {
                Country = Country.GuineaBissau,
                CountryCode = CountryCode.GW,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.GuineaBissau,
                M49Code = "624",
                CRCode = 3_00_130,
                Alpha2Code = "GW",
                Alpha3Code = "GNB",
                Name = "The Republic of Guinea-Bissau",
                ShorterForm = "Guinea Bissau",
                ChineseName = "几内亚比绍共和国",
                ChineseShorterForm = "几内亚比绍",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 几内亚比绍（The Republic of Guinea-Bissau，非洲，GW，GNB，624），几内亚比绍共和国 <br />
        /// Cosmos i18n code: i18n_country_jineiyabishao <br />
        /// Cosmos region code: 300130
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jineiyabishao";

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