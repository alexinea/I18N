namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 伊朗（The Islamic Republic of Iran，亚洲，IR，IRN，364），伊朗伊斯兰共和国 <br />
    /// Cosmos i18n code: i18n_country_yilang <br />
    /// Cosmos region code: 100014
    /// </summary>
    public static partial class Iran
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Iran()
        {
            _country = new CountryInfo
            {
                Country = Country.Iran,
                CountryCode = CountryCode.IR,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Iran,
                M49Code = "364",
                CRCode = 1_00_014,
                Alpha2Code = "IR",
                Alpha3Code = "IRN",
                Name = "The Islamic Republic of Iran",
                ShorterForm = "Iran",
                ChineseName = "伊朗伊斯兰共和国",
                ChineseShorterForm = "伊朗",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 伊朗（The Islamic Republic of Iran，亚洲，IR，IRN，364），伊朗伊斯兰共和国 <br />
        /// Cosmos i18n code: i18n_country_yilang<br />
        /// Cosmos region code: 100014
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yilang";

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