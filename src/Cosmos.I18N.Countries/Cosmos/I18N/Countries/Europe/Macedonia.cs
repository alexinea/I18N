namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 北马其顿（The Republic of North Macedonia，欧洲，MK，MKD，807），北马其顿共和国 <br />
    /// Cosmos i18n code: i18n_country_maqidun <br />
    /// Cosmos region code: 200125
    /// </summary>
    public static partial class Macedonia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Macedonia()
        {
            _country = new CountryInfo
            {
                Country = Country.Macedonia,
                CountryCode = CountryCode.MK,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Macedonia,
                M49Code = "807",
                CRCode = 2_00_125,
                Alpha2Code = "MK",
                Alpha3Code = "MKD",
                Name = "The Republic of North Macedonia",
                ShorterForm = "Macedonia",
                ChineseName = "北马其顿共和国",
                ChineseShorterForm = "北马其顿",
                ChineseAlias = "马其顿",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 北马其顿（The Republic of North Macedonia，欧洲，MK，MKD，807），北马其顿共和国 <br />
        /// Cosmos i18n code: i18n_country_maqidun <br />
        /// Cosmos region code: 200125
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_maqidun";

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