using System;
using Cosmos.Dependency;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Extensions for service collection
    /// </summary>
    public static class DependencyExtensions
    {
        /// <summary>
        /// Add Cosmos.I18N
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionAct"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static II18NServiceCollection AddInternationalizationService(this IServiceCollection services, Action<I18NOptions> optionAct = null)
        {
            var register = new MicrosoftProxyRegister(services);
            return register.AddInternationalizationService<MicrosoftProxyRegister, IServiceCollection>(optionAct);
        }

        /// <summary>
        /// Done
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceCollection Done(this II18NServiceCollection services)
        {
            using var register = services.Done<MicrosoftProxyRegister, IServiceCollection>();

            return register.RawServices;
        }
    }
}