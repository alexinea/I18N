namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 摩洛哥（The Kingdom of Morocco，非洲，MA，MAR，504），摩洛哥王国 <br />
    /// Cosmos i18n code: i18n_country_moluoge <br />
    /// Cosmos region code: 300139
    /// </summary>
    public static partial  class Morocco {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Morocco() {
            _country = new CountryInfo {
                CountryCode = CountryCode.MA,
                Country = Country.Morocco,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Morocco,
                M49Code = "504",
                CRCode = 3_00_139,
                Alpha2Code = "MA",
                Alpha3Code = "MAR",
                Name = "The Kingdom of Morocco",
                ShorterForm = "Morocco",
                ChineseName = "摩洛哥王国",
                ChineseShorterForm = "摩洛哥",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 摩洛哥（The Kingdom of Morocco，非洲，MA，MAR，504），摩洛哥王国 <br />
        /// Cosmos i18n code: i18n_country_moluoge <br />
        /// Cosmos region code: 300139
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_moluoge";

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