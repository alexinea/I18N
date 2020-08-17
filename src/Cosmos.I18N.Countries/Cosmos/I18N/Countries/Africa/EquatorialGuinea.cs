namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 赤道几内亚（The Republic of Equatorial Guinea，非洲，GQ，GNQ，226），赤道几内亚共和国 <br />
    /// Cosmos i18n code: i18n_country_chidaojineiya <br />
    /// Cosmos region code: 300115
    /// </summary>
    public static class EquatorialGuinea {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static EquatorialGuinea() {
            _country = new CountryInfo {
                Country = Country.EquatorialGuinea,
                CountryCode = CountryCode.GQ,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.EquatorialGuinea,
                M49Code = "226",
                CRCode = 3_00_115,
                Alpha2Code = "GQ",
                Alpha3Code = "GNQ",
                Name = "The Republic of Equatorial Guinea",
                ShorterForm = "Equatorial Guinea",
                ChineseName = "赤道几内亚共和国",
                ChineseShorterForm = "赤道几内亚",
                Alias = "赤几",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 赤道几内亚（The Republic of Equatorial Guinea，非洲，GQ，GNQ，226），赤道几内亚共和国 <br />
        /// Cosmos i18n code: i18n_country_chidaojineiya <br />
        /// Cosmos region code: 300115
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_chidaojineiya";

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