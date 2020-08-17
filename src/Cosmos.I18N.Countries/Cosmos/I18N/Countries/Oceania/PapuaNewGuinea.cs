namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 巴布亚新几内亚（The Independent State of Papua New Guinea，大洋洲，PG，PNG，598），巴布亚新几内亚独立国 <br />
    /// Cosmos i18n code: i18n_country_baxin <br />
    /// Cosmos region code: 600114
    /// </summary>
    public static class PapuaNewGuinea {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static PapuaNewGuinea() {
            _country = new CountryInfo {
                Country = Country.PapuaNewGuinea,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.PapuaNewGuinea,
                M49Code = "598",
                CRCode = 6_00_114,
                Alpha2Code = "PG",
                Alpha3Code = "PNG",
                Name = "The Independent State of Papua New Guinea",
                ShorterForm = "Papua New Guinea",
                ChineseName = "巴布亚新几内亚独立国",
                ChineseShorterForm = "巴布亚新几内亚",
                ChineseAlias = "巴新",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴布亚新几内亚（The Independent State of Papua New Guinea，大洋洲，PG，PNG，598），巴布亚新几内亚独立国 <br />
        /// Cosmos i18n code: i18n_country_baxin <br />
        /// Cosmos region code: 600114
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_baxin";

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