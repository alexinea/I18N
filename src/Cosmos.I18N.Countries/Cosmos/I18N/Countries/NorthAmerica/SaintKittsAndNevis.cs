namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 圣基茨和尼维斯（The Federation of Saint Kitts and Nevis，北美洲，KN，KNA，659），圣基茨和尼维斯联邦 <br />
    /// Cosmos i18n code: i18n_country_shengjiciniweisi <br />
    /// Cosmos region code: 400128
    /// </summary>
    public static class SaintKittsAndNevis {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaintKittsAndNevis() {
            _country = new CountryInfo {
                Country = Country.SaintKittsAndNevis,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.SaintKittsAndNevis,
                M49Code = "659",
                CRCode = 4_00_128,
                Alpha2Code = "KN",
                Alpha3Code = "KNA",
                Name = "The Federation of Saint Kitts and Nevis",
                ShorterForm = "Saint Kitts and Nevis",
                ChineseName = "圣基茨和尼维斯联邦",
                ChineseShorterForm = "圣基茨和尼维斯",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣基茨和尼维斯（The Federation of Saint Kitts and Nevis，北美洲，KN，KNA，659），圣基茨和尼维斯联邦 <br />
        /// Cosmos i18n code: i18n_country_shengjiciniweisi <br />
        /// Cosmos region code: 400128
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengjiciniweisi";

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