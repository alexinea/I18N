namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 捷克（The Czech Republic，欧洲，CZ，CZE，203），捷克共和国 <br />
    /// Cosmos i18n code: i18n_country_jieke <br />
    /// Cosmos region code: 200012
    /// </summary>
    public static class Czechia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Czechia() {
            _country = new CountryInfo {
                Country = Country.Czechia,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Czechia,
                M49Code = "203",
                CRCode = 2_00_012,
                Alpha2Code = "CZ",
                Alpha3Code = "CZE",
                Name = "The Czech Republic",
                ShorterForm = "Czechia",
                ChineseName = "捷克共和国",
                ChineseShorterForm = "捷克",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 捷克（The Czech Republic，欧洲，CZ，CZE，203），捷克共和国 <br />
        /// Cosmos i18n code: i18n_country_jieke <br />
        /// Cosmos region code: 200012
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jieke";

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