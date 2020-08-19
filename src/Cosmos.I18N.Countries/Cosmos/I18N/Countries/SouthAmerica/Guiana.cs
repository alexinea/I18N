using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 法属圭亚那（Guyane Francaise，南美洲，GF，GUF，254） <br />
    /// Cosmos i18n code: i18n_country_guiyana <br />
    /// Cosmos region code: 500105
    /// </summary>
    public static class Guiana
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guiana()
        {
            _country = new CountryInfo
            {
                Country = Country.Guiana,
                CountryCode = CountryCode.GF,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.France,
                M49Code = "254",
                CRCode = 5_00_105,
                Alpha2Code = "GF",
                Alpha3Code = "GUF",
                Name = "Guyane Francaise",
                ShorterForm = "Guiana",
                ChineseName = "法属圭亚那",
                ChineseAlias = "森林之国",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 法属圭亚那（Guyane Francaise，南美洲，GF，GUF，254） <br />
        /// Cosmos i18n code: i18n_country_guiyana <br />
        /// Cosmos region code: 500105
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_guiyana";

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