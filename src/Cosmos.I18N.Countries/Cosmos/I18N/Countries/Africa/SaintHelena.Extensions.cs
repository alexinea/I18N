﻿using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Africa
{
    public static  partial class SaintHelena
    {
        /// <summary>
        /// Convert <see cref="SaintHelena.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Get CEP-1 / Cosmos Region Code.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static long ToNumericRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, RegionCodeAttribute>().CRCode;
        }

        /// <summary>
        /// Convert <see cref="SaintHelena.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"SH-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.SaintHelena;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.SH;
        }

        /// <summary>
        /// Get Cosmos Region Code / CEP-1 from the given enum values.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RegionCodeValue GetRegionCodeValue(this EnumValues value)
        {
            return (RegionCodeValue)value.ToNumericRegionCode();
        }

        /// <summary>
        /// Get Cosmos Region Enum value / CEP-1 from the given enum values.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RegionEnumValue GetRegionEnumValue(this EnumValues value)
        {
            return RegionEnumValue.Of(() => value);
        }

        /// <summary>
        /// Get Cosmos Region Enum value / CEP-1 from the given code value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RegionEnumValue GetRegionEnumValue(this RegionCodeValue value)
        {
            return RegionEnumHelper.Value(value, InternalCrCodeMappingCache);
        }

        public static bool IsUnknownValue(this EnumValues value) => EnumValues.Unknown == value;
    }
}