using System;
using EnumsNET;

namespace Cosmos.I18N.Countries
{
    public readonly struct CountryCodeValue
    {
        private readonly CountryCode _countryCode;
        private readonly string _countryCodeString;
        private readonly bool _isHistorical;

        public CountryCodeValue(CountryCode code)
        {
            if (code == CountryCode.Unknown)
            {
                _countryCode = CountryCode.Unknown;
                _countryCodeString = "Unknown";
                _isHistorical = true;
            }
            else
            {
                _countryCode = code;
                _countryCodeString = Enums.GetName(typeof(CountryCode), code);
                _isHistorical = false;
            }
        }

        public CountryCodeValue(string countryCodeString)
        {
            if (string.IsNullOrWhiteSpace(countryCodeString))
                throw new ArgumentNullException(nameof(countryCodeString));
            if (countryCodeString.Length != 2)
                throw new ArgumentException("The length of the countryCodeString must be 2. ");
            var enumMember = Enums.GetMember<CountryCode>(countryCodeString, true);

            if (enumMember is null)
            {
                _countryCode = CountryCode.Unknown;
                _countryCodeString = countryCodeString.ToUpper();
                _isHistorical = true;
            }
            else
            {
                _countryCode = enumMember.Value;
                _countryCodeString = countryCodeString.ToUpper();
                _isHistorical = false;
            }
        }

        public static implicit operator CountryCode(CountryCodeValue value)
        {
            if (value._isHistorical)
                return CountryCode.Unknown;
            return value._countryCode;
        }

        public static implicit operator string(CountryCodeValue value)
        {
            return value._countryCodeString;
        }

        public static implicit operator CountryCodeValue(CountryCode code)
        {
            return new CountryCodeValue(code);
        }

        public static implicit operator CountryCodeValue(string countryCodeString)
        {
            return new CountryCodeValue(countryCodeString);
        }

        public bool IsHistorical => _isHistorical;

        public string Value => _countryCodeString;

        public CountryCode EnumValue => _countryCode;
    }
}