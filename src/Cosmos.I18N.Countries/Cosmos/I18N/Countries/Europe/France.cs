namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 法国（French Republic，欧洲，FR，FRA，250），法兰西共和国 <br />
    /// Cosmos i18n code: i18n_country_faguo <br />
    /// Cosmos region code: 200001
    /// </summary>
    public static partial class France
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static France()
        {
            _country = new CountryInfo
            {
                Country = Country.France,
                CountryCode = CountryCode.FR,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.France,
                M49Code = "250",
                CRCode = 2_00_001,
                Alpha2Code = "FR",
                Alpha3Code = "FRA",
                Name = "French Republic",
                ShorterForm = "France",
                ChineseName = "法兰西共和国",
                ChineseShorterForm = "法国",
                ChineseAlias = "法兰西",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 法国（French Republic，欧洲，FR，FRA，250），法兰西共和国 <br />
        /// Cosmos i18n code: i18n_country_faguo <br />
        /// Cosmos region code: 200001
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_faguo";

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