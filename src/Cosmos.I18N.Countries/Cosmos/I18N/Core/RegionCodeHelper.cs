using System;

namespace Cosmos.I18N.Core
{
    internal static class RegionCodeHelper
    {
        public static long GetCrCode<TEnumValues>(TEnumValues values)
            where TEnumValues : struct, Enum
        {
            return values.GetAttr<TEnumValues, RegionCodeAttribute>().CRCode;
        }
    }
}