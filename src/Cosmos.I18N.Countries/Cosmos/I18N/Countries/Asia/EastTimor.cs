namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 东帝汶（Democratic Republic of Timor-Leste，亚洲，TL，TLS，626），东帝汶民主共和国 <br />
    /// Cosmos i18n code: i18n_country_dongdiwen <br />
    /// Cosmos region code: 100114
    /// </summary>
    public static class EastTimor {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static EastTimor() {
            _country = new CountryInfo {
                Country = Country.EastTimor,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.EastTimor,
                M49Code = "626",
                CRCode = 1_00_114,
                Alpha2Code = "TL",
                Alpha3Code = "TLS",
                Name = "Democratic Republic of Timor-Leste",
                ShorterForm = "East Timor",
                ChineseName = "东帝汶民主共和国",
                ChineseShorterForm = "东帝汶",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 东帝汶（Democratic Republic of Timor-Leste，亚洲，TL，TLS，626），东帝汶民主共和国 <br />
        /// Cosmos i18n code: i18n_country_dongdiwen <br />
        /// Cosmos region code: 100114
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_dongdiwen";

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