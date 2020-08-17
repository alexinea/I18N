namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// 玻利维亚（Plurinational State of Bolivia，南美洲，BO，BOL，068），多民族玻利维亚国 <br />
    /// Cosmos i18n code: i18n_country_boliweiya <br />
    /// Cosmos region code: 500101
    /// </summary>
    public static class Bolivia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bolivia() {
            _country = new CountryInfo {
                Country = Country.Bolivia,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Bolivia,
                M49Code = "068",
                CRCode = 5_00_101,
                Alpha2Code = "BO",
                Alpha3Code = "BOL",
                Name = "Plurinational State of Bolivia",
                ShorterForm = "Bolivia",
                ChineseName = "多民族玻利维亚国",
                ChineseShorterForm = "玻利维亚",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 玻利维亚（Plurinational State of Bolivia，南美洲，BO，BOL，068），多民族玻利维亚国 <br />
        /// Cosmos i18n code: i18n_country_balin <br />
        /// Cosmos region code: 500101
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_boliweiya";

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