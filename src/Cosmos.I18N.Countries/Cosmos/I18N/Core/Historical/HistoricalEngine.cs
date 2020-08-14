using Cosmos.I18N.Countries;

namespace Cosmos.I18N.Core.Historical
{
    internal static class HistoricalEngine
    {
        public static RuntimeCountryInfo Get(RuntimeCountryInfo countryInfo, int year, int month, int day)
        {
            if (countryInfo.RuntimeHistoricalCountry == false)
                return countryInfo;

            //TODO
            return null;
        }
    }
}