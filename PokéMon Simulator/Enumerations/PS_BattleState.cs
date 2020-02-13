using System;
using System.Collections.Generic;
using System.Text;

namespace PokéMon_Simulator.Enumerations
{
    public enum PS_BattleState : byte
    {       
        WaitingForPlayers,
        ReadyToBegin,
        WaitingForActions,
        ReadyToRunTurn,
        Processing,
        WaitingForSwitchIns,
        Ended
    }
}
