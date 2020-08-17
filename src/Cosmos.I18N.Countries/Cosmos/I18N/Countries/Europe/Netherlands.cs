namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 荷兰（The Kingdom of the Netherlands，欧洲，NL，NLD，528），荷兰王国 <br />
    /// Cosmos i18n code: i18n_country_helan <br />
    /// Cosmos region code: 200131
    /// </summary>
    public static class Netherlands {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Netherlands() {
            _country = new CountryInfo {
                Country = Country.Netherlands,
                CountryCode = CountryCode.NL,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Netherlands,
                M49Code = "528",
                CRCode = 2_00_131,
                Alpha2Code = "NL",
                Alpha3Code = "NLD",
                Name = "The Kingdom of the Netherlands",
                ShorterForm = "Netherlands",
                ChineseName = "荷兰王国",
                ChineseShorterForm = "荷兰",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 荷兰（The Kingdom of the Netherlands，欧洲，NL，NLD，528），荷兰王国 <br />
        /// Cosmos i18n code: i18n_country_helan <br />
        /// Cosmos region code: 200131
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_helan";

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