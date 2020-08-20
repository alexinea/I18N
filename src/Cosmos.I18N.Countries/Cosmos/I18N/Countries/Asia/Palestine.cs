namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 巴勒斯坦（The State of Palestine，亚洲，PS，PSE，275），巴勒斯坦国 <br />
    /// Cosmos i18n code: i18n_country_balesitan <br />
    /// Cosmos region code: 100130
    /// </summary>
    public static partial class Palestine
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Palestine()
        {
            _country = new CountryInfo
            {
                Country = Country.Palestine,
                CountryType = CountryType.Country,
                CountryCode = CountryCode.PS,
                BelongsToCountry = Country.Palestine,
                M49Code = "275",
                Cep1CrCode = 1_00_130,
                Alpha2Code = "PS",
                Alpha3Code = "PSE",
                Name = "The State of Palestine",
                ShorterForm = "Palestine",
                ChineseName = "巴勒斯坦国",
                ChineseShorterForm = "巴勒斯坦",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 巴勒斯坦（The State of Palestine，亚洲，PS，PSE，275），巴勒斯坦国 <br />
        /// Cosmos i18n code: i18n_country_balesitan <br />
        /// Cosmos region code: 100130
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_balesitan";

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