using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Bulgaria regions
    /// </summary>
    public static partial class Bulgaria
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Blagoevgrad
            /// </summary>
            public static EnumValues Blagoevgrad => EnumValues.Blagoevgrad;

            /// <summary>
            /// Burgas
            /// </summary>
            public static EnumValues Burgas => EnumValues.Burgas;

            /// <summary>
            /// Varna
            /// </summary>
            public static EnumValues Varna => EnumValues.Varna;

            /// <summary>
            /// Veliko Tarnovo
            /// </summary>
            public static EnumValues VelikoTarnovo => EnumValues.VelikoTarnovo;

            /// <summary>
            /// Vidin
            /// </summary>
            public static EnumValues Vidin => EnumValues.Vidin;

            /// <summary>
            /// Vratsa
            /// </summary>
            public static EnumValues Vratsa => EnumValues.Vratsa;

            /// <summary>
            /// Gabrovo
            /// </summary>
            public static EnumValues Gabrovo => EnumValues.Gabrovo;

            /// <summary>
            /// Dobrich
            /// </summary>
            public static EnumValues Dobrich => EnumValues.Dobrich;

            /// <summary>
            /// Kardzhali
            /// </summary>
            public static EnumValues Kardzhali => EnumValues.Kardzhali;

            /// <summary>
            /// Kyustendil
            /// </summary>
            public static EnumValues Kyustendil => EnumValues.Kyustendil;

            /// <summary>
            /// Lovech
            /// </summary>
            public static EnumValues Lovech => EnumValues.Lovech;

            /// <summary>
            /// Montana
            /// </summary>
            public static EnumValues Montana => EnumValues.Montana;

            /// <summary>
            /// Pazardzhik
            /// </summary>
            public static EnumValues Pazardzhik => EnumValues.Pazardzhik;

            /// <summary>
            /// Pernik
            /// </summary>
            public static EnumValues Pernik => EnumValues.Pernik;

            /// <summary>
            /// Pleven
            /// </summary>
            public static EnumValues Pleven => EnumValues.Pleven;

            /// <summary>
            /// Plovdiv
            /// </summary>
            public static EnumValues Plovdiv => EnumValues.Plovdiv;

            /// <summary>
            /// Razgrad
            /// </summary>
            public static EnumValues Razgrad => EnumValues.Razgrad;

            /// <summary>
            /// Ruse
            /// </summary>
            public static EnumValues Ruse => EnumValues.Ruse;

            /// <summary>
            /// Silistra
            /// </summary>
            public static EnumValues Silistra => EnumValues.Silistra;

            /// <summary>
            /// Sliven
            /// </summary>
            public static EnumValues Sliven => EnumValues.Sliven;

            /// <summary>
            /// Smolyan
            /// </summary>
            public static EnumValues Smolyan => EnumValues.Smolyan;

            /// <summary>
            /// Sofia
            /// </summary>
            public static EnumValues Sofia => EnumValues.Sofia;

            /// <summary>
            /// Sofia District
            /// </summary>
            public static EnumValues SofiaDistrict => EnumValues.SofiaDistrict;

            /// <summary>
            /// Stara Zagora
            /// </summary>
            public static EnumValues StaraZagora => EnumValues.StaraZagora;

            /// <summary>
            /// Targovishte
            /// </summary>
            public static EnumValues Targovishte => EnumValues.Targovishte;

            /// <summary>
            /// Haskovo
            /// </summary>
            public static EnumValues Haskovo => EnumValues.Haskovo;

            /// <summary>
            /// Shumen
            /// </summary>
            public static EnumValues Shumen => EnumValues.Shumen;

            /// <summary>
            /// Yambol
            /// </summary>
            public static EnumValues Yambol => EnumValues.Yambol;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Bulgaria regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Blagoevgrad
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(2_00_108_0001)]
            Blagoevgrad,

            /// <summary>
            /// Burgas
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(2_00_108_0002)]
            Burgas,

            /// <summary>
            /// Varna
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(2_00_108_0003)]
            Varna,

            /// <summary>
            /// Veliko Tarnovo
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(2_00_108_0004)]
            VelikoTarnovo,

            /// <summary>
            /// Vidin
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(2_00_108_0005)]
            Vidin,

            /// <summary>
            /// Vratsa
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(2_00_108_0006)]
            Vratsa,

            /// <summary>
            /// Gabrovo
            /// </summary>
            [AliasInShort("07")]
            [RegionCode(2_00_108_0007)]
            Gabrovo,

            /// <summary>
            /// Dobrich
            /// </summary>
            [AliasInShort("08")]
            [RegionCode(2_00_108_0008)]
            Dobrich,

            /// <summary>
            /// Kardzhali
            /// </summary>
            [AliasInShort("09")]
            [RegionCode(2_00_108_0009)]
            Kardzhali,

            /// <summary>
            /// Kyustendil
            /// </summary>
            [AliasInShort("10")]
            Kyustendil,

            /// <summary>
            /// Lovech
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(2_00_108_0011)]
            Lovech,

            /// <summary>
            /// Montana
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(2_00_108_0012)]
            Montana,

            /// <summary>
            /// Pazardzhik
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(2_00_108_0013)]
            Pazardzhik,

            /// <summary>
            /// Pernik
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(2_00_108_0014)]
            Pernik,

            /// <summary>
            /// Pleven
            /// </summary>
            [AliasInShort("15")]
            [RegionCode(2_00_108_0015)]
            Pleven,

            /// <summary>
            /// Plovdiv
            /// </summary>
            [AliasInShort("16")]
            [RegionCode(2_00_108_0016)]
            Plovdiv,

            /// <summary>
            /// Razgrad
            /// </summary>
            [AliasInShort("17")]
            [RegionCode(2_00_108_0017)]
            Razgrad,

            /// <summary>
            /// Ruse
            /// </summary>
            [AliasInShort("18")]
            [RegionCode(2_00_108_0018)]
            Ruse,

            /// <summary>
            /// Silistra
            /// </summary>
            [AliasInShort("19")]
            [RegionCode(2_00_108_0010)]
            Silistra,

            /// <summary>
            /// Sliven
            /// </summary>
            [AliasInShort("20")]
            [RegionCode(2_00_108_0020)]
            Sliven,

            /// <summary>
            /// Smolyan
            /// </summary>
            [AliasInShort("21")]
            [RegionCode(2_00_108_0021)]
            Smolyan,

            /// <summary>
            /// Sofia
            /// </summary>
            [AliasInShort("22")]
            [RegionCode(2_00_108_0022)]
            Sofia,

            /// <summary>
            /// Sofia District
            /// </summary>
            [AliasInShort("23")]
            [RegionCode(2_00_108_0023)]
            SofiaDistrict,

            /// <summary>
            /// Stara Zagora
            /// </summary>
            [AliasInShort("24")]
            [RegionCode(2_00_108_0024)]
            StaraZagora,

            /// <summary>
            /// Targovishte
            /// </summary>
            [AliasInShort("25")]
            [RegionCode(2_00_108_0025)]
            Targovishte,

            /// <summary>
            /// Haskovo
            /// </summary>
            [AliasInShort("26")]
            [RegionCode(2_00_108_0026)]
            Haskovo,

            /// <summary>
            /// Shumen
            /// </summary>
            [AliasInShort("27")]
            [RegionCode(2_00_108_0027)]
            Shumen,

            /// <summary>
            /// Yambol
            /// </summary>
            [AliasInShort("28")]
            [RegionCode(2_00_108_0028)]
            Yambol,


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