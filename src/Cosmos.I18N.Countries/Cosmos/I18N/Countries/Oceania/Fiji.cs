namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 斐济（The Republic of Fiji，大洋洲，FJ，FJI，242），斐济共和国 <br />
    /// Cosmos i18n code: i18n_country_feiji <br />
    /// Cosmos region code: 600103
    /// </summary>
    public static class Fiji {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Fiji() {
            _country = new CountryInfo {
                Country = Country.Fiji,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Fiji,
                M49Code = "242",
                CRCode = 6_00_103,
                Alpha2Code = "FJ",
                Alpha3Code = "FJI",
                Name = "The Republic of Fiji",
                ShorterForm = "Fiji",
                ChineseName = "斐济共和国",
                ChineseShorterForm = "斐济",
                Continent = Continent.Oceania,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 斐济（The Republic of Fiji，大洋洲，FJ，FJI，242），斐济共和国 <br />
        /// Cosmos i18n code: i18n_country_feiji <br />
        /// Cosmos region code: 600103
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_feiji";

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