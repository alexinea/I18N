namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 大马（Malaysia，亚洲，MY，MYS，458），马来西亚 <br />
    /// Cosmos i18n code: i18n_country_malaixiya <br />
    /// Cosmos region code: 100124
    /// </summary>
    public static class Malaysia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Malaysia() {
            _country = new CountryInfo {
                Country = Country.Malaysia,
                CountryCode = CountryCode.MY,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Malaysia,
                M49Code = "458",
                CRCode = 1_00_124,
                Alpha2Code = "MY",
                Alpha3Code = "MYS",
                Name = "Malaysia",
                ChineseName = "马来西亚",
                ChineseShorterForm = "大马",
                Continent = Continent.Asia,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 大马（Malaysia，亚洲，MY，MYS，458），马来西亚 <br />
        /// Cosmos i18n code: i18n_country_malaixiya <br />
        /// Cosmos region code: 100124
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_malaixiya";

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