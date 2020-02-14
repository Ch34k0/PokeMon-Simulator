using System;

namespace PokéMon_Simulator.Enumerations
{
    [Flags]
    public enum PS_TeamStatus : ushort
    {
        /// <summary>
        /// Das Team hat keinen Status.
        /// </summary>
        None,

        /// <summary>
        /// Das Team erleidet weniger Schaden von <see cref="PS_MoveCategory.Special"/> Attacken.
        /// </summary>
        LightScreen = 1 << 0,

        /// <summary>
        /// Das Team ist vor Volltreffern geschützt.
        /// </summary>
        LuckyChant = 1 << 1,

        /// <summary>
        /// Das Team erleidet weniger Schaden von <see cref="PS_MoveCategory.Physical"/> Attacken.
        /// </summary>
        Reflect = 1 << 2,

        Safeguard = 1 << 3,

        /// <summary>
        /// Pokémon, die gerade einwechseln und den Boden berühren, erleiden Schaden. The amount of damage is based on <see cref="Team.SpikeCount"/>. 
        /// </summary>
        Spikes = 1 << 4, // TODO: Gravity, magic guard, iron ball, baton pass with ingrain, air balloon

        /// <summary>
        /// Pokémon, die gerade einwechseln und den Boden berühren, erleiden Schaden. The amount of damage is based on the effectiveness of <see cref="PS_Types.Rock"/> on the Pokémon. 
        /// </summary>
        StealthRock = 1 << 5, // TODO: magic guard

        Tailwind = 1 << 6,

        /// <summary>
        /// Pokémon, die gerade einwechseln und den Boden berühren, erhalten 
        /// <see cref="PS_PrimaryStatus.Poisoned"/> wenn <see cref="PS_Team.ToxicSpikeCount"/> 1 ist
        /// oder <see cref="PS_PrimaryStatus.BadlyPoisoned"/> wenn es 2 ist.
        /// Gift-PokéMon, die den Boden berühren entfernen ToxicSpikes.
        /// </summary>
        ToxicSpikes = 1 << 7, // TODO: Gravity, magic guard, iron ball, baton pass with ingrain, air balloon, synchronize with roar/whirlwind

        /// <summary>
        /// Das Team ist vor Attacken geschützt, die mehrere Ziele haben.
        /// </summary>
        WideGuard = 1 << 8
    }
}
