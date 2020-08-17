namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 卢森堡（The Grand Duchy of Luxembourg，欧洲，LU，LUX，442），卢森堡大公国 <br />
    /// Cosmos i18n code: i18n_country_lusenbao <br />
    /// Cosmos region code: 200124
    /// </summary>
    public static class Luxembourg {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Luxembourg() {
            _country = new CountryInfo {
                Country = Country.Luxembourg,
                CountryCode = CountryCode.LU,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Luxembourg,
                M49Code = "442",
                CRCode = 2_00_124,
                Alpha2Code = "LU",
                Alpha3Code = "LUX",
                Name = "The Grand Duchy of Luxembourg",
                ShorterForm = "Luxembourg",
                ChineseName = "卢森堡大公国",
                ChineseShorterForm = "卢森堡",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 卢森堡（The Grand Duchy of Luxembourg，欧洲，LU，LUX，442），卢森堡大公国 <br />
        /// Cosmos i18n code: i18n_country_lusenbao <br />
        /// Cosmos region code: 200124
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_lusenbao";

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