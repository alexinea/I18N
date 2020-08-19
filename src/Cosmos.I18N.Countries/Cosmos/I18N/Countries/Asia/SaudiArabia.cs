namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 沙特（Kingdom of Saudi Arabia，亚洲，SA，SAU，682），沙特阿拉伯王国 <br />
    /// Cosmos i18n code: i18n_country_shate <br />
    /// Cosmos region code: 100133
    /// </summary>
    public static partial class SaudiArabia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaudiArabia()
        {
            _country = new CountryInfo
            {
                Country = Country.SaudiArabia,
                CountryCode = CountryCode.SA,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.SaudiArabia,
                M49Code = "682",
                CRCode = 1_00_133,
                Alpha2Code = "SA",
                Alpha3Code = "SAU",
                Name = "Kingdom of Saudi Arabia",
                ShorterForm = "Saudi Arabia",
                ChineseName = "沙特阿拉伯王国",
                ChineseShorterForm = "沙特",
                ChineseAlias = "沙特阿拉伯",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 沙特（Kingdom of Saudi Arabia，亚洲，SA，SAU，682），沙特阿拉伯王国 <br />
        /// Cosmos i18n code: i18n_country_shate <br />
        /// Cosmos region code: 100133
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shate";

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