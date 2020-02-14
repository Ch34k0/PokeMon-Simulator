namespace PokéMon_Simulator.Enumerations
{
    public enum PS_ItemAction : byte
    {
        /// <summary>
        /// Das Item hat den primären oder sekundären Status von einem PokéMon geändert.
        /// </summary>
        ChangedStatus = 0,

        /// <summary>
        /// Das Item wurde von einem PokéMon konsumiert.
        /// </summary>
        Consumed = 1,

        /// <summary>
        /// Das Item hat was mit Schaden zu tun.
        /// </summary>
        Damage = 2,

        /// <summary>
        /// Das Item hat die KP eines PokéMon aufgefüllt.
        /// </summary>
        RestoredHP = 3
    }
}
