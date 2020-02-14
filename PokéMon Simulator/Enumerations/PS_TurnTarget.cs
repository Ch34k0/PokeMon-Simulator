using System;

namespace PokéMon_Simulator.Enumerations
{
    [Flags]
    public enum PS_TurnTarget : byte
    {
        /// <summary>
        /// Kein Ziel.
        /// </summary>
        None,

        /// <summary>
        /// Das Ziel ist das PokéMon auf der linken Seite des Spielers.
        /// </summary>
        AllyLeft = 1 << 0,

        /// <summary>
        /// Das Ziel ist das PokéMon mittig auf der Seite des Spielers.
        /// </summary>
        AllyCenter = 1 << 1,

        /// <summary>
        /// Das Ziel ist das PokéMon auf der rechten Seite des Spielers.
        /// </summary>
        AllyRight = 1 << 2,

        /// <summary>
        /// Das Ziel ist das PokéMon auf der linken Seite des Gegners.
        /// </summary>
        FoeLeft = 1 << 3,

        /// <summary>
        /// Das Ziel ist das PokéMon mittig auf der Seite des Gegners.
        /// </summary>
        FoeCenter = 1 << 4,

        /// <summary>
        /// Das Ziel ist das PokéMon auf der rechten Seite des Gegners.
        /// </summary>
        FoeRight = 1 << 5
    }
}
