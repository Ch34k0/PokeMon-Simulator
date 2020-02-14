namespace PokéMon_Simulator.Enumerations
{
    public enum PS_TeamStatusAction : byte
    {
        /// <summary>
        /// Das Team hat den Status erhalten.
        /// </summary>
        Added = 0,

        /// <summary>
        /// Der Status wurde vom Team entfernt.
        /// </summary>
        Cleared = 1,

        /// <summary>
        /// Der Status hat dafür gesorgt, dass ein PokéMon Schaden erleidet.
        /// </summary>
        Damage = 2,

        /// <summary>
        /// Der Status ist vorbei.
        /// </summary>
        Ended = 3
    }
}
