using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Lesotho Regions
    /// </summary>
    public static  partial class Lesotho 
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {

        /// <summary>
        /// Maseru
        /// </summary>
        public static EnumValues Maseru => EnumValues.Maseru;

        /// <summary>
        /// Butha-Buthe
        /// </summary>
        public static EnumValues ButhaButhe => EnumValues.ButhaButhe;

        /// <summary>
        /// Leribe
        /// </summary>
        public static EnumValues Leribe => EnumValues.Leribe;

        /// <summary>
        /// Berea
        /// </summary>
        public static EnumValues Berea => EnumValues.Berea;

        /// <summary>
        /// Mafeteng
        /// </summary>
        public static EnumValues Mafeteng => EnumValues.Mafeteng;

        /// <summary>
        /// Mohale’s Hoek
        /// </summary>
        public static EnumValues MohalesHoek => EnumValues.MohalesHoek;

        /// <summary>
        /// Quthing
        /// </summary>
        public static EnumValues Quthing => EnumValues.Quthing;

        /// <summary>
        /// Qacha’s Nek
        /// </summary>
        public static EnumValues QachasNek => EnumValues.QachasNek;

        /// <summary>
        /// Mokhotlong
        /// </summary>
        public static EnumValues Mokhotlong => EnumValues.Mokhotlong;

        /// <summary>
        /// Thaba-Tseka
        /// </summary>
        public static EnumValues ThabaTseka => EnumValues.ThabaTseka;

        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Lesotho regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Maseru
            /// </summary>
            [AliasInShort("A")][RegionCode(3_00_131_0001)] Maseru,

            /// <summary>
            /// Butha-Buthe
            /// </summary>
            [AliasInShort("B")][RegionCode(3_00_131_0002)] ButhaButhe,

            /// <summary>
            /// Leribe
            /// </summary>
            [AliasInShort("C")][RegionCode(3_00_131_0003)] Leribe,

            /// <summary>
            /// Berea
            /// </summary>
            [AliasInShort("D")][RegionCode(3_00_131_0004)] Berea,

            /// <summary>
            /// Mafeteng
            /// </summary>
            [AliasInShort("E")][RegionCode(3_00_131_0005)] Mafeteng,

            /// <summary>
            /// Mohale’s Hoek
            /// </summary>
            [AliasInShort("F")][RegionCode(3_00_131_0006)] MohalesHoek,

            /// <summary>
            /// Quthing
            /// </summary>
            [AliasInShort("G")][RegionCode(3_00_131_0007)] Quthing,

            /// <summary>
            /// Qacha’s Nek
            /// </summary>
            [AliasInShort("H")][RegionCode(3_00_131_0008)] QachasNek,

            /// <summary>
            /// Mokhotlong
            /// </summary>
            [AliasInShort("J")][RegionCode(3_00_131_0009)] Mokhotlong,

            /// <summary>
            /// Thaba-Tseka
            /// </summary>
            [AliasInShort("K")][RegionCode(3_00_131_0010)] ThabaTseka,

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