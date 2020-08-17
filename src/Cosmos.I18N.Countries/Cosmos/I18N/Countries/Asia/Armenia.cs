namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 亚美尼亚（Armenia，亚洲，AM，ARM，051），亚美尼亚共和国<br />
    /// Cosmos i18n code: i18n_country_yameiniya <br />
    /// Cosmos region code: 100102
    /// </summary>
    public static class Armenia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Armenia() {
            _country = new CountryInfo {
                Country = Country.Armenia,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Armenia,
                M49Code = "051",
                CRCode = 1_00_102,
                Alpha2Code = "AM",
                Alpha3Code = "ARM",
                Name = "The Republic of Armenia",
                ChineseName = "亚美尼亚共和国",
                ChineseShorterForm = "亚美尼亚",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 亚美尼亚（Armenia，亚洲，AM，ARM，051），亚美尼亚共和国<br />
        /// Cosmos i18n code: i18n_country_yameiniya <br />
        /// Cosmos region code: 100102
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yameiniya";

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