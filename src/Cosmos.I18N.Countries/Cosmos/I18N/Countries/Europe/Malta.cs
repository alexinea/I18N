namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 马耳他（Republic of Malta，欧洲，MT，MLT，470），马耳他共和国 <br />
    /// Cosmos i18n code: i18n_country_maerta <br />
    /// Cosmos region code: 200126
    /// </summary>
    public static class Malta {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Malta() {
            _country = new CountryInfo {
                Country = Country.Malta,
                CountryCode = CountryCode.MT,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Malta,
                M49Code = "470",
                CRCode = 2_00_126,
                Alpha2Code = "MT",
                Alpha3Code = "MLT",
                Name = "Republic of Malta",
                ShorterForm = "Malta",
                ChineseName = "马耳他共和国",
                ChineseShorterForm = "马耳他",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 马耳他（Republic of Malta，欧洲，MT，MLT，470），马耳他共和国 <br />
        /// Cosmos i18n code: i18n_country_maerta <br />
        /// Cosmos region code: 200126
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_maerta";

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