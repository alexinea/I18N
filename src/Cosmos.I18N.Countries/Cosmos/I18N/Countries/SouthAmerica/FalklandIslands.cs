namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// 马尔维纳斯群岛（Falkland Islands，南美洲，FK，FLK，238） <br />
    /// Cosmos i18n code: i18n_country_fukelan <br />
    /// Cosmos region code: 500104
    /// </summary>
    public static class FalklandIslands {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static FalklandIslands() {
            _country = new CountryInfo {
                Country = Country.FalklandIslands,
                CountryCode = CountryCode.FK,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.FalklandIslands,
                M49Code = "238",
                CRCode = 5_00_104,
                Alpha2Code = "FK",
                Alpha3Code = "FLK",
                Name = "Falkland Islands",
                ShorterForm = "Ecuador",
                ChineseName = "马尔维纳斯群岛",
                ChineseAlias = "福克兰群岛",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马尔维纳斯群岛（Falkland Islands，南美洲，FK，FLK，238） <br />
        /// Cosmos i18n code: i18n_country_fukelan <br />
        /// Cosmos region code: 500104
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_fukelan";

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