using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// VietNam Regions
    /// </summary>
    public static class VietnamRegions
    {
        #region Gets regions

        /// <summary>
        /// Lai Châu
        /// </summary>
        public static EnumValues LaiChâu => EnumValues.LaiChâu;

        /// <summary>
        /// Lào Cai
        /// </summary>
        public static EnumValues LàoCai => EnumValues.LàoCai;

        /// <summary>
        /// Hà Giang
        /// </summary>
        public static EnumValues HàGiang => EnumValues.HàGiang;

        /// <summary>
        /// Cao Bằng
        /// </summary>
        public static EnumValues CaoBằng => EnumValues.CaoBằng;

        /// <summary>
        /// Sơn La
        /// </summary>
        public static EnumValues SơnLa => EnumValues.SơnLa;

        /// <summary>
        /// Yên Bái
        /// </summary>
        public static EnumValues YênBái => EnumValues.YênBái;

        /// <summary>
        /// Tuyên Quang
        /// </summary>
        public static EnumValues TuyênQuang => EnumValues.TuyênQuang;

        /// <summary>
        /// Lạng Sơn
        /// </summary>
        public static EnumValues LạngSơn => EnumValues.LạngSơn;

        /// <summary>
        /// Quảng Ninh
        /// </summary>
        public static EnumValues QuảngNinh => EnumValues.QuảngNinh;


        /// <summary>
        /// Hòa Bình
        /// </summary>
        public static EnumValues HòaBình => EnumValues.HòaBình;

        /// <summary>
        /// Ninh Bình
        /// </summary>
        public static EnumValues NinhBình => EnumValues.NinhBình;

        /// <summary>
        /// Thái Bình
        /// </summary>
        public static EnumValues TháiBình => EnumValues.TháiBình;

        /// <summary>
        /// Thanh Hóa
        /// </summary>
        public static EnumValues ThanhHóa => EnumValues.ThanhHóa;

        /// <summary>
        /// Nghệ An
        /// </summary>
        public static EnumValues NghệAn => EnumValues.NghệAn;

        /// <summary>
        /// Hà Tĩnh
        /// </summary>
        public static EnumValues HàTĩnh => EnumValues.HàTĩnh;

        /// <summary>
        /// Quảng Bình
        /// </summary>
        public static EnumValues QuảngBình => EnumValues.QuảngBình;

        /// <summary>
        /// Quảng Trị
        /// </summary>
        public static EnumValues QuảngTrị => EnumValues.QuảngTrị;

        /// <summary>
        /// Thừa Thiên–Huế
        /// </summary>
        public static EnumValues ThừaThiênHuế => EnumValues.ThừaThiênHuế;

        /// <summary>
        /// Quảng Nam
        /// </summary>
        public static EnumValues QuảngNam => EnumValues.QuảngNam;

        /// <summary>
        /// Kon Tum
        /// </summary>
        public static EnumValues KonTum => EnumValues.KonTum;

        /// <summary>
        /// Quảng Ngãi
        /// </summary>
        public static EnumValues QuảngNgãi => EnumValues.QuảngNgãi;

        /// <summary>
        /// Gia Lai
        /// </summary>
        public static EnumValues GiaLai => EnumValues.GiaLai;

        /// <summary>
        /// Bình Định
        /// </summary>
        public static EnumValues BìnhĐịnh => EnumValues.BìnhĐịnh;

        /// <summary>
        /// Phú Yên
        /// </summary>
        public static EnumValues PhúYên => EnumValues.PhúYên;

        /// <summary>
        /// Đắk Lắk
        /// </summary>
        public static EnumValues ĐắkLắk => EnumValues.ĐắkLắk;

        /// <summary>
        /// Khánh Hòa
        /// </summary>
        public static EnumValues KhánhHòa => EnumValues.KhánhHòa;

        /// <summary>
        /// Lâm Đồng
        /// </summary>
        public static EnumValues LâmĐồng => EnumValues.LâmĐồng;

        /// <summary>
        /// Ninh Thuận
        /// </summary>
        public static EnumValues NinhThuận => EnumValues.NinhThuận;

        /// <summary>
        /// Tây Ninh
        /// </summary>
        public static EnumValues TâyNinh => EnumValues.TâyNinh;

        /// <summary>
        /// Đồng Nai
        /// </summary>
        public static EnumValues ĐồngNai => EnumValues.ĐồngNai;

        /// <summary>
        /// Bình Thuận
        /// </summary>
        public static EnumValues BìnhThuận => EnumValues.BìnhThuận;

        /// <summary>
        /// Long An
        /// </summary>
        public static EnumValues LongAn => EnumValues.LongAn;

        /// <summary>
        /// Bà Rịa–Vũng Tàu
        /// </summary>
        public static EnumValues BàRịaVũngTàu => EnumValues.BàRịaVũngTàu;

        /// <summary>
        /// An Giang
        /// </summary>
        public static EnumValues AnGiang => EnumValues.AnGiang;

        /// <summary>
        /// Đồng Tháp
        /// </summary>
        public static EnumValues ĐồngTháp => EnumValues.ĐồngTháp;

        /// <summary>
        /// Tiền Giang
        /// </summary>
        public static EnumValues TiềnGiang => EnumValues.TiềnGiang;

        /// <summary>
        /// Kiên Giang
        /// </summary>
        public static EnumValues KiênGiang => EnumValues.KiênGiang;

        /// <summary>
        /// Vĩnh Long
        /// </summary>
        public static EnumValues VĩnhLong => EnumValues.VĩnhLong;

        /// <summary>
        /// Bến Tre
        /// </summary>
        public static EnumValues BếnTre => EnumValues.BếnTre;

        /// <summary>
        /// Trà Vinh
        /// </summary>
        public static EnumValues TràVinh => EnumValues.TràVinh;

        /// <summary>
        /// Sóc Trăng
        /// </summary>
        public static EnumValues SócTrăng => EnumValues.SócTrăng;

        /// <summary>
        /// Bắc Kạn
        /// </summary>
        public static EnumValues BắcKạn => EnumValues.BắcKạn;

        /// <summary>
        /// Bắc Giang
        /// </summary>
        public static EnumValues BắcGiang => EnumValues.BắcGiang;

        /// <summary>
        /// Bạc Liêu
        /// </summary>
        public static EnumValues BạcLiêu => EnumValues.BạcLiêu;

        /// <summary>
        /// Bắc Ninh
        /// </summary>
        public static EnumValues BắcNinh => EnumValues.BắcNinh;

        /// <summary>
        /// Bình Dương
        /// </summary>
        public static EnumValues BìnhDương => EnumValues.BìnhDương;

        /// <summary>
        /// Bình Phước
        /// </summary>
        public static EnumValues BìnhPhước => EnumValues.BìnhPhước;

        /// <summary>
        /// Cà Mau
        /// </summary>
        public static EnumValues CàMau => EnumValues.CàMau;

        /// <summary>
        /// Hải Dương
        /// </summary>
        public static EnumValues HảiDương => EnumValues.HảiDương;

        /// <summary>
        /// Hà Nam
        /// </summary>
        public static EnumValues HàNam => EnumValues.HàNam;

        /// <summary>
        /// Hưng Yên
        /// </summary>
        public static EnumValues HưngYên => EnumValues.HưngYên;

        /// <summary>
        /// Nam Định
        /// </summary>
        public static EnumValues NamĐịnh => EnumValues.NamĐịnh;

        /// <summary>
        /// Phú Thọ
        /// </summary>
        public static EnumValues PhúThọ => EnumValues.PhúThọ;

        /// <summary>
        /// Thái Nguyên
        /// </summary>
        public static EnumValues TháiNguyên => EnumValues.TháiNguyên;

        /// <summary>
        /// Vĩnh Phúc
        /// </summary>
        public static EnumValues VĩnhPhúc => EnumValues.VĩnhPhúc;

        /// <summary>
        /// Điện Biên
        /// </summary>
        public static EnumValues ĐiệnBiên => EnumValues.ĐiệnBiên;

        /// <summary>
        /// Đắk Nông
        /// </summary>
        public static EnumValues ĐắkNông => EnumValues.ĐắkNông;

        /// <summary>
        /// Hậu Giang
        /// </summary>
        public static EnumValues HậuGiang => EnumValues.HậuGiang;

        /// <summary>
        /// Can Tho
        /// </summary>
        public static EnumValues CanTho => EnumValues.CanTho;

        /// <summary>
        /// Da Nang
        /// </summary>
        public static EnumValues DaNang => EnumValues.DaNang;

        /// <summary>
        /// Hanoi
        /// </summary>
        public static EnumValues Hanoi => EnumValues.Hanoi;

        /// <summary>
        /// Haiphong
        /// </summary>
        public static EnumValues Haiphong => EnumValues.Haiphong;

        /// <summary>
        /// Ho Chi Minh City
        /// </summary>
        public static EnumValues HoChiMinhCity => EnumValues.HoChiMinhCity;

        #endregion

        /// <summary>
        /// Enum values for VietNam regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Lai Châu
            /// </summary>
            [AliasInShort("01")] [RegionCode(1_00_018_0001)]
            LaiChâu,

            /// <summary>
            /// Lào Cai
            /// </summary>
            [AliasInShort("02")] [RegionCode(1_00_018_0002)]
            LàoCai,

            /// <summary>
            /// Hà Giang
            /// </summary>
            [AliasInShort("03")] [RegionCode(1_00_018_0003)]
            HàGiang,

            /// <summary>
            /// Cao Bằng
            /// </summary>
            [AliasInShort("04")] [RegionCode(1_00_018_0004)]
            CaoBằng,

            /// <summary>
            /// Sơn La
            /// </summary>
            [AliasInShort("05")] [RegionCode(1_00_018_0005)]
            SơnLa,

            /// <summary>
            /// Yên Bái
            /// </summary>
            [AliasInShort("06")] [RegionCode(1_00_018_0006)]
            YênBái,

            /// <summary>
            /// Tuyên Quang
            /// </summary>
            [AliasInShort("07")] [RegionCode(1_00_018_0007)]
            TuyênQuang,

            /// <summary>
            /// Lạng Sơn
            /// </summary>
            [AliasInShort("09")] [RegionCode(1_00_018_0009)]
            LạngSơn,

            /// <summary>
            /// Quảng Ninh
            /// </summary>
            [AliasInShort("13")] [RegionCode(1_00_018_0013)]
            QuảngNinh,

            /// <summary>
            /// Hòa Bình
            /// </summary>
            [AliasInShort("14")] [RegionCode(1_00_018_0014)]
            HòaBình,

            /// <summary>
            /// Ninh Bình
            /// </summary>
            [AliasInShort("18")] [RegionCode(1_00_018_0018)]
            NinhBình,

            /// <summary>
            /// Thái Bình
            /// </summary>
            [AliasInShort("20")] [RegionCode(1_00_018_0020)]
            TháiBình,

            /// <summary>
            /// Thanh Hóa
            /// </summary>
            [AliasInShort("21")] [RegionCode(1_00_018_0021)]
            ThanhHóa,

            /// <summary>
            /// Nghệ An
            /// </summary>
            [AliasInShort("22")] [RegionCode(1_00_018_0022)]
            NghệAn,

            /// <summary>
            /// Hà Tĩnh
            /// </summary>
            [AliasInShort("23")] [RegionCode(1_00_018_0023)]
            HàTĩnh,

            /// <summary>
            /// Quảng Bình
            /// </summary>
            [AliasInShort("24")] [RegionCode(1_00_018_0024)]
            QuảngBình,

            /// <summary>
            /// Quảng Trị
            /// </summary>
            [AliasInShort("25")] [RegionCode(1_00_018_0025)]
            QuảngTrị,

            /// <summary>
            /// Thừa Thiên–Huế
            /// </summary>
            [AliasInShort("26")] [RegionCode(1_00_018_0026)]
            ThừaThiênHuế,

            /// <summary>
            /// Quảng Nam
            /// </summary>
            [AliasInShort("27")] [RegionCode(1_00_018_0027)]
            QuảngNam,

            /// <summary>
            /// Kon Tum
            /// </summary>
            [AliasInShort("28")] [RegionCode(1_00_018_0028)]
            KonTum,

            /// <summary>
            /// Quảng Ngãi
            /// </summary>
            [AliasInShort("29")] [RegionCode(1_00_018_0029)]
            QuảngNgãi,

            /// <summary>
            /// Gia Lai
            /// </summary>
            [AliasInShort("30")] [RegionCode(1_00_018_0030)]
            GiaLai,

            /// <summary>
            /// Bình Định
            /// </summary>
            [AliasInShort("31")] [RegionCode(1_00_018_0031)]
            BìnhĐịnh,

            /// <summary>
            /// Phú Yên
            /// </summary>
            [AliasInShort("32")] [RegionCode(1_00_018_0032)]
            PhúYên,

            /// <summary>
            /// Đắk Lắk
            /// </summary>
            [AliasInShort("33")] [RegionCode(1_00_018_0033)]
            ĐắkLắk,

            /// <summary>
            /// Khánh Hòa
            /// </summary>
            [AliasInShort("34")] [RegionCode(1_00_018_0034)]
            KhánhHòa,

            /// <summary>
            /// Lâm Đồng
            /// </summary>
            [AliasInShort("35")] [RegionCode(1_00_018_0035)]
            LâmĐồng,

            /// <summary>
            /// Ninh Thuận
            /// </summary>
            [AliasInShort("36")] [RegionCode(1_00_018_0036)]
            NinhThuận,

            /// <summary>
            /// Tây Ninh
            /// </summary>
            [AliasInShort("37")] [RegionCode(1_00_018_0037)]
            TâyNinh,

            /// <summary>
            /// Đồng Nai
            /// </summary>
            [AliasInShort("39")] [RegionCode(1_00_018_0039)]
            ĐồngNai,

            /// <summary>
            /// Bình Thuận
            /// </summary>
            [AliasInShort("40")] [RegionCode(1_00_018_0040)]
            BìnhThuận,

            /// <summary>
            /// Long An
            /// </summary>
            [AliasInShort("41")] [RegionCode(1_00_018_0041)]
            LongAn,

            /// <summary>
            /// Bà Rịa–Vũng Tàu
            /// </summary>
            [AliasInShort("43")] [RegionCode(1_00_018_0043)]
            BàRịaVũngTàu,

            /// <summary>
            /// An Giang
            /// </summary>
            [AliasInShort("44")] [RegionCode(1_00_018_0044)]
            AnGiang,

            /// <summary>
            /// Đồng Tháp
            /// </summary>
            [AliasInShort("45")] [RegionCode(1_00_018_0045)]
            ĐồngTháp,

            /// <summary>
            /// Tiền Giang
            /// </summary>
            [AliasInShort("46")] [RegionCode(1_00_018_0046)]
            TiềnGiang,

            /// <summary>
            /// Kiên Giang
            /// </summary>
            [AliasInShort("47")] [RegionCode(1_00_018_0047)]
            KiênGiang,

            /// <summary>
            /// Vĩnh Long
            /// </summary>
            [AliasInShort("49")] [RegionCode(1_00_018_0049)]
            VĩnhLong,

            /// <summary>
            /// Bến Tre
            /// </summary>
            [AliasInShort("50")] [RegionCode(1_00_018_0050)]
            BếnTre,

            /// <summary>
            /// Trà Vinh
            /// </summary>
            [AliasInShort("51")] [RegionCode(1_00_018_0051)]
            TràVinh,

            /// <summary>
            /// Sóc Trăng
            /// </summary>
            [AliasInShort("52")] [RegionCode(1_00_018_0052)]
            SócTrăng,

            /// <summary>
            /// Bắc Kạn
            /// </summary>
            [AliasInShort("53")] [RegionCode(1_00_018_0053)]
            BắcKạn,

            /// <summary>
            /// Bắc Giang
            /// </summary>
            [AliasInShort("54")] [RegionCode(1_00_018_0054)]
            BắcGiang,

            /// <summary>
            /// Bạc Liêu
            /// </summary>
            [AliasInShort("55")] [RegionCode(1_00_018_0055)]
            BạcLiêu,

            /// <summary>
            /// Bắc Ninh
            /// </summary>
            [AliasInShort("56")] [RegionCode(1_00_018_0056)]
            BắcNinh,

            /// <summary>
            /// Bình Dương
            /// </summary>
            [AliasInShort("57")] [RegionCode(1_00_018_0057)]
            BìnhDương,

            /// <summary>
            /// Bình Phước
            /// </summary>
            [AliasInShort("58")] [RegionCode(1_00_018_0058)]
            BìnhPhước,

            /// <summary>
            /// Cà Mau
            /// </summary>
            [AliasInShort("59")] [RegionCode(1_00_018_0059)]
            CàMau,

            /// <summary>
            /// Hải Dương
            /// </summary>
            [AliasInShort("61")] [RegionCode(1_00_018_0061)]
            HảiDương,

            /// <summary>
            /// Hà Nam
            /// </summary>
            [AliasInShort("63")] [RegionCode(1_00_018_0063)]
            HàNam,

            /// <summary>
            /// Hưng Yên
            /// </summary>
            [AliasInShort("66")] [RegionCode(1_00_018_0066)]
            HưngYên,

            /// <summary>
            /// Nam Định
            /// </summary>
            [AliasInShort("67")] [RegionCode(1_00_018_0067)]
            NamĐịnh,

            /// <summary>
            /// Phú Thọ
            /// </summary>
            [AliasInShort("68")] [RegionCode(1_00_018_0068)]
            PhúThọ,

            /// <summary>
            /// Thái Nguyên
            /// </summary>
            [AliasInShort("69")] [RegionCode(1_00_018_0069)]
            TháiNguyên,

            /// <summary>
            /// Vĩnh Phúc
            /// </summary>
            [AliasInShort("70")] [RegionCode(1_00_018_0070)]
            VĩnhPhúc,

            /// <summary>
            /// Điện Biên
            /// </summary>
            [AliasInShort("71")] [RegionCode(1_00_018_0071)]
            ĐiệnBiên,

            /// <summary>
            /// Đắk Nông
            /// </summary>
            [AliasInShort("72")] [RegionCode(1_00_018_0072)]
            ĐắkNông,

            /// <summary>
            /// Hậu Giang
            /// </summary>
            [AliasInShort("73")] [RegionCode(1_00_018_0073)]
            HậuGiang,

            /// <summary>
            /// Can Tho
            /// </summary>
            [AliasInShort("CT")] [RegionCode(1_00_018_1001)]
            CanTho,

            /// <summary>
            /// Da Nang
            /// </summary>
            [AliasInShort("DN")] [RegionCode(1_00_018_1002)]
            DaNang,

            /// <summary>
            /// Hanoi
            /// </summary>
            [AliasInShort("HN")] [RegionCode(1_00_018_1003)]
            Hanoi,

            /// <summary>
            /// Haiphong
            /// </summary>
            [AliasInShort("HP")] [RegionCode(1_00_018_1004)]
            Haiphong,

            /// <summary>
            /// Ho Chi Minh City
            /// </summary>
            [AliasInShort("SG")] [RegionCode(1_00_018_1005)]
            HoChiMinhCity,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="VietnamRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="VietnamRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"VN-{values.ToRegionCode()}";
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
            return Country.Vietnam;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.VN;
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