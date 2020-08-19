using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.SouthAmerica
{
    /// <summary>
    /// 阿根廷（The Republic of Argentina，南美洲，AR，ARG，032），阿根廷共和国 <br />
    /// Cosmos i18n code: i18n_country_agenting <br />
    /// Cosmos region code: 500011
    /// </summary>
    public static class Argentina
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Argentina()
        {
            _country = new CountryInfo
            {
                Country = Country.Argentina,
                CountryCode = CountryCode.AR,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Argentina,
                M49Code = "032",
                CRCode = 5_00_011,
                Alpha2Code = "AR",
                Alpha3Code = "ARG",
                Name = "The Republic of Argentina",
                ShorterForm = "Argentina",
                ChineseName = "阿根廷共和国",
                ChineseShorterForm = "阿根廷",
                Continent = Continent.SouthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 阿根廷（The Republic of Argentina，南美洲，AR，ARG，032），阿根廷共和国 <br />
        /// Cosmos i18n code: i18n_country_agenting <br />
        /// Cosmos region code: 500011
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_agenting";

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