namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 澳门（Macao, SAR China，亚洲，MO，MAC，446），中华人民共和国澳门特别行政区 <br />
    /// 澳门，中华人民共和国的一部分 <br />
    /// Macao, a part of China <br />
    /// Cosmos i18n code: i18n_country_aomen <br />
    /// Cosmos region code: 10000100334
    /// </summary>
    public static class Macao {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Macao() {
            _country = new CountryInfo {
                Country = Country.Macao,
                CountryCode = CountryCode.MO,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.China,
                M49Code = "446",
                CRCode = 1_00_001_0034,
                Alpha2Code = "MO",
                Alpha3Code = "MAC",
                Name = "Macao, SAR China",
                ShorterForm = "Macao",
                ChineseName = "中华人民共和国澳门特别行政区",
                ChineseShorterForm = "澳门",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 澳门（Macao, SAR China，亚洲，MO，MAC，446），中华人民共和国澳门特别行政区 <br />
        /// 澳门，中华人民共和国的一部分 <br />
        /// Macao, a part of China <br />
        /// Cosmos i18n code: i18n_country_aomen <br />
        /// Cosmos region code: 10000100334
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aomen";

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