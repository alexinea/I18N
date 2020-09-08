using System;
using System.Collections.Generic;
using Cosmos.I18N.Core;
using Cosmos.I18N.Core.Historical;

namespace Cosmos.I18N.Countries
{
    /// <summary>
    /// Runtime country info.
    /// </summary>
    public class RuntimeCountryInfo : ICountryInfo
    {
        private readonly CountryInfo _currentData;
        private readonly Dictionary<string, string> _runtimeData;
        private readonly Continent _continent;
        private readonly CountryType _countryType;
        private readonly long _cep1CrCode;
        private readonly string _countryCodeString;
        private readonly string _countryEnumString;

        internal RuntimeCountryInfo(CountryInfo country)
        {
            _currentData = country ?? throw new ArgumentNullException(nameof(country));
            _runtimeData = null;
            _continent = country.Continent;
            _countryType = country.CountryType;
            _cep1CrCode = country.Cep1CrCode;
            _countryCodeString = string.Empty;
            _countryEnumString = string.Empty;
            _getRegionEnumValue = country.GetRegionEnumValue;
        }

        internal RuntimeCountryInfo(
            Continent continent, CountryType countryType, long cep1CrCode,
            string countryCodeString, string countryEnumString,
            Dictionary<string, string> runtimeData)
        {
            _currentData = null;
            _runtimeData = runtimeData ?? throw new ArgumentNullException(nameof(runtimeData));
            _continent = continent;
            _countryType = countryType;
            _cep1CrCode = cep1CrCode;
            _countryCodeString = countryCodeString;
            _countryEnumString = countryEnumString;
            _getRegionEnumValue = _ => RegionEnumValue.Unknown;
        }

        private bool IsCurrentEva() => _currentData != null;

        private string GetRuntimeData(string key)
        {
            return _runtimeData is null
                ? string.Empty
                : _runtimeData.TryGetValue(key, out var ret)
                    ? ret
                    : string.Empty;
        }

        private Func<RegionCodeValue, RegionEnumValue> _getRegionEnumValue;

        #region Runtime fields

        // ReSharper disable once InconsistentNaming
        public string M49Code => IsCurrentEva() ? _currentData.M49Code : GetRuntimeData("M49");

        public string Alpha2Code => IsCurrentEva() ? _currentData.Alpha2Code : GetRuntimeData("ALPHA2");

        public string Alpha3Code => IsCurrentEva() ? _currentData.Alpha3Code : GetRuntimeData("ALPHA3");

        public long Cep1CrCode => _cep1CrCode;

        public string Name => IsCurrentEva() ? _currentData.Name : GetRuntimeData("NAME");

        public string ShorterForm => IsCurrentEva() ? _currentData.ShorterForm : GetRuntimeData("SHORTER_FORM");

        public string Alias => IsCurrentEva() ? _currentData.Alias : GetRuntimeData("ALIAS");

        public string ChineseName => IsCurrentEva() ? _currentData.ChineseName : GetRuntimeData("CN_NAME");

        public string ChineseShorterForm => IsCurrentEva() ? _currentData.ChineseShorterForm : GetRuntimeData("CN_SHORTER_FORM");

        public string ChineseAlias => IsCurrentEva() ? _currentData.ChineseAlias : GetRuntimeData("CN_ALIAS1");

        public string ChineseAlias2 => IsCurrentEva() ? _currentData.ChineseAlias2 : GetRuntimeData("CN_ALIAS2");

        public Continent Continent => _continent;

        public CountryType CountryType => _countryType;

        public string I18NIdentityCode => IsCurrentEva() ? _currentData.I18NIdentityCode : GetRuntimeData("I18N");

        public Country CountryEnum => IsCurrentEva() ? _currentData.Country : Country.Unknown;

        public Country BelongsToCountryEnum => IsCurrentEva() ? _currentData.BelongsToCountry : Country.Unknown;

        private bool _commonwealthOfNations = false;
        public bool CommonwealthOfNations => IsCurrentEva() ? _currentData.CommonwealthOfNations : _commonwealthOfNations;

        public bool IsHistorical => !IsCurrentEva();

        #endregion

        #region Of

        public static RuntimeCountryInfo Of(CountryInfo country)
        {
            if (country is null)
                throw new ArgumentNullException(nameof(country));

            return RuntimeCountryInfoCache.GetOrAdd(country.Cep1CrCode, _ => new RuntimeCountryInfo(country));
        }

        public static RuntimeCountryInfo Of(Country country) => Of(CountryManager.GetCountryInfo(country));

        public static RuntimeCountryInfo Of(CountryCode code) => Of(CountryManager.GetCountryInfo(code));

        public static RuntimeCountryInfo Of(RegionCodeValue code) => CountryManager.GetCountryInfo(code);

        public static RuntimeCountryInfo Of(long cep1CrCode) => CountryManager.GetCountryInfo(cep1CrCode);

        public static RuntimeCountryInfo Of(string alphaCode) => Of(CountryManager.GetCountryInfo(alphaCode));

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

        public RuntimeCountryInfo ToRuntimeModel() => this;

        #endregion

        #region Get region code

        public RegionCodeValue GetRegionCodeValue() => new RegionCodeValue(_cep1CrCode);

        #endregion

        #region Get country by year, month and day

        public IEnumerable<RuntimeCountryInfo> GetCountryIn(int year)
        {
            return GetCountryOn(year, 1, 1);
        }

        public IEnumerable<RuntimeCountryInfo> GetCountryIn(int year, int month)
        {
            return GetCountryOn(year, month, 1);
        }

        public IEnumerable<RuntimeCountryInfo> GetCountryOn(int year, int month, int day)
        {
            return HistoricalCountryManager.Get(this, year, month, day);
        }

        public IEnumerable<RuntimeCountryInfo> GetCountryOn(DateTime dt)
        {
            return GetCountryOn(dt.Year, dt.Month, dt.Day);
        }

        public IEnumerable<RuntimeCountryInfo> GetCountryInTheCurrent()
        {
            return !IsHistorical ? new[] {this} : GetCountryOn(DateTime.Today);
        }

        #endregion

        public static explicit operator CountryInfo(RuntimeCountryInfo runtime)
        {
            return runtime._currentData;
        }

        public static explicit operator Country(RuntimeCountryInfo runtime)
        {
            return runtime.IsCurrentEva()
                ? runtime._currentData.Country
                : Country.Unknown;
        }

        /// <summary>
        /// Get country enum value.
        /// </summary>
        /// <returns></returns>
        public CountryEnumValue GetCountryEnumValue() => IsCurrentEva()
            ? (CountryEnumValue) _currentData.Country
            : (CountryEnumValue) _countryEnumString;

        /// <summary>
        /// Gets country code value.
        /// </summary>
        /// <returns></returns>
        public CountryCodeValue GetCountryCodeValue() => IsCurrentEva()
            ? (CountryCodeValue) _currentData.CountryCode
            : (CountryCodeValue) _countryCodeString;

        /// <summary>
        /// Gets region enum value factory.
        /// </summary>
        public Func<RegionCodeValue, RegionEnumValue> GetRegionEnumValue => IsCurrentEva()
            ? _currentData.GetRegionEnumValue
            : _getRegionEnumValue;

        /// <summary>
        /// Gets current country/region existence cycle
        /// </summary>
        public ExistenceCycle? ExistenceCycle { get; internal set; } = default;
    }
}