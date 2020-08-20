namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 白俄罗斯（Republic of Belarus，欧洲，BY，BLR，112），白俄罗斯共和国 <br />
    /// Cosmos i18n code: i18n_country_baieluosi <br />
    /// Cosmos region code: 200104
    /// </summary>
    public static partial class Belarus
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Belarus()
        {
            _country = new CountryInfo
            {
                Country = Country.Belarus,
                CountryCode = CountryCode.BY,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Belarus,
                M49Code = "112",
                Cep1CrCode = 2_00_104,
                Alpha2Code = "BY",
                Alpha3Code = "BLR",
                Name = "Republic of Belarus",
                ShorterForm = "Belarus",
                ChineseName = "白俄罗斯共和国",
                ChineseShorterForm = "白俄罗斯",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 白俄罗斯（Republic of Belarus，欧洲，BY，BLR，112），白俄罗斯共和国 <br />
        /// Cosmos i18n code: i18n_country_baieluosi <br />
        /// Cosmos region code: 200104
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_baieluosi";

        /// <summary>
        /// Get Cosmos Region Code (CEP-1/CRCode)
        /// </summary>
        public static long CosmosRegionCode => _country.Cep1CrCode;

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