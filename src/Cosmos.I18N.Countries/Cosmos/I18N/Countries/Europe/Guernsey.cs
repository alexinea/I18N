using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 根西岛（Bailiwick of Guernsey，欧洲，GG，GGY，831） <br />
    /// Cosmos i18n code: i18n_country_genxidao <br />
    /// Cosmos region code: 200116
    /// </summary>
    public static class Guernsey
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guernsey()
        {
            _country = new CountryInfo
            {
                Country = Country.Guernsey,
                CountryCode = CountryCode.GG,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "831",
                Cep1CrCode = 2_00_116,
                Alpha2Code = "GG",
                Alpha3Code = "GGY",
                Name = "Bailiwick of Guernsey",
                ShorterForm = "Guernsey",
                ChineseName = "根西岛",
                ChineseAlias = "格恩西岛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 根西岛（Bailiwick of Guernsey，欧洲，GG，GGY，831） <br />
        /// Cosmos i18n code: i18n_country_genxidao <br />
        /// Cosmos region code: 200116
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_genxidao";

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