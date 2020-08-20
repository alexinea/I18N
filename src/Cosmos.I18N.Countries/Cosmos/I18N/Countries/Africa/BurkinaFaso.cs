namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 布基纳法索（Burkina Faso，非洲，BF，BFA，854） <br />
    /// Cosmos i18n code: i18n_country_bujinafaso <br />
    /// Cosmos region code: 300105
    /// </summary>
    public static partial class BurkinaFaso
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static BurkinaFaso()
        {
            _country = new CountryInfo
            {
                Country = Country.BurkinaFaso,
                CountryCode = CountryCode.BF,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.BurkinaFaso,
                M49Code = "854",
                Cep1CrCode = 3_00_105,
                Alpha2Code = "BF",
                Alpha3Code = "BFA",
                Name = "Burkina Faso",
                ChineseName = "布基纳法索",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 布基纳法索（Burkina Faso，非洲，BF，BFA，854） <br />
        /// Cosmos i18n code: i18n_country_bujinafaso <br />
        /// Cosmos region code: 300105
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bujinafaso";

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