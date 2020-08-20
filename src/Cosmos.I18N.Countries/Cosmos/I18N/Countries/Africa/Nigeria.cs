namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 尼日利亚（Federal Republic of Nigeria，非洲，NG，NGA，566，尼日利亚联邦共和国 <br />
    /// Cosmos i18n code: i18n_country_niriliya <br />
    /// Cosmos region code: 300142
    /// </summary>
    public static partial  class Nigeria {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Nigeria() {
            _country = new CountryInfo {
                Country = Country.Nigeria,
                CountryCode = CountryCode.NG,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Nigeria,
                M49Code = "566",
                Cep1CrCode = 3_00_142,
                Alpha2Code = "NG",
                Alpha3Code = "NGA",
                Name = "Federal Republic of Nigeria",
                ShorterForm = "Nigeria",
                ChineseName = "尼日利亚联邦共和国",
                ChineseShorterForm = "尼日利亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 尼日利亚（Federal Republic of Nigeria，非洲，NG，NGA，566，尼日利亚联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_niriliya <br />
        /// Cosmos region code: 300142
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_niriliya";

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