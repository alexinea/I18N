namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 埃及（The Arab Republic of Egypt，非洲，EG，EGY，818），阿拉伯埃及共和国 <br />
    /// Cosmos i18n code: i18n_country_aiji <br />
    /// Cosmos region code: 300011
    /// </summary>
    public static partial class Egypt
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Egypt()
        {
            _country = new CountryInfo
            {
                Country = Country.Egypt,
                CountryCode = CountryCode.EG,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Egypt,
                M49Code = "818",
                CRCode = 3_00_011,
                Alpha2Code = "EG",
                Alpha3Code = "EGY",
                Name = "The Arab Republic of Egypt",
                ShorterForm = "Egypt",
                ChineseName = "阿拉伯埃及共和国",
                ChineseShorterForm = "埃及",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 埃及（The Arab Republic of Egypt，非洲，EG，EGY，818），阿拉伯埃及共和国 <br />
        /// Cosmos i18n code: i18n_country_aiji <br />
        /// Cosmos region code: 300011
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aiji";

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