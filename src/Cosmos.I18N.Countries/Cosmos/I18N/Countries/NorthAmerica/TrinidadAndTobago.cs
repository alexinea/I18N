namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 特立尼达和多巴哥（Republic of Trinidad and Tobago，北美洲，TT，TTO，780），特立尼达和多巴哥共和国 <br />
    /// Cosmos i18n code: i18n_country_telinidaduobage <br />
    /// Cosmos region code: 400134
    /// </summary>
    public static class TrinidadAndTobago {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static TrinidadAndTobago() {
            _country = new CountryInfo {
                Country = Country.TrinidadAndTobago,
                CountryCode = CountryCode.TT,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.TrinidadAndTobago,
                M49Code = "780",
                CRCode = 4_00_134,
                Alpha2Code = "TT",
                Alpha3Code = "TTO",
                Name = "Republic of Trinidad and Tobago",
                ShorterForm = "Trinidad and Tobago",
                ChineseName = "特立尼达和多巴哥共和国",
                ChineseShorterForm = "特立尼达和多巴哥",
                ChineseAlias = "特多",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 特立尼达和多巴哥（Republic of Trinidad and Tobago，北美洲，TT，TTO，780），特立尼达和多巴哥共和国 <br />
        /// Cosmos i18n code: i18n_country_telinidaduobage <br />
        /// Cosmos region code: 400134
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_telinidaduobage";

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