using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 库拉索（Curaçao，北美洲，CW，CUW，531） <br />
    /// Cosmos i18n code: i18n_country_kusuola <br />
    /// Cosmos region code: 400112
    /// </summary>
    public static class Curaçao
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Curaçao()
        {
            _country = new CountryInfo
            {
                Country = Country.Curaçao,
                CountryCode = CountryCode.CW,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.Netherlands,
                M49Code = "531",
                Cep1CrCode = 4_00_112,
                Alpha2Code = "CW",
                Alpha3Code = "CUW",
                Name = "Curaçao",
                ChineseName = "库拉索",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 库拉索（Curaçao，北美洲，CW，CUW，531） <br />
        /// Cosmos i18n code: i18n_country_kusuola <br />
        /// Cosmos region code: 400112
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kusuola";

        /// <summary>
        /// Get Cosmos Region Code (CEP-1/CRCode)
        /// </summary>
        public static long CosmosRegionCode => _country.Cep1CrCode;

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