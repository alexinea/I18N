namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 维尔京群岛（The British Virgin Islands，北美洲，VG，VGB，092），英属维尔京群岛 <br />
    /// Cosmos i18n code: i18n_country_yingshuweierjing <br />
    /// Cosmos region code: 400137
    /// </summary>
    public static class VirginIslandsBritish {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static VirginIslandsBritish() {
            _country = new CountryInfo {
                Country = Country.VirginIslandsBritish,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "092",
                CRCode = 4_00_137,
                Alpha2Code = "VG",
                Alpha3Code = "VGB",
                Name = "The British Virgin Islands",
                ShorterForm = "Virgin Islands (British)",
                ChineseName = "英属维尔京群岛",
                ChineseShorterForm = "维尔京群岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 维尔京群岛（The British Virgin Islands，北美洲，VG，VGB，092），英属维尔京群岛 <br />
        /// Cosmos i18n code: i18n_country_yingshuweierjing <br />
        /// Cosmos region code: 400137
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yingshuweierjing";

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