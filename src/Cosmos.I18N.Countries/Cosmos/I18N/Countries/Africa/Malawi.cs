using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 马拉维（The Republic of Malawi，非洲，MW，MWI，454），马拉维共和国 <br />
    /// Cosmos i18n code: i18n_country_malawei <br />
    /// Cosmos region code: 300137
    /// </summary>
    public static class Malawi
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Malawi()
        {
            _country = new CountryInfo
            {
                Country = Country.Malawi,
                CountryCode = CountryCode.MW,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Malawi,
                M49Code = "454",
                CRCode = 3_00_137,
                Alpha2Code = "MW",
                Alpha3Code = "MWI",
                Name = "The Republic of Malawi",
                ShorterForm = "Malawi",
                ChineseName = "马拉维共和国",
                ChineseShorterForm = "马拉维",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 马拉维（The Republic of Malawi，非洲，MW，MWI，454），马拉维共和国 <br />
        /// Cosmos i18n code: i18n_country_malawei <br />
        /// Cosmos region code: 300137
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_malawei";

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