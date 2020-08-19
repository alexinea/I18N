namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 刚果（布）（The Republic of Congo，非洲，CG，COG，178），刚果共和国 <br />
    /// Cosmos i18n code: i18n_country_gangguobu <br />
    /// Cosmos region code: 300112
    /// </summary>
    public static partial class CongoBrazzaville
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static CongoBrazzaville()
        {
            _country = new CountryInfo
            {
                Country = Country.CongoBrazzaville,
                CountryCode = CountryCode.CG,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.CongoBrazzaville,
                M49Code = "178",
                CRCode = 3_00_112,
                Alpha2Code = "CG",
                Alpha3Code = "COG",
                Name = "The Republic of Congo",
                ShorterForm = "Congo (Brazzaville)",
                ChineseName = "刚果共和国",
                ChineseShorterForm = "刚果（布）",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 刚果（布）（The Republic of Congo，非洲，CG，COG，178），刚果共和国 <br />
        /// Cosmos i18n code: i18n_country_gangguobu <br />
        /// Cosmos region code: 300112
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gangguobu";

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