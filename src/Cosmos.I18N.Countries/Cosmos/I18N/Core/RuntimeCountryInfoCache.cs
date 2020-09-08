using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Cosmos.Collections;
using Cosmos.I18N.Countries;

namespace Cosmos.I18N.Core
{
    internal static class RuntimeCountryInfoCache
    {
        private static readonly ConcurrentDictionary<long, RuntimeCountryInfo> CachedData;
        private static bool _hasInit;

        static RuntimeCountryInfoCache()
        {
            CachedData = new ConcurrentDictionary<long, RuntimeCountryInfo>();
        }

        public static RuntimeCountryInfo GetOrAdd(long cep1CrCode, Func<long, RuntimeCountryInfo> factory)
        {
            return CachedData.GetOrAdd(cep1CrCode, factory);
        }

        public static RuntimeCountryInfo GetOrDefault(long cep1Code)
        {
            return ((IDictionary<long, RuntimeCountryInfo>) CachedData).GetValueOrDefault(cep1Code);
        }

        public static RuntimeCountryInfo GetOrDefault(RegionCodeValue code)
        {
            return ((IDictionary<long, RuntimeCountryInfo>) CachedData).GetValueOrDefault(code);
        }

        public static void FirstTimeUpdate(IEnumerable<CountryInfo> data)
        {
            if (!_hasInit)
            {
                CachedData.Clear();

                foreach (var info in data)
                {
                    CachedData[info.Cep1CrCode] = RuntimeCountryInfo.Of(info);
                }

                _hasInit = true;
            }
        }

        public static void RuntimeUpdate(RuntimeCountryInfo info)
        {
            CachedData.AddOrUpdate(info.Cep1CrCode,
                k => info,
                (k, v) => info);
        }

        public static void RuntimeUpdateRange(IEnumerable<RuntimeCountryInfo> infos)
        {
            foreach (var info in infos)
                RuntimeUpdate(info);
        }
    }
}