namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 汤加（The Kingdom of Tonga，大洋洲，TO，TN，776），汤加王国 <br />
    /// Cosmos i18n code: i18n_country_tangjia <br />
    /// Cosmos region code: 600121
    /// </summary>
    public static partial class Tonga
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Tonga()
        {
            _country = new CountryInfo
            {
                Country = Country.Tonga,
                CountryCode = CountryCode.TO,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Tonga,
                M49Code = "776",
                CRCode = 6_00_121,
                Alpha2Code = "TO",
                Alpha3Code = "TON",
                Name = "The Kingdom of Tonga",
                ShorterForm = "Tonga",
                ChineseName = "汤加王国",
                ChineseShorterForm = "汤加",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 汤加（The Kingdom of Tonga，大洋洲，TO，TN，776），汤加王国 <br />
        /// Cosmos i18n code: i18n_country_tangjia <br />
        /// Cosmos region code: 600121
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tangjia";

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