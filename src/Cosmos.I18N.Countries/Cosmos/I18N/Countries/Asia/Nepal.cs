namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 尼泊尔（Federal Democratic Republic of Nepal，亚洲，NP，NPL，524），尼泊尔联邦民主共和国 <br />
    /// Cosmos i18n code: i18n_country_niboer <br />
    /// Cosmos region code: 100128
    /// </summary>
    public static class Nepal {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Nepal() {
            _country = new CountryInfo {
                Country = Country.Nepal,
                CountryCode = CountryCode.NP,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Nepal,
                M49Code = "524",
                CRCode = 1_00_128,
                Alpha2Code = "NP",
                Alpha3Code = "NPL",
                Name = "Federal Democratic Republic of Nepal",
                ShorterForm = "Nepal",
                ChineseName = "尼泊尔联邦民主共和国",
                ChineseShorterForm = "尼泊尔",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 尼泊尔（Federal Democratic Republic of Nepal，亚洲，NP，NPL，524），尼泊尔联邦民主共和国 <br />
        /// Cosmos i18n code: i18n_country_niboer <br />
        /// Cosmos region code: 100128
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_niboer";

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