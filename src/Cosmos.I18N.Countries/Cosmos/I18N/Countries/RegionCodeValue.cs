using System;
using Cosmos.Conversions;

namespace Cosmos.I18N.Countries
{
    public struct RegionCodeValue
    {
        private readonly long _originalCode;

        public RegionCodeValue(long code)
        {
            if (code == 0)
            {
                ContinentValue = 0;
                HistoricalValue = 0;
                RegionValue = 0;
                SubRegionValue = null;
            }
            else
            {
                if (code < 1_00_000_0)
                    throw new ArgumentOutOfRangeException(nameof(code), "The length of CRCode should be greater than 6 bits.");

                var o = code.ToString();

                ContinentValue = o[0].CastToInt32();
#if NETSTANDARD2_0
                HistoricalValue = o.Substring(1, 2).CastToInt32();
                RegionValue = o.Substring(3, 3).CastToInt32();
#else
                HistoricalValue = o[1..3].CastToInt32();
                RegionValue = o[3..6].CastToInt32();
#endif

                if (o.Length >= 10)
                {
#if NETSTANDARD2_0
                    SubRegionValue = o.Substring(6, 4).CastToInt32();
#else
                    SubRegionValue = o[6..10].CastToInt32();
#endif
                }
                else
                {
                    SubRegionValue = null;
                }
            }

            _originalCode = code;
        }

        public int ContinentValue { get; }

        public int HistoricalValue { get; }

        public bool IsHistoricalValue() => HistoricalValue != 0;

        public int RegionValue { get; }

        public int? SubRegionValue { get; }

        public bool IsUnknownValue() => ContinentValue == 0 || RegionValue == 0;

        public static implicit operator long(RegionCodeValue value)
        {
            //0_00_000
            return value.RegionValue +
                   value.HistoricalValue * 1_000 +
                   value.ContinentValue * 1_00_000;
        }

        public static explicit operator RegionCodeValue(long code)
        {
            return new RegionCodeValue(code);
        }

        public long ToRegionCode()
        {
            //0_00_000
            return RegionValue +
                   HistoricalValue * 1_000 +
                   ContinentValue * 1_00_000;
        }

        public long ToFullRegionCode()
        {
            //0_00_000_0000
            return ToRegionCode() * 1_0000 + (SubRegionValue ?? 0);
        }

        public long GetOriginalValue() => _originalCode;

        public static RegionCodeValue Unknown => new RegionCodeValue(0);
    }
}