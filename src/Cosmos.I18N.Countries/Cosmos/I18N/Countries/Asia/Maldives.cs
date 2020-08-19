namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 马尔代夫（The Republic of Maldives，亚洲，MV，MDV，462），马尔代夫共和国 <br />
    /// Cosmos i18n code: i18n_country_maerdaifu <br />
    /// Cosmos region code: 100125
    /// </summary>
    public static partial class Maldives
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Maldives()
        {
            _country = new CountryInfo
            {
                Country = Country.Maldives,
                CountryCode = CountryCode.MV,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Maldives,
                M49Code = "462",
                CRCode = 1_00_125,
                Alpha2Code = "MV",
                Alpha3Code = "MDV",
                Name = "The Republic of Maldives",
                ShorterForm = "Maldives",
                ChineseName = "马尔代夫共和国",
                ChineseShorterForm = "马尔代夫",
                ChineseAlias = "马尔代夫群岛",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 马尔代夫（The Republic of Maldives，亚洲，MV，MDV，462），马尔代夫共和国 <br />
        /// Cosmos i18n code: i18n_country_maerdaifu <br />
        /// Cosmos region code: 100125
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_maerdaifu";

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