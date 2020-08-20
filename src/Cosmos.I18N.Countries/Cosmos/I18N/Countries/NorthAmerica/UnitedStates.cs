namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 美国（United States of America，北美洲，US，USA，840），美利坚合众国 <br />
    /// Cosmos i18n code: i18n_country_meiguo <br />
    /// Cosmos region code: 400001
    /// </summary>
    public static partial class UnitedStates
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static UnitedStates()
        {
            _country = new CountryInfo
            {
                Country = Country.UnitedStates,
                CountryCode = CountryCode.US,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.UnitedStates,
                M49Code = "840",
                Cep1CrCode = 4_00_001,
                Alpha2Code = "US",
                Alpha3Code = "USA",
                Name = "United States of America",
                ShorterForm = "United States",
                ChineseName = "美利坚合众国",
                ChineseShorterForm = "美国",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 美国（United States of America，北美洲，US，USA，840），美利坚合众国 <br />
        /// Cosmos i18n code: i18n_country_meiguo <br />
        /// Cosmos region code: 400001
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_meiguo";

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