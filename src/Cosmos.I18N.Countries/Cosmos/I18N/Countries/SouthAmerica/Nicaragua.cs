namespace Cosmos.I18N.Countries.SouthAmerica {
    /// <summary>
    /// 尼加拉瓜（The Republic of Nicaragua，南美洲，NI，NIC，558），尼加拉瓜共和国 <br />
    /// Cosmos i18n code: i18n_country_nijialagua <br />
    /// Cosmos region code: 500108
    /// </summary>
    public static class Nicaragua {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Nicaragua() {
            _country = new CountryInfo {
                Country = Country.Nicaragua,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Nicaragua,
                M49Code = "558",
                CRCode = 5_00_108,
                Alpha2Code = "NI",
                Alpha3Code = "NIC",
                Name = "The Republic of Nicaragua",
                ShorterForm = "Nicaragua",
                ChineseName = "尼加拉瓜共和国",
                ChineseShorterForm = "尼加拉瓜",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 尼加拉瓜（The Republic of Nicaragua，南美洲，NI，NIC，558），尼加拉瓜共和国 <br />
        /// Cosmos i18n code: i18n_country_nijialagua <br />
        /// Cosmos region code: 500108
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nijialagua";

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