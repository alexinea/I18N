namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 图瓦卢（Tuvalu，大洋洲，TV，TUV，798） <br />
    /// Cosmos i18n code: i18n_country_tuwalu <br />
    /// Cosmos region code: 600122
    /// </summary>
    public static class Tuvalu {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Tuvalu() {
            _country = new CountryInfo {
                Country = Country.Tuvalu,
                CountryCode = CountryCode.TV,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Tuvalu,
                M49Code = "798",
                CRCode = 6_00_122,
                Alpha2Code = "TV",
                Alpha3Code = "TUV",
                Name = "Tuvalu",
                ChineseName = "图瓦卢",
                ChineseAlias = "埃利斯群岛",
                ChineseAlias2 = "潟湖群岛",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 图瓦卢（Tuvalu，大洋洲，TV，TUV，798） <br />
        /// Cosmos i18n code: i18n_country_tuwalu <br />
        /// Cosmos region code: 600122
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tuwalu";

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