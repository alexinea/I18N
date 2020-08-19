using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Greenland Regions
    /// </summary>
    public static partial class Greenland
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Kujalleq
            /// </summary>
            public static EnumValues Kujalleq => EnumValues.Kujalleq;

            /// <summary>
            /// Qaasuitsup
            /// </summary>
            public static EnumValues Qaasuitsup => EnumValues.Qaasuitsup;

            /// <summary>
            /// Qeqqata
            /// </summary>
            public static EnumValues Qeqqata => EnumValues.Qeqqata;

            /// <summary>
            /// Sermersooq
            /// </summary>
            public static EnumValues Sermersooq => EnumValues.Sermersooq;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Greenland regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Kujalleq
            /// </summary>
            [AliasInShort("KU")]
            [RegionCode(4_00_116_0001)]
            Kujalleq,

            /// <summary>
            /// Qaasuitsup
            /// </summary>
            [AliasInShort("QA")]
            [RegionCode(4_00_116_0002)]
            Qaasuitsup,

            /// <summary>
            /// Qeqqata
            /// </summary>
            [AliasInShort("QE")]
            [RegionCode(4_00_116_0003)]
            Qeqqata,

            /// <summary>
            /// Sermersooq
            /// </summary>
            [AliasInShort("SM")]
            [RegionCode(4_00_116_0004)]
            Sermersooq,

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