namespace Cosmos.I18N.Countries
{
    public readonly struct ExistenceCycle
    {
        /// <summary>
        /// Since
        /// </summary>
        public int Since { get; }

        /// <summary>
        /// Ended in
        /// </summary>
        public int? EndedIn { get; }

        /// <summary>
        /// Create a new instance of <see cref="ExistenceCycle"/>
        /// </summary>
        /// <param name="since"></param>
        public ExistenceCycle(int since)
        {
            Since = since;
            EndedIn = null;
        }

        /// <summary>
        /// Create a new instance of <see cref="ExistenceCycle"/>
        /// </summary>
        /// <param name="since"></param>
        /// <param name="endedIn"></param>
        public ExistenceCycle(int since, int endedIn)
        {
            Since = since;
            EndedIn = endedIn;
        }
    }
}