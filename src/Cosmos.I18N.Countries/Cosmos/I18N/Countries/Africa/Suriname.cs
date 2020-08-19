namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 苏里南（The Republic of Suriname，非洲，SR，SUR，740），苏里南共和国 <br />
    /// Cosmos i18n code: i18n_country_sulinan <br />
    /// Cosmos region code: 300150
    /// </summary>
    public static partial class Suriname
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Suriname()
        {
            _country = new CountryInfo
            {
                Country = Country.Suriname,
                CountryCode = CountryCode.SR,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Suriname,
                M49Code = "740",
                CRCode = 3_00_150,
                Alpha2Code = "SR",
                Alpha3Code = "SUR",
                Name = "The Republic of Suriname",
                ShorterForm = "Suriname",
                ChineseName = "苏里南共和国",
                ChineseShorterForm = "苏里南",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 苏里南（The Republic of Suriname，非洲，SR，SUR，740），苏里南共和国 <br />
        /// Cosmos i18n code: i18n_country_sulinan <br />
        /// Cosmos region code: 300150
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_sulinan";

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