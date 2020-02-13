using System;
using System.Collections.Generic;
using System.Text;

namespace PokéMon_Simulator.Enumerations
{
    public enum PS_StatusAction : byte
    {
        /// <summary>
        /// Der Status hat seinen Haupteffekt ausgelöst.
        /// </summary>
        Activated = 0,

        /// <summary>
        /// Der Status wurde einem PokéMon hinzugefügt.
        /// </summary>
        Added = 1,

        /// <summary>
        /// Der Status hat ein PokéMon daran gehindert zu agieren.
        /// </summary>
        CausedImmobility = 2,

        /// <summary>
        /// Der Status wurde geheilt.
        /// </summary>
        Cured = 3,

        /// <summary>
        /// Der Status hat Schaden verursacht.
        /// </summary>
        Damage = 4,

        /// <summary>
        /// Der Status ist zu Ende.
        /// </summary>
        Ended = 5
    }
}
