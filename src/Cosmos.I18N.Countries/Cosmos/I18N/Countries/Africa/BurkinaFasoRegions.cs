using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// BurkinaFaso regions
    /// </summary>
    public static class BurkinaFasoRegions
    {
        #region Getes regions

        /// <summary>
        /// Nord
        /// </summary>
        public static EnumValues Nord => EnumValues.Nord;

        /// <summary>
        /// Plateau-Central
        /// </summary>
        public static EnumValues PlateauCentral => EnumValues.PlateauCentral;

        /// <summary>
        /// Sahel
        /// </summary>
        public static EnumValues Sahel => EnumValues.Sahel;

        /// <summary>
        /// Sud-Ouest
        /// </summary>
        public static EnumValues SudOuest => EnumValues.SudOuest;

        /// <summary>
        /// Boucle du Mouhoun
        /// </summary>
        public static EnumValues BoucleDuMouhoun => EnumValues.BoucleDuMouhoun;

        /// <summary>
        /// Cascades
        /// </summary>
        public static EnumValues Cascades => EnumValues.Cascades;

        /// <summary>
        /// Centre
        /// </summary>
        public static EnumValues Centre => EnumValues.Centre;

        /// <summary>
        /// Centre-Est
        /// </summary>
        public static EnumValues CentreEst => EnumValues.CentreEst;

        /// <summary>
        /// Centre-Nord
        /// </summary>
        public static EnumValues CentreNord => EnumValues.CentreNord;

        /// <summary>
        /// Centre-Ouest
        /// </summary>
        public static EnumValues CentreOuest => EnumValues.CentreOuest;

        /// <summary>
        /// Centre-Sud
        /// </summary>
        public static EnumValues CentreSud => EnumValues.CentreSud;

        /// <summary>
        /// Est
        /// </summary>
        public static EnumValues Est => EnumValues.Est;

        /// <summary>
        /// Hauts-Bassins
        /// </summary>
        public static EnumValues HautsBassins => EnumValues.HautsBassins;

        #endregion

        /// <summary>
        /// Enum values for BurkinaFaso regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Nord
            /// </summary>
            [AliasInShort("10")][RegionCode(3_00_105_0010)] Nord,

            /// <summary>
            /// Plateau-Central
            /// </summary>
            [AliasInShort("11")][RegionCode(3_00_105_0011)] PlateauCentral,

            /// <summary>
            /// Sahel
            /// </summary>
            [AliasInShort("12")][RegionCode(3_00_105_0012)] Sahel,

            /// <summary>
            /// Sud-Ouest
            /// </summary>
            [AliasInShort("13")][RegionCode(3_00_105_0013)] SudOuest,

            /// <summary>
            /// Boucle du Mouhoun
            /// </summary>
            [AliasInShort("01")][RegionCode(3_00_105_0001)] BoucleDuMouhoun,

            /// <summary>
            /// Cascades
            /// </summary>
            [AliasInShort("02")][RegionCode(3_00_105_0002)] Cascades,

            /// <summary>
            /// Centre
            /// </summary>
            [AliasInShort("03")][RegionCode(3_00_105_0003)] Centre,

            /// <summary>
            /// Centre-Est
            /// </summary>
            [AliasInShort("04")][RegionCode(3_00_105_0004)] CentreEst,

            /// <summary>
            /// Centre-Nord
            /// </summary>
            [AliasInShort("05")][RegionCode(3_00_105_0005)] CentreNord,

            /// <summary>
            /// Centre-Ouest
            /// </summary>
            [AliasInShort("06")][RegionCode(3_00_105_0006)] CentreOuest,

            /// <summary>
            /// Centre-Sud
            /// </summary>
            [AliasInShort("07")][RegionCode(3_00_105_0007)] CentreSud,

            /// <summary>
            /// Est
            /// </summary>
            [AliasInShort("08")][RegionCode(3_00_105_0008)] Est,

            /// <summary>
            /// Hauts-Bassins
            /// </summary>
            [AliasInShort("09")][RegionCode(3_00_105_0009)] HautsBassins,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="BurkinaFasoRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="BurkinaFasoRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"BF-{values.ToRegionCode()}";
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
            return Country.BurkinaFaso;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.BF;
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