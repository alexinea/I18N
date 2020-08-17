namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 赫德岛和麦克唐纳群岛（Heard Island and McDonald Islands，亚洲，HM，HMD，334） <br />
    /// Cosmos i18n code: i18n_country_hedemaiketang <br />
    /// Cosmos region code: 100116
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class HIMI {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        // ReSharper disable once IdentifierTypo
        static HIMI() {
            _country = new CountryInfo {
                Country = Country.HIMI,
                CountryCode = CountryCode.HM,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.Australia,
                M49Code = "334",
                CRCode = 1_00_116,
                Alpha2Code = "HM",
                Alpha3Code = "HMD",
                Name = "Heard Island and McDonald Islands",
                ShorterForm = "HIMI",
                ChineseName = "赫德岛和麦克唐纳群岛",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 赫德岛和麦克唐纳群岛（Heard Island and McDonald Islands，亚洲，HM，HMD，334） <br />
        /// Cosmos i18n code: i18n_country_hedemaiketang <br />
        /// Cosmos region code: 100116
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_hedemaiketang";

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