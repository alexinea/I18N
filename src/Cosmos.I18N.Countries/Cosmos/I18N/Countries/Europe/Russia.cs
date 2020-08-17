namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 俄罗斯（Russian Federation，欧洲，BI，BDI，108），俄罗斯联邦 <br />
    /// Cosmos i18n code: i18n_country_eluosi <br />
    /// Cosmos region code: 200004
    /// </summary>
    public static class Russia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Russia() {
            _country = new CountryInfo {
                Country = Country.Russia,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Russia,
                M49Code = "643",
                CRCode = 2_00_004,
                Alpha2Code = "RU",
                Alpha3Code = "RUS",
                Name = "Russian Federation",
                ShorterForm = "Russia",
                ChineseName = "俄罗斯联邦",
                ChineseShorterForm = "俄罗斯",
                ChineseAlias = "俄联邦",
                ChineseAlias2 = "俄国",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 俄罗斯（Russian Federation，欧洲，BI，BDI，108），俄罗斯联邦 <br />
        /// Cosmos i18n code: i18n_country_eluosi <br />
        /// Cosmos region code: 200004
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_eluosi";

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