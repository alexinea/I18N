namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 泰国（The Kingdom of Thailand，亚洲，TH，THA，764），泰王国 <br />
    /// Cosmos i18n code: i18n_country_taiguo <br />
    /// Cosmos region code: 100138
    /// </summary>
    public static partial class Thailand
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Thailand()
        {
            _country = new CountryInfo
            {
                Country = Country.Thailand,
                CountryCode = CountryCode.TH,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Thailand,
                M49Code = "764",
                CRCode = 1_00_138,
                Alpha2Code = "TH",
                Alpha3Code = "THA",
                Name = "The Kingdom of Thailand",
                ShorterForm = "Thailand",
                ChineseName = "泰王国",
                ChineseShorterForm = "泰国",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 泰国（The Kingdom of Thailand，亚洲，TH，THA，764），泰王国 <br />
        /// Cosmos i18n code: i18n_country_taiguo <br />
        /// Cosmos region code: 100138
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_taiguo";

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