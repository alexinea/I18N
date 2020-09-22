using System;
using Cosmos.Dependency;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;

namespace AspectCore.DependencyInjection
{
    /// <summary>
    /// Extensions for AspectCore register
    /// </summary>
    public static class DependencyExtensions
    {
        /// <summary>
        /// Register Cosmos.I18N for NCC AspectCore
        /// </summary>
        /// <param name="context"></param>
        /// <param name="optionAct"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static II18NServiceCollection AddInternationalizationService(this IServiceContext context, Action<I18NOptions> optionAct = null)
        {
            var register = new AspectCoreProxyRegister(context);
            return register.AddInternationalizationService<AspectCoreProxyRegister, IServiceContext>(optionAct);
        }

        /// <summary>
        /// Done
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceContext Done(this II18NServiceCollection services)
        {
            using var register = services.Done<AspectCoreProxyRegister, IServiceContext>();

            return register.RawServices;
        }
    }
}