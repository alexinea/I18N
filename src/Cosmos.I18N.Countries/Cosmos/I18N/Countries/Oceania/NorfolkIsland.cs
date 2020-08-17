namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 诺福克岛（Norfolk Island，大洋洲，NF，NFK，574） <br />
    /// Cosmos i18n code: i18n_country_nuofuke <br />
    /// Cosmos region code: 600111
    /// </summary>
    public static class NorfolkIsland {
        private static readonly CountryInfo _country;

        static NorfolkIsland() {
            _country = new CountryInfo {
                Country = Country.NorfolkIsland,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.Australia,
                M49Code = "574",
                CRCode = 6_00_111,
                Alpha2Code = "NF",
                Alpha3Code = "NFK",
                Name = "Norfolk Island",
                ChineseName = "诺福克岛",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 诺福克岛（Norfolk Island，大洋洲，NF，NFK，574） <br />
        /// Cosmos i18n code: i18n_country_nuofuke <br />
        /// Cosmos region code: 600111
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nuofuke";

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