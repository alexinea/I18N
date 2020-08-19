using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 安圭拉（Anguilla，北美洲，AI，AIA，660），英国海外领土 <br />
    /// Cosmos i18n code: i18n_country_anguila <br />
    /// Cosmos region code: 400102
    /// </summary>
    public static class Anguilla
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Anguilla()
        {
            _country = new CountryInfo
            {
                Country = Country.Anguilla,
                CountryCode = CountryCode.AI,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "660",
                CRCode = 4_00_102,
                Alpha2Code = "AI",
                Alpha3Code = "AIA",
                Name = "Anguilla",
                ChineseName = "安圭拉",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 安圭拉（Anguilla，北美洲，AI，AIA，660），英国海外领土 <br />
        /// Cosmos i18n code: i18n_country_anguila <br />
        /// Cosmos region code: 400102
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_anguila";

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