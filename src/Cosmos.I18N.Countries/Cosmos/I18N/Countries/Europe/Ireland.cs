namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 爱尔兰（Republic of Ireland，欧洲，IE，IRL，372），爱尔兰共和国 <br />
    /// Cosmos i18n code: i18n_country_aierlan <br />
    /// Cosmos region code: 200117
    /// </summary>
    public static class Ireland {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Ireland() {
            _country = new CountryInfo {
                Country = Country.Ireland,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Ireland,
                M49Code = "372",
                CRCode = 2_00_117,
                Alpha2Code = "IE",
                Alpha3Code = "IRL",
                Name = "Republic of Ireland",
                ShorterForm = "Ireland",
                ChineseName = "爱尔兰共和国",
                ChineseShorterForm = "爱尔兰",
                Continent = Continent.Europe,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 爱尔兰（Republic of Ireland，欧洲，IE，IRL，372），爱尔兰共和国 <br />
        /// Cosmos i18n code: i18n_country_aierlan <br />
        /// Cosmos region code: 200117
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aierlan";

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