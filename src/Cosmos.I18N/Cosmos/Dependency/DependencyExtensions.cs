using System;
using Cosmos.I18N;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Languages;
using Cosmos.I18N.Translation;

namespace Cosmos.Dependency
{
    public static class DependencyExtensions
    {
        /// <summary>
        /// Add Cosmos.I18N, and start to config the i18n service.
        /// </summary>
        /// <param name="register"></param>
        /// <param name="optionAct"></param>
        /// <typeparam name="TRegister"></typeparam>
        /// <typeparam name="TService"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static II18NServiceCollection AddInternationalizationService<TRegister, TService>(this TRegister register, Action<I18NOptions> optionAct = null)
            where TRegister : DependencyProxyRegister<TService>
        {
            if (register is null)
                throw new ArgumentNullException(nameof(register));

            return new DefaultI18NServiceCollection<TRegister, TService>(register, I18NOptions.Create(optionAct));
        }

        /// <summary>
        /// Done
        /// </summary>
        /// <param name="services"></param>
        /// <typeparam name="TRegister"></typeparam>
        /// <typeparam name="TService"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static TRegister Done<TRegister, TService>(this II18NServiceCollection services)
            where TRegister : DependencyProxyRegister<TService>
        {
            if (services is null)
                throw new ArgumentNullException(nameof(services));

            if (services is DefaultI18NServiceCollection<TRegister, TService> serviceImpl)
            {
                var register = serviceImpl.OriginalRegister;

                if (!StaticFlag.HasInit)
                {
                    var options = services.ExposeOptions;

                    services.RegisterAllPackages(options);

                    services.RegisterTranslationProcessor();

                    services.RegisterTranslationProviders();

                    services.RegisterTranslationAccessor();
                }

                return register;
            }

            throw new ArgumentException("Unknown type of II18NServiceCollection");
        }

        private static void RegisterAllPackages(this II18NServiceCollection services, I18NOptions options)
        {
            var translationManager = new TranslationManager();
            var translationSetter = (ITranslationManSetter) translationManager;

            foreach (var package in options.TranslationPackages)
            {
                var translationPackage = package.Value;
                translationSetter.RegisterPackage(translationPackage);
                services.AddDependency(register => register.AddSingletonService(translationPackage));
            }


            services.AddDependency(register => register.AddSingletonService(translationManager));
            services.AddDependency(register => register.AddSingletonService<ITranslationManager>(translationManager));
        }

        private static void RegisterTranslationProviders(this II18NServiceCollection services)
        {
            services.AddDependency(register => register.AddSingleton<ITextProvider, TextProvider>());
            services.AddDependency(register => register.AddSingleton<ILanguageServiceProvider, DefaultLanguageServiceProvider>());
        }

        private static void RegisterTranslationAccessor(this II18NServiceCollection services)
        {
            var tagFactory = new DefaultLanguageTagFactory(LanguageTag.Current.ToString);
            services.AddDependency(register => register.AddSingletonService<ICoreScopedLanguageTagFactory>(tagFactory));
            services.AddDependency(register => register.AddScoped<ITranslationAccessor, DefaultTranslationAccessor>());
        }

        private static void RegisterTranslationProcessor(this II18NServiceCollection services)
        {
            services.AddDependency(s => s.AddSingleton<TranslationProcessor>());
        }
    }
}