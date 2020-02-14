namespace PokéMon_Simulator.Enumerations
{
    public enum PS_Item : ushort
    {
        /// <summary>
        /// Kein Item.
        /// </summary>
        None = 0,

        /// <summary>
        /// Pokebälle
        /// </summary>
        #region
        Master_Ball = 1,
        Ultra_Ball = 2,
        Great_Ball = 3,
        Poké_Ball = 4,
        Safari_Ball = 5,
        Net_Ball = 6,
        Dive_Ball = 7,
        Nest_Ball = 8,
        Repeat_Ball = 9,
        Timer_Ball = 10,
        Luxury_Ball = 11,
        Premier_Ball = 12,
        Dusk_Ball = 13,
        Heal_Ball = 14,
        Quick_Ball = 15,
        Cherish_Ball = 16,
        Fast_Ball = 404,
        Level_Ball = 405,
        Lure_Ball = 406,
        Heavy_Ball = 407,
        Love_Ball = 408,
        Friend_Ball = 409,
        Moon_Ball = 410,
        Sport_Ball = 411,
        Park_Ball = 412,
        Dream_Ball = 450,
        Beast_Ball = 610,
        #endregion

        /// <summary>
        /// Medizin
        /// </summary>
        #region
        Potion = 17,
        Max_Potion = 24,
        Hyper_Potion = 25,
        Super_Potion = 26,
        Full_Restore = 23,

        Antidote = 18,
        Burn_Heal = 19,
        Ice_Heal = 20,
        Awakening = 21,
        Paralyze_Heal = 22,
        Full_Heal = 27,

        Sweet_Heart = 117,
        Casteliacone = 464,
        Lumiose_Galette = 523,
        Shalour_Sable = 524,
        Big_Malasada = 611,
        Lava_Cookie = 42,
        Old_Gateau = 54,

        Revive = 28,
        Max_Revive = 29,
        Sacred_Ash = 44,

        Fresh_Water = 30,
        Soda_Pop = 31,
        Lemonade = 32,

        Moomoo_Milk = 33,
        Berry_Juice = 43,

        Energy_Powder = 34,
        Energy_Root = 35,
        Heal_Powder = 36,
        Revival_Herb = 37,

        Ether = 38,
        Max_Ether = 39,
        Elixir = 40,
        Max_Elixir = 41,

        HP_Up = 45,
        Protein = 46,
        Iron = 47,
        Carbos = 48,
        Calcium = 49,
        Zinc = 52,

        Health_Feather = 441,
        Muscle_Feather = 442,
        Resist_Feather = 443,
        Genius_Feather = 444,
        Clever_Feather = 445,
        Swift_Feather = 446,

        Rare_Candy = 50,
        Exp_Candy_XS = 674,
        Exp_Candy_S = 675,
        Exp_Candy_M = 676,
        Exp_Candy_L = 677,
        Exp_Candy_XL = 678,

        PP_Up = 51,
        PP_Max = 53,

        Guard_Spec = 55,
        Dire_Hit = 56,
        X_Attack = 57,
        X_Defense = 58,
        X_Speed = 59,
        X_Accuracy = 60,
        X_Sp_Atk = 61,
        X_Sp_Def = 62,

        Dynamax_Candy = 679,

        Ability_Capsule = 475,
        #endregion

        /// <summary>
        /// Kampf-Items
        /// </summary>
        #region
        Poké_Doll = 63,
        Fluffy_Tail = 64,
        Blue_Flute = 65,
        Yellow_Flute = 66,
        Red_Flute = 67,
        Black_Flute = 68,
        White_Flute = 69,
        Poké_Toy = 451,
        #endregion

        /// <summary>
        /// Andere
        /// </summary>
        #region
        Shoal_Salt = 70,
        Shoal_Shell = 71,

        Red_Shard = 72,
        Blue_Shard = 73,
        Yellow_Shard = 74,
        Green_Shard = 75,

        Super_Repel = 76,
        Max_Repel = 77,
        Escape_Rope = 78,
        Repel = 79,

        Heart_Scale = 93,
        Honey = 94,

        Growth_Mulch = 95,
        Damp_Mulch = 96,
        Stable_Mulch = 97,
        Gooey_Mulch = 98,

        Rich_Mulch = 481,
        Surprise_Mulch = 482,
        Boost_Mulch = 483,
        Amaze_Mulch = 484,

        Odd_Keystone = 111,
        #endregion

        /// <summary>
        /// Entwicklungsitems
        /// </summary>
        #region
        Sun_Stone = 80,
        Moon_Stone = 81,
        Fire_Stone = 82,
        Thunder_Stone = 83,
        Water_Stone = 84,
        Leaf_Stone = 85,
        Shiny_Stone = 107,
        Dusk_Stone = 108,
        Dawn_Stone = 109,
        Oval_Stone = 110,
        Ice_Stone = 609,

        Everstone = 212,

        Protector = 304,
        Electirizer = 305,
        Magmarizer = 306,
        Dubious_Disc = 307,
        Reaper_Cloth = 308,
        Razor_Claw = 309,
        Razor_Fang = 310,
        Upgrade = 235,
        Dragon_Scale = 218,
        Whipped_Dream = 476,
        Sachet = 477,
        Deep_Sea_Tooth = 209,
        Deep_Sea_Scale = 210,
        Prism_Scale = 413,

        Cracked_Pot = 803,
        Chipped_Pot = 804,

        Sweet_Apple = 666,
        Tart_Apple = 667,

        Strawberry_Sweet = 659,
        Love_Sweet = 660,
        Berry_Sweet = 661,
        Clover_Sweet = 662,
        Flower_Sweet = 663,
        Star_Sweet = 664,
        Ribbon_Sweet = 665,
        #endregion

        /// <summary>
        /// Wertvolles
        /// </summary>
        #region
        Tiny_Mushroom = 86,
        Big_Mushroom = 87,
        Balm_Mushroom = 453,

        Pearl = 88,
        Big_Pearl = 89,
        Pearl_String = 455,

        Stardust = 90,
        Star_Piece = 91,
        Comet_Shard = 456,

        Nugget = 92,
        Big_Nugget = 454,

        Rare_Bone = 106,

        Pretty_Feather = 447,

        Relic_Copper = 457,
        Relic_Silver = 458,
        Relic_Gold = 459,
        Relic_Vase = 460,
        Relic_Band = 461,
        Relic_Statue = 462,
        Relic_Crown = 463,

        Bottle_Cap = 566,
        Gold_Bottle_Cap = 567,
        #endregion

        /// <summary>
        /// Fossile
        /// </summary>
        #region        
        Helix_Fossil = 101,
        Dome_Fossil = 102,
        Old_Amber = 103,

        Root_Fossil = 99,
        Claw_Fossil = 100,

        Armor_Fossil = 104,
        Skull_Fossil = 105,

        Cover_Fossil = 448,
        Plume_Fossil = 449,

        Jaw_Fossil = 525,
        Sail_Fossil = 526,

        Fossilized_Bird = 655,
        Fossilized_Fish = 656,
        Fossilized_Drake = 657,
        Fossilized_Dino = 658,
        #endregion

        /// <summary>
        /// Formwandel-Items
        /// </summary>        
        #region        
        Douse_Drive = 113,
        Shock_Drive = 114,
        Burn_Drive = 115,
        Chill_Drive = 116,

        Gracidea = 403,

        DNA_Splicers = 468,

        Reveal_Glass = 471,

        Prison_Bottle = 542,

        N_Solarizer = 651,
        N_Lunarizer = 652,

        Rusted_Sword = 653,
        Rusted_Shield = 654,

        Zygarde_Cube = 608,

        Red_Nectar = 612,
        Yellow_Nectar = 613,
        Pink_Nectar = 614,
        Purple_Nectar = 615,
        #endregion

        /// <summary>
        /// PokéMon spezifische Items
        /// </summary>
        #region
        Griseous_Orb = 112,
        Adamant_Orb = 118,
        Lustrous_Orb = 119,

        Soul_Dew = 208,

        Light_Ball = 219,

        Lucky_Punch = 239,

        Metal_Powder = 240,
        Quick_Powder = 257,

        Thick_Club = 241,

        Leek = 242,
        #endregion

        /// <summary>
        /// Briefe
        /// </summary>
        #region
        Greet_Mail = 120,
        Favored_Mail = 121,
        RSVP_Mail = 122,
        Thanks_Mail = 123,
        Inquiry_Mail = 124,
        Like_Mail = 125,
        Reply_Mail = 126,
        Bridge_Mail_S = 127,
        Bridge_Mail_D = 128,
        Bridge_Mail_T = 129,
        Bridge_Mail_V = 130,
        Bridge_Mail_M = 131,
        #endregion

        /// <summary>
        /// Beeren
        /// </summary>
        #region
        Cheri_Berry = 132,
        Chesto_Berry = 133,
        Pecha_Berry = 134,
        Rawst_Berry = 135,
        Aspear_Berry = 136,
        Leppa_Berry = 137,
        Oran_Berry = 138,
        Persim_Berry = 139,
        Lum_Berry = 140,
        Sitrus_Berry = 141,
        Figy_Berry = 142,
        Wiki_Berry = 143,
        Mago_Berry = 144,
        Aguav_Berry = 145,
        Iapapa_Berry = 146,
        Razz_Berry = 147,
        Bluk_Berry = 148,
        Nanab_Berry = 149,
        Wepear_Berry = 150,
        Pinap_Berry = 151,
        Pomeg_Berry = 152,
        Kelpsy_Berry = 153,
        Qualot_Berry = 154,
        Hondew_Berry = 155,
        Grepa_Berry = 156,
        Tamato_Berry = 157,
        Cornn_Berry = 158,
        Magost_Berry = 159,
        Rabuta_Berry = 160,
        Nomel_Berry = 161,
        Spelon_Berry = 162,
        Pamtre_Berry = 163,
        Watmel_Berry = 164,
        Durin_Berry = 165,
        Belue_Berry = 166,
        Occa_Berry = 167,
        Passho_Berry = 168,
        Wacan_Berry = 169,
        Rindo_Berry = 170,
        Yache_Berry = 171,
        Chople_Berry = 172,
        Kebia_Berry = 173,
        Shuca_Berry = 174,
        Coba_Berry = 175,
        Payapa_Berry = 176,
        Tanga_Berry = 177,
        Charti_Berry = 178,
        Kasib_Berry = 179,
        Haban_Berry = 180,
        Colbur_Berry = 181,
        Babiri_Berry = 182,
        Chilan_Berry = 183,
        Liechi_Berry = 184,
        Ganlon_Berry = 185,
        Salac_Berry = 186,
        Petaya_Berry = 187,
        Apicot_Berry = 188,
        Lansat_Berry = 189,
        Starf_Berry = 190,
        Enigma_Berry = 191,
        Micle_Berry = 192,
        Custap_Berry = 193,
        Jaboca_Berry = 194,
        Rowap_Berry = 195,
        Roseli_Berry = 515,
        Kee_Berry = 516,
        Maranga_Berry = 517,
        #endregion

        /// <summary>
        /// sinnvolle Kampf-Items
        /// </summary>
        #region
        Muscle_Band = 249,
        Wise_Glasses = 250,
        Bright_Powder = 196,
        Quick_Claw = 200,
        Kings_Rock = 204,
        Smoke_Ball = 211,
        Metronome = 260,
        Iron_Ball = 261,
        Lagging_Tail = 262,
        Destiny_Knot = 263,
        Expert_Belt = 251,

        Scope_Lens = 215,
        Wide_Lens = 248,
        Zoom_Lens = 259,

        Focus_Band = 213,
        Focus_Sash = 258,

        White_Herb = 197,
        Mental_Herb = 202,
        Power_Herb = 254,

        Exp_Share = 199,
        Macho_Brace = 198,
        Power_Bracer = 272,
        Power_Belt = 273,
        Power_Lens = 274,
        Power_Band = 275,
        Power_Anklet = 276,
        Power_Weight = 277,

        Soothe_Bell = 201,
        Amulet_Coin = 206,
        Lucky_Egg = 214,

        Choice_Band = 203,
        Choice_Specs = 280,
        Choice_Scarf = 270,

        Leftovers = 217,
        Black_Sludge = 264,
        Shell_Bell = 236,

        Metal_Coat = 216,
        Silver_Powder = 205,
        Cleanse_Tag = 207,
        Soft_Sand = 220,
        Hard_Stone = 221,
        Miracle_Seed = 222,
        Black_Glasses = 223,
        Black_Belt = 224,
        Magnet = 225,
        Mystic_Water = 226,
        Sharp_Beak = 227,
        Poison_Barb = 228,
        Never_Melt_Ice = 229,
        Spell_Tag = 230,
        Twisted_Spoon = 231,
        Charcoal = 232,
        Dragon_Fang = 233,
        Silk_Scarf = 234,

        Sea_Incense = 237,
        Lax_Incense = 238,
        Odd_Incense = 297,
        Rock_Incense = 298,
        Full_Incense = 299,
        Wave_Incense = 300,
        Rose_Incense = 301,
        Luck_Incense = 302,
        Pure_Incense = 303,

        Red_Scarf = 243,
        Blue_Scarf = 244,
        Pink_Scarf = 245,
        Green_Scarf = 246,
        Yellow_Scarf = 247,

        Life_Orb = 253,

        Toxic_Orb = 255,
        Flame_Orb = 256,

        Icy_Rock = 265,
        Smooth_Rock = 266,
        Heat_Rock = 267,
        Damp_Rock = 268,

        Terrain_Extender = 616,
        Electric_Seed = 618,
        Psychic_Seed = 619,
        Misty_Seed = 620,
        Grassy_Seed = 621,

        Light_Clay = 252,

        Grip_Claw = 269,
        Sticky_Barb = 271,
        Shed_Shell = 278,
        Big_Root = 279,
        Eviolite = 414,
        Float_Stone = 415,
        Rocky_Helmet = 416,
        Air_Balloon = 417,
        Red_Card = 418,
        Ring_Target = 419,
        Binding_Band = 420,
        Absorb_Bulb = 421,
        Cell_Battery = 422,
        Eject_Button = 423,
        Weakness_Policy = 472,
        Assault_Vest = 473,
        Luminous_Moss = 478,
        Snowball = 479,
        Safety_Goggles = 480,
        Adrenaline_Orb = 607,
        Throat_Spray = 668,
        Eject_Pack = 669,
        Heavy_Duty_Boots = 670,
        Blunder_Policy = 671,
        Room_Service = 672,
        Utility_Umbrella = 673,
        Protective_Pads = 617,
        #endregion

        /// <summary>
        /// TMs
        /// </summary>
        #region
        TM01 = 311,
        TM02 = 312,
        TM03 = 313,
        TM04 = 314,
        TM05 = 315,
        TM06 = 316,
        TM07 = 317,
        TM08 = 318,
        TM09 = 319,
        TM10 = 320,
        TM11 = 321,
        TM12 = 322,
        TM13 = 323,
        TM14 = 324,
        TM15 = 325,
        TM16 = 326,
        TM17 = 327,
        TM18 = 328,
        TM19 = 329,
        TM20 = 330,
        TM21 = 331,
        TM22 = 332,
        TM23 = 333,
        TM24 = 334,
        TM25 = 335,
        TM26 = 336,
        TM27 = 337,
        TM28 = 338,
        TM29 = 339,
        TM30 = 340,
        TM31 = 341,
        TM32 = 342,
        TM33 = 343,
        TM34 = 344,
        TM35 = 345,
        TM36 = 346,
        TM37 = 347,
        TM38 = 348,
        TM39 = 349,
        TM40 = 350,
        TM41 = 351,
        TM42 = 352,
        TM43 = 353,
        TM44 = 354,
        TM45 = 355,
        TM46 = 356,
        TM47 = 357,
        TM48 = 358,
        TM49 = 359,
        TM50 = 360,
        TM51 = 361,
        TM52 = 362,
        TM53 = 363,
        TM54 = 364,
        TM55 = 365,
        TM56 = 366,
        TM57 = 367,
        TM58 = 368,
        TM59 = 369,
        TM60 = 370,
        TM61 = 371,
        TM62 = 372,
        TM63 = 373,
        TM64 = 374,
        TM65 = 375,
        TM66 = 376,
        TM67 = 377,
        TM68 = 378,
        TM69 = 379,
        TM70 = 380,
        TM71 = 381,
        TM72 = 382,
        TM73 = 383,
        TM74 = 384,
        TM75 = 385,
        TM76 = 386,
        TM77 = 387,
        TM78 = 388,
        TM79 = 389,
        TM80 = 390,
        TM81 = 391,
        TM82 = 392,
        TM83 = 393,
        TM84 = 394,
        TM85 = 395,
        TM86 = 396,
        TM87 = 397,
        TM88 = 398,
        TM89 = 399,
        TM90 = 400,
        TM91 = 401,
        TM92 = 402,
        TM93 = 465,
        TM94 = 466,
        TM95 = 467,
        TM96 = 518,
        TM97 = 519,
        TM98 = 520,
        TM99 = 521,
        TM100 = 522,

        TR00 = 680,
        TR01 = 681,
        TR02 = 682,
        TR03 = 683,
        TR04 = 684,
        TR05 = 685,
        TR06 = 686,
        TR07 = 687,
        TR08 = 688,
        TR09 = 689,
        TR10 = 690,
        TR11 = 691,
        TR12 = 692,
        TR13 = 693,
        TR14 = 694,
        TR15 = 695,
        TR16 = 696,
        TR17 = 697,
        TR18 = 698,
        TR19 = 699,
        TR20 = 700,
        TR21 = 701,
        TR22 = 702,
        TR23 = 703,
        TR24 = 704,
        TR25 = 705,
        TR26 = 706,
        TR27 = 707,
        TR28 = 708,
        TR29 = 709,
        TR30 = 710,
        TR31 = 711,
        TR32 = 712,
        TR33 = 713,
        TR34 = 714,
        TR35 = 715,
        TR36 = 716,
        TR37 = 717,
        TR38 = 718,
        TR39 = 719,
        TR40 = 720,
        TR41 = 721,
        TR42 = 722,
        TR43 = 723,
        TR44 = 724,
        TR45 = 725,
        TR46 = 726,
        TR47 = 727,
        TR48 = 728,
        TR49 = 729,
        TR50 = 730,
        TR51 = 731,
        TR52 = 732,
        TR53 = 733,
        TR54 = 734,
        TR55 = 735,
        TR56 = 736,
        TR57 = 737,
        TR58 = 738,
        TR59 = 739,
        TR60 = 740,
        TR61 = 741,
        TR62 = 742,
        TR63 = 743,
        TR64 = 744,
        TR65 = 745,
        TR66 = 746,
        TR67 = 747,
        TR68 = 748,
        TR69 = 749,
        TR70 = 750,
        TR71 = 751,
        TR72 = 752,
        TR73 = 753,
        TR74 = 754,
        TR75 = 755,
        TR76 = 756,
        TR77 = 757,
        TR78 = 758,
        TR79 = 759,
        TR80 = 760,
        TR81 = 761,
        TR82 = 762,
        TR83 = 763,
        TR84 = 764,
        TR85 = 765,
        TR86 = 766,
        TR87 = 767,
        TR88 = 768,
        TR89 = 769,
        TR90 = 770,
        TR91 = 771,
        TR92 = 772,
        TR93 = 773,
        TR94 = 774,
        TR95 = 775,
        TR96 = 776,
        TR97 = 777,
        TR98 = 778,
        TR99 = 779,
        TM00 = 780,
        #endregion

        /// <summary>
        /// Platten
        /// </summary>
        #region
        Flame_Plate = 281,
        Splash_Plate = 282,
        Zap_Plate = 283,
        Meadow_Plate = 284,
        Icicle_Plate = 285,
        Fist_Plate = 286,
        Toxic_Plate = 287,
        Earth_Plate = 288,
        Sky_Plate = 289,
        Mind_Plate = 290,
        Insect_Plate = 291,
        Stone_Plate = 292,
        Spooky_Plate = 293,
        Draco_Plate = 294,
        Dread_Plate = 295,
        Iron_Plate = 296,
        Pixie_Plate = 474,
        #endregion

        /// <summary>
        /// Discs
        /// </summary>
        #region
        Fighting_Memory = 622,
        Flying_Memory = 623,
        Poison_Memory = 624,
        Ground_Memory = 625,
        Rock_Memory = 626,
        Bug_Memory = 627,
        Ghost_Memory = 628,
        Steel_Memory = 629,
        Fire_Memory = 630,
        Water_Memory = 631,
        Grass_Memory = 632,
        Electric_Memory = 633,
        Psychic_Memory = 634,
        Ice_Memory = 635,
        Dragon_Memory = 636,
        Dark_Memory = 637,
        Fairy_Memory = 638,
        #endregion

        /// <summary>
        /// Juwele
        /// </summary>
        #region
        Fire_Gem = 424,
        Water_Gem = 425,
        Electric_Gem = 426,
        Grass_Gem = 427,
        Ice_Gem = 428,
        Fighting_Gem = 429,
        Poison_Gem = 430,
        Ground_Gem = 431,
        Flying_Gem = 432,
        Psychic_Gem = 433,
        Bug_Gem = 434,
        Rock_Gem = 435,
        Ghost_Gem = 436,
        Dragon_Gem = 437,
        Dark_Gem = 438,
        Steel_Gem = 439,
        Normal_Gem = 440,
        Fairy_Gem = 527,
        #endregion

        /// <summary>
        /// Mega-Steine
        /// </summary>
        #region
        Gengarite = 485,
        Gardevoirite = 486,
        Ampharosite = 487,
        Venusaurite = 488,
        Charizardite_X = 489,
        Blastoisinite = 490,
        Mewtwonite_X = 491,
        Mewtwonite_Y = 492,
        Blazikenite = 493,
        Medichamite = 494,
        Houndoominite = 495,
        Aggronite = 496,
        Banettite = 497,
        Tyranitarite = 498,
        Scizorite = 499,
        Pinsirite = 500,
        Aerodactylite = 501,
        Lucarionite = 502,
        Abomasite = 503,
        Kangaskhanite = 504,
        Gyaradosite = 505,
        Absolite = 506,
        Charizardite_Y = 507,
        Alakazite = 508,
        Heracronite = 509,
        Mawilite = 510,
        Manectite = 511,
        Garchompite = 512,
        Latiasite = 513,
        Latiosite = 514,
        Swampertite = 529,
        Sceptilite = 530,
        Sablenite = 531,
        Altarianite = 532,
        Galladite = 533,
        Audinite = 534,
        Metagrossite = 535,
        Sharpedonite = 536,
        Slowbronite = 537,
        Steelixite = 538,
        Pidgeotite = 539,
        Glalitite = 540,
        Diancite = 541,
        Cameruptite = 543,
        Lopunnite = 544,
        Salamencite = 545,
        Beedrillite = 546,
        #endregion

        /// <summary>
        /// Z-Kristalle
        /// </summary>
        #region
        Normalium_Z = 547,
        Firium_Z = 548,
        Waterium_Z = 549,
        Electrium_Z = 550,
        Grassium_Z = 551,
        Icium_Z = 552,
        Fightinium_Z = 553,
        Poisonium_Z = 554,
        Groundium_Z = 555,
        Flyinium_Z = 556,
        Psychium_Z = 557,
        Buginium_Z = 558,
        Rockium_Z = 559,
        Ghostium_Z = 560,
        Dragonium_Z = 561,
        Darkinium_Z = 562,
        Steelium_Z = 563,
        Fairium_Z = 564,
        Pikanium_Z = 565,
        Decidium_Z = 568,
        Incinium_Z = 569,
        Primarium_Z = 570,
        Tapunium_Z = 571,
        Marshadium_Z = 572,
        Aloraichium_Z = 573,
        Snorlium_Z = 574,
        Eevium_Z = 575,
        Mewnium_Z = 576,
        Pikashunium_Z = 605,
        Solganium_Z = 639,
        Lunalium_Z = 640,
        Ultranecrozium_Z = 641,
        Mimikium_Z = 642,
        Lycanium_Z = 643,
        Kommonium_Z = 644,
        #endregion

        /// <summary>
        /// Minze
        /// </summary>
        #region
        Lonely_Mint = 781,
        Adamant_Mint = 782,
        Naughty_Mint = 783,
        Brave_Mint = 784,
        Bold_Mint = 785,
        Impish_Mint = 786,
        Lax_Mint = 787,
        Relaxed_Mint = 788,
        Modest_Mint = 789,
        Mild_Mint = 790,
        Rash_Mint = 791,
        Quiet_Mint = 792,
        Calm_Mint = 793,
        Gentle_Mint = 794,
        Careful_Mint = 795,
        Sassy_Mint = 796,
        Timid_Mint = 797,
        Hasty_Mint = 798,
        Jolly_Mint = 799,
        Naive_Mint = 800,
        Serious_Mint = 801,
        #endregion

        /// <summary>
        /// Ungültiges Item.
        /// </summary>
        ERROR = 1000
    }
}
