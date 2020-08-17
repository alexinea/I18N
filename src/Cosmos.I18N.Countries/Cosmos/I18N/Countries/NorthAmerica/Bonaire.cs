namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 波内赫、圣尤斯特歇斯和萨巴（Bonaire, Sint Eustatius and Saba，北美洲，BQ，BES，535） <br />
    /// Cosmos i18n code: i18n_country_boneihe <br />
    /// Cosmos region code: 400109
    /// </summary>
    public static class Bonaire {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bonaire() {
            _country = new CountryInfo {
                Country = Country.Bonaire,
                CountryCode = CountryCode.BQ,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.Netherlands,
                M49Code = "535",
                CRCode = 4_00_109,
                Alpha2Code = "BQ",
                Alpha3Code = "BES",
                Name = "Bonaire, Sint Eustatius and Saba",
                ChineseName = "波内赫、圣尤斯特歇斯和萨巴",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 波内赫、圣尤斯特歇斯和萨巴（Bonaire, Sint Eustatius and Saba，北美洲，BQ，BES，535） <br />
        /// Cosmos i18n code: i18n_country_boneihe <br />
        /// Cosmos region code: 400109
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_boneihe";

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