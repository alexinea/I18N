namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 马绍尔群岛（The Republic of Marshall Islands，大洋洲，MH，MHL，584），马绍尔群岛共和国 <br />
    /// Cosmos i18n code: i18n_country_mashaoer <br />
    /// Cosmos region code: 600106
    /// </summary>
    public static class MarshallIslands {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static MarshallIslands() {
            _country = new CountryInfo {
                Country = Country.MarshallIslands,
                CountryCode = CountryCode.MH,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.MarshallIslands,
                M49Code = "584",
                CRCode = 6_00_106,
                Alpha2Code = "MH",
                Alpha3Code = "MHL",
                Name = "The Republic of Marshall Islands",
                ShorterForm = "Marshall Islands",
                ChineseName = "马绍尔群岛共和国",
                ChineseShorterForm = "马绍尔群岛",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马绍尔群岛（The Republic of Marshall Islands，大洋洲，MH，MHL，584），马绍尔群岛共和国 <br />
        /// Cosmos i18n code: i18n_country_mashaoer <br />
        /// Cosmos region code: 600106
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_mashaoer";

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