using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 马奥霍（Territorial Collectivity of Mayotte ，非洲，YT，MYT，004），马约特岛 <br />
    /// Cosmos i18n code: i18n_country_mayuete <br />
    /// Cosmos region code: 300138
    /// </summary>
    public static class Mayotte
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Mayotte()
        {
            _country = new CountryInfo
            {
                Country = Country.Mayotte,
                CountryCode = CountryCode.YT,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.France,
                M49Code = "175",
                Cep1CrCode = 3_00_138,
                Alpha2Code = "YT",
                Alpha3Code = "MYT",
                Name = "Territorial Collectivity of Mayotte",
                ShorterForm = "Mahore",
                ChineseName = "马约特岛",
                ChineseShorterForm = "马奥霍",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 马奥霍（Territorial Collectivity of Mayotte ，非洲，YT，MYT，004），马约特岛 <br />
        /// Cosmos i18n code: i18n_country_mayuete <br />
        /// Cosmos region code: 300138
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_mayuete";

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