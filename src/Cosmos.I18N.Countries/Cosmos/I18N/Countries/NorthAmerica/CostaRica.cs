namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 哥斯达黎加（The Republic of Costa Rica，北美洲，CR，CRI，188），哥斯达黎加共和国 <br />
    /// Cosmos i18n code: i18n_country_gesidalijia <br />
    /// Cosmos region code: 400111
    /// </summary>
    public static partial class CostaRica
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CostaRica()
        {
            _country = new CountryInfo
            {
                Country = Country.CostaRica,
                CountryCode = CountryCode.CR,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.CostaRica,
                M49Code = "188",
                Cep1CrCode = 4_00_111,
                Alpha2Code = "CR",
                Alpha3Code = "CRI",
                Name = "The Republic of Costa Rica",
                ShorterForm = "Costa Rica",
                ChineseName = "哥斯达黎加共和国",
                ChineseShorterForm = "哥斯达黎加",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 哥斯达黎加（The Republic of Costa Rica，北美洲，CR，CRI，188），哥斯达黎加共和国 <br />
        /// Cosmos i18n code: i18n_country_gesidalijia <br />
        /// Cosmos region code: 400111
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gesidalijia";

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