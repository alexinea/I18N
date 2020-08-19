namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 塞尔维亚（The Republic of Serbia，欧洲，RS，SRB，688），塞尔维亚共和国 <br />
    /// Cosmos i18n code: i18n_country_saierweiya <br />
    /// Cosmos region code: 200136
    /// </summary>
    public static partial class Serbia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Serbia()
        {
            _country = new CountryInfo
            {
                Country = Country.Serbia,
                CountryCode = CountryCode.RS,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Serbia,
                M49Code = "688",
                CRCode = 2_00_136,
                Alpha2Code = "RS",
                Alpha3Code = "SRB",
                Name = "The Republic of Serbia",
                ShorterForm = "Serbia",
                ChineseName = "塞尔维亚共和国",
                ChineseShorterForm = "塞尔维亚",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 塞尔维亚（The Republic of Serbia，欧洲，RS，SRB，688），塞尔维亚共和国 <br />
        /// Cosmos i18n code: i18n_country_saierweiya <br />
        /// Cosmos region code: 200136
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_saierweiya";

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