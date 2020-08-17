namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 巴拿马（The Republic of Panama，北美洲，PA，PAN，591），巴拿马共和国 <br />
    /// Cosmos i18n code: i18n_country_banama <br />
    /// Cosmos region code: 400125
    /// </summary>
    public static class Panama {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Panama() {
            _country = new CountryInfo {
                Country = Country.Panama,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Panama,
                M49Code = "591",
                CRCode = 4_00_125,
                Alpha2Code = "PA",
                Alpha3Code = "PAN",
                Name = "The Republic of Panama",
                ShorterForm = "Panama",
                ChineseName = "巴拿马共和国",
                ChineseShorterForm = "巴拿马",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴拿马（The Republic of Panama，北美洲，PA，PAN，591），巴拿马共和国 <br />
        /// Cosmos i18n code: i18n_country_banama <br />
        /// Cosmos region code: 400125
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_banama";

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