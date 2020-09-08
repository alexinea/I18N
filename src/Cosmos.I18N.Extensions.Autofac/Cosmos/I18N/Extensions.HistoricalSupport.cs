using System.Collections.Generic;
using Cosmos.I18N.Core;
using Cosmos.I18N.Core.Historical;
using Microsoft.Extensions.Configuration;

namespace Cosmos.I18N
{
    public static class HistoricalSupportExtensions
    {
        public static II18NServiceCollection AddHistoricalSupport(this II18NServiceCollection services, IConfigurationSection config)
        {
            var models = config.GetValue<IEnumerable<HistoricalCountryModel>>("Historical");

            HistoricalCountryStarter.AppendConfiguredCountries(models);

            return services;
        }
    }
}