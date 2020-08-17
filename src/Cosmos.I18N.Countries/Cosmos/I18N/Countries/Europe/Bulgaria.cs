namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 保加利亚（The Republic of Bulgaria，欧洲，BG，BRN，096），保加利亚共和国 <br />
    /// Cosmos i18n code: i18n_country_baojialiya <br />
    /// Cosmos region code: 200108
    /// </summary>
    public static class Bulgaria {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bulgaria() {
            _country = new CountryInfo {
                Country = Country.Bulgaria,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Bulgaria,
                M49Code = "096",
                CRCode = 2_00_108,
                Alpha2Code = "BG",
                Alpha3Code = "BGR",
                Name = "The Republic of Bulgaria",
                ShorterForm = "Bulgaria",
                ChineseName = "保加利亚共和国",
                ChineseShorterForm = "保加利亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 保加利亚（The Republic of Bulgaria，欧洲，BG，BRN，096），保加利亚共和国 <br />
        /// Cosmos i18n code: i18n_country_baojialiya <br />
        /// Cosmos region code: 200108
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_baojialiya";

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
