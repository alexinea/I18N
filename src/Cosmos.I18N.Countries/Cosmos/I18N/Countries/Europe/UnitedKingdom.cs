namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 英国（United Kingdom of Great Britain and Northern Ireland，欧洲，GB，GBR，826），大不列颠及北爱尔兰联合王国 <br />
    /// Cosmos i18n code: i18n_country_yingguo <br />
    /// Cosmos region code: 200005
    /// </summary>
    public static partial class UnitedKingdom
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static UnitedKingdom()
        {
            _country = new CountryInfo
            {
                Country = Country.UnitedKingdom,
                CountryCode = CountryCode.GB,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "826",
                Cep1CrCode = 2_00_005,
                Alpha2Code = "GB",
                Alpha3Code = "GBR",
                Name = "United Kingdom of Great Britain and Northern Ireland",
                ShorterForm = "United Kingdom",
                ChineseName = "大不列颠及北爱尔兰联合王国",
                ChineseShorterForm = "英国",
                Continent = Continent.Europe,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 英国（United Kingdom of Great Britain and Northern Ireland，欧洲，GB，GBR，826），大不列颠及北爱尔兰联合王国 <br />
        /// Cosmos i18n code: i18n_country_yingguo <br />
        /// Cosmos region code: 200005
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_yingguo";

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