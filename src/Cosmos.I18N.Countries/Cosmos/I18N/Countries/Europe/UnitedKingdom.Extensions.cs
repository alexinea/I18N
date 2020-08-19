using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    public static partial class UnitedKingdom
    {
        /// <summary>
        /// Convert <see cref="UnitedKingdom.EnumValues"/> to region code likes 'ENG', 'ALD', 'GI'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="UnitedKingdom.EnumValues"/> to full region code likes 'GB-ENG', 'GB-ALD', 'GB-GI'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"GB-{values.ToRegionCode()}";
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
                case EnumValues.Guernsey:
                    return Country.Guernsey;
                case EnumValues.Jersey:
                    return Country.Jersey;
                case EnumValues.Mann:
                    return Country.Mann;
                case EnumValues.Gibraltar:
                    return Country.Gibraltar;
                case EnumValues.Bermuda:
                    return Country.Bermuda;
                case EnumValues.CaymanIslands:
                    return Country.CaymanIslands;
                case EnumValues.TurksAndCaicosIslands:
                    return Country.TurksAndCaicosIslands;
                case EnumValues.BritishVirginIslands:
                    return Country.VirginIslandsBritish;
                case EnumValues.Anguilla:
                    return Country.Anguilla;
                case EnumValues.Montserrat:
                    return Country.Montserrat;
                case EnumValues.SaintHelena:
                    return Country.SaintHelena;
                case EnumValues.SGSSI:
                    return Country.SGSSI;
                case EnumValues.BritishIndianOceanTerritory:
                    return Country.BritishIndianOceanTerritory;
                case EnumValues.Pitcairn:
                    return Country.Pitcairn;
                default:
                    return Country.UnitedKingdom;
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
                case EnumValues.Guernsey:
                    return CountryCode.GG;
                case EnumValues.Jersey:
                    return CountryCode.JE;
                case EnumValues.Mann:
                    return CountryCode.IM;
                case EnumValues.Gibraltar:
                    return CountryCode.GI;
                case EnumValues.Bermuda:
                    return CountryCode.BM;
                case EnumValues.CaymanIslands:
                    return CountryCode.KY;
                case EnumValues.TurksAndCaicosIslands:
                    return CountryCode.TC;
                case EnumValues.BritishVirginIslands:
                    return CountryCode.VG;
                case EnumValues.Anguilla:
                    return CountryCode.AI;
                case EnumValues.Montserrat:
                    return CountryCode.MS;
                case EnumValues.SaintHelena:
                    return CountryCode.SH;
                case EnumValues.SGSSI:
                    return CountryCode.GS;
                case EnumValues.BritishIndianOceanTerritory:
                    return CountryCode.IO;
                case EnumValues.Pitcairn:
                    return CountryCode.PN;
                default:
                    return CountryCode.GB;
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