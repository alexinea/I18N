namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 马提尼克岛（Martinique，北美洲，MQ，MTQ，474），法国的海外大区 <br />
    /// Cosmos i18n code: i18n_country_matinike <br />
    /// Cosmos region code: 400122
    /// </summary>
    public static class Martinique {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Martinique() {
            _country = new CountryInfo {
                Country = Country.Martinique,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.France,
                M49Code = "474",
                CRCode = 4_00_122,
                Alpha2Code = "MQ",
                Alpha3Code = "MTQ",
                Name = "Martinique",
                ChineseName = "马提尼克岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马提尼克岛（Martinique，北美洲，MQ，MTQ，474），法国的海外大区 <br />
        /// Cosmos i18n code: i18n_country_matinike <br />
        /// Cosmos region code: 400122
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_matinike";

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