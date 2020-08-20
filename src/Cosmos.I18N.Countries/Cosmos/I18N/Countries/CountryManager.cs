using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using Cosmos.I18N.Core.Historical;

namespace Cosmos.I18N.Countries
{
    /// <summary>
    /// Country Manager
    /// </summary>
    public static partial class CountryManager
    {
        // ReSharper disable once InconsistentNaming
        private static readonly Dictionary<Country, CountryCode> _nameAndCodeMap;

        // ReSharper disable once InconsistentNaming
        private static readonly Dictionary<CountryCode, Country> _codeAndNameMap;

        static CountryManager()
        {
            _nameAndCodeMap = WholeWorld.Data.ToDictionary(k => k.Country, v => v.CountryCode);
            _codeAndNameMap = WholeWorld.Data.ToDictionary(k => k.CountryCode, v => v.Country);

            RuntimeCountryInfoCache.FirstTimeUpdate(WholeWorld.Data);
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via <see cref="Country"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static CountryInfo GetCountryInfo(Country country)
        {
            return WholeWorld.Data.FirstOrDefault(x => x.Country == country);
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static CountryInfo GetCountryInfo(CountryCode code)
        {
            return WholeWorld.Data.FirstOrDefault(x => x.CountryCode == code);
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via AlphaCode2 or AlphaCode3
        /// </summary>
        /// <param name="alphaCode"></param>
        /// <returns></returns>
        public static CountryInfo GetCountryInfo(string alphaCode)
        {
            if (string.IsNullOrWhiteSpace(alphaCode))
            {
                return null;
            }

            if (alphaCode.Length == 2)
            {
                var alpha2Code = alphaCode.ToUpper();
                return WholeWorld.Data.FirstOrDefault(x => x.Alpha2Code == alpha2Code);
            }

            if (alphaCode.Length == 3)
            {
                var alpha3Code = alphaCode.ToUpper();
                return WholeWorld.Data.FirstOrDefault(x => x.Alpha3Code == alpha3Code);
            }

            return null;
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via Cosmos Region Code / CEP-1.
        /// </summary>
        /// <param name="cep1CrCode"></param>
        /// <returns></returns>
        public static RuntimeCountryInfo GetCountryInfo(long cep1CrCode)
        {
            return GetCountryInfo(new RegionCodeValue(cep1CrCode));
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via Cosmos Region Code / CEP-1.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RuntimeCountryInfo GetCountryInfo(RegionCodeValue value)
        {
            if (value.IsHistoricalValue())
            {
                return RuntimeCountryInfoCache.GetOrDefault(value);
            }

            var country = WholeWorld.Data.FirstOrDefault(x => x.Cep1CrCode == value);

            return RuntimeCountryInfo.Of(country);
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via <see cref="Country"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<RuntimeCountryInfo> GetCountryInfo(Country country, int year, int month, int day)
        {
            return HistoricalCountryManager.Get(country, year, month, day);
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<RuntimeCountryInfo> GetCountryInfo(CountryCode code, int year, int month, int day)
        {
            return HistoricalCountryManager.Get(code, year, month, day);
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via AlphaCode2 or AlphaCode3
        /// </summary>
        /// <param name="alphaCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<RuntimeCountryInfo> GetCountryInfo(string alphaCode, int year, int month, int day)
        {
            return HistoricalCountryManager.Get(alphaCode, year, month, day);
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via Cosmos Region Code / CEP-1.
        /// </summary>
        /// <param name="cep1CrCode"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<RuntimeCountryInfo> GetCountryInfo(long cep1CrCode, int year, int month, int day)
        {
            return HistoricalCountryManager.Get(new RegionCodeValue(cep1CrCode), year, month, day);
        }

        /// <summary>
        /// Gets <see cref="CountryInfo"/> via Cosmos Region Code / CEP-1.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public static IEnumerable<RuntimeCountryInfo> GetCountryInfo(RegionCodeValue value, int year, int month, int day)
        {
            return HistoricalCountryManager.Get(value, year, month, day);
        }

        /// <summary>
        /// Gets <see cref="Country"/> from <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Country GetCountryEnum(CountryCode code)
        {
            return _codeAndNameMap[code];
        }

        /// <summary>
        /// Gets <see cref="CountryCode"/> from <see cref="Country"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static CountryCode GetCountryCode(Country country)
        {
            return _nameAndCodeMap[country];
        }

        /// <summary>
        /// Gets <see cref="RegionCodeValue"/> from <see cref="CountryCode"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static RegionCodeValue GetRegionCode(CountryCode code)
        {
            return (RegionCodeValue) GetCountryInfo(code).Cep1CrCode;
        }

        /// <summary>
        /// Gets <see cref="RegionCodeValue"/> from <see cref="Country"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static RegionCodeValue GetRegionCode(Country country)
        {
            return (RegionCodeValue) GetCountryInfo(country).Cep1CrCode;
        }

        /// <summary>
        /// Gets <see cref="RegionCodeValue"/> via AlphaCode2 or AlphaCode3.
        /// </summary>
        /// <param name="alphaCode"></param>
        /// <returns></returns>
        public static RegionCodeValue GetRegionCode(string alphaCode)
        {
            return (RegionCodeValue) GetCountryInfo(alphaCode).Cep1CrCode;
        }

        /// <summary>
        /// Gets <see cref="RegionEnumValue"/> via Cosmos Region Code / CEP-1.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static RegionEnumValue GetRegionEnum(RegionCodeValue value)
        {
            return ((CountryInfo) GetCountryInfo(value))?.GetRegionEnumValue(value) ?? RegionEnumValue.Unknown;
        }

        /// <summary>
        /// Gets Continent
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static Continent GetContinent(Country country)
        {
            return GetCountryInfo(country).Continent;
        }

        /// <summary>
        /// Gets Continent
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static Continent GetContinent(CountryCode code)
        {
            return GetCountryInfo(code).Continent;
        }

        private static class WholeWorld
        {
            public static readonly List<CountryInfo> Data = new List<CountryInfo>
            {
                Europe.Andorra.Instance,
                Asia.Afghanistan.Instance,
                Africa.Algeria.Instance,
                NorthAmerica.AntiguaAndBarbuda.Instance,
                NorthAmerica.Anguilla.Instance,
                Asia.Armenia.Instance,
                Africa.Angola.Instance,
                CountryOf.Antarctica,
                SouthAmerica.Argentina.Instance,
                Oceania.AmericanSamoa.Instance,
                Europe.Austria.Instance,
                Oceania.Australia.Instance,
                NorthAmerica.Aruba.Instance,
                Europe.AlandIslands.Instance,
                Asia.Azerbaijan.Instance,
                Europe.BosniaAndHerzegovina.Instance,
                NorthAmerica.Barbados.Instance,
                Asia.Bangladesh.Instance,
                Europe.Belgium.Instance,
                Africa.BurkinaFaso.Instance,
                Europe.Bulgaria.Instance,
                Asia.Bahrain.Instance,
                Africa.Burundi.Instance,
                Africa.Benin.Instance,
                NorthAmerica.Bermuda.Instance,
                Asia.Brunei.Instance,
                SouthAmerica.Bolivia.Instance,
                NorthAmerica.Bonaire.Instance,
                Europe.BouvetIsland.Instance,
                SouthAmerica.Brazil.Instance,
                NorthAmerica.Bahamas.Instance,
                Asia.Bhutan.Instance,
                Africa.Botswana.Instance,
                Europe.Belarus.Instance,
                NorthAmerica.Belize.Instance,
                Africa.Cameroun.Instance,
                NorthAmerica.Canada.Instance,
                Africa.CapeVerde.Instance,
                Africa.CentralAfrican.Instance,
                Asia.China.Instance,
                SouthAmerica.Chile.Instance,
                Asia.ChristmasIsland.Instance,
                Africa.CongoBrazzaville.Instance,
                Africa.CongoKinshasa.Instance,
                Asia.CocosIslands.Instance,
                SouthAmerica.Colombia.Instance,
                Oceania.CookIslands.Instance,
                NorthAmerica.CostaRica.Instance,
                Africa.CotedIvoire.Instance,
                NorthAmerica.Cuba.Instance,
                NorthAmerica.Curaçao.Instance,
                Asia.Cyprus.Instance,
                Europe.Czechia.Instance,
                Europe.Denmark.Instance,
                NorthAmerica.Dominica.Instance,
                NorthAmerica.Dominican.Instance,
                Asia.Djibouti.Instance,
                SouthAmerica.Ecuador.Instance,
                Europe.Estonia.Instance,
                Africa.Egypt.Instance,
                Africa.Eritrea.Instance,
                Africa.Ethiopia.Instance,
                SouthAmerica.FalklandIslands.Instance,
                Europe.Faroe.Instance,
                Oceania.Fiji.Instance,
                Europe.Finland.Instance,
                Europe.France.Instance,
                Asia.Georgia.Instance,
                Europe.Germany.Instance,
                NorthAmerica.Grenada.Instance,
                SouthAmerica.Guiana.Instance,
                Africa.Guinea.Instance,
                Africa.EquatorialGuinea.Instance,
                NorthAmerica.Guadeloupe.Instance,
                NorthAmerica.Greenland.Instance,
                Africa.Gabon.Instance,
                Africa.Ghana.Instance,
                Europe.Gibraltar.Instance,
                Africa.Gambia.Instance,
                NorthAmerica.Guatemala.Instance,
                Europe.Greece.Instance,
                Oceania.Guam.Instance,
                Africa.GuineaBissau.Instance,
                SouthAmerica.Guyana.Instance,
                Asia.HIMI.Instance,
                Asia.HongKong.Instance,
                SouthAmerica.Honduras.Instance,
                Europe.Vatican.Instance,
                Europe.Croatia.Instance,
                NorthAmerica.Haiti.Instance,
                Europe.Hungary.Instance,
                Asia.India.Instance,
                Asia.Indonesia.Instance,
                Asia.Israel.Instance,
                Asia.BritishIndianOceanTerritory.Instance,
                Asia.Iraq.Instance,
                Asia.Iran.Instance,
                Europe.Iceland.Instance,
                Europe.Ireland.Instance,
                Europe.Italy.Instance,
                NorthAmerica.Jamaica.Instance,
                Asia.Japan.Instance,
                Europe.Jersey.Instance,
                Asia.Jordan.Instance,
                Africa.Kenya.Instance,
                Oceania.Kiribati.Instance,
                Africa.Comoros.Instance,
                Asia.Kyrgyzstan.Instance,
                Asia.SouthKorea.Instance,
                Asia.NorthKorea.Instance,
                Asia.Cambodia.Instance,
                NorthAmerica.CaymanIslands.Instance,
                Asia.Kuwait.Instance,
                Asia.Kazakhstan.Instance,
                Asia.LaoPDR.Instance,
                Asia.Lebanon.Instance,
                NorthAmerica.SaintLucia.Instance,
                Europe.Liechtenstein.Instance,
                Asia.SriLanka.Instance,
                Africa.Liberia.Instance,
                Africa.Lesotho.Instance,
                Europe.Lithuania.Instance,
                Europe.Luxembourg.Instance,
                Europe.Latvia.Instance,
                Africa.Libya.Instance,
                Asia.Macao.Instance,
                Europe.Mann.Instance,
                Africa.Mayotte.Instance,
                Oceania.Micronesia.Instance,
                Africa.Morocco.Instance,
                Europe.Monaco.Instance,
                Europe.Moldova.Instance,
                Europe.Montenegro.Instance,
                NorthAmerica.SaintMartinFrenchPart.Instance,
                NorthAmerica.SintMaartenDutchPart.Instance,
                Africa.Madagascar.Instance,
                Oceania.MarshallIslands.Instance,
                Europe.Macedonia.Instance,
                Africa.Mali.Instance,
                NorthAmerica.Mexico.Instance,
                Asia.Myanmar.Instance,
                Asia.Mongolia.Instance,
                Oceania.NorthernMarianaIslands.Instance,
                NorthAmerica.Martinique.Instance,
                Africa.Mauritania.Instance,
                NorthAmerica.Montserrat.Instance,
                Europe.Malta.Instance,
                Africa.Mauritius.Instance,
                Asia.Maldives.Instance,
                Africa.Malawi.Instance,
                Asia.Malaysia.Instance,
                Africa.Mozambique.Instance,
                Africa.Namibia.Instance,
                Oceania.NewCaledonia.Instance,
                Europe.Netherlands.Instance,
                Oceania.NewZealand.Instance,
                SouthAmerica.Nicaragua.Instance,
                Africa.Niger.Instance,
                Africa.Nigeria.Instance,
                Oceania.NorfolkIsland.Instance,
                Asia.Nepal.Instance,
                Oceania.Nauru.Instance,
                Oceania.Niue.Instance,
                Europe.Norway.Instance,
                Asia.Oman.Instance,
                NorthAmerica.Panama.Instance,
                SouthAmerica.Paraguay.Instance,
                SouthAmerica.Peru.Instance,
                Oceania.Polynesia.Instance,
                Oceania.PapuaNewGuinea.Instance,
                Asia.Philippines.Instance,
                Asia.Pakistan.Instance,
                Europe.Poland.Instance,
                NorthAmerica.SaintPierreAndMiquelon.Instance,
                Oceania.Pitcairn.Instance,
                NorthAmerica.PuertoRico.Instance,
                Asia.Palestine.Instance,
                Europe.Portugal.Instance,
                Oceania.Palau.Instance,
                Asia.Qatar.Instance,
                Africa.Réunion.Instance,
                Europe.Romania.Instance,
                Europe.Russia.Instance,
                Africa.Rwanda.Instance,
                SouthAmerica.SGSSI.Instance,
                NorthAmerica.SaintBarts.Instance,
                Oceania.Samoa.Instance,
                Asia.SaudiArabia.Instance,
                NorthAmerica.SaintKittsAndNevis.Instance,
                NorthAmerica.StVAndG.Instance,
                Europe.Serbia.Instance,
                Oceania.SolomonIslands.Instance,
                Africa.Seychelles.Instance,
                Africa.Sudan.Instance,
                Europe.Sweden.Instance,
                Asia.Singapore.Instance,
                Europe.Slovenia.Instance,
                Africa.SaintHelena.Instance,
                Europe.SvalbardAndJanMayen.Instance,
                Europe.Slovakia.Instance,
                Africa.SierraLeone.Instance,
                Europe.SanMarino.Instance,
                Africa.Senegal.Instance,
                Africa.Somalia.Instance,
                Africa.Suriname.Instance,
                Africa.SouthSudan.Instance,
                Africa.SouthAfrica.Instance,
                Africa.SaoTomeAndPrincipe.Instance,
                Europe.Spain.Instance,
                Europe.Switzerland.Instance,
                Asia.Syrian.Instance,
                Africa.Swaziland.Instance,
                NorthAmerica.ElSalvador.Instance,
                Asia.Taiwan.Instance,
                Africa.Tanzania.Instance,
                NorthAmerica.TrinidadAndTobago.Instance,
                NorthAmerica.TurksAndCaicosIslands.Instance,
                Africa.Chad.Instance,
                Africa.FrenchSouthernTerritories.Instance,
                Africa.Togo.Instance,
                Asia.Thailand.Instance,
                Asia.Tajikistan.Instance,
                Oceania.Tokelau.Instance,
                Asia.EastTimor.Instance,
                Asia.Turkmenistan.Instance,
                Africa.Tunisia.Instance,
                Oceania.Tonga.Instance,
                Asia.Turkey.Instance,
                Oceania.Tuvalu.Instance,
                Africa.Uganda.Instance,
                Europe.Ukraine.Instance,
                Asia.UnitedArabEmirates.Instance,
                Europe.UnitedKingdom.Instance,
                NorthAmerica.UnitedStates.Instance,
                NorthAmerica.UnitedStatesMinorOutlyingIslands.Instance,
                SouthAmerica.Uruguay.Instance,
                Asia.Uzbekistan.Instance,
                SouthAmerica.Venezuela.Instance,
                Asia.Vietnam.Instance,
                NorthAmerica.VirginIslandsBritish.Instance,
                NorthAmerica.VirginIslandsUS.Instance,
                Oceania.Vanuatu.Instance,
                Oceania.WallisAndFutuna.Instance,
                Africa.WesternSahara.Instance,
                Europe.Kosovo.Instance,
                Asia.Yemen.Instance,
                Europe.Yugoslavia1992.Instance,
                Africa.Zambia.Instance,
                Africa.Zimbabwe.Instance,
            };
        }
    }
}