namespace Cosmos.I18N.Countries.Asia {
    /// <summary>
    /// 越南（Socialist Republic of Vietnam，亚洲，VN，VNM，704），越南社会主义共和国 <br />
    /// Cosmos i18n code: i18n_country_yuenan <br />
    /// Cosmos region code: 100018
    /// </summary>
    public static class Vietnam {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Vietnam() {
            _country = new CountryInfo {
                Country = Country.Vietnam,
                CountryCode = CountryCode.VN,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Vietnam,
                M49Code = "704",
                CRCode = 1_00_018,
                Alpha2Code = "VN",
                Alpha3Code = "VNM",
                Name = "Socialist Republic of Vietnam",
                ShorterForm = "Vietnam",
                ChineseName = "越南社会主义共和国",
                ChineseShorterForm = "越南",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 越南（Socialist Republic of Vietnam，亚洲，VN，VNM，704），越南社会主义共和国 <br />
        /// Cosmos i18n code: i18n_country_yuenan <br />
        /// Cosmos region code: 100018
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yuenan";

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