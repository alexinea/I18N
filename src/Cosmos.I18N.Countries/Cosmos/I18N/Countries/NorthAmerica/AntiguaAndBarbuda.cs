namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 安提瓜和巴布达（Antigua and Barbuda，北美洲，AG，ATG，028） <br />
    /// Cosmos i18n code: i18n_country_andaguababuda <br />
    /// Cosmos region code: 400103
    /// </summary>
    public static class AntiguaAndBarbuda {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static AntiguaAndBarbuda() {
            _country = new CountryInfo {
                Country = Country.AntiguaAndBarbuda,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.AntiguaAndBarbuda,
                M49Code = "028",
                CRCode = 4_00_103,
                Alpha2Code = "AG",
                Alpha3Code = "ATG",
                Name = "Antigua and Barbuda",
                ChineseName = "安提瓜和巴布达",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 安提瓜和巴布达（Antigua and Barbuda，北美洲，AG，ATG，028） <br />
        /// Cosmos i18n code: i18n_country_andaguababuda <br />
        /// Cosmos region code: 400103
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_andaguababuda";

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