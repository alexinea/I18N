namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 牙买加（Jamaica，北美洲，JM，JAM，388） <br />
    /// Cosmos i18n code: i18n_country_yamaijia <br />
    /// Cosmos region code: 400121
    /// </summary>
    public static class Jamaica {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Jamaica() {
            _country = new CountryInfo {
                Country = Country.Jamaica,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Jamaica,
                M49Code = "388",
                CRCode = 4_00_121,
                Alpha2Code = "JM",
                Alpha3Code = "JAM",
                Name = "Jamaica",
                ChineseName = "牙买加",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 牙买加（Jamaica，北美洲，JM，JAM，388） <br />
        /// Cosmos i18n code: i18n_country_yamaijia <br />
        /// Cosmos region code: 400121
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yamaijia";

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