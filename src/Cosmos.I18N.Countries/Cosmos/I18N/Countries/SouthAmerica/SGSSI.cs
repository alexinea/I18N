using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 南乔治亚岛和南桑威奇群岛（South Georgia and The South Sandwich Islands，南美洲，GS，SGS，239） <br />
    /// Cosmos i18n code: i18n_country_nanqiaozhiya <br />
    /// Cosmos region code: 500111
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static class SGSSI
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SGSSI()
        {
            _country = new CountryInfo
            {
                Country = Country.SGSSI,
                CountryCode = CountryCode.GS,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "239",
                CRCode = 5_00_111,
                Alpha2Code = "GS",
                Alpha3Code = "SGS",
                Name = "South Georgia and The South Sandwich Islands",
                ShorterForm = "SGSSI",
                ChineseName = "南乔治亚岛和南桑威奇群岛",
                ChineseShorterForm = "厄瓜多尔",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 南乔治亚岛和南桑威奇群岛（South Georgia and The South Sandwich Islands，南美洲，GS，SGS，239） <br />
        /// Cosmos i18n code: i18n_country_nanqiaozhiya <br />
        /// Cosmos region code: 500111
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nanqiaozhiya";

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