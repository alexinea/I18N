namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 马里（The Republic of Mali，非洲，ML，MLI，466），马里共和国 <br />
    /// Cosmos i18n code: i18n_country_mali <br />
    /// Cosmos region code: 300122
    /// </summary>
    public static class Mali {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mali() {
            _country = new CountryInfo {
                Country = Country.Mali,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Mali,
                M49Code = "466",
                CRCode = 3_00_122,
                Alpha2Code = "ML",
                Alpha3Code = "MLI",
                Name = "The Republic of Mali",
                ShorterForm = "Mali",
                ChineseName = "马里共和国",
                ChineseShorterForm = "马里",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马里（The Republic of Mali，非洲，ML，MLI，466），马里共和国 <br />
        /// Cosmos i18n code: i18n_country_mali <br />
        /// Cosmos region code: 300122
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_mali";

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