using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 留尼汪（Reunion Island，非洲，RE，REU，638），留尼旺岛 <br />
    /// Cosmos i18n code: i18n_country_liuniwang <br />
    /// Cosmos region code: 300147
    /// </summary>
    public static class Réunion
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Réunion()
        {
            _country = new CountryInfo
            {
                Country = Country.Réunion,
                CountryCode = CountryCode.RE,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.France,
                M49Code = "638",
                CRCode = 3_00_147,
                Alpha2Code = "RE",
                Alpha3Code = "REU",
                Name = "Reunion Island",
                ShorterForm = "Réunion",
                ChineseName = "留尼旺岛",
                ChineseShorterForm = "留尼汪",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 留尼汪（Reunion Island，非洲，RE，REU，638），留尼旺岛 <br />
        /// Cosmos i18n code: i18n_country_liuniwang <br />
        /// Cosmos region code: 300147
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_liuniwang";

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