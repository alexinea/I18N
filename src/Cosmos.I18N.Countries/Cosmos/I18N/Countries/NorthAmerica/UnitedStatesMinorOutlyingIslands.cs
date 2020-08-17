namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 美国本土外小岛屿（United States Minor Outlying Islands，北美洲，UM，UMI，581） <br />
    /// Cosmos i18n code: i18n_country_meiguoum <br />
    /// Cosmos region code: 400136
    /// </summary>
    public static class UnitedStatesMinorOutlyingIslands {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static UnitedStatesMinorOutlyingIslands() {
            _country = new CountryInfo {
                Country = Country.UnitedStatesMinorOutlyingIslands,
                CountryCode = CountryCode.UM,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedStates,
                M49Code = "581",
                CRCode = 4_00_136,
                Alpha2Code = "UM",
                Alpha3Code = "UMI",
                Name = "United States Minor Outlying Islands",
                ChineseName = "美国本土外小岛屿",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 美国本土外小岛屿（United States Minor Outlying Islands，北美洲，UM，UMI，581） <br />
        /// Cosmos i18n code: i18n_country_meiguoum <br />
        /// Cosmos region code: 400136
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_meiguoum";

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