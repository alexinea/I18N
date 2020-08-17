namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 安哥拉（Angola，非洲，AO，AGO，024），安哥拉共和国 <br />
    /// Cosmos i18n code: i18n_country_angela <br />
    /// Cosmos region code: 300102
    /// </summary>
    public static class Angola {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Angola() {
            _country = new CountryInfo {
                Country = Country.Angola,
                CountryCode = CountryCode.AO,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Angola,
                M49Code = "024",
                CRCode = 3_00_102,
                Alpha2Code = "AO",
                Alpha3Code = "AGO",
                Name = "The Republic of Angola",
                ShorterForm = "Angola",
                ChineseName = "安哥拉共和国",
                ChineseShorterForm = "安哥拉",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 安哥拉（Angola，非洲，AO，AGO，024），安哥拉共和国 <br />
        /// Cosmos i18n code: i18n_country_angela <br />
        /// Cosmos region code: 300102
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_angela";

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