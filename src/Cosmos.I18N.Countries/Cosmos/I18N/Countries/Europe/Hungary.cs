namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 匈牙利（Hungary，欧洲，HU，HUN，348） <br />
    /// Cosmos i18n code: i18n_country_xiongyali <br />
    /// Cosmos region code: 200013
    /// </summary>
    public static class Hungary {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Hungary() {
            _country = new CountryInfo {
                Country = Country.Hungary,
                CountryCode = CountryCode.HU,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Hungary,
                M49Code = "348",
                CRCode = 2_00_013,
                Alpha2Code = "HU",
                Alpha3Code = "HUN",
                Name = "Hungary",
                ChineseName = "匈牙利",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 匈牙利（Hungary，欧洲，HU，HUN，348） <br />
        /// Cosmos i18n code: i18n_country_xiongyali <br />
        /// Cosmos region code: 200013
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xiongyali";

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