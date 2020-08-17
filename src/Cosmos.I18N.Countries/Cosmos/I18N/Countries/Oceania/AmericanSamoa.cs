namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 美属萨摩亚群岛（American Samoa，大洋洲，AS，ASM，016），阿根廷共和国 <br />
    /// 美属萨摩亚领地<br />
    /// Cosmos i18n code: i18n_country_ussamoya <br />
    /// Cosmos region code: 600101
    /// </summary>
    public static class AmericanSamoa {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static AmericanSamoa() {
            _country = new CountryInfo {
                Country = Country.AmericanSamoa,
                CountryCode = CountryCode.AS,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedStates,
                M49Code = "016",
                CRCode = 6_00_101,
                Alpha2Code = "AS",
                Alpha3Code = "ASM",
                Name = "American Samoa",
                Alias = "Eastern Samoa",
                ChineseName = "美属萨摩亚群岛",
                ChineseAlias = "美属萨摩亚领地",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 美属萨摩亚群岛（American Samoa，大洋洲，AS，ASM，016），阿根廷共和国 <br />
        /// 美属萨摩亚领地<br />
        /// Cosmos i18n code: i18n_country_ussamoya <br />
        /// Cosmos region code: 600101
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_ussamoya";

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