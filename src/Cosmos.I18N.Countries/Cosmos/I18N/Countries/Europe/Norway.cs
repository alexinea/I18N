namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 挪威（The Kingdom of Norway，欧洲，NO，NOR，578），挪威王国 <br />
    /// Cosmos i18n code: i18n_country_nuowei<br />
    /// Cosmos region code: 200132
    /// </summary>
    public static class Norway {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Norway() {
            _country = new CountryInfo {
                Country = Country.Norway,
                CountryCode = CountryCode.NO,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Norway,
                M49Code = "578",
                CRCode = 2_00_132,
                Alpha2Code = "NO",
                Alpha3Code = "NOR",
                Name = "The Kingdom of Norway",
                ShorterForm = "Norway",
                ChineseName = "挪威王国",
                ChineseShorterForm = "挪威",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 挪威（The Kingdom of Norway，欧洲，NO，NOR，578），挪威王国 <br />
        /// Cosmos i18n code: i18n_country_nuowei<br />
        /// Cosmos region code: 200132
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nuowei";

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