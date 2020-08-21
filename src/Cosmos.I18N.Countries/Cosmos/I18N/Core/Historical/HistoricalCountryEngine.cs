using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Cosmos.I18N.Countries;
using EnumsNET;

namespace Cosmos.I18N.Core.Historical
{
    internal static class HistoricalCountryEngine
    {
        private static readonly Dictionary<long, List<(long, int, int?)>> firstLevelNav;
        private static readonly Dictionary<string, List<(long, int, int?)>> firstLevelStringNav;
        private static readonly Dictionary<(long, int, int?), HistoricalCountryNav> _allNavs;
        private static readonly object _opLockObj = new object();
        private static bool _hasInit;

        static HistoricalCountryEngine()
        {
            firstLevelNav = new Dictionary<long, List<(long, int, int?)>>();
            firstLevelStringNav = new Dictionary<string, List<(long, int, int?)>>();
            _allNavs = new Dictionary<(long, int, int?), HistoricalCountryNav>();
        }

        public static IEnumerable<HistoricalCountryNav> GetNav(long code, int year, int month, int day)
        {
            lock (_opLockObj)
            {
                return TouchNavs(firstLevelNav[code], year, month, day);
            }
        }

        public static IEnumerable<HistoricalCountryNav> GetNav(string alias, int year, int month, int day)
        {
            lock (_opLockObj)
            {
                return TouchNavs(firstLevelStringNav[alias], year, month, day);
            }
        }

        private static IEnumerable<HistoricalCountryNav> TouchNavs(ICollection<(long, int, int?)> matchedKeys, int year, int month, int day)
        {
            if (matchedKeys is null || !matchedKeys.Any())
                yield return null;

            var mark = year * 10000 + month * 100 + day;
            var sourceNavs = _allNavs.Where(pair => matchedKeys!.Contains(pair.Key)).Select(pair => pair.Value);

            foreach (var nav in sourceNavs)
            foreach (var ret in TrackSourceNav(nav, mark))
                yield return ret;
        }

        private static IEnumerable<HistoricalCountryNav> TrackSourceNav(HistoricalCountryNav nav, int mark)
        {
            if (nav is null)
                yield return null;

            var go = nav!.Go(mark);

            if (go > 0)
            {
                foreach (var key in nav.Next)
                foreach (var t in TrackSourceNav(_allNavs[key], mark))
                    yield return t;
            }

            if (go < 0)
            {
                foreach (var t in TrackSourceNav(_allNavs[nav.Previous], mark))
                    yield return t;
            }

            yield return nav;
        }

        public static void AddNav(HistoricalCountryNav nav)
        {
            if (nav is null)
                return;

            lock (_opLockObj)
            {
                AddNavWithoutLock(nav);
            }
        }

        public static void FirstTimeUpdate(IEnumerable<CountryInfo> data)
        {
            if (!_hasInit)
            {
                lock (_opLockObj)
                {
                    if (_hasInit)
                        return;

                    firstLevelNav.Clear();
                    firstLevelStringNav.Clear();
                    _allNavs.Clear();

                    foreach (var info in data)
                    {
                        if (info.ExistenceCycle.HasValue)
                        {
                            var cycle = info.ExistenceCycle.Value;
                            var nav = new HistoricalCountryNav
                            {
                                Key = (info.Cep1CrCode, cycle.Since, cycle.EndedIn),
                                Code = info.Cep1CrCode,
                                Name = info.Country.GetName()
                            };
                            AddNavWithoutLock(nav);
                        }
                    }

                    _hasInit = true;
                }
            }
        }

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        [SuppressMessage("ReSharper", "InconsistentlySynchronizedField")]
        private static void AddNavWithoutLock(HistoricalCountryNav nav)
        {
            __updateAllNavs(nav);
            __updateFirstLevelNav(nav);
            __updateFirstLevelStringNav(nav);

            void __updateAllNavs(HistoricalCountryNav nav0)
            {
                var __key = nav0.Key;

                if (!_allNavs.ContainsKey(__key))
                    _allNavs.Add(__key, nav0);
            }

            void __updateFirstLevelNav(HistoricalCountryNav nav1)
            {
                var __key0 = nav1.Key.Item1;
                var __key1 = nav1.Key;

                if (firstLevelNav.ContainsKey(__key0))
                {
                    var list = firstLevelNav[__key0];

                    if (list is null)
                    {
                        list = new List<(long, int, int?)> {__key1};
                        firstLevelNav[__key0] = list;
                    }
                    else if (!list.Contains(__key1))
                    {
                        list.Add(__key1);
                    }
                }
                else
                {
                    firstLevelNav[__key0] = new List<(long, int, int?)> {__key1};
                }
            }

            void __updateFirstLevelStringNav(HistoricalCountryNav nav1)
            {
                var __key0 = nav1.Name;
                var __key1 = nav1.Key;

                if (firstLevelStringNav.ContainsKey(__key0))
                {
                    var list = firstLevelStringNav[__key0];

                    if (list is null)
                    {
                        list = new List<(long, int, int?)> {__key1};
                        firstLevelStringNav[__key0] = list;
                    }
                    else if (!list.Contains(__key1))
                    {
                        list.Add(__key1);
                    }
                }
                else
                {
                    firstLevelStringNav[__key0] = new List<(long, int, int?)> {__key1};
                }
            }
        }
    }
}