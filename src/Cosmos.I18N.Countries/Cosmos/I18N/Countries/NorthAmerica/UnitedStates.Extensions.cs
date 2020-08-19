using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    public static partial class UnitedStates
    {
        /// <summary>
        /// Convert <see cref="UnitedStates.EnumValues"/> to region code likes 'NY', 'GU', 'WDC'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="UnitedStates.EnumValues"/> to full region code likes 'US-NY', 'US-GU', 'US-WDC'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"US-{values.ToRegionCode()}";
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
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            switch (value)
            {
                case EnumValues.VirginIslands:
                    return Country.VirginIslandsUS;
                case EnumValues.NorthernMarianaIslands:
                    return Country.NorthernMarianaIslands;
                case EnumValues.PuertoRico:
                    return Country.PuertoRico;
                case EnumValues.Guam:
                    return Country.Guam;
                case EnumValues.EasternSamoa:
                    return Country.AmericanSamoa;
                case EnumValues.MinorOutlyingIslands:
                    return Country.UnitedStatesMinorOutlyingIslands;
                default:
                    return Country.UnitedStates;
            }
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            switch (value)
            {
                case EnumValues.VirginIslands:
                    return CountryCode.VI;
                case EnumValues.NorthernMarianaIslands:
                    return CountryCode.MP;
                case EnumValues.PuertoRico:
                    return CountryCode.PR;
                case EnumValues.Guam:
                    return CountryCode.GU;
                case EnumValues.EasternSamoa:
                    return CountryCode.AS;
                case EnumValues.MinorOutlyingIslands:
                    return CountryCode.UM;
                default:
                    return CountryCode.US;
            }
        }

        /// <summary>
        /// Get Cosmos Region Code / CEP-1 from the given enum values.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RegionCodeValue GetRegionCodeValue(this EnumValues value)
        {
            return (RegionCodeValue) value.ToNumericRegionCode();
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