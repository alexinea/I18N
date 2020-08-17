// ReSharper disable once CheckNamespace

namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 南斯拉夫（Yugoslavia，欧洲，YU，YUG，38），南斯拉夫联盟共和国 <br />
    /// Cosmos i18n code: i18n_country_nlm_1992 <br />
    /// Cosmos region code: 220106
    /// </summary>
    public static class Yugoslavia1992 {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Yugoslavia1992() {
            _country = new CountryInfo {
                Country = Country.Yugoslavia1992,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Yugoslavia1992,
                M49Code = "038",
                CRCode = 2_20_106,
                Alpha2Code = "YU",
                Alpha3Code = "YUG",
                Name = "The Federal Republic of Yugoslavia",
                ShorterForm = "Yugoslavia",
                ChineseName = "南斯拉夫联盟共和国",
                ChineseShorterForm = "南斯拉夫",
                ChineseAlias = "南联盟",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                HistoricalCountry = true,
            };
        }

        /// <summary>
        /// 南斯拉夫（Yugoslavia，欧洲，YU，YUG，38），南斯拉夫联盟共和国 <br />
        /// Cosmos i18n code: i18n_country_nlm_1992 <br />
        /// Cosmos region code: 220106
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nlm_1992";

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