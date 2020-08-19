namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 安道尔（Andorra，欧洲，AD，AND，020），安道尔共和国 <br />
    /// Cosmos i18n code: i18n_country_andaoer <br />
    /// Cosmos region code: 200103
    /// </summary>
    public static partial class Andorra
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Andorra()
        {
            _country = new CountryInfo
            {
                Country = Country.Andorra,
                CountryCode = CountryCode.AD,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Andorra,
                M49Code = "020",
                CRCode = 2_00_103,
                Alpha2Code = "AD",
                Alpha3Code = "AND",
                Name = "Andorra",
                ChineseName = "安道尔共和国",
                ChineseShorterForm = "安道尔",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 安道尔（Andorra，欧洲，AD，AND，020），安道尔共和国 <br />
        /// Cosmos i18n code: i18n_country_andaoer <br />
        /// Cosmos region code: 200103
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_andaoer";

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