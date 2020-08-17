namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 利比亚（State of Libya，非洲，LY，LBY，434），利比亚国 <br />
    /// Cosmos i18n code: i18n_country_libiya <br />
    /// Cosmos region code: 300133
    /// </summary>
    public static class Libya {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Libya() {
            _country = new CountryInfo {
                Country = Country.Libya,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Libya,
                M49Code = "434",
                CRCode = 3_00_133,
                Alpha2Code = "LY",
                Alpha3Code = "LBY",
                Name = "State of Libya",
                ShorterForm = "Libya",
                ChineseName = "利比亚国",
                ChineseShorterForm = "利比亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 利比亚（State of Libya，非洲，LY，LBY，434），利比亚国 <br />
        /// Cosmos i18n code: i18n_country_libiya <br />
        /// Cosmos region code: 300133
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_libiya";

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