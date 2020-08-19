using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 奥兰群岛（Aland Island，欧洲，AX，ALA，248），奥兰自治省 <br />
    /// Cosmos i18n code: i18n_country_aolanqundao <br />
    /// Cosmos region code: 200101
    /// </summary>
    public static class AlandIslands
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static AlandIslands()
        {
            _country = new CountryInfo
            {
                Country = Country.AlandIslands,
                CountryCode = CountryCode.AX,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.Finland,
                M49Code = "248",
                CRCode = 2_00_101,
                Alpha2Code = "AX",
                Alpha3Code = "ALA",
                Name = "Aland Island",
                Alias = "Ahvenanmaa",
                ChineseName = "奥兰群岛",
                ChineseAlias = "奥兰自治省",
                ChineseAlias2 = "阿赫韦南马群岛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 奥兰群岛（Aland Island，欧洲，AX，ALA，248），奥兰自治省 <br />
        /// Cosmos i18n code: i18n_country_aolanqundao
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aolanqundao";

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