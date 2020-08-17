namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 黑山（Montenegro，欧洲，ME，MNE，499），黑山共和国 <br />
    /// Cosmos i18n code: i18n_country_heishan <br />
    /// Cosmos region code: 200130
    /// </summary>
    public static class Montenegro {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Montenegro() {
            _country = new CountryInfo {
                Country = Country.Montenegro,
                CountryCode = CountryCode.ME,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Montenegro,
                M49Code = "499",
                CRCode = 2_00_130,
                Alpha2Code = "ME",
                Alpha3Code = "MNE",
                Name = "Montenegro",
                ChineseName = "黑山共和国",
                ChineseShorterForm = "黑山",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 黑山（Montenegro，欧洲，ME，MNE，499），黑山共和国 <br />
        /// Cosmos i18n code: i18n_country_heishan <br />
        /// Cosmos region code: 200130
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_heishan";

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