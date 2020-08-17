using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// France Regions
    /// </summary>
    public static class FranceRegions
    {
        #region Gets regions

        /// <summary>
        /// Département et région d'outre-mer Mayotte
        /// </summary>
        public static EnumValues Mayotte => EnumValues.Mayotte;

        /// <summary>
        /// Département et région d'outre-mer Martinique
        /// </summary>
        public static EnumValues Martinique => EnumValues.Martinique;

        /// <summary>
        /// Département et région d'outre-mer Guadeloupe
        /// </summary>
        public static EnumValues Guadeloupe => EnumValues.Guadeloupe;

        /// <summary>
        /// Département et région d'outre-mer Guyane
        /// </summary>
        public static EnumValues Guiana => EnumValues.Guiana;

        /// <summary>
        /// Département et région d'outre-mer La Réunion
        /// </summary>
        public static EnumValues Réunion => EnumValues.Réunion;

        /// <summary>
        /// Saint Martin French Part
        /// </summary>
        public static EnumValues SaintMartin => EnumValues.SaintMartin;

        /// <summary>
        /// French Southern Territories
        /// </summary>
        public static EnumValues SouthernTerritories => EnumValues.SouthernTerritories;

        /// <summary>
        /// SaintBarts
        /// </summary>
        public static EnumValues SaintBarts => EnumValues.SaintBarts;

        /// <summary>
        /// Département Bas-Rhin
        /// </summary>
        public static EnumValues DépartementBasRhin => EnumValues.DépartementBasRhin;

        /// <summary>
        /// Département Haut-Rhin
        /// </summary>
        public static EnumValues DépartementHautRhin => EnumValues.DépartementHautRhin;

        /// <summary>
        /// Dordogne
        /// </summary>
        public static EnumValues Dordogne => EnumValues.Dordogne;

        /// <summary>
        /// Gironde
        /// </summary>
        public static EnumValues Gironde => EnumValues.Gironde;

        /// <summary>
        /// Landes
        /// </summary>
        public static EnumValues Landes => EnumValues.Landes;

        /// <summary>
        /// Lot-et-Garonne
        /// </summary>
        public static EnumValues LotEtGaronne => EnumValues.LotEtGaronne;

        /// <summary>
        /// Pyrénées-Atlantiques
        /// </summary>
        public static EnumValues PyrénéesAtlantiques => EnumValues.PyrénéesAtlantiques;

        /// <summary>
        /// Cantal
        /// </summary>
        public static EnumValues Cantal => EnumValues.Cantal;

        /// <summary>
        /// Haute-Loire
        /// </summary>
        public static EnumValues HauteLoire => EnumValues.HauteLoire;

        /// <summary>
        /// Puy-de-Dôme
        /// </summary>
        public static EnumValues PuyDeDôme => EnumValues.PuyDeDôme;

        /// <summary>
        /// Allier 
        /// </summary>
        public static EnumValues Allier => EnumValues.Allier;

        /// <summary>
        /// Côte-d’Or
        /// </summary>
        public static EnumValues CôtedOr => EnumValues.CôtedOr;

        /// <summary>
        /// Nièvre 
        /// </summary>
        public static EnumValues Nièvre => EnumValues.Nièvre;

        /// <summary>
        /// Saône-et-Loire
        /// </summary>
        public static EnumValues SaôneEtLoire => EnumValues.SaôneEtLoire;

        /// <summary>
        /// Yonne 
        /// </summary>
        public static EnumValues Yonne => EnumValues.Yonne;

        /// <summary>
        /// Côtes-d’Armor 
        /// </summary>
        public static EnumValues CôtesdArmor => EnumValues.CôtesdArmor;

        /// <summary>
        /// Finistère 
        /// </summary>
        public static EnumValues Finistère => EnumValues.Finistère;

        /// <summary>
        /// Ille-et-Vilaine
        /// </summary>
        public static EnumValues IlleEtVilaine => EnumValues.IlleEtVilaine;

        /// <summary>
        /// Morbihan 
        /// </summary>
        public static EnumValues Morbihan => EnumValues.Morbihan;

        /// <summary>
        /// Cher
        /// </summary>
        public static EnumValues Cher => EnumValues.Cher;

        /// <summary>
        /// Eure-et-Loir 
        /// </summary>
        public static EnumValues EureEtLoir => EnumValues.EureEtLoir;

        /// <summary>
        /// Indre 
        /// </summary>
        public static EnumValues Indre => EnumValues.Indre;

        /// <summary>
        /// Indre-et-Loire
        /// </summary>
        public static EnumValues IndreEtLoire => EnumValues.IndreEtLoire;

        /// <summary>
        /// Loir-et-Cher 
        /// </summary>
        public static EnumValues LoirEtCher => EnumValues.LoirEtCher;

        /// <summary>
        /// Loiret 
        /// </summary>
        public static EnumValues Loiret => EnumValues.Loiret;

        /// <summary>
        /// Aube
        /// </summary>
        public static EnumValues Aube => EnumValues.Aube;

        /// <summary>
        /// Marne 
        /// </summary>
        public static EnumValues Marne => EnumValues.Marne;

        /// <summary>
        /// Haute-Marne 
        /// </summary>
        public static EnumValues HauteMarne => EnumValues.HauteMarne;

        /// <summary>
        /// Ardennes
        /// </summary>
        public static EnumValues Ardennes => EnumValues.Ardennes;

        /// <summary>
        /// Corse-du-Sud
        /// </summary>
        public static EnumValues CorseDuSud => EnumValues.CorseDuSud;

        /// <summary>
        /// Haute-Corse
        /// </summary>
        public static EnumValues HauteCorse => EnumValues.HauteCorse;

        /// <summary>
        /// Doubs
        /// </summary>
        public static EnumValues Doubs => EnumValues.Doubs;


        /// <summary>
        /// Jura
        /// </summary>
        public static EnumValues Jura => EnumValues.Jura;

        /// <summary>
        /// Haute-Saône
        /// </summary>
        public static EnumValues HauteSaône => EnumValues.HauteSaône;

        /// <summary>
        /// Territoire de Belfort
        /// </summary>
        public static EnumValues TerritoireDeBelfort => EnumValues.TerritoireDeBelfort;

        /// <summary>
        /// Paris
        /// </summary>
        public static EnumValues Paris => EnumValues.Paris;

        /// <summary>
        /// Seine-et-Marne
        /// </summary>
        public static EnumValues SeineEtMarne => EnumValues.SeineEtMarne;

        /// <summary>
        /// Yvelines
        /// </summary>
        public static EnumValues Yvelines => EnumValues.Yvelines;

        /// <summary>
        /// Essonne
        /// </summary>
        public static EnumValues Essonne => EnumValues.Essonne;

        /// <summary>
        /// Hauts-de-Seine
        /// </summary>
        public static EnumValues HautsDeSeine => EnumValues.HautsDeSeine;

        /// <summary>
        /// Seine-Saint-Denis
        /// </summary>
        public static EnumValues SeineSaintDenis => EnumValues.SeineSaintDenis;

        /// <summary>
        /// Val-de-Marne
        /// </summary>
        public static EnumValues ValDeMarne => EnumValues.ValDeMarne;

        /// <summary>
        /// Val-d’Oise
        /// </summary>
        public static EnumValues ValdOise => EnumValues.ValdOise;

        /// <summary>
        /// Aude
        /// </summary>
        public static EnumValues Aude => EnumValues.Aude;

        /// <summary>
        /// Gard
        /// </summary>
        public static EnumValues Gard => EnumValues.Gard;

        /// <summary>
        /// Hérault
        /// </summary>
        public static EnumValues Hérault => EnumValues.Hérault;

        /// <summary>
        /// Lozère
        /// </summary>
        public static EnumValues Lozère => EnumValues.Lozère;

        /// <summary>
        /// Pyrénées-Orientales
        /// </summary>
        public static EnumValues PyrénéesOrientales => EnumValues.PyrénéesOrientales;

        /// <summary>
        /// Corrèze
        /// </summary>
        public static EnumValues Corrèze => EnumValues.Corrèze;

        /// <summary>
        /// Creuse
        /// </summary>
        public static EnumValues Creuse => EnumValues.Creuse;

        /// <summary>
        /// Haute-Vienne
        /// </summary>
        public static EnumValues HauteVienne => EnumValues.HauteVienne;

        /// <summary>
        /// Meurthe-et-Moselle
        /// </summary>
        public static EnumValues MeurtheEtMoselle => EnumValues.MeurtheEtMoselle;

        /// <summary>
        /// Meuse
        /// </summary>
        public static EnumValues Meuse => EnumValues.Meuse;

        /// <summary>
        /// Département Moselle
        /// </summary>
        public static EnumValues DépartementMoselle => EnumValues.DépartementMoselle;

        /// <summary>
        /// Vosges
        /// </summary>
        public static EnumValues Vosges => EnumValues.Vosges;

        /// <summary>
        /// Aveyron
        /// </summary>
        public static EnumValues Aveyron => EnumValues.Aveyron;

        /// <summary>
        /// Haute-Garonne
        /// </summary>
        public static EnumValues HauteGaronne => EnumValues.HauteGaronne;

        /// <summary>
        /// Gers
        /// </summary>
        public static EnumValues Gers => EnumValues.Gers;

        /// <summary>
        /// Lot
        /// </summary>
        public static EnumValues Lot => EnumValues.Lot;

        /// <summary>
        /// Hautes-Pyrénées
        /// </summary>
        public static EnumValues HautesPyrénées => EnumValues.HautesPyrénées;

        /// <summary>
        /// Tarn
        /// </summary>
        public static EnumValues Tarn => EnumValues.Tarn;

        /// <summary>
        /// Tarn-et-Garonne
        /// </summary>
        public static EnumValues TarnEtGaronne => EnumValues.TarnEtGaronne;

        /// <summary>
        /// Ariège
        /// </summary>
        public static EnumValues Ariège => EnumValues.Ariège;

        /// <summary>
        /// Nord
        /// </summary>
        public static EnumValues Nord => EnumValues.Nord;

        /// <summary>
        /// Pas-de-Calais
        /// </summary>
        public static EnumValues PasDeCalais => EnumValues.PasDeCalais;

        /// <summary>
        /// Calvados
        /// </summary>
        public static EnumValues Calvados => EnumValues.Calvados;

        /// <summary>
        /// Manche
        /// </summary>
        public static EnumValues Manche => EnumValues.Manche;

        /// <summary>
        /// Orne
        /// </summary>
        public static EnumValues Orne => EnumValues.Orne;

        /// <summary>
        /// Eure
        /// </summary>
        public static EnumValues Eure => EnumValues.Eure;

        /// <summary>
        /// Seine-Maritime
        /// </summary>
        public static EnumValues SeineMaritime => EnumValues.SeineMaritime;

        /// <summary>
        /// Loire-Atlantique
        /// </summary>
        public static EnumValues LoireAtlantique => EnumValues.LoireAtlantique;

        /// <summary>
        /// Maine-et-Loire
        /// </summary>
        public static EnumValues MaineEtLoire => EnumValues.MaineEtLoire;

        /// <summary>
        /// Mayenne
        /// </summary>
        public static EnumValues Mayenne => EnumValues.Mayenne;

        /// <summary>
        /// Sarthe
        /// </summary>
        public static EnumValues Sarthe => EnumValues.Sarthe;

        /// <summary>
        /// Vendée
        /// </summary>
        public static EnumValues Vendée => EnumValues.Vendée;

        /// <summary>
        /// Oise
        /// </summary>
        public static EnumValues Oise => EnumValues.Oise;

        /// <summary>
        /// Somme
        /// </summary>
        public static EnumValues Somme => EnumValues.Somme;

        /// <summary>
        /// Aisne
        /// </summary>
        public static EnumValues Aisne => EnumValues.Aisne;

        /// <summary>
        /// Charente
        /// </summary>
        public static EnumValues Charente => EnumValues.Charente;

        /// <summary>
        /// Charente-Maritime
        /// </summary>
        public static EnumValues CharenteMaritime => EnumValues.CharenteMaritime;

        /// <summary>
        /// Deux-Sèvres
        /// </summary>
        public static EnumValues DeuxSèvres => EnumValues.DeuxSèvres;

        /// <summary>
        /// Vienne
        /// </summary>
        public static EnumValues Vienne => EnumValues.Vienne;

        /// <summary>
        /// Bouches-du-Rhône
        /// </summary>
        public static EnumValues BouchesDuRhône => EnumValues.BouchesDuRhône;

        /// <summary>
        /// Var
        /// </summary>
        public static EnumValues Var => EnumValues.Var;

        /// <summary>
        /// Vaucluse
        /// </summary>
        public static EnumValues Vaucluse => EnumValues.Vaucluse;

        /// <summary>
        /// Alpes-de-Haute-Provence
        /// </summary>
        public static EnumValues AlpesDeHauteProvence => EnumValues.AlpesDeHauteProvence;

        /// <summary>
        /// Hautes-Alpes
        /// </summary>
        public static EnumValues HautesAlpes => EnumValues.HautesAlpes;

        /// <summary>
        /// Alpes-Maritimes
        /// </summary>
        public static EnumValues AlpesMaritimes => EnumValues.AlpesMaritimes;

        /// <summary>
        /// Drôme
        /// </summary>
        public static EnumValues Drôme => EnumValues.Drôme;

        /// <summary>
        /// Isère
        /// </summary>
        public static EnumValues Isère => EnumValues.Isère;

        /// <summary>
        /// Loire
        /// </summary>
        public static EnumValues Loire => EnumValues.Loire;

        /// <summary>
        /// Rhône
        /// </summary>
        public static EnumValues Rhône => EnumValues.Rhône;

        /// <summary>
        /// Savoie
        /// </summary>
        public static EnumValues Savoie => EnumValues.Savoie;

        /// <summary>
        /// Haute-Savoie
        /// </summary>
        public static EnumValues HauteSavoie => EnumValues.HauteSavoie;

        /// <summary>
        /// Ain
        /// </summary>
        public static EnumValues Ain => EnumValues.Ain;

        /// <summary>
        /// Ardèche
        /// </summary>
        public static EnumValues Ardèche => EnumValues.Ardèche;

        #endregion

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

            /// <summary>
            /// SaintMartinFrenchPart
            /// </summary>
            // ReSharper disable once MemberHidesStaticFromOuterClass
            public static Country SaintMartin => Country.SaintMartinFrenchPart;

            /// <summary>
            /// SaintMartinFrenchPart
            /// </summary>
            public static CountryCode SaintMartinCode => CountryCode.MF;
        }

        /// <summary>
        /// Enum values for France regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Département et région d'outre-mer Mayotte
            /// </summary>
            [AliasInShort("YT")] [RegionCode(2_00_001_1001)] [RegionFlag("overseas")]
            Mayotte,

            /// <summary>
            /// Département et région d'outre-mer Martinique
            /// </summary>
            [AliasInShort("MQ")] [RegionCode(2_00_001_1002)] [RegionFlag("overseas")]
            Martinique,

            /// <summary>
            /// Département et région d'outre-mer Guadeloupe
            /// </summary>
            [AliasInShort("GP")] [RegionCode(2_00_001_1003)] [RegionFlag("overseas")]
            Guadeloupe,

            /// <summary>
            /// Département et région d'outre-mer Guyane
            /// </summary>
            [AliasInShort("GF")] [RegionCode(2_00_001_1004)] [RegionFlag("overseas")]
            Guiana,

            /// <summary>
            /// Département et région d'outre-mer La Réunion
            /// </summary>
            [AliasInShort("RE")] [RegionCode(2_00_001_1005)] [RegionFlag("overseas")]
            Réunion,

            /// <summary>
            /// Saint Martin French Part
            /// </summary>
            [AliasInShort("MF")] [RegionCode(2_00_001_1006)] [RegionFlag("overseas")]
            SaintMartin,

            /// <summary>
            /// French Southern Territories
            /// </summary>
            [AliasInShort("TF")] [RegionCode(2_00_001_1007)] [RegionFlag("overseas")]
            SouthernTerritories,

            /// <summary>
            /// SaintBarts
            /// </summary>
            [AliasInShort("BL")] [RegionCode(2_00_001_1008)] [RegionFlag("overseas")]
            SaintBarts,

            /// <summary>
            /// Département Bas-Rhin
            /// </summary>
            [AliasInShort("67")] [RegionCode(2_00_001_0067)] [RegionFlag("main")]
            DépartementBasRhin,

            /// <summary>
            /// Département Haut-Rhin
            /// </summary>
            [AliasInShort("68")] [RegionCode(2_00_001_0068)] [RegionFlag("main")]
            DépartementHautRhin,

            /// <summary>
            /// Dordogne
            /// </summary>
            [AliasInShort("24")] [RegionCode(2_00_001_0024)] [RegionFlag("main")]
            Dordogne,

            /// <summary>
            /// Gironde
            /// </summary>
            [AliasInShort("33")] [RegionCode(2_00_001_0033)] [RegionFlag("main")]
            Gironde,

            /// <summary>
            /// Landes
            /// </summary>
            [AliasInShort("40")] [RegionCode(2_00_001_0040)] [RegionFlag("main")]
            Landes,

            /// <summary>
            /// Lot-et-Garonne
            /// </summary>
            [AliasInShort("47")] [RegionCode(2_00_001_0047)] [RegionFlag("main")]
            LotEtGaronne,

            /// <summary>
            /// Pyrénées-Atlantiques
            /// </summary>
            [AliasInShort("64")] [RegionCode(2_00_001_0064)] [RegionFlag("main")]
            PyrénéesAtlantiques,

            /// <summary>
            /// Cantal
            /// </summary>
            [AliasInShort("15")] [RegionCode(2_00_001_0015)] [RegionFlag("main")]
            Cantal,

            /// <summary>
            /// Haute-Loire
            /// </summary>
            [AliasInShort("43")] [RegionCode(2_00_001_0043)] [RegionFlag("main")]
            HauteLoire,

            /// <summary>
            /// Puy-de-Dôme
            /// </summary>
            [AliasInShort("63")] [RegionCode(2_00_001_0063)] [RegionFlag("main")]
            PuyDeDôme,

            /// <summary>
            /// Allier
            /// </summary>
            [AliasInShort("03")] [RegionCode(2_00_001_0003)] [RegionFlag("main")]
            Allier,

            /// <summary>
            /// Côte-d’Or
            /// </summary>
            [AliasInShort("21")] [RegionCode(2_00_001_0021)] [RegionFlag("main")]
            CôtedOr,

            /// <summary>
            /// Nièvre
            /// </summary>
            [AliasInShort("58")] [RegionCode(2_00_001_0058)] [RegionFlag("main")]
            Nièvre,

            /// <summary>
            /// Saône-et-Loire
            /// </summary>
            [AliasInShort("71")] [RegionCode(2_00_001_0071)] [RegionFlag("main")]
            SaôneEtLoire,

            /// <summary>
            /// Yonne
            /// </summary>
            [AliasInShort("89")] [RegionCode(2_00_001_0089)] [RegionFlag("main")]
            Yonne,

            /// <summary>
            /// Côtes-d’Armor
            /// </summary>
            [AliasInShort("22")] [RegionCode(2_00_001_0022)] [RegionFlag("main")]
            CôtesdArmor,

            /// <summary>
            /// Finistère
            /// </summary>
            [AliasInShort("29")] [RegionCode(2_00_001_0029)] [RegionFlag("main")]
            Finistère,

            /// <summary>
            /// Ille-et-Vilaine
            /// </summary>
            [AliasInShort("35")] [RegionCode(2_00_001_0035)] [RegionFlag("main")]
            IlleEtVilaine,

            /// <summary>
            /// Morbihan
            /// </summary>
            [AliasInShort("56")] [RegionCode(2_00_001_0056)] [RegionFlag("main")]
            Morbihan,

            /// <summary>
            /// Cher
            /// </summary>
            [AliasInShort("18")] [RegionCode(2_00_001_0018)] [RegionFlag("main")]
            Cher,

            /// <summary>
            /// Eure-et-Loir
            /// </summary>
            [AliasInShort("28")] [RegionCode(2_00_001_0028)] [RegionFlag("main")]
            EureEtLoir,

            /// <summary>
            /// Indre
            /// </summary>
            [AliasInShort("36")] [RegionCode(2_00_001_0036)] [RegionFlag("main")]
            Indre,

            /// <summary>
            /// Indre-et-Loire
            /// </summary>
            [AliasInShort("37")] [RegionCode(2_00_001_0037)] [RegionFlag("main")]
            IndreEtLoire,

            /// <summary>
            /// Loir-et-Cher
            /// </summary>
            [AliasInShort("41")] [RegionCode(2_00_001_0041)] [RegionFlag("main")]
            LoirEtCher,

            /// <summary>
            /// Loiret
            /// </summary>
            [AliasInShort("45")] [RegionCode(2_00_001_0045)] [RegionFlag("main")]
            Loiret,

            /// <summary>
            /// Aube
            /// </summary>
            [AliasInShort("10")] [RegionCode(2_00_001_0010)] [RegionFlag("main")]
            Aube,

            /// <summary>
            /// Marne
            /// </summary>
            [AliasInShort("51")] [RegionCode(2_00_001_0051)] [RegionFlag("main")]
            Marne,

            /// <summary>
            /// Haute-Marne
            /// </summary>
            [AliasInShort("52")] [RegionCode(2_00_001_0052)] [RegionFlag("main")]
            HauteMarne,

            /// <summary>
            /// Ardennes
            /// </summary>
            [AliasInShort("08")] [RegionCode(2_00_001_0008)] [RegionFlag("main")]
            Ardennes,

            /// <summary>
            /// Corse-du-Sud
            /// </summary>
            [AliasInShort("2A")] [RegionCode(2_00_001_1021)] [RegionFlag("main")]
            CorseDuSud,

            /// <summary>
            /// Haute-Corse
            /// </summary>
            [AliasInShort("2B")] [RegionCode(2_00_001_1022)] [RegionFlag("main")]
            HauteCorse,

            /// <summary>
            /// Doubs
            /// </summary>
            [AliasInShort("25")] [RegionCode(2_00_001_0025)] [RegionFlag("main")]
            Doubs,

            /// <summary>
            /// Jura
            /// </summary>
            [AliasInShort("39")] [RegionCode(2_00_001_0039)] [RegionFlag("main")]
            Jura,

            /// <summary>
            /// Haute-Saône
            /// </summary>
            [AliasInShort("70")] [RegionCode(2_00_001_0070)] [RegionFlag("main")]
            HauteSaône,

            /// <summary>
            /// Territoire de Belfort
            /// </summary>
            [AliasInShort("90")] [RegionCode(2_00_001_0090)] [RegionFlag("main")]
            TerritoireDeBelfort,

            /// <summary>
            /// Paris
            /// </summary>
            [AliasInShort("75")] [RegionCode(2_00_001_0075)] [RegionFlag("main")]
            Paris,

            /// <summary>
            /// Seine-et-Marne
            /// </summary>
            [AliasInShort("77")] [RegionCode(2_00_001_0077)] [RegionFlag("main")]
            SeineEtMarne,

            /// <summary>
            /// Yvelines
            /// </summary>
            [AliasInShort("78")] [RegionCode(2_00_001_0078)] [RegionFlag("main")]
            Yvelines,

            /// <summary>
            /// Essonne
            /// </summary>
            [AliasInShort("91")] [RegionCode(2_00_001_0091)] [RegionFlag("main")]
            Essonne,

            /// <summary>
            /// Hauts-de-Seine
            /// </summary>
            [AliasInShort("92")] [RegionCode(2_00_001_0092)] [RegionFlag("main")]
            HautsDeSeine,

            /// <summary>
            /// Seine-Saint-Denis
            /// </summary>
            [AliasInShort("93")] [RegionCode(2_00_001_0093)] [RegionFlag("main")]
            SeineSaintDenis,

            /// <summary>
            /// Val-de-Marne
            /// </summary>
            [AliasInShort("94")] [RegionCode(2_00_001_0094)] [RegionFlag("main")]
            ValDeMarne,

            /// <summary>
            /// Val-d’Oise
            /// </summary>
            [AliasInShort("95")] [RegionCode(2_00_001_0095)] [RegionFlag("main")]
            ValdOise,

            /// <summary>
            /// Aude
            /// </summary>
            [AliasInShort("11")] [RegionCode(2_00_001_0001)] [RegionFlag("main")]
            Aude,

            /// <summary>
            /// Gard
            /// </summary>
            [AliasInShort("30")] [RegionCode(2_00_001_0030)] [RegionFlag("main")]
            Gard,

            /// <summary>
            /// Hérault
            /// </summary>
            [AliasInShort("34")] [RegionCode(2_00_001_0034)] [RegionFlag("main")]
            Hérault,

            /// <summary>
            /// Lozère
            /// </summary>
            [AliasInShort("48")] [RegionCode(2_00_001_0048)] [RegionFlag("main")]
            Lozère,

            /// <summary>
            /// Pyrénées-Orientales
            /// </summary>
            [AliasInShort("66")] [RegionCode(2_00_001_0066)] [RegionFlag("main")]
            PyrénéesOrientales,

            /// <summary>
            /// Corrèze
            /// </summary>
            [AliasInShort("19")] [RegionCode(2_00_001_0019)] [RegionFlag("main")]
            Corrèze,

            /// <summary>
            /// Creuse
            /// </summary>
            [AliasInShort("23")] [RegionCode(2_00_001_0023)] [RegionFlag("main")]
            Creuse,

            /// <summary>
            /// Haute-Vienne
            /// </summary>
            [AliasInShort("87")] [RegionCode(2_00_001_0087)] [RegionFlag("main")]
            HauteVienne,

            /// <summary>
            /// Meurthe-et-Moselle
            /// </summary>
            [AliasInShort("54")] [RegionCode(2_00_001_0054)] [RegionFlag("main")]
            MeurtheEtMoselle,

            /// <summary>
            /// Meuse
            /// </summary>
            [AliasInShort("55")] [RegionCode(2_00_001_0055)] [RegionFlag("main")]
            Meuse,

            /// <summary>
            /// Département Moselle
            /// </summary>
            [AliasInShort("57")] [RegionCode(2_00_001_0057)] [RegionFlag("main")]
            DépartementMoselle,

            /// <summary>
            /// Vosges
            /// </summary>
            [AliasInShort("88")] [RegionCode(2_00_001_0088)] [RegionFlag("main")]
            Vosges,

            /// <summary>
            /// Aveyron
            /// </summary>
            [AliasInShort("12")] [RegionCode(2_00_001_0012)] [RegionFlag("main")]
            Aveyron,

            /// <summary>
            /// Haute-Garonne
            /// </summary>
            [AliasInShort("31")] [RegionCode(2_00_001_0031)] [RegionFlag("main")]
            HauteGaronne,

            /// <summary>
            /// Gers
            /// </summary>
            [AliasInShort("32")] [RegionCode(2_00_001_0032)] [RegionFlag("main")]
            Gers,

            /// <summary>
            /// Lot
            /// </summary>
            [AliasInShort("46")] [RegionCode(2_00_001_0046)] [RegionFlag("main")]
            Lot,

            /// <summary>
            /// Hautes-Pyrénées
            /// </summary>
            [AliasInShort("65")] [RegionCode(2_00_001_0065)] [RegionFlag("main")]
            HautesPyrénées,

            /// <summary>
            /// Tarn
            /// </summary>
            [AliasInShort("81")] [RegionCode(2_00_001_0081)] [RegionFlag("main")]
            Tarn,

            /// <summary>
            /// Tarn-et-Garonne
            /// </summary>
            [AliasInShort("82")] [RegionCode(2_00_001_0082)] [RegionFlag("main")]
            TarnEtGaronne,

            /// <summary>
            /// Ariège
            /// </summary>
            [AliasInShort("09")] [RegionCode(2_00_001_0009)] [RegionFlag("main")]
            Ariège,

            /// <summary>
            /// Nord
            /// </summary>
            [AliasInShort("59")] [RegionCode(2_00_001_0059)] [RegionFlag("main")]
            Nord,

            /// <summary>
            /// Pas-de-Calais
            /// </summary>
            [AliasInShort("62")] [RegionCode(2_00_001_0062)] [RegionFlag("main")]
            PasDeCalais,

            /// <summary>
            /// Calvados
            /// </summary>
            [AliasInShort("14")] [RegionCode(2_00_001_0014)] [RegionFlag("main")]
            Calvados,

            /// <summary>
            /// Manche
            /// </summary>
            [AliasInShort("50")] [RegionCode(2_00_001_0050)] [RegionFlag("main")]
            Manche,

            /// <summary>
            /// Orne
            /// </summary>
            [AliasInShort("61")] [RegionCode(2_00_001_0061)] [RegionFlag("main")]
            Orne,

            /// <summary>
            /// Eure
            /// </summary>
            [AliasInShort("27")] [RegionCode(2_00_001_0027)] [RegionFlag("main")]
            Eure,

            /// <summary>
            /// Seine-Maritime
            /// </summary>
            [AliasInShort("76")] [RegionCode(2_00_001_0076)] [RegionFlag("main")]
            SeineMaritime,

            /// <summary>
            /// Loire-Atlantique
            /// </summary>
            [AliasInShort("44")] [RegionCode(2_00_001_0044)] [RegionFlag("main")]
            LoireAtlantique,

            /// <summary>
            /// Maine-et-Loire
            /// </summary>
            [AliasInShort("49")] [RegionCode(2_00_001_0049)] [RegionFlag("main")]
            MaineEtLoire,

            /// <summary>
            /// Mayenne
            /// </summary>
            [AliasInShort("53")] [RegionCode(2_00_001_0053)] [RegionFlag("main")]
            Mayenne,

            /// <summary>
            /// Sarthe
            /// </summary>
            [AliasInShort("72")] [RegionCode(2_00_001_0072)] [RegionFlag("main")]
            Sarthe,

            /// <summary>
            /// Vendée
            /// </summary>
            [AliasInShort("85")] [RegionCode(2_00_001_0085)] [RegionFlag("main")]
            Vendée,

            /// <summary>
            /// Oise
            /// </summary>
            [AliasInShort("60")] [RegionCode(2_00_001_0060)] [RegionFlag("main")]
            Oise,

            /// <summary>
            /// Somme
            /// </summary>
            [AliasInShort("80")] [RegionCode(2_00_001_0080)] [RegionFlag("main")]
            Somme,

            /// <summary>
            /// Aisne
            /// </summary>
            [AliasInShort("02")] [RegionCode(2_00_001_0002)] [RegionFlag("main")]
            Aisne,

            /// <summary>
            /// Charente
            /// </summary>
            [AliasInShort("16")] [RegionCode(2_00_001_0016)] [RegionFlag("main")]
            Charente,

            /// <summary>
            /// Charente-Maritime
            /// </summary>
            [AliasInShort("17")] [RegionCode(2_00_001_0017)] [RegionFlag("main")]
            CharenteMaritime,

            /// <summary>
            /// Deux-Sèvres
            /// </summary>
            [AliasInShort("79")] [RegionCode(2_00_001_0079)] [RegionFlag("main")]
            DeuxSèvres,

            /// <summary>
            /// Vienne
            /// </summary>
            [AliasInShort("86")] [RegionCode(2_00_001_0086)] [RegionFlag("main")]
            Vienne,

            /// <summary>
            /// Bouches-du-Rhône
            /// </summary>
            [AliasInShort("13")] [RegionCode(2_00_001_0013)] [RegionFlag("main")]
            BouchesDuRhône,

            /// <summary>
            /// Var
            /// </summary>
            [AliasInShort("83")] [RegionCode(2_00_001_0083)] [RegionFlag("main")]
            Var,

            /// <summary>
            /// Vaucluse
            /// </summary>
            [AliasInShort("84")] [RegionCode(2_00_001_0084)] [RegionFlag("main")]
            Vaucluse,

            /// <summary>
            /// Alpes-de-Haute-Provence
            /// </summary>
            [AliasInShort("04")] [RegionCode(2_00_001_0004)] [RegionFlag("main")]
            AlpesDeHauteProvence,

            /// <summary>
            /// Hautes-Alpes
            /// </summary>
            [AliasInShort("05")] [RegionCode(2_00_001_0005)] [RegionFlag("main")]
            HautesAlpes,

            /// <summary>
            /// Alpes-Maritimes
            /// </summary>
            [AliasInShort("06")] [RegionCode(2_00_001_0006)] [RegionFlag("main")]
            AlpesMaritimes,

            /// <summary>
            /// Drôme
            /// </summary>
            [AliasInShort("26")] [RegionCode(2_00_001_0026)] [RegionFlag("main")]
            Drôme,

            /// <summary>
            /// Isère
            /// </summary>
            [AliasInShort("38")] [RegionCode(2_00_001_0038)] [RegionFlag("main")]
            Isère,

            /// <summary>
            /// Loire
            /// </summary>
            [AliasInShort("42")] [RegionCode(2_00_001_0042)] [RegionFlag("main")]
            Loire,

            /// <summary>
            /// Rhône
            /// </summary>
            [AliasInShort("69")] [RegionCode(2_00_001_0069)] [RegionFlag("main")]
            Rhône,

            /// <summary>
            /// Savoie
            /// </summary>
            [AliasInShort("73")] [RegionCode(2_00_001_0073)] [RegionFlag("main")]
            Savoie,

            /// <summary>
            /// Haute-Savoie
            /// </summary>
            [AliasInShort("74")] [RegionCode(2_00_001_0074)] [RegionFlag("main")]
            HauteSavoie,

            /// <summary>
            /// Ain
            /// </summary>
            [AliasInShort("01")] [RegionCode(2_00_001_0001)] [RegionFlag("main")]
            Ain,

            /// <summary>
            /// Ardèche
            /// </summary>
            [AliasInShort("07")] [RegionCode(2_00_001_0007)] [RegionFlag("main")]
            Ardèche,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="FranceRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="FranceRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"FR-{values.ToRegionCode()}";
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
            switch (value)
            {
                case EnumValues.Mayotte:
                    return Country.Mayotte;
                case EnumValues.Martinique:
                    return Country.Martinique;
                case EnumValues.Guadeloupe:
                    return Country.Guadeloupe;
                case EnumValues.Guiana:
                    return Country.Guiana;
                case EnumValues.Réunion:
                    return Country.Réunion;
                case EnumValues.SaintMartin:
                    return Country.SaintMartinFrenchPart;
                case EnumValues.SouthernTerritories:
                    return Country.FrenchSouthernTerritories;
                case EnumValues.SaintBarts:
                    return Country.SaintBarts;
                default:
                    return Country.France;
            }
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            switch (value)
            {
                case EnumValues.Mayotte:
                    return CountryCode.YT;
                case EnumValues.Martinique:
                    return CountryCode.MQ;
                case EnumValues.Guadeloupe:
                    return CountryCode.GP;
                case EnumValues.Guiana:
                    return CountryCode.GF;
                case EnumValues.Réunion:
                    return CountryCode.RE;
                case EnumValues.SaintMartin:
                    return CountryCode.MF;
                case EnumValues.SouthernTerritories:
                    return CountryCode.TF;
                case EnumValues.SaintBarts:
                    return CountryCode.BL;
                default:
                    return CountryCode.FR;
            }
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Convert from special regions of France
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(Country country)
        {
            switch (country)
            {
                case Country.Mayotte:
                    return EnumValues.Mayotte;
                case Country.Martinique:
                    return EnumValues.Martinique;
                case Country.Guadeloupe:
                    return EnumValues.Guadeloupe;
                case Country.Guiana:
                    return EnumValues.Guiana;
                case Country.Réunion:
                    return EnumValues.Réunion;
                case Country.SaintMartinFrenchPart:
                    return EnumValues.SaintMartin;
                case Country.FrenchSouthernTerritories:
                    return EnumValues.SouthernTerritories;
                case Country.SaintBarts:
                    return EnumValues.SaintBarts;
                default:
                    return EnumValues.Unknown;
            }
        }

        /// <summary>
        /// Convert from special regions of France
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EnumValues FromSpecialRegions(CountryCode code)
        {
            switch (code)
            {
                case CountryCode.YT:
                    return EnumValues.Mayotte;
                case CountryCode.MQ:
                    return EnumValues.Martinique;
                case CountryCode.GP:
                    return EnumValues.Guadeloupe;
                case CountryCode.GF:
                    return EnumValues.Guiana;
                case CountryCode.RE:
                    return EnumValues.Réunion;
                case CountryCode.MF:
                    return EnumValues.SaintMartin;
                case CountryCode.TF:
                    return EnumValues.SouthernTerritories;
                case CountryCode.BL:
                    return EnumValues.SaintBarts;
                default:
                    return EnumValues.Unknown;
            }
        }

        #endregion

        #region Getters

        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(member => !member.HasAttr<EnumValues, IgnoreRegionAttribute>());

        private static IEnumerable<EnumMember<EnumValues>> Filter(string flag) =>
            InternalEnumMembersCache.Where(x => x.Attributes.GetAll<RegionFlagAttribute>().Any(attr => attr.Flag == flag));

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// 获得本土地区的地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMainRegionCodes()
            => Filter("mainland").Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// 获得海外地区的地区代号
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetOverseasRegionCodes()
            => Filter("overseas").Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// Get all numeric region code(CEP-1 / Cosmos Region Code).
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetAllNumericRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToNumericRegionCode());

        #endregion
    }
}