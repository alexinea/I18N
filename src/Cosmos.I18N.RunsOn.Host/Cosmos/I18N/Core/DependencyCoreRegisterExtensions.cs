using Cosmos.Dependency;
using Microsoft.Extensions.DependencyInjection;

namespace Cosmos.I18N.Core
{
    internal static class DependencyCoreRegisterExtensions
    {
        public static void AppendOrOverride(this II18NServiceCollection services)
        {
            services.AddDependency(s =>
            {
                s.AddSingleton<ICoreScopedLanguageTagFactory, HostedLanguageTagFactory>();
                s.AddScoped<IRequestedLanguageTagAccessor, RequestedLanguageTagAccessor>();
            });
        }

        public static void UpdateState(this II18NServiceCollection services)
        {
            if (services is DefaultI18NServiceCollection<MicrosoftProxyRegister, IServiceCollection> serviceImpl)
            {
                serviceImpl.AddPostRegisterAction("FlagState", s =>
                {
                    StaticFlag.HasInit = true;
                    StaticFlag.ExpectedServiceName = "HostImpl";
                });
            }
        }
    }
}