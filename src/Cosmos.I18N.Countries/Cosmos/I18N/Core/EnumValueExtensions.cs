using System;
using System.Collections.Generic;
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

        public static TAttribute GetAttr<TEnum, TAttribute>(this EnumMember<TEnum> values)
            where TEnum : struct, Enum
            where TAttribute : Attribute
        {
            return values.Attributes.Get<TAttribute>();
        }

        public static IEnumerable<TAttribute> GetAttrAll<TEnum, TAttribute>(this TEnum values)
            where TEnum : struct, Enum
            where TAttribute : Attribute
        {
            return values.GetAttributes()?.GetAll<TAttribute>();
        }

        public static IEnumerable<TAttribute> GetAttrAll<TEnum, TAttribute>(this EnumMember<TEnum> values)
            where TEnum : struct, Enum
            where TAttribute : Attribute
        {
            return values.Attributes.GetAll<TAttribute>();
        }

        public static bool HasAttr<TEnum, TAttribute>(this TEnum values)
            where TEnum : struct, Enum
            where TAttribute : Attribute
        {
            return values.GetAttributes()?.Has<TAttribute>() ?? false;
        }

        public static bool HasAttr<TEnum, TAttribute>(this EnumMember<TEnum> values)
            where TEnum : struct, Enum
            where TAttribute : Attribute
        {
            return values.Attributes.Has<TAttribute>();
        }
    }
}