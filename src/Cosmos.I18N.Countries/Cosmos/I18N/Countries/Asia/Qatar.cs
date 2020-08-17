namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 卡塔尔（State of Qatar，亚洲，QA，QAT，634），卡塔尔国 <br />
    /// Cosmos i18n code: i18n_country_kataer <br />
    /// Cosmos region code: 100132
    /// </summary>
    public static class Qatar {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Qatar() {
            _country = new CountryInfo {
                Country = Country.Qatar,
                CountryCode = CountryCode.QA,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Qatar,
                M49Code = "634",
                CRCode = 1_00_132,
                Alpha2Code = "QA",
                Alpha3Code = "QAT",
                Name = "State of Qatar",
                ShorterForm = "Qatar",
                ChineseName = "卡塔尔国",
                ChineseShorterForm = "卡塔尔",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 卡塔尔（State of Qatar，亚洲，QA，QAT，634），卡塔尔国 <br />
        /// Cosmos i18n code: i18n_country_kataer <br />
        /// Cosmos region code: 100132
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kataer";

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