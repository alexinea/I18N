namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 加拿大（Canada，北美洲，CA，CAN，124），英联邦成员国 <br />
    /// Cosmos i18n code: i18n_country_jianada <br />
    /// Cosmos region code: 400011
    /// </summary>
    public static class Canada {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Canada() {
            _country = new CountryInfo {
                Country = Country.Canada,
                CountryCode = CountryCode.CA,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Canada,
                M49Code = "124",
                CRCode = 4_00_011,
                Alpha2Code = "CA",
                Alpha3Code = "CAN",
                Name = "Canada",
                ChineseName = "加拿大",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 加拿大（Canada，北美洲，CA，CAN，124），英联邦成员国 <br />
        /// Cosmos i18n code: i18n_country_jianada <br />
        /// Cosmos region code: 400011
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jianada";

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