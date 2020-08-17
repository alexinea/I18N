namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// 巴西（The Federative Republic of Brazil，南美洲，BR，BRA，076），巴西联邦共和国 <br />
    /// Cosmos i18n code: i18n_country_baxi <br />
    /// Cosmos region code: 500001
    /// </summary>
    public static class Brazil {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Brazil() {
            _country = new CountryInfo {
                Country = Country.Brazil,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Brazil,
                M49Code = "076",
                CRCode = 5_00_001,
                Alpha2Code = "BR",
                Alpha3Code = "BRA",
                Name = "The Federative Republic of Brazil",
                ShorterForm = "Brazil",
                ChineseName = "巴西联邦共和国",
                ChineseShorterForm = "巴西",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴西（The Federative Republic of Brazil，南美洲，BR，BRA，076），巴西联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_baxi <br />
        /// Cosmos region code: 500001
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18n
        /// </summary>
        public const string I18N_IDENTITY_CODE = "i18n_country_baxi";

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