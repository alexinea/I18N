namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 埃塞俄比亚（The Federal Democratic Republic of Ethiopia，非洲，ET，ETH，231），埃塞俄比亚联邦民主共和国 <br />
    /// Cosmos i18n code: i18n_country_aisaiebiya <br />
    /// Cosmos region code: 300123
    /// </summary>
    public static class Ethiopia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Ethiopia() {
            _country = new CountryInfo {
                Country = Country.Ethiopia,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Ethiopia,
                M49Code = "231",
                CRCode = 3_00_123,
                Alpha2Code = "ET",
                Alpha3Code = "ETH",
                Name = "The Federal Democratic Republic of Ethiopia",
                ShorterForm = "Ethiopia",
                ChineseName = "埃塞俄比亚联邦民主共和国",
                ChineseShorterForm = "埃塞俄比亚",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 埃塞俄比亚（The Federal Democratic Republic of Ethiopia，非洲，ET，ETH，231），埃塞俄比亚联邦民主共和国 <br />
        /// Cosmos i18n code: i18n_country_aisaiebiya <br />
        /// Cosmos region code: 300123
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aisaiebiya";

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