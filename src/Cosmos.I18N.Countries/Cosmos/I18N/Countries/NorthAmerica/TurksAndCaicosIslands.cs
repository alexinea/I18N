namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 特克斯和凯科斯群岛（The Turks and Caicos Islands，北美洲，TC，TCA，796） <br />
    /// Cosmos i18n code: i18n_country_tekesikks <br />
    /// Cosmos region code: 400135
    /// </summary>
    public static class TurksAndCaicosIslands {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static TurksAndCaicosIslands() {
            _country = new CountryInfo {
                Country = Country.TurksAndCaicosIslands,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.TurksAndCaicosIslands,
                M49Code = "796",
                CRCode = 4_00_135,
                Alpha2Code = "TC",
                Alpha3Code = "TCA",
                Name = "The Turks and Caicos Islands",
                ChineseName = "特克斯和凯科斯群岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 特克斯和凯科斯群岛（The Turks and Caicos Islands，北美洲，TC，TCA，796） <br />
        /// Cosmos i18n code: i18n_country_tekesikks <br />
        /// Cosmos region code: 400135
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tekesikks";

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