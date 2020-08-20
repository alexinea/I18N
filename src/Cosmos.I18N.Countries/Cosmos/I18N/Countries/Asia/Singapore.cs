namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 新加坡（Republic of Singapore，亚洲，SG，SGP，702），新加坡共和国 <br />
    /// Cosmos i18n code: i18n_country_xinjiapo <br />
    /// Cosmos region code: 100134
    /// </summary>
    public static partial class Singapore
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Singapore()
        {
            _country = new CountryInfo
            {
                Country = Country.Singapore,
                CountryCode = CountryCode.SG,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Singapore,
                M49Code = "702",
                Cep1CrCode = 1_00_134,
                Alpha2Code = "SG",
                Alpha3Code = "SGP",
                Name = "Republic of Singapore",
                ShorterForm = "Singapore",
                ChineseName = "新加坡共和国",
                ChineseShorterForm = "新加坡",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 新加坡（Republic of Singapore，亚洲，SG，SGP，702），新加坡共和国 <br />
        /// Cosmos i18n code: i18n_country_xinjiapo<br />
        /// Cosmos region code: 100134
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xinjiapo";

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