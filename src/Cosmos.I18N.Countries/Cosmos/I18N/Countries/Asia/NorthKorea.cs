namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 朝鲜（Democratic People's Republic of Korea，亚洲，KP，PRK，408），朝鲜民主主义人民共和国 <br />
    /// Cosmos i18n code: i18n_country_chaoxian <br />
    /// Cosmos region code: 100011
    /// </summary>
    public static class NorthKorea {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static NorthKorea() {
            _country = new CountryInfo {
                Country = Country.NorthKorea,
                CountryCode = CountryCode.KP,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.NorthKorea,
                M49Code = "408",
                CRCode = 1_00_011,
                Alpha2Code = "KP",
                Alpha3Code = "PRK",
                Name = "Democratic People's Republic of Korea",
                ShorterForm = "North Korea",
                ChineseName = "朝鲜民主主义人民共和国",
                ChineseShorterForm = "朝鲜",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 朝鲜（Democratic People's Republic of Korea，亚洲，KP，PRK，408），朝鲜民主主义人民共和国 <br />
        /// Cosmos i18n code: i18n_country_chaoxian <br />
        /// Cosmos region code: 100011
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_chaoxian";

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