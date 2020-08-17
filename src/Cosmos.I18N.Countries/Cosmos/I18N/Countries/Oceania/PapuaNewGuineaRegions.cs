using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Oceania
{
    /// <summary>
    /// PapuaNewGuinea Regions
    /// </summary>
    public static class PapuaNewGuineaRegions
    {
        #region Gets regions

        /// <summary>
        /// Chimbu
        /// </summary>
        public static EnumValues Chimbu => EnumValues.Chimbu;

        /// <summary>
        /// Central
        /// </summary>
        public static EnumValues Central => EnumValues.Central;

        /// <summary>
        /// East New Britain
        /// </summary>
        public static EnumValues EastNewBritain => EnumValues.EastNewBritain;

        /// <summary>
        /// Eastern Highlands
        /// </summary>
        public static EnumValues EasternHighlands => EnumValues.EasternHighlands;

        /// <summary>
        /// Enga
        /// </summary>
        public static EnumValues Enga => EnumValues.Enga;

        /// <summary>
        /// East Sepik
        /// </summary>
        public static EnumValues EastSepik => EnumValues.EastSepik;

        /// <summary>
        /// Gulf
        /// </summary>
        public static EnumValues Gulf => EnumValues.Gulf;

        /// <summary>
        /// Hela
        /// </summary>
        public static EnumValues Hela => EnumValues.Hela;

        /// <summary>
        /// Jiwaka
        /// </summary>
        public static EnumValues Jiwaka => EnumValues.Jiwaka;

        /// <summary>
        /// Milne Bay
        /// </summary>
        public static EnumValues MilneBay => EnumValues.MilneBay;

        /// <summary>
        /// Morobe
        /// </summary>
        public static EnumValues Morobe => EnumValues.Morobe;

        /// <summary>
        /// Madang
        /// </summary>
        public static EnumValues Madang => EnumValues.Madang;

        /// <summary>
        /// Manus
        /// </summary>
        public static EnumValues Manus => EnumValues.Manus;

        /// <summary>
        /// Port Moresby
        /// </summary>
        public static EnumValues PortMoresby => EnumValues.PortMoresby;

        /// <summary>
        /// New Ireland
        /// </summary>
        public static EnumValues NewIreland => EnumValues.NewIreland;

        /// <summary>
        /// Oro
        /// </summary>
        public static EnumValues Oro => EnumValues.Oro;

        /// <summary>
        /// Bougainville
        /// </summary>
        public static EnumValues Bougainville => EnumValues.Bougainville;

        /// <summary>
        /// Sandaun
        /// </summary>
        public static EnumValues Sandaun => EnumValues.Sandaun;

        /// <summary>
        /// Southern Highlands
        /// </summary>
        public static EnumValues SouthernHighlands => EnumValues.SouthernHighlands;

        /// <summary>
        /// West New Britain
        /// </summary>
        public static EnumValues WestNewBritain => EnumValues.WestNewBritain;

        /// <summary>
        /// Western Highlands
        /// </summary>
        public static EnumValues WesternHighlands => EnumValues.WesternHighlands;

        /// <summary>
        /// Western
        /// </summary>
        public static EnumValues Western => EnumValues.Western;

        #endregion

        /// <summary>
        /// Enum values for PapuaNewGuinea regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Chimbu
            /// </summary>
            [AliasInShort("CPK")] [RegionCode(6_00_114_0001)]
            Chimbu,

            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("CPM")] [RegionCode(6_00_114_0002)]
            Central,

            /// <summary>
            /// East New Britain
            /// </summary>
            [AliasInShort("EBK")] [RegionCode(6_00_114_0003)]
            EastNewBritain,

            /// <summary>
            /// Eastern Highlands
            /// </summary>
            [AliasInShort("EHG")] [RegionCode(6_00_114_0004)]
            EasternHighlands,

            /// <summary>
            /// Enga
            /// </summary>
            [AliasInShort("EPW")] [RegionCode(6_00_114_0005)]
            Enga,

            /// <summary>
            /// East Sepik
            /// </summary>
            [AliasInShort("ESW")] [RegionCode(6_00_114_0006)]
            EastSepik,

            /// <summary>
            /// Gulf
            /// </summary>
            [AliasInShort("GPK")] [RegionCode(6_00_114_0007)]
            Gulf,

            /// <summary>
            /// Hela
            /// </summary>
            [AliasInShort("HLA")] [RegionCode(6_00_114_0008)]
            Hela,

            /// <summary>
            /// Imbabura
            /// </summary>
            [AliasInShort("JWK")] [RegionCode(6_00_114_0009)]
            Jiwaka,

            /// <summary>
            /// Milne Bay
            /// </summary>
            [AliasInShort("MBA")] [RegionCode(6_00_114_0010)]
            MilneBay,

            /// <summary>
            /// Morobe
            /// </summary>
            [AliasInShort("MPL")] [RegionCode(6_00_114_0011)]
            Morobe,

            /// <summary>
            /// Madang
            /// </summary>
            [AliasInShort("MPM")] [RegionCode(6_00_114_0012)]
            Madang,

            /// <summary>
            /// Manus
            /// </summary>
            [AliasInShort("MRL")] [RegionCode(6_00_114_0013)]
            Manus,

            /// <summary>
            /// Port Moresby
            /// </summary>
            [AliasInShort("NCD")] [RegionCode(6_00_114_0014)]
            PortMoresby,

            /// <summary>
            /// New Ireland
            /// </summary>
            [AliasInShort("NIK")] [RegionCode(6_00_114_0015)]
            NewIreland,

            /// <summary>
            /// Oro
            /// </summary>
            [AliasInShort("NPP")] [RegionCode(6_00_114_0016)]
            Oro,

            /// <summary>
            /// Bougainville
            /// </summary>
            [AliasInShort("NSB")] [RegionCode(6_00_114_0017)]
            Bougainville,

            /// <summary>
            /// Sandaun
            /// </summary>
            [AliasInShort("SAN")] [RegionCode(6_00_114_0018)]
            Sandaun,

            /// <summary>
            /// Southern Highlands
            /// </summary>
            [AliasInShort("SHM")] [RegionCode(6_00_114_0019)]
            SouthernHighlands,

            /// <summary>
            /// West New Britain
            /// </summary>
            [AliasInShort("WBK")] [RegionCode(6_00_114_0020)]
            WestNewBritain,

            /// <summary>
            /// Western Highlands
            /// </summary>
            [AliasInShort("WHM")] [RegionCode(6_00_114_0021)]
            WesternHighlands,

            /// <summary>
            /// Western
            /// </summary>
            [AliasInShort("WPD")] [RegionCode(6_00_114_0022)]
            Western,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="PapuaNewGuineaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="PapuaNewGuineaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"PG-{values.ToRegionCode()}";
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
            return Country.PapuaNewGuinea;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.PG;
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