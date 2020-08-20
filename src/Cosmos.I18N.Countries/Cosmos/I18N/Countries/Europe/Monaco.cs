using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 摩纳哥（The Principality of Monaco，欧洲，MC，MCO，492），摩纳哥公国 <br />
    /// Cosmos i18n code: i18n_country_monage <br />
    /// Cosmos region code: 200129
    /// </summary>
    public static class Monaco
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Monaco()
        {
            _country = new CountryInfo
            {
                Country = Country.Monaco,
                CountryCode = CountryCode.MC,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Monaco,
                M49Code = "492",
                Cep1CrCode = 2_00_129,
                Alpha2Code = "MC",
                Alpha3Code = "MCO",
                Name = "The Principality of Monaco",
                ShorterForm = "Monaco",
                ChineseName = "摩纳哥公国",
                ChineseShorterForm = "摩纳哥",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 摩纳哥（The Principality of Monaco，欧洲，MC，MCO，492），摩纳哥公国 <br />
        /// Cosmos i18n code: i18n_country_monage <br />
        /// Cosmos region code: 200129
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_monage";

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