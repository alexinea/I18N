namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 塞浦路斯（The Republic of Cyprus，亚洲，CY，CYP，196），塞浦路斯共和国 <br />
    /// Cosmos i18n code: i18n_country_saipulusi <br />
    /// Cosmos region code: 100112
    /// </summary>
    public static partial class Cyprus
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Cyprus()
        {
            _country = new CountryInfo
            {
                Country = Country.Cyprus,
                CountryCode = CountryCode.CY,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Cyprus,
                M49Code = "196",
                Cep1CrCode = 1_00_112,
                Alpha2Code = "CY",
                Alpha3Code = "CYP",
                Name = "The Republic of Cyprus",
                ShorterForm = "Cyprus",
                ChineseName = "塞浦路斯共和国",
                ChineseShorterForm = "塞浦路斯",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 塞浦路斯（The Republic of Cyprus，亚洲，CY，CYP，196），塞浦路斯共和国 <br />
        /// Cosmos i18n code: i18n_country_saipulusi <br />
        /// Cosmos region code: 100112
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_saipulusi";

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