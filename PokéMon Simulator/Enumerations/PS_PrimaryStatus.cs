namespace PokéMon_Simulator.Enumerations
{
    public enum PS_PrimaryStatus : byte
    {
        /// <summary>
        /// Das PokéMon hat keinen primären Status.
        /// </summary>
        None,

        /// <summary>
        /// Das PokéMon ist eingeschlafen.
        /// </summary>
        Asleep,

        /// <summary>
        /// Das PokéMon ist schwer vergiftet.
        /// </summary>
        BadlyPoisoned,

        /// <summary>
        /// Das PokéMon ist verbrannt.
        /// </summary>
        Burned,

        /// <summary>
        /// Das PokéMon ist eingefroren.
        /// </summary>
        Frozen,

        /// <summary>
        /// Das PokéMon ist paralysiert.
        /// </summary>
        Paralyzed,

        /// <summary>
        /// Das PokéMon ist vergiftet.
        /// </summary>
        Poisoned
    }
}
