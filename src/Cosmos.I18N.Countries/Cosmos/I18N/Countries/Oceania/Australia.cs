namespace Cosmos.I18N.Countries.Oceania {
    /// <summary>
    /// 澳大利亚（The Commonwealth of Australia，大洋洲，AU，AUS，036），澳大利亚联邦 <br />
    /// Cosmos i18n code: i18n_country_aodaliya <br />
    /// Cosmos region code: 600011
    /// </summary>
    public static class Australia {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Australia() {
            _country = new CountryInfo {
                Country = Country.Australia,
                CountryCode = CountryCode.AU,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Australia,
                M49Code = "036",
                CRCode = 6_00_011,
                Alpha2Code = "AU",
                Alpha3Code = "AUS",
                Name = "The Commonwealth of Australia",
                ShorterForm = "Argentina",
                ChineseName = "澳大利亚联邦",
                ChineseShorterForm = "澳大利亚",
                Continent = Continent.Oceania,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 澳大利亚（The Commonwealth of Australia，大洋洲，AU，AUS，036），澳大利亚联邦 <br />
        /// Cosmos i18n code: i18n_country_aodaliya <br />
        /// Cosmos region code: 600011
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aodaliya";

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