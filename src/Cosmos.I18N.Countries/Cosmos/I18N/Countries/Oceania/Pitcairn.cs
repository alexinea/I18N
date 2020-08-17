namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 皮特肯岛（Pitcairn Islands，大洋洲，PN，PCN，612），皮特凯恩群岛 <br />
    /// Cosmos i18n code: i18n_country_piteken <br />
    /// Cosmos region code: 600117
    /// </summary>
    public static class Pitcairn {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Pitcairn() {
            _country = new CountryInfo {
                Country = Country.Pitcairn,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "612",
                CRCode = 6_00_117,
                Alpha2Code = "PN",
                Alpha3Code = "PCN",
                Name = "Pitcairn Islands",
                ShorterForm = "Pitcairn",
                ChineseName = "皮特凯恩群岛",
                ChineseShorterForm = "皮特肯岛",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 皮特肯岛（Pitcairn Islands，大洋洲，PN，PCN，612），皮特凯恩群岛 <br />
        /// Cosmos i18n code: i18n_country_piteken <br />
        /// Cosmos region code: 600117
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_piteken";

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