namespace PokéMon_Simulator.Enumerations
{
    public enum PS_TerrainAction : byte
    {
        /// <summary>
        /// Der Feldeffekt wurde gestartet.
        /// </summary>
        Added = 0,

        /// <summary>
        /// Der Feldeffekt wurde vom Team entfernt.
        /// </summary>
        Cleared = 1,

        /// <summary>
        /// Der Feldeffekt sorgte dafür, dass ein PokéMon nicht mit einem primären oder sekundären Status befallen wurde.
        /// </summary>
        PreventedStatus = 6,

        /// <summary>
        /// Der Feldeffekt sorgte dafür, dass die KP eines PokéMon geheilt wurden.
        /// </summary>
        RestoredHP = 7,

        /// <summary>
        /// Der Feldeffekt ist vorbei.
        /// </summary>
        Ended = 2,
    }
}
