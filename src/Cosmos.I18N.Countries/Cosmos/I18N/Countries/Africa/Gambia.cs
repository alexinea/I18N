namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 冈比亚（Republic of The Gambia，非洲，GM，GMB，270），冈比亚共和国 <br />
    /// Cosmos i18n code: i18n_country_gangbiya <br />
    /// Cosmos region code: 300128
    /// </summary>
    public static partial  class Gambia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Gambia() {
            _country = new CountryInfo {
                Country = Country.Gambia,
                CountryCode = CountryCode.GM,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Gambia,
                M49Code = "270",
                Cep1CrCode = 3_00_128,
                Alpha2Code = "GM",
                Alpha3Code = "GMB",
                Name = "Republic of The Gambia",
                ShorterForm = "Gambia",
                ChineseName = "冈比亚共和国",
                ChineseShorterForm = "冈比亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 冈比亚（Republic of The Gambia，非洲，GM，GMB，270），冈比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_gangbiya <br />
        /// Cosmos region code: 300128
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gangbiya";

        /// <summary>
        /// Get Cosmos Region Code (CEP-1/CRCode)
        /// </summary>
        public static long CosmosRegionCode => _country.Cep1CrCode;

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