namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 斯瓦尔巴群岛（The Svalbard archipelago，欧洲，SJ，SJM，744） <br />
    /// Cosmos i18n code: i18n_country_siwaerba <br />
    /// Cosmos region code: 200139
    /// </summary>
    public static class SvalbardAndJanMayen {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SvalbardAndJanMayen() {
            _country = new CountryInfo {
                Country = Country.SvalbardAndJanMayen,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.Norway,
                M49Code = "744",
                CRCode = 2_00_139,
                Alpha2Code = "SJ",
                Alpha3Code = "SJM",
                Name = "The Svalbard archipelago",
                ShorterForm = "Svalbard and Jan Mayen",
                ChineseName = "斯瓦尔巴群岛",
                ChineseAlias = "斯匹次卑尔根",
                ChineseAlias2 = "斯匹次卑尔根",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 斯瓦尔巴群岛（The Svalbard archipelago，欧洲，SJ，SJM，744） <br />
        /// Cosmos i18n code: i18n_country_siwaerba <br />
        /// Cosmos region code: 200139
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_siwaerba";

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