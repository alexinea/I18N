using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 科索沃（Kosovo，欧洲，XK，XKX，838），科索沃自治省 <br />
    /// Cosmos i18n code: i18n_country_kesuowo <br />
    /// Cosmos region code: 200120
    /// </summary>
    public static class Kosovo
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Kosovo()
        {
            _country = new CountryInfo
            {
                Country = Country.Kosovo,
                CountryCode = CountryCode.XK,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.Serbia,
                M49Code = "838",
                Cep1CrCode = 2_00_120,
                Alpha2Code = "XK",
                Alpha3Code = "XKX",
                Name = "Kosovo",
                ChineseName = "科索沃自治省",
                ChineseShorterForm = "科索沃",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 科索沃（Kosovo，欧洲，XK，XKX，838），科索沃自治省 <br />
        /// Cosmos i18n code: i18n_country_kesuowo <br />
        /// Cosmos region code: 200120
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kesuowo";

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