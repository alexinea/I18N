namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 塔吉克斯坦（The Republic of Tajikistan，亚洲，TJ，TJK，762），塔吉克斯坦共和国 <br />
    /// Cosmos i18n code: i18n_country_tajikesitan <br />
    /// Cosmos region code: 100137
    /// </summary>
    public static partial class Tajikistan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Tajikistan()
        {
            _country = new CountryInfo
            {
                Country = Country.Tajikistan,
                CountryCode = CountryCode.TJ,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Tajikistan,
                M49Code = "762",
                CRCode = 1_00_137,
                Alpha2Code = "TJ",
                Alpha3Code = "TJK",
                Name = "The Republic of Tajikistan",
                ShorterForm = "Tajikistan",
                ChineseName = "塔吉克斯坦共和国",
                ChineseShorterForm = "塔吉克斯坦",
                ChineseAlias = "塔吉克",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 塔吉克斯坦（The Republic of Tajikistan，亚洲，TJ，TJK，762），塔吉克斯坦共和国 <br />
        /// Cosmos i18n code: i18n_country_tajikesitan <br />
        /// Cosmos region code: 100137
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tajikesitan";

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