namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 不丹（Kingdom of Bhutan，亚洲，BT，BTN，064），不丹王国 <br />
    /// Cosmos i18n code: i18n_country_budan <br />
    /// Cosmos region code: 100106
    /// </summary>
    public static partial class Bhutan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bhutan()
        {
            _country = new CountryInfo
            {
                Country = Country.Bhutan,
                CountryCode = CountryCode.BT,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Bhutan,
                M49Code = "064",
                CRCode = 1_00_106,
                Alpha2Code = "BT",
                Alpha3Code = "BTN",
                Name = "Kingdom of Bhutan",
                ShorterForm = "Bhutan",
                ChineseName = "不丹王国",
                ChineseShorterForm = "不丹",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 不丹（Kingdom of Bhutan，亚洲，BT，BTN，064），不丹王国 <br />
        /// Cosmos i18n code: i18n_country_budan <br />
        /// Cosmos region code: 100106
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_budan";

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