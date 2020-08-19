using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// TrinidadAndTobago Regions
    /// </summary>
    public static partial class TrinidadAndTobago
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Arima
            /// </summary>
            public static EnumValues Arima => EnumValues.Arima;

            /// <summary>
            /// Chaguanas
            /// </summary>
            public static EnumValues Chaguanas => EnumValues.Chaguanas;

            /// <summary>
            /// Couva-Tabaquite-Talparo
            /// </summary>
            public static EnumValues CouvaTabaquiteTalparo => EnumValues.CouvaTabaquiteTalparo;

            /// <summary>
            /// Diego Martin
            /// </summary>
            public static EnumValues DiegoMartin => EnumValues.DiegoMartin;

            /// <summary>
            /// Mayaro-Rio Claro
            /// </summary>
            public static EnumValues MayaroRioClaro => EnumValues.MayaroRioClaro;

            /// <summary>
            /// Penal-Debe
            /// </summary>
            public static EnumValues PenalDebe => EnumValues.PenalDebe;

            /// <summary>
            /// Port of Spain
            /// </summary>
            public static EnumValues PortOfSpain => EnumValues.PortOfSpain;

            /// <summary>
            /// Princes Town
            /// </summary>
            public static EnumValues PrincesTown => EnumValues.PrincesTown;

            /// <summary>
            /// Point Fortin
            /// </summary>
            public static EnumValues PointFortin => EnumValues.PointFortin;

            /// <summary>
            /// San Fernando
            /// </summary>
            public static EnumValues SanFernando => EnumValues.SanFernando;

            /// <summary>
            /// Sangre Grande
            /// </summary>
            public static EnumValues SangreGrande => EnumValues.SangreGrande;

            /// <summary>
            /// Siparia
            /// </summary>
            public static EnumValues Siparia => EnumValues.Siparia;

            /// <summary>
            /// San Juan-Laventille
            /// </summary>
            public static EnumValues SanJuanLaventille => EnumValues.SanJuanLaventille;

            /// <summary>
            /// Tobago
            /// </summary>
            public static EnumValues Tobago => EnumValues.Tobago;

            /// <summary>
            /// Tunapuna-Piarco
            /// </summary>
            public static EnumValues TunapunaPiarco => EnumValues.TunapunaPiarco;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for TrinidadAndTobago regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Arima
            /// </summary>
            [AliasInShort("ARI")]
            [RegionCode(4_00_134_0001)]
            Arima,

            /// <summary>
            /// Chaguanas
            /// </summary>
            [AliasInShort("CHA")]
            [RegionCode(4_00_134_0002)]
            Chaguanas,

            /// <summary>
            /// Couva-Tabaquite-Talparo
            /// </summary>
            [AliasInShort("CTT")]
            [RegionCode(4_00_134_0003)]
            CouvaTabaquiteTalparo,

            /// <summary>
            /// Diego Martin
            /// </summary>
            [AliasInShort("DMN")]
            [RegionCode(4_00_134_0004)]
            DiegoMartin,

            /// <summary>
            /// Mayaro-Rio Claro
            /// </summary>
            [AliasInShort("MRC")]
            [RegionCode(4_00_134_0005)]
            MayaroRioClaro,

            /// <summary>
            /// Penal-Debe
            /// </summary>
            [AliasInShort("PED")]
            [RegionCode(4_00_134_0006)]
            PenalDebe,

            /// <summary>
            /// Port of Spain
            /// </summary>
            [AliasInShort("POS")]
            [RegionCode(4_00_134_0007)]
            PortOfSpain,

            /// <summary>
            /// Princes Town
            /// </summary>
            [AliasInShort("PRT")]
            [RegionCode(4_00_134_0008)]
            PrincesTown,

            /// <summary>
            /// Point Fortin
            /// </summary>
            [AliasInShort("PTF")]
            [RegionCode(4_00_134_0009)]
            PointFortin,

            /// <summary>
            /// San Fernando
            /// </summary>
            [AliasInShort("SFO")]
            [RegionCode(4_00_134_0010)]
            SanFernando,

            /// <summary>
            /// Sangre Grande
            /// </summary>
            [AliasInShort("SGE")]
            [RegionCode(4_00_134_0011)]
            SangreGrande,

            /// <summary>
            /// Siparia
            /// </summary>
            [AliasInShort("SIP")]
            [RegionCode(4_00_134_0012)]
            Siparia,

            /// <summary>
            /// San Juan-Laventille
            /// </summary>
            [AliasInShort("SJL")]
            [RegionCode(4_00_134_0013)]
            SanJuanLaventille,

            /// <summary>
            /// Tobago
            /// </summary>
            [AliasInShort("TOB")]
            [RegionCode(4_00_134_0014)]
            Tobago,

            /// <summary>
            /// Tunapuna-Piarco
            /// </summary>
            [AliasInShort("TUP")]
            [RegionCode(4_00_134_0015)]
            TunapunaPiarco,

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