using System.Collections.Generic;

namespace Cosmos.I18N.Core.Historical
{
    internal class HistoricalCountryNav
    {
        /// <summary>
        /// Key (CrCode/SinceYear/EndYear)
        /// </summary>
        public (long, int, int?) Key { get; set; }

        /// <summary>
        /// Cosmos region code / CEP-1
        /// </summary>
        public long Code { get; set; }

        public (long, int, int?) Previous { get; set; }

        public List<(long, int, int?)> Next { get; set; } = new List<(long, int, int?)>();

        private bool IsHistoricalMode() => Key.Item3.HasValue;

        public int Go(int mark)
        {
            if (IsHistoricalMode())
            {
                if (mark > Key.Item3!.Value)
                    return 1;
                if (mark < Key.Item2)
                    return -1;
                return 0;
            }
            else
            {
                if (mark < Key.Item2)
                    return -1;
                return 0;
            }
        }
    }
}