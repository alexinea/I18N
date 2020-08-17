namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 纽埃（Niue，大洋洲，NU，NIU，570） <br />
    /// Cosmos i18n code: i18n_country_niuai <br />
    /// Cosmos region code: 600110
    /// </summary>
    public static class Niue {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Niue() {
            _country = new CountryInfo {
                Country = Country.Niue,
                CountryCode = CountryCode.NU,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Niue,
                M49Code = "570",
                CRCode = 6_00_110,
                Alpha2Code = "NU",
                Alpha3Code = "NIU",
                Name = "Niue",
                ChineseName = "纽埃",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 纽埃（Niue，大洋洲，NU，NIU，570） <br />
        /// Cosmos i18n code: i18n_country_niuai <br />
        /// Cosmos region code: 600110
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_niuai";

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