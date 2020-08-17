namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 所罗门群岛（Solomon Islands，大洋洲，SB，SLB，090） <br />
    /// Cosmos i18n code: i18n_country_suoluomen <br />
    /// Cosmos region code: 600115
    /// </summary>
    public static class SolomonIslands {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SolomonIslands() {
            _country = new CountryInfo {
                Country = Country.SolomonIslands,
                CountryCode = CountryCode.SB,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.SolomonIslands,
                M49Code = "090",
                CRCode = 6_00_115,
                Alpha2Code = "SB",
                Alpha3Code = "SLB",
                Name = "Solomon Islands",
                ChineseName = "所罗门群岛",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 所罗门群岛（Solomon Islands，大洋洲，SB，SLB，090） <br />
        /// Cosmos i18n code: i18n_country_suoluomen <br />
        /// Cosmos region code: 600115
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_suoluomen";

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