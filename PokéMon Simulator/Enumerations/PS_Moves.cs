namespace PokéMon_Simulator.Enumerations
{
    public enum PS_Move : ushort
    {
        None = 0,

        /// <summary>
        /// Normal-Attacken
        /// </summary>
        #region Physisch
        Pound = 1,
        Double_Slap = 2,
        Comet_Punch = 3,
        Mega_Punch = 4,
        Pay_Day = 5,
        Scratch = 6,
        Vise_Grip = 7,
        Guillotine = 8,
        Cut = 9,
        Bind = 10,
        Slam = 11,
        Stomp = 12,
        Mega_Kick = 13,
        Headbutt = 14,
        Horn_Attack = 15,
        Fury_Attack = 16,
        Horn_Drill = 17,
        Tackle = 18,
        Body_Slam = 19,
        Wrap = 20,
        Take_Down = 21,
        Thrash = 22,
        Double_Edge = 23,
        Strength = 24,
        Quick_Attack = 25,
        Rage = 26,
        Bide = 27,
        Self_Destruct = 28,
        Egg_Bomb = 29,
        Skull_Bash = 30,
        Spike_Cannon = 31,
        Constrict = 32,
        Barrage = 33,
        Dizzy_Punch = 34,
        Explosion = 35,
        Fury_Swipes = 36,
        Hyper_Fang = 37,
        Super_Fang = 38,
        Slash = 39,
        Struggle = 40,
        Flail = 41,
        False_Swipe = 42,
        Return = 43,
        Present = 44,
        Frustration = 45,
        Rapid_Spin = 46,
        Extreme_Speed = 47,
        Fake_Out = 48,
        Facade = 49,
        Smelling_Salts = 50,
        Endeavor = 51,
        Secret_Power = 52,
        Crush_Claw = 53,
        Covet = 54,
        Natural_Gift = 55,
        Feint = 56,
        Last_Resort = 57,
        Giga_Impact = 58,
        Rock_Climb = 59,
        Double_Hit = 60,
        Crush_Grip = 61,
        Chip_Away = 62,
        Retaliate = 63,
        Tail_Slap = 64,
        Head_Charge = 65,
        Hold_Back = 66,
        Breakneck_Blitz_ph = 67,
        Pulverizing_Pancake = 68,
        Multi_Attack = 69,
        Veevee_Volley = 70,

        #endregion


        #region Speziell
        Razor_Wind = 71,
        Sonic_Boom = 72,
        Hyper_Beam = 73,
        Swift = 74,
        Tri_Attack = 75,
        Snore = 76,
        Hidden_Power = 77,
        Uproar = 78,
        Spit_Up = 79,
        Hyper_Voice = 80,
        Weather_Ball = 81,
        Trump_Card = 82,
        Wring_Out = 83,
        Judgment = 84,
        Round = 85,
        Echoed_Voice = 86,
        Techno_Blast = 87,
        Relic_Song = 88,
        Boomburst = 89,
        Breakneck_Blitz_sp = 90,
        Revelation_Dance = 91,
        #endregion

        #region Status
        Swords_Dance = 92,
        Whirlwind = 93,
        Tail_Whip = 94,
        Leer = 95,
        Growl = 96,
        Roar = 97,
        Sing = 98,
        Supersonic = 99,
        Disable = 100,
        Growth = 101,
        Mimic = 102,
        Screech = 103,
        Double_Team = 104,
        Recover = 105,
        Harden = 106,
        Minimize = 107,
        Smokescreen = 108,
        Defense_Curl = 109,
        Focus_Energy = 110,
        Metronome = 111,
        Soft_Boiled = 112,
        Glare = 113,
        Lovely_Kiss = 114,
        Transform = 115,
        Flash = 116,
        Splash = 117,
        Sharpen = 118,
        Conversion = 119,
        Substitute = 120,
        Sketch = 121,
        Mind_Reader = 122,
        Conversion_2 = 123,
        Protect = 124,
        Scary_Face = 125,
        Belly_Drum = 126,
        Foresight = 127,
        Perish_Song = 128,
        Lock_On = 129,
        Endure = 130,
        Swagger = 131,
        Milk_Drink = 132,
        Mean_Look = 133,
        Attract = 134,
        Sleep_Talk = 135,
        Heal_Bell = 136,
        Safeguard = 137,
        Pain_Split = 138,
        Baton_Pass = 139,
        Encore = 140,
        Sweet_Scent = 141,
        Morning_Sun = 142,
        Psych_Up = 143,
        Stockpile = 144,
        Swallow = 145,
        Follow_Me = 146,
        Nature_Power = 147,
        Helping_Hand = 148,
        Wish = 149,
        Assist = 150,
        Recycle = 151,
        Yawn = 152,
        Refresh = 153,
        Camouflage = 154,
        Teeter_Dance = 155,
        Slack_Off = 156,
        Odor_Sleuth = 157,
        Tickle = 158,
        Block = 159,
        Howl = 160,
        Acupressure = 161,
        Lucky_Chant = 162,
        Me_First = 163,
        Copycat = 164,
        Captivate = 165,
        Simple_Beam = 166,
        Entrainment = 167,
        After_You = 168,
        Shell_Smash = 169,
        Reflect_Type = 170,
        Bestow = 171,
        Work_Up = 172,
        Noble_Roar = 173,
        Play_Nice = 174,
        Confide = 175,
        Happy_Hour = 176,
        Celebrate = 177,
        Hold_Hands = 178,
        Spotlight = 179,
        Laser_Focus = 180,
        Extreme_Evoboost = 181,
        Tearful_Look = 182,
        Max_Guard = 183,
        Stuff_Cheeks = 184,
        Teatime = 185,
        Court_Change = 186,
        #endregion

        /// <summary>
        /// Kampf-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Flug-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Gift-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Boden-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Gestein-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Käfer-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Geist-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Stahl-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Feuer-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Wasser-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Pflanze-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Elektro-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Psycho-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Eis-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Drachen-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Unlicht-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        /// <summary>
        /// Fee-Attacken
        /// </summary>
        #region Physisch
        #endregion
        #region Speziell
        #endregion
        #region Status
        #endregion

        ERROR = 1000,
    }
}
