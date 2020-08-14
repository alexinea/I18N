namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 格林纳达（Grenada，北美洲，GD，GRD，308） <br />
    /// Cosmos i18n code: i18n_country_gelinnada
    /// </summary>
    public static class Grenada {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Grenada() {
            _country = new CountryInfo {
                Country = Country.Grenada,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Grenada,
                UNCode = "308",
                Alpha2Code = "GD",
                Alpha3Code = "GRD",
                Name = "Grenada",
                ChineseName = "格林纳达",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 格林纳达（Grenada，北美洲，GD，GRD，308） <br />
        /// Cosmos i18n code: i18n_country_gelinnada
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gelinnada";
    }
}