using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Netherlands Regions
    /// </summary>
    public static class NetherlandsRegions
    {
        #region Gets regions

        /// <summary>
        /// SintMaartenDutchPart
        /// </summary>
        public static EnumValues SintMaarten => EnumValues.SintMaarten;

        #endregion

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special
        {
            /// <summary>
            /// Sint Maarten Dutch Part
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country SintMaarten => Country.SintMaartenDutchPart;

            /// <summary>
            /// Sint Maarten Dutch Part
            /// </summary>
            public static CountryCode SintMaartenCode => CountryCode.SX;
        }

        /// <summary>
        /// Enum values for United Kingdom regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Sint Maarten Dutch Part
            /// </summary>
            [AliasInShort("SX")] [RegionFlag("overseas")]
            SintMaarten,

            /// <summary>
            /// 未知
            /// </summary>
            [IgnoreRegionAttribute] [AliasInShort("??")]
            Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="NetherlandsRegions.EnumValues"/> to region code likes 'ENG', 'ALD', 'GI'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="NetherlandsRegions.EnumValues"/> to full region code likes 'GB-ENG', 'GB-ALD', 'GB-GI'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"NL-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Netherlands;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.NL;
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Convert from special regions of United States
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country)
        {
            switch (country)
            {
                case Country.SintMaartenDutchPart:
                    return EnumValues.SintMaarten;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of United States
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code)
        {
            switch (code)
            {
                case CountryCode.SX:
                    return EnumValues.SintMaarten;
                default:
                    return EnumValues.Unknown;
            }
        }

        #endregion

        #region Getters

        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(member => !member.HasAttr<EnumValues, IgnoreRegionAttribute>());

        private static IEnumerable<EnumMember<EnumValues>> Filter(string flag) =>
            InternalEnumMembersCache.Where(x => x.Attributes.GetAll<RegionFlagAttribute>().Any(attr => attr.Flag == flag));

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// Get overseas region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetOverseasRegionCodes()
            => Filter("overseas").Select(member => member.Value.ToFullRegionCode());
        
        /// <summary>
        /// Get main region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMainRegionCodes()
            => Filter("main").Select(member => member.Value.ToFullRegionCode());

        #endregion
    }
}