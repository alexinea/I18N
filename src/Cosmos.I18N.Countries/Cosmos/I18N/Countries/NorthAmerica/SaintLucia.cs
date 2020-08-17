namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 圣卢西亚（Republic Of Iraq，北美洲，LC，LCA，662） <br />
    /// Cosmos i18n code: i18n_country_shengluxiya <br />
    /// Cosmos region code: 400129
    /// </summary>
    public static class SaintLucia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaintLucia() {
            _country = new CountryInfo {
                Country = Country.SaintLucia,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.SaintLucia,
                M49Code = "662",
                CRCode = 4_00_129,
                Alpha2Code = "LC",
                Alpha3Code = "LCA",
                Name = "Saint Lucia",
                ChineseName = "圣卢西亚",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣卢西亚（Republic Of Iraq，北美洲，LC，LCA，662） <br />
        /// Cosmos i18n code: i18n_country_shengluxiya <br />
        /// Cosmos region code: 400129
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengluxiya";

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