namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 菲律宾（Republic of the Philippines，亚洲，PH，PHL，6080），菲律宾共和国 <br />
    /// Cosmos i18n code: i18n_country_felvbin <br />
    /// Cosmos region code: 100131
    /// </summary>
    public static partial class Philippines
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Philippines()
        {
            _country = new CountryInfo
            {
                Country = Country.Philippines,
                CountryCode = CountryCode.PH,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Philippines,
                M49Code = "608",
                Cep1CrCode = 1_00_131,
                Alpha2Code = "PH",
                Alpha3Code = "PHL",
                Name = "Republic of the Philippines",
                ShorterForm = "Philippines",
                ChineseName = "菲律宾共和国",
                ChineseShorterForm = "菲律宾",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 菲律宾（Republic of the Philippines，亚洲，PH，PHL，6080），菲律宾共和国 <br />
        /// Cosmos i18n code: i18n_country_felvbin <br />
        /// Cosmos region code: 100131
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_felvbin";

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