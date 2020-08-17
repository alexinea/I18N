namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 墨西哥（The United Mexican States，北美洲，MX，MEX，484），墨西哥合众国 <br />
    /// Cosmos i18n code: i18n_country_moxige <br />
    /// Cosmos region code: 400123
    /// </summary>
    public static class Mexico {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mexico() {
            _country = new CountryInfo {
                Country = Country.Mexico,
                CountryCode = CountryCode.MX,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Mexico,
                M49Code = "484",
                CRCode = 4_00_123,
                Alpha2Code = "MX",
                Alpha3Code = "MEX",
                Name = "The United Mexican States",
                ShorterForm = "Mexico",
                ChineseName = "墨西哥合众国",
                ChineseShorterForm = "墨西哥",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 墨西哥（The United Mexican States，北美洲，MX，MEX，484），墨西哥合众国 <br />
        /// Cosmos i18n code: i18n_country_moxige <br />
        /// Cosmos region code: 400123
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_moxige";

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