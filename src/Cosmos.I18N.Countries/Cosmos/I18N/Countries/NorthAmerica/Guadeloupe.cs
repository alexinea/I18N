using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 瓜德罗普（Guadeloupe，北美洲，GP，GLP，312） <br />
    /// Cosmos i18n code: i18n_country_guadeluopu <br />
    /// Cosmos region code: 400118
    /// </summary>
    public static class Guadeloupe
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guadeloupe()
        {
            _country = new CountryInfo
            {
                Country = Country.Guadeloupe,
                CountryCode = CountryCode.GP,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.France,
                M49Code = "312",
                Cep1CrCode = 4_00_118,
                Alpha2Code = "GP",
                Alpha3Code = "GLP",
                Name = "Guadeloupe",
                ChineseName = "瓜德罗普",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 瓜德罗普（Guadeloupe，北美洲，GP，GLP，312） <br />
        /// Cosmos i18n code: i18n_country_guadeluopu <br />
        /// Cosmos region code: 400118
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_guadeluopu";

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