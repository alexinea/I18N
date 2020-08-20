namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 智利（Republic of Chile，南美洲，CL，CHL，152），智利共和国 <br />
    /// Cosmos i18n code: i18n_country_zhili <br />
    /// Cosmos region code: 500012
    /// </summary>
    public static partial class Chile
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Chile()
        {
            _country = new CountryInfo
            {
                Country = Country.Chile,
                CountryCode = CountryCode.CL,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Chile,
                M49Code = "152",
                Cep1CrCode = 5_00_012,
                Alpha2Code = "CL",
                Alpha3Code = "CHL",
                Name = "Republic of Chile",
                ShorterForm = "Chile",
                ChineseName = "智利共和国",
                ChineseShorterForm = "智利",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 智利（Republic of Chile，南美洲，CL，CHL，152），智利共和国 <br />
        /// Cosmos i18n code: i18n_country_zhili <br />
        /// Cosmos region code: 500012
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_zhili";

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