namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 罗马尼亚（Romania，欧洲，RO，ROU，642） <br />
    /// Cosmos i18n code: i18n_country_luomaniya <br />
    /// Cosmos region code: 200134
    /// </summary>
    public static class Romania {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Romania() {
            _country = new CountryInfo {
                Country = Country.Romania,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Romania,
                M49Code = "642",
                CRCode = 2_00_134,
                Alpha2Code = "RO",
                Alpha3Code = "ROU",
                Name = "Romania",
                ChineseName = "罗马尼亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 罗马尼亚（Romania，欧洲，RO，ROU，642） <br />
        /// Cosmos i18n code: i18n_country_luomaniya <br />
        /// Cosmos region code: 200134
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_luomaniya";

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