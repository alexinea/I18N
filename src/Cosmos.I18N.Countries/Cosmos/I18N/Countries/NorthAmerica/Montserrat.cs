using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 蒙特塞拉特（Montserrat，北美洲，MS，MSR，500） <br />
    /// Cosmos i18n code: i18n_country_mengtesailate <br />
    /// Cosmos region code: 400124
    /// </summary>
    public static class Montserrat
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Montserrat()
        {
            _country = new CountryInfo
            {
                Country = Country.Montserrat,
                CountryCode = CountryCode.MS,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "500",
                CRCode = 4_00_124,
                Alpha2Code = "MS",
                Alpha3Code = "MSR",
                Name = "Montserrat",
                ChineseName = "蒙特塞拉特",
                ChineseAlias = "蒙瑟拉特岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 蒙特塞拉特（Montserrat，北美洲，MS，MSR，500） <br />
        /// Cosmos i18n code: i18n_country_mengtesailate <br />
        /// Cosmos region code: 400124
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_mengtesailate";

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