namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 厄立特里亚（The State of Eritrea，非洲，ER，ERI，232），厄立特里亚国 <br />
    /// Cosmos i18n code: i18n_country_aliteliya <br />
    /// Cosmos region code: 300116
    /// </summary>
    public static partial  class Eritrea {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Eritrea() {
            _country = new CountryInfo {
                Country = Country.Eritrea,
                CountryCode = CountryCode.ER,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Eritrea,
                M49Code = "232",
                Cep1CrCode = 3_00_116,
                Alpha2Code = "ER",
                Alpha3Code = "ERI",
                Name = "The State of Eritrea",
                ShorterForm = "Eritrea",
                ChineseName = "厄立特里亚国",
                ChineseShorterForm = "厄立特里亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 厄立特里亚（The State of Eritrea，非洲，ER，ERI，232），厄立特里亚国 <br />
        /// Cosmos i18n code: i18n_country_aliteliya <br />
        /// Cosmos region code: 300116
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aliteliya";

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