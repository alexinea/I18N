namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 波利尼西亚（French Polynesia，大洋洲，PF，PYF，258），法属波利尼西亚 <br />
    /// Cosmos i18n code: i18n_country_bolinixiya <br />
    /// Cosmos region code: 600119
    /// </summary>
    public static class Polynesia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Polynesia() {
            _country = new CountryInfo {
                Country = Country.Polynesia,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.France,
                M49Code = "258",
                CRCode=6_00_119,
                Alpha2Code = "PF",
                Alpha3Code = "PYF",
                Name = "French Polynesia",
                ShorterForm = "Polynesia",
                ChineseName = "法属波利尼西亚",
                ChineseShorterForm = "波利尼西亚",
                ChineseAlias = "塔希提",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 波利尼西亚（French Polynesia，大洋洲，PF，PYF，258），法属波利尼西亚 <br />
        /// Cosmos i18n code: i18n_country_bolinixiya <br />
        /// Cosmos region code: 600119
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bolinixiya";

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