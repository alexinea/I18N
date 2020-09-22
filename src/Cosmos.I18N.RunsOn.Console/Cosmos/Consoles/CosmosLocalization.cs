using Cosmos.I18N.Core;
using Cosmos.I18N.RunsOn.ConsoleService;

namespace Cosmos.Consoles {
    /// <summary>
    /// Cosmos localization helper
    /// </summary>
    public static class CosmosLocalization {
        /// <summary>
        /// Initialize
        /// </summary>
        /// <returns></returns>
        public static II18NServiceCollection Initialize() {
            return SoloDependencyContainer.Initialize(new ConsoleI18NServiceCollection());
        }
    }
}