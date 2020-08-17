namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 黎巴嫩（The Republic of Lebanon，亚洲，LB，LBN，422），黎巴嫩共和国 <br />
    /// Cosmos i18n code: i18n_country_libanen <br />
    /// Cosmos region code: 100123
    /// </summary>
    public static class Lebanon {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Lebanon() {
            _country = new CountryInfo {
                Country = Country.Lebanon,
                CountryCode = CountryCode.LB,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Lebanon,
                M49Code = "422",
                CRCode = 1_00_123,
                Alpha2Code = "LB",
                Alpha3Code = "LBN",
                Name = "The Republic of Lebanon",
                ShorterForm = "Lebanon",
                ChineseName = "黎巴嫩共和国",
                ChineseShorterForm = "黎巴嫩",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 黎巴嫩（The Republic of Lebanon，亚洲，LB，LBN，422），黎巴嫩共和国 <br />
        /// Cosmos i18n code: i18n_country_libanen <br />
        /// Cosmos region code: 100123
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_libanen";

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