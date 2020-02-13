using System;
using System.Collections.Generic;
using System.Text;

namespace PokéMon_Simulator.Enumerations
{
    [Flags]
    public enum PS_BattleStatus : byte
    {
        /// <summary>Der Kampf hat keinen Status.</summary>
        None,
        /// <summary>
        /// Die Reihenfolge der agierenden PokéMon wird umgedreht. 
        /// Das bezieht sich nur auf SPEED, nicht aber auf Prioritäten!
        /// </summary>
        TrickRoom = 1 << 0
    }
}
