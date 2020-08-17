namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 斯威士兰（The Kingdom of Swaziland，非洲，SZ，SWZ，748），斯威士兰王国 <br />
    /// Cosmos i18n code: i18n_country_siweishilan <br />
    /// Cosmos region code: 300155
    /// </summary>
    public static class Swaziland {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Swaziland() {
            _country = new CountryInfo {
                Country = Country.Swaziland,
                CountryCode = CountryCode.SZ,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Swaziland,
                M49Code = "748",
                CRCode = 3_00_155,
                Alpha2Code = "SZ",
                Alpha3Code = "SWZ",
                Name = "The Kingdom of Swaziland",
                ShorterForm = "Swaziland",
                Alias = "The Kingdom of eSwatini",
                ChineseName = "斯威士兰王国",
                ChineseShorterForm = "斯威士兰",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 斯威士兰（The Kingdom of Swaziland，非洲，SZ，SWZ，748），斯威士兰王国 <br />
        /// Cosmos i18n code: i18n_country_siweishilan <br />
        /// Cosmos region code: 300155
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_siweishilan";

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