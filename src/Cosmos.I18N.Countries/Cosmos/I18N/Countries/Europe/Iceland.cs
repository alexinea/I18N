using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 冰岛（The Republic of Iceland，欧洲，IS，ISL，352），冰岛共和国 <br />
    /// Cosmos i18n code: i18n_country_bingdao <br />
    /// Cosmos region code: 200118
    /// </summary>
    public static class Iceland
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Iceland()
        {
            _country = new CountryInfo
            {
                Country = Country.Iceland,
                CountryCode = CountryCode.IS,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Iceland,
                M49Code = "352",
                CRCode = 2_00_118,
                Alpha2Code = "IS",
                Alpha3Code = "ISL",
                Name = "The Republic of Iceland",
                ShorterForm = "Iceland",
                ChineseName = "冰岛共和国",
                ChineseShorterForm = "冰岛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 冰岛（The Republic of Iceland，欧洲，IS，ISL，352），冰岛共和国 <br />
        /// Cosmos i18n code: i18n_country_bingdao
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bingdao";

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