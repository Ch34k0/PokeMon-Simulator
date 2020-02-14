namespace PokéMon_Simulator.Enumerations
{
    public enum PS_Ability : byte
    {
        

        /// <summary>
        /// Die Fähigkeit wurde mit <see cref="PS_Move.GastroAcid"/> unterdrückt.
        /// </summary>
        None = 0,

        /// <summary>
        /// Diese Fähigkeiten erhöhen den Schaden von Attacken ihres Types, 
        /// wenn die KP des Anwenders unter 30% liegen.
        /// </summary>
        Blaze = 1, //Feuer
        Torrent = 2, //Wasser
        Overqrow = 3, //Pflanze
        Swarm = 4, //Käfer

        /// <summary>
        /// Rückstoß-Attacken.
        /// </summary>
        Reckless,
        RockHead,

        /// <summary>
        /// Verhindert das Senken von Stats.
        /// </summary>
        KeenEye,
        BigPecks,

        /// <summary>
        /// Erhöht Stats bei Statuseffekten.
        /// </summary>
        Guts,
        FlareBoost,
        QuickFeet,
        MarvelScale,
        ToxicBoost,

        /// <summary>
        /// Ändert Typ abhängig vom Item.
        /// </summary>
        RKS_System,
        Multitype,

        /// <summary>
        /// Erhöht STAB.
        /// </summary>
        Adaptability,

        /// <summary>
        /// Verhindert <see cref="PS_PrimaryStatus"/> oder <see cref="PS_SecondaryStatus"/>.
        /// </summary>
        WaterVeil,
        Oblivious,
        Limber,
        Insomnia,
        VitalSpirit,
        Immunity,
        MagmaArmor,
        LeafGuard,

        /// <summary>
        /// Heilt den Nutzer bei Vergiftung.
        /// </summary>
        PoisonHeal,

        /// <summary>
        /// Beeinflusst Typeneffektivität.
        /// </summary>
        TintedLens,
        Filter,
        SolidRock,
        PrismArmor,

        /// <summary>
        /// Auren Fähigkeiten.
        /// </summary>
        AuraBreak,
        DarkAura,
        FairyAura,

        /// <summary>
        /// Hindert den Gegner am auswecheln.
        /// </summary>
        ArenaTrap,
        MagnetPull,
        ShadowTag,

        /// <summary>
        /// Beerenkonsum.
        /// </summary>
        CheekPouch,
        Unnerve,
        Gluttony,

        /// <summary>
        /// Verstärkt Spezial Angriff von Mitgliedern.
        /// </summary>
        Battery,

        /// <summary>
        /// Ändert Stats bei Kampfeintritt.
        /// </summary>
        Intimidate,
        Download,

        /// <summary>
        /// Heilt KP beim auswechseln.
        /// </summary>
        Regenerator,

        /// <summary>
        /// Erhöht den Schaden gegen neu eingewechselte Ziele.
        /// </summary>
        Stakeout,

        /// <summary>
        /// Erhöht Stats wenn PokéMon Gegner besiegt hat.
        /// </summary>
        BeastBoost,
        Moxie,
        Soul_Heart,

        /// <summary>
        /// Zieht Attacken von bestimmten Typen an und erhöht Stats.
        /// </summary>
        Lightningrod,
        StormDrain,

        /// <summary>
        /// Schützt Mitglieder vor Statussenkungen.
        /// </summary>
        FlowerVeil,
        AromaVeil,

        /// <summary>
        /// Ändert Stats wenn getroffen.
        /// </summary>
        WeakArmor,

        /// <summary>
        /// Verhindert den Einsatz von Attacken mit erhöhter Priorität.
        /// </summary>
        Dazzling,

        /// <summary>
        /// Kann bei Kontakt <see cref="PS_PrimaryStatus"/> oder <see cref="PS_SecondaryStatus"/> auslösen.
        /// </summary>
        CuteCharm,
        FlameBody,
        Static,
        EffectSpore,
        PoisonPoint,


        /// <summary>
        /// Wenn ein Mitglied besiegt wurde erhält der Nutzer dessen Fähigkeit.
        /// </summary>
        PowerOfAlchemy,
        Receiver,

        /// <summary>
        /// Erhöht Stats bei Wetter.
        /// </summary>
        Chlorophyll,
        SwiftSwim,
        SlushRush,
        SandRush,

        /// <summary>
        /// Heilt Nutzer bei Wetter.
        /// </summary>
        IceBody,
        RainDish,
        DrySkin,

        /// <summary>
        /// Verhindert, dass das Pokémon durch Statusveränderungen, außer Schlaf, betroffen wird.
        /// </summary>
        Comatose,

        /// <summary>
        /// Löst Wetter aus.
        /// </summary>
        DeltaStream,
        Drought,
        Drizzle,
        DesolateLand,
        PrimordialSea,
        CloudNine,
        SandStream,
        SnowWarning,

        /// <summary>
        /// Löst Feldeffekt aus.
        /// </summary>
        ElectricSurge,
        PsychicSurge,
        GrassySurge,
        MistySurge,

        /// <summary>
        /// Verwandelt den Nutzer in den Gegner.
        /// </summary>
        Imposter,

        /// <summary>
        /// Attacken können zurückschrecken lassen.
        /// </summary>
        Stench,

        /// <summary>
        /// Verdoppelt die Chance einen sekundären Effekt aufzurufen.
        /// </summary>
        SereneGrace,

        /// <summary>
        /// Verstärkt Attacken, die <see cref="PS_MoveFlag.AffectedByIronFist"/> sind.
        /// </summary>
        IronFist,

        /// <summary>
        /// Verursacht Schaden bei Kontakt.
        /// </summary>
        IronBarbs,
        RoughSkin,

        /// <summary>
        /// Ändert den Typ von Normal-Attacken und gibt einen Schaden-Bonus.
        /// </summary>
        Galvanize,
        Pixilate,
        Aerilate,
        Refrigerate,
        Normalize,

        /// <summary>
        /// Kopiert Fähigkeit von Gegner.
        /// </summary>
        Trace,


        Unburden,

        Illuminate,
        Pressure,

        /// <summary>
        /// Heilt eventuell <see cref="PS_PrimaryStatus"/> oder <see cref="PS_SecondaryStatus"/>.
        /// </summary>
        Healer,
        ShedSkin,

        CompoundEyes,


        ParentalBound,

        /// <summary>
        /// Ändert Typ zu dem der Attacke mit der der Nutzer zuletzt getroffen wurde.
        /// </summary>
        ColorChange,




        /// <summary>
        /// Halbiert Schaden von physischen Attacken.
        /// </summary>
        FurCoat,
        Fluffy,

        /// <summary>
        /// Lusardin.
        /// </summary>
        Schooling,

        /// <summary>
        /// Immunität gegenüber Typ.
        /// </summary>
        FlashFire,
        Levitate,
        WaterAbsorb,
        VoltAbsorb,

        /// <summary>
        /// Gegner erleidet Schaden wenn Nutzer besiegt wird.
        /// </summary>
        Aftermath,

        /// <summary>
        /// Mitstreiter erleiden weniger Schaden.
        /// </summary>
        FriendGuard,

        /// <summary>
        /// Ash-Quajutsu.
        /// </summary>
        BattleBond,

        /// <summary>
        /// Ermöglicht schnelleres Aufwachen.
        /// </summary>
        EarlyBird,

        /// <summary>
        /// Erhöht den Fluchtwert, wenn das Pokémon verwirrt ist.
        /// </summary>
        TangledFeet,

        /// <summary>
        /// Ein Statuswert steigt um zwei Stufen und einer sinkt um eine Stufe pro Runde.
        /// </summary>
        Moody,

        /// <summary>
        /// Vergiftet eventuell bei Berührung.
        /// </summary>
        PoisonTouch,

        /// <summary>
        /// Erhöht die Chance auf einen Volltreffer.
        /// </summary>
        SuperLuck,

        /// <summary>
        /// Erhöht Init. bei Treffer durch Geist-, Käfer- oder Unlicht-Attacke.
        /// </summary>
        Rattled,

        Triage,
        Heatproof,
        HoneyGather,
        Hydration,
        NaturalCure,
        Cacophony,
        BattleArmor,
        AirLock,
        LiquidOoze,
        InnerFocus,
        Corrosion,
        Disguise,
        HugePower,
        Steadfast,
        Damp,
        ToughClaws,
        Bulletproof,
        AngerPoint,
        Soundproof,
        Pickpocket,
        LongReach,
        LightMetal,
        ShieldsDown,
        MagicGuard,
        MagicBounce,


        TanglingHair,
        Gooey,


        Innardsout,
        QueenlyMajesty,
        MegaLauncher,
        PurePower,
        FullMetalBody,
        Minus,
        Pickup,
        Multiscale,
        Mummy,
        ClearBody,
        Symbiosis,
        GaleWings,
        ShellArmor,
        FlowerGift,
        GrassPelt,
        ShadowShield,
        LiquidVoice,
        Plus,
        Forecast,

        ShieldDust,
        WhiteSmoke,
        Merciless,
        Scrappy,
        Justified,
        Harvest,
        WimpOut,
        EmergencyExit,
        Rivalry,
        Sturdy,

        SheerForce,
        SandForce,
        SandVeil,
        SuctionCups,
        SlowStart,
        PowerConstruct,
        HyperCutter,

        NoGuard,
        SnowCloak,
        Truant,
        Frisk,
        Defeatist,
        Infiltrator,
        HeavyMetal,
        Defiant,
        SolarPower,
        ThickFat,
        Steelworker,
        MotorDrive,
        Prankster,
        Sniper,
        SurgeSurfer,
        Synchronize,
        StanceChange,

        Dancer,
        CursedBody,
        Technician,
        Telepathy,
        OwnTempo,
        SpeedBoost,

        /// <summary>
        /// Überbrückt Fähikeiten.
        /// </summary>
        Teravolt,
        Turboblaze,
        MoldBreaker,

        StrongJaw,
        Klutz,
        ZenMode,
        VictoryStar,
        Illusion,
        Hustle,
        Contrary,
        Unaware,

        Competitive,

        SapSipper,
        WaterCompaction,

        Anticipation,
        Forewarn,
        Protean,

        Simple,
        WaterBubble,
        StickyHold,

        SkillLink,
        Overcoat,

        WonderSkin,
        WonderGuard,

        Berserk,
        Stamina,
        Magician,
        Stall,
        SweetVeil,
        Neuroforce,

        BadDreams,
        Analytic,
        RunAway,

        /// <summary>
        /// Die Fähigkeit ist ungültig.
        /// </summary>
        ERROR = 165
    }
}
