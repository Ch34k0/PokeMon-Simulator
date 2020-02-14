namespace PokéMon_Simulator.Enumerations
{
    public enum PS_MoveEffect : byte
    {
        /// <summary>
        /// Normaler Treffer.
        /// </summary>
        Hit,

        /// <summary>
        /// Normale Treffer mit sekundären Effekten.
        /// </summary>
        Hit__MaybeBurn,
        Hit__MaybeBurn__10PercentFlinch,
        Hit__MaybeConfuse,
        Hit__MaybeFlinch,
        Hit__MaybeFreeze,
        Hit__MaybeFreeze__10PercentFlinch,
        Hit__MaybeLowerTarget_ACC_By1,
        Hit__MaybeLowerTarget_ATK_By1,
        Hit__MaybeLowerTarget_DEF_By1,
        Hit__MaybeLowerTarget_SPATK_By1,
        Hit__MaybeLowerTarget_SPDEF_By1,
        Hit__MaybeLowerTarget_SPDEF_By2,
        Hit__MaybeLowerTarget_SPE_By1,
        Hit__MaybeLowerUser_ATK_DEF_By1,
        Hit__MaybeLowerUser_DEF_SPDEF_By1,
        Hit__MaybeLowerUser_SPATK_By2,
        Hit__MaybeLowerUser_SPE_By1,
        Hit__MaybeLowerUser_SPE_DEF_SPDEF_By1,
        Hit__MaybeParalyze,
        Hit__MaybeParalyze__10PercentFlinch,
        Hit__MaybePoison,
        Hit__MaybeRaiseUser_ATK_By1,
        Hit__MaybeRaiseUser_ATK_DEF_SPATK_SPDEF_SPE_By1,
        Hit__MaybeRaiseUser_DEF_By1,
        Hit__MaybeRaiseUser_SPATK_By1,
        Hit__MaybeRaiseUser_SPE_By1,
        Hit__MaybeToxic,

        /// <summary>
        /// Verändert die Stats des Zieles.
        /// </summary>
        ChangeTarget_ACC,
        ChangeTarget_ATK,
        ChangeTarget_DEF,
        ChangeTarget_EVA,
        ChangeTarget_SPATK,
        ChangeTarget_SPATK__IfAttractionPossible,
        ChangeTarget_SPDEF,
        ChangeTarget_SPE,

        LowerTarget_ATK_DEF_By1,
        LowerTarget_DEF_SPDEF_By1_Raise_ATK_SPATK_SPE_By2,

        RaiseTarget_ATK_ACC_By1,
        RaiseTarget_ATK_DEF_By1,
        RaiseTarget_ATK_DEF_ACC_By1,
        RaiseTarget_ATK_SPATK_By1,
        RaiseTarget_ATK_SPE_By1,
        RaiseTarget_DEF_SPDEF_By1,
        RaiseTarget_SPATK_SPDEF_By1,
        RaiseTarget_SPATK_SPDEF_SPE_By1,
        RaiseTarget_SPE_By2_ATK_By1,

        FocusEnergy,
        Growth,
        Haze,

        /// <summary>
        /// Verursacht einen primären oder sekundären Status.
        /// </summary>
        Burn,
        Confuse,
        Paralyze,
        Poison,
        Attract,
        Sleep,
        Flatter,
        Toxic,
        Swagger,
        Curse,

        /// <summary>
        /// Die Attacke hat eine Vorbereitungsrunde.
        /// </summary>
        Fly,
        Dig,
        Dive,

        /// <summary>
        /// Ändert das Wetter.
        /// </summary>
        Hail,
        RainDance,
        Sandstorm,
        SunnyDay,

        /// <summary>
        /// Umwandlung.
        /// </summary>
        Conversion,

        /// <summary>
        /// Schaden richtet sich nach den KP des Anwenders und/oder Zieles.
        /// </summary>
        Endeavor,
        FinalGambit,
        PainSplit,
        SuperFang,

        /// <summary>
        /// Setzt Schilde auf.
        /// </summary>
        LightScreen,
        BrickBreak,
        Reflect,
        Safeguard,
        WideGuard,

        /// <summary>
        /// Rückstoßschaden.
        /// </summary>
        Recoil,
        Recoil__10PercentBurn,
        Recoil__10PercentParalyze,

        /// <summary>
        /// Schaden richtet sich dem Level des Anwenders.
        /// </summary>
        SeismicToss,

        /// <summary>
        /// Der Schaden ist fest vorbestimmt.
        /// </summary>
        SetDamage,

        /// <summary>
        /// Richtet Schaden an und heilt den Anwender.
        /// </summary>
        HPDrain,
        HPDrain__RequireSleep,

        /// <summary>
        /// Verändert die Eigenschaften des Zieles oder Anwenders.
        /// </summary>
        LeechSeed,
        HelpingHand,
        LuckyChant,
        MagnetRise,
        PsychUp,
        Soak,

        /// <summary>
        /// Die Attacke ändert die Fähigkeit des Zieles.
        /// </summary>
        GastroAcid,
        SimpleBeam,

        /// <summary>
        /// Schutzschilde.
        /// </summary>
        Protect, // TODO: If the user goes last, fail

        /// <summary>
        /// Hazards.
        /// </summary>
        Spikes,
        StealthRock,
        ToxicSpikes,

        /// <summary>
        /// Selbstheilung.
        /// </summary>
        Moonlight,
        Rest,
        RestoreTargetHP,

        /// <summary>
        /// Selbstzerstörung.
        /// </summary>
        Selfdestruct,

        /// <summary>
        /// Führt eine zufällige Attacke aus.
        /// </summary>
        Metronome,

        /// <summary>
        /// Nichts.
        /// </summary>       
        Nothing,

        /// <summary>
        /// OHKO
        /// </summary>
        OneHitKnockout,

        /// <summary>
        /// Schaden ist zufällig.
        /// </summary>
        Psywave,

        /// <summary>
        /// Schaden richtet sich nach den StatChanges des Anwenders.
        /// </summary>
        PowerTrick,

        /// <summary>
        /// Attacke kann im Schlaf ausgeführt werden.
        /// </summary>        
        Snore,

        /// <summary>
        /// Wenn der Anwender keine AP mehr hat.
        /// </summary>
        Struggle,

        /// <summary>
        /// Setzt Delegator auf.
        /// </summary>
        Substitute,

        /// <summary>
        /// Funktioniert nur unter bestimmten Voraussetzungen.
        /// </summary>
        SuckerPunch,

        /// <summary>
        /// Setzt Rückenwind auf.
        /// </summary>
        Tailwind,

        /// <summary>
        /// Setzt Bizarroraum auf.
        /// </summary>
        TrickRoom,

        /// <summary>
        /// Schickt das Ziel aus dem Kampf.
        /// </summary>
        Whirlwind,

        /// <summary>
        /// Schickt den Anwender aus dem Kampf.
        /// </summary>
        Teleport,

        /// <summary>
        /// Wandler.
        /// </summary>
        Transform,
    }
}
