namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 圣皮埃尔和密克隆群岛（The Islands of Saint Pierre and Miquelon，北美洲，PM，SPM，666），法国海外领土 <br />
    /// Cosmos i18n code: i18n_country_shengyiaiermkl <br />
    /// Cosmos region code: 400132
    /// </summary>
    public static class SaintPierreAndMiquelon {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaintPierreAndMiquelon() {
            _country = new CountryInfo {
                Country = Country.SaintPierreAndMiquelon,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.France,
                M49Code = "666",
                CRCode = 4_00_132,
                Alpha2Code = "PM",
                Alpha3Code = "SPM",
                Name = "The Islands of Saint Pierre and Miquelon",
                ShorterForm = "Saint Pierre and Miquelon",
                ChineseName = "圣皮埃尔和密克隆群岛",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣皮埃尔和密克隆群岛（The Islands of Saint Pierre and Miquelon，北美洲，PM，SPM，666），法国海外领土 <br />
        /// Cosmos i18n code: i18n_country_shengyiaiermkl <br />
        /// Cosmos region code: 400132
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengyiaiermkl";

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