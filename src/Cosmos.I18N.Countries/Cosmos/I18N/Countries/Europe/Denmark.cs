namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 丹麦（The Kingdom of Denmark，欧洲，DK，DNK，208），丹麦王国 <br />
    /// Cosmos i18n code: i18n_country_danmai <br />
    /// Cosmos region code: 200110
    /// </summary>
    public static class Denmark {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Denmark() {
            _country = new CountryInfo {
                Country = Country.Denmark,
                CountryCode = CountryCode.DK,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Denmark,
                M49Code = "208",
                CRCode = 2_00_110,
                Alpha2Code = "DK",
                Alpha3Code = "DNK",
                Name = "The Kingdom of Denmark",
                ShorterForm = "Denmark",
                ChineseName = "丹麦王国",
                ChineseShorterForm = "丹麦",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 丹麦（The Kingdom of Denmark，欧洲，DK，DNK，208），丹麦王国 <br />
        /// Cosmos i18n code: i18n_country_danmai <br />
        /// Cosmos region code: 200110
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_danmai";

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