namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 津巴布韦（Zimbabwe，非洲，ZW，ZWE，716），津巴布韦共和国 <br />
    /// Cosmos i18n code: i18n_country_jinbabuwei <br />
    /// Cosmos region code: 300119
    /// </summary>
    public static class Zimbabwe {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Zimbabwe() {
            _country = new CountryInfo {
                Country = Country.Zimbabwe,
                CountryCode = CountryCode.ZW,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Zimbabwe,
                M49Code = "716",
                CRCode = 3_00_119,
                Alpha2Code = "ZW",
                Alpha3Code = "ZWE",
                Name = "The Republic of Zimbabwe",
                ShorterForm = "Zimbabwe",
                ChineseName = "津巴布韦共和国",
                ChineseShorterForm = "津巴布韦",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 津巴布韦（Zimbabwe，非洲，ZW，ZWE，716），津巴布韦共和国 <br />
        /// Cosmos i18n code: i18n_country_jinbabuwei <br />
        /// Cosmos region code: 300119
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jinbabuwei";

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