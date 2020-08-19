namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 贝宁（The Republic of Benin，非洲，BJ，BEN，204），贝宁共和国 <br />
    /// Cosmos i18n code: i18n_country_beining <br />
    /// Cosmos region code: 300103
    /// </summary>
    public static partial class Benin
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Benin()
        {
            _country = new CountryInfo
            {
                Country = Country.Benin,
                CountryCode = CountryCode.BJ,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Benin,
                M49Code = "204",
                CRCode = 3_00_103,
                Alpha2Code = "BJ",
                Alpha3Code = "BEN",
                Name = "The Republic of Benin",
                ShorterForm = "Benin",
                ChineseName = "贝宁共和国",
                ChineseShorterForm = "贝宁",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 贝宁（The Republic of Benin，非洲，BJ，BEN，204），贝宁共和国 <br />
        /// Cosmos i18n code: i18n_country_beining <br />
        /// Cosmos region code: 300103
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_beining";

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