using System;
using Cosmos.Dependency;
using Cosmos.I18N.Core;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Translation;

namespace Cosmos.I18N.RunsOn.ConsoleService
{
    internal static class SoloDependencyContainer
    {
        private static IServiceProvider ServiceResolver { get; set; }
        public static void SetResolver(IServiceProvider resolver) => ServiceResolver = resolver;

        internal static ConsoleI18NServiceCollection Initialize(ConsoleI18NServiceCollection serviceImpl)
        {
            return serviceImpl;
        }

        internal static void AllDone(II18NServiceCollection services)
        {
            if (!StaticFlag.HasInit && services is ConsoleI18NServiceCollection serviceImpl)
            {
                using (serviceImpl)
                {
                    serviceImpl.RegisterAllPackages();

                    serviceImpl.RegisterTranslationProcessor();

                    serviceImpl.RegisterTranslationProviders();

                    serviceImpl.RegisterTranslationAccessor();
                }

                SetResolver(serviceImpl.Build());

                StaticFlag.HasInit = true;
                StaticFlag.ExpectedServiceName = "ConsoleImpl";
            }
        }

        private static void RegisterAllPackages(this II18NServiceCollection services)
        {
            var translationManager = services.ExposeTranslationManager;
            var translationSetter = (ITranslationManSetter) translationManager;

            foreach (var package in services.ExposeOptions.TranslationPackages)
            {
                var translationPackage = package.Value;
                translationSetter.RegisterPackage(translationPackage);
                services.AddDependency(s => s.AddSingletonService(translationPackage));
            }

            services.AddDependency(s =>
            {
                s.AddSingletonService(translationManager);
                s.AddSingletonService<ITranslationManager>(translationManager);
            });
        }

        private static void RegisterTranslationProcessor(this II18NServiceCollection services)
        {
            services.AddDependency(s => s.AddSingleton<TranslationProcessor>());
        }

        private static void RegisterTranslationProviders(this II18NServiceCollection services)
        {
            services.AddDependency(s =>
            {
                s.AddSingleton<ITextProvider, TextProvider>();
                s.AddSingleton<ILanguageServiceProvider, DefaultLanguageServiceProvider>();
            });
        }

        private static void RegisterTranslationAccessor(this II18NServiceCollection services)
        {
            var tagFactory = new DefaultLanguageTagFactory(LanguageTag.Current.ToString);
            services.AddDependency(s =>
            {
                s.AddSingletonService<ICoreScopedLanguageTagFactory>(tagFactory);
                s.AddScoped<ITranslationAccessor, DefaultTranslationAccessor>();
            });
        }

        public static IServiceProvider GetServiceResolver() => ServiceResolver ?? throw new NullReferenceException(nameof(ServiceResolver));
    }
}