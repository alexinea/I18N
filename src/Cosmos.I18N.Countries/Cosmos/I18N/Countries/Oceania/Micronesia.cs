namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 密克罗尼西亚（The Federated States of Micronesia，大洋洲，FM，FSM，583） ，密克罗尼西亚联邦<br />
    /// Cosmos i18n code: i18n_country_mikeluonixiya <br />
    /// Cosmos region code: 600107
    /// </summary>
    public static class Micronesia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Micronesia() {
            _country = new CountryInfo {
                Country = Country.Micronesia,
                CountryCode = CountryCode.FM,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Micronesia,
                M49Code = "583",
                CRCode = 6_00_107,
                Alpha2Code = "FM",
                Alpha3Code = "FSM",
                Name = "The Federated States of Micronesia",
                ShorterForm = "Micronesia",
                ChineseName = "密克罗尼西亚联邦",
                ChineseShorterForm = "密联邦",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 密克罗尼西亚（The Federated States of Micronesia，大洋洲，FM，FSM，583） ，密克罗尼西亚联邦<br />
        /// Cosmos i18n code: i18n_country_mikeluonixiya <br />
        /// Cosmos region code: 600107
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_mikeluonixiya";

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