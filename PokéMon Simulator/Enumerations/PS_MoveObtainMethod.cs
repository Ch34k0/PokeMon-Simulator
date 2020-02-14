using System;

namespace PokéMon_Simulator.Enumerations
{
    [Flags]
    public enum PS_MoveObtainMethod : ulong
    {
        /// <summary>
        /// Es gibt keine Möglichkeit wie das PokéMon diese Attacke erlernen kann.
        /// </summary>
        None,

        /// <summary>
        /// Die Attacke kann per Level-UP erlernt werden.
        /// </summary>
        LevelUp = 1uL << 0,

        /// <summary>
        /// Die Attacke kann mit einer TM erlernt werden.
        /// </summary>
        TM = 1uL << 1,

        /// <summary>
        /// Die Attacke kann mit einer TP erlernt werden.
        /// </summary>
        TP = 1uL << 2,

        /// <summary>
        /// Die Attacke kann von einem Attacken-Lehrer erlernt werden.
        /// </summary>        
        MoveTutor = 1uL << 3,

        /// <summary>
        /// Die Attacke kann vererbt sein.
        /// </summary>
        EggMove = 1uL << 4,

        /// <summary>
        /// Die Attacke kann mit bestimmten Voraussetzungen vererbt sein.
        /// </summary>
        EggMove_Special = 1uL << 5,

        /// <summary>
        /// Ein PokéMon aus der DreamWorld kann diese Attacke erlernt haben.
        /// </summary>
        DreamWorld = 1uL << 6,

        /// <summary>
        /// Die Attacke kann bei einem Formwechsel erlernt werden.
        /// </summary>
        Form = 1uL << 7
    }
}
