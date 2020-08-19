namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 帕劳（The Republic of Palau，大洋洲，PW，PLW，585），帕劳共和国 <br />
    /// Cosmos i18n code: i18n_country_palao <br />
    /// Cosmos region code: 600113
    /// </summary>
    public static partial class Palau
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Palau()
        {
            _country = new CountryInfo
            {
                Country = Country.Palau,
                CountryCode = CountryCode.PW,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Palau,
                M49Code = "585",
                CRCode = 6_00_113,
                Alpha2Code = "PW",
                Alpha3Code = "PLW",
                Name = "The Republic of Palau",
                ShorterForm = "Palau",
                ChineseName = "帕劳共和国",
                ChineseShorterForm = "帕劳",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 帕劳（The Republic of Palau，大洋洲，PW，PLW，585），帕劳共和国 <br />
        /// Cosmos i18n code: i18n_country_palao <br />
        /// Cosmos region code: 600113
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_palao";

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