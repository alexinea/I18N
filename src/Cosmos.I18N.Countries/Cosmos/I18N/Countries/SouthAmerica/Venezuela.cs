namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 委内瑞拉（Bolivarian Republic of Venezuela，南美洲，VE，VEN，862），委内瑞拉玻利瓦尔共和国 <br />
    /// Cosmos i18n code: i18n_country_weineiruila <br />
    /// Cosmos region code: 500013
    /// </summary>
    public static partial class Venezuela
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Venezuela()
        {
            _country = new CountryInfo
            {
                Country = Country.Venezuela,
                CountryCode = CountryCode.VE,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Venezuela,
                M49Code = "862",
                CRCode = 5_00_013,
                Alpha2Code = "VE",
                Alpha3Code = "VEN",
                Name = "Bolivarian Republic of Venezuela",
                ShorterForm = "Venezuela",
                ChineseName = "委内瑞拉玻利瓦尔共和国",
                ChineseShorterForm = "委内瑞拉",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 委内瑞拉（Bolivarian Republic of Venezuela，南美洲，VE，VEN，862），委内瑞拉玻利瓦尔共和国 <br />
        /// Cosmos i18n code: i18n_country_weineiruila <br />
        /// Cosmos region code: 500013
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_weineiruila";

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