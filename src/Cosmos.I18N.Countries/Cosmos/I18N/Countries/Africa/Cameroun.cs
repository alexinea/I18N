namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 喀麦隆（Republic of Cameroon，非洲，CM，CRM，120），喀麦隆共和国 <br />
    /// Cosmos i18n code: i18n_country_kamailong <br />
    /// Cosmos region code: 300108
    /// </summary>
    public static partial class Cameroun
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Cameroun()
        {
            _country = new CountryInfo
            {
                Country = Country.Cameroun,
                CountryCode = CountryCode.CM,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Cameroun,
                M49Code = "120",
                CRCode = 3_00_108,
                Alpha2Code = "CM",
                Alpha3Code = "CMR",
                Name = "Republic of Cameroon",
                ShorterForm = "Cameroun",
                ChineseName = "喀麦隆共和国",
                ChineseShorterForm = "喀麦隆",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 喀麦隆（Republic of Cameroon，非洲，CM，CRM，120），喀麦隆共和国 <br />
        /// Cosmos i18n code: i18n_country_kamailong <br />
        /// Cosmos region code: 300108
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_kamailong";

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
