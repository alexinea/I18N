using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 乌拉圭（The Oriental Republic of Uruguay，南美洲，UY，URY，858），乌拉圭东岸共和国 <br />
    /// Cosmos i18n code: i18n_country_wulagui <br />
    /// Cosmos region code: 500112
    /// </summary>
    public static class Uruguay
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Uruguay()
        {
            _country = new CountryInfo
            {
                Country = Country.Uruguay,
                CountryCode = CountryCode.UY,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Uruguay,
                M49Code = "858",
                Cep1CrCode = 5_00_112,
                Alpha2Code = "UY",
                Alpha3Code = "URY",
                Name = "The Oriental Republic of Uruguay",
                ShorterForm = "Uruguay",
                ChineseName = "乌拉圭东岸共和国",
                ChineseShorterForm = "乌拉圭",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 乌拉圭（The Oriental Republic of Uruguay，南美洲，UY，URY，858），乌拉圭东岸共和国 <br />
        /// Cosmos i18n code: i18n_country_wulagui <br />
        /// Cosmos region code: 500112
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_wulagui";

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