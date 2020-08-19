namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 孟加拉国（People's Republic Of Bangladesh，亚洲，BD，BGD，050），孟加拉人民共和国 <br />
    /// Cosmos i18n code: i18n_country_mengjiala <br />
    /// Cosmos region code: 100105
    /// </summary>
    public static partial class Bangladesh
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bangladesh()
        {
            _country = new CountryInfo
            {
                Country = Country.Bangladesh,
                CountryCode = CountryCode.BD,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Bangladesh,
                M49Code = "050",
                CRCode = 1_00_105,
                Alpha2Code = "BD",
                Alpha3Code = "BGD",
                Name = "People's Republic Of Bangladesh",
                ShorterForm = "Bangladesh",
                ChineseName = "孟加拉人民共和国",
                ChineseShorterForm = "孟加拉国",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 孟加拉国（People's Republic Of Bangladesh，亚洲，BD，BGD，050），孟加拉人民共和国 <br />
        /// Cosmos i18n code: i18n_country_mengjiala <br />
        /// Cosmos region code: 100105
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_mengjiala";

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