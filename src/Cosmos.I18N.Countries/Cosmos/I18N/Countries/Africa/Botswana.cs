namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 博茨瓦纳（The Republic of Botswana，非洲，BW，BWA，072），博茨瓦纳共和国 <br />
    /// Cosmos i18n code: i18n_country_boziwana <br />
    /// Cosmos region code: 300104
    /// </summary>
    public static partial class Botswana
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Botswana()
        {
            _country = new CountryInfo
            {
                Country = Country.Botswana,
                CountryCode = CountryCode.BW,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Botswana,
                M49Code = "072",
                CRCode = 3_00_104,
                Alpha2Code = "BW",
                Alpha3Code = "BWA",
                Name = "The Republic of Botswana",
                ShorterForm = "Burundi",
                ChineseName = "博茨瓦纳共和国",
                ChineseShorterForm = "博茨瓦纳",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 博茨瓦纳（The Republic of Botswana，非洲，BW，BWA，072），博茨瓦纳共和国 <br />
        /// Cosmos i18n code: i18n_country_boziwana <br />
        /// Cosmos region code: 300104
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_boziwana";

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