namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 苏丹（Republic of the Sudan，非洲，SD，SDN，736），苏丹共和国 <br />
    /// Cosmos i18n code: i18n_country_sudan <br />
    /// Cosmos region code: 300146
    /// </summary>
    public static class Sudan {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Sudan() {
            _country = new CountryInfo {
                Country = Country.Sudan,
                CountryCode = CountryCode.SD,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Sudan,
                M49Code = "736",
                CRCode = 3_00_146,
                Alpha2Code = "SD",
                Alpha3Code = "SDN",
                Name = "Republic of the Sudan",
                ShorterForm = "Sudan",
                ChineseName = "苏丹共和国",
                ChineseShorterForm = "苏丹",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 苏丹（Republic of the Sudan，非洲，SD，SDN，736），苏丹共和国 <br />
        /// Cosmos i18n code: i18n_country_sudan <br />
        /// Cosmos region code: 300146
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_sudan";

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