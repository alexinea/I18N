using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Bosnia And Herzegovina Regions
    /// </summary>
    public static partial class BosniaAndHerzegovina
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Federation of Bosnia and Herzegovina
            /// </summary>
            public static EnumValues FederationOfBosniaAndHerzegovina => EnumValues.FederationOfBosniaAndHerzegovina;

            /// <summary>
            /// Brčko District
            /// </summary>
            public static EnumValues BrčkoDistrict => EnumValues.BrčkoDistrict;

            /// <summary>
            /// Republika Srpska
            /// </summary>
            public static EnumValues RepublikaSrpskam => EnumValues.RepublikaSrpskam;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Bosnia And Herzegovina regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Federation of Bosnia and Herzegovina
            /// </summary>
            [AliasInShort("BIH")]
            [RegionCode(2_00_106_0001)]
            FederationOfBosniaAndHerzegovina,

            /// <summary>
            /// Brčko District
            /// </summary>
            [AliasInShort("BRC")]
            [RegionCode(2_00_106_0002)]
            BrčkoDistrict,

            /// <summary>
            /// Republika Srpska
            /// </summary>
            [AliasInShort("SRP")]
            [RegionCode(2_00_106_0003)]
            RepublikaSrpskam,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion]
            [AliasInShort("??")]
            [RegionCode(0)]
            Unknown,
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
        /// Get all numeric region code(CEP-1 / Cosmos Region Code).
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetAllNumericRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToNumericRegionCode());

        #endregion
    }
}