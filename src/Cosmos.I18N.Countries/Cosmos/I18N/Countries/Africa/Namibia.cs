using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 纳米比亚（The Republic of Namibia，非洲，NA，NAM，516），纳米比亚共和国 <br />
    /// Cosmos i18n code: i18n_country_manibiya <br />
    /// Cosmos region code: 300141
    /// </summary>
    public static class Namibia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Namibia()
        {
            _country = new CountryInfo
            {
                Country = Country.Namibia,
                CountryCode = CountryCode.NA,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Namibia,
                M49Code = "516",
                Cep1CrCode = 3_00_141,
                Alpha2Code = "NA",
                Alpha3Code = "NAM",
                Name = "The Republic of Namibia",
                ShorterForm = "Namibia",
                ChineseName = "纳米比亚共和国",
                ChineseShorterForm = "纳米比亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 纳米比亚（The Republic of Namibia，非洲，NA，NAM，516），纳米比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_manibiya <br />
        /// Cosmos region code: 300141
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_manibiya";

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