namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 拉脱维亚（The Republic of Latvia，欧洲，LV，LVA，428），拉脱维亚共和国 <br />
    /// Cosmos i18n code: i18n_country_latuoweiya <br />
    /// Cosmos region code: 200121
    /// </summary>
    public static class Latvia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Latvia() {
            _country = new CountryInfo {
                Country = Country.Latvia,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Latvia,
                M49Code = "428",
                CRCode = 2_00_121,
                Alpha2Code = "LV",
                Alpha3Code = "LVA",
                Name = "The Republic of Latvia",
                ShorterForm = "Latvia",
                ChineseName = "拉脱维亚共和国",
                ChineseShorterForm = "拉脱维亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 拉脱维亚（The Republic of Latvia，欧洲，LV，LVA，428），拉脱维亚共和国 <br />
        /// Cosmos i18n code: i18n_country_latuoweiya <br />
        /// Cosmos region code: 200121
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_latuoweiya";

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