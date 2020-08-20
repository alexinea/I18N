namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 科特迪瓦 （The Republic of Côte d'Ivoire，非洲，CI，CIV，384），科特迪瓦共和国 <br />
    /// Cosmos i18n code: i18n_country_ketediwa <br />
    /// Cosmos region code: 300114
    /// </summary>
    public static partial class CotedIvoire
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CotedIvoire()
        {
            _country = new CountryInfo
            {
                Country = Country.CotedIvoire,
                CountryCode = CountryCode.CI,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.CotedIvoire,
                M49Code = "384",
                Cep1CrCode = 3_00_114,
                Alpha2Code = "CI",
                Alpha3Code = "CIV",
                Name = "The Republic of Côte d'Ivoire",
                ShorterForm = "Côte d'Ivoire",
                ChineseName = "科特迪瓦共和国",
                ChineseShorterForm = "科特迪瓦",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 科特迪瓦 （The Republic of Côte d'Ivoire，非洲，CI，CIV，384），科特迪瓦共和国 <br />
        /// Cosmos i18n code: i18n_country_ketediwa <br />
        /// Cosmos region code: 300114
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_ketediwa";

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