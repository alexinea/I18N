using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Czechia regions
    /// </summary>
    public static class CzechiaRegions
    {
        #region Gets regions

        /// <summary>
        /// South Bohemia
        /// </summary>
        public static EnumValues SouthBohemia => EnumValues.SouthBohemia;

        /// <summary>
        /// South Moravia
        /// </summary>
        public static EnumValues SouthMoravia => EnumValues.SouthMoravia;

        /// <summary>
        /// Karlovy Vary Region
        /// </summary>
        public static EnumValues KarlovyVaryRegion => EnumValues.KarlovyVaryRegion;

        /// <summary>
        /// Hradec Králové Region
        /// </summary>
        public static EnumValues HradecKrálovéRegion => EnumValues.HradecKrálovéRegion;

        /// <summary>
        /// Liberec Region
        /// </summary>
        public static EnumValues LiberecRegion => EnumValues.LiberecRegion;

        /// <summary>
        /// Moravian-Silesia
        /// </summary>
        public static EnumValues MoravianSilesia => EnumValues.MoravianSilesia;

        /// <summary>
        /// Olomouc Region
        /// </summary>
        public static EnumValues OlomoucRegion => EnumValues.OlomoucRegion;

        /// <summary>
        /// Pardubice Region
        /// </summary>
        public static EnumValues PardubiceRegion => EnumValues.PardubiceRegion;

        /// <summary>
        /// Plzeň Region
        /// </summary>
        public static EnumValues PlzeňRegion => EnumValues.PlzeňRegion;

        /// <summary>
        /// Prague
        /// </summary>
        public static EnumValues Prague => EnumValues.Prague;

        /// <summary>
        /// Central Bohemia
        /// </summary>
        public static EnumValues CentralBohemia => EnumValues.CentralBohemia;

        /// <summary>
        /// Ústí nad Labem Region
        /// </summary>
        public static EnumValues ÚstíNadLabemRegion => EnumValues.ÚstíNadLabemRegion;

        /// <summary>
        /// Vysočina
        /// </summary>
        public static EnumValues Vysočina => EnumValues.Vysočina;

        /// <summary>
        /// Zlín Region
        /// </summary>
        public static EnumValues ZlínRegion => EnumValues.ZlínRegion;

        #endregion

        /// <summary>
        /// Enum values for Czechia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// South Bohemia
            /// </summary>
            [AliasInShort("JC")] [RegionCode(2_00_012_0001)]
            SouthBohemia,

            /// <summary>
            /// South Moravia
            /// </summary>
            [AliasInShort("JM")] [RegionCode(2_00_012_0002)]
            SouthMoravia,

            /// <summary>
            /// Karlovy Vary Region
            /// </summary>
            [AliasInShort("KA")] [RegionCode(2_00_012_0003)]
            KarlovyVaryRegion,

            /// <summary>
            /// Hradec Králové Region
            /// </summary>
            [AliasInShort("KR")] [RegionCode(2_00_012_0004)]
            HradecKrálovéRegion,

            /// <summary>
            /// Liberec Region
            /// </summary>
            [AliasInShort("LI")] [RegionCode(2_00_012_0005)]
            LiberecRegion,

            /// <summary>
            /// Moravian-Silesia
            /// </summary>
            [AliasInShort("NO")] [RegionCode(2_00_012_0006)]
            MoravianSilesia,

            /// <summary>
            /// Olomouc Region
            /// </summary>
            [AliasInShort("OL")] [RegionCode(2_00_012_0007)]
            OlomoucRegion,

            /// <summary>
            /// Pardubice Region
            /// </summary>
            [AliasInShort("PA")] [RegionCode(2_00_012_0008)]
            PardubiceRegion,

            /// <summary>
            /// Plzeň Region
            /// </summary>
            [AliasInShort("PL")] [RegionCode(2_00_012_0009)]
            PlzeňRegion,

            /// <summary>
            /// Prague
            /// </summary>
            [AliasInShort("PR")] [RegionCode(2_00_012_0010)]
            Prague,

            /// <summary>
            /// Central Bohemia
            /// </summary>
            [AliasInShort("ST")] [RegionCode(2_00_012_0011)]
            CentralBohemia,

            /// <summary>
            /// Ústí nad Labem Region
            /// </summary>
            [AliasInShort("US")] [RegionCode(2_00_012_0012)]
            ÚstíNadLabemRegion,

            /// <summary>
            /// Vysočina
            /// </summary>
            [AliasInShort("VY")] [RegionCode(2_00_012_0013)]
            Vysočina,

            /// <summary>
            /// Zlín Region
            /// </summary>
            [AliasInShort("ZL")] [RegionCode(2_00_012_0014)]
            ZlínRegion,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="CzechiaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="CzechiaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"CZ-{values.ToRegionCode()}";
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
            return Country.Czechia;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.CZ;
        }

        #endregion

        #region Getters

        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(member => !member.HasAttr<EnumValues, IgnoreRegionAttribute>());

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