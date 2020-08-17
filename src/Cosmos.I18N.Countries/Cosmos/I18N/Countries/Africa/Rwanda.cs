namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 卢旺达（The Republic of Rwanda，非洲，RW，RWA，646），卢旺达共和国 <br />
    /// Cosmos i18n code: i18n_country_luwangda <br />
    /// Cosmos region code: 300144
    /// </summary>
    public static class Rwanda {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Rwanda() {
            _country = new CountryInfo {
                Country = Country.Rwanda,
                CountryCode = CountryCode.RW,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Rwanda,
                M49Code = "646",
                CRCode = 3_00_144,
                Alpha2Code = "RW",
                Alpha3Code = "RWA",
                Name = "The Republic of Rwanda",
                ShorterForm = "Rwanda",
                ChineseName = "卢旺达共和国",
                ChineseShorterForm = "卢旺达",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 卢旺达（The Republic of Rwanda，非洲，RW，RWA，646），卢旺达共和国 <br />
        /// Cosmos i18n code: i18n_country_luwangda <br />
        /// Cosmos region code: 300144
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_luwangda";

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