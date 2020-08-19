namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 利比里亚（Republic Of Liberia，非洲，LR，LBR，430），利比里亚共和国 <br />
    /// Cosmos i18n code: i18n_country_libiliya <br />
    /// Cosmos region code: 300132
    /// </summary>
    public static partial  class Liberia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Liberia() {
            _country = new CountryInfo {
                Country = Country.Liberia,
                CountryCode = CountryCode.LR,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Liberia,
                M49Code = "430",
                CRCode = 3_00_132,
                Alpha2Code = "LR",
                Alpha3Code = "LBR",
                Name = "Republic Of Liberia",
                ShorterForm = "Liberia",
                ChineseName = "利比里亚共和国",
                ChineseShorterForm = "利比里亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 利比里亚（Republic Of Liberia，非洲，LR，LBR，430），利比里亚共和国 <br />
        /// Cosmos i18n code: i18n_country_libiliya <br />
        /// Cosmos region code: 300132
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_libiliya";

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