namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 阿尔巴尼亚（Albania，欧洲，AL，ALB，008），阿尔巴尼亚共和国 <br />
    /// Cosmos i18n code: i18n_country_aerbaniya <br />
    /// Cosmos region code: 200102
    /// </summary>
    public static class Albania {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Albania() {
            _country = new CountryInfo {
                Country = Country.Albania,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Albania,
                M49Code = "008",
                CRCode = 2_00_102,
                Alpha2Code = "AL",
                Alpha3Code = "ALB",
                Name = "Republic of Albania",
                ShorterForm = "Albania",
                ChineseName = "阿尔巴尼亚共和国",
                ChineseShorterForm = "阿尔巴尼亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 阿尔巴尼亚（Albania，欧洲，AL，ALB，008），阿尔巴尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_aerbaniya <br />
        /// Cosmos region code: 200102
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aerbaniya";

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