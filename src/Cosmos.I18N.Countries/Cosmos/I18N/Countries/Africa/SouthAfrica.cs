using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 南非（The Republic of South Africa，非洲，ZA，ZAF，710），南非共和国 <br />
    /// Cosmos i18n code: i18n_country_nanfei <br />
    /// Cosmos region code: 300013
    /// </summary>
    public static class SouthAfrica
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SouthAfrica()
        {
            _country = new CountryInfo
            {
                Country = Country.SouthAfrica,
                CountryCode = CountryCode.ZA,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.SouthAfrica,
                M49Code = "710",
                CRCode = 3_00_013,
                Alpha2Code = "ZA",
                Alpha3Code = "ZAF",
                Name = "The Republic of South Africa",
                ChineseName = "南非共和国",
                ChineseShorterForm = "南非",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 南非（The Republic of South Africa，非洲，ZA，ZAF，710），南非共和国 <br />
        /// Cosmos i18n code: i18n_country_nanfei <br />
        /// Cosmos region code: 300013
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nanfei";

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