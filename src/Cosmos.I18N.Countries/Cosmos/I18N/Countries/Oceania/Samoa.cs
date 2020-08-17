namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 萨摩亚（The Independent State of Samoa，大洋洲，WS，WSM，882），萨摩亚独立国 <br />
    /// Cosmos i18n code: i18n_country_samoya <br />
    /// Cosmos region code: 600118
    /// </summary>
    public static class Samoa {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Samoa() {
            _country = new CountryInfo {
                Country = Country.Samoa,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Samoa,
                M49Code = "882",
                CRCode = 6_00_118,
                Alpha2Code = "WS",
                Alpha3Code = "WSM",
                Name = "The Independent State of Samoa",
                ShorterForm = "Samoa",
                ChineseName = "萨摩亚独立国",
                ChineseShorterForm = "萨摩亚",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 萨摩亚（The Independent State of Samoa，大洋洲，WS，WSM，882），萨摩亚独立国 <br />
        /// Cosmos i18n code: i18n_country_samoya <br />
        /// Cosmos region code: 600118
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_samoya";

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