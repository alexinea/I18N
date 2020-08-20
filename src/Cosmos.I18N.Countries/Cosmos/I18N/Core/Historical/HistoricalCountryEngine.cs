using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Cosmos.I18N.Core.Historical
{
    internal static class HistoricalCountryEngine
    {
        private static readonly Dictionary<long, List<(long, int, int?)>> firstLevelNav;
        private static readonly Dictionary<(long, int, int?), HistoricalCountryNav> _allNavs;
        private static readonly object _opLockObj = new object();

        static HistoricalCountryEngine()
        {
            firstLevelNav = new Dictionary<long, List<(long, int, int?)>>();
            _allNavs = new Dictionary<(long, int, int?), HistoricalCountryNav>();
        }

        public static IEnumerable<HistoricalCountryNav> GetNav(long code, int year, int month, int day)
        {
            lock (_opLockObj)
            {
                var matchedKeys = firstLevelNav[code];

                if (matchedKeys is null || !matchedKeys.Any())
                    yield return null;

                var mark = year * 10000 + month * 100 + day;
                var sourceNavs = _allNavs.Where(pair => matchedKeys!.Contains(pair.Key)).Select(pair => pair.Value);

                foreach (var nav in sourceNavs)
                foreach (var ret in TrackSourceNav(nav, mark))
                    yield return ret;
            }
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

        [SuppressMessage("ReSharper", "InconsistentNaming")]
        [SuppressMessage("ReSharper", "InconsistentlySynchronizedField")]
        public static void AddNav(HistoricalCountryNav nav)
        {
            if (nav is null)
                return;

            lock (_opLockObj)
            {
                __updateAllNavs(nav);
                __updateFirstLevelNav(nav);
            }

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
        }
    }
}