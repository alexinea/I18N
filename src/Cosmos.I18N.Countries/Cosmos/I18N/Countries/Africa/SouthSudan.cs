using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 南苏丹（The Republic of South Sudan，非洲，SS，SSD，728），南苏丹共和国 <br />
    /// Cosmos i18n code: i18n_country_nansudan <br />
    /// Cosmos region code: 300149
    /// </summary>
    public static class SouthSudan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SouthSudan()
        {
            _country = new CountryInfo
            {
                Country = Country.SouthSudan,
                CountryCode = CountryCode.SS,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.SouthSudan,
                M49Code = "728",
                CRCode = 3_00_149,
                Alpha2Code = "SS",
                Alpha3Code = "SSD",
                Name = "The Republic of South Sudan",
                ShorterForm = "South Sudan",
                ChineseName = "南苏丹共和国",
                ChineseShorterForm = "南苏丹",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 南苏丹（The Republic of South Sudan，非洲，SS，SSD，728），南苏丹共和国 <br />
        /// Cosmos i18n code: i18n_country_nansudan <br />
        /// Cosmos region code: 300149
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nansudan";

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