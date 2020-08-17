namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 圣马力诺（The Republic of San Marino，欧洲，SM，SMR，674），圣马力诺共和国 <br />
    /// Cosmos i18n code: i18n_country_shengmalinuo <br />
    /// Cosmos region code: 200135
    /// </summary>
    public static class SanMarino {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SanMarino() {
            _country = new CountryInfo {
                Country = Country.SanMarino,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.SanMarino,
                M49Code = "674",
                CRCode = 2_00_135,
                Alpha2Code = "SM",
                Alpha3Code = "SMR",
                Name = "The Republic of San Marino",
                ShorterForm = "San Marino",
                ChineseName = "圣马力诺共和国",
                ChineseShorterForm = "圣马力诺",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 圣马力诺（The Republic of San Marino，欧洲，SM，SMR，674），圣马力诺共和国 <br />
        /// Cosmos i18n code: i18n_country_shengmalinuo <br />
        /// Cosmos region code: 200135
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengmalinuo";

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