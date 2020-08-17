namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 文莱 （Negara Brunei Darussalam，亚洲，BN，BRN，096），文莱达鲁萨兰国 <br />
    /// Cosmos i18n code: i18n_country_wenlai <br />
    /// Cosmos region code: 100108
    /// </summary>
    public static class Brunei {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Brunei() {
            _country = new CountryInfo {
                Country = Country.Brunei,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Brunei,
                M49Code = "096",
                CRCode = 1_00_108,
                Alpha2Code = "BN",
                Alpha3Code = "BRN",
                Name = "Negara Brunei Darussalam",
                ShorterForm = "Brunei",
                ChineseName = "文莱达鲁萨兰国",
                ChineseShorterForm = "文莱",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 文莱 （Negara Brunei Darussalam，亚洲，BN，BRN，096），文莱达鲁萨兰国 <br />
        /// Cosmos i18n code: i18n_country_wenlai <br />
        /// Cosmos region code: 100108
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_wenlai";

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