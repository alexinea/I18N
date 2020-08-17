namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 马恩岛（Isle of Man，欧洲，IM，IMN，833），英属马恩岛 <br />
    /// Cosmos i18n code: i18n_country_maendao <br />
    /// Cosmos region code: 200127
    /// </summary>
    public static class Mann {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mann() {
            _country = new CountryInfo {
                Country = Country.Mann,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "833",
                CRCode = 2_00_127,
                Alpha2Code = "IM",
                Alpha3Code = "IMN",
                Name = "Isle of Man",
                ShorterForm = "Mann",
                ChineseName = "英属马恩岛",
                ChineseShorterForm = "马恩岛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马恩岛（Isle of Man，欧洲，IM，IMN，833），英属马恩岛 <br />
        /// Cosmos i18n code: i18n_country_maendao <br />
        /// Cosmos region code: 200127
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_maendao";

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