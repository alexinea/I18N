namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 爱沙尼亚（Republic of Estonia，欧洲，EE，EST，233），爱沙尼亚共和国 <br />
    /// Cosmos i18n code: i18n_country_aishaniya <br />
    /// Cosmos region code: 200111
    /// </summary>
    public static class Estonia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Estonia() {
            _country = new CountryInfo {
                Country = Country.Estonia,
                CountryCode = CountryCode.EE,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Estonia,
                M49Code = "233",
                CRCode = 2_00_111,
                Alpha2Code = "EE",
                Alpha3Code = "EST",
                Name = "Republic of Estonia",
                ShorterForm = "Ecuador",
                ChineseName = "爱沙尼亚共和国",
                ChineseShorterForm = "爱沙尼亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 爱沙尼亚（Republic of Estonia，欧洲，EE，EST，233），爱沙尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_aishaniya <br />
        /// Cosmos region code: 200111
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aishaniya";

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