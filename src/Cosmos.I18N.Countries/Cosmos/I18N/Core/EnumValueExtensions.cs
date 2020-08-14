using System;
using EnumsNET;

namespace Cosmos.I18N.Core
{
    internal static class EnumValueExtensions
    {
        public static TAttribute GetAttr<TEnum, TAttribute>(this TEnum values)
            where TEnum : struct, Enum
            where TAttribute : Attribute
        {
            return values.GetAttributes()?.Get<TAttribute>();
        }

        public static bool HasAttr<TEnum, TAttribute>(this EnumMember<TEnum> values)
            where TEnum : struct, Enum
            where TAttribute : Attribute
        {
            return values.Attributes.Has<TAttribute>();
        }
    }
}