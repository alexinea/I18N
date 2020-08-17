namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 巴哈马（Commonwealth of the Bahamas，北美洲，BS，BHS，044），巴哈马国 <br />
    /// Cosmos i18n code: i18n_country_bahama <br />
    /// Cosmos region code: 400105
    /// </summary>
    public static class Bahamas {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Bahamas() {
            _country = new CountryInfo {
                Country = Country.Bahamas,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Bahamas,
                M49Code = "044",
                CRCode = 4_00_105,
                Alpha2Code = "BS",
                Alpha3Code = "BHS",
                Name = "Commonwealth of the Bahamas",
                ShorterForm = "Bahamas",
                ChineseName = "巴哈马国",
                ChineseShorterForm = "巴哈马",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 巴哈马（Commonwealth of the Bahamas，北美洲，BS，BHS，044），巴哈马国 <br />
        /// Cosmos i18n code: i18n_country_bahama <br />
        /// Cosmos region code: 400105
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bahama";

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