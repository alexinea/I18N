namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 加纳（The Republic of Ghana，非洲，GH，GHA，288），加纳共和国 <br />
    /// Cosmos i18n code: i18n_country_jiana <br />
    /// Cosmos region code: 300127
    /// </summary>
    public static class Ghana {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Ghana() {
            _country = new CountryInfo {
                Country = Country.Ghana,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Ghana,
                M49Code = "288",
                CRCode = 3_00_127,
                Alpha2Code = "GH",
                Alpha3Code = "GHA",
                Name = "The Republic of Ghana",
                ShorterForm = "Ghana",
                ChineseName = "加纳共和国",
                ChineseShorterForm = "加纳",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 加纳（The Republic of Ghana，非洲，GH，GHA，288），加纳共和国 <br />
        /// Cosmos i18n code: i18n_country_jiana <br />
        /// Cosmos region code: 300127
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jiana";

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