namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 比利时（The Kingdom of Belgium，欧洲，BE，BEL，056），比利时王国 <br />
    /// Cosmos i18n code: i18n_country_bilishi <br />
    /// Cosmos region code: 200105
    /// </summary>
    public static class Belgium {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Belgium() {
            _country = new CountryInfo {
                Country = Country.Belgium,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Belgium,
                M49Code = "056",
                CRCode = 2_00_105,
                Alpha2Code = "BE",
                Alpha3Code = "BEL",
                Name = "The Kingdom of Belgium",
                ShorterForm = "Belgium",
                ChineseName = "比利时王国",
                ChineseShorterForm = "比利时",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 比利时（The Kingdom of Belgium，欧洲，BE，BEL，056），比利时王国 <br />
        /// Cosmos i18n code: i18n_country_bilishi <br />
        /// Cosmos region code: 200105
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bilishi";

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