using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 荷兰属圣马丁（Sint Maarten (Dutch part)，北美洲，SX，SXM，534） <br />
    /// Cosmos i18n code: i18n_country_shengmadingdp <br />
    /// Cosmos region code: 400131
    /// </summary>
    public static class SintMaartenDutchPart
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static SintMaartenDutchPart()
        {
            _country = new CountryInfo
            {
                Country = Country.SintMaartenDutchPart,
                CountryCode = CountryCode.SX,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.Netherlands,
                M49Code = "534",
                CRCode = 4_00_131,
                Alpha2Code = "SX",
                Alpha3Code = "SXM",
                Name = "Sint Maarten (Dutch part)",
                ShorterForm = "Sint Maarten",
                ChineseName = "荷兰属圣马丁",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 荷兰属圣马丁（Sint Maarten (Dutch part)，北美洲，SX，SXM，534） <br />
        /// Cosmos i18n code: i18n_country_shengmadingdp <br />
        /// Cosmos region code: 400131
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengmadingdp";

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