namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 圣赫勒拿、阿森松与特里斯坦达库尼亚（Saint Helena, Ascension and Tristan da Cunha，非洲，SH，SHN，654） <br />
    /// Cosmos i18n code: i18n_country_shenghelena <br />
    /// Cosmos region code: 300121
    /// </summary>
    public static class SaintHelena {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaintHelena() {
            _country = new CountryInfo {
                Country = Country.SaintHelena,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "654",
                CRCode = 3_00_121,
                Alpha2Code = "SH",
                Alpha3Code = "SHN",
                Name = "Saint Helena, Ascension and Tristan da Cunha",
                ChineseName = "圣赫勒拿、阿森松与特里斯坦达库尼亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣赫勒拿、阿森松与特里斯坦达库尼亚（Saint Helena, Ascension and Tristan da Cunha，非洲，SH，SHN，654） <br />
        /// Cosmos i18n code: i18n_country_shenghelena <br />
        /// Cosmos region code: 300121
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shenghelena";

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