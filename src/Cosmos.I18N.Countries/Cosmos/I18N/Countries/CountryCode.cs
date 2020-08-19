// ReSharper disable once CheckNamespace
// ReSharper disable InconsistentNaming

using System;
using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries
{
    /// <summary>
    /// 国家和地区编号
    /// Country And Regions Code (ISO 3166-1 ALPHA-2)
    /// https://www.nationsonline.org/oneworld/country_code_list.htm
    /// </summary>
    public enum CountryCode : long
    {
        /// <summary>
        /// 安道尔（Andorra，欧洲，AD，AND，020），安道尔共和国 <br />
        /// Cosmos i18n code: i18n_country_andaoer <br />
        /// Cosmos region code: 200103
        /// </summary>
        [RegionCode(200103)] [I18NIdentityCode(Europe.Andorra.I18N_IDENTITY_CODE)]
        AD,

        /// <summary>
        /// 阿联酋（United Arab Emirates，亚洲，AE，ARE，784），阿拉伯联合酋长国 <br />
        /// 又名 阿拉伯联合大公国 <br />
        /// Cosmos i18n code: i18n_country_alianqiu <br />
        /// Cosmos region code: 100140
        /// </summary>
        [RegionCode(100140)] [I18NIdentityCode(Asia.UnitedArabEmirates.I18N_IDENTITY_CODE)]
        AE,

        /// <summary>
        /// 阿富汗（Afghanistan，亚洲，AF，AFG，004），阿富汗伊斯兰国 <br />
        /// Cosmos i18n code: i18n_country_afuhan <br />
        /// Cosmos region code: 100101
        /// </summary>
        [RegionCode(100101)] [I18NIdentityCode(Asia.Afghanistan.I18N_IDENTITY_CODE)]
        AF,

        /// <summary>
        /// 安提瓜和巴布达（Antigua and Barbuda，北美洲，AG，ATG，028） <br />
        /// Cosmos i18n code: i18n_country_andaguababuda <br />
        /// Cosmos region code: 400103
        /// </summary>
        [RegionCode(400103)] [I18NIdentityCode(NorthAmerica.AntiguaAndBarbuda.I18N_IDENTITY_CODE)]
        AG,

        /// <summary>
        /// 安圭拉（Anguilla，北美洲，AI，AIA，660），英国海外领土 <br />
        /// Cosmos i18n code: i18n_country_anguila <br />
        /// Cosmos region code: 400102
        /// </summary>
        [RegionCode(400102)] [I18NIdentityCode(NorthAmerica.Anguilla.I18N_IDENTITY_CODE)]
        AI,

        /// <summary>
        /// 阿尔巴尼亚（Albania，欧洲，AL，ALB，008），阿尔巴尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_aerbaniya <br />
        /// Cosmos region code: 200102
        /// </summary>
        [RegionCode(200102)] [I18NIdentityCode(Europe.Albania.I18N_IDENTITY_CODE)]
        AL,

        /// <summary>
        /// 亚美尼亚（Armenia，亚洲，AM，ARM，051），亚美尼亚共和国<br />
        /// Cosmos i18n code: i18n_country_yameiniya <br />
        /// Cosmos region code: 100102
        /// </summary>
        [RegionCode(100102)] [I18NIdentityCode(Asia.Armenia.I18N_IDENTITY_CODE)]
        AM,

        /// <summary>
        /// 安哥拉（Angola，非洲，AO，AGO，024），安哥拉共和国 <br />
        /// Cosmos i18n code: i18n_country_angela <br />
        /// Cosmos region code: 300102
        /// </summary>
        [RegionCode(300102)] [I18NIdentityCode(Africa.Angola.I18N_IDENTITY_CODE)]
        AO,

        /// <summary>
        /// 南极洲（Antarctica，南极洲，AQ，ATA，010）<br />
        /// 人类的净土 <br />
        /// Cosmos i18n code: i18n_country_nanji <br />
        /// Cosmos region code: 700010
        /// </summary>
        [RegionCode(700010)] [I18NIdentityCode(Antarctica.Antarctique.I18N_IDENTITY_CODE)]
        AQ,

        /// <summary>
        /// 阿根廷（The Republic of Argentina，南美洲，AR，ARG，032），阿根廷共和国 <br />
        /// Cosmos i18n code: i18n_country_agenting <br />
        /// Cosmos region code: 500011
        /// </summary>
        [RegionCode(500011)] [I18NIdentityCode(SouthAmerica.Argentina.I18N_IDENTITY_CODE)]
        AR,

        /// <summary>
        /// 美属萨摩亚群岛（American Samoa，大洋洲，AS，ASM，016），阿根廷共和国 <br />
        /// 美属萨摩亚领地<br />
        /// Cosmos i18n code: i18n_country_ussamoya <br />
        /// Cosmos region code: 600101
        /// </summary>
        [RegionCode(600101)] [I18NIdentityCode(Oceania.AmericanSamoa.I18N_IDENTITY_CODE)]
        AS,

        /// <summary>
        /// 奥地利（The Republic of Austria，欧洲，AT，AUT，040），奥地利共和国 <br />
        /// Cosmos i18n code: i18n_country_aodili <br />
        /// Cosmos region code: 200011
        /// </summary>
        [RegionCode(200011)] [I18NIdentityCode(Europe.Austria.I18N_IDENTITY_CODE)]
        AT,

        /// <summary>
        /// 澳大利亚（The Commonwealth of Australia，大洋洲，AU，AUS，036），澳大利亚联邦 <br />
        /// Cosmos i18n code: i18n_country_aodaliya <br />
        /// Cosmos region code: 600011
        /// </summary>
        [RegionCode(600011)] [I18NIdentityCode(Oceania.Australia.I18N_IDENTITY_CODE)]
        AU,

        /// <summary>
        /// 阿鲁巴（Aruba，北美洲，AW，ABW，533），荷兰海外属地 <br />
        /// Cosmos i18n code: i18n_country_aluba <br />
        /// Cosmos region code: 400104
        /// </summary>
        [RegionCode(400104)] [I18NIdentityCode(NorthAmerica.Aruba.I18N_IDENTITY_CODE)]
        AW,

        /// <summary>
        /// 奥兰群岛（Aland Island，欧洲，AX，ALA，248），奥兰自治省 <br />
        /// Cosmos i18n code: i18n_country_aolanqundao <br />
        /// Cosmos region code: 200101
        /// </summary>
        [RegionCode(200101)] [I18NIdentityCode(Europe.AlandIslands.I18N_IDENTITY_CODE)]
        AX,

        /// <summary>
        /// 阿塞拜疆（The Republic of Azerbaijan，亚洲，AZ，AZE，031），阿塞拜疆共和国 <br />
        /// Cosmos i18n code: i18n_country_asaibaijiang <br />
        /// Cosmos region code: 100103
        /// </summary>
        [RegionCode(100103)] [I18NIdentityCode(Asia.Azerbaijan.I18N_IDENTITY_CODE)]
        AZ,

        /// <summary>
        /// 波黑（Bosnia and Herzegovina，欧洲，BA，BIH，070），波斯尼亚和黑塞哥维那 <br />
        /// Cosmos i18n code: i18n_country_bohei <br />
        /// Cosmos region code: 200106
        /// </summary>
        [RegionCode(200106)] [I18NIdentityCode(Europe.BosniaAndHerzegovina.I18N_IDENTITY_CODE)]
        BA,

        /// <summary>
        /// 巴巴多斯（Barbados，北美洲，BB，BRB，052） <br />
        /// Cosmos i18n code: i18n_country_babaduosi <br />
        /// Cosmos region code: 400106
        /// </summary>
        [RegionCode(400106)] [I18NIdentityCode(NorthAmerica.Barbados.I18N_IDENTITY_CODE)]
        BB,

        /// <summary>
        /// 孟加拉国（People's Republic Of Bangladesh，亚洲，BD，BGD，050），孟加拉人民共和国 <br />
        /// Cosmos i18n code: i18n_country_mengjiala <br />
        /// Cosmos region code: 100105
        /// </summary>
        [RegionCode(100105)] [I18NIdentityCode(Asia.Bangladesh.I18N_IDENTITY_CODE)]
        BD,

        /// <summary>
        /// 比利时（The Kingdom of Belgium，欧洲，BE，BEL，056），比利时王国 <br />
        /// Cosmos i18n code: i18n_country_bilishi <br />
        /// Cosmos region code: 200105
        /// </summary>
        [RegionCode(200105)] [I18NIdentityCode(Europe.Belgium.I18N_IDENTITY_CODE)]
        BE,

        /// <summary>
        /// 布基纳法索（Burkina Faso，非洲，BF，BFA，854） <br />
        /// Cosmos i18n code: i18n_country_bujinafaso <br />
        /// Cosmos region code: 300105
        /// </summary>
        [RegionCode(300105)] [I18NIdentityCode(Africa.BurkinaFaso.I18N_IDENTITY_CODE)]
        BF,

        /// <summary>
        /// 保加利亚（The Republic of Bulgaria，欧洲，BG，BRN，096），保加利亚共和国 <br />
        /// Cosmos i18n code: i18n_country_baojialiya <br />
        /// Cosmos region code: 200108
        /// </summary>
        [RegionCode(200108)] [I18NIdentityCode(Europe.Bulgaria.I18N_IDENTITY_CODE)]
        BG,

        /// <summary>
        /// 巴林（The Kingdom of Bahrain ，亚洲，BH，BHR，048），巴林王国 <br />
        /// Cosmos i18n code: i18n_country_balin <br />
        /// Cosmos region code: 100104
        /// </summary>
        [RegionCode(100104)] [I18NIdentityCode(Asia.Bahrain.I18N_IDENTITY_CODE)]
        BH,

        /// <summary>
        /// 布隆迪（The Republic of Burundi，非洲，BI，BDI，108），布隆迪共和国 <br />
        /// Cosmos i18n code: i18n_country_bulongdi <br />
        /// Cosmos region code: 300107
        /// </summary>
        [RegionCode(300107)] [I18NIdentityCode(Africa.Burundi.I18N_IDENTITY_CODE)]
        BI,

        /// <summary>
        /// 贝宁（The Republic of Benin，非洲，BJ，BEN，204），贝宁共和国 <br />
        /// Cosmos i18n code: i18n_country_beining <br />
        /// Cosmos region code: 300103
        /// </summary>
        [RegionCode(300103)] [I18NIdentityCode(Africa.Benin.I18N_IDENTITY_CODE)]
        BJ,

        /// <summary>
        /// 圣巴托洛缪岛（Collectivitéde Saint-Barthélemy，北美洲，BL，BLM，652），法兰西共和国圣巴托洛缪行政区 <br />
        /// Cosmos i18n code: i18n_country_shengbatuo <br />
        /// Cosmos region code: 400127
        /// </summary>
        [RegionCode(400127)] [I18NIdentityCode(NorthAmerica.SaintBarts.I18N_IDENTITY_CODE)]
        BL,

        /// <summary>
        /// 百慕大（The Bermuda Islands，北美洲，BI，BDI，108），百慕大群岛 <br />
        /// 旧称萨摩斯岛，隶属于大不列颠及北爱尔兰联合王国的海外自治领 <br />
        /// Cosmos i18n code: i18n_country_baimuda <br />
        /// Cosmos region code: 400108
        /// </summary>
        [RegionCode(400108)] [I18NIdentityCode(NorthAmerica.Bermuda.I18N_IDENTITY_CODE)]
        BM,

        /// <summary>
        /// 文莱 （Negara Brunei Darussalam，亚洲，BN，BRN，096），文莱达鲁萨兰国 <br />
        /// Cosmos i18n code: i18n_country_wenlai <br />
        /// Cosmos region code: 100108
        /// </summary>
        [RegionCode(100108)] [I18NIdentityCode(Asia.Brunei.I18N_IDENTITY_CODE)]
        BN,

        /// <summary>
        /// 玻利维亚（Plurinational State of Bolivia，南美洲，BO，BOL，068），多民族玻利维亚国 <br />
        /// Cosmos i18n code: i18n_country_boliweiya <br />
        /// Cosmos region code: 500101
        /// </summary>
        [RegionCode(500101)] [I18NIdentityCode(SouthAmerica.Bolivia.I18N_IDENTITY_CODE)]
        BO,

        /// <summary>
        /// 波内赫、圣尤斯特歇斯和萨巴（Bonaire, Sint Eustatius and Saba，北美洲，BQ，BES，535） <br />
        /// Cosmos i18n code: i18n_country_boneihe <br />
        /// Cosmos region code: 400109
        /// </summary>
        [RegionCode(400109)] [I18NIdentityCode(NorthAmerica.Bonaire.I18N_IDENTITY_CODE)]
        BQ,

        /// <summary>
        /// 巴西（The Federative Republic of Brazil，南美洲，BR，BRA，076），巴西联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_baxi <br />
        /// Cosmos region code: 500001
        /// </summary>
        [RegionCode(500001)] [I18NIdentityCode(SouthAmerica.Brazil.I18N_IDENTITY_CODE)]
        BR,

        /// <summary>
        /// 巴哈马（Commonwealth of the Bahamas，北美洲，BS，BHS，044），巴哈马国 <br />
        /// Cosmos i18n code: i18n_country_bahama <br />
        /// Cosmos region code: 400105
        /// </summary>
        [RegionCode(400105)] [I18NIdentityCode(NorthAmerica.Bahamas.I18N_IDENTITY_CODE)]
        BS,

        /// <summary>
        /// 不丹（Kingdom of Bhutan，亚洲，BT，BTN，064），不丹王国 <br />
        /// Cosmos i18n code: i18n_country_budan <br />
        /// Cosmos region code: 100106
        /// </summary>
        [RegionCode(100106)] [I18NIdentityCode(Asia.Bhutan.I18N_IDENTITY_CODE)]
        BT,

        /// <summary>
        /// 布韦岛（Bouvet Island，欧洲，BV，BVT，074） <br />
        /// Cosmos i18n code: i18n_country_buweidao <br />
        /// Cosmos region code: 200107
        /// </summary>
        [RegionCode(200107)] [I18NIdentityCode(Europe.BouvetIsland.I18N_IDENTITY_CODE)]
        BV,

        /// <summary>
        /// 博茨瓦纳（The Republic of Botswana，非洲，BW，BWA，072），博茨瓦纳共和国 <br />
        /// Cosmos i18n code: i18n_country_boziwana <br />
        /// Cosmos region code: 300104
        /// </summary>
        [RegionCode(300104)] [I18NIdentityCode(Africa.Botswana.I18N_IDENTITY_CODE)]
        BW,

        /// <summary>
        /// 白俄罗斯（Republic of Belarus，欧洲，BY，BLR，112），白俄罗斯共和国 <br />
        /// Cosmos i18n code: i18n_country_baieluosi <br />
        /// Cosmos region code: 200104
        /// </summary>
        [RegionCode(200104)] [I18NIdentityCode(Europe.Belarus.I18N_IDENTITY_CODE)]
        BY,

        /// <summary>
        /// 伯利兹（Belize，北美洲，BZ，BLZ，084） <br />
        /// Cosmos i18n code: i18n_country_bolizi<br />
        /// Cosmos region code: 400107
        /// </summary>
        [RegionCode(400107)] [I18NIdentityCode(NorthAmerica.Belize.I18N_IDENTITY_CODE)]
        BZ,

        /// <summary>
        /// 加拿大（Canada，北美洲，CA，CAN，124），英联邦成员国 <br />
        /// Cosmos i18n code: i18n_country_jianada <br />
        /// Cosmos region code: 400011
        /// </summary>
        [RegionCode(400011)] [I18NIdentityCode(NorthAmerica.Canada.I18N_IDENTITY_CODE)]
        CA,

        /// <summary>
        /// 科科斯群岛（Cocos Islands，亚洲，CC，CCK，166） <br />
        /// Cosmos i18n code: i18n_country_kekesi <br />
        /// Cosmos region code: 100111
        /// </summary>
        [RegionCode(100111)] [I18NIdentityCode(Asia.CocosIslands.I18N_IDENTITY_CODE)]
        CC,

        /// <summary>
        /// 刚果（金）（The Democratic Republic of the Congo，非洲，CD，CAF，140），刚果民主共和国 <br />
        /// Cosmos i18n code: i18n_country_gangguojin <br />
        /// Cosmos region code: 300113
        /// </summary>
        [RegionCode(300113)] [I18NIdentityCode(Africa.CongoKinshasa.I18N_IDENTITY_CODE)]
        CD,

        /// <summary>
        /// 中非（Central African Republic，非洲，CF，COD，180），中非共和国 <br />
        /// Cosmos i18n code: i18n_country_zhongfei <br />
        /// Cosmos region code: 300109
        /// </summary>
        [RegionCode(300109)] [I18NIdentityCode(Africa.CentralAfrican.I18N_IDENTITY_CODE)]
        CF,

        /// <summary>
        /// 刚果（布）（The Republic of Congo，非洲，CG，COG，178），刚果共和国 <br />
        /// Cosmos i18n code: i18n_country_gangguobu <br />
        /// Cosmos region code: 300112
        /// </summary>
        [RegionCode(300112)] [I18NIdentityCode(Africa.CongoBrazzaville.I18N_IDENTITY_CODE)]
        CG,

        /// <summary>
        /// 瑞士（Swiss Confederation，欧洲，CH，CHE，756），瑞士联邦 <br />
        /// Cosmos i18n code: i18n_country_ruishi <br />
        /// Cosmos region code: 200017
        /// </summary>
        [RegionCode(200017)] [I18NIdentityCode(Europe.Switzerland.I18N_IDENTITY_CODE)]
        CH,

        /// <summary>
        /// 科特迪瓦 （The Republic of Côte d'Ivoire，非洲，CI，CIV，384），科特迪瓦共和国 <br />
        /// Cosmos i18n code: i18n_country_ketediwa <br />
        /// Cosmos region code: 300114
        /// </summary>
        [RegionCode(300114)] [I18NIdentityCode(Africa.CotedIvoire.I18N_IDENTITY_CODE)]
        CI,

        /// <summary>
        /// 库克群岛（The Cook Islands，非洲，CK，COK，184） <br />
        /// Cosmos i18n code: i18n_country_kukequndao <br />
        /// Cosmos region code: 600102
        /// </summary>
        [RegionCode(600102)] [I18NIdentityCode(Oceania.CookIslands.I18N_IDENTITY_CODE)]
        CK,

        /// <summary>
        /// 智利（Republic of Chile，南美洲，CL，CHL，152），智利共和国 <br />
        /// Cosmos i18n code: i18n_country_zhili <br />
        /// Cosmos region code: 500012
        /// </summary>
        [RegionCode(500012)] [I18NIdentityCode(SouthAmerica.Chile.I18N_IDENTITY_CODE)]
        CL,

        /// <summary>
        /// 喀麦隆（Republic of Cameroon，非洲，CM，CRM，120），喀麦隆共和国 <br />
        /// Cosmos i18n code: i18n_country_kamailong <br />
        /// Cosmos region code: 300108
        /// </summary>
        [RegionCode(300108)] [I18NIdentityCode(Africa.Cameroun.I18N_IDENTITY_CODE)]
        CM,

        /// <summary>
        /// 中国（People's Republic of China，亚洲，CN，CNH，156），中华人民共和国 <br />
        /// 一个伟大的文明古国，人类的未来 <br />
        /// Cosmos i18n code: i18n_country_china <br />
        /// Cosmos region code: 100001
        /// </summary>
        [RegionCode(100001)] [I18NIdentityCode(Asia.China.I18N_IDENTITY_CODE)]
        CN,

        /// <summary>
        /// 哥伦比亚（The Republic of Colombia，南美洲，CO，COL，170），哥伦比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_gelunbiya <br />
        /// Cosmos region code: 500102
        /// </summary>
        [RegionCode(500102)] [I18NIdentityCode(SouthAmerica.Colombia.I18N_IDENTITY_CODE)]
        CO,

        /// <summary>
        /// 哥斯达黎加（The Republic of Costa Rica，南美洲，CR，CRI，188），哥斯达黎加共和国 <br />
        /// Cosmos i18n code: i18n_country_gesidalijia <br />
        /// Cosmos region code: 400111
        /// </summary>
        [RegionCode(400111)] [I18NIdentityCode(NorthAmerica.CostaRica.I18N_IDENTITY_CODE)]
        CR,

        /// <summary>
        /// 古巴（The Republic of Cuba，北美洲，CU，CUB，192），古巴共和国 <br />
        /// Cosmos i18n code: i18n_country_guba <br />
        /// Cosmos region code: 400101
        /// </summary>
        [RegionCode(400101)] [I18NIdentityCode(NorthAmerica.Cuba.I18N_IDENTITY_CODE)]
        CU,

        /// <summary>
        /// 佛得角（Republic of Cape Verde，非洲，CV，CPV，132），佛得角共和国 <br />
        /// Cosmos i18n code: i18n_country_fodejiao <br />
        /// Cosmos region code: 300106
        /// </summary>
        [RegionCode(300106)] [I18NIdentityCode(Africa.CapeVerde.I18N_IDENTITY_CODE)]
        CV,

        /// <summary>
        /// 库拉索（Curaçao，北美洲，CW，CUW，531） <br />
        /// Cosmos i18n code: i18n_country_kusuola <br />
        /// Cosmos region code: 400112
        /// </summary>
        [RegionCode(400112)] [I18NIdentityCode(NorthAmerica.Curaçao.I18N_IDENTITY_CODE)]
        CW,

        /// <summary>
        /// 圣诞岛（Christmas Island，亚洲，CX，CXR，162） <br />
        /// Cosmos i18n code: i18n_country_shengdandao <br />
        /// Cosmos region code: 100110
        /// </summary>
        [RegionCode(100110)] [I18NIdentityCode(Asia.ChristmasIsland.I18N_IDENTITY_CODE)]
        CX,

        /// <summary>
        /// 塞浦路斯（The Republic of Cyprus，亚洲，CY，CYP，196），塞浦路斯共和国 <br />
        /// Cosmos i18n code: i18n_country_saipulusi <br />
        /// Cosmos region code: 100112
        /// </summary>
        [RegionCode(100112)] [I18NIdentityCode(Asia.Cyprus.I18N_IDENTITY_CODE)]
        CY,

        /// <summary>
        /// 捷克（The Czech Republic，欧洲，CZ，CZE，203），捷克共和国 <br />
        /// Cosmos i18n code: i18n_country_jieke <br />
        /// Cosmos region code: 200012
        /// </summary>
        [RegionCode(200012)] [I18NIdentityCode(Europe.Czechia.I18N_IDENTITY_CODE)]
        CZ,

        /// <summary>
        /// 德国（TThe Federal Republic of Germany，欧洲，DE，DEU，276），德意志联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_deguo <br />
        /// Cosmos region code: 200002
        /// </summary>
        [RegionCode(200002)] [I18NIdentityCode(Europe.Germany.I18N_IDENTITY_CODE)]
        DE,

        /// <summary>
        /// 吉布提（The Republic of Djibouti，亚洲，DJ，DJI，262），吉布提共和国 <br />
        /// Cosmos i18n code: i18n_country_jibuti <br />
        /// Cosmos region code: 100113
        /// </summary>
        [RegionCode(100113)] [I18NIdentityCode(Asia.Djibouti.I18N_IDENTITY_CODE)]
        DJ,

        /// <summary>
        /// 丹麦（The Kingdom of Denmark，欧洲，DK，DNK，208），丹麦王国 <br />
        /// Cosmos i18n code: i18n_country_danmai <br />
        /// Cosmos region code: 200110
        /// </summary>
        [RegionCode(200110)] [I18NIdentityCode(Europe.Denmark.I18N_IDENTITY_CODE)]
        DK,

        /// <summary>
        /// 多米尼克（The Commonwealth of Dominica，北美洲，DM，DMA，212），多米尼克国 <br />
        /// Cosmos i18n code: i18n_country_duominike <br />
        /// Cosmos region code: 400113
        /// </summary>
        [RegionCode(400113)] [I18NIdentityCode(NorthAmerica.Dominica.I18N_IDENTITY_CODE)]
        DM,

        /// <summary>
        /// 多米尼加（The Dominican Republic，北美洲，DO，DOM，214），多米尼加共和国 <br />
        /// Cosmos i18n code: i18n_country_duominijia <br />
        /// Cosmos region code: 400114
        /// </summary>
        [RegionCode(400114)] [I18NIdentityCode(NorthAmerica.Dominican.I18N_IDENTITY_CODE)]
        DO,

        /// <summary>
        /// 阿尔及利亚（People's Democratic Republic of Algeria，非洲，DZ，DZA，012），阿尔及利亚民主人民共和国 <br />
        /// Cosmos i18n code: i18n_country_aerjiliya <br />
        /// Cosmos region code: 300101
        /// </summary>
        [RegionCode(300101)] [I18NIdentityCode(Africa.Algeria.I18N_IDENTITY_CODE)]
        DZ,

        /// <summary>
        /// 厄瓜多尔（The Republic of Ecuador，南美洲，EC，ECU，218），厄瓜多尔共和国 <br />
        /// Cosmos i18n code: i18n_country_eguaduoer <br />
        /// Cosmos region code: 500103
        /// </summary>
        [RegionCode(500103)] [I18NIdentityCode(SouthAmerica.Ecuador.I18N_IDENTITY_CODE)]
        EC,

        /// <summary>
        /// 爱沙尼亚（Republic of Estonia，欧洲，EE，EST，233），爱沙尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_aishaniya <br />
        /// Cosmos region code: 200111
        /// </summary>
        [RegionCode(200111)] [I18NIdentityCode(Europe.Estonia.I18N_IDENTITY_CODE)]
        EE,

        /// <summary>
        /// 埃及（The Arab Republic of Egypt，非洲，EG，EGY，818），阿拉伯埃及共和国 <br />
        /// Cosmos i18n code: i18n_country_aiji <br />
        /// Cosmos region code: 300011
        /// </summary>
        [RegionCode(300011)] [I18NIdentityCode(Africa.Egypt.I18N_IDENTITY_CODE)]
        EG,

        /// <summary>
        /// 西撒哈拉（The Sahrawi Arab Democratic Republic，非洲，EH，ESH，732），阿拉伯撒哈拉民主共和国 <br />
        /// Cosmos i18n code: i18n_country_xisahala <br />
        /// Cosmos region code: 300118
        /// </summary>
        [RegionCode(300118)] [I18NIdentityCode(Africa.WesternSahara.I18N_IDENTITY_CODE)]
        EH,

        /// <summary>
        /// 厄立特里亚（The State of Eritrea，非洲，ER，ERI，232），厄立特里亚国 <br />
        /// Cosmos i18n code: i18n_country_aliteliya <br />
        /// Cosmos region code: 300116
        /// </summary>
        [RegionCode(300116)] [I18NIdentityCode(Africa.Eritrea.I18N_IDENTITY_CODE)]
        ER,

        /// <summary>
        /// 西班牙（The Kingdom of Spain，欧洲，ES，ESP，724），西班牙王国 <br />
        /// Cosmos i18n code: i18n_country_xibanya <br />
        /// Cosmos region code: 200015
        /// </summary>
        [RegionCode(200015)] [I18NIdentityCode(Europe.Spain.I18N_IDENTITY_CODE)]
        ES,

        /// <summary>
        /// 埃塞俄比亚（The Federal Democratic Republic of Ethiopia，非洲，ET，ETH，231），埃塞俄比亚联邦民主共和国 <br />
        /// Cosmos i18n code: i18n_country_aisaiebiya <br />
        /// Cosmos region code: 300123
        /// </summary>
        [RegionCode(300123)] [I18NIdentityCode(Africa.Ethiopia.I18N_IDENTITY_CODE)]
        ET,

        /// <summary>
        /// 芬兰（The Republic of Finland，欧洲，FI，FIN，246），芬兰共和国 <br />
        /// Cosmos i18n code: i18n_country_fenlan <br />
        /// Cosmos region code: 200113
        /// </summary>
        [RegionCode(200113)] [I18NIdentityCode(Europe.Finland.I18N_IDENTITY_CODE)]
        FI,

        /// <summary>
        /// 斐济（The Republic of Fiji，大洋洲，FJ，FJI，242），斐济共和国 <br />
        /// Cosmos i18n code: i18n_country_feiji <br />
        /// Cosmos region code: 600103
        /// </summary>
        [RegionCode(600103)] [I18NIdentityCode(Oceania.Fiji.I18N_IDENTITY_CODE)]
        FJ,

        /// <summary>
        /// 马尔维纳斯群岛（Falkland Islands，南美洲，FK，FLK，238） <br />
        /// Cosmos i18n code: i18n_country_fukelan <br />
        /// Cosmos region code: 500104
        /// </summary>
        [RegionCode(500104)] [I18NIdentityCode(SouthAmerica.FalklandIslands.I18N_IDENTITY_CODE)]
        FK,

        /// <summary>
        /// 密克罗尼西亚（The Federated States of Micronesia，大洋洲，FM，FSM，583） ，密克罗尼西亚联邦<br />
        /// Cosmos i18n code: i18n_country_mikeluonixiya <br />
        /// Cosmos region code: 600107
        /// </summary>
        [RegionCode(600107)] [I18NIdentityCode(Oceania.Micronesia.I18N_IDENTITY_CODE)]
        FM,

        /// <summary>
        /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
        /// Cosmos i18n code: i18n_country_faluo <br />
        /// Cosmos region code: 200112
        /// </summary>
        [RegionCode(200112)] [I18NIdentityCode(Europe.Faroe.I18N_IDENTITY_CODE)]
        FO,

        /// <summary>
        /// 法国（French Republic，欧洲，FR，FRA，250），法兰西共和国 <br />
        /// Cosmos i18n code: i18n_country_faguo <br />
        /// Cosmos region code: 200001
        /// </summary>
        [RegionCode(200001)] [I18NIdentityCode(Europe.France.I18N_IDENTITY_CODE)]
        FR,

        /// <summary>
        /// 加蓬（The Gabonese Republic，非洲，GA，GAB，266），加蓬共和国 <br />
        /// Cosmos i18n code: i18n_country_jiapeng <br />
        /// Cosmos region code: 300126
        /// </summary>
        [RegionCode(300126)] [I18NIdentityCode(Africa.Gabon.I18N_IDENTITY_CODE)]
        GA,

        /// <summary>
        /// 英国（United Kingdom of Great Britain and Northern Ireland，欧洲，GB，GBR，826），大不列颠及北爱尔兰联合王国 <br />
        /// Cosmos i18n code: i18n_country_yingguo <br />
        /// Cosmos region code: 200005
        /// </summary>
        [RegionCode(200005)] [I18NIdentityCode(Europe.UnitedKingdom.I18N_IDENTITY_CODE)]
        GB,

        /// <summary>
        /// 格林纳达（Grenada，北美洲，GD，GRD，308） <br />
        /// Cosmos i18n code: i18n_country_gelinnada <br />
        /// Cosmos region code: 400117
        /// </summary>
        [RegionCode(400117)] [I18NIdentityCode(NorthAmerica.Grenada.I18N_IDENTITY_CODE)]
        GD,

        /// <summary>
        /// 格鲁吉亚（Georgia，亚洲，GE，GEO，268） <br />
        /// Cosmos i18n code: i18n_country_gelujiya <br />
        /// Cosmos region code: 100115
        /// </summary>
        [RegionCode(100115)] [I18NIdentityCode(Asia.Georgia.I18N_IDENTITY_CODE)]
        GE,

        /// <summary>
        /// 法属圭亚那（Guyane Francaise，南美洲，GF，GUF，254） <br />
        /// Cosmos i18n code: i18n_country_guiyana <br />
        /// Cosmos region code: 500105
        /// </summary>
        [RegionCode(500105)] [I18NIdentityCode(SouthAmerica.Guiana.I18N_IDENTITY_CODE)]
        GF,

        /// <summary>
        /// 根西岛（Bailiwick of Guernsey，欧洲，GG，GGY，831） <br />
        /// Cosmos i18n code: i18n_country_genxidao <br />
        /// Cosmos region code: 200116
        /// </summary>
        [RegionCode(200116)] [I18NIdentityCode(Europe.Guernsey.I18N_IDENTITY_CODE)]
        GG,

        /// <summary>
        /// 加纳（The Republic of Ghana，非洲，GH，GHA，288），加纳共和国 <br />
        /// Cosmos i18n code: i18n_country_jiana <br />
        /// Cosmos region code: 300127
        /// </summary>
        [RegionCode(300127)] [I18NIdentityCode(Africa.Ghana.I18N_IDENTITY_CODE)]
        GH,

        /// <summary>
        /// 直布罗陀（Gibraltar，欧洲，GI，GIB，292） <br />
        /// Cosmos i18n code: i18n_country_zhibuluotuo <br />
        /// Cosmos region code: 200114
        /// </summary>
        [RegionCode(200114)] [I18NIdentityCode(Europe.Gibraltar.I18N_IDENTITY_CODE)]
        GI,

        /// <summary>
        /// 格陵兰岛（Greenland，北美洲，GL，GRL，304） <br />
        /// Cosmos i18n code: i18n_country_gelinlan <br />
        /// Cosmos region code: 400116
        /// </summary>
        [RegionCode(400116)] [I18NIdentityCode(NorthAmerica.Greenland.I18N_IDENTITY_CODE)]
        GL,

        /// <summary>
        /// 冈比亚（Republic of The Gambia，非洲，GM，GMB，270），冈比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_gangbiya <br />
        /// Cosmos region code: 300128
        /// </summary>
        [RegionCode(300128)] [I18NIdentityCode(Africa.Gambia.I18N_IDENTITY_CODE)]
        GM,

        /// <summary>
        /// 几内亚（The Republic of Guinea，非洲，GN，GIN，324），几内亚共和国 <br />
        /// Cosmos i18n code: i18n_country_jineiya <br />
        /// Cosmos region code: 300129
        /// </summary>
        [RegionCode(300129)] [I18NIdentityCode(Africa.Guinea.I18N_IDENTITY_CODE)]
        GN,

        /// <summary>
        /// 瓜德罗普（Guadeloupe，北美洲，GP，GLP，312） <br />
        /// Cosmos i18n code: i18n_country_guadeluopu <br />
        /// Cosmos region code: 400118
        /// </summary>
        [RegionCode(400118)] [I18NIdentityCode(NorthAmerica.Guadeloupe.I18N_IDENTITY_CODE)]
        GP,

        /// <summary>
        /// 赤道几内亚（The Republic of Equatorial Guinea，非洲，GQ，GNQ，226），赤道几内亚共和国 <br />
        /// Cosmos i18n code: i18n_country_chidaojineiya<br />
        /// Cosmos region code: 300115
        /// </summary>
        [RegionCode(300115)] [I18NIdentityCode(Africa.EquatorialGuinea.I18N_IDENTITY_CODE)]
        GQ,

        /// <summary>
        /// 希腊（The Republic of Greece，欧洲，GR，GRC，300），希腊共和国 <br />
        /// Cosmos i18n code: i18n_country_xila <br />
        /// Cosmos region code: 200115
        /// </summary>
        [RegionCode(200115)] [I18NIdentityCode(Europe.Greece.I18N_IDENTITY_CODE)]
        GR,

        /// <summary>
        /// 南乔治亚岛和南桑威奇群岛（South Georgia and The South Sandwich Islands，南美洲，GS，SGS，239） <br />
        /// Cosmos i18n code: i18n_country_nanqiaozhiya <br />
        /// Cosmos region code: 500111
        /// </summary>
        [RegionCode(500111)] [I18NIdentityCode(SouthAmerica.SGSSI.I18N_IDENTITY_CODE)]
        GS,

        /// <summary>
        /// 危地马拉（The Republic of Guatemala，北美洲，GT，GTM，320），危地马拉共和国 <br />
        /// Cosmos i18n code: i18n_country_weidimala <br />
        /// Cosmos region code: 400119
        /// </summary>
        [RegionCode(400119)] [I18NIdentityCode(NorthAmerica.Guatemala.I18N_IDENTITY_CODE)]
        GT,

        /// <summary>
        /// 关岛（The Territory of Guam，大洋洲，GU，GUM，316） <br />
        /// Cosmos i18n code: i18n_country_guandao <br />
        /// Cosmos region code: 600104
        /// </summary>
        [RegionCode(600104)] [I18NIdentityCode(Oceania.Guam.I18N_IDENTITY_CODE)]
        GU,

        /// <summary>
        /// 几内亚比绍（The Republic of Guinea-Bissau，非洲，GW，GNB，624），几内亚比绍共和国 <br />
        /// Cosmos i18n code: i18n_country_jineiyabishao <br />
        /// Cosmos region code: 300130
        /// </summary>
        [RegionCode(300130)] [I18NIdentityCode(Africa.GuineaBissau.I18N_IDENTITY_CODE)]
        GW,

        /// <summary>
        /// 圭亚那（Cooperative Republic of Guyana，南美洲，GY，GUY，328），圭亚那合作共和国 <br />
        /// Cosmos i18n code: i18n_country_guiyana <br />
        /// Cosmos region code: 500106
        /// </summary>
        [RegionCode(500106)] [I18NIdentityCode(SouthAmerica.Guyana.I18N_IDENTITY_CODE)]
        GY,

        /// <summary>
        /// 香港（Hong Kong, SAR China，亚洲，HK，HKG，344），中华人民共和国香港特别行政区 <br />
        /// 香港，中华人民共和国的一部分 <br />
        /// Hong Kong, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhxianggang <br />
        /// Cosmos region code: 1000010033
        /// </summary>
        [RegionCode(1_00_001_0033)] [I18NIdentityCode(Asia.HongKong.I18N_IDENTITY_CODE)]
        HK,

        /// <summary>
        /// 赫德岛和麦克唐纳群岛（Heard Island and McDonald Islands，亚洲，HM，HMD，334） <br />
        /// Cosmos i18n code: i18n_country_hedemaiketang <br />
        /// Cosmos region code: 100116
        /// </summary>
        [RegionCode(100116)] [I18NIdentityCode(Asia.HIMI.I18N_IDENTITY_CODE)]
        HM,

        /// <summary>
        /// 洪都拉斯（The Republic of Honduras，南美洲，HN，HND，340），洪都拉斯共和国 <br />
        /// Cosmos i18n code: i18n_country_hongdulasi <br />
        /// Cosmos region code: 500107
        /// </summary>
        [RegionCode(500107)] [I18NIdentityCode(SouthAmerica.Honduras.I18N_IDENTITY_CODE)]
        HN,

        /// <summary>
        /// 克罗地亚（Republic of Croatia，欧洲，HR，HRV，191），克罗地亚共和国 <br />
        /// Cosmos i18n code: i18n_country_keluodiya <br />
        /// Cosmos region code: 200109
        /// </summary>
        [RegionCode(200109)] [I18NIdentityCode(Europe.Croatia.I18N_IDENTITY_CODE)]
        HR,

        /// <summary>
        /// 海地（The Republic of Haiti，北美洲，HT，HTI，332），海地共和国 <br />
        /// Cosmos i18n code: i18n_country_haidi <br />
        /// Cosmos region code: 400120
        /// </summary>
        [RegionCode(400120)] [I18NIdentityCode(NorthAmerica.Haiti.I18N_IDENTITY_CODE)]
        HT,

        /// <summary>
        /// 匈牙利（Hungary，欧洲，HU，HUN，348） <br />
        /// Cosmos i18n code: i18n_country_xiongyali <br />
        /// Cosmos region code: 200013
        /// </summary>
        [RegionCode(200013)] [I18NIdentityCode(Europe.Hungary.I18N_IDENTITY_CODE)]
        HU,

        /// <summary>
        /// 印度尼西亚（The Republic of Indonesia，亚洲，ID，IDN，360），印度尼西亚共和国 <br />
        /// Cosmos i18n code: i18n_country_yindunixiya <br />
        /// Cosmos region code: 100116
        /// </summary>
        [RegionCode(100116)] [I18NIdentityCode(Asia.Indonesia.I18N_IDENTITY_CODE)]
        ID,

        /// <summary>
        /// 爱尔兰（Republic of Ireland，欧洲，IE，IRL，372），爱尔兰共和国 <br />
        /// Cosmos i18n code: i18n_country_aierlan <br />
        /// Cosmos region code: 200117
        /// </summary>
        [RegionCode(200117)] [I18NIdentityCode(Europe.Ireland.I18N_IDENTITY_CODE)]
        IE,

        /// <summary>
        /// 以色列（The State of Israel，亚洲，IL，ISR，376），以色列国 <br />
        /// Cosmos i18n code: i18n_country_yiselie <br />
        /// Cosmos region code: 100015
        /// </summary>
        [RegionCode(100015)] [I18NIdentityCode(Asia.Israel.I18N_IDENTITY_CODE)]
        IL,

        /// <summary>
        /// 马恩岛（Isle of Man，欧洲，IM，IMN，833），英属马恩岛 <br />
        /// Cosmos i18n code: i18n_country_maendao <br />
        /// Cosmos region code: 200127
        /// </summary>
        [RegionCode(200127)] [I18NIdentityCode(Europe.Mann.I18N_IDENTITY_CODE)]
        IM,

        /// <summary>
        /// 印度（Republic of India，亚洲，IN，IND，356），印度共和国 <br />
        /// Cosmos i18n code: i18n_country_yindu <br />
        /// Cosmos region code: 100013
        /// </summary>
        [RegionCode(100013)] [I18NIdentityCode(Asia.India.I18N_IDENTITY_CODE)]
        IN,

        /// <summary>
        /// 英属印度洋领地（British Indian Ocean Territory，亚洲，IO，IOT，086） <br />
        /// Cosmos i18n code: i18n_country_yingshuying <br />
        /// Cosmos region code: 100107
        /// </summary>
        [RegionCode(100107)] [I18NIdentityCode(Asia.BritishIndianOceanTerritory.I18N_IDENTITY_CODE)]
        IO,

        /// <summary>
        /// 伊拉克（Republic Of Iraq，亚洲，IQ，IRQ，368），伊拉克共和国 <br />
        /// Cosmos i18n code: i18n_country_yilake <br />
        /// Cosmos region code: 100117
        /// </summary>
        [RegionCode(100117)] [I18NIdentityCode(Asia.Iraq.I18N_IDENTITY_CODE)]
        IQ,

        /// <summary>
        /// 伊朗（The Islamic Republic of Iran，亚洲，IR，IRN，364），伊朗伊斯兰共和国 <br />
        /// Cosmos i18n code: i18n_country_yilang<br />
        /// Cosmos region code: 100014
        /// </summary>
        [RegionCode(100014)] [I18NIdentityCode(Asia.Iran.I18N_IDENTITY_CODE)]
        IR,

        /// <summary>
        /// 冰岛（The Republic of Iceland，欧洲，IS，ISL，352），冰岛共和国 <br />
        /// Cosmos i18n code: i18n_country_bingdao <br />
        /// Cosmos region code: 200118
        /// </summary>
        [RegionCode(200118)] [I18NIdentityCode(Europe.Iceland.I18N_IDENTITY_CODE)]
        IS,

        /// <summary>
        /// 意大利（The Republic of Italy，欧洲，IT，ITA，380），意大利共和国 <br />
        /// Cosmos i18n code: i18n_country_yidali <br />
        /// Cosmos region code: 200003
        /// </summary>
        [RegionCode(200003)] [I18NIdentityCode(Europe.Italy.I18N_IDENTITY_CODE)]
        IT,

        /// <summary>
        /// 泽西（Bailiwick of Jersey，欧洲，JE，JEY，832），泽西岛 <br />
        /// Cosmos i18n code: i18n_country_zexi <br />
        /// Cosmos region code: 200119
        /// </summary>
        [RegionCode(200119)] [I18NIdentityCode(Europe.Jersey.I18N_IDENTITY_CODE)]
        JE,

        /// <summary>
        /// 牙买加（Jamaica，北美洲，JM，JAM，388） <br />
        /// Cosmos i18n code: i18n_country_yamaijia <br />
        /// Cosmos region code: 400121
        /// </summary>
        [RegionCode(400121)] [I18NIdentityCode(NorthAmerica.Jamaica.I18N_IDENTITY_CODE)]
        JM,

        /// <summary>
        /// 约旦（The Hashemite Kingdom of Jordan，亚洲，JO，JOR，400），约旦哈希姆王国 <br />
        /// Cosmos i18n code: i18n_country_yuedan <br />
        /// Cosmos region code: 100118
        /// </summary>
        [RegionCode(100118)] [I18NIdentityCode(Asia.Jordan.I18N_IDENTITY_CODE)]
        JO,

        /// <summary>
        /// 日本（Japan，亚洲，JP，JPN，392），日本国 <br />
        /// Cosmos i18n code: i18n_country_riben<br />
        /// Cosmos region code: 100002
        /// </summary>
        [RegionCode(100002)] [I18NIdentityCode(Asia.Japan.I18N_IDENTITY_CODE)]
        JP,

        /// <summary>
        /// 肯尼亚（The Republic Of Kenya，非洲，KE，KEN，404），肯尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_kenniya <br />
        /// Cosmos region code: 300012
        /// </summary>
        [RegionCode(300012)] [I18NIdentityCode(Africa.Kenya.I18N_IDENTITY_CODE)]
        KE,

        /// <summary>
        /// 吉尔吉斯斯坦（The Kyrgyz Republic/Kyrgyzstan，亚洲，KG，KGZ，417），吉尔吉斯共和国 <br />
        /// Cosmos i18n code: i18n_country_jierjisi <br />
        /// Cosmos region code: 100121
        /// </summary>
        [RegionCode(100121)] [I18NIdentityCode(Asia.Kyrgyzstan.I18N_IDENTITY_CODE)]
        KG,

        /// <summary>
        /// 柬埔寨（The Kingdom of Cambodia，亚洲，KH，KHM，116），柬埔寨王国 <br />
        /// Cosmos i18n code: i18n_country_jipuzhai <br />
        /// Cosmos region code: 100109
        /// </summary>
        [RegionCode(100109)] [I18NIdentityCode(Asia.Cambodia.I18N_IDENTITY_CODE)]
        KH,

        /// <summary>
        /// 基里巴斯（The Republic of Kiribati，大洋洲，KI，KIR，296），基里巴斯共和国 <br />
        /// Cosmos i18n code: i18n_country_jilibasi <br />
        /// Cosmos region code: 600105
        /// </summary>
        [RegionCode(600105)] [I18NIdentityCode(Oceania.Kiribati.I18N_IDENTITY_CODE)]
        KI,

        /// <summary>
        /// 科摩罗（Union of Comoros，非洲，KM，COM，174），科摩罗联盟 <br />
        /// Cosmos i18n code: i18n_country_kemoluo <br />
        /// Cosmos region code: 300111
        /// </summary>
        [RegionCode(300111)] [I18NIdentityCode(Africa.Comoros.I18N_IDENTITY_CODE)]
        KM,

        /// <summary>
        /// 圣基茨和尼维斯（The Federation of Saint Kitts and Nevis，北美洲，KN，KNA，659），圣基茨和尼维斯联邦 <br />
        /// Cosmos i18n code: i18n_country_shengjiciniweisi <br />
        /// Cosmos region code: 400128
        /// </summary>
        [RegionCode(400128)] [I18NIdentityCode(NorthAmerica.SaintKittsAndNevis.I18N_IDENTITY_CODE)]
        KN,

        /// <summary>
        /// 朝鲜（Democratic People's Republic of Korea，亚洲，KP，PRK，408），朝鲜民主主义人民共和国 <br />
        /// Cosmos i18n code: i18n_country_chaoxian <br />
        /// Cosmos region code: 100011
        /// </summary>
        [RegionCode(100011)] [I18NIdentityCode(Asia.NorthKorea.I18N_IDENTITY_CODE)]
        KP,

        /// <summary>
        /// 韩国（Republic Of Korea，亚洲，KR，KOR，410），大韩民国 <br />
        /// Cosmos i18n code: i18n_country_hanguo <br />
        /// Cosmos region code: 100012
        /// </summary>
        [RegionCode(100012)] [I18NIdentityCode(Asia.SouthKorea.I18N_IDENTITY_CODE)]
        KR,

        /// <summary>
        /// 科威特（The State of Kuwait，亚洲，KW，KWT，414），科威特国 <br />
        /// Cosmos i18n code: i18n_country_keweite <br />
        /// Cosmos region code: 100120
        /// </summary>
        [RegionCode(100120)] [I18NIdentityCode(Asia.Kuwait.I18N_IDENTITY_CODE)]
        KW,

        /// <summary>
        /// 开曼群岛（Cayman Islands，北美洲，KY，CYM，136） <br />
        /// Cosmos i18n code: i18n_country_kaiman <br />
        /// Cosmos region code: 400110
        /// </summary>
        [RegionCode(400110)] [I18NIdentityCode(NorthAmerica.CaymanIslands.I18N_IDENTITY_CODE)]
        KY,

        /// <summary>
        /// 哈萨克斯坦（ The Republic of Kazakhstan，亚洲，KZ，KAZ，398），哈萨克斯坦共和国 <br />
        /// Cosmos i18n code: i18n_country_hasakesitan <br />
        /// Cosmos region code: 100119
        /// </summary>
        [RegionCode(100119)] [I18NIdentityCode(Asia.Kazakhstan.I18N_IDENTITY_CODE)]
        KZ,

        /// <summary>
        /// 老挝（Lao People's Democratic Republic，亚洲，LA，LAO，418），老挝人民民主共和国 <br />
        /// Cosmos i18n code: i18n_country_laowo <br />
        /// Cosmos region code: 100122
        /// </summary>
        [RegionCode(100122)] [I18NIdentityCode(Asia.LaoPDR.I18N_IDENTITY_CODE)]
        LA,

        /// <summary>
        /// 黎巴嫩（The Republic of Lebanon，亚洲，LB，LBN，422），黎巴嫩共和国 <br />
        /// Cosmos i18n code: i18n_country_libanen <br />
        /// Cosmos region code: 100123
        /// </summary>
        [RegionCode(100123)] [I18NIdentityCode(Asia.Lebanon.I18N_IDENTITY_CODE)]
        LB,

        /// <summary>
        /// 圣卢西亚（Republic Of Iraq，北美洲，LC，LCA，662） <br />
        /// Cosmos i18n code: i18n_country_shengluxiya <br />
        /// Cosmos region code: 400129
        /// </summary>
        [RegionCode(400129)] [I18NIdentityCode(NorthAmerica.SaintLucia.I18N_IDENTITY_CODE)]
        LC,

        /// <summary>
        /// 列支敦士登（Principality of Liechtenstein，欧洲，LI，LIE，438），列支敦士登公国 <br />
        /// Cosmos i18n code: i18n_country_liezhidunshideng <br />
        /// Cosmos region code: 200122
        /// </summary>
        [RegionCode(200122)] [I18NIdentityCode(Europe.Liechtenstein.I18N_IDENTITY_CODE)]
        LI,

        /// <summary>
        /// 斯里兰卡（The Democratic Socialist Republic of Sri Lanka，亚洲，LK，LKA，144），斯里兰卡民主社会主义共和国 <br />
        /// Cosmos i18n code: i18n_country_sililanka <br />
        /// Cosmos region code: 100135
        /// </summary>
        [RegionCode(100135)] [I18NIdentityCode(Asia.SriLanka.I18N_IDENTITY_CODE)]
        LK,

        /// <summary>
        /// 利比里亚（Republic Of Liberia，非洲，LR，LBR，430），利比里亚共和国 <br />
        /// Cosmos i18n code: i18n_country_libiliya <br />
        /// Cosmos region code: 300132
        /// </summary>
        [RegionCode(300132)] [I18NIdentityCode(Africa.Liberia.I18N_IDENTITY_CODE)]
        LR,

        /// <summary>
        /// 莱索托（Kingdom of Lesotho，非洲，LS，LSO，426），莱索托王国 <br />
        /// Cosmos i18n code: i18n_country_laisuotuo <br />
        /// Cosmos region code: 300131
        /// </summary>
        [RegionCode(300131)] [I18NIdentityCode(Africa.Lesotho.I18N_IDENTITY_CODE)]
        LS,

        /// <summary>
        /// 立陶宛（The Republic of Lithuania，欧洲，LT，LTU，440），立陶宛共和国 <br />
        /// Cosmos i18n code: i18n_country_litaowan <br />
        /// Cosmos region code: 200123
        /// </summary>
        [RegionCode(200123)] [I18NIdentityCode(Europe.Lithuania.I18N_IDENTITY_CODE)]
        LT,

        /// <summary>
        /// 卢森堡（The Grand Duchy of Luxembourg，欧洲，LU，LUX，442），卢森堡大公国 <br />
        /// Cosmos i18n code: i18n_country_lusenbao <br />
        /// Cosmos region code: 200124
        /// </summary>
        [RegionCode(200124)] [I18NIdentityCode(Europe.Luxembourg.I18N_IDENTITY_CODE)]
        LU,

        /// <summary>
        /// 拉脱维亚（The Republic of Latvia，欧洲，LV，LVA，428），拉脱维亚共和国 <br />
        /// Cosmos i18n code: i18n_country_latuoweiya <br />
        /// Cosmos region code: 200121
        /// </summary>
        [RegionCode(200121)] [I18NIdentityCode(Europe.Latvia.I18N_IDENTITY_CODE)]
        LV,

        /// <summary>
        /// 利比亚（State of Libya，非洲，LY，LBY，434），利比亚国 <br />
        /// Cosmos i18n code: i18n_country_libiya <br />
        /// Cosmos region code: 300133
        /// </summary>
        [RegionCode(300133)] [I18NIdentityCode(Africa.Libya.I18N_IDENTITY_CODE)]
        LY,

        /// <summary>
        /// 摩洛哥（The Kingdom of Morocco，非洲，MA，MAR，504），摩洛哥王国 <br />
        /// Cosmos i18n code: i18n_country_moluoge <br />
        /// Cosmos region code: 300139
        /// </summary>
        [RegionCode(300139)] [I18NIdentityCode(Africa.Morocco.I18N_IDENTITY_CODE)]
        MA,

        /// <summary>
        /// 摩纳哥（The Principality of Monaco，欧洲，MC，MCO，492），摩纳哥公国 <br />
        /// Cosmos i18n code: i18n_country_monage <br />
        /// Cosmos region code: 200129
        /// </summary>
        [RegionCode(200129)] [I18NIdentityCode(Europe.Monaco.I18N_IDENTITY_CODE)]
        MC,

        /// <summary>
        /// 摩尔多瓦（Republic of Moldova，欧洲，MD，MDA，498），摩尔多瓦共和国 <br />
        /// Cosmos i18n code: i18n_country_moerduowa <br />
        /// Cosmos region code: 200128
        /// </summary>
        [RegionCode(200128)] [I18NIdentityCode(Europe.Moldova.I18N_IDENTITY_CODE)]
        MD,

        /// <summary>
        /// 黑山（Montenegro，欧洲，ME，MNE，499），黑山共和国 <br />
        /// Cosmos i18n code: i18n_country_heishan <br />
        /// Cosmos region code: 200130
        /// </summary>
        [RegionCode(200130)] [I18NIdentityCode(Europe.Montenegro.I18N_IDENTITY_CODE)]
        ME,

        /// <summary>
        /// 法属圣马丁（Saint Martin (French part)，北美洲，MF，MAF，663），圣马丁行政区 <br />
        /// Cosmos i18n code: i18n_country_shengmading <br />
        /// Cosmos region code: 400130
        /// </summary>
        [RegionCode(400130)] [I18NIdentityCode(NorthAmerica.SaintMartinFrenchPart.I18N_IDENTITY_CODE)]
        MF,

        /// <summary>
        /// 马达加斯加（The Republic of Madagascar，非洲，MG，MDG，450），马达加斯加共和国 <br />
        /// Cosmos i18n code: i18n_country_madajiasijia <br />
        /// Cosmos region code: 300134
        /// </summary>
        [RegionCode(300134)] [I18NIdentityCode(Africa.Madagascar.I18N_IDENTITY_CODE)]
        MG,

        /// <summary>
        /// 马绍尔群岛（The Republic of Marshall Islands，大洋洲，MH，MHL，584），马绍尔群岛共和国 <br />
        /// Cosmos i18n code: i18n_country_mashaoer <br />
        /// Cosmos region code: 600106
        /// </summary>
        [RegionCode(600106)] [I18NIdentityCode(Oceania.MarshallIslands.I18N_IDENTITY_CODE)]
        MH,

        /// <summary>
        /// 北马其顿（The Republic of North Macedonia，欧洲，MK，MKD，807），北马其顿共和国 <br />
        /// Cosmos i18n code: i18n_country_maqidun <br />
        /// Cosmos region code: 200125
        /// </summary>
        [RegionCode(200125)] [I18NIdentityCode(Europe.Macedonia.I18N_IDENTITY_CODE)]
        MK,

        /// <summary>
        /// 马里（The Republic of Mali，非洲，ML，MLI，466），马里共和国 <br />
        /// Cosmos i18n code: i18n_country_mali <br />
        /// Cosmos region code: 300122
        /// </summary>
        [RegionCode(300122)] [I18NIdentityCode(Africa.Mali.I18N_IDENTITY_CODE)]
        ML,

        /// <summary>
        /// 缅甸（The Republic of the Union of Myanmar，亚洲，MM，MMR，104），缅甸联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_miandian <br />
        /// Cosmos region code: 100127
        /// </summary>
        [RegionCode(100127)] [I18NIdentityCode(Asia.Myanmar.I18N_IDENTITY_CODE)]
        MM,

        /// <summary>
        /// 蒙古国（Outer Mongolia，亚洲，MN，MNG，496），外蒙古 <br />
        /// Cosmos i18n code: i18n_country_waimenggu <br />
        /// Cosmos region code: 100126
        /// </summary>
        [RegionCode(100126)] [I18NIdentityCode(Asia.Mongolia.I18N_IDENTITY_CODE)]
        MN,

        /// <summary>
        /// 澳门（Macao, SAR China，亚洲，MO，MAC，446），中华人民共和国澳门特别行政区 <br />
        /// 澳门，中华人民共和国的一部分 <br />
        /// Macao, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhaomen <br />
        /// Cosmos region code: 10000100334
        /// </summary>
        [RegionCode(1_00_001_0034)] [I18NIdentityCode(Asia.Macao.I18N_IDENTITY_CODE)]
        MO,

        /// <summary>
        /// 北马里亚那群岛（Commonwealth of the Northern Mariana Islands，大洋洲，MP，MNP，580），北马里亚纳群岛自由邦 <br />
        /// Cosmos i18n code: i18n_country_beimaliyana <br />
        /// Cosmos region code: 600112
        /// </summary>
        [RegionCode(600112)] [I18NIdentityCode(Oceania.NorthernMarianaIslands.I18N_IDENTITY_CODE)]
        MP,

        /// <summary>
        /// 马提尼克岛（Martinique，北美洲，MQ，MTQ，474），法国的海外大区 <br />
        /// Cosmos i18n code: i18n_country_matinike <br />
        /// Cosmos region code: 400122
        /// </summary>
        [RegionCode(400122)] [I18NIdentityCode(NorthAmerica.Martinique.I18N_IDENTITY_CODE)]
        MQ,

        /// <summary>
        /// 毛里塔尼亚（The Islamic Republic of Mauritania，非洲，MR，MR，478），毛里塔尼亚伊斯兰共和国 <br />
        /// Cosmos i18n code: i18n_country_maolitaniya <br />
        /// Cosmos region code: 300135
        /// </summary>
        [RegionCode(300135)] [I18NIdentityCode(Africa.Mauritania.I18N_IDENTITY_CODE)]
        MR,

        /// <summary>
        /// 蒙特塞拉特（Montserrat，北美洲，MS，MSR，500） <br />
        /// Cosmos i18n code: i18n_country_mengtesailate <br />
        /// Cosmos region code: 400124
        /// </summary>
        [RegionCode(400124)] [I18NIdentityCode(NorthAmerica.Montserrat.I18N_IDENTITY_CODE)]
        MS,

        /// <summary>
        /// 马耳他（Republic of Malta，欧洲，MT，MLT，470），马耳他共和国 <br />
        /// Cosmos i18n code: i18n_country_maerta <br />
        /// Cosmos region code: 200126
        /// </summary>
        [RegionCode(200126)] [I18NIdentityCode(Europe.Malta.I18N_IDENTITY_CODE)]
        MT,

        /// <summary>
        /// 毛里求斯（The Republic of Mauritius，非洲，MU，MUS，480），毛里求斯共和国 <br />
        /// Cosmos i18n code: i18n_country_maoliqiusi <br />
        /// Cosmos region code: 300136
        /// </summary>
        [RegionCode(300136)] [I18NIdentityCode(Africa.Mauritius.I18N_IDENTITY_CODE)]
        MU,

        /// <summary>
        /// 马尔代夫（The Republic of Maldives，亚洲，MV，MDV，462），马尔代夫共和国 <br />
        /// Cosmos i18n code: i18n_country_maerdaifu <br />
        /// Cosmos region code: 100125
        /// </summary>
        [RegionCode(100124)] [I18NIdentityCode(Asia.Maldives.I18N_IDENTITY_CODE)]
        MV,

        /// <summary>
        /// 马拉维（The Republic of Malawi，非洲，MW，MWI，454），马拉维共和国 <br />
        /// Cosmos i18n code: i18n_country_malawei <br />
        /// Cosmos region code: 300137
        /// </summary>
        [RegionCode(300137)] [I18NIdentityCode(Africa.Malawi.I18N_IDENTITY_CODE)]
        MW,

        /// <summary>
        /// 墨西哥（The United Mexican States，北美洲，MX，MEX，484），墨西哥合众国 <br />
        /// Cosmos i18n code: i18n_country_moxige <br />
        /// Cosmos region code: 400123
        /// </summary>
        [RegionCode(400123)] [I18NIdentityCode(NorthAmerica.Mexico.I18N_IDENTITY_CODE)]
        MX,

        /// <summary>
        /// 大马（Malaysia，亚洲，MY，MYS，458），马来西亚 <br />
        /// Cosmos i18n code: i18n_country_malaixiya <br />
        /// Cosmos region code: 100124
        /// </summary>
        [RegionCode(100124)] [I18NIdentityCode(Asia.Malaysia.I18N_IDENTITY_CODE)]
        MY,

        /// <summary>
        /// 莫桑比克（The Republic of Mozambique，非洲，MZ，MOZ，508），莫桑比克共和国 <br />
        /// Cosmos i18n code: i18n_country_mosangbike <br />
        /// Cosmos region code: 300140
        /// </summary>
        [RegionCode(300140)] [I18NIdentityCode(Africa.Mozambique.I18N_IDENTITY_CODE)]
        MZ,

        /// <summary>
        /// 纳米比亚（The Republic of Namibia，非洲，NA，NAM，516），纳米比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_manibiya <br />
        /// Cosmos region code: 300141
        /// </summary>
        [RegionCode(300141)] [I18NIdentityCode(Africa.Namibia.I18N_IDENTITY_CODE)]
        NA,

        /// <summary>
        /// 新喀里多尼亚（New Caledonia，大洋洲，NC，NCL，540） <br />
        /// Cosmos i18n code: i18n_country_xinkaliduoniya <br />
        /// Cosmos region code: 600109
        /// </summary>
        [RegionCode(600109)] [I18NIdentityCode(Oceania.NewCaledonia.I18N_IDENTITY_CODE)]
        NC,

        /// <summary>
        /// 尼日尔（The Republic of Niger，非洲，NE，NER，562），尼日尔共和国 <br />
        /// Cosmos i18n code: i18n_country_nirier <br />
        /// Cosmos region code: 300143
        /// </summary>
        [RegionCode(300143)] [I18NIdentityCode(Africa.Niger.I18N_IDENTITY_CODE)]
        NE,

        /// <summary>
        /// 诺福克岛（Norfolk Island，大洋洲，NF，NFK，574） <br />
        /// Cosmos i18n code: i18n_country_nuofuke <br />
        /// Cosmos region code: 600111
        /// </summary>
        [RegionCode(600111)] [I18NIdentityCode(Oceania.NorfolkIsland.I18N_IDENTITY_CODE)]
        NF,

        /// <summary>
        /// 尼日利亚（Federal Republic of Nigeria，非洲，NG，NGA，566，尼日利亚联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_niriliya <br />
        /// Cosmos region code: 300142
        /// </summary>
        [RegionCode(300142)] [I18NIdentityCode(Africa.Nigeria.I18N_IDENTITY_CODE)]
        NG,

        /// <summary>
        /// 尼加拉瓜（The Republic of Nicaragua，南美洲，NI，NIC，558），尼加拉瓜共和国 <br />
        /// Cosmos i18n code: i18n_country_nijialagua <br />
        /// Cosmos region code: 500108
        /// </summary>
        [RegionCode(500108)] [I18NIdentityCode(SouthAmerica.Nicaragua.I18N_IDENTITY_CODE)]
        NI,

        /// <summary>
        /// 荷兰（The Kingdom of the Netherlands，欧洲，NL，NLD，528），荷兰王国 <br />
        /// Cosmos i18n code: i18n_country_helan<br />
        /// Cosmos region code: 200131
        /// </summary>
        [RegionCode(200131)] [I18NIdentityCode(Europe.Netherlands.I18N_IDENTITY_CODE)]
        NL,

        /// <summary>
        /// 挪威（The Kingdom of Norway，欧洲，NO，NOR，578），挪威王国 <br />
        /// Cosmos i18n code: i18n_country_nuowei<br />
        /// Cosmos region code: 200132
        /// </summary>
        [RegionCode(200132)] [I18NIdentityCode(Europe.Norway.I18N_IDENTITY_CODE)]
        NO,

        /// <summary>
        /// 尼泊尔（Federal Democratic Republic of Nepal，亚洲，NP，NPL，524），尼泊尔联邦民主共和国 <br />
        /// Cosmos i18n code: i18n_country_niboer <br />
        /// Cosmos region code: 100128
        /// </summary>
        [RegionCode(100128)] [I18NIdentityCode(Asia.Nepal.I18N_IDENTITY_CODE)]
        NP,

        /// <summary>
        /// 瑙鲁（The Republic of Nauru，大洋洲，NR，NRU，520），瑙鲁共和国 <br />
        /// Cosmos i18n code: i18n_country_manu <br />
        /// Cosmos region code: 600108
        /// </summary>
        [RegionCode(600108)] [I18NIdentityCode(Oceania.Nauru.I18N_IDENTITY_CODE)]
        NR,

        /// <summary>
        /// 纽埃（Niue，大洋洲，NU，NIU，570） <br />
        /// Cosmos i18n code: i18n_country_niuai <br />
        /// Cosmos region code: 600110
        /// </summary>
        [RegionCode(600110)] [I18NIdentityCode(Oceania.Niue.I18N_IDENTITY_CODE)]
        NU,

        /// <summary>
        /// 新西兰（New Zealand，大洋洲，NZ，NZL，554） <br />
        /// Cosmos i18n code: i18n_country_xinxilan <br />
        /// Cosmos region code: 600012
        /// </summary>
        [RegionCode(600012)] [I18NIdentityCode(Oceania.NewZealand.I18N_IDENTITY_CODE)]
        NZ,

        /// <summary>
        /// 阿曼（Sultanate of Oman，亚洲，OM，OMN，512），阿曼苏丹国 <br />
        /// Cosmos i18n code: i18n_country_aman <br />
        /// Cosmos region code: 100129
        /// </summary>
        [RegionCode(100129)] [I18NIdentityCode(Asia.Oman.I18N_IDENTITY_CODE)]
        OM,

        /// <summary>
        /// 巴拿马（The Republic of Panama，北美洲，PA，PAN，591），巴拿马共和国 <br />
        /// Cosmos i18n code: i18n_country_banama <br />
        /// Cosmos region code: 400125
        /// </summary>
        [RegionCode(400125)] [I18NIdentityCode(NorthAmerica.Panama.I18N_IDENTITY_CODE)]
        PA,

        /// <summary>
        /// 秘鲁（The Republic of Peru，南美洲，PE，PER，604），秘鲁共和国 <br />
        /// Cosmos i18n code: i18n_country_bilu <br />
        /// Cosmos region code: 500110
        /// </summary>
        [RegionCode(500110)] [I18NIdentityCode(SouthAmerica.Peru.I18N_IDENTITY_CODE)]
        PE,

        /// <summary>
        /// 波利尼西亚（French Polynesia，大洋洲，PF，PYF，258），法属波利尼西亚 <br />
        /// Cosmos i18n code: i18n_country_bolinixiya <br />
        /// Cosmos region code: 600119
        /// </summary>
        [RegionCode(600119)] [I18NIdentityCode(Oceania.Polynesia.I18N_IDENTITY_CODE)]
        PF,

        /// <summary>
        /// 巴布亚新几内亚（The Independent State of Papua New Guinea，大洋洲，PG，PNG，598），巴布亚新几内亚独立国 <br />
        /// Cosmos i18n code: i18n_country_baxin <br />
        /// Cosmos region code: 600114
        /// </summary>
        [RegionCode(600114)] [I18NIdentityCode(Oceania.PapuaNewGuinea.I18N_IDENTITY_CODE)]
        PG,

        /// <summary>
        /// 菲律宾（Republic of the Philippines，亚洲，PH，PHL，6080），菲律宾共和国 <br />
        /// Cosmos i18n code: i18n_country_felvbin <br />
        /// Cosmos region code: 100131
        /// </summary>
        [RegionCode(100131)] [I18NIdentityCode(Asia.Philippines.I18N_IDENTITY_CODE)]
        PH,

        /// <summary>
        /// 巴基斯坦（Islamic Republic of Pakistan，亚洲，PK，PAK，586），巴基斯坦伊斯兰共和国 <br />
        /// Cosmos i18n code: i18n_country_bajisitan <br />
        /// Cosmos region code: 100016
        /// </summary>
        [RegionCode(100016)] [I18NIdentityCode(Asia.Pakistan.I18N_IDENTITY_CODE)]
        PK,

        /// <summary>
        /// 波兰（The Republic Of Poland，欧洲，PL，POL，61），波兰共和国 <br />
        /// Cosmos i18n code: i18n_country_bolan <br />
        /// Cosmos region code: 200014
        /// </summary>
        [RegionCode(200014)] [I18NIdentityCode(Europe.Poland.I18N_IDENTITY_CODE)]
        PL,

        /// <summary>
        /// 圣皮埃尔和密克隆群岛（The Islands of Saint Pierre and Miquelon，北美洲，PM，SPM，666），法国海外领土 <br />
        /// Cosmos i18n code: i18n_country_shengyiaiermkl <br />
        /// Cosmos region code: 400132
        /// </summary>
        [RegionCode(400132)] [I18NIdentityCode(NorthAmerica.SaintPierreAndMiquelon.I18N_IDENTITY_CODE)]
        PM,

        /// <summary>
        /// 皮特肯岛（Pitcairn Islands，大洋洲，PN，PCN，612），皮特凯恩群岛 <br />
        /// Cosmos i18n code: i18n_country_piteken <br />
        /// Cosmos region code: 600117
        /// </summary>
        [RegionCode(600117)] [I18NIdentityCode(Oceania.Pitcairn.I18N_IDENTITY_CODE)]
        PN,

        /// <summary>
        /// 波多黎各（The Commonwealth of Puerto Rico，北美洲，PR，PRI，630），波多黎各自治邦 <br />
        /// Cosmos i18n code: i18n_country_boduolige <br />
        /// Cosmos region code: 400126
        /// </summary>
        [RegionCode(400126)] [I18NIdentityCode(NorthAmerica.PuertoRico.I18N_IDENTITY_CODE)]
        PR,

        /// <summary>
        /// 巴勒斯坦（The State of Palestine，亚洲，PS，PSE，275），巴勒斯坦国 <br />
        /// Cosmos i18n code: i18n_country_balesitan <br />
        /// Cosmos region code: 100130
        /// </summary>
        [RegionCode(100130)] [I18NIdentityCode(Asia.Palestine.I18N_IDENTITY_CODE)]
        PS,

        /// <summary>
        /// 葡萄牙（The Portuguese Republic，欧洲，PT，PRT，620），葡萄牙共和国 <br />
        /// Cosmos i18n code: i18n_country_putapya <br />
        /// Cosmos region code: 200133
        /// </summary>
        [RegionCode(200133)] [I18NIdentityCode(Europe.Portugal.I18N_IDENTITY_CODE)]
        PT,

        /// <summary>
        /// 帕劳（The Republic of Palau，大洋洲，PW，PLW，585），帕劳共和国 <br />
        /// Cosmos i18n code: i18n_country_palao <br />
        /// Cosmos region code: 600113
        /// </summary>
        [RegionCode(600113)] [I18NIdentityCode(Oceania.Palau.I18N_IDENTITY_CODE)]
        PW,

        /// <summary>
        /// 巴拉圭（Republic Of Paraguay，南美洲，PY，PRY，600），巴拉圭共和国 <br />
        /// Cosmos i18n code: i18n_country_balagui <br />
        /// Cosmos region code: 500109
        /// </summary>
        [RegionCode(500109)] [I18NIdentityCode(SouthAmerica.Paraguay.I18N_IDENTITY_CODE)]
        PY,

        /// <summary>
        /// 卡塔尔（State of Qatar，亚洲，QA，QAT，634），卡塔尔国 <br />
        /// Cosmos i18n code: i18n_country_kataer <br />
        /// Cosmos region code: 100132
        /// </summary>
        [RegionCode(100132)] [I18NIdentityCode(Asia.Qatar.I18N_IDENTITY_CODE)]
        QA,

        /// <summary>
        /// 留尼汪（Reunion Island，非洲，RE，REU，638），留尼旺岛 <br />
        /// Cosmos i18n code: i18n_country_liuniwang <br />
        /// Cosmos region code: 300147
        /// </summary>
        [RegionCode(300147)] [I18NIdentityCode(Africa.Réunion.I18N_IDENTITY_CODE)]
        RE,

        /// <summary>
        /// 罗马尼亚（Romania，欧洲，RO，ROU，642） <br />
        /// Cosmos i18n code: i18n_country_luomaniya <br />
        /// Cosmos region code: 200134
        /// </summary>
        [RegionCode(200134)] [I18NIdentityCode(Europe.Romania.I18N_IDENTITY_CODE)]
        RO,

        /// <summary>
        /// 塞尔维亚（The Republic of Serbia，欧洲，RS，SRB，688），塞尔维亚共和国 <br />
        /// Cosmos i18n code: i18n_country_saierweiya <br />
        /// Cosmos region code: 200136
        /// </summary>
        [RegionCode(200136)] [I18NIdentityCode(Europe.Serbia.I18N_IDENTITY_CODE)]
        RS,

        /// <summary>
        /// 俄罗斯（Russian Federation，欧洲，BI，BDI，108），俄罗斯联邦 <br />
        /// Cosmos i18n code: i18n_country_eluosi <br />
        /// Cosmos region code: 200004
        /// </summary>
        [RegionCode(200004)] [I18NIdentityCode(Europe.Russia.I18N_IDENTITY_CODE)]
        RU,

        /// <summary>
        /// 卢旺达（The Republic of Rwanda，非洲，RW，RWA，646），卢旺达共和国 <br />
        /// Cosmos i18n code: i18n_country_luwangda <br />
        /// Cosmos region code: 300144
        /// </summary>
        [RegionCode(300144)] [I18NIdentityCode(Africa.Rwanda.I18N_IDENTITY_CODE)]
        RW,

        /// <summary>
        /// 沙特（Kingdom of Saudi Arabia，亚洲，SA，SAU，682），沙特阿拉伯王国 <br />
        /// Cosmos i18n code: i18n_country_shate <br />
        /// Cosmos region code: 100133
        /// </summary>
        [RegionCode(100133)] [I18NIdentityCode(Asia.SaudiArabia.I18N_IDENTITY_CODE)]
        SA,

        /// <summary>
        /// 所罗门群岛（Solomon Islands，大洋洲，SB，SLB，090） <br />
        /// Cosmos i18n code: i18n_country_suoluomen <br />
        /// Cosmos region code: 600115
        /// </summary>
        [RegionCode(600115)] [I18NIdentityCode(Oceania.SolomonIslands.I18N_IDENTITY_CODE)]
        SB,

        /// <summary>
        /// 塞舌尔（Republic of Seychelles，非洲，SC，SYC，690），塞舌尔共和国 <br />
        /// Cosmos i18n code: i18n_country_saisheer <br />
        /// Cosmos region code: 300145
        /// </summary>
        [RegionCode(300145)] [I18NIdentityCode(Africa.Seychelles.I18N_IDENTITY_CODE)]
        SC,

        /// <summary>
        /// 苏丹（Republic of the Sudan，非洲，SD，SDN，736），苏丹共和国 <br />
        /// Cosmos i18n code: i18n_country_sudan <br />
        /// Cosmos region code: 300146
        /// </summary>
        [RegionCode(300146)] [I18NIdentityCode(Africa.Sudan.I18N_IDENTITY_CODE)]
        SD,

        /// <summary>
        /// 瑞典（The Kingdom of Sweden，欧洲，SE，SWE，752），瑞典王国 <br />
        /// Cosmos i18n code: i18n_country_ruidian <br />
        /// Cosmos region code: 200016
        /// </summary>
        [RegionCode(200016)] [I18NIdentityCode(Europe.Sweden.I18N_IDENTITY_CODE)]
        SE,

        /// <summary>
        /// 新加坡（Republic of Singapore，亚洲，SG，SGP，702），新加坡共和国 <br />
        /// Cosmos i18n code: i18n_country_xinjiapo<br />
        /// Cosmos region code: 100134
        /// </summary>
        [RegionCode(100134)] [I18NIdentityCode(Asia.Singapore.I18N_IDENTITY_CODE)]
        SG,

        /// <summary>
        /// 圣赫勒拿、阿森松与特里斯坦达库尼亚（Saint Helena, Ascension and Tristan da Cunha，非洲，SH，SHN，654） <br />
        /// Cosmos i18n code: i18n_country_shenghelena <br />
        /// Cosmos region code: 300121
        /// </summary>
        [RegionCode(300121)] [I18NIdentityCode(Africa.SaintHelena.I18N_IDENTITY_CODE)]
        SH,

        /// <summary>
        /// 斯洛文尼亚（The Republic of Slovenia，欧洲，SI，SVN，705），斯洛文尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_sinuowenniya <br />
        /// Cosmos region code: 200138
        /// </summary>
        [RegionCode(200138)] [I18NIdentityCode(Europe.Slovenia.I18N_IDENTITY_CODE)]
        SI,

        /// <summary>
        /// 斯瓦尔巴群岛（The Svalbard archipelago，欧洲，SJ，SJM，744） <br />
        /// Cosmos i18n code: i18n_country_siwaerba <br />
        /// Cosmos region code: 200139
        /// </summary>
        [RegionCode(200139)] [I18NIdentityCode(Europe.SvalbardAndJanMayen.I18N_IDENTITY_CODE)]
        SJ,

        /// <summary>
        /// 斯洛伐克（The Slovak Republic，欧洲，SK，SVK，703），斯洛伐克共和国 <br />
        /// Cosmos i18n code: i18n_country_siluofake <br />
        /// Cosmos region code: 200137
        /// </summary>
        [RegionCode(200137)] [I18NIdentityCode(Europe.Slovakia.I18N_IDENTITY_CODE)]
        SK,

        /// <summary>
        /// 塞拉利昂（The Republic of Sierra Leone，非洲，SL，SLE，694），塞拉利昂共和国 <br />
        /// Cosmos i18n code: i18n_country_sailaliang <br />
        /// Cosmos region code: 300153
        /// </summary>
        [RegionCode(300153)] [I18NIdentityCode(Africa.SierraLeone.I18N_IDENTITY_CODE)]
        SL,

        /// <summary>
        /// 圣马力诺（The Republic of San Marino，欧洲，SM，SMR，674），圣马力诺共和国 <br />
        /// Cosmos i18n code: i18n_country_shengmalinuo <br />
        /// Cosmos region code: 200135
        /// </summary>
        [RegionCode(200135)] [I18NIdentityCode(Europe.SanMarino.I18N_IDENTITY_CODE)]
        SM,

        /// <summary>
        /// 塞内加尔（The Republic of Senegal，非洲，SN，SEN，686），塞内加尔共和国 <br />
        /// Cosmos i18n code: i18n_country_saineijiaer <br />
        /// Cosmos region code: 300151
        /// </summary>
        [RegionCode(300151)] [I18NIdentityCode(Africa.Senegal.I18N_IDENTITY_CODE)]
        SN,

        /// <summary>
        /// 索马里（The Federal Republic of Somalia，非洲，SO，SOM，706），索马里联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_suomali <br />
        /// Cosmos region code: 300152
        /// </summary>
        [RegionCode(300152)] [I18NIdentityCode(Africa.Somalia.I18N_IDENTITY_CODE)]
        SO,

        /// <summary>
        /// 苏里南（The Republic of Suriname，非洲，SR，SUR，740），苏里南共和国 <br />
        /// Cosmos i18n code: i18n_country_sulinan <br />
        /// Cosmos region code: 300150
        /// </summary>
        [RegionCode(300150)] [I18NIdentityCode(Africa.Suriname.I18N_IDENTITY_CODE)]
        SR,

        /// <summary>
        /// 南苏丹（The Republic of South Sudan，非洲，SS，SSD，728），南苏丹共和国 <br />
        /// Cosmos i18n code: i18n_country_nansudan <br />
        /// Cosmos region code: 300149
        /// </summary>
        [RegionCode(300149)] [I18NIdentityCode(Africa.SouthSudan.I18N_IDENTITY_CODE)]
        SS,

        /// <summary>
        /// 圣多美和普林西比（The Democratic Republic of Sao Tome and Principe，非洲，ST，STP，678），圣多美和普林西比民主共和国 <br />
        /// Cosmos i18n code: i18n_country_shengduomeiplxb <br />
        /// Cosmos region code: 300148
        /// </summary>
        [RegionCode(300148)] [I18NIdentityCode(Africa.SaoTomeAndPrincipe.I18N_IDENTITY_CODE)]
        ST,

        /// <summary>
        /// 萨尔瓦多（The Democratic Republic of Sao Tome and Principe，北美洲，SV，SLV，222），萨尔瓦多共和国 <br />
        /// Cosmos i18n code: i18n_country_saerwaduo <br />
        /// Cosmos region code: 400115
        /// </summary>
        [RegionCode(400115)] [I18NIdentityCode(NorthAmerica.ElSalvador.I18N_IDENTITY_CODE)]
        SV,

        /// <summary>
        /// 荷兰属圣马丁（Sint Maarten (Dutch part)，北美洲，SX，SXM，534） <br />
        /// Cosmos i18n code: i18n_country_shengmadingdp <br />
        /// Cosmos region code: 400131
        /// </summary>
        [RegionCode(400131)] [I18NIdentityCode(NorthAmerica.SintMaartenDutchPart.I18N_IDENTITY_CODE)]
        SX,

        /// <summary>
        /// 叙利亚（The Syrian Arab Republic，亚洲，SY，SYR，760），阿拉伯叙利亚共和国 <br />
        /// Cosmos i18n code: i18n_country_xuliya <br />
        /// Cosmos region code: 100136
        /// </summary>
        [RegionCode(100136)] [I18NIdentityCode(Asia.Syrian.I18N_IDENTITY_CODE)]
        SY,

        /// <summary>
        /// 斯威士兰（The Kingdom of Swaziland，非洲，SZ，SWZ，748），斯威士兰王国 <br />
        /// Cosmos i18n code: i18n_country_siweishilan <br />
        /// Cosmos region code: 300155
        /// </summary>
        [RegionCode(300155)] [I18NIdentityCode(Africa.Swaziland.I18N_IDENTITY_CODE)]
        SZ,

        /// <summary>
        /// 特克斯和凯科斯群岛（The Turks and Caicos Islands，北美洲，TC，TCA，796） <br />
        /// Cosmos i18n code: i18n_country_tekesikks <br />
        /// Cosmos region code: 400135
        /// </summary>
        [RegionCode(400135)] [I18NIdentityCode(NorthAmerica.TurksAndCaicosIslands.I18N_IDENTITY_CODE)]
        TC,

        /// <summary>
        /// 乍得（Republic of Chad，非洲，TD，TCD，148），乍得共和国 <br />
        /// Cosmos i18n code: i18n_country_zhade <br />
        /// Cosmos region code: 300110
        /// </summary>
        [RegionCode(300110)] [I18NIdentityCode(Africa.Chad.I18N_IDENTITY_CODE)]
        TD,

        /// <summary>
        /// 法属南部领地（French Southern Territories，非洲，TF，ATF，260） <br />
        /// Cosmos i18n code: i18n_country_faguonanbulingdi <br />
        /// Cosmos region code: 300124
        /// </summary>
        [RegionCode(300124)] [I18NIdentityCode(Africa.FrenchSouthernTerritories.I18N_IDENTITY_CODE)]
        TF,

        /// <summary>
        /// 多哥（French Southern Territories，非洲，TG，TGO，768），多哥共和国 <br />
        /// Cosmos i18n code: i18n_country_duoge <br />
        /// Cosmos region code: 300125
        /// </summary>
        [RegionCode(300125)] [I18NIdentityCode(Africa.Togo.I18N_IDENTITY_CODE)]
        TG,

        /// <summary>
        /// 泰国（The Kingdom of Thailand，亚洲，TH，THA，764），泰王国 <br />
        /// Cosmos i18n code: i18n_country_taiguo <br />
        /// Cosmos region code: 100138
        /// </summary>
        [RegionCode(100138)] [I18NIdentityCode(Asia.Thailand.I18N_IDENTITY_CODE)]
        TH,

        /// <summary>
        /// 塔吉克斯坦（The Republic of Tajikistan，亚洲，TJ，TJK，762），塔吉克斯坦共和国 <br />
        /// Cosmos i18n code: i18n_country_tajikesitan <br />
        /// Cosmos region code: 100137
        /// </summary>
        [RegionCode(100137)] [I18NIdentityCode(Asia.Tajikistan.I18N_IDENTITY_CODE)]
        TJ,

        /// <summary>
        /// 托克劳群岛（Tokelau，大洋洲，TK，TKL，772） <br />
        /// Cosmos i18n code: i18n_country_tuokelao <br />
        /// Cosmos region code: 600120
        /// </summary>
        [RegionCode(600120)] [I18NIdentityCode(Oceania.Tokelau.I18N_IDENTITY_CODE)]
        TK,

        /// <summary>
        /// 东帝汶（Democratic Republic of Timor-Leste，亚洲，TL，TLS，626），东帝汶民主共和国 <br />
        /// Cosmos i18n code: i18n_country_dongdiwen <br />
        /// Cosmos region code: 100114
        /// </summary>
        [RegionCode(100114)] [I18NIdentityCode(Asia.EastTimor.I18N_IDENTITY_CODE)]
        TL,

        /// <summary>
        /// 土库曼（Turkmenistan，亚洲，TM，TKM，795），土库曼斯坦 <br />
        /// Cosmos i18n code: i18n_country_tukumansitan <br />
        /// Cosmos region code: 100139
        /// </summary>
        [RegionCode(100139)] [I18NIdentityCode(Asia.Turkmenistan.I18N_IDENTITY_CODE)]
        TM,

        /// <summary>
        /// 突尼斯（The Republic of Tunisia，非洲，TN，TUN，788），突尼斯共和国 <br />
        /// Cosmos i18n code: i18n_country_tunisi <br />
        /// Cosmos region code: 300120
        /// </summary>
        [RegionCode(300120)] [I18NIdentityCode(Africa.Tunisia.I18N_IDENTITY_CODE)]
        TN,

        /// <summary>
        /// 汤加（The Kingdom of Tonga，大洋洲，TO，TN，776），汤加王国 <br />
        /// Cosmos i18n code: i18n_country_tangjia <br />
        /// Cosmos region code: 600121
        /// </summary>
        [RegionCode(600121)] [I18NIdentityCode(Oceania.Tonga.I18N_IDENTITY_CODE)]
        TO,

        /// <summary>
        /// 土耳其（The Republic of Turkey，亚洲，TR，TUR，792），土耳其共和国 <br />
        /// Cosmos i18n code: i18n_country_tuerqi <br />
        /// Cosmos region code: 100017
        /// </summary>
        [RegionCode(100017)] [I18NIdentityCode(Asia.Turkey.I18N_IDENTITY_CODE)]
        TR,

        /// <summary>
        /// 特立尼达和多巴哥（Republic of Trinidad and Tobago，北美洲，TT，TTO，780），特立尼达和多巴哥共和国 <br />
        /// Cosmos i18n code: i18n_country_telinidaduobage <br />
        /// Cosmos region code: 400134
        /// </summary>
        [RegionCode(400134)] [I18NIdentityCode(NorthAmerica.TrinidadAndTobago.I18N_IDENTITY_CODE)]
        TT,

        /// <summary>
        /// 图瓦卢（Tuvalu，大洋洲，TV，TUV，798） <br />
        /// Cosmos i18n code: i18n_country_tuwalu <br />
        /// Cosmos region code: 600122
        /// </summary>
        [RegionCode(600122)] [I18NIdentityCode(Oceania.Tuvalu.I18N_IDENTITY_CODE)]
        TV,

        /// <summary>
        /// 台湾（Taiwan, China，亚洲，TW，TWN，158），中华人民共和国台湾省 <br />
        /// 台湾，中华人民共和国的一部分 <br />
        /// Taiwan, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhtaiwan <br />
        /// Cosmos region code: 10000100332
        /// </summary>
        [RegionCode(1_00_001_0032)] [I18NIdentityCode(Asia.Taiwan.I18N_IDENTITY_CODE)]
        TW,

        /// <summary>
        /// 坦桑尼亚（The United Republic of Tanzania，非洲，TZ，TZA，834），坦桑尼亚联合共和国 <br />
        /// Cosmos i18n code: i18n_country_tansangniya <br />
        /// Cosmos region code: 300014
        /// </summary>
        [RegionCode(300014)] [I18NIdentityCode(Africa.Tanzania.I18N_IDENTITY_CODE)]
        TZ,

        /// <summary>
        /// 乌克兰（Ukraine，欧洲，UA，UKR，804） <br />
        /// Cosmos i18n code: i18n_country_wukelan <br />
        /// Cosmos region code: 200140
        /// </summary>
        [RegionCode(200140)] [I18NIdentityCode(Europe.Ukraine.I18N_IDENTITY_CODE)]
        UA,

        /// <summary>
        /// 乌干达（The Republic of Uganda，非洲，UG，UGA，800），乌干达共和国 <br />
        /// Cosmos i18n code: i18n_country_wuganda <br />
        /// Cosmos region code: 300154
        /// </summary>
        [RegionCode(300154)] [I18NIdentityCode(Africa.Uganda.I18N_IDENTITY_CODE)]
        UG,

        /// <summary>
        /// 美国本土外小岛屿（United States Minor Outlying Islands，北美洲，UM，UMI，581） <br />
        /// Cosmos i18n code: i18n_country_meiguoum <br />
        /// Cosmos region code: 400136
        /// </summary>
        [RegionCode(400136)] [I18NIdentityCode(NorthAmerica.UnitedStatesMinorOutlyingIslands.I18N_IDENTITY_CODE)]
        UM,

        /// <summary>
        /// 美国（United States of America，北美洲，US，USA，840），美利坚合众国 <br />
        /// Cosmos i18n code: i18n_country_meiguo <br />
        /// Cosmos region code: 400001
        /// </summary>
        [RegionCode(400001)] [I18NIdentityCode(NorthAmerica.UnitedStates.I18N_IDENTITY_CODE)]
        US,

        /// <summary>
        /// 乌拉圭（The Oriental Republic of Uruguay，南美洲，UY，URY，858），乌拉圭东岸共和国 <br />
        /// Cosmos i18n code: i18n_country_wulagui <br />
        /// Cosmos region code: 500112
        /// </summary>
        [RegionCode(500112)] [I18NIdentityCode(SouthAmerica.Uruguay.I18N_IDENTITY_CODE)]
        UY,

        /// <summary>
        /// 乌兹别克斯坦（The Republic Of Uzbekistan，亚洲，UZ，UZB，860），乌兹别克斯坦共和国 <br />
        /// Cosmos i18n code: i18n_country_wuzibiekesitan <br />
        /// Cosmos region code: 100141
        /// </summary>
        [RegionCode(100141)] [I18NIdentityCode(Asia.Uzbekistan.I18N_IDENTITY_CODE)]
        UZ,

        /// <summary>
        /// 梵蒂冈（Vatican City State，欧洲，VA，VAT，336），梵蒂冈城国 <br />
        /// Cosmos i18n code: i18n_country_fandigang <br />
        /// Cosmos region code: 200141
        /// </summary>
        [RegionCode(200141)] [I18NIdentityCode(Europe.Vatican.I18N_IDENTITY_CODE)]
        VA,

        /// <summary>
        /// 圣文森特和格林纳丁斯（Saint Vincent and the Grenadines，北美洲，VC，VCT，670） <br />
        /// Cosmos i18n code: i18n_country_shengwensenteglnds <br />
        /// Cosmos region code: 400133
        /// </summary>
        [RegionCode(400133)] [I18NIdentityCode(NorthAmerica.StVAndG.I18N_IDENTITY_CODE)]
        VC,

        /// <summary>
        /// 委内瑞拉（Bolivarian Republic of Venezuela，南美洲，VE，VEN，862），委内瑞拉玻利瓦尔共和国 <br />
        /// Cosmos i18n code: i18n_country_weineiruila <br />
        /// Cosmos region code: 500013
        /// </summary>
        [RegionCode(500013)] [I18NIdentityCode(SouthAmerica.Venezuela.I18N_IDENTITY_CODE)]
        VE,

        /// <summary>
        /// 维尔京群岛（The British Virgin Islands，北美洲，VG，VGB，092），英属维尔京群岛 <br />
        /// Cosmos i18n code: i18n_country_yingshuweierjing <br />
        /// Cosmos region code: 400137
        /// </summary>
        [RegionCode(400137)] [I18NIdentityCode(NorthAmerica.VirginIslandsBritish.I18N_IDENTITY_CODE)]
        VG,

        /// <summary>
        /// 美属维尔京群岛（The United States Virgin Islands，北美洲，VI，VIR，850） <br />
        /// Cosmos i18n code: i18n_country_meishuweierjing <br />
        /// Cosmos region code: 400138
        /// </summary>
        [RegionCode(400138)] [I18NIdentityCode(NorthAmerica.VirginIslandsUS.I18N_IDENTITY_CODE)]
        VI,

        /// <summary>
        /// 越南（Socialist Republic of Vietnam，亚洲，VN，VNM，704），越南社会主义共和国 <br />
        /// Cosmos i18n code: i18n_country_yuenan <br />
        /// Cosmos region code: 100018
        /// </summary>
        [RegionCode(100018)] [I18NIdentityCode(Asia.Vietnam.I18N_IDENTITY_CODE)]
        VN,

        /// <summary>
        /// 瓦努阿图（The Republic of Vanuatu，大洋洲，VU，VUT，548），瓦努阿图共和国 <br />
        /// Cosmos i18n code: i18n_country_wanuatu <br />
        /// Cosmos region code: 600123
        /// </summary>
        [RegionCode(600123)] [I18NIdentityCode(Oceania.Vanuatu.I18N_IDENTITY_CODE)]
        VU,

        /// <summary>
        /// 瓦利斯和富图纳群岛（Wallis and Futuna Islands，大洋洲，WF，WLF，876） <br />
        /// Cosmos i18n code: i18n_country_walisi <br />
        /// Cosmos region code: 600116
        /// </summary>
        [RegionCode(600116)] [I18NIdentityCode(Oceania.WallisAndFutuna.I18N_IDENTITY_CODE)]
        WF,

        /// <summary>
        /// 萨摩亚（The Independent State of Samoa，大洋洲，WS，WSM，882），萨摩亚独立国 <br />
        /// Cosmos i18n code: i18n_country_samoya <br />
        /// Cosmos region code: 600118
        /// </summary>
        [RegionCode(600118)] [I18NIdentityCode(Oceania.Samoa.I18N_IDENTITY_CODE)]
        WS,

        /// <summary>
        /// 科索沃（Kosovo，欧洲，XK，XKX，838），科索沃自治省 <br />
        /// Cosmos i18n code: i18n_country_kesuowo <br />
        /// Cosmos region code: 200120
        /// </summary>
        [RegionCode(200120)] [I18NIdentityCode(Europe.Kosovo.I18N_IDENTITY_CODE)]
        XK,

        /// <summary>
        /// 也门（The Republic Of Yemen，亚洲，YE，YEM，887），也门共和国 <br />
        /// Cosmos i18n code: i18n_country_yemen <br />
        /// Cosmos region code: 100142
        /// </summary>
        [RegionCode(100142)] [I18NIdentityCode(Asia.Yemen.I18N_IDENTITY_CODE)]
        YE,

        /// <summary>
        /// 马奥霍（Territorial Collectivity of Mayotte ，非洲，YT，MYT，004），马约特岛 <br />
        /// Cosmos i18n code: i18n_country_mayuete <br />
        /// Cosmos region code: 300138
        /// </summary>
        [RegionCode(300138)] [I18NIdentityCode(Africa.Mayotte.I18N_IDENTITY_CODE)]
        YT,

        //TODO 合并到 Historical 体系，从当前枚举中移除
        /// <summary>
        /// 南斯拉夫（Yugoslavia，欧洲，YU，YUG，38），南斯拉夫联盟共和国 <br />
        /// Cosmos i18n code: i18n_country_nlm_1992 <br />
        /// Cosmos region code: 220106
        /// </summary>
        [RegionCode(220106)] [I18NIdentityCode(Europe.Yugoslavia1992.I18N_IDENTITY_CODE)] [Obsolete]
        YU,

        /// <summary>
        /// 南非（The Republic of South Africa，非洲，ZA，ZAF，710），南非共和国 <br />
        /// Cosmos i18n code: i18n_country_nanfei <br />
        /// Cosmos region code: 300013
        /// </summary>
        [RegionCode(300013)] [I18NIdentityCode(Africa.SouthAfrica.I18N_IDENTITY_CODE)]
        ZA,

        /// <summary>
        /// 赞比亚（The Republic of Zambia，非洲，ZM，ZMB，894），赞比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_zanbiya <br />
        /// Cosmos region code: 300117
        /// </summary>
        [RegionCode(300117)] [I18NIdentityCode(Africa.Zambia.I18N_IDENTITY_CODE)]
        ZM,

        /// <summary>
        /// 津巴布韦（Zimbabwe，非洲，ZW，ZWE，716），津巴布韦共和国 <br />
        /// Cosmos i18n code: i18n_country_jinbabuwei <br />
        /// Cosmos region code: 300119
        /// </summary>
        [RegionCode(300119)] [I18NIdentityCode(Africa.Zimbabwe.I18N_IDENTITY_CODE)]
        ZW,
    }
}