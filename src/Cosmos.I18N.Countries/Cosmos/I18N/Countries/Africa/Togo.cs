using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 多哥（French Southern Territories，非洲，TG，TGO，768），多哥共和国 <br />
    /// Cosmos i18n code: i18n_country_duoge <br />
    /// Cosmos region code: 300125
    /// </summary>
    public static class Togo
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Togo()
        {
            _country = new CountryInfo
            {
                Country = Country.Togo,
                CountryCode = CountryCode.TG,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Togo,
                M49Code = "768",
                Cep1CrCode = 3_00_125,
                Alpha2Code = "TG",
                Alpha3Code = "TGO",
                Name = "The Republic of Togo",
                ShorterForm = "Togo",
                ChineseName = "多哥共和国",
                ChineseShorterForm = "多哥",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 多哥（French Southern Territories，非洲，TG，TGO，768），多哥共和国 <br />
        /// Cosmos i18n code: i18n_country_duoge <br />
        /// Cosmos region code: 300125
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_duoge";

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
