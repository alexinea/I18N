using Cosmos.I18N.Core;
using Cosmos.I18N.RunsOn.ConsoleService;

namespace Cosmos.Dependency
{
    /// <summary>
    /// Extensions for done
    /// </summary>
    public static class DependencyExtensions
    {
        /// <summary>
        /// ALl done
        /// </summary>
        /// <param name="services"></param>
        public static void AllDone(this II18NServiceCollection services)
        {
            SoloDependencyContainer.AllDone(services);
        }
    }
}