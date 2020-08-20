using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 马达加斯加（The Republic of Madagascar，非洲，MG，MDG，450），马达加斯加共和国 <br />
    /// Cosmos i18n code: i18n_country_madajiasijia <br />
    /// Cosmos region code: 300134
    /// </summary>
    public static class Madagascar
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Madagascar()
        {
            _country = new CountryInfo
            {
                Country = Country.Madagascar,
                CountryCode = CountryCode.MG,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Madagascar,
                M49Code = "450",
                Cep1CrCode = 3_00_134,
                Alpha2Code = "MG",
                Alpha3Code = "MDG",
                Name = "The Republic of Madagascar",
                ShorterForm = "Madagascar",
                ChineseName = "马达加斯加共和国",
                ChineseShorterForm = "马达加斯加",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 马达加斯加（The Republic of Madagascar，非洲，MG，MDG，450），马达加斯加共和国 <br />
        /// Cosmos i18n code: i18n_country_madajiasijia <br />
        /// Cosmos region code: 300134
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_madajiasijia";

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