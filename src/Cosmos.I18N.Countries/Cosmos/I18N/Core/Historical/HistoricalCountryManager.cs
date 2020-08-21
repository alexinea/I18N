using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Countries;

namespace Cosmos.I18N.Core.Historical
{
    internal static class HistoricalCountryManager
    {
        public static IEnumerable<RuntimeCountryInfo> Get(Country country, int year, int month, int day)
        {
            return Get(CountryManager.GetCountryInfo(country), year, month, day);
        }

        public static IEnumerable<RuntimeCountryInfo> Get(CountryCode code, int year, int month, int day)
        {
            return Get(CountryManager.GetCountryInfo(code), year, month, day);
        }

        public static IEnumerable<RuntimeCountryInfo> Get(string alphaCode, int year, int month, int day)
        {
            return Get(CountryManager.GetCountryInfo(alphaCode), year, month, day);
        }

        public static IEnumerable<RuntimeCountryInfo> Get(CountryInfo countryInfo, int year, int month, int day)
        {
            return InternalGet(countryInfo.Cep1CrCode, year, month, day);
        }

        public static IEnumerable<RuntimeCountryInfo> Get(RuntimeCountryInfo countryInfo, int year, int month, int day)
        {
            return countryInfo.IsHistorical == false
                ? new[] {countryInfo}
                : InternalGet(countryInfo.Cep1CrCode, year, month, day);
        }

        public static IEnumerable<RuntimeCountryInfo> Get(RegionCodeValue code, int year, int month, int day)
        {
            return code.IsHistoricalValue() == false
                ? new[] {RuntimeCountryInfoCache.GetOrDefault(code)}
                : InternalGet(code, year, month, day);
        }

        private static IEnumerable<RuntimeCountryInfo> InternalGet(long cep1CrCode, int year, int month, int day)
        {
            var navs = HistoricalCountryEngine.GetNav(cep1CrCode, year, month, day);

            return navs.Select(nav => nav.Code).Select(RuntimeCountryInfoCache.GetOrDefault).Where(item => item != null);
        }

        public static IEnumerable<RuntimeCountryInfo> GetByAlias(string alias, int year, int month, int day)
        {
            var navs = HistoricalCountryEngine.GetNav(alias, year, month, day);

            return navs.Select(nav => nav.Code).Select(RuntimeCountryInfoCache.GetOrDefault).Where(item => item != null);
        }
    }
}