namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 印度尼西亚（The Republic of Indonesia，亚洲，ID，IDN，360），印度尼西亚共和国 <br />
    /// Cosmos i18n code: i18n_country_yindunixiya <br />
    /// Cosmos region code: 100116
    /// </summary>
    public static class Indonesia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Indonesia() {
            _country = new CountryInfo {
                Country = Country.Indonesia,
                CountryCode = CountryCode.ID,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Indonesia,
                M49Code = "360",
                CRCode = 1_00_116,
                Alpha2Code = "ID",
                Alpha3Code = "IDN",
                Name = "The Republic of Indonesia",
                ShorterForm = "Indonesia",
                ChineseName = "印度尼西亚共和国",
                ChineseShorterForm = "印度尼西亚",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 印度尼西亚（The Republic of Indonesia，亚洲，ID，IDN，360），印度尼西亚共和国 <br />
        /// Cosmos i18n code: i18n_country_yindunixiya <br />
        /// Cosmos region code: 100116
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yindunixiya";

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