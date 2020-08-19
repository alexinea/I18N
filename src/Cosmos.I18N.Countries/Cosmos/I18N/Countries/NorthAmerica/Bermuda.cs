using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 百慕大（The Bermuda Islands，北美洲，BM，BMU，060），百慕大群岛 <br />
    /// 旧称萨摩斯岛，隶属于大不列颠及北爱尔兰联合王国的海外自治领 <br />
    /// Cosmos i18n code: i18n_country_baimuda<br />
    /// Cosmos region code: 400108
    /// </summary>
    public static class Bermuda
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bermuda()
        {
            _country = new CountryInfo
            {
                Country = Country.Bermuda,
                CountryCode = CountryCode.BM,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "060",
                CRCode = 4_00_108,
                Alpha2Code = "BM",
                Alpha3Code = "BMU",
                Name = "The Bermuda Islands",
                ShorterForm = "Bermuda",
                ChineseName = "百慕大群岛",
                ChineseShorterForm = "百慕大",
                ChineseAlias = "旧称萨默斯岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 百慕大（The Bermuda Islands，北美洲，BM，BMU，060），百慕大群岛 <br />
        /// 旧称萨摩斯岛，隶属于大不列颠及北爱尔兰联合王国的海外自治领 <br />
        /// Cosmos i18n code: i18n_country_baimuda <br />
        /// Cosmos region code: 400108
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_baimuda";

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