namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 中国（People's Republic of China，亚洲，CN，CNH，156），中华人民共和国 <br />
    /// 一个伟大的文明古国，人类的未来 <br />
    /// Cosmos i18n code: i18n_country_china <br />
    /// Cosmos region code: 100001
    /// </summary>
    public static partial class China
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static China()
        {
            _country = new CountryInfo
            {
                Country = Country.China,
                CountryCode = CountryCode.CN,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.China,
                M49Code = "156",
                CRCode = 1_00_001,
                Alpha2Code = "CN",
                Alpha3Code = "CHN",
                Name = "People's Republic of China",
                ShorterForm = "China",
                ChineseName = "中华人民共和国",
                ChineseShorterForm = "中国",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 中国（People's Republic of China，亚洲，CN，CNH，156），中华人民共和国 <br />
        /// 一个伟大的文明古国，人类的未来 <br />
        /// Cosmos i18n code: i18n_country_china <br />
        /// Cosmos region code: 100001
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_china";

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