using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 关岛（The Territory of Guam，大洋洲，GU，GUM，316） <br />
    /// Cosmos i18n code: i18n_country_guandao <br />
    /// Cosmos region code: 600104
    /// </summary>
    public static class Guam
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guam()
        {
            _country = new CountryInfo
            {
                Country = Country.Guam,
                CountryCode = CountryCode.GU,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedStates,
                M49Code = "316",
                Cep1CrCode = 6_00_104,
                Alpha2Code = "GU",
                Alpha3Code = "GUM",
                Name = "The Territory of Guam",
                ShorterForm = "Guam",
                ChineseName = "关岛",
                ChineseAlias = "自由天堂",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 关岛（The Territory of Guam，大洋洲，GU，GUM，316） <br />
        /// Cosmos i18n code: i18n_country_guandao <br />
        /// Cosmos region code: 600104
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_guandao";

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