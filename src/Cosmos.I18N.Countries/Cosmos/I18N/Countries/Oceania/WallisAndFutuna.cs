namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 瓦利斯和富图纳群岛（Wallis and Futuna Islands，大洋洲，WF，WLF，876） <br />
    /// Cosmos i18n code: i18n_country_walisi <br />
    /// Cosmos region code: 600116
    /// </summary>
    public static partial class WallisAndFutuna
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static WallisAndFutuna()
        {
            _country = new CountryInfo
            {
                Country = Country.WallisAndFutuna,
                CountryCode = CountryCode.WF,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.France,
                M49Code = "876",
                CRCode = 6_00_116,
                Alpha2Code = "WF",
                Alpha3Code = "WLF",
                Name = "Wallis and Futuna Islands",
                ChineseName = "瓦利斯和富图纳群岛",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 瓦利斯和富图纳群岛（Wallis and Futuna Islands，大洋洲，WF，WLF，876） <br />
        /// Cosmos i18n code: i18n_country_walisi <br />
        /// Cosmos region code: 600116
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_walisi";

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