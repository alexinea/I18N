namespace Cosmos.I18N.Countries.Antarctica
{
    /// <summary>
    /// 南极洲（Antarctica，南极洲，AQ，ATA，010）<br />
    /// 人类的净土 <br />
    /// Cosmos i18n code: i18n_country_nanji <br />
    /// Cosmos region code: 700010
    /// </summary>
    public static partial class Antarctique
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Antarctique()
        {
            _country = new CountryInfo
            {
                Country = Country.Antarctica,
                CountryCode = CountryCode.AQ,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Antarctica,
                M49Code = "010",
                Cep1CrCode = 7_00_010,
                Alpha2Code = "AQ",
                Alpha3Code = "ATA",
                Name = "Antarctica",
                ChineseName = "南极洲",
                Continent = Continent.Antarctica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 南极洲（Antarctica，南极洲，AQ，ATA，010）<br />
        /// 人类的净土 <br />
        /// Cosmos i18n code: i18n_country_nanji <br />
        /// Cosmos region code: 700010
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_nanji";

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