namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 梵蒂冈（Vatican City State，欧洲，VA，VAT，336），梵蒂冈城国 <br />
    /// Cosmos i18n code: i18n_country_fandigang <br />
    /// Cosmos region code: 200141
    /// </summary>
    public static class Vatican {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Vatican() {
            _country = new CountryInfo {
                Country = Country.Vatican,
                CountryCode = CountryCode.VA,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Vatican,
                M49Code = "336",
                CRCode = 2_00_141,
                Alpha2Code = "VA",
                Alpha3Code = "VAT",
                Name = "Vatican City State",
                ShorterForm = "Holy See",
                ChineseName = "梵蒂冈城国",
                ChineseShorterForm = "梵蒂冈",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 梵蒂冈（Vatican City State，欧洲，VA，VAT，336），梵蒂冈城国 <br />
        /// Cosmos i18n code: i18n_country_fandigang <br />
        /// Cosmos region code: 200141
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_fandigang";

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