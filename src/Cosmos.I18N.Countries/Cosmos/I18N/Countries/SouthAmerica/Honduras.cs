using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 洪都拉斯（The Republic of Honduras，南美洲，HN，HND，340），洪都拉斯共和国 <br />
    /// Cosmos i18n code: i18n_country_hongdulasi <br />
    /// Cosmos region code: 500107
    /// </summary>
    public static class Honduras
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Honduras()
        {
            _country = new CountryInfo
            {
                Country = Country.Honduras,
                CountryCode = CountryCode.HN,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Honduras,
                M49Code = "340",
                Cep1CrCode = 5_00_107,
                Alpha2Code = "HN",
                Alpha3Code = "HND",
                Name = "The Republic of Honduras",
                ShorterForm = "Honduras",
                ChineseName = "洪都拉斯共和国",
                ChineseShorterForm = "洪都拉斯",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 洪都拉斯（The Republic of Honduras，南美洲，HN，HND，340），洪都拉斯共和国 <br />
        /// Cosmos i18n code: i18n_country_hongdulasi <br />
        /// Cosmos region code: 500107
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_hongdulasi";

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