namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 佛得角（Republic of Cape Verde，非洲，CV，CPV，132），佛得角共和国 <br />
    /// Cosmos i18n code: i18n_country_fodejiao <br />
    /// Cosmos region code: 300106
    /// </summary>
    public static class CapeVerde {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CapeVerde() {
            _country = new CountryInfo {
                Country = Country.CapeVerde,
                CountryCode = CountryCode.CV,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.CapeVerde,
                M49Code = "132",
                CRCode = 3_00_106,
                Alpha2Code = "CV",
                Alpha3Code = "CPV",
                Name = "Republic of Cape Verde",
                ShorterForm = "Cape Verde",
                ChineseName = "佛得角共和国",
                ChineseShorterForm = "佛得角",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 佛得角（Republic of Cape Verde，非洲，CV，CPV，132），佛得角共和国 <br />
        /// Cosmos i18n code: i18n_country_fodejiao <br />
        /// Cosmos region code: 300106
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_fodejiao";

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