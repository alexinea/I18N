namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 莱索托（Kingdom of Lesotho，非洲，LS，LSO，426），莱索托王国 <br />
    /// Cosmos i18n code: i18n_country_laisuotuo <br />
    /// Cosmos region code: 300131
    /// </summary>
    public static class Lesotho {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Lesotho() {
            _country = new CountryInfo {
                Country = Country.Lesotho,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Lesotho,
                M49Code = "426",
                CRCode = 3_00_131,
                Alpha2Code = "LS",
                Alpha3Code = "LSO",
                Name = "Kingdom of Lesotho",
                ShorterForm = "Lesotho",
                ChineseName = "莱索托王国",
                ChineseShorterForm = "莱索托",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 莱索托（Kingdom of Lesotho，非洲，LS，LSO，426），莱索托王国 <br />
        /// Cosmos i18n code: i18n_country_laisuotuo <br />
        /// Cosmos region code: 300131
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_laisuotuo";

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