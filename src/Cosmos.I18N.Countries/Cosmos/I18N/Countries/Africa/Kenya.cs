using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 肯尼亚（The Republic Of Kenya，非洲，KE，KEN，404），肯尼亚共和国 <br />
    /// Cosmos i18n code: i18n_country_kenniya <br />
    /// Cosmos region code: 300012
    /// </summary>
    public static class Kenya
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Kenya()
        {
            _country = new CountryInfo
            {
                Country = Country.Kenya,
                CountryCode = CountryCode.KE,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Kenya,
                M49Code = "404",
                Cep1CrCode = 3_00_012,
                Alpha2Code = "KE",
                Alpha3Code = "KEN",
                Name = "The Republic Of Kenya",
                ShorterForm = "Kenya",
                ChineseName = "肯尼亚共和国",
                ChineseShorterForm = "肯尼亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 肯尼亚（The Republic Of Kenya，非洲，KE，KEN，404），肯尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_kenniya <br />
        /// Cosmos region code: 300012
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kenniya";

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