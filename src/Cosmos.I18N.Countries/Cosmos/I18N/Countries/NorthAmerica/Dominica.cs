namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 多米尼克（The Commonwealth of Dominica，北美洲，DM，DMA，212），多米尼克国 <br />
    /// Cosmos i18n code: i18n_country_duominike <br />
    /// Cosmos region code: 400113
    /// </summary>
    public static partial class Dominica
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Dominica()
        {
            _country = new CountryInfo
            {
                Country = Country.Dominica,
                CountryCode = CountryCode.DM,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Dominica,
                M49Code = "212",
                Cep1CrCode = 4_00_113,
                Alpha2Code = "DM",
                Alpha3Code = "DMA",
                Name = "The Commonwealth of Dominica",
                ShorterForm = "Dominica",
                ChineseName = "多米尼克国",
                ChineseShorterForm = "多米尼克",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 多米尼克（The Commonwealth of Dominica，北美洲，DM，DMA，212），多米尼克国 <br />
        /// Cosmos i18n code: i18n_country_duominike <br />
        /// Cosmos region code: 400113
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_duominike";

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