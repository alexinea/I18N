namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 巴林（The Kingdom of Bahrain ，亚洲，BH，BHR，048），巴林王国 <br />
    /// Cosmos i18n code: i18n_country_balin <br />
    /// Cosmos region code: 100104
    /// </summary>
    public static class Bahrain {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bahrain() {
            _country = new CountryInfo {
                Country = Country.Bahrain,
                CountryCode = CountryCode.BH,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Bahrain,
                M49Code = "048",
                CRCode = 1_00_104,
                Alpha2Code = "BH",
                Alpha3Code = "BHR",
                Name = "The Kingdom of Bahrain",
                ShorterForm = "Bahrain",
                ChineseName = "巴林王国",
                ChineseShorterForm = "巴林",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴林（The Kingdom of Bahrain ，亚洲，BH，BHR，048），巴林王国 <br />
        /// Cosmos i18n code: i18n_country_balin <br />
        /// Cosmos region code: 100104
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_balin";

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