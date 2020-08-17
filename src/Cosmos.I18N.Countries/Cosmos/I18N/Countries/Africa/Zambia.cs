namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 赞比亚（The Republic of Zambia，非洲，ZM，ZMB，894），赞比亚共和国 <br />
    /// Cosmos i18n code: i18n_country_zanbiya <br />
    /// Cosmos region code: 300117
    /// </summary>
    public static class Zambia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Zambia() {
            _country = new CountryInfo {
                Country = Country.Zambia,
                CountryCode = CountryCode.ZM,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Zambia,
                M49Code = "894",
                CRCode = 3_00_117,
                Alpha2Code = "ZM",
                Alpha3Code = "ZMB",
                Name = "The Republic of Zambia",
                ShorterForm = "Zambia",
                ChineseName = "赞比亚共和国",
                ChineseShorterForm = "赞比亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 赞比亚（The Republic of Zambia，非洲，ZM，ZMB，894），赞比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_zanbiya <br />
        /// Cosmos region code: 300117
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_zanbiya";

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