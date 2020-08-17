namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 吉尔吉斯斯坦（The Kyrgyz Republic/Kyrgyzstan，亚洲，KG，KGZ，417），吉尔吉斯共和国 <br />
    /// Cosmos i18n code: i18n_country_jierjisi <br />
    /// Cosmos region code: 100121
    /// </summary>
    public static class Kyrgyzstan {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Kyrgyzstan() {
            _country = new CountryInfo {
                Country = Country.Kyrgyzstan,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Kyrgyzstan,
                M49Code = "417",
                CRCode = 1_00_121,
                Alpha2Code = "KG",
                Alpha3Code = "KGZ",
                Name = "The Kyrgyz Republic",
                ShorterForm = "Kyrgyzstan",
                ChineseName = "吉尔吉斯共和国",
                ChineseShorterForm = "吉尔吉斯斯坦",
                ChineseAlias = "吉尔吉斯",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 吉尔吉斯斯坦（The Kyrgyz Republic/Kyrgyzstan，亚洲，KG，KGZ，417），吉尔吉斯共和国 <br />
        /// Cosmos i18n code: i18n_country_jierjisi <br />
        /// Cosmos region code: 100121
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jierjisi";

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