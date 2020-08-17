namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 摩尔多瓦（Republic of Moldova，欧洲，MD，MDA，498），摩尔多瓦共和国 <br />
    /// Cosmos i18n code: i18n_country_moerduowa <br />
    /// Cosmos region code: 200128
    /// </summary>
    public static class Moldova {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Moldova() {
            _country = new CountryInfo {
                Country = Country.Moldova,
                CountryCode = CountryCode.MD,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Moldova,
                M49Code = "498",
                CRCode = 2_00_128,
                Alpha2Code = "MD",
                Alpha3Code = "MDA",
                Name = "Republic of Moldova",
                ShorterForm = "Moldova",
                ChineseName = "摩尔多瓦共和国",
                ChineseShorterForm = "摩尔多瓦",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 摩尔多瓦（Republic of Moldova，欧洲，MD，MDA，498），摩尔多瓦共和国 <br />
        /// Cosmos i18n code: i18n_country_moerduowa <br />
        /// Cosmos region code: 200128
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_moerduowa";

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