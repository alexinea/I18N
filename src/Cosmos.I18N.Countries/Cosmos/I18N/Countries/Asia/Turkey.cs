using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 土耳其（The Republic of Turkey，亚洲，TR，TUR，792），土耳其共和国 <br />
    /// Cosmos i18n code: i18n_country_tuerqi <br />
    /// Cosmos region code: 100017
    /// </summary>
    public static class Turkey
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Turkey()
        {
            _country = new CountryInfo
            {
                Country = Country.Turkey,
                CountryCode = CountryCode.TR,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Turkey,
                M49Code = "792",
                Cep1CrCode = 1_00_017,
                Alpha2Code = "TR",
                Alpha3Code = "TUR",
                Name = "The Republic of Turkey",
                ShorterForm = "Turkey",
                ChineseName = "土耳其共和国",
                ChineseShorterForm = "土耳其",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 土耳其（The Republic of Turkey，亚洲，TR，TUR，792），土耳其共和国 <br />
        /// Cosmos i18n code: i18n_country_tuerqi <br />
        /// Cosmos region code: 100017
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tuerqi";

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