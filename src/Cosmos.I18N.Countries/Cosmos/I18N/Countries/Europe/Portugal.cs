using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 葡萄牙（The Portuguese Republic，欧洲，PT，PRT，620），葡萄牙共和国 <br />
    /// Cosmos i18n code: i18n_country_putapya <br />
    /// Cosmos region code: 200133
    /// </summary>
    public static class Portugal
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Portugal()
        {
            _country = new CountryInfo
            {
                Country = Country.Portugal,
                CountryCode = CountryCode.PT,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Portugal,
                M49Code = "620",
                CRCode = 2_00_133,
                Alpha2Code = "PT",
                Alpha3Code = "PRT",
                Name = "The Portuguese Republic",
                ShorterForm = "Portugal",
                ChineseName = "葡萄牙共和国",
                ChineseShorterForm = "葡萄牙",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 葡萄牙（The Portuguese Republic，欧洲，PT，PRT，620），葡萄牙共和国 <br />
        /// Cosmos i18n code: i18n_country_putapya <br />
        /// Cosmos region code: 200133
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_putapya";

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