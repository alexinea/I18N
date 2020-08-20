namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 加蓬（The Gabonese Republic，非洲，GA，GAB，266），加蓬共和国 <br />
    /// Cosmos i18n code: i18n_country_jiapeng <br />
    /// Cosmos region code: 300126
    /// </summary>
    public static partial  class Gabon {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Gabon() {
            _country = new CountryInfo {
                Country = Country.Gabon,
                CountryCode = CountryCode.GA,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Gabon,
                M49Code = "266",
                Cep1CrCode = 3_00_126,
                Alpha2Code = "GA",
                Alpha3Code = "GAB",
                Name = "The Gabonese Republic",
                ShorterForm = "Gabon",
                ChineseName = "加蓬共和国",
                ChineseShorterForm = "加蓬",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 加蓬（The Gabonese Republic，非洲，GA，GAB，266），加蓬共和国 <br />
        /// Cosmos i18n code: i18n_country_jiapeng <br />
        /// Cosmos region code: 300126
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jiapeng";

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