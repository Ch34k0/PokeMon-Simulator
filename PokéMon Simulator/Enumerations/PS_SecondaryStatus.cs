using System;

namespace PokéMon_Simulator.Enumerations
{
    [Flags]
    public enum PS_SecondaryStatus : uint
    {
        /// <summary>
        /// Das PokéMon hat keinen sekundären Status.
        /// </summary>
        None,

        /// <summary>
        /// Das PokéMon ist in der Luft. Eine Attacke gegen dieses PokéMon wird daneben gehen, außer die Attacke hat <see cref="PS_MoveFlag.HitsAirborne"/> oder eines des beiden PokéMon die Fähigkeit <see cref="PS_Ability.NoGuard"/>.
        /// </summary>
        Airborne = 1 << 0,

        /// <summary>
        /// Das PokéMon ist verwirrt und fügt sich manchmal selbst Schaden zu anstatt die eigentliche Attacke auszuführen.
        /// </summary>
        Confused = 1 << 1,

        /// <summary>
        /// Das PokéMon ist verflucht und erleidet am Ende jeder Runde Schaden.
        /// </summary>
        Cursed = 1 << 2,

        /// <summary>
        /// Das PokéMon ist mit der Fähigkeit <see cref="PS_Ability.Illusion"/> als <see cref="PokéMon.DisguisedAsPokéMon"/> getarnt.
        /// </summary>
        Disguised = 1 << 3,

        /// <summary>
        /// Das PokéMon schreckt zurück und kann nicht angreifen.
        /// </summary>
        Flinching = 1 << 4,

        /// <summary>
        /// Das PokéMon erhält einen Schaden-Bonus wegen <see cref="PS_Move.HelpingHand"/>.
        /// </summary>
        HelpingHand = 1 << 5,

        /// <summary>
        /// Das PokéMon ist in <see cref="PokéMon.InfatuatedWithPokéMon"/> vernarrt und ist vielleicht nicht in der Lage anzugreifen.
        /// </summary>
        Infatuated = 1 << 6,

        /// <summary>
        /// Das PokéMon ist bepflanzt und verliert am Ende jeder Runde ein Paar KP.
        /// </summary>
        LeechSeed = 1 << 7,

        MagnetRise = 1 << 8,

        /// <summary>
        /// <see cref="PS_Stats.Attack"/> und <see cref="PS_Stats.Defense"/> sind vertauscht.
        /// </summary>
        PowerTrick = 1 << 9,

        /// <summary>
        /// Das PokéMon ist vor Attacken geschüzt.
        /// </summary>
        Protected = 1 << 10,

        /// <summary>
        /// Das PokéMon steht unter dem Effekt von <see cref="PS_Move.FocusEnergy"/> oder <see cref="PS_Items.LansatBerry"/> und hat eine höhere Chance einen Volltreffer zu landen.
        /// </summary>
        Pumped = 1 << 11,

        /// <summary>
        /// Das PokéMon versteckt sich hinter einem Delegator. 
        /// Dieser nimmt den Schaden und hat selbst die Hälfte der maximalen KP des Nutzers.
        /// </summary>
        Substitute = 1 << 12,

        /// <summary>
        /// Das PokéMon kann die selbe Attacke nicht zweimal hintereinander einsetzen.
        /// </summary>
        Tormented = 1 << 13, // TODO

        /// <summary>
        /// Das PokéMon hat sich in ein anderes PokéMon verwandelt.
        /// </summary>
        Transformed = 1 << 14,

        /// <summary>
        /// Das PokéMon ist im Boden. Eine Attacke gegen dieses PokéMon wird daneben gehen, außer die Attacke hat <see cref="PS_MoveFlag.HitsUnderground"/> oder eines des beiden PokéMon die Fähigkeit <see cref="PS_Ability.NoGuard"/>.
        /// Das PokéMon erhält doppelten Schaden von <see cref="PS_Move.Earthquake"/> und <see cref="PS_Move.Magnitude"/>.
        /// </summary>
        Underground = 1 << 15,

        /// <summary>
        /// Das PokéMon ist unterwasser. Eine Attacke gegen dieses PokéMon wird daneben gehen, außer die Attacke hat <see cref="PS_MoveFlag.HitsUnderwater"/> oder eines des beiden PokéMon die Fähigkeit <see cref="PS_Ability.NoGuard"/>.
        /// Das PokéMon erhält doppelten Schaden von <see cref="PS_Move.Surf"/> und <see cref="PS_Move.Whirlpool"/>.
        /// </summary>
        Underwater = 1 << 16
    }
}
