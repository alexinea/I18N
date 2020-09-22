using System;
using Cosmos.Dependency;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;

namespace Autofac
{
    /// <summary>
    /// Extensions for Autofac register
    /// </summary>
    public static class DependencyExtensions
    {
        /// <summary>
        /// Register Cosmos.I18N for Autofac
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="optionAct"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static II18NServiceCollection RegisterInternationalizationService(this ContainerBuilder builder, Action<I18NOptions> optionAct = null)
        {
            var register = new AutofacProxyRegister(builder);
            return register.AddInternationalizationService<AutofacProxyRegister, ContainerBuilder>(optionAct);
        }

        /// <summary>
        /// Done
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ContainerBuilder Done(this II18NServiceCollection services)
        {
            using var register = services.Done<AutofacProxyRegister, ContainerBuilder>();

            return register.RawServices;
        }
    }
}