using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 立陶宛（The Republic of Lithuania，欧洲，LT，LTU，440），立陶宛共和国 <br />
    /// Cosmos i18n code: i18n_country_litaowan <br />
    /// Cosmos region code: 200123
    /// </summary>
    public static class Lithuania
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Lithuania()
        {
            _country = new CountryInfo
            {
                Country = Country.Lithuania,
                CountryCode = CountryCode.LT,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Lithuania,
                M49Code = "440",
                CRCode = 2_00_123,
                Alpha2Code = "LT",
                Alpha3Code = "LTU",
                Name = "The Republic of Lithuania",
                ShorterForm = "Lithuania",
                ChineseName = "立陶宛共和国",
                ChineseShorterForm = "立陶宛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 立陶宛（The Republic of Lithuania，欧洲，LT，LTU，440），立陶宛共和国 <br />
        /// Cosmos i18n code: i18n_country_litaowan <br />
        /// Cosmos region code: 200123
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_litaowan";

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