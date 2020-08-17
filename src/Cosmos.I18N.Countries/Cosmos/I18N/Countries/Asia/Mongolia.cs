namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 蒙古国（Outer Mongolia，亚洲，MN，MNG，496），外蒙古 <br />
    /// Cosmos i18n code: i18n_country_waimenggu <br />
    /// Cosmos region code: 100126
    /// </summary>
    public static class Mongolia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mongolia() {
            _country = new CountryInfo {
                Country = Country.Mongolia,
                CountryCode = CountryCode.MN,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Mongolia,
                M49Code = "496",
                CRCode = 1_00_126,
                Alpha2Code = "MN",
                Alpha3Code = "MNG",
                Name = "Outer Mongolia",
                ShorterForm = "Mongolia",
                ChineseName = "蒙古国",
                ChineseShorterForm = "外蒙古",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 蒙古国（Outer Mongolia，亚洲，MN，MNG，496），外蒙古 <br />
        /// Cosmos i18n code: i18n_country_waimenggu <br />
        /// Cosmos region code: 100126
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_waimenggu";

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