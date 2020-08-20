namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 阿联酋（United Arab Emirates，亚洲，AE，ARE，784），阿拉伯联合酋长国 <br />
    /// 又名 阿拉伯联合大公国 <br />
    /// Cosmos i18n code: i18n_country_alianqiu <br />
    /// Cosmos region code: 100140
    /// </summary>
    public static partial class UnitedArabEmirates
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static UnitedArabEmirates()
        {
            _country = new CountryInfo
            {
                Country = Country.UnitedArabEmirates,
                CountryCode = CountryCode.AE,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.UnitedArabEmirates,
                M49Code = "784",
                Cep1CrCode = 1_00_140,
                Alpha2Code = "AE",
                Alpha3Code = "ARE",
                Name = "United Arab Emirates",
                ChineseName = "阿拉伯联合酋长国",
                ChineseShorterForm = "阿联酋",
                ChineseAlias = "阿拉伯联合大公国",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 阿联酋（United Arab Emirates，亚洲，AE，ARE，784），阿拉伯联合酋长国 <br />
        /// 又名 阿拉伯联合大公国 <br />
        /// Cosmos i18n code: i18n_country_alianqiu <br />
        /// Cosmos region code: 100140
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_alianqiu";

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