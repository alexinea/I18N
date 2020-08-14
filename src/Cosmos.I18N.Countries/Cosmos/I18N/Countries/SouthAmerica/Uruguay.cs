namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// 乌拉圭（The Oriental Republic of Uruguay，南美洲，UY，URY，858），乌拉圭东岸共和国 <br />
    /// Cosmos i18n code: i18n_country_wulagui
    /// </summary>
    public static class Uruguay {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Uruguay() {
            _country = new CountryInfo {
                Country = Country.Uruguay,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Uruguay,
                UNCode = "858",
                Alpha2Code = "UY",
                Alpha3Code = "URY",
                Name = "The Oriental Republic of Uruguay",
                ShorterForm = "Uruguay",
                ChineseName = "乌拉圭东岸共和国",
                ChineseShorterForm = "乌拉圭",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 乌拉圭（The Oriental Republic of Uruguay，南美洲，UY，URY，858），乌拉圭东岸共和国 <br />
        /// Cosmos i18n code: i18n_country_wulagui
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_wulagui";
    }
}