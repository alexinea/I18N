namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 阿尔及利亚（People's Democratic Republic of Algeria，非洲，DZ，DZA，012），阿尔及利亚民主人民共和国 <br />
    /// Cosmos i18n code: i18n_country_aerjiliya <br />
    /// Cosmos region code: 300101
    /// </summary>
    public static partial class Algeria
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Algeria()
        {
            _country = new CountryInfo
            {
                Country = Country.Algeria,
                CountryCode = CountryCode.DZ,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Algeria,
                M49Code = "012",
                CRCode = 3_00_101,
                Alpha2Code = "DZ",
                Alpha3Code = "DZA",
                Name = "People's Democratic Republic of Algeria",
                ShorterForm = "Algeria",
                ChineseName = "阿尔及利亚民主人民共和国",
                ChineseShorterForm = "阿尔及利亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 阿尔及利亚（People's Democratic Republic of Algeria，非洲，DZ，DZA，012），阿尔及利亚民主人民共和国 <br />
        /// Cosmos i18n code: i18n_country_aerjiliya <br />
        /// Cosmos region code: 300101
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aerjiliya";

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