namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 塞拉利昂（The Republic of Sierra Leone，非洲，SL，SLE，694），塞拉利昂共和国 <br />
    /// Cosmos i18n code: i18n_country_sailaliang <br />
    /// Cosmos region code: 300153
    /// </summary>
    public static partial class SierraLeone {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SierraLeone() {
            _country = new CountryInfo {
                Country = Country.SierraLeone,
                CountryCode = CountryCode.SL,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.SierraLeone,
                M49Code = "694",
                CRCode = 3_00_153,
                Alpha2Code = "SL",
                Alpha3Code = "SLE",
                Name = "The Republic of Sierra Leone",
                ShorterForm = "Sierra Leone",
                ChineseName = "塞拉利昂共和国",
                ChineseShorterForm = "塞拉利昂",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 塞拉利昂（The Republic of Sierra Leone，非洲，SL，SLE，694），塞拉利昂共和国 <br />
        /// Cosmos i18n code: i18n_country_sailaliang <br />
        /// Cosmos region code: 300153
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_sailaliang";

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