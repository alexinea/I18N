using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Netherlands Regions
    /// </summary>
    public static partial class Netherlands
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        private static IEnumerable<EnumMember<EnumValues>> Filter(string flag) => RegionEnumHelper.Filter(InternalEnumMembersCache, flag);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// SintMaartenDutchPart
            /// </summary>
            public static EnumValues SintMaarten => EnumValues.SintMaarten;
        }

        #endregion

        #region Region definition

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
            [AliasInShort("SX")]
            [RegionCode(4_00_131)]
            [RegionFlag("overseas")]
            SintMaarten,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            [RegionCode(0)]
            Unknown,
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

        #region All regions getter

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

        /// <summary>
        /// Get all numeric region code(CEP-1 / Cosmos Region Code).
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetAllNumericRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToNumericRegionCode());

        #endregion
    }
}