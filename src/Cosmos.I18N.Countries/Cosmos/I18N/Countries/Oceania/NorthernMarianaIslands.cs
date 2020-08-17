namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 北马里亚那群岛（Commonwealth of the Northern Mariana Islands，大洋洲，MP，MNP，580），北马里亚纳群岛自由邦 <br />
    /// Cosmos i18n code: i18n_country_beimaliyana <br />
    /// Cosmos region code: 600112
    /// </summary>
    public static class NorthernMarianaIslands {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static NorthernMarianaIslands() {
            _country = new CountryInfo {
                Country = Country.NorthernMarianaIslands,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedStates,
                M49Code = "580",
                CRCode = 6_00_112,
                Alpha2Code = "MP",
                Alpha3Code = "MNP",
                Name = "Commonwealth of the Northern Mariana Islands",
                ShorterForm = "Northern Mariana Islands",
                ChineseName = "北马里亚纳群岛自由邦",
                ChineseShorterForm = "北马里亚那群岛",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 北马里亚那群岛（Commonwealth of the Northern Mariana Islands，大洋洲，MP，MNP，580），北马里亚纳群岛自由邦 <br />
        /// Cosmos i18n code: i18n_country_beimaliyana <br />
        /// Cosmos region code: 600112
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_beimaliyana";

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