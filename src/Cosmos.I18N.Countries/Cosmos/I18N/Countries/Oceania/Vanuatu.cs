namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 瓦努阿图（The Republic of Vanuatu，大洋洲，VU，VUT，548），瓦努阿图共和国 <br />
    /// Cosmos i18n code: i18n_country_wanuatu <br />
    /// Cosmos region code: 600123
    /// </summary>
    public static partial class Vanuatu
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Vanuatu()
        {
            _country = new CountryInfo
            {
                Country = Country.Vanuatu,
                CountryCode = CountryCode.VU,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Vanuatu,
                M49Code = "548",
                CRCode = 6_00_123,
                Alpha2Code = "VU",
                Alpha3Code = "VUT",
                Name = "The Republic of Vanuatu",
                ShorterForm = "Vanuatu",
                ChineseName = "瓦努阿图共和国",
                ChineseShorterForm = "瓦努阿图",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 瓦努阿图（The Republic of Vanuatu，大洋洲，VU，VUT，548），瓦努阿图共和国 <br />
        /// Cosmos i18n code: i18n_country_wanuatu <br />
        /// Cosmos region code: 600123
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_wanuatu";

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