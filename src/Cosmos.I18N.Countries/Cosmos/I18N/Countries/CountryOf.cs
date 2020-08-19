using System;

namespace Cosmos.I18N.Countries
{
    /// <summary>
    /// Country of...
    /// </summary>
    public static class CountryOf
    {
        #region Value

        public static CountryInfo Value(long regionCode) => CountryManager.GetCountryInfo(regionCode);
        public static CountryInfo Value(RegionCodeValue value) => CountryManager.GetCountryInfo(value);
        public static CountryInfo Value(Country country) => CountryManager.GetCountryInfo(country);
        public static CountryInfo Value(CountryCode code) => CountryManager.GetCountryInfo(code);
        public static CountryInfo Value(string alphaCode) => CountryManager.GetCountryInfo(alphaCode);

        #endregion

        #region Whole world

        /// <summary>
        /// 安道尔（Andorra，欧洲，AD，AND，020），安道尔共和国 <br />
        /// Cosmos i18n code: i18n_country_andaoer <br />
        /// Cosmos region code: 200103
        /// </summary>
        public static CountryInfo Andorra => Europe.Andorra.Instance;

        /// <summary>
        /// 阿富汗（Afghanistan，亚洲，AF，AFG，004），阿富汗伊斯兰国 <br />
        /// Cosmos i18n code: i18n_country_afuhan <br />
        /// Cosmos region code: 100101
        /// </summary>
        public static CountryInfo Afghanistan => Asia.Afghanistan.Instance;

        /// <summary>
        /// 阿尔及利亚（People's Democratic Republic of Algeria，非洲，DZ，DZA，012），阿尔及利亚民主人民共和国 <br />
        /// Cosmos i18n code: i18n_country_aerjiliya <br />
        /// Cosmos region code: 300101
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Algeria => Africa.Algeria.Instance;

        /// <summary>
        /// 安提瓜和巴布达（Antigua and Barbuda，北美洲，AG，ATG，028） <br />
        /// Cosmos i18n code: i18n_country_andaguababuda <br />
        /// Cosmos region code: 400103
        /// </summary>
        public static CountryInfo AntiguaAndBarbuda => NorthAmerica.AntiguaAndBarbuda.Instance;

        /// <summary>
        /// 安圭拉（Anguilla，北美洲，AI，AIA，660），英国海外领土 <br />
        /// Cosmos i18n code: i18n_country_anguila <br />
        /// Cosmos region code: 400102
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Anguilla => NorthAmerica.Anguilla.Instance;

        /// <summary>
        /// 阿尔巴尼亚（Albania，欧洲，AL，ALB，008），阿尔巴尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_aerbaniya <br />
        /// Cosmos region code: 200102
        /// </summary>
        public static CountryInfo Albania => Europe.Albania.Instance;

        /// <summary>
        /// 亚美尼亚（Armenia，亚洲，AM，ARM，051），亚美尼亚共和国<br />
        /// Cosmos i18n code: i18n_country_yameiniya<br />
        /// Cosmos region code: 100102
        /// </summary>
        public static CountryInfo Armenia => Asia.Armenia.Instance;

        /// <summary>
        /// 安哥拉（Angola，非洲，AO，AGO，024），安哥拉共和国 <br />
        /// Cosmos i18n code: i18n_country_angela <br />
        /// Cosmos region code: 300102
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Angola => Africa.Angola.Instance;

        /// <summary>
        /// 南极洲（Antarctica，南极洲，AQ，ATA，010）<br />
        /// 人类的净土 <br />
        /// Cosmos i18n code: i18n_country_nanji <br />
        /// Cosmos region code: 700010
        /// </summary>
        public static CountryInfo Antarctica => global::Cosmos.I18N.Countries.Antarctica.Antarctique.Instance;

        /// <summary>
        /// 南极洲（Antarctica，南极洲，AQ，ATA，010）<br />
        /// 人类的净土 <br />
        /// Cosmos i18n code: i18n_country_nanji <br />
        /// Cosmos region code: 700010
        /// </summary>
        public static CountryInfo Antarctique => global::Cosmos.I18N.Countries.Antarctica.Antarctique.Instance;

        /// <summary>
        /// 阿根廷（The Republic of Argentina，南美洲，AR，ARG，032），阿根廷共和国 <br />
        /// Cosmos i18n code: i18n_country_agenting <br />
        /// Cosmos region code: 500011
        /// </summary>
        public static CountryInfo Argentina => SouthAmerica.Argentina.Instance;

        /// <summary>
        /// 美属萨摩亚群岛（American Samoa，大洋洲，AS，ASM，016），阿根廷共和国 <br />
        /// 美属萨摩亚领地<br />
        /// Cosmos i18n code: i18n_country_ussamoya <br />
        /// Cosmos region code: 600101
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo AmericanSamoa => Oceania.AmericanSamoa.Instance;

        /// <summary>
        /// 奥地利（The Republic of Austria，欧洲，AT，AUT，040），奥地利共和国 <br />
        /// Cosmos i18n code: i18n_country_aodili <br />
        /// Cosmos region code: 200011
        /// </summary>
        public static CountryInfo Austria => Europe.Austria.Instance;

        /// <summary>
        /// 澳大利亚（The Commonwealth of Australia，大洋洲，AU，AUS，036），澳大利亚联邦 <br />
        /// Cosmos i18n code: i18n_country_aodaliya <br />
        /// Cosmos region code: 600011
        /// </summary>
        public static CountryInfo Australia => Oceania.Australia.Instance;

        /// <summary>
        /// 阿鲁巴（Aruba，北美洲，AW，ABW，533），荷兰海外属地 <br />
        /// Cosmos i18n code: i18n_country_aluba <br />
        /// Cosmos region code: 400104
        /// </summary>
        public static CountryInfo Aruba => NorthAmerica.Aruba.Instance;

        /// <summary>
        /// 奥兰群岛（Aland Island，欧洲，AX，ALA，248），奥兰自治省 <br />
        /// Cosmos i18n code: i18n_country_aolanqundao <br />
        /// Cosmos region code: 200101
        /// </summary>
        public static CountryInfo AlandIslands => Europe.AlandIslands.Instance;

        /// <summary>
        /// 阿塞拜疆（The Republic of Azerbaijan，亚洲，AZ，AZE，031），阿塞拜疆共和国 <br />
        /// Cosmos i18n code: i18n_country_asaibaijiang <br />
        /// Cosmos region code: 100103
        /// </summary>
        public static CountryInfo Azerbaijan => Asia.Azerbaijan.Instance;

        /// <summary>
        /// 波黑（Bosnia and Herzegovina，欧洲，BA，BIH，070），波斯尼亚和黑塞哥维那 <br />
        /// Cosmos i18n code: i18n_country_bohei <br />
        /// Cosmos region code: 200106
        /// </summary>
        public static CountryInfo BosniaAndHerzegovina => Europe.BosniaAndHerzegovina.Instance;

        /// <summary>
        /// 巴巴多斯（Barbados，北美洲，BB，BRB，052） <br />
        /// Cosmos i18n code: i18n_country_babaduosi <br />
        /// Cosmos region code: 400106
        /// </summary>
        public static CountryInfo Barbados => NorthAmerica.Barbados.Instance;

        /// <summary>
        /// 孟加拉国（People's Republic Of Bangladesh，亚洲，BD，BGD，050），孟加拉人民共和国 <br />
        /// Cosmos i18n code: i18n_country_mengjiala <br />
        /// Cosmos region code: 100105
        /// </summary>
        public static CountryInfo Bangladesh => Asia.Bangladesh.Instance;

        /// <summary>
        /// 比利时（The Kingdom of Belgium，欧洲，BE，BEL，056），比利时王国 <br />
        /// Cosmos i18n code: i18n_country_bilishi <br />
        /// Cosmos region code: 200105
        /// </summary>
        public static CountryInfo Belgium => Europe.Belgium.Instance;

        /// <summary>
        /// 布基纳法索（Burkina Faso，非洲，BF，BFA，854） <br />
        /// Cosmos i18n code: i18n_country_bujinafaso <br />
        /// Cosmos region code: 300105
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo BurkinaFaso => Africa.BurkinaFaso.Instance;

        /// <summary>
        /// 保加利亚（The Republic of Bulgaria，欧洲，BG，BRN，096），保加利亚共和国 <br />
        /// Cosmos i18n code: i18n_country_baojialiya <br />
        /// Cosmos region code: 200108
        /// </summary>
        public static CountryInfo Bulgaria => Europe.Bulgaria.Instance;

        /// <summary>
        /// 巴林（The Kingdom of Bahrain ，亚洲，BH，BHR，048），巴林王国 <br />
        /// Cosmos i18n code: i18n_country_balin <br />
        /// Cosmos region code: 100104
        /// </summary>
        public static CountryInfo Bahrain => Asia.Bahrain.Instance;

        /// <summary>
        /// 布隆迪（The Republic of Burundi，非洲，BI，BDI，108），布隆迪共和国 <br />
        /// Cosmos i18n code: i18n_country_bulongdi <br />
        /// Cosmos region code: 300107
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Burundi => Africa.Burundi.Instance;

        /// <summary>
        /// 贝宁（The Republic of Benin，非洲，BJ，BEN，204），贝宁共和国 <br />
        /// Cosmos i18n code: i18n_country_beining <br />
        /// Cosmos region code: 300103
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Benin => Africa.Benin.Instance;

        /// <summary>
        /// 百慕大（The Bermuda Islands，北美洲，BM，BMU，060），百慕大群岛 <br />
        /// 旧称萨摩斯岛，隶属于大不列颠及北爱尔兰联合王国的海外自治领 <br />
        /// Cosmos i18n code: i18n_country_baimuda <br />
        /// Cosmos region code: 400108
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Bermuda => NorthAmerica.Bermuda.Instance;

        /// <summary>
        /// 文莱 （Negara Brunei Darussalam，亚洲，BN，BRN，096），文莱达鲁萨兰国 <br />
        /// Cosmos i18n code: i18n_country_wenlai <br />
        /// Cosmos region code: 100108
        /// </summary>
        public static CountryInfo Brunei => Asia.Brunei.Instance;

        /// <summary>
        /// 玻利维亚（Plurinational State of Bolivia，南美洲，BO，BOL，068），多民族玻利维亚国 <br />
        /// Cosmos i18n code: i18n_country_boliweiya <br />
        /// Cosmos region code: 500101
        /// </summary>
        public static CountryInfo Bolivia => SouthAmerica.Bolivia.Instance;

        /// <summary>
        /// 波内赫、圣尤斯特歇斯和萨巴（Bonaire, Sint Eustatius and Saba，北美洲，BQ，BES，535） <br />
        /// Cosmos i18n code: i18n_country_boneihe <br />
        /// Cosmos region code: 400109
        /// </summary>
        public static CountryInfo Bonaire => NorthAmerica.Bonaire.Instance;

        /// <summary>
        /// 巴西（The Federative Republic of Brazil，南美洲，BR，BRA，076），巴西联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_baxi <br />
        /// Cosmos region code: 500001
        /// </summary>
        public static CountryInfo Brazil => SouthAmerica.Brazil.Instance;

        /// <summary>
        /// 巴哈马（Commonwealth of the Bahamas，北美洲，BS，BHS，044），巴哈马国 <br />
        /// Cosmos i18n code: i18n_country_bahama <br />
        /// Cosmos region code: 400105
        /// </summary>
        public static CountryInfo Bahamas => NorthAmerica.Bahamas.Instance;

        /// <summary>
        /// 不丹（Kingdom of Bhutan，亚洲，BT，BTN，064），不丹王国 <br />
        /// Cosmos i18n code: i18n_country_budan <br />
        /// Cosmos region code: 100106
        /// </summary>
        public static CountryInfo Bhutan => Asia.Bhutan.Instance;

        /// <summary>
        /// 布韦岛（Bouvet Island，欧洲，BV，BVT，074） <br />
        /// Cosmos i18n code: i18n_country_buweidao <br />
        /// Cosmos region code: 200107
        /// </summary>
        public static CountryInfo BouvetIsland => Europe.BouvetIsland.Instance;

        /// <summary>
        /// 博茨瓦纳（The Republic of Botswana，非洲，BW，BWA，072），博茨瓦纳共和国 <br />
        /// Cosmos i18n code: i18n_country_boziwana <br />
        /// Cosmos region code: 300104
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Botswana => Africa.Botswana.Instance;

        /// <summary>
        /// 白俄罗斯（Republic of Belarus，欧洲，BY，BLR，112），白俄罗斯共和国 <br />
        /// Cosmos i18n code: i18n_country_baieluosi <br />
        /// Cosmos region code: 200104
        /// </summary>
        public static CountryInfo Belarus => Europe.Belarus.Instance;

        /// <summary>
        /// 伯利兹（Belize，北美洲，BZ，BLZ，084） <br />
        /// Cosmos i18n code: i18n_country_bolizi <br />
        /// Cosmos region code: 400107
        /// </summary>
        public static CountryInfo Belize => NorthAmerica.Belize.Instance;

        /// <summary>
        /// 喀麦隆（Republic of Cameroon，非洲，CM，CRM，120），喀麦隆共和国 <br />
        /// Cosmos i18n code: i18n_country_kamailong <br />
        /// Cosmos region code: 300108
        /// </summary>
        public static CountryInfo Cameroun => Africa.Cameroun.Instance;

        /// <summary>
        /// 佛得角（Republic of Cape Verde，非洲，CV，CPV，132），佛得角共和国 <br />
        /// Cosmos i18n code: i18n_country_fodejiao <br />
        /// Cosmos region code: 300106
        /// </summary>
        public static CountryInfo CapeVerde => Africa.CapeVerde.Instance;

        /// <summary>
        /// 加拿大（Canada，北美洲，CA，CAN，124），英联邦成员国 <br />
        /// Cosmos i18n code: i18n_country_jianada <br />
        /// Cosmos region code: 400011
        /// </summary>
        public static CountryInfo Canada => NorthAmerica.Canada.Instance;

        /// <summary>
        /// 中非（Central African Republic，非洲，CF，COD，180），中非共和国 <br />
        /// Cosmos i18n code: i18n_country_zhongfei <br />
        /// Cosmos region code: 300109
        /// </summary>
        public static CountryInfo CentralAfrican => Africa.CentralAfrican.Instance;

        /// <summary>
        /// 中国（People's Republic of China，亚洲，CN，CNH，156），中华人民共和国 <br />
        /// Cosmos i18n code: i18n_country_china <br />
        /// Cosmos region code: 100001
        /// </summary>
        public static CountryInfo China => Asia.China.Instance;

        /// <summary>
        /// 智利（Republic of Chile，南美洲，CL，CHL，152），智利共和国 <br />
        /// Cosmos i18n code: i18n_country_zhili <br />
        /// Cosmos region code: 500012
        /// </summary>
        public static CountryInfo Chile => SouthAmerica.Chile.Instance;

        /// <summary>
        /// 科科斯群岛（Cocos Islands，亚洲，CC，CCK，166） <br />
        /// Cosmos i18n code: i18n_country_kekesi <br />
        /// Cosmos region code: 100111
        /// </summary>
        public static CountryInfo CocosIslands => Asia.CocosIslands.Instance;

        /// <summary>
        /// 哥伦比亚（The Republic of Colombia，南美洲，CO，COL，170），哥伦比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_gelunbiya <br />
        /// Cosmos region code: 500102
        /// </summary>
        public static CountryInfo Colombia => SouthAmerica.Colombia.Instance;

        /// <summary>
        /// 刚果（布）（The Republic of Congo，非洲，CG，COG，178），刚果共和国 <br />
        /// Cosmos i18n code: i18n_country_gangguobu <br />
        /// Cosmos region code: 300112
        /// </summary>
        public static CountryInfo CongoBrazzaville => Africa.CongoBrazzaville.Instance;

        /// <summary>
        /// 刚果（金）（The Democratic Republic of the Congo，非洲，CD，CAF，140），刚果民主共和国 <br />
        /// Cosmos i18n code: i18n_country_gangguojin <br />
        /// Cosmos region code: 300113
        /// </summary>
        public static CountryInfo CongoKinshasa => Africa.CongoKinshasa.Instance;

        /// <summary>
        /// 库克群岛（The Cook Islands，非洲，CK，COK，184） <br />
        /// Cosmos i18n code: i18n_country_kukequndao <br />
        /// Cosmos region code: 600102
        /// </summary>
        public static CountryInfo CookIslands => Oceania.CookIslands.Instance;

        /// <summary>
        /// 哥斯达黎加（The Republic of Costa Rica，北美洲，CR，CRI，188），哥斯达黎加共和国 <br />
        /// Cosmos i18n code: i18n_country_gesidalijia <br />
        /// Cosmos region code: 400111
        /// </summary>
        public static CountryInfo CostaRica => NorthAmerica.CostaRica.Instance;

        /// <summary>
        /// 科特迪瓦 （The Republic of Côte d'Ivoire，非洲，CI，CIV，384），科特迪瓦共和国 <br />
        /// Cosmos i18n code: i18n_country_ketediwa<br />
        /// Cosmos region code: 300114
        /// </summary>
        public static CountryInfo CotedIvoire => Africa.CotedIvoire.Instance;

        /// <summary>
        /// 古巴（The Republic of Cuba，北美洲，CU，CUB，192），古巴共和国 <br />
        /// Cosmos i18n code: i18n_country_guba <br />
        /// Cosmos region code: 400101
        /// </summary>
        public static CountryInfo Cuba => NorthAmerica.Cuba.Instance;

        /// <summary>
        /// 库拉索（Curaçao，北美洲，CW，CUW，531） <br />
        /// Cosmos i18n code: i18n_country_kusuola <br />
        /// Cosmos region code: 400112
        /// </summary>
        public static CountryInfo Curaçao => NorthAmerica.Curaçao.Instance;

        /// <summary>
        /// 圣诞岛（Christmas Island，亚洲，CX，CXR，162） <br />
        /// Cosmos i18n code: i18n_country_balin <br />
        /// Cosmos region code: 100110
        /// </summary>
        public static CountryInfo ChristmasIsland => Asia.ChristmasIsland.Instance;

        /// <summary>
        /// 塞浦路斯（The Republic of Cyprus，亚洲，CY，CYP，196），塞浦路斯共和国 <br />
        /// Cosmos i18n code: i18n_country_saipulusi <br />
        /// Cosmos region code: 100112
        /// </summary>
        public static CountryInfo Cyprus => Asia.Cyprus.Instance;

        /// <summary>
        /// 捷克（The Czech Republic，欧洲，CZ，CZE，203），捷克共和国 <br />
        /// Cosmos i18n code: i18n_country_jieke <br />
        /// Cosmos region code: 200012
        /// </summary>
        public static CountryInfo Czechia => Europe.Czechia.Instance;

        /// <summary>
        /// 丹麦（The Kingdom of Denmark，欧洲，DK，DNK，208），丹麦王国 <br />
        /// Cosmos i18n code: i18n_country_danmai <br />
        /// Cosmos region code: 200110
        /// </summary>
        public static CountryInfo Denmark => Europe.Denmark.Instance;

        /// <summary>
        /// 多米尼克（The Commonwealth of Dominica，北美洲，DM，DMA，212），多米尼克国 <br />
        /// Cosmos i18n code: i18n_country_duominike <br />
        /// Cosmos region code: 400113
        /// </summary>
        public static CountryInfo Dominica => NorthAmerica.Dominica.Instance;

        /// <summary>
        /// 多米尼加（The Dominican Republic，北美洲，DO，DOM，214），多米尼加共和国 <br />
        /// Cosmos i18n code: i18n_country_duominijia <br />
        /// Cosmos region code: 400114
        /// </summary>
        public static CountryInfo Dominican => NorthAmerica.Dominican.Instance;

        /// <summary>
        /// 吉布提（The Republic of Djibouti，亚洲，BI，BDI，108），吉布提共和国 <br />
        /// Cosmos i18n code: i18n_country_balin <br />
        /// Cosmos region code: 100113
        /// </summary>
        public static CountryInfo Djibouti => Asia.Djibouti.Instance;

        /// <summary>
        /// 厄瓜多尔（The Republic of Ecuador，南美洲，EC，ECU，218），厄瓜多尔共和国 <br />
        /// Cosmos i18n code: i18n_country_eguaduoer <br />
        /// Cosmos region code: 500103
        /// </summary>
        public static CountryInfo Ecuador => SouthAmerica.Ecuador.Instance;

        /// <summary>
        /// 爱沙尼亚（Republic of Estonia，欧洲，EE，EST，233），爱沙尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_aishaniya <br />
        /// Cosmos region code: 200111
        /// </summary>
        public static CountryInfo Estonia => Europe.Estonia.Instance;

        /// <summary>
        /// 埃及（The Arab Republic of Egypt，非洲，EG，EGY，818），阿拉伯埃及共和国 <br />
        /// Cosmos i18n code: i18n_country_aiji <br />
        /// Cosmos region code: 300011
        /// </summary>
        public static CountryInfo Egypt => Africa.Egypt.Instance;

        /// <summary>
        /// 厄立特里亚（The State of Eritrea，非洲，ER，ERI，232），厄立特里亚国 <br />
        /// Cosmos i18n code: i18n_country_aliteliya <br />
        /// Cosmos region code: 300116
        /// </summary>
        public static CountryInfo Eritrea => Africa.Eritrea.Instance;

        /// <summary>
        /// 埃塞俄比亚（The Federal Democratic Republic of Ethiopia，非洲，ET，ETH，231），埃塞俄比亚联邦民主共和国 <br />
        /// Cosmos i18n code: i18n_country_aisaiebiya <br />
        /// Cosmos region code: 300123
        /// </summary>
        public static CountryInfo Ethiopia => Africa.Ethiopia.Instance;

        /// <summary>
        /// 斐济（The Republic of Fiji，大洋洲，FJ，FJI，242），斐济共和国 <br />
        /// Cosmos i18n code: i18n_country_feiji <br />
        /// Cosmos region code: 600103
        /// </summary>
        public static CountryInfo Fiji => Oceania.Fiji.Instance;

        /// <summary>
        /// 马尔维纳斯群岛（Falkland Islands，南美洲，FK，FLK，238） <br />
        /// Cosmos i18n code: i18n_country_fukelan <br />
        /// Cosmos region code: 500104
        /// </summary>
        public static CountryInfo FalklandIslands => SouthAmerica.FalklandIslands.Instance;

        /// <summary>
        /// 芬兰（The Republic of Finland，欧洲，FI，FIN，246），芬兰共和国 <br />
        /// Cosmos i18n code: i18n_country_fenlan <br />
        /// Cosmos region code: 200113
        /// </summary>
        public static CountryInfo Finland => Europe.Finland.Instance;

        /// <summary>
        /// 法国（French Republic，欧洲，FR，FRA，250），法兰西共和国 <br />
        /// Cosmos i18n code: i18n_country_faguo <br />
        /// Cosmos region code: 200001
        /// </summary>
        public static CountryInfo France => Europe.France.Instance;

        /// <summary>
        /// 法罗群岛（Faroe Islands，欧洲，FO，FRO，234） <br />
        /// Cosmos i18n code: i18n_country_faluo <br />
        /// Cosmos region code: 200112
        /// </summary>
        public static CountryInfo Faroe => Europe.Faroe.Instance;

        /// <summary>
        /// 加蓬（The Gabonese Republic，非洲，GA，GAB，266），加蓬共和国 <br />
        /// Cosmos i18n code: i18n_country_jiapeng <br />
        /// Cosmos region code: 300126
        /// </summary>
        public static CountryInfo Gabon => Africa.Gabon.Instance;

        /// <summary>
        /// 德国（The Federal Republic of Germany，欧洲，DE，DEU，276），德意志联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_deguo <br />
        /// Cosmos region code: 200002
        /// </summary>
        public static CountryInfo Germany => Europe.Germany.Instance;

        /// <summary>
        /// 格林纳达（Grenada，北美洲，GD，GRD，308） <br />
        /// Cosmos i18n code: i18n_country_gelinnada <br />
        /// Cosmos region code: 400117
        /// </summary>
        public static CountryInfo Grenada => NorthAmerica.Grenada.Instance;

        /// <summary>
        /// 格鲁吉亚（Georgia，亚洲，GE，GEO，268） <br />
        /// Cosmos i18n code: i18n_country_gelujiya <br />
        /// Cosmos region code: 100115
        /// </summary>
        public static CountryInfo Georgia => Asia.Georgia.Instance;

        /// <summary>
        /// 法属圭亚那（Guyane Francaise，南美洲，GF，GUF，254） <br />
        /// Cosmos i18n code: i18n_country_guiyana <br />
        /// Cosmos region code: 500105
        /// </summary>
        public static CountryInfo Guiana => SouthAmerica.Guiana.Instance;

        /// <summary>
        /// 根西岛（Bailiwick of Guernsey，欧洲，GG，GGY，831） <br />
        /// Cosmos i18n code: i18n_country_genxidao <br />
        /// Cosmos region code: 200116
        /// </summary>
        public static CountryInfo Guernsey => Europe.Guernsey.Instance;

        /// <summary>
        /// 加纳（The Republic of Ghana，非洲，GH，GHA，288），加纳共和国 <br />
        /// Cosmos i18n code: i18n_country_jiana <br />
        /// Cosmos region code: 300127
        /// </summary>
        public static CountryInfo Ghana => Africa.Ghana.Instance;

        /// <summary>
        /// 直布罗陀（Gibraltar，欧洲，GI，GIB，292） <br />
        /// Cosmos i18n code: i18n_country_zhibuluotuo <br />
        /// Cosmos region code: 200114
        /// </summary>
        public static CountryInfo Gibraltar => Europe.Gibraltar.Instance;

        /// <summary>
        /// 格陵兰岛（Greenland，北美洲，GL，GRL，304） <br />
        /// Cosmos i18n code: i18n_country_gelinlan <br />
        /// Cosmos region code: 400116
        /// </summary>
        public static CountryInfo Greenland => NorthAmerica.Greenland.Instance;

        /// <summary>
        /// 冈比亚（Republic of The Gambia，非洲，GM，GMB，270），冈比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_gangbiya <br />
        /// Cosmos region code: 300128
        /// </summary>
        public static CountryInfo Gambia => Africa.Gambia.Instance;

        /// <summary>
        /// 几内亚（The Republic of Guinea，非洲，GN，GIN，324），几内亚共和国 <br />
        /// Cosmos i18n code: i18n_country_jineiya <br />
        /// Cosmos region code: 300129
        /// </summary>
        public static CountryInfo Guinea => Africa.Guinea.Instance;

        /// <summary>
        /// 赤道几内亚（The Republic of Equatorial Guinea，非洲，GQ，GNQ，226），赤道几内亚共和国 <br />
        /// Cosmos i18n code: i18n_country_chidaojineiya <br />
        /// Cosmos region code: 300115
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo EquatorialGuinea => Africa.EquatorialGuinea.Instance;

        /// <summary>
        /// 瓜德罗普（Guadeloupe，北美洲，GP，GLP，312） <br />
        /// Cosmos i18n code: i18n_country_guadeluopu <br />
        /// Cosmos region code: 400118
        /// </summary>
        public static CountryInfo Guadeloupe => NorthAmerica.Guadeloupe.Instance;

        /// <summary>
        /// 危地马拉（The Republic of Guatemala，北美洲，GT，GTM，320），危地马拉共和国 <br />
        /// Cosmos i18n code: i18n_country_weidimala <br />
        /// Cosmos region code: 400119
        /// </summary>
        public static CountryInfo Guatemala => NorthAmerica.Guatemala.Instance;

        /// <summary>
        /// 关岛（The Territory of Guam，大洋洲，GU，GUM，316） <br />
        /// Cosmos i18n code: i18n_country_guandao <br />
        /// Cosmos region code: 600104
        /// </summary>
        public static CountryInfo Guam => Oceania.Guam.Instance;

        /// <summary>
        /// 几内亚比绍（The Republic of Guinea-Bissau，非洲，GW，GNB，624），几内亚比绍共和国 <br />
        /// Cosmos i18n code: i18n_country_jineiyabishao <br />
        /// Cosmos region code: 300130
        /// </summary>
        public static CountryInfo GuineaBissau => Africa.GuineaBissau.Instance;

        /// <summary>
        /// 希腊（The Republic of Greece，欧洲，GR，GRC，300），希腊共和国 <br />
        /// Cosmos i18n code: i18n_country_xila <br />
        /// Cosmos region code: 200115
        /// </summary>
        public static CountryInfo Greece => Europe.Greece.Instance;

        /// <summary>
        /// 圭亚那（Cooperative Republic of Guyana，南美洲，GY，GUY，328），圭亚那合作共和国 <br />
        /// Cosmos i18n code: i18n_country_guiyana <br />
        /// Cosmos region code: 500106
        /// </summary>
        public static CountryInfo Guyana => SouthAmerica.Guyana.Instance;

        /// <summary>
        /// 克罗地亚（Republic of Croatia，欧洲，HR，HRV，191），克罗地亚共和国 <br />
        /// Cosmos i18n code: i18n_country_keluodiya <br />
        /// Cosmos region code: 200109
        /// </summary>
        public static CountryInfo Croatia => Europe.Croatia.Instance;

        /// <summary>
        /// 海地（The Republic of Haiti，北美洲，HT，HTI，332），海地共和国 <br />
        /// Cosmos i18n code: i18n_country_haidi <br />
        /// Cosmos region code: 400120
        /// </summary>
        public static CountryInfo Haiti => NorthAmerica.Haiti.Instance;

        /// <summary>
        /// 赫德岛和麦克唐纳群岛（Heard Island and McDonald Islands，亚洲，HM，HMD，334） <br />
        /// Cosmos i18n code: i18n_country_hedemaiketang <br />
        /// Cosmos region code: 100116
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public static CountryInfo HIMI => Asia.HIMI.Instance;

        /// <summary>
        /// 洪都拉斯（The Republic of Honduras，南美洲，HN，HND，340），洪都拉斯共和国 <br />
        /// Cosmos i18n code: i18n_country_hongdulasi <br />
        /// Cosmos region code: 500107
        /// </summary>
        public static CountryInfo Honduras => SouthAmerica.Honduras.Instance;

        /// <summary>
        /// 匈牙利（Hungary，欧洲，HU，HUN，348） <br />
        /// Cosmos i18n code: i18n_country_xiongyali<br />
        /// Cosmos region code: 200013
        /// </summary>
        public static CountryInfo Hungary => Europe.Hungary.Instance;

        /// <summary>
        /// 香港（Hong Kong, SAR China，亚洲，HK，HKG，344），中华人民共和国香港特别行政区 <br />
        /// 香港，中华人民共和国的一部分 <br />
        /// Hong Kong, a part of China <br />
        /// Cosmos i18n code: i18n_country_xianggang <br />
        /// Cosmos region code: 1000010033
        /// </summary>
        public static CountryInfo HongKong => Asia.HongKong.Instance;

        /// <summary>
        /// 梵蒂冈（Vatican City State，欧洲，VA，VAT，336），梵蒂冈城国 <br />
        /// Cosmos i18n code: i18n_country_fandigang <br />
        /// Cosmos region code: 200141
        /// </summary>
        public static CountryInfo Vatican => Europe.Vatican.Instance;

        /// <summary>
        /// 印度尼西亚（The Republic of Indonesia，亚洲，ID，IDN，360），印度尼西亚共和国 <br />
        /// Cosmos i18n code: i18n_country_yindunixiya <br />
        /// Cosmos region code: 100116
        /// </summary>
        public static CountryInfo Indonesia => Asia.Indonesia.Instance;

        /// <summary>
        /// 爱尔兰（Republic of Ireland，欧洲，IE，IRL，372），爱尔兰共和国 <br />
        /// Cosmos i18n code: i18n_country_aierlan <br />
        /// Cosmos region code: 200117
        /// </summary>
        public static CountryInfo Ireland => Europe.Ireland.Instance;

        /// <summary>
        /// 以色列（The State of Israel，亚洲，IL，ISR，376），以色列国 <br />
        /// Cosmos i18n code: i18n_country_yiselie <br />
        /// Cosmos region code: 100015
        /// </summary>
        public static CountryInfo Israel => Asia.Israel.Instance;

        /// <summary>
        /// 印度（Republic of India，亚洲，IN，IND，356），印度共和国 <br />
        /// Cosmos i18n code: i18n_country_yindu <br />
        /// Cosmos region code: 100013
        /// </summary>
        public static CountryInfo India => Asia.India.Instance;

        /// <summary>
        /// 英属印度洋领地（British Indian Ocean Territory，亚洲，IO，IOT，086） <br />
        /// Cosmos i18n code: i18n_country_yingshuying <br />
        /// Cosmos region code: 100107
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo BritishIndianOceanTerritory => Asia.BritishIndianOceanTerritory.Instance;

        /// <summary>
        /// 伊拉克（Republic Of Iraq，亚洲，IQ，IRQ，368），伊拉克共和国 <br />
        /// Cosmos i18n code: i18n_country_yilake <br />
        /// Cosmos region code: 100117
        /// </summary>
        public static CountryInfo Iraq => Asia.Iraq.Instance;

        /// <summary>
        /// 伊朗（The Islamic Republic of Iran，亚洲，IR，IRN，364），伊朗伊斯兰共和国 <br />
        /// Cosmos i18n code: i18n_country_yilang<br />
        /// Cosmos region code: 100014
        /// </summary>
        public static CountryInfo Iran => Asia.Iran.Instance;

        /// <summary>
        /// 冰岛（The Republic of Iceland，欧洲，IS，ISL，352），冰岛共和国 <br />
        /// Cosmos i18n code: i18n_country_bingdao <br />
        /// Cosmos region code: 200118
        /// </summary>
        public static CountryInfo Iceland => Europe.Iceland.Instance;

        /// <summary>
        /// 意大利（The Republic of Italy，欧洲，IT，ITA，380），意大利共和国 <br />
        /// Cosmos i18n code: i18n_country_yidali <br />
        /// Cosmos region code: 200003
        /// </summary>
        public static CountryInfo Italy => Europe.Italy.Instance;

        /// <summary>
        /// 日本（Japan，亚洲，JP，JPN，392），日本国 <br />
        /// Cosmos i18n code: i18n_country_riben <br />
        /// Cosmos region code: 100002
        /// </summary>
        public static CountryInfo Japan => Asia.Japan.Instance;

        /// <summary>
        /// 泽西（Bailiwick of Jersey，欧洲，JE，JEY，832），泽西岛 <br />
        /// Cosmos i18n code: i18n_country_zexi <br />
        /// Cosmos region code: 200119
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Jersey => Europe.Jersey.Instance;

        /// <summary>
        /// 牙买加（Jamaica，北美洲，JM，JAM，388） <br />
        /// Cosmos i18n code: i18n_country_yamaijia <br />
        /// Cosmos region code: 400121
        /// </summary>
        public static CountryInfo Jamaica => NorthAmerica.Jamaica.Instance;

        /// <summary>
        /// 约旦（The Hashemite Kingdom of Jordan，亚洲，JO，JOR，400），约旦哈希姆王国 <br />
        /// Cosmos i18n code: i18n_country_yuedan <br />
        /// Cosmos region code: 100118
        /// </summary>
        public static CountryInfo Jordan => Asia.Jordan.Instance;

        /// <summary>
        /// 肯尼亚（The Republic Of Kenya，非洲，KE，KEN，404），肯尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_kenniya <br />
        /// Cosmos region code: 300012
        /// </summary>
        public static CountryInfo Kenya => Africa.Kenya.Instance;

        /// <summary>
        /// 基里巴斯（The Republic of Kiribati，大洋洲，KI，KIR，296），基里巴斯共和国 <br />
        /// Cosmos i18n code: i18n_country_jilibasi <br />
        /// Cosmos region code: 600105
        /// </summary>
        public static CountryInfo Kiribati => Oceania.Kiribati.Instance;

        /// <summary>
        /// 科摩罗（Union of Comoros，非洲，KM，COM，174），科摩罗联盟 <br />
        /// Cosmos i18n code: i18n_country_kemoluo <br />
        /// Cosmos region code: 300111
        /// </summary>
        public static CountryInfo Comoros => Africa.Comoros.Instance;

        /// <summary>
        /// 圣基茨和尼维斯（The Federation of Saint Kitts and Nevis，北美洲，KN，KNA，659），圣基茨和尼维斯联邦 <br />
        /// Cosmos i18n code: i18n_country_shengjiciniweisi <br />
        /// Cosmos region code: 400128
        /// </summary>
        public static CountryInfo SaintKittsAndNevis => NorthAmerica.SaintKittsAndNevis.Instance;

        /// <summary>
        /// 韩国（Republic Of Korea，亚洲，KR，KOR，410），大韩民国 <br />
        /// Cosmos i18n code: i18n_country_hanguo <br />
        /// Cosmos region code: 100012
        /// </summary>
        public static CountryInfo SouthKorea => Asia.SouthKorea.Instance;

        /// <summary>
        /// 朝鲜（Democratic People's Republic of Korea，亚洲，KP，PRK，408），朝鲜民主主义人民共和国 <br />
        /// Cosmos i18n code: i18n_country_chaoxian <br />
        /// Cosmos region code: 100011
        /// </summary>
        public static CountryInfo NorthKorea => Asia.NorthKorea.Instance;

        /// <summary>
        /// 科威特（The State of Kuwait，亚洲，KW，KWT，414），科威特国 <br />
        /// Cosmos i18n code: i18n_country_keweite <br />
        /// Cosmos region code: 100120
        /// </summary>
        public static CountryInfo Kuwait => Asia.Kuwait.Instance;

        /// <summary>
        /// 开曼群岛（Cayman Islands，北美洲，KY，CYM，136） <br />
        /// Cosmos i18n code: i18n_country_kaiman <br />
        /// Cosmos region code: 400110
        /// </summary>
        public static CountryInfo CaymanIslands => NorthAmerica.CaymanIslands.Instance;

        /// <summary>
        /// 哈萨克斯坦（ The Republic of Kazakhstan，亚洲，KZ，KAZ，398），哈萨克斯坦共和国 <br />
        /// Cosmos i18n code: i18n_country_hasakesitan <br />
        /// Cosmos region code: 100119
        /// </summary>
        public static CountryInfo Kazakhstan => Asia.Kazakhstan.Instance;

        /// <summary>
        /// 吉尔吉斯斯坦（The Kyrgyz Republic/Kyrgyzstan，亚洲，KG，KGZ，417），吉尔吉斯共和国 <br />
        /// Cosmos i18n code: i18n_country_jierjisi <br />
        /// Cosmos region code: 100121
        /// </summary>
        public static CountryInfo Kyrgyzstan => Asia.Kyrgyzstan.Instance;

        /// <summary>
        /// 柬埔寨（The Kingdom of Cambodia，亚洲，KH，KHM，116），柬埔寨王国 <br />
        /// Cosmos i18n code: i18n_country_jipuzhai <br />
        /// Cosmos region code: 100109
        /// </summary>
        public static CountryInfo Cambodia => Asia.Cambodia.Instance;

        /// <summary>
        /// 老挝（Lao People's Democratic Republic，亚洲，LA，LAO，418），老挝人民民主共和国 <br />
        /// Cosmos i18n code: i18n_country_laowo <br />
        /// Cosmos region code: 100122
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public static CountryInfo LaoPDR => Asia.LaoPDR.Instance;

        /// <summary>
        /// 黎巴嫩（The Republic of Lebanon，亚洲，LB，LBN，422），黎巴嫩共和国 <br />
        /// Cosmos i18n code: i18n_country_libanen <br />
        /// Cosmos region code: 100123
        /// </summary>
        public static CountryInfo Lebanon => Asia.Lebanon.Instance;

        /// <summary>
        /// 圣卢西亚（Republic Of Iraq，北美洲，LC，LCA，662） <br />
        /// Cosmos i18n code: i18n_country_shengluxiya <br />
        /// Cosmos region code: 400129
        /// </summary>
        public static CountryInfo SaintLucia => NorthAmerica.SaintLucia.Instance;

        /// <summary>
        /// 列支敦士登（Principality of Liechtenstein，欧洲，LI，LIE，438），列支敦士登公国 <br />
        /// Cosmos i18n code: i18n_country_liezhidunshideng <br />
        /// Cosmos region code: 200122
        /// </summary>
        public static CountryInfo Liechtenstein => Europe.Liechtenstein.Instance;

        /// <summary>
        /// 斯里兰卡（The Democratic Socialist Republic of Sri Lanka，亚洲，LK，LKA，144），斯里兰卡民主社会主义共和国 <br />
        /// Cosmos i18n code: i18n_country_sililanka <br />
        /// Cosmos region code: 100135
        /// </summary>
        public static CountryInfo SriLanka => Asia.SriLanka.Instance;

        /// <summary>
        /// 利比里亚（Republic Of Liberia，非洲，LR，LBR，430），利比里亚共和国 <br />
        /// Cosmos i18n code: i18n_country_libiliya<br />
        /// Cosmos region code: 300132
        /// </summary>
        public static CountryInfo Liberia => Africa.Liberia.Instance;

        /// <summary>
        /// 莱索托（Kingdom of Lesotho，非洲，LS，LSO，426），莱索托王国 <br />
        /// Cosmos i18n code: i18n_country_laisuotuo <br />
        /// Cosmos region code: 300131
        /// </summary>
        public static CountryInfo Lesotho => Africa.Lesotho.Instance;

        /// <summary>
        /// 立陶宛（The Republic of Lithuania，欧洲，LT，LTU，440），立陶宛共和国 <br />
        /// Cosmos i18n code: i18n_country_litaowan <br />
        /// Cosmos region code: 200123
        /// </summary>
        public static CountryInfo Lithuania => Europe.Lithuania.Instance;

        /// <summary>
        /// 卢森堡（The Grand Duchy of Luxembourg，欧洲，LU，LUX，442），卢森堡大公国 <br />
        /// Cosmos i18n code: i18n_country_lusenbao <br />
        /// Cosmos region code: 200124
        /// </summary>
        public static CountryInfo Luxembourg => Europe.Luxembourg.Instance;

        /// <summary>
        /// 拉脱维亚（The Republic of Latvia，欧洲，LV，LVA，428），拉脱维亚共和国 <br />
        /// Cosmos i18n code: i18n_country_latuoweiya <br />
        /// Cosmos region code: 200121
        /// </summary>
        public static CountryInfo Latvia => Europe.Latvia.Instance;

        /// <summary>
        /// 利比亚（State of Libya，非洲，LY，LBY，434），利比亚国 <br />
        /// Cosmos i18n code: i18n_country_libiya <br />
        /// Cosmos region code: 300133
        /// </summary>
        public static CountryInfo Libya => Africa.Libya.Instance;

        /// <summary>
        /// 马恩岛（Isle of Man，欧洲，IM，IMN，833），英属马恩岛 <br />
        /// Cosmos i18n code: i18n_country_maendao <br />
        /// Cosmos region code: 200127
        /// </summary>
        public static CountryInfo Mann => Europe.Mann.Instance;

        /// <summary>
        /// 澳门（Macao, SAR China，亚洲，MO，MAC，446），中华人民共和国澳门特别行政区 <br />
        /// 澳门，中华人民共和国的一部分 <br />
        /// Macao, a part of China <br />
        /// Cosmos i18n code: i18n_country_aomen <br />
        /// Cosmos region code: 10000100334
        /// </summary>
        public static CountryInfo Macao => Asia.Macao.Instance;

        /// <summary>
        /// 马奥霍（Territorial Collectivity of Mayotte，非洲，AF，AFG，004），马约特岛 <br />
        /// Cosmos i18n code: i18n_country_mayuete <br />
        /// Cosmos region code: 300138
        /// </summary>
        public static CountryInfo Mayotte => Africa.Mayotte.Instance;

        /// <summary>
        /// 密克罗尼西亚（The Federated States of Micronesia，大洋洲，FM，FSM，583） ，密克罗尼西亚联邦<br />
        /// Cosmos i18n code: i18n_country_mikeluonixiya <br />
        /// Cosmos region code: 600107
        /// </summary>
        public static CountryInfo Micronesia => Oceania.Micronesia.Instance;

        /// <summary>
        /// 摩洛哥（The Kingdom of Morocco，非洲，MA，MAR，504），摩洛哥王国 <br />
        /// Cosmos i18n code: i18n_country_moluoge <br />
        /// Cosmos region code: 300139
        /// </summary>
        public static CountryInfo Morocco => Africa.Morocco.Instance;

        /// <summary>
        /// 摩纳哥（The Principality of Monaco，欧洲，MC，MCO，492），摩纳哥公国 <br />
        /// Cosmos i18n code: i18n_country_monage <br />
        /// Cosmos region code: 200129
        /// </summary>
        public static CountryInfo Monaco => Europe.Monaco.Instance;

        /// <summary>
        /// 摩尔多瓦（Republic of Moldova，欧洲，MD，MDA，498），摩尔多瓦共和国 <br />
        /// Cosmos i18n code: i18n_country_moerduowa <br />
        /// Cosmos region code: 200128
        /// </summary>
        public static CountryInfo Moldova => Europe.Moldova.Instance;

        /// <summary>
        /// 黑山（Montenegro，欧洲，ME，MNE，499），黑山共和国 <br />
        /// Cosmos i18n code: i18n_country_heishan <br />
        /// Cosmos region code: 200130
        /// </summary>
        public static CountryInfo Montenegro => Europe.Montenegro.Instance;

        /// <summary>
        /// 法属圣马丁（Saint Martin (French part)，北美洲，MF，MAF，663），圣马丁行政区 <br />
        /// Cosmos i18n code: i18n_country_shengmading <br />
        /// Cosmos region code: 400130
        /// </summary>
        public static CountryInfo SaintMartin => NorthAmerica.SaintMartinFrenchPart.Instance;

        /// <summary>
        /// 马达加斯加（The Republic of Madagascar，非洲，MG，MDG，450），马达加斯加共和国 <br />
        /// Cosmos i18n code: i18n_country_madajiasijia <br />
        /// Cosmos region code: 300134
        /// </summary>
        public static CountryInfo Madagascar => Africa.Madagascar.Instance;

        /// <summary>
        /// 马绍尔群岛（The Republic of Marshall Islands，大洋洲，MH，MHL，584），马绍尔群岛共和国 <br />
        /// Cosmos i18n code: i18n_country_mashaoer <br />
        /// Cosmos region code: 600106
        /// </summary>
        public static CountryInfo MarshallIslands => Oceania.MarshallIslands.Instance;

        /// <summary>
        /// 北马其顿（The Republic of North Macedonia，欧洲，MK，MKD，807），北马其顿共和国 <br />
        /// Cosmos i18n code: i18n_country_maqidun <br />
        /// Cosmos region code: 200125
        /// </summary>
        public static CountryInfo Macedonia => Europe.Macedonia.Instance;

        /// <summary>
        /// 马里（The Republic of Mali，非洲，ML，MLI，466），马里共和国 <br />
        /// Cosmos i18n code: i18n_country_mali <br />
        /// Cosmos region code: 300122
        /// </summary>
        public static CountryInfo Mali => Africa.Mali.Instance;

        /// <summary>
        /// 缅甸（The Republic of the Union of Myanmar，亚洲，MM，MMR，104），缅甸联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_miandian <br />
        /// Cosmos region code: 100127
        /// </summary>
        public static CountryInfo Myanmar => Asia.Myanmar.Instance;

        /// <summary>
        /// 蒙古国（Outer Mongolia，亚洲，MN，MNG，496），外蒙古 <br />
        /// Cosmos i18n code: i18n_country_waimenggu <br />
        /// Cosmos region code: 100126
        /// </summary>
        public static CountryInfo Mongolia => Asia.Mongolia.Instance;

        /// <summary>
        /// 北马里亚那群岛（Commonwealth of the Northern Mariana Islands，大洋洲，MP，MNP，580），北马里亚纳群岛自由邦 <br />
        /// Cosmos i18n code: i18n_country_beimaliyana <br />
        /// Cosmos region code: 600112
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo NorthernMarianaIslands => Oceania.NorthernMarianaIslands.Instance;

        /// <summary>
        /// 马提尼克岛（Martinique，北美洲，MQ，MTQ，474），法国的海外大区 <br />
        /// Cosmos i18n code: i18n_country_matinike <br />
        /// Cosmos region code: 400122
        /// </summary>
        public static CountryInfo Martinique => NorthAmerica.Martinique.Instance;

        /// <summary>
        /// 毛里塔尼亚（The Islamic Republic of Mauritania，非洲，MR，MR，478），毛里塔尼亚伊斯兰共和国 <br />
        /// Cosmos i18n code: i18n_country_maolitaniya <br />
        /// Cosmos region code: 300135
        /// </summary>
        public static CountryInfo Mauritania => Africa.Mauritania.Instance;

        /// <summary>
        /// 蒙特塞拉特（Montserrat，北美洲，MS，MSR，500） <br />
        /// Cosmos i18n code: i18n_country_mengtesailate <br />
        /// Cosmos region code: 400124
        /// </summary>
        public static CountryInfo Montserrat => NorthAmerica.Montserrat.Instance;

        /// <summary>
        /// 马耳他（Republic of Malta，欧洲，MT，MLT，470），马耳他共和国 <br />
        /// Cosmos i18n code: i18n_country_maerta <br />
        /// Cosmos region code: 200126
        /// </summary>
        public static CountryInfo Malta => Europe.Malta.Instance;

        /// <summary>
        /// 毛里求斯（The Republic of Mauritius，非洲，MU，MUS，480），毛里求斯共和国 <br />
        /// Cosmos i18n code: i18n_country_maoliqiusi <br />
        /// Cosmos region code: 300136
        /// </summary>
        public static CountryInfo Mauritius => Africa.Mauritius.Instance;

        /// <summary>
        /// 马尔代夫（The Republic of Maldives，亚洲，MV，MDV，462），马尔代夫共和国 <br />
        /// Cosmos i18n code: i18n_country_maerdaifu <br />
        /// Cosmos region code: 100125
        /// </summary>
        public static CountryInfo Maldives => Asia.Maldives.Instance;

        /// <summary>
        /// 马拉维（The Republic of Malawi，非洲，MW，MWI，454），马拉维共和国 <br />
        /// Cosmos i18n code: i18n_country_malawei <br />
        /// Cosmos region code: 300137
        /// </summary>
        public static CountryInfo Malawi => Africa.Malawi.Instance;

        /// <summary>
        /// 墨西哥（The United Mexican States，北美洲，MX，MEX，484），墨西哥合众国 <br />
        /// Cosmos i18n code: i18n_country_moxige <br />
        /// Cosmos region code: 400123
        /// </summary>
        public static CountryInfo Mexico => NorthAmerica.Mexico.Instance;

        /// <summary>
        /// 大马（Malaysia，亚洲，MY，MYS，458），马来西亚 <br />
        /// Cosmos i18n code: i18n_country_malaixiya <br />
        /// Cosmos region code: 100124
        /// </summary>
        public static CountryInfo Malaysia => Asia.Malaysia.Instance;

        /// <summary>
        /// 莫桑比克（The Republic of Mozambique，非洲，MZ，MOZ，508），莫桑比克共和国 <br />
        /// Cosmos i18n code: i18n_country_mosangbike <br />
        /// Cosmos region code: 300140
        /// </summary>
        public static CountryInfo Mozambique => Africa.Mozambique.Instance;

        /// <summary>
        /// 纳米比亚（The Republic of Namibia，非洲，NA，NAM，516），纳米比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_manibiya <br />
        /// Cosmos region code: 300141
        /// </summary>
        public static CountryInfo Namibia => Africa.Namibia.Instance;

        /// <summary>
        /// 荷兰（The Kingdom of the Netherlands，欧洲，NL，NLD，528），荷兰王国 <br />
        /// Cosmos i18n code: i18n_country_helan<br />
        /// Cosmos region code: 200131
        /// </summary>
        public static CountryInfo Netherlands => Europe.Netherlands.Instance;

        /// <summary>
        /// 新喀里多尼亚（New Caledonia，大洋洲，NC，NCL，540） <br />
        /// Cosmos i18n code: i18n_country_xinkaliduoniya <br />
        /// Cosmos region code: 600109
        /// </summary>
        public static CountryInfo NewCaledonia => Oceania.NewCaledonia.Instance;

        /// <summary>
        /// 尼日尔（The Republic of Niger，非洲，NE，NER，562），尼日尔共和国 <br />
        /// Cosmos i18n code: i18n_country_nirier <br />
        /// Cosmos region code: 300143
        /// </summary>
        public static CountryInfo Niger => Africa.Niger.Instance;

        /// <summary>
        /// 尼日利亚（Federal Republic of Nigeria，非洲，NG，NGA，566，尼日利亚联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_niriliya <br />
        /// Cosmos region code: 300142
        /// </summary>
        public static CountryInfo Nigeria => Africa.Nigeria.Instance;

        /// <summary>
        /// 诺福克岛（Norfolk Island，大洋洲，NF，NFK，574） <br />
        /// Cosmos i18n code: i18n_country_nuofuke <br />
        /// Cosmos region code: 600111
        /// </summary>
        public static CountryInfo NorfolkIsland => Oceania.NorfolkIsland.Instance;

        /// <summary>
        /// 尼泊尔（Federal Democratic Republic of Nepal，亚洲，NP，NPL，524），尼泊尔联邦民主共和国 <br />
        /// Cosmos i18n code: i18n_country_niboer <br />
        /// Cosmos region code: 100128
        /// </summary>
        public static CountryInfo Nepal => Asia.Nepal.Instance;

        /// <summary>
        /// 尼加拉瓜（The Republic of Nicaragua，南美洲，NI，NIC，558），尼加拉瓜共和国 <br />
        /// Cosmos i18n code: i18n_country_nijialagua <br />
        /// Cosmos region code: 500108
        /// </summary>
        public static CountryInfo Nicaragua => SouthAmerica.Nicaragua.Instance;

        /// <summary>
        /// 瑙鲁（The Republic of Nauru，大洋洲，NR，NRU，520），瑙鲁共和国 <br />
        /// Cosmos i18n code: i18n_country_manu <br />
        /// Cosmos region code: 600108
        /// </summary>
        public static CountryInfo Nauru => Oceania.Nauru.Instance;

        /// <summary>
        /// 挪威（The Kingdom of Norway，欧洲，NO，NOR，578），挪威王国 <br />
        /// Cosmos i18n code: i18n_country_nuowei<br />
        /// Cosmos region code: 200132
        /// </summary>
        public static CountryInfo Norway => Europe.Norway.Instance;

        /// <summary>
        /// 纽埃（Niue，大洋洲，NU，NIU，570） <br />
        /// Cosmos i18n code: i18n_country_niuai <br />
        /// Cosmos region code: 600110
        /// </summary>
        public static CountryInfo Niue => Oceania.Niue.Instance;

        /// <summary>
        /// 新西兰（New Zealand，大洋洲，NZ，NZL，554） <br />
        /// Cosmos i18n code: i18n_country_xinxilan <br />
        /// Cosmos region code: 600012
        /// </summary>
        public static CountryInfo NewZealand => Oceania.NewZealand.Instance;

        /// <summary>
        /// 阿曼（Sultanate of Oman，亚洲，OM，OMN，512），阿曼苏丹国 <br />
        /// Cosmos i18n code: i18n_country_aman <br />
        /// Cosmos region code: 100129
        /// </summary>
        public static CountryInfo Oman => Asia.Oman.Instance;

        /// <summary>
        /// 巴拿马（The Republic of Panama，北美洲，PA，PAN，591），巴拿马共和国 <br />
        /// Cosmos i18n code: i18n_country_banama <br />
        /// Cosmos region code: 400125
        /// </summary>
        public static CountryInfo Panama => NorthAmerica.Panama.Instance;

        /// <summary>
        /// 巴拉圭（Republic Of Paraguay，南美洲，PY，PRY，600），巴拉圭共和国 <br />
        /// Cosmos i18n code: i18n_country_balagui <br />
        /// Cosmos region code: 500109
        /// </summary>
        public static CountryInfo Paraguay => SouthAmerica.Paraguay.Instance;

        /// <summary>
        /// 秘鲁（The Republic of Peru，南美洲，PE，PER，604），秘鲁共和国 <br />
        /// Cosmos i18n code: i18n_country_bilu <br />
        /// Cosmos region code: 500110
        /// </summary>
        public static CountryInfo Peru => SouthAmerica.Peru.Instance;

        /// <summary>
        /// 波利尼西亚（French Polynesia，大洋洲，PF，PYF，258），法属波利尼西亚 <br />
        /// Cosmos i18n code: i18n_country_bolinixiya <br />
        /// Cosmos region code: 600119
        /// </summary>
        public static CountryInfo Polynesia => Oceania.Polynesia.Instance;

        /// <summary>
        /// 巴布亚新几内亚（The Independent State of Papua New Guinea，大洋洲，PG，PNG，598），巴布亚新几内亚独立国 <br />
        /// Cosmos i18n code: i18n_country_baxin <br />
        /// Cosmos region code: 600114
        /// </summary>
        public static CountryInfo PapuaNewGuinea => Oceania.PapuaNewGuinea.Instance;

        /// <summary>
        /// 菲律宾（Republic of the Philippines，亚洲，PH，PHL，6080），菲律宾共和国 <br />
        /// Cosmos i18n code: i18n_country_felvbin <br />
        /// Cosmos region code: 100131
        /// </summary>
        public static CountryInfo Philippines => Asia.Philippines.Instance;

        /// <summary>
        /// 巴基斯坦（Islamic Republic of Pakistan，亚洲，PK，PAK，586），巴基斯坦伊斯兰共和国 <br />
        /// Cosmos i18n code: i18n_country_bajisitan <br />
        /// Cosmos region code: 100016
        /// </summary>
        public static CountryInfo Pakistan => Asia.Pakistan.Instance;

        /// <summary>
        /// 波兰（The Republic Of Poland，欧洲，PL，POL，61），波兰共和国 <br />
        /// Cosmos i18n code: i18n_country_bolan <br />
        /// Cosmos region code: 200014
        /// </summary>
        public static CountryInfo Poland => Europe.Poland.Instance;

        /// <summary>
        /// 圣皮埃尔和密克隆群岛（The Islands of Saint Pierre and Miquelon，北美洲，PM，SPM，666），法国海外领土 <br />
        /// Cosmos i18n code: i18n_country_shengyiaiermkl <br />
        /// Cosmos region code: 400132
        /// </summary>
        public static CountryInfo SaintPierreAndMiquelon => NorthAmerica.SaintPierreAndMiquelon.Instance;

        /// <summary>
        /// 皮特肯岛（Pitcairn Islands，大洋洲，PN，PCN，612），皮特凯恩群岛 <br />
        /// Cosmos i18n code: i18n_country_piteken <br />
        /// Cosmos region code: 600117
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo Pitcairn => Oceania.Pitcairn.Instance;

        /// <summary>
        /// 波多黎各（The Commonwealth of Puerto Rico，北美洲，PR，PRI，630），波多黎各自治邦 <br />
        /// Cosmos i18n code: i18n_country_boduolige <br />
        /// Cosmos region code: 400126
        /// </summary>
        public static CountryInfo PuertoRico => NorthAmerica.PuertoRico.Instance;

        /// <summary>
        /// 巴勒斯坦（The State of Palestine，亚洲，PS，PSE，275），巴勒斯坦国 <br />
        /// Cosmos i18n code: i18n_country_balesitan <br />
        /// Cosmos region code: 100130
        /// </summary>
        public static CountryInfo Palestine => Asia.Palestine.Instance;

        /// <summary>
        /// 葡萄牙（The Portuguese Republic，欧洲，PT，PRT，620），葡萄牙共和国 <br />
        /// Cosmos i18n code: i18n_country_putapya <br />
        /// Cosmos region code: 200133
        /// </summary>
        public static CountryInfo Portugal => Europe.Portugal.Instance;

        /// <summary>
        /// 帕劳（The Republic of Palau，大洋洲，PW，PLW，585），帕劳共和国 <br />
        /// Cosmos i18n code: i18n_country_palao <br />
        /// Cosmos region code: 600113
        /// </summary>
        public static CountryInfo Palau => Oceania.Palau.Instance;

        /// <summary>
        /// 卡塔尔（State of Qatar，亚洲，QA，QAT，634），卡塔尔国 <br />
        /// Cosmos i18n code: i18n_country_kataer <br />
        /// Cosmos region code: 100132
        /// </summary>
        public static CountryInfo Qatar => Asia.Qatar.Instance;

        /// <summary>
        /// 留尼汪（Reunion Island，非洲，RE，REU，638），留尼旺岛 <br />
        /// Cosmos i18n code: i18n_country_liuniwang <br />
        /// Cosmos region code: 300147
        /// </summary>
        public static CountryInfo Réunion => Africa.Réunion.Instance;

        /// <summary>
        /// 罗马尼亚（Romania，欧洲，RO，ROU，642） <br />
        /// Cosmos i18n code: i18n_country_luomaniya <br />
        /// Cosmos region code: 200134
        /// </summary>
        public static CountryInfo Romania => Europe.Romania.Instance;

        /// <summary>
        /// 俄罗斯（Russian Federation，欧洲，BI，BDI，108），俄罗斯联邦 <br />
        /// Cosmos i18n code: i18n_country_eluosi <br />
        /// Cosmos region code: 200004
        /// </summary>
        public static CountryInfo Russia => Europe.Russia.Instance;

        /// <summary>
        /// 卢旺达（The Republic of Rwanda，非洲，RW，RWA，646），卢旺达共和国 <br />
        /// Cosmos i18n code: i18n_country_luwangda <br />
        /// Cosmos region code: 300144
        /// </summary>
        public static CountryInfo Rwanda => Africa.Rwanda.Instance;

        /// <summary>
        /// 塞尔维亚（The Republic of Serbia，欧洲，RS，SRB，688），塞尔维亚共和国 <br />
        /// Cosmos i18n code: i18n_country_saierweiya <br />
        /// Cosmos region code: 200136
        /// </summary>
        public static CountryInfo Serbia => Europe.Serbia.Instance;

        /// <summary>
        /// 沙特（Kingdom of Saudi Arabia，亚洲，SA，SAU，682），沙特阿拉伯王国 <br />
        /// Cosmos i18n code: i18n_country_shate <br />
        /// Cosmos region code: 100133
        /// </summary>
        public static CountryInfo SaudiArabia => Asia.SaudiArabia.Instance;

        /// <summary>
        /// 南乔治亚岛和南桑威奇群岛（South Georgia and The South Sandwich Islands，南美洲，GS，SGS，239） <br />
        /// Cosmos i18n code: i18n_country_nanqiaozhiya <br />
        /// Cosmos region code: 500111
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public static CountryInfo SGSSI => SouthAmerica.SGSSI.Instance;

        /// <summary>
        /// 圣巴托洛缪岛（Collectivitéde Saint-Barthélemy，北美洲，BL，BLM，652），法兰西共和国圣巴托洛缪行政区 <br />
        /// Cosmos i18n code: i18n_country_shengbatuo <br />
        /// Cosmos region code: 400127
        /// </summary>
        public static CountryInfo SaintBarts => NorthAmerica.SaintBarts.Instance;

        /// <summary>
        /// 萨摩亚（The Independent State of Samoa，大洋洲，WS，WSM，882），萨摩亚独立国 <br />
        /// Cosmos i18n code: i18n_country_samoya <br />
        /// Cosmos region code: 600118
        /// </summary>
        public static CountryInfo Samoa => Oceania.Samoa.Instance;

        /// <summary>
        /// 所罗门群岛（Solomon Islands，大洋洲，SB，SLB，090） <br />
        /// Cosmos i18n code: i18n_country_suoluomen <br />
        /// Cosmos region code: 600115
        /// </summary>
        public static CountryInfo SolomonIslands => Oceania.SolomonIslands.Instance;

        /// <summary>
        /// 塞舌尔（Republic of Seychelles，非洲，SC，SYC，690），塞舌尔共和国 <br />
        /// Cosmos i18n code: i18n_country_saisheer <br />
        /// Cosmos region code: 300145
        /// </summary>
        public static CountryInfo Seychelles => Africa.Seychelles.Instance;

        /// <summary>
        /// 苏丹（Republic of the Sudan，非洲，SD，SDN，736），苏丹共和国 <br />
        /// Cosmos i18n code: i18n_country_sudan <br />
        /// Cosmos region code: 300146
        /// </summary>
        public static CountryInfo Sudan => Africa.Sudan.Instance;

        /// <summary>
        /// 瑞典（The Kingdom of Sweden，欧洲，SE，SWE，752），瑞典王国 <br />
        /// Cosmos i18n code: i18n_country_ruidian <br />
        /// Cosmos region code: 200016
        /// </summary>
        public static CountryInfo Sweden => Europe.Sweden.Instance;

        /// <summary>
        /// 新加坡（Republic of Singapore，亚洲，SG，SGP，702），新加坡共和国 <br />
        /// Cosmos i18n code: i18n_country_xinjiapo<br />
        /// Cosmos region code: 100134
        /// </summary>
        public static CountryInfo Singapore => Asia.Singapore.Instance;

        /// <summary>
        /// 斯洛文尼亚（The Republic of Slovenia，欧洲，SI，SVN，705），斯洛文尼亚共和国 <br />
        /// Cosmos i18n code: i18n_country_sinuowenniya <br />
        /// Cosmos region code: 200138
        /// </summary>
        public static CountryInfo Slovenia => Europe.Slovenia.Instance;

        /// <summary>
        /// 圣赫勒拿、阿森松与特里斯坦达库尼亚（Saint Helena, Ascension and Tristan da Cunha，非洲，SH，SHN，654） <br />
        /// Cosmos i18n code: i18n_country_shenghelena <br />
        /// Cosmos region code: 300121
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo SaintHelena => Africa.SaintHelena.Instance;

        /// <summary>
        /// 南非（The Republic of South Africa，非洲，ZA，ZAF，710），南非共和国 <br />
        /// Cosmos i18n code: i18n_country_nanfei <br />
        /// Cosmos region code: 300013
        /// </summary>
        public static CountryInfo SouthAfrica => Africa.SouthAfrica.Instance;

        /// <summary>
        /// 斯瓦尔巴群岛（The Svalbard archipelago，欧洲，SJ，SJM，744） <br />
        /// Cosmos i18n code: i18n_country_siwaerba <br />
        /// Cosmos region code: 200139
        /// </summary>
        public static CountryInfo SvalbardAndJanMayen => Europe.SvalbardAndJanMayen.Instance;

        /// <summary>
        /// 斯洛伐克（The Slovak Republic，欧洲，SK，SVK，703），斯洛伐克共和国 <br />
        /// Cosmos i18n code: i18n_country_siluofake <br />
        /// Cosmos region code: 200137
        /// </summary>
        public static CountryInfo Slovakia => Europe.Slovakia.Instance;

        /// <summary>
        /// 塞拉利昂（The Republic of Sierra Leone，非洲，SL，SLE，694），塞拉利昂共和国 <br />
        /// Cosmos i18n code: i18n_country_sailaliang <br />
        /// Cosmos region code: 300153
        /// </summary>
        public static CountryInfo SierraLeone => Africa.SierraLeone.Instance;

        /// <summary>
        /// 圣马力诺（The Republic of San Marino，欧洲，SM，SMR，674），圣马力诺共和国 <br />
        /// Cosmos i18n code: i18n_country_shengmalinuo <br />
        /// Cosmos region code: 200135
        /// </summary>
        public static CountryInfo SanMarino => Europe.SanMarino.Instance;

        /// <summary>
        /// 塞内加尔（The Republic of Senegal，非洲，SN，SEN，686），塞内加尔共和国 <br />
        /// Cosmos i18n code: i18n_country_saineijiaer <br />
        /// Cosmos region code: 300151
        /// </summary>
        public static CountryInfo Senegal => Africa.Senegal.Instance;

        /// <summary>
        /// 索马里（The Federal Republic of Somalia，非洲，SO，SOM，706），索马里联邦共和国 <br />
        /// Cosmos i18n code: i18n_country_suomali <br />
        /// Cosmos region code: 300152
        /// </summary>
        public static CountryInfo Somalia => Africa.Somalia.Instance;

        /// <summary>
        /// 苏里南（The Republic of Suriname，非洲，SR，SUR，740），苏里南共和国 <br />
        /// Cosmos i18n code: i18n_country_sulinan <br />
        /// Cosmos region code: 300150
        /// </summary>
        public static CountryInfo Suriname => Africa.Suriname.Instance;

        /// <summary>
        /// 南苏丹（The Republic of South Sudan，非洲，SS，SSD，728），南苏丹共和国 <br />
        /// Cosmos i18n code: i18n_country_nansudan <br />
        /// Cosmos region code: 300149
        /// </summary>
        public static CountryInfo SouthSudan => Africa.SouthSudan.Instance;

        /// <summary>
        /// 圣多美和普林西比（The Democratic Republic of Sao Tome and Principe，非洲，ST，STP，678），圣多美和普林西比民主共和国 <br />
        /// Cosmos i18n code: i18n_country_shengduomeiplxb <br />
        /// Cosmos region code: 300148
        /// </summary>
        public static CountryInfo SaoTomeAndPrincipe => Africa.SaoTomeAndPrincipe.Instance;

        /// <summary>
        /// 西班牙（The Kingdom of Spain，南美洲，ES，ESP，724），西班牙王国 <br />
        /// Cosmos i18n code: i18n_country_xibanya <br />
        /// Cosmos region code: 200015
        /// </summary>
        public static CountryInfo Spain => Europe.Spain.Instance;

        /// <summary>
        /// 瑞士（Swiss Confederation，欧洲，CH，CHE，756），瑞士联邦 <br />
        /// Cosmos i18n code: i18n_country_ruishi <br />
        /// Cosmos region code: 200017
        /// </summary>
        public static CountryInfo Switzerland => Europe.Switzerland.Instance;

        /// <summary>
        /// 圣文森特和格林纳丁斯（Saint Vincent and the Grenadines，北美洲，VC，VCT，670） <br />
        /// Cosmos i18n code: i18n_country_shengwensenteglnds <br />
        /// Cosmos region code: 400133
        /// </summary>
        public static CountryInfo StVAndG => NorthAmerica.StVAndG.Instance;

        /// <summary>
        /// 萨尔瓦多（The Democratic Republic of Sao Tome and Principe，北美洲，SV，SLV，222），萨尔瓦多共和国 <br />
        /// Cosmos i18n code: i18n_country_saerwaduo <br />
        /// Cosmos region code: 400115
        /// </summary>
        public static CountryInfo ElSalvador => NorthAmerica.ElSalvador.Instance;

        /// <summary>
        /// 荷兰属圣马丁（Sint Maarten (Dutch part)，北美洲，SX，SXM，534） <br />
        /// Cosmos i18n code: i18n_country_shengmadingdp <br />
        /// Cosmos region code: 400131
        /// </summary>
        public static CountryInfo SintMaarten => NorthAmerica.SintMaartenDutchPart.Instance;

        /// <summary>
        /// 叙利亚（The Syrian Arab Republic，亚洲，SY，SYR，760），阿拉伯叙利亚共和国 <br />
        /// Cosmos i18n code: i18n_country_xuliya <br />
        /// Cosmos region code: 100136
        /// </summary>
        public static CountryInfo Syrian => Asia.Syrian.Instance;

        /// <summary>
        /// 斯威士兰（The Kingdom of Swaziland，非洲，SZ，SWZ，748），斯威士兰王国 <br />
        /// Cosmos i18n code: i18n_country_siweishilan <br />
        /// Cosmos region code: 300155
        /// </summary>
        public static CountryInfo Swaziland => Africa.Swaziland.Instance;

        /// <summary>
        /// 特克斯和凯科斯群岛（The Turks and Caicos Islands，北美洲，TC，TCA，796） <br />
        /// Cosmos i18n code: i18n_country_tekesikks <br />
        /// Cosmos region code: 400135
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo TurksAndCaicosIslands => NorthAmerica.TurksAndCaicosIslands.Instance;

        /// <summary>
        /// 台湾（Taiwan, China，亚洲，TW，TWN，158），中华人民共和国台湾省 <br />
        /// 台湾，中华人民共和国的一部分 <br />
        /// Taiwan, a part of China <br />
        /// Cosmos i18n code: i18n_country_cnhtaiwan <br />
        /// Cosmos region code: 10000100332
        /// </summary>
        public static CountryInfo Taiwan => Asia.Taiwan.Instance;

        /// <summary>
        /// 坦桑尼亚（The United Republic of Tanzania，非洲，TZ，TZA，834），坦桑尼亚联合共和国 <br />
        /// Cosmos i18n code: i18n_country_tansangniya <br />
        /// Cosmos region code: 300014
        /// </summary>
        public static CountryInfo Tanzania => Africa.Tanzania.Instance;

        /// <summary>
        /// 特立尼达和多巴哥（Republic of Trinidad and Tobago，北美洲，TT，TTO，780），特立尼达和多巴哥共和国 <br />
        /// Cosmos i18n code: i18n_country_telinidaduobage <br />
        /// Cosmos region code: 400134
        /// </summary>
        public static CountryInfo TrinidadAndTobago => NorthAmerica.TrinidadAndTobago.Instance;

        /// <summary>
        /// 土耳其（The Republic of Turkey，亚洲，TR，TUR，792），土耳其共和国 <br />
        /// Cosmos i18n code: i18n_country_tuerqi <br />
        /// Cosmos region code: 100017
        /// </summary>
        public static CountryInfo Turkey => Asia.Turkey.Instance;

        /// <summary>
        /// 图瓦卢（Tuvalu，大洋洲，TV，TUV，798） <br />
        /// Cosmos i18n code: i18n_country_tuwalu <br />
        /// Cosmos region code: 600122
        /// </summary>
        public static CountryInfo Tuvalu => Oceania.Tuvalu.Instance;

        /// <summary>
        /// 乍得（Republic of Chad，非洲，TD，TCD，148），乍得共和国 <br />
        /// Cosmos i18n code: i18n_country_zhade <br />
        /// Cosmos region code: 300110
        /// </summary>
        public static CountryInfo Chad => Africa.Chad.Instance;

        /// <summary>
        /// 法属南部领地（French Southern Territories，非洲，TF，ATF，260） <br />
        /// Cosmos i18n code: i18n_country_faguonanbulingdi <br />
        /// Cosmos region code: 300124
        /// </summary>
        public static CountryInfo FrenchSouthernTerritories => Africa.FrenchSouthernTerritories.Instance;

        /// <summary>
        /// 多哥（French Southern Territories，非洲，TG，TGO，768），多哥共和国 <br />
        /// Cosmos i18n code: i18n_country_duoge <br />
        /// Cosmos region code: 300125
        /// </summary>
        public static CountryInfo Togo => Africa.Togo.Instance;

        /// <summary>
        /// 泰国（The Kingdom of Thailand，亚洲，TH，THA，764），泰王国 <br />
        /// Cosmos i18n code: i18n_country_taiguo <br />
        /// Cosmos region code: 100138
        /// </summary>
        public static CountryInfo Thailand => Asia.Thailand.Instance;

        /// <summary>
        /// 塔吉克斯坦（The Republic of Tajikistan，亚洲，TJ，TJK，762），塔吉克斯坦共和国 <br />
        /// Cosmos i18n code: i18n_country_tajikesitan <br />
        /// Cosmos region code: 100137
        /// </summary>
        public static CountryInfo Tajikistan => Asia.Tajikistan.Instance;

        /// <summary>
        /// 托克劳群岛（Tokelau，大洋洲，TK，TKL，772） <br />
        /// Cosmos i18n code: i18n_country_tuokelao <br />
        /// Cosmos region code: 600120
        /// </summary>
        public static CountryInfo Tokelau => Oceania.Tokelau.Instance;

        /// <summary>
        /// 东帝汶（Democratic Republic of Timor-Leste，亚洲，TL，TLS，626），东帝汶民主共和国 <br />
        /// Cosmos i18n code: i18n_country_dongdiwen <br />
        /// Cosmos region code: 100114
        /// </summary>
        public static CountryInfo EastTimor => Asia.EastTimor.Instance;

        /// <summary>
        /// 土库曼（Turkmenistan，亚洲，TM，TKM，795），土库曼斯坦 <br />
        /// Cosmos i18n code: i18n_country_tukumansitan <br />
        /// Cosmos region code: 100139
        /// </summary>
        public static CountryInfo Turkmenistan => Asia.Turkmenistan.Instance;

        /// <summary>
        /// 突尼斯（The Republic of Tunisia，非洲，TN，TUN，788），突尼斯共和国 <br />
        /// Cosmos i18n code: i18n_country_tunisi <br />
        /// Cosmos region code: 300120
        /// </summary>
        public static CountryInfo Tunisia => Africa.Tunisia.Instance;

        /// <summary>
        /// 汤加（The Kingdom of Tonga，大洋洲，TO，TN，776），汤加王国 <br />
        /// Cosmos i18n code: i18n_country_tangjia <br />
        /// Cosmos region code: 600121
        /// </summary>
        public static CountryInfo Tonga => Oceania.Tonga.Instance;

        /// <summary>
        /// 乌克兰（Ukraine，欧洲，UA，UKR，804） <br />
        /// Cosmos i18n code: i18n_country_wukelan <br />
        /// Cosmos region code: 200140
        /// </summary>
        public static CountryInfo Ukraine => Europe.Ukraine.Instance;

        /// <summary>
        /// 阿联酋（United Arab Emirates，亚洲，AE，ARE，784），阿拉伯联合酋长国 <br />
        /// 又名 阿拉伯联合大公国 <br />
        /// Cosmos i18n code: i18n_country_alianqiu <br />
        /// Cosmos region code: 100140
        /// </summary>
        public static CountryInfo UnitedArabEmirates => Asia.UnitedArabEmirates.Instance;

        /// <summary>
        /// 英国（United Kingdom of Great Britain and Northern Ireland，欧洲，GB，GBR，826），大不列颠及北爱尔兰联合王国 <br />
        /// Cosmos i18n code: i18n_country_yingguo <br />
        /// Cosmos region code: 200005
        /// </summary>
        public static CountryInfo UnitedKingdom => Europe.UnitedKingdom.Instance;

        /// <summary>
        /// 乌干达（The Republic of Uganda，非洲，UG，UGA，800），乌干达共和国 <br />
        /// Cosmos i18n code: i18n_country_wuganda <br />
        /// Cosmos region code: 300154
        /// </summary>
        public static CountryInfo Uganda => Africa.Uganda.Instance;

        /// <summary>
        /// 美国（United States of America，北美洲，US，USA，840），美利坚合众国 <br />
        /// Cosmos i18n code: i18n_country_meiguo <br />
        /// Cosmos region code: 400001
        /// </summary>
        public static CountryInfo UnitedStates => NorthAmerica.UnitedStates.Instance;

        /// <summary>
        /// 美国本土外小岛屿（United States Minor Outlying Islands，北美洲，UM，UMI，581） <br />
        /// Cosmos i18n code: i18n_country_meiguoum <br />
        /// Cosmos region code: 400136
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo UnitedStatesMinorOutlyingIslands => NorthAmerica.UnitedStatesMinorOutlyingIslands.Instance;

        /// <summary>
        /// 乌拉圭（The Oriental Republic of Uruguay，南美洲，UY，URY，858），乌拉圭东岸共和国 <br />
        /// Cosmos i18n code: i18n_country_wulagui <br />
        /// Cosmos region code: 500112
        /// </summary>
        public static CountryInfo Uruguay => SouthAmerica.Uruguay.Instance;

        /// <summary>
        /// 乌兹别克斯坦（The Republic Of Uzbekistan，亚洲，UZ，UZB，860），乌兹别克斯坦共和国 <br />
        /// Cosmos i18n code: i18n_country_wuzibiekesitan <br />
        /// Cosmos region code: 100141
        /// </summary>
        public static CountryInfo Uzbekistan => Asia.Uzbekistan.Instance;

        /// <summary>
        /// 委内瑞拉（Bolivarian Republic of Venezuela，南美洲，VE，VEN，862），委内瑞拉玻利瓦尔共和国 <br />
        /// Cosmos i18n code: i18n_country_weineiruila <br />
        /// Cosmos region code: 500013
        /// </summary>
        public static CountryInfo Venezuela => SouthAmerica.Venezuela.Instance;

        /// <summary>
        /// 维尔京群岛（The British Virgin Islands，北美洲，VG，VGB，092），英属维尔京群岛 <br />
        /// Cosmos i18n code: i18n_country_yingshuweierjing <br />
        /// Cosmos region code: 400137
        /// </summary>
        // ReSharper disable once ConvertToAutoProperty
        public static CountryInfo VirginIslandsBritish => NorthAmerica.VirginIslandsBritish.Instance;

        /// <summary>
        /// 美属维尔京群岛（The United States Virgin Islands，北美洲，VI，VIR，850） <br />
        /// Cosmos i18n code: i18n_country_meishuweierjing <br />
        /// Cosmos region code: 400138
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public static CountryInfo VirginIslandsUS => NorthAmerica.VirginIslandsUS.Instance;

        /// <summary>
        /// 越南（Socialist Republic of Vietnam，亚洲，VN，VNM，704），越南社会主义共和国 <br />
        /// Cosmos i18n code: i18n_country_yuenan <br />
        /// Cosmos region code: 100018
        /// </summary>
        public static CountryInfo Vietnam => Asia.Vietnam.Instance;

        /// <summary>
        /// 瓦努阿图（The Republic of Vanuatu，大洋洲，VU，VUT，548），瓦努阿图共和国 <br />
        /// Cosmos i18n code: i18n_country_wanuatu <br />
        /// Cosmos region code: 600123
        /// </summary>
        public static CountryInfo Vanuatu => Oceania.Vanuatu.Instance;

        /// <summary>
        /// 瓦利斯和富图纳群岛（Wallis and Futuna Islands，大洋洲，WF，WLF，876） <br />
        /// Cosmos i18n code: i18n_country_walisi <br />
        /// Cosmos region code: 600116
        /// </summary>
        public static CountryInfo WallisAndFutuna => Oceania.WallisAndFutuna.Instance;

        /// <summary>
        /// 西撒哈拉（The Sahrawi Arab Democratic Republic，非洲，EH，ESH，732），阿拉伯撒哈拉民主共和国 <br />
        /// Cosmos i18n code: i18n_country_xisahala <br />
        /// Cosmos region code: 300118
        /// </summary>
        public static CountryInfo WesternSahara => Africa.WesternSahara.Instance;

        /// <summary>
        /// 科索沃（Kosovo，欧洲，XK，XKX，838），科索沃自治省 <br />
        /// Cosmos i18n code: i18n_country_kesuowo <br />
        /// Cosmos region code: 200120
        /// </summary>
        public static CountryInfo Kosovo => Europe.Kosovo.Instance;

        /// <summary>
        /// 也门（The Republic Of Yemen，亚洲，YE，YEM，887），也门共和国 <br />
        /// Cosmos i18n code: i18n_country_yemen <br />
        /// Cosmos region code: 100142
        /// </summary>
        public static CountryInfo Yemen => Asia.Yemen.Instance;

        //TODO 即将执行合并，并从枚举中移除
        /// <summary>
        /// 南斯拉夫（Yugoslavia，欧洲，YU，YUG，38），南斯拉夫联盟共和国 <br />
        /// Cosmos i18n code: i18n_country_nlm_1992<br />
        /// Cosmos region code: 220106
        /// </summary>
        [Obsolete]
        public static CountryInfo Yugoslavia1992 => Europe.Yugoslavia1992.Instance;

        /// <summary>
        /// 赞比亚（The Republic of Zambia，非洲，ZM，ZMB，894），赞比亚共和国 <br />
        /// Cosmos i18n code: i18n_country_zanbiya <br />
        /// Cosmos region code: 300117
        /// </summary>
        public static CountryInfo Zambia => Africa.Zambia.Instance;

        /// <summary>
        /// 津巴布韦（Zimbabwe，非洲，ZW，ZWE，716），津巴布韦共和国 <br />
        /// Cosmos i18n code: i18n_country_jinbabuwei <br />
        /// Cosmos region code: 300119
        /// </summary>
        public static CountryInfo Zimbabwe => Africa.Zimbabwe.Instance;

        #endregion
    }
}