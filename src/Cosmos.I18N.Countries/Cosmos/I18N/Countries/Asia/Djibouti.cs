namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 吉布提（The Republic of Djibouti，亚洲，DJ，DJI，262），吉布提共和国 <br />
    /// Cosmos i18n code: i18n_country_jibuti <br />
    /// Cosmos region code: 100113
    /// </summary>
    public static class Djibouti {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Djibouti() {
            _country = new CountryInfo {
                Country = Country.Djibouti,
                CountryCode = CountryCode.DJ,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Djibouti,
                M49Code = "262",
                CRCode = 1_00_113,
                Alpha2Code = "DJ",
                Alpha3Code = "DJI",
                Name = "The Republic of Djibouti",
                ShorterForm = "Djibouti",
                ChineseName = "吉布提共和国",
                ChineseShorterForm = "吉布提",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 吉布提（The Republic of Djibouti，亚洲，DJ，DJI，262），吉布提共和国 <br />
        /// Cosmos i18n code: i18n_country_jibuti <br />
        /// Cosmos region code: 100113
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jibuti";

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