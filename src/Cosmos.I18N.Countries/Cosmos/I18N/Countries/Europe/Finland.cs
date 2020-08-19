namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 芬兰（The Republic of Finland，欧洲，FI，FIN，246），芬兰共和国 <br />
    /// Cosmos i18n code: i18n_country_fenlan <br />
    /// Cosmos region code: 200113
    /// </summary>
    public static partial class Finland
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Finland()
        {
            _country = new CountryInfo
            {
                Country = Country.Finland,
                CountryCode = CountryCode.FI,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Finland,
                M49Code = "246",
                CRCode = 2_00_113,
                Alpha2Code = "FI",
                Alpha3Code = "FIN",
                Name = "The Republic of Finland",
                ShorterForm = "Finland",
                ChineseName = "芬兰共和国",
                ChineseShorterForm = "芬兰",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 芬兰（The Republic of Finland，欧洲，FI，FIN，246），芬兰共和国 <br />
        /// Cosmos i18n code: i18n_country_fenlan <br />
        /// Cosmos region code: 200113
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_fenlan";

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