namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 克罗地亚（Republic of Croatia，欧洲，HR，HRV，191），克罗地亚共和国 <br />
    /// Cosmos i18n code: i18n_country_keluodiya <br />
    /// Cosmos region code: 200109
    /// </summary>
    public static class Croatia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Croatia() {
            _country = new CountryInfo {
                Country = Country.Croatia,
                CountryCode = CountryCode.HR,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Croatia,
                M49Code = "191",
                CRCode = 2_00_109,
                Alpha2Code = "HR",
                Alpha3Code = "HRV",
                Name = "Republic of Croatia",
                ShorterForm = "Croatia",
                ChineseName = "克罗地亚共和国",
                ChineseShorterForm = "克罗地亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 克罗地亚（Republic of Croatia，欧洲，HR，HRV，191），克罗地亚共和国 <br />
        /// Cosmos i18n code: i18n_country_keluodiya <br />
        /// Cosmos region code: 200109
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_keluodiya";

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