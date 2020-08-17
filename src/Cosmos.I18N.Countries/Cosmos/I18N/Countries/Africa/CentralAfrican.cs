namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 中非（Central African Republic，非洲，CF，COD，180），中非共和国 <br />
    /// Cosmos i18n code: i18n_country_zhongfei <br />
    /// Cosmos region code: 300109
    /// </summary>
    public static class CentralAfrican {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CentralAfrican() {
            _country = new CountryInfo {
                Country = Country.CentralAfrican,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.CentralAfrican,
                M49Code = "180",
                CRCode = 3_00_109,
                Alpha2Code = "CF",
                Alpha3Code = "COD",
                Name = "Central African Republic",
                ChineseName = "中非共和国",
                ChineseShorterForm = "中非",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 中非（Central African Republic，非洲，CF，COD，180），中非共和国 <br />
        /// Cosmos i18n code: i18n_country_zhongfei <br />
        /// Cosmos region code: 300109
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_zhongfei";

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