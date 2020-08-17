namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 刚果（金）（The Democratic Republic of the Congo，非洲，CD，CAF，140），刚果民主共和国 <br />
    /// Cosmos i18n code: i18n_country_gangguojin <br />
    /// Cosmos region code: 300113
    /// </summary>
    public static class CongoKinshasa {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CongoKinshasa() {
            _country = new CountryInfo {
                Country = Country.CongoKinshasa,
                CountryCode = CountryCode.CD,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.CongoKinshasa,
                M49Code = "140",
                CRCode = 3_00_113,
                Alpha2Code = "CD",
                Alpha3Code = "CAF",
                Name = "The Democratic Republic of the Congo",
                ShorterForm = "Congo (Kinshasa)",
                ChineseName = "刚果民主共和国",
                ChineseShorterForm = "刚果（金）",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 刚果（金）（The Democratic Republic of the Congo，非洲，CD，CAF，140），刚果民主共和国 <br />
        /// Cosmos i18n code: i18n_country_gangguojin <br />
        /// Cosmos region code: 300113
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gangguojin";

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