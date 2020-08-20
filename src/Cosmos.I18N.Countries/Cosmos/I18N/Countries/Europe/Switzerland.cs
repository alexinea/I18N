namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 瑞士（Swiss Confederation，欧洲，CH，CHE，756），瑞士联邦 <br />
    /// Cosmos i18n code: i18n_country_ruishi <br />
    /// Cosmos region code: 200017
    /// </summary>
    public static partial class Switzerland
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Switzerland()
        {
            _country = new CountryInfo
            {
                Country = Country.Switzerland,
                CountryCode = CountryCode.CH,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Switzerland,
                M49Code = "756",
                Cep1CrCode = 2_00_017,
                Alpha2Code = "CH",
                Alpha3Code = "CHE",
                Name = "Swiss Confederation",
                ShorterForm = "Switzerland",
                ChineseName = "瑞士联邦",
                ChineseShorterForm = "瑞士",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 瑞士（Swiss Confederation，欧洲，CH，CHE，756），瑞士联邦 <br />
        /// Cosmos i18n code: i18n_country_ruishi <br />
        /// Cosmos region code: 200017
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_ruishi";

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