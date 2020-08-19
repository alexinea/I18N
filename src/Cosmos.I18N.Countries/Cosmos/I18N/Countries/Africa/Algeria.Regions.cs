using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Algeria regions
    /// </summary>
    public static partial class Algeria
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Bouira
            /// </summary>
            public static EnumValues Bouira => EnumValues.Bouira;

            /// <summary>
            /// Tamanghasset
            /// </summary>
            public static EnumValues Tamanghasset => EnumValues.Tamanghasset;

            /// <summary>
            /// Tébessa
            /// </summary>
            public static EnumValues Tébessa => EnumValues.Tébessa;

            /// <summary>
            /// Tlemcen
            /// </summary>
            public static EnumValues Tlemcen => EnumValues.Tlemcen;

            /// <summary>
            /// Tiaret
            /// </summary>
            public static EnumValues Tiaret => EnumValues.Tiaret;

            /// <summary>
            /// Tizi Ouzou
            /// </summary>
            public static EnumValues TiziOuzou => EnumValues.TiziOuzou;

            /// <summary>
            /// Algiers
            /// </summary>
            public static EnumValues Algiers => EnumValues.Algiers;

            /// <summary>
            /// Djelfa
            /// </summary>
            public static EnumValues Djelfa => EnumValues.Djelfa;

            /// <summary>
            /// Jijel
            /// </summary>
            public static EnumValues Jijel => EnumValues.Jijel;

            /// <summary>
            /// Sétif
            /// </summary>
            public static EnumValues Sétif => EnumValues.Sétif;

            /// <summary>
            /// Saïda
            /// </summary>
            public static EnumValues Saïda => EnumValues.Saïda;

            /// <summary>
            /// Skikda
            /// </summary>
            public static EnumValues Skikda => EnumValues.Skikda;

            /// <summary>
            /// Sidi Bel Abbès
            /// </summary>
            public static EnumValues SidiBelAbbès => EnumValues.SidiBelAbbès;

            /// <summary>
            /// Annaba
            /// </summary>
            public static EnumValues Annaba => EnumValues.Annaba;

            /// <summary>
            /// Guelma
            /// </summary>
            public static EnumValues Guelma => EnumValues.Guelma;

            /// <summary>
            /// Constantine 
            /// </summary>
            public static EnumValues Constantine => EnumValues.Constantine;

            /// <summary>
            /// Médéa
            /// </summary>
            public static EnumValues Médéa => EnumValues.Médéa;

            /// <summary>
            /// Mostaganem 
            /// </summary>
            public static EnumValues Mostaganem => EnumValues.Mostaganem;

            /// <summary>
            /// M’Sila 
            /// </summary>
            public static EnumValues MSila => EnumValues.MSila;

            /// <summary>
            /// Mascara 
            /// </summary>
            public static EnumValues Mascara => EnumValues.Mascara;

            /// <summary>
            /// Ouargla 
            /// </summary>
            public static EnumValues Ouargla => EnumValues.Ouargla;

            /// <summary>
            /// Oran 
            /// </summary>
            public static EnumValues Oran => EnumValues.Oran;

            /// <summary>
            /// El Bayadh
            /// </summary>
            public static EnumValues ElBayadh => EnumValues.ElBayadh;

            /// <summary>
            /// Illizi 
            /// </summary>
            public static EnumValues Illizi => EnumValues.Illizi;

            /// <summary>
            /// Bordj Bou Arréridj
            /// </summary>
            public static EnumValues BordjBouArréridj => EnumValues.BordjBouArréridj;

            /// <summary>
            /// Boumerdès 
            /// </summary>
            public static EnumValues Boumerdès => EnumValues.Boumerdès;

            /// <summary>
            /// El Tarf 
            /// </summary>
            public static EnumValues ElTarf => EnumValues.ElTarf;

            /// <summary>
            /// Tindouf
            /// </summary>
            public static EnumValues Tindouf => EnumValues.Tindouf;

            /// <summary>
            /// Tissemsilt 
            /// </summary>
            public static EnumValues Tissemsilt => EnumValues.Tissemsilt;

            /// <summary>
            /// El Oued 
            /// </summary>
            public static EnumValues ElOued => EnumValues.ElOued;

            /// <summary>
            /// Khenchela
            /// </summary>
            public static EnumValues Khenchela => EnumValues.Khenchela;

            /// <summary>
            /// Souk Ahras 
            /// </summary>
            public static EnumValues SoukAhras => EnumValues.SoukAhras;

            /// <summary>
            /// Tipasa 
            /// </summary>
            public static EnumValues Tipasa => EnumValues.Tipasa;

            /// <summary>
            /// Mila
            /// </summary>
            public static EnumValues Mila => EnumValues.Mila;

            /// <summary>
            /// Aïn Defla
            /// </summary>
            public static EnumValues AïnDefla => EnumValues.AïnDefla;

            /// <summary>
            /// Naama
            /// </summary>
            public static EnumValues Naama => EnumValues.Naama;

            /// <summary>
            /// Aïn Témouchent
            /// </summary>
            public static EnumValues AïnTémouchent => EnumValues.AïnTémouchent;

            /// <summary>
            /// Ghardaïa
            /// </summary>
            public static EnumValues Ghardaïa => EnumValues.Ghardaïa;

            /// <summary>
            /// Relizane
            /// </summary>
            public static EnumValues Relizane => EnumValues.Relizane;

            /// <summary>
            /// Adrar
            /// </summary>
            public static EnumValues Adrar => EnumValues.Adrar;

            /// <summary>
            /// Chlef
            /// </summary>
            public static EnumValues Chlef => EnumValues.Chlef;

            /// <summary>
            /// Laghouat
            /// </summary>
            public static EnumValues Laghouat => EnumValues.Laghouat;

            /// <summary>
            /// Oum El Bouaghi
            /// </summary>
            public static EnumValues OumElBouaghi => EnumValues.OumElBouaghi;

            /// <summary>
            /// Batna
            /// </summary>
            public static EnumValues Batna => EnumValues.Batna;

            /// <summary>
            /// Béjaïa
            /// </summary>
            public static EnumValues Béjaïa => EnumValues.Béjaïa;

            /// <summary>
            /// Biskra
            /// </summary>
            public static EnumValues Biskra => EnumValues.Biskra;

            /// <summary>
            /// Béchar
            /// </summary>
            public static EnumValues Béchar => EnumValues.Béchar;

            /// <summary>
            /// Blida
            /// </summary>
            public static EnumValues Blida => EnumValues.Blida;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Enum values for Algeria regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bouira
            /// </summary>
            [AliasInShort("10")]
            [RegionCode(3_00_101_0010)]
            Bouira,

            /// <summary>
            /// Tamanghasset
            /// </summary>
            [AliasInShort("11")]
            [RegionCode(3_00_101_0011)]
            Tamanghasset,

            /// <summary>
            /// Tébessa
            /// </summary>
            [AliasInShort("12")]
            [RegionCode(3_00_101_0012)]
            Tébessa,

            /// <summary>
            /// Tlemcen
            /// </summary>
            [AliasInShort("13")]
            [RegionCode(3_00_101_0013)]
            Tlemcen,

            /// <summary>
            /// Tiaret
            /// </summary>
            [AliasInShort("14")]
            [RegionCode(3_00_101_0014)]
            Tiaret,

            /// <summary>
            /// Tizi Ouzou
            /// </summary>
            [AliasInShort("15")]
            [RegionCode(3_00_101_0015)]
            TiziOuzou,

            /// <summary>
            /// Algiers
            /// </summary>
            [AliasInShort("16")]
            [RegionCode(3_00_101_0016)]
            Algiers,

            /// <summary>
            /// Djelfa
            /// </summary>
            [AliasInShort("17")]
            [RegionCode(3_00_101_0017)]
            Djelfa,

            /// <summary>
            /// Jijel
            /// </summary>
            [AliasInShort("18")]
            [RegionCode(3_00_101_0018)]
            Jijel,

            /// <summary>
            /// Sétif
            /// </summary>
            [AliasInShort("19")]
            [RegionCode(3_00_101_0019)]
            Sétif,

            /// <summary>
            /// Saïda
            /// </summary>
            [AliasInShort("20")]
            [RegionCode(3_00_101_0020)]
            Saïda,

            /// <summary>
            /// Skikda
            /// </summary>
            [AliasInShort("21")]
            [RegionCode(3_00_101_0021)]
            Skikda,

            /// <summary>
            /// Sidi Bel Abbès
            /// </summary>
            [AliasInShort("22")]
            [RegionCode(3_00_101_0022)]
            SidiBelAbbès,

            /// <summary>
            /// Annaba
            /// </summary>
            [AliasInShort("23")]
            [RegionCode(3_00_101_0023)]
            Annaba,

            /// <summary>
            /// Guelma
            /// </summary>
            [AliasInShort("24")]
            [RegionCode(3_00_101_0024)]
            Guelma,

            /// <summary>
            /// Constantine
            /// </summary>
            [AliasInShort("25")]
            [RegionCode(3_00_101_0025)]
            Constantine,

            /// <summary>
            /// Médéa
            /// </summary>
            [AliasInShort("26")]
            [RegionCode(3_00_101_0026)]
            Médéa,

            /// <summary>
            /// Mostaganem
            /// </summary>
            [AliasInShort("27")]
            [RegionCode(3_00_101_0027)]
            Mostaganem,

            /// <summary>
            /// M’Sila
            /// </summary>
            [AliasInShort("28")]
            [RegionCode(3_00_101_0028)]
            MSila,

            /// <summary>
            /// Mascara
            /// </summary>
            [AliasInShort("29")]
            [RegionCode(3_00_101_0029)]
            Mascara,

            /// <summary>
            /// Ouargla
            /// </summary>
            [AliasInShort("30")]
            [RegionCode(3_00_101_0030)]
            Ouargla,

            /// <summary>
            /// Oran
            /// </summary>
            [AliasInShort("31")]
            [RegionCode(3_00_101_0031)]
            Oran,

            /// <summary>
            /// El Bayadh
            /// </summary>
            [AliasInShort("32")]
            [RegionCode(3_00_101_0032)]
            ElBayadh,

            /// <summary>
            /// Illizi
            /// </summary>
            [AliasInShort("33")]
            [RegionCode(3_00_101_0033)]
            Illizi,

            /// <summary>
            /// Bordj Bou Arréridj
            /// </summary>
            [AliasInShort("34")]
            [RegionCode(3_00_101_0034)]
            BordjBouArréridj,

            /// <summary>
            /// Boumerdès
            /// </summary>
            [AliasInShort("35")]
            [RegionCode(3_00_101_0035)]
            Boumerdès,

            /// <summary>
            /// El Tarf
            /// </summary>
            [AliasInShort("36")]
            [RegionCode(3_00_101_0036)]
            ElTarf,

            /// <summary>
            /// Tindouf
            /// </summary>
            [AliasInShort("37")]
            [RegionCode(3_00_101_0037)]
            Tindouf,

            /// <summary>
            /// Tissemsilt
            /// </summary>
            [AliasInShort("38")]
            [RegionCode(3_00_101_0038)]
            Tissemsilt,

            /// <summary>
            /// El Oued
            /// </summary>
            [AliasInShort("39")]
            [RegionCode(3_00_101_0039)]
            ElOued,

            /// <summary>
            /// Khenchela
            /// </summary>
            [AliasInShort("40")]
            [RegionCode(3_00_101_0040)]
            Khenchela,

            /// <summary>
            /// Souk Ahras
            /// </summary>
            [AliasInShort("41")]
            [RegionCode(3_00_101_0041)]
            SoukAhras,

            /// <summary>
            /// Tipasa
            /// </summary>
            [AliasInShort("42")]
            [RegionCode(3_00_101_0042)]
            Tipasa,

            /// <summary>
            /// Mila
            /// </summary>
            [AliasInShort("43")]
            [RegionCode(3_00_101_0043)]
            Mila,

            /// <summary>
            /// Aïn Defla
            /// </summary>
            [AliasInShort("44")]
            [RegionCode(3_00_101_0044)]
            AïnDefla,

            /// <summary>
            /// Naama
            /// </summary>
            [AliasInShort("45")]
            [RegionCode(3_00_101_0045)]
            Naama,

            /// <summary>
            /// Aïn Témouchent
            /// </summary>
            [AliasInShort("46")]
            [RegionCode(3_00_101_0046)]
            AïnTémouchent,

            /// <summary>
            /// Ghardaïa
            /// </summary>
            [AliasInShort("47")]
            [RegionCode(3_00_101_0047)]
            Ghardaïa,

            /// <summary>
            /// Relizane
            /// </summary>
            [AliasInShort("48")]
            [RegionCode(3_00_101_0048)]
            Relizane,

            /// <summary>
            /// Adrar
            /// </summary>
            [AliasInShort("01")]
            [RegionCode(3_00_101_0001)]
            Adrar,

            /// <summary>
            /// Chlef
            /// </summary>
            [AliasInShort("02")]
            [RegionCode(3_00_101_0002)]
            Chlef,

            /// <summary>
            /// Laghouat
            /// </summary>
            [AliasInShort("03")]
            [RegionCode(3_00_101_0003)]
            Laghouat,

            /// <summary>
            /// Oum El Bouaghi
            /// </summary>
            [AliasInShort("04")]
            [RegionCode(3_00_101_0004)]
            OumElBouaghi,

            /// <summary>
            /// Batna
            /// </summary>
            [AliasInShort("05")]
            [RegionCode(3_00_101_0005)]
            Batna,

            /// <summary>
            /// Béjaïa
            /// </summary>
            [AliasInShort("06")]
            [RegionCode(3_00_101_0006)]
            Béjaïa,

            /// <summary>
            /// Biskra
            /// </summary>
            [AliasInShort("07")]
            [RegionCode(3_00_101_0007)]
            Biskra,

            /// <summary>
            /// Béchar
            /// </summary>
            [AliasInShort("08")]
            [RegionCode(3_00_101_0008)]
            Béchar,

            /// <summary>
            /// Blida
            /// </summary>
            [AliasInShort("09")]
            [RegionCode(3_00_101_0009)]
            Blida,

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