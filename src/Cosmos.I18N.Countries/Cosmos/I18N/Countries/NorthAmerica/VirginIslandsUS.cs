using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 美属维尔京群岛（The United States Virgin Islands，北美洲，VI，VIR，850） <br />
    /// Cosmos i18n code: i18n_country_meishuweierjing <br />
    /// Cosmos region code: 400138
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class VirginIslandsUS
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static VirginIslandsUS()
        {
            _country = new CountryInfo
            {
                Country = Country.VirginIslandsUS,
                CountryCode = CountryCode.VI,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedStates,
                M49Code = "850",
                CRCode = 4_00_138,
                Alpha2Code = "VI",
                Alpha3Code = "VIR",
                Name = "The United States Virgin Islands",
                ShorterForm = "Virgin Islands (U.S.)",
                ChineseName = "美属维尔京群岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 美属维尔京群岛（The United States Virgin Islands，北美洲，VI，VIR，850） <br />
        /// Cosmos i18n code: i18n_country_meishuweierjing <br />
        /// Cosmos region code: 400138
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_meishuweierjing";

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