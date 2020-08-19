using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 香港（Hong Kong, SAR China，亚洲，HK，HKG，344），中华人民共和国香港特别行政区 <br />
    /// 香港，中华人民共和国的一部分 <br />
    /// Hong Kong, a part of China <br />
    /// Cosmos i18n code: i18n_country_xianggang <br />
    /// Cosmos region code: 1000010033
    /// </summary>
    public static class HongKong
    {
        private static readonly CountryInfo _country;

        static HongKong()
        {
            _country = new CountryInfo
            {
                Country = Country.HongKong,
                CountryCode = CountryCode.HK,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.China,
                M49Code = "344",
                CRCode = 1_00_001_0033,
                Alpha2Code = "HK",
                Alpha3Code = "HKG",
                Name = "Hong Kong, SAR China",
                ShorterForm = "Hong Kong",
                ChineseName = "中华人民共和国香港特别行政区",
                ChineseShorterForm = "香港",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 香港（Hong Kong, SAR China，亚洲，HK，HKG，344），中华人民共和国香港特别行政区 <br />
        /// 香港，中华人民共和国的一部分 <br />
        /// Hong Kong, a part of China <br />
        /// Cosmos i18n code: i18n_country_xianggang <br />
        /// Cosmos region code: 1000010033
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xianggang";

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