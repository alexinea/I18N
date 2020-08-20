namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 布隆迪（The Republic of Burundi，非洲，BI，BDI，108），布隆迪共和国 <br />
    /// Cosmos i18n code: i18n_country_bulongdi <br />
    /// Cosmos region code: 300107
    /// </summary>
    public static partial class Burundi
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Burundi()
        {
            _country = new CountryInfo
            {
                Country = Country.Burundi,
                CountryCode = CountryCode.BI,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Burundi,
                M49Code = "108",
                Cep1CrCode = 3_00_107,
                Alpha2Code = "BI",
                Alpha3Code = "BDI",
                Name = "The Republic of Burundi",
                ShorterForm = "Burundi",
                ChineseName = "布隆迪共和国",
                ChineseShorterForm = "布隆迪",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 布隆迪（The Republic of Burundi，非洲，BI，BDI，108），布隆迪共和国 <br />
        /// Cosmos i18n code: i18n_country_bulongdi <br />
        /// Cosmos region code: 300107
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bulongdi";

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