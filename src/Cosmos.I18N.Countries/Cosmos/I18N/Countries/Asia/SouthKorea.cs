namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 韩国（Republic Of Korea，亚洲，KR，KOR，410），大韩民国 <br />
    /// Cosmos i18n code: i18n_country_hanguo <br />
    /// Cosmos region code: 100012
    /// </summary>
    public static partial class SouthKorea
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SouthKorea()
        {
            _country = new CountryInfo
            {
                Country = Country.SouthKorea,
                CountryCode = CountryCode.KR,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.SouthKorea,
                M49Code = "410",
                Cep1CrCode = 1_00_012,
                Alpha2Code = "KR",
                Alpha3Code = "KOR",
                Name = "Republic Of Korea",
                ShorterForm = "South Korea",
                ChineseName = "大韩民国",
                ChineseShorterForm = "韩国",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 韩国（Republic Of Korea，亚洲，KR，KOR，410），大韩民国 <br />
        /// Cosmos i18n code: i18n_country_hanguo <br />
        /// Cosmos region code: 100012
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_hanguo";

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