using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 托克劳群岛（Tokelau，大洋洲，TK，TKL，772） <br />
    /// Cosmos i18n code: i18n_country_tuokelao <br />
    /// Cosmos region code: 600120
    /// </summary>
    public static class Tokelau
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Tokelau()
        {
            _country = new CountryInfo
            {
                Country = Country.Tokelau,
                CountryCode = CountryCode.TK,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.NewZealand,
                M49Code = "772",
                CRCode = 6_00_120,
                Alpha2Code = "TK",
                Alpha3Code = "TKL",
                Name = "Tokelau",
                ChineseName = "托克劳群岛",
                ChineseShorterForm = "泰国",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 托克劳群岛（Tokelau，大洋洲，TK，TKL，772） <br />
        /// Cosmos i18n code: i18n_country_tuokelao <br />
        /// Cosmos region code: 600120
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tuokelao";

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