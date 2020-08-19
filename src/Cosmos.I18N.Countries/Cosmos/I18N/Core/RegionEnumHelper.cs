using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Countries;
using EnumsNET;

namespace Cosmos.I18N.Core
{
    internal static class RegionEnumHelper
    {
        public static IEnumerable<EnumMember<TEnumValues>> Cache<TEnumValues>()
            where TEnumValues : struct, Enum
        {
            return Enums.GetMembers<TEnumValues>()
                        .Where(member => !member.HasAttr<TEnumValues, IgnoreRegionAttribute>());
        }

        public static Dictionary<long, TEnumValues> Mapping<TEnumValues>(IEnumerable<EnumMember<TEnumValues>> cache)
            where TEnumValues : struct, Enum
        {
            return cache.ToDictionary(k => RegionCodeHelper.GetCrCode(k.Value), v => v.Value);
        }

        public static IEnumerable<EnumMember<TEnumValues>> Filter<TEnumValues>(IEnumerable<EnumMember<TEnumValues>> cache, string flag)
            where TEnumValues : struct, Enum
        {
            return cache.Where(x => x.Attributes.GetAll<RegionFlagAttribute>().Any(attr => attr.Flag == flag));
        }

        public static RegionEnumValue Value<TEnumValues>(RegionCodeValue value, Dictionary<long, TEnumValues> mapping)
            where TEnumValues : struct, Enum
        {
            if (value.IsHistoricalValue() || !value.SubRegionValue.HasValue)
                return RegionEnumValue.Unknown;
            if (mapping.TryGetValue(value.SubRegionValue.Value, out var ret))
                return RegionEnumValue.Of(() => ret);
            return RegionEnumValue.Unknown;
        }

        public static RegionEnumValue Unknown(RegionCodeValue value)
        {
            return RegionEnumValue.Unknown;
        }
    }
}