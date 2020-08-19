namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 巴基斯坦（Islamic Republic of Pakistan，亚洲，PK，PAK，586），巴基斯坦伊斯兰共和国 <br />
    /// Cosmos i18n code: i18n_country_bajisitan <br />
    /// Cosmos region code: 100016
    /// </summary>
    public static partial class Pakistan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Pakistan()
        {
            _country = new CountryInfo
            {
                Country = Country.Pakistan,
                CountryCode = CountryCode.PK,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Pakistan,
                M49Code = "586",
                CRCode = 1_00_016,
                Alpha2Code = "PK",
                Alpha3Code = "PAK",
                Name = "Islamic Republic of Pakistan",
                ShorterForm = "Pakistan",
                ChineseName = "巴基斯坦伊斯兰共和国",
                ChineseShorterForm = "巴基斯坦",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 巴基斯坦（Islamic Republic of Pakistan，亚洲，PK，PAK，586），巴基斯坦伊斯兰共和国 <br />
        /// Cosmos i18n code: i18n_country_bajisitan <br />
        /// Cosmos region code: 100016
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bajisitan";

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