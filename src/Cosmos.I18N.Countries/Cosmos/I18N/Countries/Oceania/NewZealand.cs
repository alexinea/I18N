namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 新西兰（New Zealand，大洋洲，NZ，NZL，554） <br />
    /// Cosmos i18n code: i18n_country_xinxilan <br />
    /// Cosmos region code: 600012
    /// </summary>
    public static partial class NewZealand
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static NewZealand()
        {
            _country = new CountryInfo
            {
                Country = Country.NewZealand,
                CountryCode = CountryCode.NZ,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.NewZealand,
                M49Code = "554",
                Cep1CrCode = 6_00_012,
                Alpha2Code = "NZ",
                Alpha3Code = "NZL",
                Name = "New Zealand",
                ChineseName = "新西兰",
                ChineseAlias = "纽西兰",
                Continent = Continent.Oceania,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 新西兰（New Zealand，大洋洲，NZ，NZL，554） <br />
        /// Cosmos i18n code: i18n_country_xinxilan <br />
        /// Cosmos region code: 600012
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xinxilan";

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