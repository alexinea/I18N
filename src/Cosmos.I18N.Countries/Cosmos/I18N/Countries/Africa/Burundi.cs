namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 布隆迪（The Republic of Burundi，非洲，BI，BDI，108），布隆迪共和国 <br />
    /// Cosmos i18n code: i18n_country_bulongdi
    /// </summary>
    public static class Burundi {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Burundi() {
            _country = new CountryInfo {
                Country = Country.Burundi,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Burundi,
                UNCode = "108",
                Alpha2Code = "BI",
                Alpha3Code = "BDI",
                Name = "The Republic of Burundi",
                ShorterForm = "Burundi",
                ChineseName = "布隆迪共和国",
                ChineseShorterForm = "布隆迪",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 布隆迪（The Republic of Burundi，非洲，BI，BDI，108），布隆迪共和国 <br />
        /// Cosmos i18n code: i18n_country_bulongdi
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bulongdi";
    }
}