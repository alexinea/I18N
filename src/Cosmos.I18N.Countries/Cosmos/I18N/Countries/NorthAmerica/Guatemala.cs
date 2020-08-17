namespace Cosmos.I18N.Countries.NorthAmerica {
    /// <summary>
    /// 危地马拉（The Republic of Guatemala，北美洲，GT，GTM，320），危地马拉共和国 <br />
    /// Cosmos i18n code: i18n_country_weidimala <br />
    /// Cosmos region code: 400119
    /// </summary>
    public static class Guatemala {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guatemala() {
            _country = new CountryInfo {
                Country = Country.Guatemala,
                CountryCode = CountryCode.GT,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Guatemala,
                M49Code = "320",
                CRCode = 4_00_119,
                Alpha2Code = "GT",
                Alpha3Code = "GTM",
                Name = "The Republic of Guatemala",
                ShorterForm = "Guatemala",
                ChineseName = "危地马拉共和国",
                ChineseShorterForm = "危地马拉",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 危地马拉（The Republic of Guatemala，北美洲，GT，GTM，320），危地马拉共和国 <br />
        /// Cosmos i18n code: i18n_country_weidimala <br />
        /// Cosmos region code: 400119
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_weidimala";

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