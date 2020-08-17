namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 叙利亚（The Syrian Arab Republic，亚洲，SY，SYR，760），阿拉伯叙利亚共和国 <br />
    /// Cosmos i18n code: i18n_country_xuliya <br />
    /// Cosmos region code: 100136
    /// </summary>
    public static class Syrian {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Syrian() {
            _country = new CountryInfo {
                Country = Country.Syrian,
                CountryCode = CountryCode.SY,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Syrian,
                M49Code = "760",
                CRCode = 1_00_136,
                Alpha2Code = "SY",
                Alpha3Code = "SYR",
                Name = "The Syrian Arab Republic",
                ShorterForm = "Syrian",
                ChineseName = "阿拉伯叙利亚共和国",
                ChineseShorterForm = "叙利亚",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 叙利亚（The Syrian Arab Republic，亚洲，SY，SYR，760），阿拉伯叙利亚共和国 <br />
        /// Cosmos i18n code: i18n_country_xuliya <br />
        /// Cosmos region code: 100136
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xuliya";

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