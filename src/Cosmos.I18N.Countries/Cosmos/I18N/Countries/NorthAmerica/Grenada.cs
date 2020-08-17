namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 格林纳达（Grenada，北美洲，GD，GRD，308） <br />
    /// Cosmos i18n code: i18n_country_gelinnada <br />
    /// Cosmos region code: 400117
    /// </summary>
    public static class Grenada {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Grenada() {
            _country = new CountryInfo {
                Country = Country.Grenada,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Grenada,
                M49Code = "308",
                CRCode = 4_00_117,
                Alpha2Code = "GD",
                Alpha3Code = "GRD",
                Name = "Grenada",
                ChineseName = "格林纳达",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 格林纳达（Grenada，北美洲，GD，GRD，308） <br />
        /// Cosmos i18n code: i18n_country_gelinnada <br />
        /// Cosmos region code: 400117
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gelinnada";

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