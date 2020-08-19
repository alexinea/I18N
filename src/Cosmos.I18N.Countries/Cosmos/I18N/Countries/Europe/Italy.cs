namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 意大利（The Republic of Italy，欧洲，IT，ITA，380），意大利共和国 <br />
    /// Cosmos i18n code: i18n_country_yidali <br />
    /// Cosmos region code: 200003
    /// </summary>
    public static partial class Italy
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Italy()
        {
            _country = new CountryInfo
            {
                Country = Country.Italy,
                CountryCode = CountryCode.IT,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Italy,
                M49Code = "380",
                CRCode = 2_00_003,
                Alpha2Code = "IT",
                Alpha3Code = "ITA",
                Name = "The Republic of Italy",
                ShorterForm = "Italy",
                ChineseName = "意大利共和国",
                ChineseShorterForm = "意大利",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 意大利（The Republic of Italy，欧洲，IT，ITA，380），意大利共和国 <br />
        /// Cosmos i18n code: i18n_country_yidali <br />
        /// Cosmos region code: 200003
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yidali";

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