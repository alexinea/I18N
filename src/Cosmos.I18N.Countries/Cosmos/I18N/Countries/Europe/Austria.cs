namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 奥地利（The Republic of Austria，欧洲，AT，AUT，040），奥地利共和国 <br />
    /// Cosmos i18n code: i18n_country_aodili <br />
    /// Cosmos region code: 200011
    /// </summary>
    public static partial class Austria
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Austria()
        {
            _country = new CountryInfo
            {
                Country = Country.Austria,
                CountryCode = CountryCode.AT,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Austria,
                M49Code = "040",
                Cep1CrCode = 2_00_011,
                Alpha2Code = "AT",
                Alpha3Code = "AUT",
                Name = "The Republic of Austria",
                ShorterForm = "Austria",
                ChineseName = "奥地利共和国",
                ChineseShorterForm = "奥地利",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 奥地利（The Republic of Austria，欧洲，AT，AUT，040），奥地利共和国 <br />
        /// Cosmos i18n code: i18n_country_aodili <br />
        /// Cosmos region code: 200011
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aodili";

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