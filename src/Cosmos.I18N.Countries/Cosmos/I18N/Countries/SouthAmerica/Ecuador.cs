namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// 厄瓜多尔（The Republic of Ecuador，南美洲，EC，ECU，218），厄瓜多尔共和国 <br />
    /// Cosmos i18n code: i18n_country_eguaduoer <br />
    /// Cosmos region code: 500103
    /// </summary>
    public static class Ecuador {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Ecuador() {
            _country = new CountryInfo {
                Country = Country.Ecuador,
                CountryCode = CountryCode.EC,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Ecuador,
                M49Code = "218",
                CRCode = 5_00_103,
                Alpha2Code = "EC",
                Alpha3Code = "ECU",
                Name = "The Republic of Ecuador",
                ShorterForm = "Ecuador",
                ChineseName = "厄瓜多尔共和国",
                ChineseShorterForm = "厄瓜多尔",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 厄瓜多尔（The Republic of Ecuador，南美洲，EC，ECU，218），厄瓜多尔共和国 <br />
        /// Cosmos i18n code: i18n_country_eguaduoer <br />
        /// Cosmos region code: 500103
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_eguaduoer";

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