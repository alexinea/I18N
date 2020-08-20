using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 法属圣马丁（Saint Martin (French part)，北美洲，MF，MAF，663），圣马丁行政区 <br />
    /// Cosmos i18n code: i18n_country_shengmading <br />
    /// Cosmos region code: 400130
    /// </summary>
    public static class SaintMartinFrenchPart
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaintMartinFrenchPart()
        {
            _country = new CountryInfo
            {
                Country = Country.SaintMartinFrenchPart,
                CountryCode = CountryCode.MF,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.France,
                M49Code = "663",
                Cep1CrCode = 4_00_130,
                Alpha2Code = "MF",
                Alpha3Code = "MAF",
                Name = "Saint Martin (French part)",
                ShorterForm = "Saint-Martin",
                ChineseName = "圣马丁行政区",
                ChineseShorterForm = "法属圣马丁",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 法属圣马丁（Saint Martin (French part)，北美洲，MF，MAF，663），圣马丁行政区 <br />
        /// Cosmos i18n code: i18n_country_shengmading <br />
        /// Cosmos region code: 400130
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengmading";

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