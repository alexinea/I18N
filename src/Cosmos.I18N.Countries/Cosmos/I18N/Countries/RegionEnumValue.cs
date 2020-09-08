using System;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries
{
    /// <summary>
    /// Region enum value
    /// </summary>
    public struct RegionEnumValue
    {
        private readonly string _pinnedValue;
        
        private RegionEnumValue(dynamic value, long regionCode, Func<dynamic> func, Type type, string pinnedValue)
        {
            Value = value;
            RegionCode = regionCode;
            ValueFactory = func;
            Type = type;

            _pinnedValue = pinnedValue;
        }

        public dynamic Value { get; }

        public long RegionCode { get; }

        public Type Type { get; }

        public Func<dynamic> ValueFactory { get; }

        internal static RegionEnumValue Of<TEnumValue>(Func<TEnumValue> valueFunc)
            where TEnumValue : struct, Enum
        {
            var currentValue = valueFunc();
            var member = currentValue.GetMember();
            var isUnknown = member is null || member.Name == "Unknown";
            var regionCode = isUnknown ? 0 : member.GetAttr<TEnumValue, RegionCodeAttribute>().CRCode;
            return new RegionEnumValue(
                currentValue,
                regionCode,
                () => valueFunc(),
                typeof(TEnumValue),
                member?.Name ?? "Unknown");
        }

        public static RegionEnumValue Unknown
        {
            get
            {
                return new RegionEnumValue(
                    DefaultEnumValues.Unknown,
                    0,
                    () => DefaultEnumValues.Unknown,
                    typeof(DefaultEnumValues),
                    "Unknown");
            }
        }

        public enum DefaultEnumValues
        {
            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            [RegionCode(0)]
            Unknown
        }

        public bool IsUnknownValue() => RegionCode == 0;

        public static bool operator ==(RegionEnumValue left, RegionEnumValue right)
        {
            return left.RegionCode == right.RegionCode;
        }

        public static bool operator !=(RegionEnumValue left, RegionEnumValue right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is long l)
                return RegionCode == l;
            return RegionCode.Equals(obj);
        }

        public override int GetHashCode() => RegionCode.GetHashCode();

        public TEnumValue As<TEnumValue>() where TEnumValue : struct, Enum
        {
            var member = Enums.GetMember<TEnumValue>(_pinnedValue) ??
                         Enums.GetMember<TEnumValue>("Unknown");

            return member!.Value;
        }

        public RegionCodeValue ToRegionCodeValue => new RegionCodeValue(RegionCode);
    }
}