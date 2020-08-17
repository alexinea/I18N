namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 科科斯群岛（Cocos Islands，亚洲，CC，CCK，166） <br />
    /// Cosmos i18n code: i18n_country_kekesi <br />
    /// Cosmos region code: 100111
    /// </summary>
    public static class CocosIslands {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CocosIslands() {
            _country = new CountryInfo {
                Country = Country.CocosIslands,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.Australia,
                M49Code = "166",
                CRCode = 1_00_111,
                Alpha2Code = "CC",
                Alpha3Code = "CCK",
                Name = "Cocos Islands",
                Alias = "Keeling Islands",
                ChineseName = "科科斯群岛",
                ChineseAlias = "基林群岛",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 科科斯群岛（Cocos Islands，亚洲，CC，CCK，166） <br />
        /// Cosmos i18n code: i18n_country_kekesi <br />
        /// Cosmos region code: 100111
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kekesi";

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