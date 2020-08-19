using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Slovenia Regions
    /// </summary>
    public static partial class Slovenia
    {
        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; } = RegionEnumHelper.Cache<EnumValues>();

        private static Dictionary<long, EnumValues> InternalCrCodeMappingCache { get; } = RegionEnumHelper.Mapping(InternalEnumMembersCache);

        #region Region getter

        public static class Regions
        {
            /// <summary>
            /// Ajdovščina
            /// </summary>
            public static EnumValues Ajdovščina => EnumValues.Ajdovščina;

            /// <summary>
            /// Beltinci
            /// </summary>
            public static EnumValues Beltinci => EnumValues.Beltinci;

            /// <summary>
            /// Bled
            /// </summary>
            public static EnumValues Bled => EnumValues.Bled;

            /// <summary>
            /// Bohinj
            /// </summary>
            public static EnumValues Bohinj => EnumValues.Bohinj;

            /// <summary>
            /// Borovnica
            /// </summary>
            public static EnumValues Borovnica => EnumValues.Borovnica;

            /// <summary>
            /// Bovec
            /// </summary>
            public static EnumValues Bovec => EnumValues.Bovec;

            /// <summary>
            /// Brda
            /// </summary>
            public static EnumValues Brda => EnumValues.Brda;

            /// <summary>
            /// Brezovica
            /// </summary>
            public static EnumValues Brezovica => EnumValues.Brezovica;

            /// <summary>
            /// Brežice
            /// </summary>
            public static EnumValues Brežice => EnumValues.Brežice;

            /// <summary>
            /// Tišina
            /// </summary>
            public static EnumValues Tišina => EnumValues.Tišina;

            /// <summary>
            /// Celje
            /// </summary>
            public static EnumValues Celje => EnumValues.Celje;

            /// <summary>
            /// Cerklje na Gorenjskem
            /// </summary>
            public static EnumValues CerkljeNaGorenjskem => EnumValues.CerkljeNaGorenjskem;

            /// <summary>
            /// Cerknica
            /// </summary>
            public static EnumValues Cerknica => EnumValues.Cerknica;

            /// <summary>
            /// Cerkno
            /// </summary>
            public static EnumValues Cerkno => EnumValues.Cerkno;

            /// <summary>
            /// Črenšovci
            /// </summary>
            public static EnumValues Črenšovci => EnumValues.Črenšovci;

            /// <summary>
            /// Črna na Koroškem 
            /// </summary>
            public static EnumValues ČrnaNaKoroškem => EnumValues.ČrnaNaKoroškem;

            /// <summary>
            /// Črnomelj
            /// </summary>
            public static EnumValues Črnomelj => EnumValues.Črnomelj;

            /// <summary>
            /// Destrnik 
            /// </summary>
            public static EnumValues Destrnik => EnumValues.Destrnik;

            /// <summary>
            /// Divača
            /// </summary>
            public static EnumValues Divača => EnumValues.Divača;

            /// <summary>
            /// Dobrepolje 
            /// </summary>
            public static EnumValues Dobrepolje => EnumValues.Dobrepolje;

            /// <summary>
            /// Dobrova–Polhov Gradec
            /// </summary>
            public static EnumValues DobrovaPolhovGradec => EnumValues.DobrovaPolhovGradec;

            /// <summary>
            /// Dol pri Ljubljani 
            /// </summary>
            public static EnumValues DolPriLjubljani => EnumValues.DolPriLjubljani;

            /// <summary>
            /// Domžale
            /// </summary>
            public static EnumValues Domžale => EnumValues.Domžale;

            /// <summary>
            /// Dornava 
            /// </summary>
            public static EnumValues Dornava => EnumValues.Dornava;

            /// <summary>
            /// Dravograd
            /// </summary>
            public static EnumValues Dravograd => EnumValues.Dravograd;

            /// <summary>
            /// Duplek
            /// </summary>
            public static EnumValues Duplek => EnumValues.Duplek;

            /// <summary>
            /// Gorenja Vas–Poljane 
            /// </summary>
            public static EnumValues GorenjaVasPoljane => EnumValues.GorenjaVasPoljane;

            /// <summary>
            /// Gorišnica
            /// </summary>
            public static EnumValues Gorišnica => EnumValues.Gorišnica;

            /// <summary>
            /// Gornja Radgona
            /// </summary>
            public static EnumValues GornjaRadgona => EnumValues.GornjaRadgona;

            /// <summary>
            /// Gornji Grad 
            /// </summary>
            public static EnumValues GornjiGrad => EnumValues.GornjiGrad;

            /// <summary>
            /// Gornji Petrovci
            /// </summary>
            public static EnumValues GornjiPetrovci => EnumValues.GornjiPetrovci;

            /// <summary>
            /// Grosuplje 
            /// </summary>
            public static EnumValues Grosuplje => EnumValues.Grosuplje;

            /// <summary>
            /// Šalovci
            /// </summary>
            public static EnumValues Šalovci => EnumValues.Šalovci;

            /// <summary>
            /// Hrastnik
            /// </summary>
            public static EnumValues Hrastnik => EnumValues.Hrastnik;

            /// <summary>
            /// Hrpelje–Kozina
            /// </summary>
            public static EnumValues HrpeljeKozina => EnumValues.HrpeljeKozina;

            /// <summary>
            /// Idrija
            /// </summary>
            public static EnumValues Idrija => EnumValues.Idrija;

            /// <summary>
            /// Ig
            /// </summary>
            public static EnumValues Ig => EnumValues.Ig;

            /// <summary>
            /// Ilirska Bistrica
            /// </summary>
            public static EnumValues IlirskaBistrica => EnumValues.IlirskaBistrica;

            /// <summary>
            /// Ivančna Gorica
            /// </summary>
            public static EnumValues IvančnaGorica => EnumValues.IvančnaGorica;

            /// <summary>
            /// Izola
            /// </summary>
            public static EnumValues Izola => EnumValues.Izola;

            /// <summary>
            /// Jesenice
            /// </summary>
            public static EnumValues Jesenice => EnumValues.Jesenice;

            /// <summary>
            /// Juršinci
            /// </summary>
            public static EnumValues Juršinci => EnumValues.Juršinci;

            /// <summary>
            /// Kamnik
            /// </summary>
            public static EnumValues Kamnik => EnumValues.Kamnik;

            /// <summary>
            /// Kanal
            /// </summary>
            public static EnumValues Kanal => EnumValues.Kanal;

            /// <summary>
            /// Kidričevo
            /// </summary>
            public static EnumValues Kidričevo => EnumValues.Kidričevo;

            /// <summary>
            /// Kobarid
            /// </summary>
            public static EnumValues Kobarid => EnumValues.Kobarid;

            /// <summary>
            /// Kobilje
            /// </summary>
            public static EnumValues Kobilje => EnumValues.Kobilje;

            /// <summary>
            /// Kočevje
            /// </summary>
            public static EnumValues Kočevje => EnumValues.Kočevje;

            /// <summary>
            /// Komen
            /// </summary>
            public static EnumValues Komen => EnumValues.Komen;

            /// <summary>
            /// Koper
            /// </summary>
            public static EnumValues Koper => EnumValues.Koper;

            /// <summary>
            /// Kozje
            /// </summary>
            public static EnumValues Kozje => EnumValues.Kozje;

            /// <summary>
            /// Kranj
            /// </summary>
            public static EnumValues Kranj => EnumValues.Kranj;

            /// <summary>
            /// Kranjska Gora
            /// </summary>
            public static EnumValues KranjskaGora => EnumValues.KranjskaGora;

            /// <summary>
            /// Krško
            /// </summary>
            public static EnumValues Krško => EnumValues.Krško;

            /// <summary>
            /// Kungota
            /// </summary>
            public static EnumValues Kungota => EnumValues.Kungota;

            /// <summary>
            /// Kuzma
            /// </summary>
            public static EnumValues Kuzma => EnumValues.Kuzma;

            /// <summary>
            /// Laško
            /// </summary>
            public static EnumValues Laško => EnumValues.Laško;

            /// <summary>
            /// Lenart
            /// </summary>
            public static EnumValues Lenart => EnumValues.Lenart;

            /// <summary>
            /// Lendava
            /// </summary>
            public static EnumValues Lendava => EnumValues.Lendava;

            /// <summary>
            /// Litija
            /// </summary>
            public static EnumValues Litija => EnumValues.Litija;

            /// <summary>
            /// Ljubljana
            /// </summary>
            public static EnumValues Ljubljana => EnumValues.Ljubljana;

            /// <summary>
            /// Ljubno
            /// </summary>
            public static EnumValues Ljubno => EnumValues.Ljubno;

            /// <summary>
            /// Ljutomer
            /// </summary>
            public static EnumValues Ljutomer => EnumValues.Ljutomer;

            /// <summary>
            /// Logatec
            /// </summary>
            public static EnumValues Logatec => EnumValues.Logatec;

            /// <summary>
            /// Loška Dolina
            /// </summary>
            public static EnumValues LoškaDolina => EnumValues.LoškaDolina;

            /// <summary>
            /// Loški Potok
            /// </summary>
            public static EnumValues LoškiPotok => EnumValues.LoškiPotok;

            /// <summary>
            /// Luče
            /// </summary>
            public static EnumValues Luče => EnumValues.Luče;

            /// <summary>
            /// Lukovica
            /// </summary>
            public static EnumValues Lukovica => EnumValues.Lukovica;

            /// <summary>
            /// Majšperk
            /// </summary>
            public static EnumValues Majšperk => EnumValues.Majšperk;

            /// <summary>
            /// Maribor
            /// </summary>
            public static EnumValues Maribor => EnumValues.Maribor;

            /// <summary>
            /// Medvode
            /// </summary>
            public static EnumValues Medvode => EnumValues.Medvode;

            /// <summary>
            /// Mengeš
            /// </summary>
            public static EnumValues Mengeš => EnumValues.Mengeš;

            /// <summary>
            /// Metlika
            /// </summary>
            public static EnumValues Metlika => EnumValues.Metlika;

            /// <summary>
            /// Mežica
            /// </summary>
            public static EnumValues Mežica => EnumValues.Mežica;

            /// <summary>
            /// Miren–Kostanjevica
            /// </summary>
            public static EnumValues MirenKostanjevica => EnumValues.MirenKostanjevica;

            /// <summary>
            /// Mislinja
            /// </summary>
            public static EnumValues Mislinja => EnumValues.Mislinja;

            /// <summary>
            /// Moravče
            /// </summary>
            public static EnumValues Moravče => EnumValues.Moravče;

            /// <summary>
            /// Moravske Toplice
            /// </summary>
            public static EnumValues MoravskeToplice => EnumValues.MoravskeToplice;

            /// <summary>
            /// Mozirje
            /// </summary>
            public static EnumValues Mozirje => EnumValues.Mozirje;

            /// <summary>
            /// Murska Sobota
            /// </summary>
            public static EnumValues MurskaSobota => EnumValues.MurskaSobota;

            /// <summary>
            /// Muta
            /// </summary>
            public static EnumValues Muta => EnumValues.Muta;

            /// <summary>
            /// Naklo
            /// </summary>
            public static EnumValues Naklo => EnumValues.Naklo;

            /// <summary>
            /// Nazarje
            /// </summary>
            public static EnumValues Nazarje => EnumValues.Nazarje;

            /// <summary>
            /// Nova Gorica
            /// </summary>
            public static EnumValues NovaGorica => EnumValues.NovaGorica;

            /// <summary>
            /// Novo Mesto
            /// </summary>
            public static EnumValues NovoMesto => EnumValues.NovoMesto;

            /// <summary>
            /// Odranci
            /// </summary>
            public static EnumValues Odranci => EnumValues.Odranci;

            /// <summary>
            /// Ormož
            /// </summary>
            public static EnumValues Ormož => EnumValues.Ormož;

            /// <summary>
            /// Osilnica
            /// </summary>
            public static EnumValues Osilnica => EnumValues.Osilnica;

            /// <summary>
            /// Pesnica
            /// </summary>
            public static EnumValues Pesnica => EnumValues.Pesnica;

            /// <summary>
            /// Piran
            /// </summary>
            public static EnumValues Piran => EnumValues.Piran;

            /// <summary>
            /// Pivka
            /// </summary>
            public static EnumValues Pivka => EnumValues.Pivka;

            /// <summary>
            /// Podčetrtek
            /// </summary>
            public static EnumValues Podčetrtek => EnumValues.Podčetrtek;

            /// <summary>
            /// Podvelka
            /// </summary>
            public static EnumValues Podvelka => EnumValues.Podvelka;

            /// <summary>
            /// Postojna
            /// </summary>
            public static EnumValues Postojna => EnumValues.Postojna;

            /// <summary>
            /// Preddvor
            /// </summary>
            public static EnumValues Preddvor => EnumValues.Preddvor;

            /// <summary>
            /// Ptuj
            /// </summary>
            public static EnumValues Ptuj => EnumValues.Ptuj;

            /// <summary>
            /// Puconci
            /// </summary>
            public static EnumValues Puconci => EnumValues.Puconci;

            /// <summary>
            /// Rače–Fram
            /// </summary>
            public static EnumValues RačeFram => EnumValues.RačeFram;

            /// <summary>
            /// Radeče
            /// </summary>
            public static EnumValues Radeče => EnumValues.Radeče;

            /// <summary>
            /// Radenci
            /// </summary>
            public static EnumValues Radenci => EnumValues.Radenci;

            /// <summary>
            /// Radlje ob Dravi
            /// </summary>
            public static EnumValues RadljeObDravi => EnumValues.RadljeObDravi;

            /// <summary>
            /// Radovljica
            /// </summary>
            public static EnumValues Radovljica => EnumValues.Radovljica;

            /// <summary>
            /// Ravne na Koroškem
            /// </summary>
            public static EnumValues RavneNaKoroškem => EnumValues.RavneNaKoroškem;

            /// <summary>
            /// Ribnica
            /// </summary>
            public static EnumValues Ribnica => EnumValues.Ribnica;

            /// <summary>
            /// Rogašovci
            /// </summary>
            public static EnumValues Rogašovci => EnumValues.Rogašovci;

            /// <summary>
            /// Rogaška Slatina
            /// </summary>
            public static EnumValues RogaškaSlatina => EnumValues.RogaškaSlatina;

            /// <summary>
            /// Rogatec
            /// </summary>
            public static EnumValues Rogatec => EnumValues.Rogatec;

            /// <summary>
            /// Ruše
            /// </summary>
            public static EnumValues Ruše => EnumValues.Ruše;

            /// <summary>
            /// Semič
            /// </summary>
            public static EnumValues Semič => EnumValues.Semič;

            /// <summary>
            /// Sevnica
            /// </summary>
            public static EnumValues Sevnica => EnumValues.Sevnica;

            /// <summary>
            /// Sežana
            /// </summary>
            public static EnumValues Sežana => EnumValues.Sežana;

            /// <summary>
            /// Slovenj Gradec
            /// </summary>
            public static EnumValues SlovenjGradec => EnumValues.SlovenjGradec;

            /// <summary>
            /// Slovenska Bistrica
            /// </summary>
            public static EnumValues SlovenskaBistrica => EnumValues.SlovenskaBistrica;

            /// <summary>
            /// Slovenske Konjice
            /// </summary>
            public static EnumValues SlovenskeKonjice => EnumValues.SlovenskeKonjice;

            /// <summary>
            /// Starše
            /// </summary>
            public static EnumValues Starše => EnumValues.Starše;

            /// <summary>
            /// Sveti Jurij
            /// </summary>
            public static EnumValues SvetiJurij => EnumValues.SvetiJurij;

            /// <summary>
            /// Šenčur
            /// </summary>
            public static EnumValues Šenčur => EnumValues.Šenčur;

            /// <summary>
            /// Šentilj
            /// </summary>
            public static EnumValues Šentilj => EnumValues.Šentilj;

            /// <summary>
            /// Šentjernej
            /// </summary>
            public static EnumValues Šentjernej => EnumValues.Šentjernej;

            /// <summary>
            /// Šentjur
            /// </summary>
            public static EnumValues Šentjur => EnumValues.Šentjur;

            /// <summary>
            /// Škocjan
            /// </summary>
            public static EnumValues Škocjan => EnumValues.Škocjan;

            /// <summary>
            /// Škofja Loka
            /// </summary>
            public static EnumValues ŠkofjaLoka => EnumValues.ŠkofjaLoka;

            /// <summary>
            /// Škofljica
            /// </summary>
            public static EnumValues Škofljica => EnumValues.Škofljica;

            /// <summary>
            /// Šmarje pri Jelšah
            /// </summary>
            public static EnumValues ŠmarjePriJelšah => EnumValues.ŠmarjePriJelšah;

            /// <summary>
            /// Šmartno ob Paki
            /// </summary>
            public static EnumValues ŠmartnoObPaki => EnumValues.ŠmartnoObPaki;

            /// <summary>
            /// Šoštanj
            /// </summary>
            public static EnumValues Šoštanj => EnumValues.Šoštanj;

            /// <summary>
            /// Štore
            /// </summary>
            public static EnumValues Štore => EnumValues.Štore;

            /// <summary>
            /// Tolmin
            /// </summary>
            public static EnumValues Tolmin => EnumValues.Tolmin;

            /// <summary>
            /// Trbovlje
            /// </summary>
            public static EnumValues Trbovlje => EnumValues.Trbovlje;

            /// <summary>
            /// Trebnje
            /// </summary>
            public static EnumValues Trebnje => EnumValues.Trebnje;

            /// <summary>
            /// Tržič
            /// </summary>
            public static EnumValues Tržič => EnumValues.Tržič;

            /// <summary>
            /// Turnišče
            /// </summary>
            public static EnumValues Turnišče => EnumValues.Turnišče;

            /// <summary>
            /// Velenje
            /// </summary>
            public static EnumValues Velenje => EnumValues.Velenje;

            /// <summary>
            /// Velike Lašče
            /// </summary>
            public static EnumValues VelikeLašče => EnumValues.VelikeLašče;

            /// <summary>
            /// Videm
            /// </summary>
            public static EnumValues Videm => EnumValues.Videm;

            /// <summary>
            /// Vipava
            /// </summary>
            public static EnumValues Vipava => EnumValues.Vipava;

            /// <summary>
            /// Vitanje
            /// </summary>
            public static EnumValues Vitanje => EnumValues.Vitanje;

            /// <summary>
            /// Vodice
            /// </summary>
            public static EnumValues Vodice => EnumValues.Vodice;

            /// <summary>
            /// Vojnik
            /// </summary>
            public static EnumValues Vojnik => EnumValues.Vojnik;

            /// <summary>
            /// Vrhnika
            /// </summary>
            public static EnumValues Vrhnika => EnumValues.Vrhnika;

            /// <summary>
            /// Vuzenica
            /// </summary>
            public static EnumValues Vuzenica => EnumValues.Vuzenica;

            /// <summary>
            /// Zagorje ob Savi
            /// </summary>
            public static EnumValues ZagorjeObSavi => EnumValues.ZagorjeObSavi;

            /// <summary>
            /// Zavrč
            /// </summary>
            public static EnumValues Zavrč => EnumValues.Zavrč;

            /// <summary>
            /// Zreče
            /// </summary>
            public static EnumValues Zreče => EnumValues.Zreče;

            /// <summary>
            /// Železniki
            /// </summary>
            public static EnumValues Železniki => EnumValues.Železniki;

            /// <summary>
            /// Žiri
            /// </summary>
            public static EnumValues Žiri => EnumValues.Žiri;

            /// <summary>
            /// Benedikt
            /// </summary>
            public static EnumValues Benedikt => EnumValues.Benedikt;

            /// <summary>
            /// Bistrica ob Sotli
            /// </summary>
            public static EnumValues BistricaObSotli => EnumValues.BistricaObSotli;

            /// <summary>
            /// Bloke
            /// </summary>
            public static EnumValues Bloke => EnumValues.Bloke;

            /// <summary>
            /// Braslovče
            /// </summary>
            public static EnumValues Braslovče => EnumValues.Braslovče;

            /// <summary>
            /// Cankova
            /// </summary>
            public static EnumValues Cankova => EnumValues.Cankova;

            /// <summary>
            /// Cerkvenjak
            /// </summary>
            public static EnumValues Cerkvenjak => EnumValues.Cerkvenjak;

            /// <summary>
            /// Dobje
            /// </summary>
            public static EnumValues Dobje => EnumValues.Dobje;

            /// <summary>
            /// Dobrna
            /// </summary>
            public static EnumValues Dobrna => EnumValues.Dobrna;

            /// <summary>
            /// Dobrovnik
            /// </summary>
            public static EnumValues Dobrovnik => EnumValues.Dobrovnik;

            /// <summary>
            /// Dolenjske Toplice
            /// </summary>
            public static EnumValues DolenjskeToplice => EnumValues.DolenjskeToplice;

            /// <summary>
            /// Grad
            /// </summary>
            public static EnumValues Grad => EnumValues.Grad;

            /// <summary>
            /// Hajdina
            /// </summary>
            public static EnumValues Hajdina => EnumValues.Hajdina;

            /// <summary>
            /// Hoče–Slivnica
            /// </summary>
            public static EnumValues HočeSlivnica => EnumValues.HočeSlivnica;

            /// <summary>
            /// Hodoš
            /// </summary>
            public static EnumValues Hodoš => EnumValues.Hodoš;

            /// <summary>
            /// Horjul
            /// </summary>
            public static EnumValues Horjul => EnumValues.Horjul;

            /// <summary>
            /// Jezersko
            /// </summary>
            public static EnumValues Jezersko => EnumValues.Jezersko;

            /// <summary>
            /// Komenda
            /// </summary>
            public static EnumValues Komenda => EnumValues.Komenda;

            /// <summary>
            /// Kostel
            /// </summary>
            public static EnumValues Kostel => EnumValues.Kostel;

            /// <summary>
            /// Križevci
            /// </summary>
            public static EnumValues Križevci => EnumValues.Križevci;

            /// <summary>
            /// Lovrenc na Pohorju
            /// </summary>
            public static EnumValues LovrencNaPohorju => EnumValues.LovrencNaPohorju;

            /// <summary>
            /// Markovci
            /// </summary>
            public static EnumValues Markovci => EnumValues.Markovci;

            /// <summary>
            /// Miklavž na Dravskem Polju
            /// </summary>
            public static EnumValues MiklavžNaDravskemPolju => EnumValues.MiklavžNaDravskemPolju;

            /// <summary>
            /// Mirna Peč
            /// </summary>
            public static EnumValues MirnaPeč => EnumValues.MirnaPeč;

            /// <summary>
            /// Oplotnica
            /// </summary>
            public static EnumValues Oplotnica => EnumValues.Oplotnica;

            /// <summary>
            /// Podlehnik
            /// </summary>
            public static EnumValues Podlehnik => EnumValues.Podlehnik;

            /// <summary>
            /// Polzela
            /// </summary>
            public static EnumValues Polzela => EnumValues.Polzela;

            /// <summary>
            /// Prebold
            /// </summary>
            public static EnumValues Prebold => EnumValues.Prebold;

            /// <summary>
            /// Prevalje
            /// </summary>
            public static EnumValues Prevalje => EnumValues.Prevalje;

            /// <summary>
            /// Razkrižje
            /// </summary>
            public static EnumValues Razkrižje => EnumValues.Razkrižje;

            /// <summary>
            /// Ribnica na Pohorju
            /// </summary>
            public static EnumValues RibnicaNaPohorju => EnumValues.RibnicaNaPohorju;

            /// <summary>
            /// Selnica ob Dravi
            /// </summary>
            public static EnumValues SelnicaObDravi => EnumValues.SelnicaObDravi;

            /// <summary>
            /// Sodražica
            /// </summary>
            public static EnumValues Sodražica => EnumValues.Sodražica;

            /// <summary>
            /// Solčava
            /// </summary>
            public static EnumValues Solčava => EnumValues.Solčava;

            /// <summary>
            /// Sveta Ana
            /// </summary>
            public static EnumValues SvetaAna => EnumValues.SvetaAna;

            /// <summary>
            /// Sveti Andraž v Slovenskih Goricah
            /// </summary>
            public static EnumValues SvetiAndražVSlovenskihGoricah => EnumValues.SvetiAndražVSlovenskihGoricah;

            /// <summary>
            /// Šempeter–Vrtojba
            /// </summary>
            public static EnumValues ŠempeterVrtojba => EnumValues.ŠempeterVrtojba;

            /// <summary>
            /// Tabor
            /// </summary>
            public static EnumValues Tabor => EnumValues.Tabor;

            /// <summary>
            /// Trnovska Vas
            /// </summary>
            public static EnumValues TrnovskaVas => EnumValues.TrnovskaVas;

            /// <summary>
            /// Trzin
            /// </summary>
            public static EnumValues Trzin => EnumValues.Trzin;

            /// <summary>
            /// Velika Polana
            /// </summary>
            public static EnumValues VelikaPolana => EnumValues.VelikaPolana;

            /// <summary>
            /// Veržej
            /// </summary>
            public static EnumValues Veržej => EnumValues.Veržej;

            /// <summary>
            /// Vransko
            /// </summary>
            public static EnumValues Vransko => EnumValues.Vransko;

            /// <summary>
            /// Žalec
            /// </summary>
            public static EnumValues Žalec => EnumValues.Žalec;

            /// <summary>
            /// Žetale
            /// </summary>
            public static EnumValues Žetale => EnumValues.Žetale;

            /// <summary>
            /// Žirovnica
            /// </summary>
            public static EnumValues Žirovnica => EnumValues.Žirovnica;

            /// <summary>
            /// Žužemberk
            /// </summary>
            public static EnumValues Žužemberk => EnumValues.Žužemberk;

            /// <summary>
            /// Šmartno pri Litiji
            /// </summary>
            public static EnumValues ŠmartnoPriLitiji => EnumValues.ŠmartnoPriLitiji;

            /// <summary>
            /// Apače
            /// </summary>
            public static EnumValues Apače => EnumValues.Apače;

            /// <summary>
            /// Cirkulane
            /// </summary>
            public static EnumValues Cirkulane => EnumValues.Cirkulane;

            /// <summary>
            /// Kostanjevica na Krki
            /// </summary>
            public static EnumValues KostanjevicaNaKrki => EnumValues.KostanjevicaNaKrki;

            /// <summary>
            /// Makole
            /// </summary>
            public static EnumValues Makole => EnumValues.Makole;

            /// <summary>
            /// Mokronog–Trebelno
            /// </summary>
            public static EnumValues MokronogTrebelno => EnumValues.MokronogTrebelno;

            /// <summary>
            /// Poljčane
            /// </summary>
            public static EnumValues Poljčane => EnumValues.Poljčane;

            /// <summary>
            /// Renče–Vogrsko
            /// </summary>
            public static EnumValues RenčeVogrsko => EnumValues.RenčeVogrsko;

            /// <summary>
            /// Središče ob Dravi
            /// </summary>
            public static EnumValues SrediščeObDravi => EnumValues.SrediščeObDravi;

            /// <summary>
            /// Straža
            /// </summary>
            public static EnumValues Straža => EnumValues.Straža;

            /// <summary>
            /// Sveta Trojica v Slovenskih Goricah
            /// </summary>
            public static EnumValues SvetaTrojicaVSlovenskihGoricah => EnumValues.SvetaTrojicaVSlovenskihGoricah;

            /// <summary>
            /// Sveti Tomaž
            /// </summary>
            public static EnumValues SvetiTomaž => EnumValues.SvetiTomaž;

            /// <summary>
            /// Šmarješke Toplice
            /// </summary>
            public static EnumValues ŠmarješkeToplice => EnumValues.ŠmarješkeToplice;

            /// <summary>
            /// Gorje
            /// </summary>
            public static EnumValues Gorje => EnumValues.Gorje;

            /// <summary>
            /// Log–Dragomer
            /// </summary>
            public static EnumValues LogDragomer => EnumValues.LogDragomer;

            /// <summary>
            /// Rečica ob Savinji
            /// </summary>
            public static EnumValues RečicaObSavinji => EnumValues.RečicaObSavinji;

            /// <summary>
            /// Sveti Jurij v Slovenskih Goricah
            /// </summary>
            public static EnumValues SvetiJurijVSlovenskihGoricah => EnumValues.SvetiJurijVSlovenskihGoricah;

            /// <summary>
            /// Šentrupert
            /// </summary>
            public static EnumValues Šentrupert => EnumValues.Šentrupert;

            /// <summary>
            /// Mirna
            /// </summary>
            public static EnumValues Mirna => EnumValues.Mirna;
        }

        #endregion

        #region Region definition

        /// <summary>
        /// Special regions
        /// </summary>
        public static class Special
        {
            /// <summary>
            /// Mayotte
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Mayotte => Country.Mayotte;

            /// <summary>
            /// Mayotte
            /// </summary>
            public static CountryCode MayotteCode => CountryCode.YT;

            /// <summary>
            /// Martinique
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Martinique => Country.Martinique;

            /// <summary>
            /// Martinique
            /// </summary>
            public static CountryCode MartiniqueCode => CountryCode.MQ;

            /// <summary>
            /// Guadeloupe
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Guadeloupe => Country.Guadeloupe;

            /// <summary>
            /// Guadeloupe
            /// </summary>
            public static CountryCode GuadeloupeCode => CountryCode.GP;

            /// <summary>
            /// Guiana
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Guiana => Country.Guiana;

            /// <summary>
            /// Guiana
            /// </summary>
            public static CountryCode GuianaCode => CountryCode.GF;

            /// <summary>
            /// Réunion
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country Réunion => Country.Réunion;

            /// <summary>
            /// Réunion
            /// </summary>
            public static CountryCode RéunionCode => CountryCode.RE;
        }

        /// <summary>
        /// Enum values for Slovenia regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Ajdovščina
            /// </summary>
            [AliasInShort("YT")]
            [RegionCode(2_00_138_0001)]
            Ajdovščina,

            /// <summary>
            /// Beltinci
            /// </summary>
            [AliasInShort("002")]
            [RegionCode(2_00_138_0002)]
            Beltinci,

            /// <summary>
            /// Bled
            /// </summary>
            [AliasInShort("003")]
            [RegionCode(2_00_138_0003)]
            Bled,

            /// <summary>
            /// Bohinj
            /// </summary>
            [AliasInShort("004")]
            [RegionCode(2_00_138_0004)]
            Bohinj,

            /// <summary>
            /// Borovnica
            /// </summary>
            [AliasInShort("005")]
            [RegionCode(2_00_138_0005)]
            Borovnica,

            /// <summary>
            /// Bovec
            /// </summary>
            [AliasInShort("006")]
            [RegionCode(2_00_138_0006)]
            Bovec,

            /// <summary>
            /// Brda
            /// </summary>
            [AliasInShort("007")]
            [RegionCode(2_00_138_0007)]
            Brda,

            /// <summary>
            /// Brezovica
            /// </summary>
            [AliasInShort("008")]
            [RegionCode(2_00_138_0008)]
            Brezovica,

            /// <summary>
            /// Brežice
            /// </summary>
            [AliasInShort("009")]
            [RegionCode(2_00_138_0009)]
            Brežice,

            /// <summary>
            /// Tišina
            /// </summary>
            [AliasInShort("010")]
            [RegionCode(2_00_138_0010)]
            Tišina,

            /// <summary>
            /// Celje
            /// </summary>
            [AliasInShort("011")]
            [RegionCode(2_00_138_0011)]
            Celje,

            /// <summary>
            /// Cerklje na Gorenjskem
            /// </summary>
            [AliasInShort("012")]
            [RegionCode(2_00_138_0012)]
            CerkljeNaGorenjskem,

            /// <summary>
            /// Cerknica
            /// </summary>
            [AliasInShort("013")]
            [RegionCode(2_00_138_0013)]
            Cerknica,

            /// <summary>
            /// Cerkno
            /// </summary>
            [AliasInShort("014")]
            [RegionCode(2_00_138_0014)]
            Cerkno,

            /// <summary>
            /// Črenšovci
            /// </summary>
            [AliasInShort("015")]
            [RegionCode(2_00_138_0015)]
            Črenšovci,

            /// <summary>
            /// Črna na Koroškem
            /// </summary>
            [AliasInShort("016")]
            [RegionCode(2_00_138_0016)]
            ČrnaNaKoroškem,

            /// <summary>
            /// Črnomelj
            /// </summary>
            [AliasInShort("017")]
            [RegionCode(2_00_138_0017)]
            Črnomelj,

            /// <summary>
            /// Destrnik
            /// </summary>
            [AliasInShort("018")]
            [RegionCode(2_00_138_0018)]
            Destrnik,

            /// <summary>
            /// Divača
            /// </summary>
            [AliasInShort("019")]
            [RegionCode(2_00_138_0019)]
            Divača,

            /// <summary>
            /// Dobrepolje
            /// </summary>
            [AliasInShort("020")]
            [RegionCode(2_00_138_0020)]
            Dobrepolje,

            /// <summary>
            /// Dobrova–Polhov Gradec
            /// </summary>
            [AliasInShort("021")]
            [RegionCode(2_00_138_0021)]
            DobrovaPolhovGradec,

            /// <summary>
            /// Dol pri Ljubljani
            /// </summary>
            [AliasInShort("022")]
            [RegionCode(2_00_138_0022)]
            DolPriLjubljani,

            /// <summary>
            /// Domžale
            /// </summary>
            [AliasInShort("023")]
            [RegionCode(2_00_138_0023)]
            Domžale,

            /// <summary>
            /// Dornava
            /// </summary>
            [AliasInShort("024")]
            [RegionCode(2_00_138_0024)]
            Dornava,

            /// <summary>
            /// Dravograd
            /// </summary>
            [AliasInShort("025")]
            [RegionCode(2_00_138_0025)]
            Dravograd,

            /// <summary>
            /// Duplek
            /// </summary>
            [AliasInShort("026")]
            [RegionCode(2_00_138_0026)]
            Duplek,

            /// <summary>
            /// Gorenja Vas–Poljane
            /// </summary>
            [AliasInShort("027")]
            [RegionCode(2_00_138_0027)]
            GorenjaVasPoljane,

            /// <summary>
            /// Gorišnica
            /// </summary>
            [AliasInShort("028")]
            [RegionCode(2_00_138_0028)]
            Gorišnica,

            /// <summary>
            /// Gornja Radgona
            /// </summary>
            [AliasInShort("029")]
            [RegionCode(2_00_138_0029)]
            GornjaRadgona,

            /// <summary>
            /// Gornji Grad
            /// </summary>
            [AliasInShort("030")]
            [RegionCode(2_00_138_0030)]
            GornjiGrad,

            /// <summary>
            /// Gornji Petrovci
            /// </summary>
            [AliasInShort("031")]
            [RegionCode(2_00_138_0031)]
            GornjiPetrovci,

            /// <summary>
            /// Grosuplje
            /// </summary>
            [AliasInShort("032")]
            [RegionCode(2_00_138_0032)]
            Grosuplje,

            /// <summary>
            /// Šalovci
            /// </summary>
            [AliasInShort("033")]
            [RegionCode(2_00_138_0033)]
            Šalovci,

            /// <summary>
            /// Hrastnik
            /// </summary>
            [AliasInShort("034")]
            [RegionCode(2_00_138_0034)]
            Hrastnik,

            /// <summary>
            /// Hrpelje–Kozina
            /// </summary>
            [AliasInShort("035")]
            [RegionCode(2_00_138_0035)]
            HrpeljeKozina,

            /// <summary>
            /// Idrija
            /// </summary>
            [AliasInShort("036")]
            [RegionCode(2_00_138_0036)]
            Idrija,

            /// <summary>
            /// Ig
            /// </summary>
            [AliasInShort("037")]
            [RegionCode(2_00_138_0037)]
            Ig,

            /// <summary>
            /// Ilirska Bistrica
            /// </summary>
            [AliasInShort("038")]
            [RegionCode(2_00_138_0038)]
            IlirskaBistrica,

            /// <summary>
            /// Ivančna Gorica
            /// </summary>
            [AliasInShort("039")]
            [RegionCode(2_00_138_0039)]
            IvančnaGorica,

            /// <summary>
            /// Izola
            /// </summary>
            [AliasInShort("040")]
            [RegionCode(2_00_138_0040)]
            Izola,

            /// <summary>
            /// Jesenice
            /// </summary>
            [AliasInShort("041")]
            [RegionCode(2_00_138_0041)]
            Jesenice,

            /// <summary>
            /// Juršinci
            /// </summary>
            [AliasInShort("042")]
            [RegionCode(2_00_138_0042)]
            Juršinci,

            /// <summary>
            /// Kamnik
            /// </summary>
            [AliasInShort("043")]
            [RegionCode(2_00_138_0043)]
            Kamnik,

            /// <summary>
            /// Kanal
            /// </summary>
            [AliasInShort("044")]
            [RegionCode(2_00_138_0044)]
            Kanal,

            /// <summary>
            /// Kidričevo
            /// </summary>
            [AliasInShort("045")]
            [RegionCode(2_00_138_0045)]
            Kidričevo,

            /// <summary>
            /// Kobarid
            /// </summary>
            [AliasInShort("046")]
            [RegionCode(2_00_138_0046)]
            Kobarid,

            /// <summary>
            /// Kobilje
            /// </summary>
            [AliasInShort("047")]
            [RegionCode(2_00_138_0047)]
            Kobilje,

            /// <summary>
            /// Kočevje
            /// </summary>
            [AliasInShort("048")]
            [RegionCode(2_00_138_0048)]
            Kočevje,

            /// <summary>
            /// Komen
            /// </summary>
            [AliasInShort("049")]
            [RegionCode(2_00_138_0049)]
            Komen,

            /// <summary>
            /// Koper
            /// </summary>
            [AliasInShort("050")]
            [RegionCode(2_00_138_0050)]
            Koper,

            /// <summary>
            /// Kozje
            /// </summary>
            [AliasInShort("051")]
            [RegionCode(2_00_138_0051)]
            Kozje,

            /// <summary>
            /// Kranj
            /// </summary>
            [AliasInShort("052")]
            [RegionCode(2_00_138_0052)]
            Kranj,

            /// <summary>
            /// Kranjska Gora
            /// </summary>
            [AliasInShort("053")]
            [RegionCode(2_00_138_0053)]
            KranjskaGora,

            /// <summary>
            /// Krško
            /// </summary>
            [AliasInShort("054")]
            [RegionCode(2_00_138_0054)]
            Krško,

            /// <summary>
            /// Kungota
            /// </summary>
            [AliasInShort("055")]
            [RegionCode(2_00_138_0055)]
            Kungota,

            /// <summary>
            /// Kuzma
            /// </summary>
            [AliasInShort("056")]
            [RegionCode(2_00_138_0056)]
            Kuzma,

            /// <summary>
            /// Laško
            /// </summary>
            [AliasInShort("057")]
            [RegionCode(2_00_138_0057)]
            Laško,

            /// <summary>
            /// Lenart
            /// </summary>
            [AliasInShort("058")]
            [RegionCode(2_00_138_0058)]
            Lenart,

            /// <summary>
            /// Lendava
            /// </summary>
            [AliasInShort("059")]
            [RegionCode(2_00_138_0059)]
            Lendava,

            /// <summary>
            /// Litija
            /// </summary>
            [AliasInShort("060")]
            [RegionCode(2_00_138_0060)]
            Litija,

            /// <summary>
            /// Ljubljana
            /// </summary>
            [AliasInShort("061")]
            [RegionCode(2_00_138_0061)]
            Ljubljana,

            /// <summary>
            /// Ljubno
            /// </summary>
            [AliasInShort("062")]
            [RegionCode(2_00_138_0062)]
            Ljubno,

            /// <summary>
            /// Ljutomer
            /// </summary>
            [AliasInShort("063")]
            [RegionCode(2_00_138_0063)]
            Ljutomer,

            /// <summary>
            /// Logatec
            /// </summary>
            [AliasInShort("064")]
            [RegionCode(2_00_138_0064)]
            Logatec,

            /// <summary>
            /// Loška Dolina
            /// </summary>
            [AliasInShort("065")]
            [RegionCode(2_00_138_0065)]
            LoškaDolina,

            /// <summary>
            /// Loški Potok
            /// </summary>
            [AliasInShort("066")]
            [RegionCode(2_00_138_0066)]
            LoškiPotok,

            /// <summary>
            /// Luče
            /// </summary>
            [AliasInShort("067")]
            [RegionCode(2_00_138_0067)]
            Luče,

            /// <summary>
            /// Lukovica
            /// </summary>
            [AliasInShort("068")]
            [RegionCode(2_00_138_0068)]
            Lukovica,

            /// <summary>
            /// Majšperk
            /// </summary>
            [AliasInShort("069")]
            [RegionCode(2_00_138_0069)]
            Majšperk,

            /// <summary>
            /// Maribor
            /// </summary>
            [AliasInShort("070")]
            [RegionCode(2_00_138_0070)]
            Maribor,

            /// <summary>
            /// Medvode
            /// </summary>
            [AliasInShort("071")]
            [RegionCode(2_00_138_0071)]
            Medvode,

            /// <summary>
            /// Mengeš
            /// </summary>
            [AliasInShort("072")]
            [RegionCode(2_00_138_0072)]
            Mengeš,

            /// <summary>
            /// Metlika
            /// </summary>
            [AliasInShort("073")]
            [RegionCode(2_00_138_0073)]
            Metlika,

            /// <summary>
            /// Mežica
            /// </summary>
            [AliasInShort("074")]
            [RegionCode(2_00_138_0074)]
            Mežica,

            /// <summary>
            /// Miren–Kostanjevica
            /// </summary>
            [AliasInShort("075")]
            [RegionCode(2_00_138_0075)]
            MirenKostanjevica,

            /// <summary>
            /// Mislinja
            /// </summary>
            [AliasInShort("076")]
            [RegionCode(2_00_138_0076)]
            Mislinja,

            /// <summary>
            /// Moravče
            /// </summary>
            [AliasInShort("077")]
            [RegionCode(2_00_138_0077)]
            Moravče,

            /// <summary>
            /// Moravske Toplice
            /// </summary>
            [AliasInShort("078")]
            [RegionCode(2_00_138_0078)]
            MoravskeToplice,

            /// <summary>
            /// Mozirje
            /// </summary>
            [AliasInShort("079")]
            [RegionCode(2_00_138_0079)]
            Mozirje,

            /// <summary>
            /// Murska Sobota
            /// </summary>
            [AliasInShort("080")]
            [RegionCode(2_00_138_0080)]
            MurskaSobota,

            /// <summary>
            /// Muta
            /// </summary>
            [AliasInShort("081")]
            [RegionCode(2_00_138_0081)]
            Muta,

            /// <summary>
            /// Naklo
            /// </summary>
            [AliasInShort("082")]
            [RegionCode(2_00_138_0082)]
            Naklo,

            /// <summary>
            /// Nazarje
            /// </summary>
            [AliasInShort("083")]
            [RegionCode(2_00_138_0083)]
            Nazarje,

            /// <summary>
            /// Nova Gorica
            /// </summary>
            [AliasInShort("084")]
            [RegionCode(2_00_138_0084)]
            NovaGorica,

            /// <summary>
            /// Novo Mesto
            /// </summary>
            [AliasInShort("085")]
            [RegionCode(2_00_138_0085)]
            NovoMesto,

            /// <summary>
            /// Odranci
            /// </summary>
            [AliasInShort("086")]
            [RegionCode(2_00_138_0086)]
            Odranci,

            /// <summary>
            /// Ormož
            /// </summary>
            [AliasInShort("087")]
            [RegionCode(2_00_138_0087)]
            Ormož,

            /// <summary>
            /// Osilnica
            /// </summary>
            [AliasInShort("088")]
            [RegionCode(2_00_138_0088)]
            Osilnica,

            /// <summary>
            /// Pesnica
            /// </summary>
            [AliasInShort("089")]
            [RegionCode(2_00_138_0089)]
            Pesnica,

            /// <summary>
            /// Piran
            /// </summary>
            [AliasInShort("090")]
            [RegionCode(2_00_138_0090)]
            Piran,

            /// <summary>
            /// Pivka
            /// </summary>
            [AliasInShort("091")]
            [RegionCode(2_00_138_0091)]
            Pivka,

            /// <summary>
            /// Podčetrtek
            /// </summary>
            [AliasInShort("092")]
            [RegionCode(2_00_138_0092)]
            Podčetrtek,

            /// <summary>
            /// Podvelka
            /// </summary>
            [AliasInShort("093")]
            [RegionCode(2_00_138_0093)]
            Podvelka,

            /// <summary>
            /// Postojna
            /// </summary>
            [AliasInShort("094")]
            [RegionCode(2_00_138_0094)]
            Postojna,

            /// <summary>
            /// Preddvor
            /// </summary>
            [AliasInShort("095")]
            [RegionCode(2_00_138_0095)]
            Preddvor,

            /// <summary>
            /// Ptuj
            /// </summary>
            [AliasInShort("096")]
            [RegionCode(2_00_138_0096)]
            Ptuj,

            /// <summary>
            /// Puconci
            /// </summary>
            [AliasInShort("097")]
            [RegionCode(2_00_138_0097)]
            Puconci,

            /// <summary>
            /// Rače–Fram
            /// </summary>
            [AliasInShort("098")]
            [RegionCode(2_00_138_0098)]
            RačeFram,

            /// <summary>
            /// Radeče
            /// </summary>
            [AliasInShort("099")]
            [RegionCode(2_00_138_0099)]
            Radeče,

            /// <summary>
            /// Radenci
            /// </summary>
            [AliasInShort("100")]
            [RegionCode(2_00_138_0100)]
            Radenci,

            /// <summary>
            /// Radlje ob Dravi
            /// </summary>
            [AliasInShort("101")]
            [RegionCode(2_00_138_0101)]
            RadljeObDravi,

            /// <summary>
            /// Radovljica
            /// </summary>
            [AliasInShort("102")]
            [RegionCode(2_00_138_0102)]
            Radovljica,

            /// <summary>
            /// Ravne na Koroškem
            /// </summary>
            [AliasInShort("103")]
            [RegionCode(2_00_138_0103)]
            RavneNaKoroškem,

            /// <summary>
            /// Ribnica
            /// </summary>
            [AliasInShort("104")]
            [RegionCode(2_00_138_0104)]
            Ribnica,

            /// <summary>
            /// Rogašovci
            /// </summary>
            [AliasInShort("105")]
            [RegionCode(2_00_138_0105)]
            Rogašovci,

            /// <summary>
            /// Rogaška Slatina
            /// </summary>
            [AliasInShort("106")]
            [RegionCode(2_00_138_0106)]
            RogaškaSlatina,

            /// <summary>
            /// Rogatec
            /// </summary>
            [AliasInShort("107")]
            [RegionCode(2_00_138_0107)]
            Rogatec,

            /// <summary>
            /// Ruše
            /// </summary>
            [AliasInShort("108")]
            [RegionCode(2_00_138_0108)]
            Ruše,

            /// <summary>
            /// Semič
            /// </summary>
            [AliasInShort("109")]
            [RegionCode(2_00_138_0109)]
            Semič,

            /// <summary>
            /// Sevnica
            /// </summary>
            [AliasInShort("110")]
            [RegionCode(2_00_138_0110)]
            Sevnica,

            /// <summary>
            /// Sežana
            /// </summary>
            [AliasInShort("111")]
            [RegionCode(2_00_138_0111)]
            Sežana,

            /// <summary>
            /// Slovenj Gradec
            /// </summary>
            [AliasInShort("112")]
            [RegionCode(2_00_138_0112)]
            SlovenjGradec,

            /// <summary>
            /// Slovenska Bistrica
            /// </summary>
            [AliasInShort("113")]
            [RegionCode(2_00_138_0113)]
            SlovenskaBistrica,

            /// <summary>
            /// Slovenske Konjice
            /// </summary>
            [AliasInShort("114")]
            [RegionCode(2_00_138_0114)]
            SlovenskeKonjice,

            /// <summary>
            /// Starše
            /// </summary>
            [AliasInShort("115")]
            [RegionCode(2_00_138_0115)]
            Starše,

            /// <summary>
            /// Sveti Jurij
            /// </summary>
            [AliasInShort("116")]
            [RegionCode(2_00_138_0116)]
            SvetiJurij,

            /// <summary>
            /// Šenčur
            /// </summary>
            [AliasInShort("117")]
            [RegionCode(2_00_138_0117)]
            Šenčur,

            /// <summary>
            /// Šentilj
            /// </summary>
            [AliasInShort("118")]
            [RegionCode(2_00_138_0118)]
            Šentilj,

            /// <summary>
            /// Šentjernej
            /// </summary>
            [AliasInShort("119")]
            [RegionCode(2_00_138_0119)]
            Šentjernej,

            /// <summary>
            /// Šentjur
            /// </summary>
            [AliasInShort("120")]
            [RegionCode(2_00_138_0120)]
            Šentjur,

            /// <summary>
            /// Škocjan
            /// </summary>
            [AliasInShort("121")]
            [RegionCode(2_00_138_0121)]
            Škocjan,

            /// <summary>
            /// Škofja Loka
            /// </summary>
            [AliasInShort("122")]
            [RegionCode(2_00_138_0122)]
            ŠkofjaLoka,

            /// <summary>
            /// Škofljica
            /// </summary>
            [AliasInShort("123")]
            [RegionCode(2_00_138_0123)]
            Škofljica,

            /// <summary>
            /// Šmarje pri Jelšah
            /// </summary>
            [AliasInShort("124")]
            [RegionCode(2_00_138_0124)]
            ŠmarjePriJelšah,

            /// <summary>
            /// Šmartno ob Paki
            /// </summary>
            [AliasInShort("125")]
            [RegionCode(2_00_138_0125)]
            ŠmartnoObPaki,

            /// <summary>
            /// Šoštanj
            /// </summary>
            [AliasInShort("126")]
            [RegionCode(2_00_138_0126)]
            Šoštanj,

            /// <summary>
            /// Štore
            /// </summary>
            [AliasInShort("127")]
            [RegionCode(2_00_138_0127)]
            Štore,

            /// <summary>
            /// Tolmin
            /// </summary>
            [AliasInShort("128")]
            [RegionCode(2_00_138_0128)]
            Tolmin,

            /// <summary>
            /// Trbovlje
            /// </summary>
            [AliasInShort("129")]
            [RegionCode(2_00_138_0129)]
            Trbovlje,

            /// <summary>
            /// Trebnje
            /// </summary>
            [AliasInShort("130")]
            [RegionCode(2_00_138_0130)]
            Trebnje,

            /// <summary>
            /// Tržič
            /// </summary>
            [AliasInShort("131")]
            [RegionCode(2_00_138_0131)]
            Tržič,

            /// <summary>
            /// Turnišče
            /// </summary>
            [AliasInShort("132")]
            [RegionCode(2_00_138_0132)]
            Turnišče,

            /// <summary>
            /// Velenje
            /// </summary>
            [AliasInShort("133")]
            [RegionCode(2_00_138_0133)]
            Velenje,

            /// <summary>
            /// Velike Lašče
            /// </summary>
            [AliasInShort("134")]
            [RegionCode(2_00_138_0134)]
            VelikeLašče,

            /// <summary>
            /// Videm
            /// </summary>
            [AliasInShort("135")]
            [RegionCode(2_00_138_0135)]
            Videm,

            /// <summary>
            /// Vipava
            /// </summary>
            [AliasInShort("136")]
            [RegionCode(2_00_138_0136)]
            Vipava,

            /// <summary>
            /// Vitanje
            /// </summary>
            [AliasInShort("137")]
            [RegionCode(2_00_138_0137)]
            Vitanje,

            /// <summary>
            /// Vodice
            /// </summary>
            [AliasInShort("138")]
            [RegionCode(2_00_138_0138)]
            Vodice,

            /// <summary>
            /// Vojnik
            /// </summary>
            [AliasInShort("139")]
            [RegionCode(2_00_138_0139)]
            Vojnik,

            /// <summary>
            /// Vrhnika
            /// </summary>
            [AliasInShort("140")]
            [RegionCode(2_00_138_0140)]
            Vrhnika,

            /// <summary>
            /// Vuzenica
            /// </summary>
            [AliasInShort("141")]
            [RegionCode(2_00_138_0141)]
            Vuzenica,

            /// <summary>
            /// Zagorje ob Savi
            /// </summary>
            [AliasInShort("142")]
            [RegionCode(2_00_138_0143)]
            ZagorjeObSavi,

            /// <summary>
            /// Zavrč
            /// </summary>
            [AliasInShort("143")]
            [RegionCode(2_00_138_0144)]
            Zavrč,

            /// <summary>
            /// Zreče
            /// </summary>
            [AliasInShort("144")]
            [RegionCode(2_00_138_0145)]
            Zreče,

            /// <summary>
            /// Železniki
            /// </summary>
            [AliasInShort("146")]
            [RegionCode(2_00_138_0146)]
            Železniki,

            /// <summary>
            /// Žiri
            /// </summary>
            [AliasInShort("147")]
            [RegionCode(2_00_138_0147)]
            Žiri,

            /// <summary>
            /// Benedikt
            /// </summary>
            [AliasInShort("148")]
            [RegionCode(2_00_138_0148)]
            Benedikt,

            /// <summary>
            /// Bistrica ob Sotli
            /// </summary>
            [AliasInShort("149")]
            [RegionCode(2_00_138_0149)]
            BistricaObSotli,

            /// <summary>
            /// Bloke
            /// </summary>
            [AliasInShort("150")]
            [RegionCode(2_00_138_0150)]
            Bloke,

            /// <summary>
            /// Braslovče
            /// </summary>
            [AliasInShort("151")]
            [RegionCode(2_00_138_0151)]
            Braslovče,

            /// <summary>
            /// Cankova
            /// </summary>
            [AliasInShort("152")]
            [RegionCode(2_00_138_0152)]
            Cankova,

            /// <summary>
            /// Cerkvenjak
            /// </summary>
            [AliasInShort("153")]
            [RegionCode(2_00_138_0153)]
            Cerkvenjak,

            /// <summary>
            /// Dobje
            /// </summary>
            [AliasInShort("154")]
            [RegionCode(2_00_138_0154)]
            Dobje,

            /// <summary>
            /// Dobrna
            /// </summary>
            [AliasInShort("155")]
            [RegionCode(2_00_138_0155)]
            Dobrna,

            /// <summary>
            /// Dobrovnik
            /// </summary>
            [AliasInShort("156")]
            [RegionCode(2_00_138_0156)]
            Dobrovnik,

            /// <summary>
            /// Dolenjske Toplice
            /// </summary>
            [AliasInShort("157")]
            [RegionCode(2_00_138_0157)]
            DolenjskeToplice,

            /// <summary>
            /// Grad
            /// </summary>
            [AliasInShort("158")]
            [RegionCode(2_00_138_0158)]
            Grad,

            /// <summary>
            /// Hajdina
            /// </summary>
            [AliasInShort("159")]
            [RegionCode(2_00_138_0159)]
            Hajdina,

            /// <summary>
            /// Hoče–Slivnica
            /// </summary>
            [AliasInShort("160")]
            [RegionCode(2_00_138_0160)]
            HočeSlivnica,

            /// <summary>
            /// Hodoš
            /// </summary>
            [AliasInShort("161")]
            [RegionCode(2_00_138_0161)]
            Hodoš,

            /// <summary>
            /// Horjul
            /// </summary>
            [AliasInShort("162")]
            [RegionCode(2_00_138_0162)]
            Horjul,

            /// <summary>
            /// Jezersko
            /// </summary>
            [AliasInShort("163")]
            [RegionCode(2_00_138_0163)]
            Jezersko,

            /// <summary>
            /// Komenda
            /// </summary>
            [AliasInShort("164")]
            [RegionCode(2_00_138_0164)]
            Komenda,

            /// <summary>
            /// Kostel
            /// </summary>
            [AliasInShort("165")]
            [RegionCode(2_00_138_0165)]
            Kostel,

            /// <summary>
            /// Križevci
            /// </summary>
            [AliasInShort("166")]
            [RegionCode(2_00_138_0166)]
            Križevci,

            /// <summary>
            /// Lovrenc na Pohorju
            /// </summary>
            [AliasInShort("167")]
            [RegionCode(2_00_138_0167)]
            LovrencNaPohorju,

            /// <summary>
            /// Markovci
            /// </summary>
            [AliasInShort("168")]
            [RegionCode(2_00_138_0168)]
            Markovci,

            /// <summary>
            /// Miklavž na Dravskem Polju
            /// </summary>
            [AliasInShort("169")]
            [RegionCode(2_00_138_0169)]
            MiklavžNaDravskemPolju,

            /// <summary>
            /// Mirna Peč
            /// </summary>
            [AliasInShort("170")]
            [RegionCode(2_00_138_0170)]
            MirnaPeč,

            /// <summary>
            /// Oplotnica
            /// </summary>
            [AliasInShort("171")]
            [RegionCode(2_00_138_0171)]
            Oplotnica,

            /// <summary>
            /// Podlehnik
            /// </summary>
            [AliasInShort("172")]
            [RegionCode(2_00_138_0172)]
            Podlehnik,

            /// <summary>
            /// Polzela
            /// </summary>
            [AliasInShort("173")]
            [RegionCode(2_00_138_0173)]
            Polzela,

            /// <summary>
            /// Prebold
            /// </summary>
            [AliasInShort("174")]
            [RegionCode(2_00_138_0174)]
            Prebold,

            /// <summary>
            /// Prevalje
            /// </summary>
            [AliasInShort("175")]
            [RegionCode(2_00_138_0175)]
            Prevalje,

            /// <summary>
            /// Razkrižje
            /// </summary>
            [AliasInShort("176")]
            [RegionCode(2_00_138_0176)]
            Razkrižje,

            /// <summary>
            /// Ribnica na Pohorju
            /// </summary>
            [AliasInShort("177")]
            [RegionCode(2_00_138_0177)]
            RibnicaNaPohorju,

            /// <summary>
            /// Selnica ob Dravi
            /// </summary>
            [AliasInShort("178")]
            [RegionCode(2_00_138_0178)]
            SelnicaObDravi,

            /// <summary>
            /// Sodražica
            /// </summary>
            [AliasInShort("179")]
            [RegionCode(2_00_138_0179)]
            Sodražica,

            /// <summary>
            /// Solčava
            /// </summary>
            [AliasInShort("180")]
            [RegionCode(2_00_138_0180)]
            Solčava,

            /// <summary>
            /// Sveta Ana
            /// </summary>
            [AliasInShort("181")]
            [RegionCode(2_00_138_0181)]
            SvetaAna,

            /// <summary>
            /// Sveti Andraž v Slovenskih Goricah
            /// </summary>
            [AliasInShort("182")]
            [RegionCode(2_00_138_0182)]
            SvetiAndražVSlovenskihGoricah,

            /// <summary>
            /// Šempeter–Vrtojba
            /// </summary>
            [AliasInShort("183")]
            [RegionCode(2_00_138_0183)]
            ŠempeterVrtojba,

            /// <summary>
            /// Tabor
            /// </summary>
            [AliasInShort("184")]
            [RegionCode(2_00_138_0184)]
            Tabor,

            /// <summary>
            /// Trnovska Vas
            /// </summary>
            [AliasInShort("185")]
            [RegionCode(2_00_138_0185)]
            TrnovskaVas,

            /// <summary>
            /// Trzin
            /// </summary>
            [AliasInShort("186")]
            [RegionCode(2_00_138_0186)]
            Trzin,

            /// <summary>
            /// Velika Polana
            /// </summary>
            [AliasInShort("187")]
            [RegionCode(2_00_138_0187)]
            VelikaPolana,

            /// <summary>
            /// Veržej
            /// </summary>
            [AliasInShort("188")]
            [RegionCode(2_00_138_0188)]
            Veržej,

            /// <summary>
            /// Vransko
            /// </summary>
            [AliasInShort("189")]
            [RegionCode(2_00_138_0189)]
            Vransko,

            /// <summary>
            /// Žalec
            /// </summary>
            [AliasInShort("190")]
            [RegionCode(2_00_138_0190)]
            Žalec,

            /// <summary>
            /// Žetale
            /// </summary>
            [AliasInShort("191")]
            [RegionCode(2_00_138_0191)]
            Žetale,

            /// <summary>
            /// Žirovnica
            /// </summary>
            [AliasInShort("192")]
            [RegionCode(2_00_138_0192)]
            Žirovnica,

            /// <summary>
            /// Žužemberk
            /// </summary>
            [AliasInShort("193")]
            [RegionCode(2_00_138_0193)]
            Žužemberk,

            /// <summary>
            /// Šmartno pri Litiji
            /// </summary>
            [AliasInShort("194")]
            [RegionCode(2_00_138_0194)]
            ŠmartnoPriLitiji,

            /// <summary>
            /// Apače
            /// </summary>
            [AliasInShort("195")]
            [RegionCode(2_00_138_0195)]
            Apače,

            /// <summary>
            /// Cirkulane
            /// </summary>
            [AliasInShort("196")]
            [RegionCode(2_00_138_0196)]
            Cirkulane,

            /// <summary>
            /// Kostanjevica na Krki
            /// </summary>
            [AliasInShort("197")]
            [RegionCode(2_00_138_0197)]
            KostanjevicaNaKrki,

            /// <summary>
            /// Makole
            /// </summary>
            [AliasInShort("198")]
            [RegionCode(2_00_138_0198)]
            Makole,

            /// <summary>
            /// Mokronog–Trebelno
            /// </summary>
            [AliasInShort("199")]
            [RegionCode(2_00_138_0199)]
            MokronogTrebelno,

            /// <summary>
            /// Poljčane
            /// </summary>
            [AliasInShort("200")]
            [RegionCode(2_00_138_0200)]
            Poljčane,

            /// <summary>
            /// Renče–Vogrsko
            /// </summary>
            [AliasInShort("201")]
            [RegionCode(2_00_138_0201)]
            RenčeVogrsko,

            /// <summary>
            /// Središče ob Dravi
            /// </summary>
            [AliasInShort("202")]
            [RegionCode(2_00_138_0202)]
            SrediščeObDravi,

            /// <summary>
            /// Straža
            /// </summary>
            [AliasInShort("203")]
            [RegionCode(2_00_138_0203)]
            Straža,

            /// <summary>
            /// Sveta Trojica v Slovenskih Goricah
            /// </summary>
            [AliasInShort("204")]
            [RegionCode(2_00_138_0204)]
            SvetaTrojicaVSlovenskihGoricah,

            /// <summary>
            /// Sveti Tomaž
            /// </summary>
            [AliasInShort("205")]
            [RegionCode(2_00_138_0205)]
            SvetiTomaž,

            /// <summary>
            /// Šmarješke Toplice
            /// </summary>
            [AliasInShort("206")]
            [RegionCode(2_00_138_0206)]
            ŠmarješkeToplice,

            /// <summary>
            /// Gorje
            /// </summary>
            [AliasInShort("207")]
            [RegionCode(2_00_138_0270)]
            Gorje,

            /// <summary>
            /// Log–Dragomer
            /// </summary>
            [AliasInShort("208")]
            [RegionCode(2_00_138_0208)]
            LogDragomer,

            /// <summary>
            /// Rečica ob Savinji
            /// </summary>
            [AliasInShort("209")]
            [RegionCode(2_00_138_0209)]
            RečicaObSavinji,

            /// <summary>
            /// Sveti Jurij v Slovenskih Goricah
            /// </summary>
            [AliasInShort("210")]
            [RegionCode(2_00_138_0210)]
            SvetiJurijVSlovenskihGoricah,

            /// <summary>
            /// Šentrupert
            /// </summary>
            [AliasInShort("211")]
            [RegionCode(2_00_138_0211)]
            Šentrupert,

            /// <summary>
            /// Mirna
            /// </summary>
            [AliasInShort("212")]
            [RegionCode(2_00_138_0212)]
            Mirna,

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