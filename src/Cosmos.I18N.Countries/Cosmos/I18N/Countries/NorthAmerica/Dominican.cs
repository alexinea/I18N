namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 多米尼加（The Dominican Republic，北美洲，DO，DOM，214），多米尼加共和国 <br />
    /// Cosmos i18n code: i18n_country_duominijia <br />
    /// Cosmos region code: 400114
    /// </summary>
    public static partial class Dominican
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Dominican()
        {
            _country = new CountryInfo
            {
                Country = Country.Dominican,
                CountryCode = CountryCode.DO,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Dominican,
                M49Code = "214",
                Cep1CrCode = 4_00_114,
                Alpha2Code = "DO",
                Alpha3Code = "DOM",
                Name = "The Dominican Republic",
                ShorterForm = "Dominican",
                ChineseName = "多米尼加共和国",
                ChineseShorterForm = "多米尼加",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 多米尼加（The Dominican Republic，北美洲，DO，DOM，214），多米尼加共和国 <br />
        /// Cosmos i18n code: i18n_country_duominijia <br />
        /// Cosmos region code: 400114
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_duominijia";

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