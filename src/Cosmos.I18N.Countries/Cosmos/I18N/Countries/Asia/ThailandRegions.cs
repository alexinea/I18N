using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Thailand Regions
    /// </summary>
    public static class ThailandRegions
    {
        #region Gets regions

        /// <summary>
        /// Bangkok
        /// </summary>
        public static EnumValues Bangkok => EnumValues.Bangkok;

        /// <summary>
        /// Samut Prakan
        /// </summary>
        public static EnumValues SamutPrakan => EnumValues.SamutPrakan;

        /// <summary>
        /// Nonthaburi
        /// </summary>
        public static EnumValues Nonthaburi => EnumValues.Nonthaburi;

        /// <summary>
        /// Pathum Thani
        /// </summary>
        public static EnumValues PathumThani => EnumValues.PathumThani;

        /// <summary>
        /// Phra Nakhon Si Ayutthaya
        /// </summary>
        public static EnumValues PhraNakhonSiAyutthaya => EnumValues.PhraNakhonSiAyutthaya;

        /// <summary>
        /// Ang Thong
        /// </summary>
        public static EnumValues AngThong => EnumValues.AngThong;

        /// <summary>
        /// Lopburi
        /// </summary>
        public static EnumValues Lopburi => EnumValues.Lopburi;

        /// <summary>
        /// Sing Buri   
        /// </summary>
        public static EnumValues SingBuri => EnumValues.SingBuri;

        /// <summary>
        /// Chai Nat
        /// </summary>
        public static EnumValues ChaiNat => EnumValues.ChaiNat;

        /// <summary>
        /// Saraburi
        /// </summary>
        public static EnumValues Saraburi => EnumValues.Saraburi;

        /// <summary>
        /// Chon Buri
        /// </summary>
        public static EnumValues ChonBuri => EnumValues.ChonBuri;

        /// <summary>
        /// Rayong
        /// </summary>
        public static EnumValues Rayong => EnumValues.Rayong;

        /// <summary>
        /// Chanthaburi
        /// </summary>
        public static EnumValues Chanthaburi => EnumValues.Chanthaburi;

        /// <summary>
        /// Trat
        /// </summary>
        public static EnumValues Trat => EnumValues.Trat;

        /// <summary>
        /// Chachoengsao
        /// </summary>
        public static EnumValues Chachoengsao => EnumValues.Chachoengsao;

        /// <summary>
        /// Prachin Buri
        /// </summary>
        public static EnumValues PrachinBuri => EnumValues.PrachinBuri;

        /// <summary>
        /// Nakhon Nayok
        /// </summary>
        public static EnumValues NakhonNayok => EnumValues.NakhonNayok;

        /// <summary>
        /// Sa Kaeo
        /// </summary>
        public static EnumValues SaKaeo => EnumValues.SaKaeo;

        /// <summary>
        /// Nakhon Ratchasima
        /// </summary>
        public static EnumValues NakhonRatchasima => EnumValues.NakhonRatchasima;

        /// <summary>
        /// Buri Ram
        /// </summary>
        public static EnumValues BuriRam => EnumValues.BuriRam;

        /// <summary>
        /// Surin
        /// </summary>
        public static EnumValues Surin => EnumValues.Surin;

        /// <summary>
        /// Si Sa Ket
        /// </summary>
        public static EnumValues SiSaKet => EnumValues.SiSaKet;

        /// <summary>
        /// Ubon Ratchathani
        /// </summary>
        public static EnumValues UbonRatchathani => EnumValues.UbonRatchathani;

        /// <summary>
        /// Yasothon
        /// </summary>
        public static EnumValues Yasothon => EnumValues.Yasothon;

        /// <summary>
        /// Chaiyaphum
        /// </summary>
        public static EnumValues Chaiyaphum => EnumValues.Chaiyaphum;

        /// <summary>
        /// Amnat Charoen
        /// </summary>
        public static EnumValues AmnatCharoen => EnumValues.AmnatCharoen;

        /// <summary>
        /// Bueng Kan
        /// </summary>
        public static EnumValues BuengKan => EnumValues.BuengKan;

        /// <summary>
        /// Nong Bua Lam Phu
        /// </summary>
        public static EnumValues NongBuaLamPhu => EnumValues.NongBuaLamPhu;

        /// <summary>
        /// Khon Kaen
        /// </summary>
        public static EnumValues KhonKaen => EnumValues.KhonKaen;

        /// <summary>
        /// Udon Thani
        /// </summary>
        public static EnumValues UdonThani => EnumValues.UdonThani;

        /// <summary>
        /// Loei
        /// </summary>
        public static EnumValues Loei => EnumValues.Loei;

        /// <summary>
        /// Nong Khai
        /// </summary>
        public static EnumValues NongKhai => EnumValues.NongKhai;

        /// <summary>
        /// Maha Sarakham
        /// </summary>
        public static EnumValues MahaSarakham => EnumValues.MahaSarakham;

        /// <summary>
        /// Roi Et
        /// </summary>
        public static EnumValues RoiEt => EnumValues.RoiEt;

        /// <summary>
        /// Kalasin
        /// </summary>
        public static EnumValues Kalasin => EnumValues.Kalasin;

        /// <summary>
        /// Sakon Nakhon
        /// </summary>
        public static EnumValues SakonNakhon => EnumValues.SakonNakhon;

        /// <summary>
        /// Nakhon Phanom
        /// </summary>
        public static EnumValues NakhonPhanom => EnumValues.NakhonPhanom;

        /// <summary>
        /// Mukdahan
        /// </summary>
        public static EnumValues Mukdahan => EnumValues.Mukdahan;

        /// <summary>
        /// Chiang Mai
        /// </summary>
        public static EnumValues ChiangMai => EnumValues.ChiangMai;

        /// <summary>
        /// Lamphun
        /// </summary>
        public static EnumValues Lamphun => EnumValues.Lamphun;

        /// <summary>
        /// Lampang
        /// </summary>
        public static EnumValues Lampang => EnumValues.Lampang;

        /// <summary>
        /// Uttaradit
        /// </summary>
        public static EnumValues Uttaradit => EnumValues.Uttaradit;

        /// <summary>
        /// Phrae
        /// </summary>
        public static EnumValues Phrae => EnumValues.Phrae;

        /// <summary>
        /// Nan
        /// </summary>
        public static EnumValues Nan => EnumValues.Nan;

        /// <summary>
        /// Phayao
        /// </summary>
        public static EnumValues Phayao => EnumValues.Phayao;

        /// <summary>
        /// Chiang Rai
        /// </summary>
        public static EnumValues ChiangRai => EnumValues.ChiangRai;

        /// <summary>
        /// Mae Hong Son
        /// </summary>
        public static EnumValues MaeHongSon => EnumValues.MaeHongSon;

        /// <summary>
        /// Nakhon Sawan
        /// </summary>
        public static EnumValues NakhonSawan => EnumValues.NakhonSawan;

        /// <summary>
        /// Uthai Thani
        /// </summary>
        public static EnumValues UthaiThani => EnumValues.UthaiThani;

        /// <summary>
        /// Kamphaeng Phet
        /// </summary>
        public static EnumValues KamphaengPhet => EnumValues.KamphaengPhet;

        /// <summary>
        /// Tak
        /// </summary>
        public static EnumValues Tak => EnumValues.Tak;

        /// <summary>
        /// Sukhothai
        /// </summary>
        public static EnumValues Sukhothai => EnumValues.Sukhothai;

        /// <summary>
        /// Phitsanulok
        /// </summary>
        public static EnumValues Phitsanulok => EnumValues.Phitsanulok;

        /// <summary>
        /// Phichit
        /// </summary>
        public static EnumValues Phichit => EnumValues.Phichit;

        /// <summary>
        /// Phetchabun
        /// </summary>
        public static EnumValues Phetchabun => EnumValues.Phetchabun;

        /// <summary>
        /// Ratchaburi
        /// </summary>
        public static EnumValues Ratchaburi => EnumValues.Ratchaburi;

        /// <summary>
        /// Kanchanaburi
        /// </summary>
        public static EnumValues Kanchanaburi => EnumValues.Kanchanaburi;

        /// <summary>
        /// Suphanburi
        /// </summary>
        public static EnumValues Suphanburi => EnumValues.Suphanburi;

        /// <summary>
        /// Nakhon Pathom
        /// </summary>
        public static EnumValues NakhonPathom => EnumValues.NakhonPathom;

        /// <summary>
        /// Samut Sakhon
        /// </summary>
        public static EnumValues SamutSakhon => EnumValues.SamutSakhon;

        /// <summary>
        /// Samut Songkhram
        /// </summary>
        public static EnumValues SamutSongkhram => EnumValues.SamutSongkhram;

        /// <summary>
        /// Phetchaburi
        /// </summary>
        public static EnumValues Phetchaburi => EnumValues.Phetchaburi;

        /// <summary>
        /// Prachuap Khiri Khan
        /// </summary>
        public static EnumValues PrachuapKhiriKhan => EnumValues.PrachuapKhiriKhan;

        /// <summary>
        /// Nakhon Si Thammarat
        /// </summary>
        public static EnumValues NakhonSiThammarat => EnumValues.NakhonSiThammarat;

        /// <summary>
        /// Krabi
        /// </summary>
        public static EnumValues Krabi => EnumValues.Krabi;

        /// <summary>
        /// Phang Nga
        /// </summary>
        public static EnumValues PhangNga => EnumValues.PhangNga;

        /// <summary>
        /// Phuket
        /// </summary>
        public static EnumValues Phuket => EnumValues.Phuket;

        /// <summary>
        /// Surat Thani
        /// </summary>
        public static EnumValues SuratThani => EnumValues.SuratThani;

        /// <summary>
        /// Ranong
        /// </summary>
        public static EnumValues Ranong => EnumValues.Ranong;

        /// <summary>
        /// Chumphon
        /// </summary>
        public static EnumValues Chumphon => EnumValues.Chumphon;

        /// <summary>
        /// Songkhla
        /// </summary>
        public static EnumValues Songkhla => EnumValues.Songkhla;

        /// <summary>
        /// Satun
        /// </summary>
        public static EnumValues Satun => EnumValues.Satun;

        /// <summary>
        /// Trang
        /// </summary>
        public static EnumValues Trang => EnumValues.Trang;

        /// <summary>
        /// Phatthalung
        /// </summary>
        public static EnumValues Phatthalung => EnumValues.Phatthalung;

        /// <summary>
        /// Pattani
        /// </summary>
        public static EnumValues Pattani => EnumValues.Pattani;

        /// <summary>
        /// Yala
        /// </summary>
        public static EnumValues Yala => EnumValues.Yala;

        /// <summary>
        /// Narathiwat
        /// </summary>
        public static EnumValues Narathiwat => EnumValues.Narathiwat;

        /// <summary>
        /// Pattaya
        /// </summary>
        public static EnumValues Pattaya => EnumValues.Pattaya;

        #endregion

        /// <summary>
        /// Enum values for Thailand regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Bangkok
            /// </summary>
            [AliasInShort("10")] [RegionCode(1_00_138_0010)]
            Bangkok,

            /// <summary>
            /// Samut Prakan
            /// </summary>
            [AliasInShort("11")] [RegionCode(1_00_138_0011)]
            SamutPrakan,

            /// <summary>
            /// Nonthaburi
            /// </summary>
            [AliasInShort("12")] [RegionCode(1_00_138_0012)]
            Nonthaburi,

            /// <summary>
            /// Pathum Thani
            /// </summary>
            [AliasInShort("13")] [RegionCode(1_00_138_0013)]
            PathumThani,

            /// <summary>
            /// Phra Nakhon Si Ayutthaya
            /// </summary>
            [AliasInShort("14")] [RegionCode(1_00_138_0014)]
            PhraNakhonSiAyutthaya,

            /// <summary>
            /// Ang Thong
            /// </summary>
            [AliasInShort("15")] [RegionCode(1_00_138_0015)]
            AngThong,

            /// <summary>
            /// Lopburi
            /// </summary>
            [AliasInShort("16")] [RegionCode(1_00_138_0016)]
            Lopburi,

            /// <summary>
            /// Sing Buri
            /// </summary>
            [AliasInShort("17")] [RegionCode(1_00_138_0017)]
            SingBuri,

            /// <summary>
            /// Chai Nat
            /// </summary>
            [AliasInShort("18")] [RegionCode(1_00_138_0018)]
            ChaiNat,

            /// <summary>
            /// Saraburi
            /// </summary>
            [AliasInShort("19")] [RegionCode(1_00_138_0019)]
            Saraburi,

            /// <summary>
            /// Chon Buri
            /// </summary>
            [AliasInShort("20")] [RegionCode(1_00_138_0020)]
            ChonBuri,

            /// <summary>
            /// Rayong
            /// </summary>
            [AliasInShort("21")] [RegionCode(1_00_138_0021)]
            Rayong,

            /// <summary>
            /// Chanthaburi
            /// </summary>
            [AliasInShort("22")] [RegionCode(1_00_138_0022)]
            Chanthaburi,

            /// <summary>
            /// Trat
            /// </summary>
            [AliasInShort("23")] [RegionCode(1_00_138_0023)]
            Trat,

            /// <summary>
            /// Chachoengsao
            /// </summary>
            [AliasInShort("24")] [RegionCode(1_00_138_0024)]
            Chachoengsao,

            /// <summary>
            /// Prachin Buri
            /// </summary>
            [AliasInShort("25")] [RegionCode(1_00_138_0025)]
            PrachinBuri,

            /// <summary>
            /// Nakhon Nayok
            /// </summary>
            [AliasInShort("26")] [RegionCode(1_00_138_0026)]
            NakhonNayok,

            /// <summary>
            /// Sa Kaeo
            /// </summary>
            [AliasInShort("27")] [RegionCode(1_00_138_0027)]
            SaKaeo,

            /// <summary>
            /// Nakhon Ratchasima
            /// </summary>
            [AliasInShort("30")] [RegionCode(1_00_138_0030)]
            NakhonRatchasima,

            /// <summary>
            /// Buri Ram
            /// </summary>
            [AliasInShort("31")] [RegionCode(1_00_138_0031)]
            BuriRam,

            /// <summary>
            /// Surin
            /// </summary>
            [AliasInShort("32")] [RegionCode(1_00_138_0032)]
            Surin,

            /// <summary>
            /// Si Sa Ket
            /// </summary>
            [AliasInShort("33")] [RegionCode(1_00_138_0033)]
            SiSaKet,

            /// <summary>
            /// Ubon Ratchathani
            /// </summary>
            [AliasInShort("34")] [RegionCode(1_00_138_0034)]
            UbonRatchathani,

            /// <summary>
            /// Yasothon
            /// </summary>
            [AliasInShort("35")] [RegionCode(1_00_138_0035)]
            Yasothon,

            /// <summary>
            /// Chaiyaphum
            /// </summary>
            [AliasInShort("36")] [RegionCode(1_00_138_0036)]
            Chaiyaphum,

            /// <summary>
            /// Amnat Charoen
            /// </summary>
            [AliasInShort("37")] [RegionCode(1_00_138_0037)]
            AmnatCharoen,

            /// <summary>
            /// Bueng Kan
            /// </summary>
            [AliasInShort("38")] [RegionCode(1_00_138_0038)]
            BuengKan,

            /// <summary>
            /// Nong Bua Lam Phu
            /// </summary>
            [AliasInShort("39")] [RegionCode(1_00_138_0039)]
            NongBuaLamPhu,

            /// <summary>
            /// Khon Kaen
            /// </summary>
            [AliasInShort("40")] [RegionCode(1_00_138_0040)]
            KhonKaen,

            /// <summary>
            /// Udon Thani
            /// </summary>
            [AliasInShort("41")] [RegionCode(1_00_138_0041)]
            UdonThani,

            /// <summary>
            /// Loei
            /// </summary>
            [AliasInShort("42")] [RegionCode(1_00_138_0042)]
            Loei,

            /// <summary>
            /// Nong Khai
            /// </summary>
            [AliasInShort("43")] [RegionCode(1_00_138_0043)]
            NongKhai,

            /// <summary>
            /// Maha Sarakham
            /// </summary>
            [AliasInShort("44")] [RegionCode(1_00_138_0044)]
            MahaSarakham,

            /// <summary>
            /// Roi Et
            /// </summary>
            [AliasInShort("45")] [RegionCode(1_00_138_0045)]
            RoiEt,

            /// <summary>
            /// Kalasin
            /// </summary>
            [AliasInShort("46")] [RegionCode(1_00_138_0046)]
            Kalasin,

            /// <summary>
            /// Sakon Nakhon
            /// </summary>
            [AliasInShort("47")] [RegionCode(1_00_138_0047)]
            SakonNakhon,

            /// <summary>
            /// Nakhon Phanom
            /// </summary>
            [AliasInShort("48")] [RegionCode(1_00_138_0048)]
            NakhonPhanom,

            /// <summary>
            /// Mukdahan
            /// </summary>
            [AliasInShort("49")] [RegionCode(1_00_138_0049)]
            Mukdahan,

            /// <summary>
            /// Chiang Mai
            /// </summary>
            [AliasInShort("50")] [RegionCode(1_00_138_0050)]
            ChiangMai,

            /// <summary>
            /// Lamphun
            /// </summary>
            [AliasInShort("51")] [RegionCode(1_00_138_0051)]
            Lamphun,

            /// <summary>
            /// Lampang
            /// </summary>
            [AliasInShort("52")] [RegionCode(1_00_138_0052)]
            Lampang,

            /// <summary>
            /// Uttaradit
            /// </summary>
            [AliasInShort("53")] [RegionCode(1_00_138_0053)]
            Uttaradit,

            /// <summary>
            /// Phrae
            /// </summary>
            [AliasInShort("54")] [RegionCode(1_00_138_0054)]
            Phrae,

            /// <summary>
            /// Nan
            /// </summary>
            [AliasInShort("55")] [RegionCode(1_00_138_0055)]
            Nan,

            /// <summary>
            /// Phayao
            /// </summary>
            [AliasInShort("56")] [RegionCode(1_00_138_0056)]
            Phayao,

            /// <summary>
            /// Chiang Rai
            /// </summary>
            [AliasInShort("57")] [RegionCode(1_00_138_0057)]
            ChiangRai,

            /// <summary>
            /// Mae Hong Son
            /// </summary>
            [AliasInShort("58")] [RegionCode(1_00_138_0058)]
            MaeHongSon,

            /// <summary>
            /// Nakhon Sawan
            /// </summary>
            [AliasInShort("60")] [RegionCode(1_00_138_0060)]
            NakhonSawan,

            /// <summary>
            /// Uthai Thani
            /// </summary>
            [AliasInShort("61")] [RegionCode(1_00_138_0061)]
            UthaiThani,

            /// <summary>
            /// Kamphaeng Phet
            /// </summary>
            [AliasInShort("62")] [RegionCode(1_00_138_0062)]
            KamphaengPhet,

            /// <summary>
            /// Tak
            /// </summary>
            [AliasInShort("63")] [RegionCode(1_00_138_0063)]
            Tak,

            /// <summary>
            /// Sukhothai
            /// </summary>
            [AliasInShort("64")] [RegionCode(1_00_138_0064)]
            Sukhothai,

            /// <summary>
            /// Phitsanulok
            /// </summary>
            [AliasInShort("65")] [RegionCode(1_00_138_0065)]
            Phitsanulok,

            /// <summary>
            /// Phichit
            /// </summary>
            [AliasInShort("66")] [RegionCode(1_00_138_0066)]
            Phichit,

            /// <summary>
            /// Phetchabun
            /// </summary>
            [AliasInShort("67")] [RegionCode(1_00_138_0067)]
            Phetchabun,

            /// <summary>
            /// Ratchaburi
            /// </summary>
            [AliasInShort("70")] [RegionCode(1_00_138_0070)]
            Ratchaburi,

            /// <summary>
            /// Kanchanaburi
            /// </summary>
            [AliasInShort("71")] [RegionCode(1_00_138_0071)]
            Kanchanaburi,

            /// <summary>
            /// Suphanburi
            /// </summary>
            [AliasInShort("72")] [RegionCode(1_00_138_0072)]
            Suphanburi,

            /// <summary>
            /// Nakhon Pathom
            /// </summary>
            [AliasInShort("73")] [RegionCode(1_00_138_0073)]
            NakhonPathom,

            /// <summary>
            /// Samut Sakhon
            /// </summary>
            [AliasInShort("74")] [RegionCode(1_00_138_0074)]
            SamutSakhon,

            /// <summary>
            /// Samut Songkhram
            /// </summary>
            [AliasInShort("75")] [RegionCode(1_00_138_0075)]
            SamutSongkhram,

            /// <summary>
            /// Phetchaburi
            /// </summary>
            [AliasInShort("76")] [RegionCode(1_00_138_0076)]
            Phetchaburi,

            /// <summary>
            /// Prachuap Khiri Khan
            /// </summary>
            [AliasInShort("77")] [RegionCode(1_00_138_0077)]
            PrachuapKhiriKhan,

            /// <summary>
            /// Nakhon Si Thammarat
            /// </summary>
            [AliasInShort("80")] [RegionCode(1_00_138_0080)]
            NakhonSiThammarat,

            /// <summary>
            /// Krabi
            /// </summary>
            [AliasInShort("81")] [RegionCode(1_00_138_0081)]
            Krabi,

            /// <summary>
            /// Phang Nga
            /// </summary>
            [AliasInShort("82")] [RegionCode(1_00_138_0082)]
            PhangNga,

            /// <summary>
            /// Phuket
            /// </summary>
            [AliasInShort("83")] [RegionCode(1_00_138_0083)]
            Phuket,

            /// <summary>
            /// Surat Thani
            /// </summary>
            [AliasInShort("84")] [RegionCode(1_00_138_0084)]
            SuratThani,

            /// <summary>
            /// Ranong
            /// </summary>
            [AliasInShort("85")] [RegionCode(1_00_138_0085)]
            Ranong,

            /// <summary>
            /// Chumphon
            /// </summary>
            [AliasInShort("86")] [RegionCode(1_00_138_0086)]
            Chumphon,

            /// <summary>
            /// Songkhla
            /// </summary>
            [AliasInShort("90")] [RegionCode(1_00_138_0090)]
            Songkhla,

            /// <summary>
            /// Satun
            /// </summary>
            [AliasInShort("91")] [RegionCode(1_00_138_0091)]
            Satun,

            /// <summary>
            /// Trang
            /// </summary>
            [AliasInShort("92")] [RegionCode(1_00_138_0092)]
            Trang,

            /// <summary>
            /// Phatthalung
            /// </summary>
            [AliasInShort("93")] [RegionCode(1_00_138_0093)]
            Phatthalung,

            /// <summary>
            /// Pattani
            /// </summary>
            [AliasInShort("94")] [RegionCode(1_00_138_0094)]
            Pattani,

            /// <summary>
            /// Yala
            /// </summary>
            [AliasInShort("95")] [RegionCode(1_00_138_0095)]
            Yala,

            /// <summary>
            /// Narathiwat
            /// </summary>
            [AliasInShort("96")] [RegionCode(1_00_138_0096)]
            Narathiwat,

            /// <summary>
            /// Pattaya
            /// </summary>
            [AliasInShort("S")] [RegionCode(1_00_138_0100)]
            Pattaya,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="ThailandRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="ThailandRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"TH-{values.ToRegionCode()}";
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
            return Country.Thailand;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.TH;
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