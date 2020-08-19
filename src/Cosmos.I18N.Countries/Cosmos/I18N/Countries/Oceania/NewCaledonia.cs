using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 新喀里多尼亚（New Caledonia，大洋洲，NC，NCL，540） <br />
    /// Cosmos i18n code: i18n_country_xinkaliduoniya <br />
    /// Cosmos region code: 600109
    /// </summary>
    public static class NewCaledonia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static NewCaledonia()
        {
            _country = new CountryInfo
            {
                Country = Country.NewCaledonia,
                CountryCode = CountryCode.NC,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.NewCaledonia,
                M49Code = "540",
                CRCode = 6_00_109,
                Alpha2Code = "NC",
                Alpha3Code = "NCL",
                Name = "New Caledonia",
                ChineseName = "新喀里多尼亚",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 新喀里多尼亚（New Caledonia，大洋洲，NC，NCL，540） <br />
        /// Cosmos i18n code: i18n_country_xinkaliduoniya <br />
        /// Cosmos region code: 600109
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xinkaliduoniya";

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