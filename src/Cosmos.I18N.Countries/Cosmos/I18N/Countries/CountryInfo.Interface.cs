using System;
using System.Collections.Generic;

namespace Cosmos.I18N.Countries
{
    /// <summary>
    /// Interface for country info
    /// </summary>
    public interface ICountryInfo
    {
        /// <summary>
        /// Country type
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        CountryType CountryType { get; }

        /// <summary>
        /// M49 code / ISO 3166-1 numeric
        /// </summary>
        // ReSharper disable once InconsistentNaming
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string M49Code { get; }

        /// <summary>
        /// Cosmos Regions Code
        /// </summary>
        // ReSharper disable once InconsistentNaming
        long Cep1CrCode { get; }

        /// <summary>
        /// Alpha2 code / ISO 3166-1 alpha-2
        /// </summary>
        string Alpha2Code { get; }

        /// <summary>
        /// Alpha3 code / ISO 3166-1 alpha-3
        /// </summary>
        string Alpha3Code { get; }

        /// <summary>
        /// Name
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string Name { get; }

        /// <summary>
        /// Shorter form
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string ShorterForm { get; }

        /// <summary>
        /// Alias
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string Alias { get; }

        /// <summary>
        /// Chinese name
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string ChineseName { get; }

        /// <summary>
        /// Chinese shorter form
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string ChineseShorterForm { get; }

        /// <summary>
        /// Chinese alias
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string ChineseAlias { get; }

        /// <summary>
        /// Chinese alias 2
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string ChineseAlias2 { get; }

        /// <summary>
        /// Continent
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        Continent Continent { get; }

        /// <summary>
        /// I18n Identity code
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        string I18NIdentityCode { get; }

        /// <summary>
        /// Commonwealth of nations
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        bool CommonwealthOfNations { get; }

        /// <summary>
        /// Historical country
        /// </summary>
        bool IsHistorical { get; }

        /// <summary>
        /// Convert to runtime country info.
        /// </summary>
        /// <returns></returns>
        RuntimeCountryInfo ToRuntimeModel();

        /// <summary>
        /// Get country enum value.
        /// </summary>
        /// <returns></returns>
        CountryEnumValue GetCountryEnumValue();

        /// <summary>
        /// Gets country code value.
        /// </summary>
        /// <returns></returns>
        CountryCodeValue GetCountryCodeValue();

        /// <summary>
        /// Gets region enum value factory.
        /// </summary>
        Func<RegionCodeValue, RegionEnumValue> GetRegionEnumValue { get; }

        /// <summary>
        /// Gets current country/region existence cycle
        /// </summary>
        ExistenceCycle? ExistenceCycle { get; }
    }
}