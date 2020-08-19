using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 法属南部领地（French Southern Territories，非洲，TF，ATF，260） <br />
    /// Cosmos i18n code: i18n_country_faguonanbulingdi <br />
    /// Cosmos region code: 300124
    /// </summary>
    public static class FrenchSouthernTerritories
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static FrenchSouthernTerritories()
        {
            _country = new CountryInfo
            {
                Country = Country.FrenchSouthernTerritories,
                CountryCode = CountryCode.TF,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.France,
                M49Code = "260",
                CRCode = 3_00_124,
                Alpha2Code = "TF",
                Alpha3Code = "ATF",
                Name = "French Southern Territories",
                ChineseName = "法属南部领地",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 法属南部领地（French Southern Territories，非洲，TF，ATF，260） <br />
        /// Cosmos i18n code: i18n_country_faguonanbulingdi <br />
        /// Cosmos region code: 300124
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_faguonanbulingdi";

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