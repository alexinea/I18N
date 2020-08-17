namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 阿塞拜疆（The Republic of Azerbaijan，亚洲，AZ，AZE，031），阿塞拜疆共和国 <br />
    /// Cosmos i18n code: i18n_country_asaibaijiang <br />
    /// Cosmos region code: 100103
    /// </summary>
    public static class Azerbaijan {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Azerbaijan() {
            _country = new CountryInfo {
                Country = Country.Azerbaijan,
                CountryCode = CountryCode.AZ,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Azerbaijan,
                M49Code = "031",
                CRCode = 1_00_103,
                Alpha2Code = "AZ",
                Alpha3Code = "AZE",
                Name = "The Republic of Azerbaijan",
                ShorterForm = "Azerbaijan",
                ChineseName = "阿塞拜疆共和国",
                ChineseShorterForm = "阿塞拜疆",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 阿塞拜疆（The Republic of Azerbaijan，亚洲，AZ，AZE，031），阿塞拜疆共和国 <br />
        /// Cosmos i18n code: i18n_country_asaibaijiang <br />
        /// Cosmos region code: 100103
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_asaibaijiang";

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