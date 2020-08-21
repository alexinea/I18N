using System;
using System.Linq;
using Cosmos.Conversions;
using Cosmos.I18N.Core.Historical;
using EnumsNET;

namespace Cosmos.I18N.Countries
{
    public readonly struct CountryEnumValue
    {
        private readonly Country _countryEnum;
        private readonly string _countryEnumString;
        private readonly ICountryInfo _countryInfo;

        public CountryEnumValue(Country country)
        {
            _countryEnum = country;
            _countryEnumString = country.GetName();
            _countryInfo = CountryManager.GetCountryInfo(country);
        }

        public CountryEnumValue(string countryString)
        {
            if (string.IsNullOrWhiteSpace(countryString))
                throw new ArgumentNullException(nameof(countryString));

            var length = countryString.Length;

            if (length == 2 || length == 3)
            {
                var country = CountryManager.GetCountryInfo(countryString);

                if (country != null)
                {
                    _countryEnum = country.Country;
                    _countryEnumString = countryString;
                    _countryInfo = country;
                    return;
                }
            }

            var enumMember = Enums.GetMember<Country>(countryString, true);

            if (enumMember != null)
            {
                _countryEnum = enumMember.Value;
                _countryEnumString = countryString;
                _countryInfo = CountryManager.GetCountryInfo(_countryEnum);
                return;
            }

            //历史国家的 Name 应当是 国名+建国年，比如 Yugoslavia1992
            if (countryString.Length <= 4)
                throw new ArgumentException("The length of the countryString must greater than 4.");

#if NETSTANDARD2_0
            var year = countryString.Substring(countryString.Length - 4).CastToInt32(-1);
            var countryStr = countryString.Substring(0, countryString.Length - 4);
#else
            var year = countryString[^4..].CastToInt32(-1);
            var countryStr = countryString[..^4];
#endif

            if (year == -1)
                throw new ArgumentException("The last four characters cannot be converted to numbers.");

            var runtime = HistoricalCountryManager.GetByAlias(countryStr, year, 1, 1).FirstOrDefault();
            if (runtime is null)
                throw new ArgumentException("Cannot get runtime country info.");

            _countryEnum = runtime.IsHistorical ? Country.Unknown : runtime.CountryEnum;
            _countryEnumString = countryString;
            _countryInfo = runtime;
        }

        public static implicit operator Country(CountryEnumValue value)
        {
            if (value._countryInfo.IsHistorical)
                return Country.Unknown;
            return value._countryEnum;
        }

        public static implicit operator string(CountryEnumValue value)
        {
            return value._countryEnumString;
        }

        public static implicit operator CountryEnumValue(Country code)
        {
            return new CountryEnumValue(code);
        }

        public static implicit operator CountryEnumValue(string countryString)
        {
            return new CountryEnumValue(countryString);
        }

        public bool IsHistorical => _countryInfo.IsHistorical;

        public string Value => _countryEnumString;

        public Country EnumValue => _countryEnum;
    }
}