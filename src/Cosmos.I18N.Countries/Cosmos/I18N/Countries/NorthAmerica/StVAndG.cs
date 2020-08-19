namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 圣文森特和格林纳丁斯（Saint Vincent and the Grenadines，北美洲，VC，VCT，670） <br />
    /// Cosmos i18n code: i18n_country_shengwensenteglnds <br />
    /// Cosmos region code: 400133
    /// </summary>
    public static partial class StVAndG
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static StVAndG()
        {
            _country = new CountryInfo
            {
                Country = Country.StVAndG,
                CountryCode = CountryCode.VC,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.StVAndG,
                M49Code = "670",
                CRCode = 4_00_133,
                Alpha2Code = "VC",
                Alpha3Code = "VCT",
                Name = "Saint Vincent and the Grenadines",
                ChineseName = "圣文森特和格林纳丁斯",
                Continent = Continent.NorthAmerica,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 圣文森特和格林纳丁斯（Saint Vincent and the Grenadines，北美洲，VC，VCT，670） <br />
        /// Cosmos i18n code: i18n_country_shengwensenteglnds <br />
        /// Cosmos region code: 400133
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_shengwensenteglnds";

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