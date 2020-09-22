using System;
using Cosmos.I18N.Configurations;
using Cosmos.I18N.Core;
using Cosmos.I18N.Translation;

namespace Cosmos.Dependency
{
    public class DefaultI18NServiceCollection<TRegister, TService> : II18NServiceCollection, IDisposable
        where TRegister : DependencyProxyRegister<TService>
    {
        private readonly TRegister _register;

        private readonly I18NOptions _options;
        private readonly TranslationManager _translationManager;

        /// <summary>
        /// I18N service collection
        /// </summary>
        /// <param name="register"></param>
        /// <param name="options"></param>
        public DefaultI18NServiceCollection(TRegister register, I18NOptions options = null)
        {
            _register = register ?? throw new ArgumentNullException(nameof(register));
            _options = I18NOptions.Create(options);
            _translationManager = new TranslationManager();
        }

        /// <inheritdoc />
        public I18NOptions ExposeOptions => _options;

        /// <inheritdoc />
        public TranslationManager ExposeTranslationManager => _translationManager;

        /// <inheritdoc />
        public virtual II18NServiceCollection AppendOptionsAction(Action<I18NOptions> optionsAct)
        {
            optionsAct?.Invoke(_options);
            return this;
        }

        /// <inheritdoc />
        public virtual II18NServiceCollection AddDependency(Action<DependencyProxyRegister> dependencyAction)
        {
            dependencyAction?.Invoke(_register);
            return this;
        }

        /// <summary>
        /// Add post action
        /// </summary>
        /// <param name="key"></param>
        /// <param name="postAction"></param>
        public void AddPostRegisterAction(string key, Action<TService> postAction)
        {
            _register.AddPostRegister(key, postAction);
        }

        /// <summary>
        /// Gets original register
        /// </summary>
        public TRegister OriginalRegister => _register;

        /// <summary>
        /// Gets original services
        /// </summary>
        public TService OriginalServices => _register.RawServices;

        /// <inheritdoc />
        public void Dispose() => _register.Dispose();
    }
}