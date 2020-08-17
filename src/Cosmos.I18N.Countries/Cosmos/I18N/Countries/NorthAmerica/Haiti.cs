namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 海地（The Republic of Haiti，北美洲，HT，HTI，332），海地共和国 <br />
    /// Cosmos i18n code: i18n_country_haidi <br />
    /// Cosmos region code: 400120
    /// </summary>
    public static class Haiti {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Haiti() {
            _country = new CountryInfo {
                Country = Country.Haiti,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Haiti,
                M49Code = "332",
                CRCode = 4_00_120,
                Alpha2Code = "HT",
                Alpha3Code = "HTI",
                Name = "The Republic of Haiti",
                ShorterForm = "Haiti",
                ChineseName = "海地共和国",
                ChineseShorterForm = "海地",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 海地（The Republic of Haiti，北美洲，HT，HTI，332），海地共和国 <br />
        /// Cosmos i18n code: i18n_country_haidi <br />
        /// Cosmos region code: 400120
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// 18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_haidi";

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