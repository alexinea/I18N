namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 土库曼（Turkmenistan，亚洲，TM，TKM，795），土库曼斯坦 <br />
    /// Cosmos i18n code: i18n_country_tukumansitan <br />
    /// Cosmos region code: 100139
    /// </summary>
    public static partial class Turkmenistan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Turkmenistan()
        {
            _country = new CountryInfo
            {
                Country = Country.Turkmenistan,
                CountryCode = CountryCode.TM,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Turkmenistan,
                M49Code = "795",
                CRCode = 1_00_139,
                Alpha2Code = "TM",
                Alpha3Code = "TKM",
                Name = "Turkmenistan",
                ChineseName = "土库曼斯坦",
                ChineseShorterForm = "土库曼",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 土库曼（Turkmenistan，亚洲，TM，TKM，795），土库曼斯坦 <br />
        /// Cosmos i18n code: i18n_country_tukumansitan <br />
        /// Cosmos region code: 100139
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tukumansitan";

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