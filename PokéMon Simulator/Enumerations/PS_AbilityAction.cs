using System;
using System.Collections.Generic;
using System.Text;

namespace PokéMon_Simulator.Enumerations
{
    public enum PS_AbilityAction : byte
    {
        /// <summary>The ability is first announced.</summary>
        Announced = 0,
        /// <summary>The ability was changed.</summary>
        Changed = 1,
        /// <summary>The ability caused a Pokémon to change its appearance.</summary>
        ChangedAppearance = 2,
        /// <summary>The ability changed a Pokémon's stats.</summary>
        ChangedStats = 3,
        /// <summary>The ability changed a Pokémon's <see cref="PrimaryStatus"/> or <see cref="SecondaryStatus"/>.</summary>
        ChangedStatus = 4,
        /// <summary>The ability was involved with damage.</summary>
        Damage = 5,
        /// <summary>The ability prevented a Pokémon from being inflicted with a <see cref="PrimaryStatus"/> or <see cref="SecondaryStatus"/>.</summary>
        PreventedStatus = 6,
        /// <summary>The ability restored a Pokémon's HP.</summary>
        RestoredHP = 7,
        /// <summary><see cref="Ability.SlowStart"/> ended.</summary>
        SlowStart_Ended = 8,
        /// <summary>The ability was involved with weather.</summary>
        Weather = 9
    }
}
