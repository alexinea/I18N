namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 秘鲁（The Republic of Peru，南美洲，PE，PER，604），秘鲁共和国 <br />
    /// Cosmos i18n code: i18n_country_bilu <br />
    /// Cosmos region code: 500110
    /// </summary>
    public static partial class Peru
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Peru()
        {
            _country = new CountryInfo
            {
                Country = Country.Peru,
                CountryCode = CountryCode.PE,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Peru,
                M49Code = "604",
                Cep1CrCode = 5_00_110,
                Alpha2Code = "PE",
                Alpha3Code = "PER",
                Name = "The Republic of Peru",
                ShorterForm = "Peru",
                ChineseName = "秘鲁共和国",
                ChineseShorterForm = "秘鲁",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 秘鲁（The Republic of Peru，南美洲，PE，PER，604），秘鲁共和国 <br />
        /// Cosmos i18n code: i18n_country_bilu <br />
        /// Cosmos region code: 500110
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bilu";

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