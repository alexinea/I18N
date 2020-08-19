namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 斯里兰卡（The Democratic Socialist Republic of Sri Lanka，亚洲，LK，LKA，144），斯里兰卡民主社会主义共和国 <br />
    /// Cosmos i18n code: i18n_country_sililanka <br />
    /// Cosmos region code: 100135
    /// </summary>
    public static partial class SriLanka
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SriLanka()
        {
            _country = new CountryInfo
            {
                Country = Country.SriLanka,
                CountryCode = CountryCode.LK,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.SriLanka,
                M49Code = "144",
                CRCode = 1_00_135,
                Alpha2Code = "LK",
                Alpha3Code = "LKA",
                Name = "The Democratic Socialist Republic of Sri Lanka",
                ShorterForm = "Sri Lanka",
                ChineseName = "斯里兰卡民主社会主义共和国",
                ChineseShorterForm = "斯里兰卡",
                Continent = Continent.Asia,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 斯里兰卡（The Democratic Socialist Republic of Sri Lanka，亚洲，LK，LKA，144），斯里兰卡民主社会主义共和国 <br />
        /// Cosmos i18n code: i18n_country_sililanka <br />
        /// Cosmos region code: 100135
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_sililanka";

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