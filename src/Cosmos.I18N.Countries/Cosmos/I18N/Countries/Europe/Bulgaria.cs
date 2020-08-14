namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 保加利亚（The Republic of Bulgaria，欧洲，BG，BRN，096），保加利亚共和国 <br />
    /// Cosmos i18n code: i18n_country_baojialiya
    /// </summary>
    public static class Bulgaria {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bulgaria() {
            _country = new CountryInfo {
                Country = Country.Bulgaria,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Bulgaria,
                UNCode = "096",
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
        /// Cosmos i18n code: i18n_country_baojialiya
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_baojialiya";
    }
}
