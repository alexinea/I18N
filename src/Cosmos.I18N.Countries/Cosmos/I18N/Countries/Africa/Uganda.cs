using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 乌干达（The Republic of Uganda，非洲，UG，UGA，800），乌干达共和国 <br />
    /// Cosmos i18n code: i18n_country_wuganda <br />
    /// Cosmos region code: 300154
    /// </summary>
    public static class Uganda
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Uganda()
        {
            _country = new CountryInfo
            {
                Country = Country.Uganda,
                CountryCode = CountryCode.UG,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Uganda,
                M49Code = "800",
                Cep1CrCode = 3_00_154,
                Alpha2Code = "UG",
                Alpha3Code = "UGA",
                Name = "The Republic of Uganda",
                ShorterForm = "Uganda",
                ChineseName = "乌干达共和国",
                ChineseShorterForm = "乌干达",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 乌干达（The Republic of Uganda，非洲，UG，UGA，800），乌干达共和国 <br />
        /// Cosmos i18n code: i18n_country_wuganda <br />
        /// Cosmos region code: 300154
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_wuganda";

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