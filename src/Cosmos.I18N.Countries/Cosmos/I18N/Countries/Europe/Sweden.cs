using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 瑞典（The Kingdom of Sweden，欧洲，SE，SWE，752），瑞典王国 <br />
    /// Cosmos i18n code: i18n_country_ruidian <br />
    /// Cosmos region code: 200016
    /// </summary>
    public static class Sweden
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Sweden()
        {
            _country = new CountryInfo
            {
                Country = Country.Sweden,
                CountryCode = CountryCode.SE,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Sweden,
                M49Code = "752",
                Cep1CrCode = 2_00_016,
                Alpha2Code = "SE",
                Alpha3Code = "SWE",
                Name = "The Kingdom of Sweden",
                ShorterForm = "Sweden",
                ChineseName = "瑞典王国",
                ChineseShorterForm = "瑞典",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 瑞典（The Kingdom of Sweden，欧洲，SE，SWE，752），瑞典王国 <br />
        /// Cosmos i18n code: i18n_country_ruidian <br />
        /// Cosmos region code: 200016
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_ruidian";

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