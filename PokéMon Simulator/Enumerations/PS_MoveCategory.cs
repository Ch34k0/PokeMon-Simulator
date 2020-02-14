namespace PokéMon_Simulator.Enumerations
{
    public enum PS_MoveCategory : byte
    {
        /// <summary>
        /// Die Attacke verursacht keinen Schaden.
        /// </summary>
        Status,

        /// <summary>
        /// Die Attacke verursacht physischen Schaden mit dem Angriff und Verteidigung Stat.
        /// </summary>
        Physical,

        /// <summary>
        /// Die Attacke verursacht speziellen Schaden mit dem Spezial Angriff und Spezial Verteidigung Stat.
        /// </summary>
        Special,

        /// <summary>
        /// Ungültige Kategorie.
        /// </summary>
        ERROR
    }
}
