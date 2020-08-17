namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// 圭亚那（Cooperative Republic of Guyana，南美洲，GY，GUY，328），圭亚那合作共和国 <br />
    /// Cosmos i18n code: i18n_country_guiyana <br />
    /// Cosmos region code: 500106
    /// </summary>
    public static class Guyana {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guyana() {
            _country = new CountryInfo {
                Country = Country.Guyana,
                CountryCode = CountryCode.GY,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Guyana,
                M49Code = "328",
                CRCode = 5_00_106,
                Alpha2Code = "GY",
                Alpha3Code = "GUY",
                Name = "Cooperative Republic of Guyana",
                ShorterForm = "Guyana",
                ChineseName = "圭亚那合作共和国",
                ChineseShorterForm = "圭亚那",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圭亚那（Cooperative Republic of Guyana，南美洲，GY，GUY，328），圭亚那合作共和国 <br />
        /// Cosmos i18n code: i18n_country_guiyana <br />
        /// Cosmos region code: 500106
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_guiyana";

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