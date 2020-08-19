namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 圣多美和普林西比（The Democratic Republic of Sao Tome and Principe，非洲，ST，STP，678），圣多美和普林西比民主共和国 <br />
    /// Cosmos i18n code: i18n_country_shengduomeiplxb <br />
    /// Cosmos region code: 300148
    /// </summary>
    public static  partial class SaoTomeAndPrincipe {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaoTomeAndPrincipe() {
            _country = new CountryInfo {
                Country = Country.SaoTomeAndPrincipe,
                CountryCode = CountryCode.ST,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.SaoTomeAndPrincipe,
                M49Code = "678",
                CRCode = 3_00_148,
                Alpha2Code = "ST",
                Alpha3Code = "STP",
                Name = "The Democratic Republic of Sao Tome and Principe",
                ShorterForm = "Sao Tome and Principe",
                ChineseName = "圣多美和普林西比民主共和国",
                ChineseShorterForm = "圣多美和普林西比",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 圣多美和普林西比（The Democratic Republic of Sao Tome and Principe，非洲，ST，STP，678），圣多美和普林西比民主共和国 <br />
        /// Cosmos i18n code: i18n_country_shengduomeiplxb <br />
        /// Cosmos region code: 300148
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengduomeiplxb";

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