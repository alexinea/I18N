using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    public static partial class France
    {
        /// <summary>
        /// Convert <see cref="France.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="France.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"FR-{values.ToRegionCode()}";
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
                case EnumValues.Mayotte:
                    return Country.Mayotte;
                case EnumValues.Martinique:
                    return Country.Martinique;
                case EnumValues.Guadeloupe:
                    return Country.Guadeloupe;
                case EnumValues.Guiana:
                    return Country.Guiana;
                case EnumValues.Réunion:
                    return Country.Réunion;
                case EnumValues.SaintMartin:
                    return Country.SaintMartinFrenchPart;
                case EnumValues.SouthernTerritories:
                    return Country.FrenchSouthernTerritories;
                case EnumValues.SaintBarts:
                    return Country.SaintBarts;
                default:
                    return Country.France;
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
                case EnumValues.Mayotte:
                    return CountryCode.YT;
                case EnumValues.Martinique:
                    return CountryCode.MQ;
                case EnumValues.Guadeloupe:
                    return CountryCode.GP;
                case EnumValues.Guiana:
                    return CountryCode.GF;
                case EnumValues.Réunion:
                    return CountryCode.RE;
                case EnumValues.SaintMartin:
                    return CountryCode.MF;
                case EnumValues.SouthernTerritories:
                    return CountryCode.TF;
                case EnumValues.SaintBarts:
                    return CountryCode.BL;
                default:
                    return CountryCode.FR;
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