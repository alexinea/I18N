using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 波多黎各（The Commonwealth of Puerto Rico，北美洲，PR，PRI，630），波多黎各自治邦 <br />
    /// Cosmos i18n code: i18n_country_boduolige <br />
    /// Cosmos region code: 400126
    /// </summary>
    public static class PuertoRico
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static PuertoRico()
        {
            _country = new CountryInfo
            {
                Country = Country.PuertoRico,
                CountryCode = CountryCode.PR,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedStates,
                M49Code = "630",
                CRCode = 4_00_126,
                Alpha2Code = "PR",
                Alpha3Code = "PRI",
                Name = "The Commonwealth of Puerto Rico",
                ShorterForm = "Puerto Rico",
                ChineseName = "波多黎各自治邦",
                ChineseShorterForm = "波多黎各",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 波多黎各（The Commonwealth of Puerto Rico，北美洲，PR，PRI，630），波多黎各自治邦 <br />
        /// Cosmos i18n code: i18n_country_boduolige <br />
        /// Cosmos region code: 400126
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_boduolige";

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