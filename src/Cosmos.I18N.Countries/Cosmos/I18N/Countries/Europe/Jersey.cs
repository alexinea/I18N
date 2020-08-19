using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 泽西（Bailiwick of Jersey，欧洲，JE，JEY，832），泽西岛 <br />
    /// Cosmos i18n code: i18n_country_zexi <br />
    /// Cosmos region code: 200119
    /// </summary>
    public static class Jersey
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Jersey()
        {
            _country = new CountryInfo
            {
                Country = Country.Jersey,
                CountryCode = CountryCode.JE,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "832",
                CRCode = 2_00_119,
                Alpha2Code = "JE",
                Alpha3Code = "JEY",
                Name = "Bailiwick of Jersey",
                ShorterForm = "Jersey",
                ChineseName = "泽西岛",
                ChineseShorterForm = "泽西",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 泽西（Bailiwick of Jersey，欧洲，JE，JEY，832），泽西岛 <br />
        /// Cosmos i18n code: i18n_country_zexi <br />
        /// Cosmos region code: 200119
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_zexi";

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