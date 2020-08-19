using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
    /// Cosmos i18n code: i18n_country_faluo <br />
    /// Cosmos region code: 200112
    /// </summary>
    public static class Faroe
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Faroe()
        {
            _country = new CountryInfo
            {
                Country = Country.Faroe,
                CountryCode = CountryCode.FO,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.Denmark,
                M49Code = "234",
                CRCode = 2_00_112,
                Alpha2Code = "FO",
                Alpha3Code = "FRO",
                Name = "Faroe Islands",
                ShorterForm = "Faroe",
                ChineseName = "法罗群岛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
        /// Cosmos i18n code: i18n_country_faluo <br />
        /// Cosmos region code: 200112
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_faluo";

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