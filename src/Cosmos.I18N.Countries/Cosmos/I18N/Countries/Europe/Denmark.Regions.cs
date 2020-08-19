using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Denmark regions
    /// </summary>
    public static partial class Denmark
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Northern Denmark
            /// </summary>
            public static EnumValues NorthernDenmark => EnumValues.NorthernDenmark;

            /// <summary>
            /// Central Denmark
            /// </summary>
            public static EnumValues CentralDenmark => EnumValues.CentralDenmark;

            /// <summary>
            /// Southern Denmark
            /// </summary>
            public static EnumValues SouthernDenmark => EnumValues.SouthernDenmark;

            /// <summary>
            /// Capital Region
            /// </summary>
            public static EnumValues CapitalRegion => EnumValues.CapitalRegion;

            /// <summary>
            /// Zealand
            /// </summary>
            public static EnumValues Zealand => EnumValues.Zealand;

            /// <summary>
            /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
            /// Cosmos i18n code: i18n_country_faluo
            /// </summary>
            public static EnumValues Faroe => EnumValues.Faroe;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special
        {
            /// <summary>
            /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
            /// Cosmos i18n code: i18n_country_faluo
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Faroe => Country.Faroe;

            /// <summary>
            /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
            /// Cosmos i18n code: i18n_country_faluo
            /// </summary>
            public static CountryCode FaroeCode => CountryCode.FO;
        }

        /// <summary>
        /// Enum values for Denmark regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Northern Denmark
            /// </summary>
            [AliasInShort("81")]
            [RegionCode(2_00_110_0081)]
            [RegionFlag("main")]
            NorthernDenmark,

            /// <summary>
            /// Central Denmark
            /// </summary>
            [AliasInShort("82")]
            [RegionCode(2_00_110_0082)]
            [RegionFlag("main")]
            CentralDenmark,

            /// <summary>
            /// Southern Denmark
            /// </summary>
            [AliasInShort("83")]
            [RegionCode(2_00_110_0083)]
            [RegionFlag("main")]
            SouthernDenmark,

            /// <summary>
            /// Capital Region
            /// </summary>
            [AliasInShort("84")]
            [RegionCode(2_00_110_0084)]
            [RegionFlag("main")]
            CapitalRegion,

            /// <summary>
            /// Zealand
            /// </summary>
            [AliasInShort("85")]
            [RegionCode(2_00_110_0085)]
            [RegionFlag("main")]
            Zealand,

            /// <summary>
            /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
            /// Cosmos i18n code: i18n_country_faluo
            /// </summary>
            [AliasInShort("FO")]
            [RegionCode(2_00_112)]
            [RegionFlag("overseas")]
            Faroe,

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
        /// Convert from special regions of Denmark
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country)
        {
            switch (country)
            {
                case Country.Faroe:
                    return EnumValues.Faroe;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of Denmark
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code)
        {
            switch (code)
            {
                case CountryCode.FO:
                    return EnumValues.Faroe;
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
        /// Get all numeric region code(CEP-1 / Cosmos Region Code).
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetAllNumericRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToNumericRegionCode());

        #endregion
    }
}