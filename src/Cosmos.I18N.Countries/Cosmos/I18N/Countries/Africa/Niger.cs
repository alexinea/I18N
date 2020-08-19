namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 尼日尔（The Republic of Niger，非洲，NE，NER，562），尼日尔共和国 <br />
    /// Cosmos i18n code: i18n_country_nirier <br />
    /// Cosmos region code: 300143
    /// </summary>
    public static  partial class Niger {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Niger() {
            _country = new CountryInfo {
                Country = Country.Niger,
                CountryCode = CountryCode.NE,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Niger,
                M49Code = "562",
                CRCode = 3_00_143,
                Alpha2Code = "NE",
                Alpha3Code = "NER",
                Name = "The Republic of Niger",
                ShorterForm = "Niger",
                ChineseName = "尼日尔共和国",
                ChineseShorterForm = "尼日尔",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 尼日尔（The Republic of Niger，非洲，NE，NER，562），尼日尔共和国 <br />
        /// Cosmos i18n code: i18n_country_nirier <br />
        /// Cosmos region code: 300143
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nirier";

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