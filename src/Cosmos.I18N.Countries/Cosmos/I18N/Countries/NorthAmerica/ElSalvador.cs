namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 萨尔瓦多（The Democratic Republic of Sao Tome and Principe，北美洲，SV，SLV，222），萨尔瓦多共和国 <br />
    /// Cosmos i18n code: i18n_country_saerwaduo <br />
    /// Cosmos region code: 400115
    /// </summary>
    public static class ElSalvador {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static ElSalvador() {
            _country = new CountryInfo {
                Country = Country.ElSalvador,
                CountryCode = CountryCode.SV,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.ElSalvador,
                M49Code = "222",
                CRCode = 4_00_115,
                Alpha2Code = "SV",
                Alpha3Code = "SLV",
                Name = "The Democratic Republic of Sao Tome and Principe",
                ShorterForm = "El Salvador",
                ChineseName = "萨尔瓦多共和国",
                ChineseShorterForm = "萨尔瓦多",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 萨尔瓦多（The Democratic Republic of Sao Tome and Principe，北美洲，SV，SLV，222），萨尔瓦多共和国 <br />
        /// Cosmos i18n code: i18n_country_saerwaduo <br />
        /// Cosmos region code: 400115
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_saerwaduo";

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