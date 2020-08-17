namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 毛里塔尼亚（The Islamic Republic of Mauritania，非洲，MR，MR，478），毛里塔尼亚伊斯兰共和国 <br />
    /// Cosmos i18n code: i18n_country_maolitaniya <br />
    /// Cosmos region code: 300135
    /// </summary>
    public static class Mauritania {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mauritania() {
            _country = new CountryInfo {
                Country = Country.Mauritania,
                CountryCode = CountryCode.MR,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Mauritania,
                M49Code = "478",
                CRCode = 3_00_135,
                Alpha2Code = "MR",
                Alpha3Code = "MRT",
                Name = "The Islamic Republic of Mauritania",
                ShorterForm = "Mauritania",
                ChineseName = "毛里塔尼亚伊斯兰共和国",
                ChineseShorterForm = "毛里塔尼亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 毛里塔尼亚（The Islamic Republic of Mauritania，非洲，MR，MR，478），毛里塔尼亚伊斯兰共和国 <br />
        /// Cosmos i18n code: i18n_country_maolitaniya <br />
        /// Cosmos region code: 300135
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_maolitaniya";

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