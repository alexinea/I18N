namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// 巴拉圭（Republic Of Paraguay，南美洲，PY，PRY，600），巴拉圭共和国 <br />
    /// Cosmos i18n code: i18n_country_balagui <br />
    /// Cosmos region code: 500109
    /// </summary>
    public static class Paraguay {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Paraguay() {
            _country = new CountryInfo {
                Country = Country.Paraguay,
                CountryCode = CountryCode.PY,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Paraguay,
                M49Code = "600",
                CRCode = 5_00_109,
                Alpha2Code = "PY",
                Alpha3Code = "PRY",
                Name = "Republic of Paraguay",
                ShorterForm = "Paraguay",
                ChineseName = "巴拉圭共和国",
                ChineseShorterForm = "巴拉圭",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴拉圭（Republic Of Paraguay，南美洲，PY，PRY，600），巴拉圭共和国 <br />
        /// Cosmos i18n code: i18n_country_balagui <br />
        /// Cosmos region code: 500109
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_balagui";

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