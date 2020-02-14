using System;

namespace PokéMon_Simulator.Enumerations
{
    [Flags]
    public enum PS_MoveFlag : ushort
    {
        /// <summary>
        /// Die Attacke hat keine Flags.
        /// </summary>
        None,

        /// <summary>
        /// Die Attacke wird von Eisenfaust verstärkt.
        /// </summary>
        AffectedByIronFist = 1 << 0,

        /// <summary>
        /// Die Attacke wird von Magiemantel und Magiespiegel geblockt.
        /// </summary>
        AffectedByMagicCoat = 1 << 1,

        /// <summary>
        /// Die Attacke kann von Spiegeltrick kopiert werden.
        /// </summary>
        AffectedByMirrorMove = 1 << 2,

        /// <summary>
        /// Die Attacke wird von Scanner, Schutzschild und Rundumschutz geblockt.
        /// </summary>
        AffectedByProtect = 1 << 3,

        /// <summary>
        /// Die Attacke wird von Achtlos verstärkt.
        /// </summary>
        AffectedByReckless = 1 << 4,

        /// <summary>Die Attacke kann von Übernahme gestohlen werden.</summary>
        AffectedBySnatch = 1 << 5,

        /// <summary>Die Attacke macht immer einen Volltreffer.</summary>
        AlwaysCrit = 1 << 6,

        /// <summary>
        /// Die Attacke kann nicht von Metronom genutzt werden.
        /// </summary>
        BlockedByMetronome = 1 << 7,

        /// <summary>
        /// Die Attacke taut das Ziel auf.
        /// </summary>
        DefrostsUser = 1 << 8,

        /// <summary>
        /// Die Attacke macht häufiger einen Volltreffer.
        /// </summary>
        HighCritChance = 1 << 9,

        /// <summary>
        /// Die Attacke trifft auch Ziele in der Luft.
        /// </summary>
        HitsAirborne = 1 << 10,

        /// <summary>
        /// Die Attacke trifft auch Ziele in dem Boden.
        /// </summary>
        HitsUnderground = 1 << 11,

        /// <summary>
        /// Die Attacke trifft auch Ziele unter Wasser.
        /// </summary>
        HitsUnderwater = 1 << 12,

        /// <summary>
        /// Die Attacke stellt Kontakt her.
        /// </summary>
        MakesContact = 1 << 13,

        /// <summary>
        /// Die Attacke ist eine Sound-Attacke.
        /// </summary>
        SoundBased = 1 << 14,

        /// <summary>
        /// Die Attacke nutzt keine Juwelen.
        /// </summary>
        UnaffectedByGems = 1 << 15
    }
}
