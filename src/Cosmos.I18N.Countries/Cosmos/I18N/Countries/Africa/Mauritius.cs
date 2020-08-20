namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 毛里求斯（The Republic of Mauritius，非洲，MU，MUS，480），毛里求斯共和国 <br />
    /// Cosmos i18n code: i18n_country_maoliqiusi <br />
    /// Cosmos region code: 300136
    /// </summary>
    public static partial  class Mauritius {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mauritius() {
            _country = new CountryInfo {
                Country = Country.Mauritius,
                CountryCode = CountryCode.MU,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Mauritius,
                M49Code = "480",
                Cep1CrCode = 3_00_136,
                Alpha2Code = "MU",
                Alpha3Code = "MUS",
                Name = "The Republic of Mauritius",
                ShorterForm = "Mauritius",
                ChineseName = "毛里求斯共和国",
                ChineseShorterForm = "毛里求斯",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 毛里求斯（The Republic of Mauritius，非洲，MU，MUS，480），毛里求斯共和国 <br />
        /// Cosmos i18n code: i18n_country_maoliqiusi <br />
        /// Cosmos region code: 300136
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_maoliqiusi";

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