namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 乍得（Republic of Chad，非洲，TD，TCD，148），乍得共和国 <br />
    /// Cosmos i18n code: i18n_country_zhade
    /// </summary>
    public static class Chad {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Chad() {
            _country = new CountryInfo {
                Country = Country.Chad,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Chad,
                UNCode = "148",
                Alpha2Code = "TD",
                Alpha3Code = "TCD",
                Name = "Republic of Chad",
                ShorterForm = "Chad",
                ChineseName = "乍得共和国",
                ChineseShorterForm = "乍得",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 乍得（Republic of Chad，非洲，TD，TCD，148），乍得共和国 <br />
        /// Cosmos i18n code: i18n_country_zhade
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_zhade";
    }
}