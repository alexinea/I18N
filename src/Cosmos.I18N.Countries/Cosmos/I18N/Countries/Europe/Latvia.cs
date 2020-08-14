namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 拉脱维亚（The Republic of Latvia，欧洲，LV，LVA，428），拉脱维亚共和国 <br />
    /// Cosmos i18n code: i18n_country_latuoweiya
    /// </summary>
    public static class Latvia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Latvia() {
            _country = new CountryInfo {
                Country = Country.Latvia,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Latvia,
                UNCode = "428",
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
        /// Cosmos i18n code: i18n_country_latuoweiya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_latuoweiya";
    }
}