using System;
using Cosmos.I18N.Core.Historical;
using EnumsNET;

namespace Cosmos.I18N.Countries
{
    /// <summary>
    /// Runtime country info.
    /// </summary>
    public class RuntimeCountryInfo
    {
        internal RuntimeCountryInfo()
        {
        }

        #region Runtime fields

        // ReSharper disable once InconsistentNaming
        public string UNCode { get; internal set; }

        public string Alpha2Code { get; internal set; }

        public string Alpha3Code { get; internal set; }

        public string Name { get; internal set; }

        public string ShorterForm { get; internal set; }

        public string Alias { get; internal set; }

        public string ChineseName { get; internal set; }

        public string ChineseShorterForm { get; internal set; }

        public string ChineseAlias { get; internal set; }

        public string ChineseAlias2 { get; internal set; }

        public Continent Continent { get; internal set; }

        public string I18NIdentityCode { get; internal set; }

        public string RuntimeCountryName { get; internal set; }

        public CountryType RuntimeCountryType { get; internal set; }

        public string RuntimeBelongsToCountry { get; internal set; }

        public bool RuntimeHistoricalCountry { get; internal set; }

        public long RuntimeRegionCode { get; internal set; }

        #endregion

        #region Of

        public static RuntimeCountryInfo Of(CountryInfo country)
        {
            if (country is null)
                throw new ArgumentNullException(nameof(country));

            var ret = new RuntimeCountryInfo
            {
                UNCode = country.M49Code,
                Alpha2Code = country.Alpha2Code,
                Alpha3Code = country.Alpha3Code,
                Name = country.Name,
                ShorterForm = country.ShorterForm,
                Alias = country.Alias,
                ChineseName = country.ChineseName,
                ChineseShorterForm = country.ChineseShorterForm,
                ChineseAlias = country.ChineseAlias,
                ChineseAlias2 = country.ChineseAlias2,
                Continent = country.Continent,
                I18NIdentityCode = country.I18NIdentityCode,

                RuntimeCountryName = country.Country.GetName(),
                RuntimeCountryType = country.CountryType,
                RuntimeBelongsToCountry = country.BelongsToCountry.GetName(),
                RuntimeHistoricalCountry = country.HistoricalCountry,
                RuntimeRegionCode = country.CRCode
            };

            return ret;
        }

        public static RuntimeCountryInfo Of(CountryCode code)
        {
            return Of(CountryManager.GetCountryInfo(code));
        }

        #endregion

        #region To country

        /// <summary>
        /// To country info
        /// </summary>
        /// <returns></returns>
        public CountryInfo ToCountryInfo()
        {
            return CountryManager.GetCountryInfo(Alpha2Code);
        }

        /// <summary>
        /// To country code
        /// </summary>
        /// <returns></returns>
        public CountryCode? ToCountryCode()
        {
            var country = ToCountryInfo()?.Country;
            if (country.HasValue)
                return CountryManager.GetCountryCode(country.Value);
            return null;
        }

        #endregion

        #region Get region code

        public RegionCodeValue GetRegionCodeValue() => new RegionCodeValue(RuntimeRegionCode);

        #endregion

        #region Get country by year, month and day

        public RuntimeCountryInfo GetCountryIn(int year)
        {
            return GetCountryOn(year, 1, 1);
        }

        public RuntimeCountryInfo GetCountryIn(int year, int month)
        {
            return GetCountryOn(year, month, 1);
        }

        public RuntimeCountryInfo GetCountryOn(int year, int month, int day)
        {
            return HistoricalCountryManager.Get(this, year, month, day);
        }

        public RuntimeCountryInfo GetCountryOn(DateTime dt)
        {
            return GetCountryOn(dt.Year, dt.Month, dt.Day);
        }

        public RuntimeCountryInfo GetCountryInTheCurrent()
        {
            return !RuntimeHistoricalCountry ? this : GetCountryOn(DateTime.Today);
        }

        #endregion
    }
}