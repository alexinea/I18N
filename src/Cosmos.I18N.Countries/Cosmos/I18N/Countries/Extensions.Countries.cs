using System;
using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries
{
    /// <summary>
    /// Countries Extensions
    /// </summary>
    public static class CountriesExtensions
    {
        #region Convert

        /// <summary>
        /// Convert <see cref="Country"/> to <see cref="CountryInfo"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static CountryInfo ToInfo(this Country country)
        {
            return CountryManager.GetCountryInfo(country);
        }

        /// <summary>
        /// Convert <see cref="CountryCode"/> to <see cref="CountryInfo"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static CountryInfo ToInfo(this CountryCode code)
        {
            return CountryManager.GetCountryInfo(code);
        }

        /// <summary>
        /// Convert <see cref="CountryCode"/> to <see cref="Country"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Country ToCountry(this CountryCode code)
        {
            return CountryManager.GetCountryEnum(code);
        }

        /// <summary>
        /// Convert <see cref="Country"/> to <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static CountryCode ToCode(this Country country)
        {
            return CountryManager.GetCountryCode(country);
        }

        /// <summary>
        /// Convert <see cref="CountryCode"/> to string.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string ToCodeString(this CountryCode code)
        {
            return EnumsNET.Enums.GetName(code);
        }

        /// <summary>
        /// Convert <see cref="Country"/> to string.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static string ToCodeString(this Country country)
        {
            return country.ToCode().ToCodeString();
        }

        #endregion

        #region Get CEP-1 / CRCode

        /// <summary>
        /// Get region code / CEP-1 from <see cref="CountryInfo"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static long GetRegionCode(this ICountryInfo country)
        {
            return country?.Cep1CrCode ?? throw new ArgumentNullException(nameof(country));
        }

        /// <summary>
        /// Get region code / CEP-1 from <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static long GetRegionCode(this CountryCode code)
        {
            return code.GetAttr<CountryCode, RegionCodeAttribute>().CRCode;
        }

        /// <summary>
        /// Get region code / CEP-1 from <see cref="Country"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static long GetRegionCode(this Country country)
        {
            return country.GetAttr<Country, RegionCodeAttribute>().CRCode;
        }

        #endregion

        #region Get M49 Code

        /// <summary>
        /// Get M49 code from <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetM49Code(this CountryCode code)
        {
            return CountryManager.GetCountryInfo(code).M49Code;
        }

        /// <summary>
        /// Get M49 code from <see cref="Country"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static string GetM49Code(this Country country)
        {
            return CountryManager.GetCountryInfo(country).M49Code;
        }

        #endregion

        #region Get Alpha2 Code

        /// <summary>
        /// Get Alpha2 code from <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetAlpha2Code(this CountryCode code)
        {
            return CountryManager.GetCountryInfo(code).Alpha2Code;
        }

        /// <summary>
        /// Get Alpha2 code from <see cref="Country"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static string GetAlpha2Code(this Country country)
        {
            return CountryManager.GetCountryInfo(country).Alpha2Code;
        }

        #endregion

        #region Get Alpha3 Code

        /// <summary>
        /// Get Alpha3 code from <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static string GetAlpha3Code(this CountryCode code)
        {
            return CountryManager.GetCountryInfo(code).Alpha3Code;
        }

        /// <summary>
        /// Get Alpha3 code from <see cref="Country"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static string GetAlpha3Code(this Country country)
        {
            return CountryManager.GetCountryInfo(country).Alpha3Code;
        }

        #endregion
    }
}