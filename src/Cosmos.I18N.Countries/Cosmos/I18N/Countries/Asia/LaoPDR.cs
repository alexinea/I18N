namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 老挝（Lao People's Democratic Republic，亚洲，LA，LAO，418），老挝人民民主共和国 <br />
    /// Cosmos i18n code: i18n_country_laowo <br />
    /// Cosmos region code: 100122
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public static partial class LaoPDR
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static LaoPDR()
        {
            _country = new CountryInfo
            {
                Country = Country.LaoPDR,
                CountryCode = CountryCode.LA,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.LaoPDR,
                M49Code = "418",
                Cep1CrCode = 1_00_122,
                Alpha2Code = "LA",
                Alpha3Code = "LAO",
                Name = "Lao People's Democratic Republic",
                ShorterForm = "LaoPDR",
                ChineseName = "老挝人民民主共和国",
                ChineseShorterForm = "老挝",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 老挝（Lao People's Democratic Republic，亚洲，LA，LAO，418），老挝人民民主共和国 <br />
        /// Cosmos i18n code: i18n_country_laowo <br />
        /// Cosmos region code: 100122
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_laowo";

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