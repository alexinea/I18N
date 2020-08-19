using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 圣巴托洛缪岛（Collectivitéde Saint-Barthélemy，北美洲，BL，BLM，652），法兰西共和国圣巴托洛缪行政区 <br />
    /// Cosmos i18n code: i18n_country_shengbatuo <br />
    /// Cosmos region code: 400127
    /// </summary>
    public static class SaintBarts
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SaintBarts()
        {
            _country = new CountryInfo
            {
                Country = Country.SaintBarts,
                CountryCode = CountryCode.BL,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.France,
                M49Code = "652",
                CRCode = 4_00_127,
                Alpha2Code = "BL",
                Alpha3Code = "BLM",
                Name = "Collectivitéde Saint-Barthélemy",
                ShorterForm = "Saint Barts",
                ChineseName = "法兰西共和国圣巴托洛缪行政区",
                ChineseShorterForm = "圣巴托洛缪岛",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 圣巴托洛缪岛（Collectivitéde Saint-Barthélemy，北美洲，BL，BLM，652），法兰西共和国圣巴托洛缪行政区 <br />
        /// Cosmos i18n code: i18n_country_shengbatuo <br />
        /// Cosmos region code: 400127
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengbatuo";

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