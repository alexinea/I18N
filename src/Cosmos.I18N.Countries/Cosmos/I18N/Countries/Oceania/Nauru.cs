namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// 瑙鲁（The Republic of Nauru，大洋洲，NR，NRU，520），瑙鲁共和国 <br />
    /// Cosmos i18n code: i18n_country_manu <br />
    /// Cosmos region code: 600108
    /// </summary>
    public static partial class Nauru
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Nauru()
        {
            _country = new CountryInfo
            {
                Country = Country.Nauru,
                CountryCode = CountryCode.NR,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Nauru,
                M49Code = "520",
                Cep1CrCode = 6_00_108,
                Alpha2Code = "NR",
                Alpha3Code = "NRU",
                Name = "The Republic of Nauru",
                ShorterForm = "Nauru",
                ChineseName = "瑙鲁共和国",
                ChineseShorterForm = "瑙鲁",
                Continent = Continent.Oceania,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 瑙鲁（The Republic of Nauru，大洋洲，NR，NRU，520），瑙鲁共和国 <br />
        /// Cosmos i18n code: i18n_country_manu <br />
        /// Cosmos region code: 600108
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_manu";

        /// <summary>
        /// Get Cosmos Region Code (CEP-1/CRCode)
        /// </summary>
        public static long CosmosRegionCode => _country.Cep1CrCode;

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