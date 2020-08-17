namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 哈萨克斯坦（ The Republic of Kazakhstan，亚洲，KZ，KAZ，398），哈萨克斯坦共和国 <br />
    /// Cosmos i18n code: i18n_country_hasakesitan <br />
    /// Cosmos region code: 100119
    /// </summary>
    public static class Kazakhstan {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Kazakhstan() {
            _country = new CountryInfo {
                Country = Country.Kazakhstan,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Kazakhstan,
                M49Code = "398",
                CRCode = 1_00_119,
                Alpha2Code = "KZ",
                Alpha3Code = "KAZ",
                Name = " The Republic of Kazakhstan",
                ShorterForm = "Kazakhstan",
                ChineseName = "哈萨克斯坦共和国",
                ChineseShorterForm = "哈萨克斯坦",
                ChineseAlias = "哈萨克",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 哈萨克斯坦（ The Republic of Kazakhstan，亚洲，KZ，KAZ，398），哈萨克斯坦共和国 <br />
        /// Cosmos i18n code: i18n_country_hasakesitan <br />
        /// Cosmos region code: 100119
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_hasakesitan";

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