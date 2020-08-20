using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 西撒哈拉（The Sahrawi Arab Democratic Republic，非洲，EH，ESH，732），阿拉伯撒哈拉民主共和国 <br />
    /// Cosmos i18n code: i18n_country_xisahala <br />
    /// Cosmos region code: 300118
    /// </summary>
    public static class WesternSahara
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static WesternSahara()
        {
            _country = new CountryInfo
            {
                Country = Country.WesternSahara,
                CountryCode = CountryCode.EH,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.WesternSahara,
                M49Code = "732",
                Cep1CrCode = 3_00_118,
                Alpha2Code = "EH",
                Alpha3Code = "ESH",
                Name = "The Sahrawi Arab Democratic Republic",
                ShorterForm = "Western Sahara",
                ChineseName = "阿拉伯撒哈拉民主共和国",
                ChineseShorterForm = "西撒哈拉",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 西撒哈拉（The Sahrawi Arab Democratic Republic，非洲，EH，ESH，732），阿拉伯撒哈拉民主共和国 <br />
        /// Cosmos i18n code: i18n_country_xisahala <br />
        /// Cosmos region code: 300118
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_xisahala";

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