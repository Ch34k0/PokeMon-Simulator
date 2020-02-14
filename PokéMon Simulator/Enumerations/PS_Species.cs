namespace PokéMon_Simulator.Enumerations
{
    public enum PS_Species : uint
    {
        /// <summary>
        /// Gen. 1
        /// </summary>
        #region
        Bulbasaur = 1,
        Ivysaur = 2,
        Venusaur = 3 | (0 << 0x10),
        Mega_Venusaur = 3 | (1 << 0x10),
        Giga_Venusaur = 3 | (2 << 0x10),

        Charmander = 4,
        Charmeleon = 5,
        Charizard = 6 | (0 << 0x10),
        Mega_Charizard_X = 6 | (1 << 0x10),
        Mega_Charizard_Y = 6 | (2 << 0x10),
        Giga_Charizard = 6 | (3 << 0x10),

        Squirtle = 7,
        Wartortle = 8,
        Blastoise = 9 | (0 << 0x10),
        Mega_Blastoise = 9 | (1 << 0x10),
        Giga_Blastoise = 9 | (2 << 0x10),

        Caterpie = 10,
        Metapod = 11,
        Butterfree = 12 | (0 << 0x10),
        Giga_Butterfree = 12 | (1 << 0x10),

        Weedle = 13,
        Kakuna = 14,
        Beedrill = 15 | (0 << 0x10),
        Mega_Beedrill = 15 | (1 << 0x10),

        Pidgey = 16,
        Pidgeotto = 17,
        Pidgeot = 18 | (0 << 0x10),
        Mega_Pidgeot = 18 | (1 << 0x10),

        Rattata = 19 | (0 << 0x10),
        Alolan_Rattata = 19 | (1 << 0x10),
        Raticate = 20 | (0 << 0x10),
        Alolan_Raticate = 20 | (1 << 0x10),

        Spearow = 21,
        Fearow = 22,

        Ekans = 23,
        Arbok = 24,

        Pikachu = 25 | (0 << 0x10),
        Giga_Pikachu = 25 | (1 << 0x10),
        Raichu = 26 | (0 << 0x10),
        Alolan_Raichu = 26 | (1 << 0x10),

        Sandshrew = 27 | (0 << 0x10),
        Alolan_Sandshrew = 27 | (1 << 0x10),
        Sandslash = 28 | (0 << 0x10),
        Alolan_Sandslash = 28 | (1 << 0x10),

        Nidoran_F = 29,
        Nidorina = 30,
        Nidoqueen = 31,

        Nidoran_M = 32,
        Nidorino = 33,
        Nidoking = 34,

        Clefairy = 35,
        Clefable = 36,

        Vulpix = 37 | (0 << 0x10),
        Alolan_Vulpix = 37 | (1 << 0x10),
        Ninetales = 38 | (0 << 0x10),
        Alolan_Ninetales = 38 | (1 << 0x10),

        Jigglypuff = 39,
        Wigglytuff = 40,

        Zubat = 41,
        Golbat = 42,

        Oddish = 43,
        Gloom = 44,
        Vileplume = 45,

        Paras = 46,
        Parasect = 47,

        Venonat = 48,
        Venomoth = 49,

        Diglett = 50 | (0 << 0x10),
        Alolan_Diglett = 50 | (1 << 0x10),
        Dugtrio = 51 | (0 << 0x10),
        Alolan_Dugtrio = 51 | (1 << 0x10),

        Meowth = 52 | (0 << 0x10),
        Alolan_Meowth = 52 | (1 << 0x10),
        Galarian_Meowth = 52 | (2 << 0x10),
        Giga_Meowth = 52 | (3 << 0x10),
        Persian = 53 | (0 << 0x10),
        Alolan_Persian = 53 | (1 << 0x10),

        Psyduck = 54,
        Golduck = 55,

        Mankey = 56,
        Primeape = 57,

        Growlithe = 58,
        Arcanine = 59,

        Poliwag = 60,
        Poliwhirl = 61,
        Poliwrath = 62,

        Abra = 63,
        Kadabra = 64,
        Alakazam = 65 | (0 << 0x10),
        Mega_Alakazam = 65 | (1 << 0x10),

        Machop = 66,
        Machoke = 67,
        Machamp = 68 | (0 << 0x10),
        Giga_Machamp = 68 | (1 << 0x10),

        Bellsprout = 69,
        Weepinbell = 70,
        Victreebel = 71,

        Tentacool = 72,
        Tentacruel = 73,

        Geodude = 74 | (0 << 0x10),
        Alolan_Geodude = 74 | (1 << 0x10),
        Graveler = 75 | (0 << 0x10),
        Alolan_Graveler = 75 | (1 << 0x10),
        Golem = 76 | (0 << 0x10),
        Alolan_Golem = 76 | (1 << 0x10),

        Ponyta = 77 | (0 << 0x10),
        Galarian_Ponyta = 77 | (1 << 0x10),
        Rapidash = 78 | (0 << 0x10),
        Galarian_Rapidash = 78 | (1 << 0x10),

        Slowpoke = 79 | (0 << 0x10),
        Galarian_Slowpoke = 79 | (1 << 0x10),
        Slowbro = 80 | (0 << 0x10),
        Mega_Slowbro = 80 | (1 << 0x10),
        Galarian_Slowbro = 80 | (2 << 0x10),

        Magnemite = 81,
        Magneton = 82,

        Farfetchd = 83 | (0 << 0x10),
        Galarian_Farfetchd = 83 | (1 << 0x10),

        Doduo = 84,
        Dodrio = 85,

        Seel = 86,
        Dewgong = 87,

        Grimer = 88 | (0 << 0x10),
        Alolan_Grimer = 88 | (1 << 0x10),
        Muk = 89 | (0 << 0x10),
        Alolan_Muk = 89 | (1 << 0x10),

        Shellder = 90,
        Cloyster = 91,

        Gastly = 92,
        Haunter = 93,
        Gengar = 94 | (0 << 0x10),
        Mega_Gengar = 94 | (1 << 0x10),
        Giga_Gengar = 94 | (2 << 0x10),

        Onix = 95,

        Drowzee = 96,
        Hypno = 97,

        Krabby = 98,
        Kingler = 99 | (0 << 0x10),
        Giga_Kingler = 99 | (1 << 0x10),

        Voltorb = 100,
        Electrode = 101,

        Exeggcute = 102,
        Exeggutor = 103 | (0 << 0x10),
        Alolan_Exeggutor = 103 | (1 << 0x10),

        Cubone = 104,
        Marowak = 105 | (0 << 0x10),
        Alolan_Marowak = 105 | (1 << 0x10),

        Hitmonlee = 106,
        Hitmonchan = 107,

        Lickitung = 108,

        Koffing = 109,
        Weezing = 110 | (0 << 0x10),
        Galarian_Weezing = 110 | (1 << 0x10),

        Rhyhorn = 111,
        Rhydon = 112,

        Chansey = 113,

        Tangela = 114,

        Kangaskhan = 115 | (0 << 0x10),
        Mega_Kangaskhan = 115 | (1 << 0x10),

        Horsea = 116,
        Seadra = 117,

        Goldeen = 118,
        Seaking = 119,

        Staryu = 120,
        Starmie = 121,

        Mr_Mime = 122 | (0 << 0x10),
        Galarian_Mr_Mime = 122 | (1 << 0x10),

        Scyther = 123,

        Jynx = 124,

        Electabuzz = 125,

        Magmar = 126,

        Pinsir = 127 | (0 << 0x10),
        Mega_Pinsir = 127 | (1 << 0x10),

        Tauros = 128,

        Magikarp = 129,
        Gyarados = 130 | (0 << 0x10),
        Mega_Gyarados = 130 | (1 << 0x10),

        Lapras = 131 | (0 << 0x10),
        Giga_Lapras = 131 | (1 << 0x10),

        Ditto = 132,

        Eevee = 133 | (0 << 0x10),
        Giga_Eevee = 133 | (1 << 0x10),
        Vaporeon = 134,
        Jolteon = 135,
        Flareon = 136,

        Porygon = 137,

        Omanyte = 138,
        Omastar = 139,

        Kabuto = 140,
        Kabutops = 141,

        Aerodactyl = 142 | (0 << 0x10),
        Mega_Aerodactyl = 142 | (1 << 0x10),

        Snorlax = 143 | (0 << 0x10),
        Giga_Snorlax = 143 | (1 << 0x10),

        Articuno = 144 | (0 << 0x10),
        Galarian_Articuno = 144 | (1 << 0x10),
        Zapdos = 145 | (0 << 0x10),
        Galarian_Zapdos = 145 | (1 << 0x10),
        Moltres = 146 | (0 << 0x10),
        Galarian_Moltres = 146 | (1 << 0x10),

        Dratini = 147,
        Dragonair = 148,
        Dragonite = 149,

        Mewtwo = 150 | (0 << 0x10),
        Mega_Mewtwo_X = 150 | (1 << 0x10),
        Mega_Mewtwo_Y = 150 | (2 << 0x10),
        Mew = 151,
        #endregion

        /// <summary>
        /// Gen. 2
        /// </summary>
        #region
        Chikorita = 152,
        Bayleef = 153,
        Meganium = 154,

        Cyndaquil = 155,
        Quilava = 156,
        Typhlosion = 157,

        Totodile = 158,
        Croconaw = 159,
        Feraligatr = 160,

        Sentret = 161,
        Furret = 162,

        Hoothoot = 163,
        Noctowl = 164,

        Ledyba = 165,
        Ledian = 166,

        Spinarak = 167,
        Ariados = 168,

        Crobat = 169,

        Chinchou = 170,
        Lanturn = 171,

        Pichu = 172,

        Cleffa = 173,

        Igglybuff = 174,

        Togepi = 175,
        Togetic = 176,

        Natu = 177,
        Xatu = 178,

        Mareep = 179,
        Flaaffy = 180,
        Ampharos = 181 | (0 << 0x10),
        Mega_Ampharos = 181 | (1 << 0x10),

        Bellossom = 182,

        Marill = 183,
        Azumarill = 184,

        Sudowoodo = 185,

        Politoed = 186,

        Hoppip = 187,
        Skiploom = 188,
        Jumpluff = 189,

        Aipom = 190,

        Sunkern = 191,
        Sunflora = 192,

        Yanma = 193,

        Wooper = 194,
        Quagsire = 195,

        Espeon = 196,
        Umbreon = 197,

        Murkrow = 198,

        Slowking = 199 | (0 << 0x10),
        Galarian_Slowking = 199 | (1 << 0x10),

        Misdreavus = 200,

        Unown_A = 201 | (0 << 0x10),
        Unown_B = 201 | (1 << 0x10),
        Unown_C = 201 | (2 << 0x10),
        Unown_D = 201 | (3 << 0x10),
        Unown_E = 201 | (4 << 0x10),
        Unown_F = 201 | (5 << 0x10),
        Unown_G = 201 | (6 << 0x10),
        Unown_H = 201 | (7 << 0x10),
        Unown_I = 201 | (8 << 0x10),
        Unown_J = 201 | (9 << 0x10),
        Unown_K = 201 | (10 << 0x10),
        Unown_L = 201 | (11 << 0x10),
        Unown_M = 201 | (12 << 0x10),
        Unown_N = 201 | (13 << 0x10),
        Unown_O = 201 | (14 << 0x10),
        Unown_P = 201 | (15 << 0x10),
        Unown_Q = 201 | (16 << 0x10),
        Unown_R = 201 | (17 << 0x10),
        Unown_S = 201 | (18 << 0x10),
        Unown_T = 201 | (19 << 0x10),
        Unown_U = 201 | (20 << 0x10),
        Unown_V = 201 | (21 << 0x10),
        Unown_W = 201 | (22 << 0x10),
        Unown_X = 201 | (23 << 0x10),
        Unown_Y = 201 | (24 << 0x10),
        Unown_Z = 201 | (25 << 0x10),
        Unown_Exclamation = 201 | (26 << 0x10),
        Unown_Question = 201 | (27 << 0x10),

        Wobbuffet = 202,

        Girafarig = 203,

        Pineco = 204,
        Forretress = 205,

        Dunsparce = 206,

        Gligar = 207,

        Steelix = 208 | (0 << 0x10),
        Mega_Steelix = 208 | (1 << 0x10),

        Snubbull = 209,
        Granbull = 210,

        Qwilfish = 211,

        Scizor = 212 | (0 << 0x10),
        Mega_Scizor = 212 | (1 << 0x10),

        Shuckle = 213,

        Heracross = 214 | (0 << 0x10),
        Mega_Heracross = 214 | (1 << 0x10),

        Sneasel = 215,

        Teddiursa = 216,
        Ursaring = 217,

        Slugma = 218,
        Magcargo = 219,

        Swinub = 220,
        Piloswine = 221,

        Corsola = 222 | (0 << 0x10),
        Galarian_Corsola = 222 | (1 << 0x10),

        Remoraid = 223,
        Octillery = 224,

        Delibird = 225,

        Mantine = 226,

        Skarmory = 227,

        Houndour = 228,
        Houndoom = 229 | (0 << 0x10),
        Mega_Houndoom = 229 | (1 << 0x10),

        Kingdra = 230,

        Phanpy = 231,
        Donphan = 232,

        Porygon2 = 233,

        Stantler = 234,

        Smeargle = 235,

        Tyrogue = 236,
        Hitmontop = 237,

        Smoochum = 238,

        Elekid = 239,

        Magby = 240,

        Miltank = 241,

        Blissey = 242,

        Raikou = 243,
        Entei = 244,
        Suicune = 245,

        Larvitar = 246,
        Pupitar = 247,
        Tyranitar = 248 | (0 << 0x10),
        Mega_Tyranitar = 248 | (1 << 0x10),

        Lugia = 249,

        Ho_Oh = 250,

        Celebi = 251,
        #endregion

        /// <summary>
        /// Gen. 3
        /// </summary>
        #region

        Treecko = 252,
        Grovyle = 253,
        Sceptile = 254 | (0 << 0x10),
        Mega_Sceptile = 254 | (1 << 0x10),

        Torchic = 255,
        Combusken = 256,
        Blaziken = 257 | (0 << 0x10),
        Mega_Blaziken = 257 | (1 << 0x10),

        Mudkip = 258,
        Marshtomp = 259,
        Swampert = 260 | (0 << 0x10),
        Mega_Swampert = 260 | (1 << 0x10),

        Poochyena = 261,
        Mightyena = 262,

        Zigzagoon = 263 | (0 << 0x10),
        Galarian_Zigzagoon = 263 | (0 << 0x10),
        Linoone = 264 | (0 << 0x10),
        Galarian_Linoone = 264 | (0 << 0x10),

        Wurmple = 265,
        Silcoon = 266,
        Beautifly = 267,
        Cascoon = 268,
        Dustox = 269,

        Lotad = 270,
        Lombre = 271,
        Ludicolo = 272,

        Seedot = 273,
        Nuzleaf = 274,
        Shiftry = 275,

        Taillow = 276,
        Swellow = 277,

        Wingull = 278,
        Pelipper = 279,

        Ralts = 280,
        Kirlia = 281,
        Gardevoir = 282 | (0 << 0x10),
        Mega_Gardevoir = 282 | (1 << 0x10),

        Surskit = 283,
        Masquerain = 284,

        Shroomish = 285,
        Breloom = 286,

        Slakoth = 287,
        Vigoroth = 288,
        Slaking = 289,

        Nincada = 290,
        Ninjask = 291,
        Shedinja = 292,

        Whismur = 293,
        Loudred = 294,
        Exploud = 295,

        Makuhita = 296,
        Hariyama = 297,

        Azurill = 298,

        Nosepass = 299,

        Skitty = 300,
        Delcatty = 301,

        Sableye = 302 | (0 << 0x10),
        Mega_Sableye = 302 | (1 << 0x10),

        Mawile = 303 | (0 << 0x10),
        Mega_Mawile = 303 | (1 << 0x10),

        Aron = 304,
        Lairon = 305,
        Aggron = 306 | (0 << 0x10),
        Mega_Aggron = 306 | (1 << 0x10),

        Meditite = 307,
        Medicham = 308 | (0 << 0x10),

        Electrike = 309,
        Manectric = 310 | (0 << 0x10),
        Mega_Manectric = 310 | (1 << 0x10),

        Plusle = 311,
        Minun = 312,

        Volbeat = 313,
        Illumise = 314,

        Roselia = 315,

        Gulpin = 316,
        Swalot = 317,

        Carvanha = 318,
        Sharpedo = 319 | (0 << 0x10),
        Mega_Sharpedo = 319 | (1 << 0x10),

        Wailmer = 320,
        Wailord = 321,

        Numel = 322,
        Camerupt = 323 | (0 << 0x10),
        Mega_Camerupt = 323 | (1 << 0x10),

        Torkoal = 324,

        Spoink = 325,
        Grumpig = 326,

        Spinda = 327,

        Trapinch = 328,
        Vibrava = 329,
        Flygon = 330,

        Cacnea = 331,
        Cacturne = 332,

        Swablu = 333,
        Altaria = 334 | (0 << 0x10),
        Mega_Altaria = 334 | (1 << 0x10),

        Zangoose = 335,
        Seviper = 336,

        Lunatone = 337,
        Solrock = 338,

        Barboach = 339,
        Whiscash = 340,

        Corphish = 341,
        Crawdaunt = 342,

        Baltoy = 343,
        Claydol = 344,

        Lileep = 345,
        Cradily = 346,

        Anorith = 347,
        Armaldo = 348,

        Feebas = 349,
        Milotic = 350,

        Castform = 351 | (0 << 0x10),
        Castform_Rainy = 351 | (0 << 0x10),
        Castform_Snowy = 351 | (0 << 0x10),
        Castform_Sunny = 351 | (0 << 0x10),

        Kecleon = 352,

        Shuppet = 353,
        Banette = 354 | (0 << 0x10),
        Mega_Banette = 354 | (1 << 0x10),

        Duskull = 355,
        Dusclops = 356,

        Tropius = 357,

        Chimecho = 358,

        Absol = 359 | (0 << 0x10),
        Mega_Absol = 359 | (1 << 0x10),

        Wynaut = 360,

        Snorunt = 361,
        Glalie = 362 | (0 << 0x10),
        Mega_Glalie = 362 | (1 << 0x10),

        Spheal = 363,
        Sealeo = 364,
        Walrein = 365,

        Clamperl = 366,
        Huntail = 367,
        Gorebyss = 368,

        Relicanth = 369,

        Luvdisc = 370,

        Bagon = 371,
        Shelgon = 372,
        Salamence = 373 | (0 << 0x10),
        Mega_Salamence = 373 | (1 << 0x10),

        Beldum = 374,
        Metang = 375,
        Metagross = 376 | (0 << 0x10),
        Mega_Metagross = 376 | (1 << 0x10),

        Regirock = 377,
        Regice = 378,
        Registeel = 379,

        Latias = 380 | (0 << 0x10),
        Mega_Latias = 380 | (0 << 0x10),
        Latios = 381 | (0 << 0x10),
        Mega_Latios = 381 | (0 << 0x10),

        Kyogre = 382 | (0 << 0x10),
        Proto_Kyogre = 382 | (1 << 0x10),
        Groudon = 383 | (0 << 0x10),
        Proto_Groudon = 383 | (1 << 0x10),
        Rayquaza = 384 | (0 << 0x10),
        Mega_Rayquaza = 384 | (1 << 0x10),

        Jirachi = 385,

        Deoxys = 386 | (0 << 0x10),
        Deoxys_Attack = 386 | (1 << 0x10),
        Deoxys_Defense = 386 | (2 << 0x10),
        Deoxys_Speed = 386 | (3 << 0x10),

        #endregion

        /// <summary>
        /// Gen. 4
        /// </summary>
        #region

        Turtwig = 387,
        Grotle = 388,
        Torterra = 389,

        Chimchar = 390,
        Monferno = 391,
        Infernape = 392,

        Piplup = 393,
        Prinplup = 394,
        Empoleon = 395,

        Starly = 396,
        Staravia = 397,
        Staraptor = 398,

        Bidoof = 399,
        Bibarel = 400,

        Kricketot = 401,
        Kricketune = 402,

        Shinx = 403,
        Luxio = 404,
        Luxray = 405,

        Budew = 406,
        Roserade = 407,

        Cranidos = 408,
        Rampardos = 409,

        Shieldon = 410,
        Bastiodon = 411,

        Burmy_Plant = 412 | (0 << 0x10),
        Burmy_Sandy = 412 | (0 << 0x10),
        Burmy_Trash = 412 | (0 << 0x10),
        Wormadam_Plant = 413 | (0 << 0x10),
        Wormadam_Sandy = 413 | (0 << 0x10),
        Wormadam_Trash = 413 | (0 << 0x10),
        Mothim = 414,

        Combee = 415,
        Vespiquen = 416,

        Pachirisu = 417,

        Buizel = 418,
        Floatzel = 419,

        Cherubi = 420,
        Cherrim = 421 | (0 << 0x10),
        Cherrim_Sunshine = 421 | (1 << 0x10),

        Shellos_East = 422 | (0 << 0x10),
        Shellos_West = 422 | (1 << 0x10),
        Gastrodon_East = 423 | (0 << 0x10),
        Gastrodon_West = 423 | (1 << 0x10),

        Ambipom = 424,

        Drifloon = 425,
        Drifblim = 426,

        Buneary = 427,
        Lopunny = 428 | (0 << 0x10),
        Mega_Lopunny = 428 | (1 << 0x10),

        Mismagius = 429,

        Honchkrow = 430,

        Glameow = 431,
        Purugly = 432,

        Chingling = 433,

        Stunky = 434,
        Skuntank = 435,

        Bronzor = 436,
        Bronzong = 437,

        Bonsly = 438,

        Mime_Jr = 439,

        Happiny = 440,

        Chatot = 441,

        Spiritomb = 442,

        Gible = 443,
        Gabite = 444,
        Garchomp = 445 | (0 << 0x10),
        Mega_Garchomp = 445 | (1 << 0x10),

        Munchlax = 446,

        Riolu = 447,
        Lucario = 448 | (0 << 0x10),
        Mega_Lucario = 448 | (1 << 0x10),

        Hippopotas = 449,
        Hippowdon = 450,

        Skorupi = 451,
        Drapion = 452,

        Croagunk = 453,
        Toxicroak = 454,

        Carnivine = 455,

        Finneon = 456,
        Lumineon = 457,

        Mantyke = 458,

        Snover = 459,
        Abomasnow = 460 | (0 << 0x10),
        Mega_Abomasnow = 460 | (1 << 0x10),

        Weavile = 461,

        Magnezone = 462,

        Lickilicky = 463,

        Rhyperior = 464,

        Tangrowth = 465,

        Electivire = 466,

        Magmortar = 467,

        Togekiss = 468,

        Yanmega = 469,

        Leafeon = 470,
        Glaceon = 471,

        Gliscor = 472,

        Mamoswine = 473,

        Porygon_Z = 474,

        Gallade = 475 | (0 << 0x10),
        Mega_Gallade = 475 | (1 << 0x10),

        Probopass = 476,

        Dusknoir = 477,

        Froslass = 478,

        Rotom = 479 | (0 << 0x10),
        Rotom_Fan = 479 | (1 << 0x10),
        Rotom_Frost = 479 | (2 << 0x10),
        Rotom_Heat = 479 | (3 << 0x10),
        Rotom_Mow = 479 | (4 << 0x10),
        Rotom_Wash = 479 | (5 << 0x10),

        Uxie = 480,
        Mesprit = 481,
        Azelf = 482,

        Dialga = 483,
        Palkia = 484,

        Heatran = 485,

        Regigigas = 486,

        Giratina = 487 | (0 << 0x10),
        Giratina_Origin = 487 | (1 << 0x10),

        Cresselia = 488,

        Phione = 489,
        Manaphy = 490,

        Darkrai = 491,

        Shaymin = 492 | (0 << 0x10),
        Shaymin_Sky = 492 | (1 << 0x10),

        Arceus = 493 | (0 << 0x10),
        Arceus_Fighting = 493 | (1 << 0x10),
        Arceus_Flying = 493 | (2 << 0x10),
        Arceus_Poison = 493 | (3 << 0x10),
        Arceus_Ground = 493 | (4 << 0x10),
        Arceus_Rock = 493 | (5 << 0x10),
        Arceus_Bug = 493 | (6 << 0x10),
        Arceus_Ghost = 493 | (7 << 0x10),
        Arceus_Steel = 493 | (8 << 0x10),
        Arceus_Fire = 493 | (9 << 0x10),
        Arceus_Water = 493 | (10 << 0x10),
        Arceus_Grass = 493 | (11 << 0x10),
        Arceus_Electric = 493 | (12 << 0x10),
        Arceus_Psychic = 493 | (13 << 0x10),
        Arceus_Ice = 493 | (14 << 0x10),
        Arceus_Dragon = 493 | (15 << 0x10),
        Arceus_Dark = 493 | (16 << 0x10),
        Arceus_Fairy = 493 | (17 << 0x10),

        #endregion

        /// <summary>
        /// Gen. 5
        /// </summary>
        #region
        Victini = 494,

        Snivy = 495,
        Servine = 496,
        Serperior = 497,

        Tepig = 498,
        Pignite = 499,
        Emboar = 500,

        Oshawott = 501,
        Dewott = 502,
        Samurott = 503,

        Patrat = 504,
        Watchog = 505,

        Lillipup = 506,
        Herdier = 507,
        Stoutland = 508,

        Purrloin = 509,
        Liepard = 510,

        Pansage = 511,
        Simisage = 512,

        Pansear = 513,
        Simisear = 514,

        Panpour = 515,
        Simipour = 516,

        Munna = 517,
        Musharna = 518,

        Pidove = 519,
        Tranquill = 520,
        Unfezant = 521,

        Blitzle = 522,
        Zebstrika = 523,

        Roggenrola = 524,
        Boldore = 525,
        Gigalith = 526,

        Woobat = 527,
        Swoobat = 528,

        Drilbur = 529,
        Excadrill = 530,

        Audino = 531 | (0 << 0x10),
        Mega_Audino = 531 | (1 << 0x10),

        Timburr = 532,
        Gurdurr = 533,
        Conkeldurr = 534,

        Tympole = 535,
        Palpitoad = 536,
        Seismitoad = 537,

        Throh = 538,
        Sawk = 539,

        Sewaddle = 540,
        Swadloon = 541,
        Leavanny = 542,

        Venipede = 543,
        Whirlipede = 544,
        Scolipede = 545,

        Cottonee = 546,
        Whimsicott = 547,

        Petilil = 548,
        Lilligant = 549,

        Basculin_Redline = 550 | (0 << 0x10),
        Basculin_Blueline = 550 | (1 << 0x10),

        Sandile = 551,
        Krokorok = 552,
        Krookodile = 553,

        Darumaka = 554 | (0 << 0x10),
        Galarian_Darumaka = 554 | (1 << 0x10),
        Darmanitan = 555 | (0 << 0x10),
        Darmanitan_Zen = 555 | (1 << 0x10),
        Galarian_Darmanitan = 555 | (2 << 0x10),
        Galarian_Darmanitan_Zen = 555 | (3 << 0x10),

        Maractus = 556,

        Dwebble = 557,
        Crustle = 558,

        Scraggy = 559,
        Scrafty = 560,

        Sigilyph = 561,

        Yamask = 562 | (0 << 0x10),
        Galarian_Yamask = 562 | (1 << 0x10),
        Cofagrigus = 563,

        Tirtouga = 564,
        Carracosta = 565,

        Archen = 566,
        Archeops = 567,

        Trubbish = 568,
        Garbodor = 569 | (0 << 0x10),
        Giga_Garbodor = 569 | (1 << 0x10),

        Zorua = 570,
        Zoroark = 571,

        Minccino = 572,
        Cinccino = 573,

        Gothita = 574,
        Gothorita = 575,
        Gothitelle = 576,

        Solosis = 577,
        Duosion = 578,
        Reuniclus = 579,

        Ducklett = 580,
        Swanna = 581,

        Vanillite = 582,
        Vanillish = 583,
        Vanilluxe = 584,

        Deerling_Spring = 585 | (0 << 0x10),
        Deerling_Summer = 585 | (1 << 0x10),
        Deerling_Autumn = 585 | (2 << 0x10),
        Deerling_Winter = 585 | (3 << 0x10),
        Sawsbuck_Spring = 586 | (0 << 0x10),
        Sawsbuck_Summer = 586 | (1 << 0x10),
        Sawsbuck_Autumn = 586 | (2 << 0x10),
        Sawsbuck_Winter = 586 | (3 << 0x10),

        Emolga = 587,

        Karrablast = 588,
        Escavalier = 589,

        Foongus = 590,
        Amoonguss = 591,

        Frillish = 592,
        Jellicent = 593,

        Alomomola = 594,

        Joltik = 595,
        Galvantula = 596,

        Ferroseed = 597,
        Ferrothorn = 598,

        Klink = 599,
        Klang = 600,
        Klinklang = 601,

        Tynamo = 602,
        Eelektrik = 603,
        Eelektross = 604,

        Elgyem = 605,
        Beheeyem = 606,

        Litwick = 607,
        Lampent = 608,
        Chandelure = 609,

        Axew = 610,
        Fraxure = 611,
        Haxorus = 612,

        Cubchoo = 613,
        Beartic = 614,

        Cryogonal = 615,

        Shelmet = 616,
        Accelgor = 617,

        Stunfisk = 618 | (0 << 0x10),
        Galarian_Stunfisk = 618 | (1 << 0x10),

        Mienfoo = 619,
        Mienshao = 620,

        Druddigon = 621,

        Golett = 622,
        Golurk = 623,

        Pawniard = 624,
        Bisharp = 625,

        Bouffalant = 626,

        Rufflet = 627,
        Braviary = 628,

        Vullaby = 629,
        Mandibuzz = 630,

        Heatmor = 631,
        Durant = 632,

        Deino = 633,
        Zweilous = 634,
        Hydreigon = 635,

        Larvesta = 636,
        Volcarona = 637,

        Cobalion = 638,
        Terrakion = 639,
        Virizion = 640,

        Tornadus_Incarnation = 641 | (0 << 0x10),
        Tornadus_Therian = 641 | (1 << 0x10),
        Thundurus_Incarnation = 642 | (0 << 0x10),
        Thundurus_Therian = 642 | (1 << 0x10),

        Reshiram = 643,
        Zekrom = 644,

        Landorus_Incarnation = 645 | (0 << 0x10),
        Landorus_Therian = 645 | (1 << 0x10),

        Kyurem = 646 | (0 << 0x10),
        Kyurem_Black = 646 | (1 << 0x10),
        Kyurem_White = 646 | (2 << 0x10),

        Keldeo = 647 | (0 << 0x10),
        Keldeo_Resolute = 647 | (1 << 0x10),

        Meloetta_Sing = 649 | (0 << 0x10),
        Meloetta_Dance = 649 | (1 << 0x10),

        Genesect = 640 | (0 << 0x10),
        Genesect_Burn = 640 | (1 << 0x10),
        Genesect_Chill = 640 | (2 << 0x10),
        Genesect_Douse = 640 | (3 << 0x10),
        Genesect_Shock = 640 | (4 << 0x10),

        #endregion


        /// <summary>
        /// Gen. 6
        /// </summary>
        #region
        Chespin = 650,
        Quilladin = 651,
        Chesnaught = 652,

        Fennekin = 653,
        Braixen = 654,
        Delphox = 655,

        Froakie = 656,
        Frogadier = 657,
        Greninja = 658 | (0 << 0x10),
        Ash_Greninja = 658 | (1 << 0x10),

        Bunnelby = 659,
        Diggersby = 660,

        Fletchling = 661,
        Fletchinder = 662,
        Talonflame = 663,

        Scatterbug = 664,
        Spewpa = 665,
        Vivillon_Aquamarin = 666 | (0 << 0x10),
        Vivillon_Archipelago = 666 | (1 << 0x10),
        Vivillon_Flowerocean = 666 | (2 << 0x10),
        Vivillon_Jungle = 666 | (3 << 0x10),
        Vivillon_Drought = 666 | (4 << 0x10),
        Vivillon_Snowy = 666 | (5 << 0x10),
        Vivillon_Riverdelta = 666 | (6 << 0x10),
        Vivillon_Frost = 666 | (7 << 0x10),
        Vivillon_Innovation = 666 | (8 << 0x10),
        Vivillon_Continental = 666 | (9 << 0x10),
        Vivillon_Rain = 666 | (10 << 0x10),
        Vivillon_Ocean = 666 | (11 << 0x10),
        Vivillon_Pomp = 666 | (12 << 0x10),
        Vivillon_Sand = 666 | (13 << 0x10),
        Vivillon_Savannah = 666 | (14 << 0x10),
        Vivillon_Snowfield = 666 | (15 << 0x10),
        Vivillon_Sun = 666 | (16 << 0x10),
        Vivillon_Garden = 666 | (17 << 0x10),
        Vivillon_Fantasy = 666 | (18 << 0x10),
        Vivillon_Pokeball = 666 | (19 << 0x10),

        Litleo = 667,
        Pyroar = 668,

        Flabébé_Red = 669 | (0 << 0x10),
        Flabébé_Yellow = 669 | (1 << 0x10),
        Flabébé_Orange = 669 | (2 << 0x10),
        Flabébé_Blue = 669 | (3 << 0x10),
        Flabébé_White = 669 | (4 << 0x10),
        Floette_Red = 670 | (0 << 0x10),
        Floette_Yellow = 670 | (1 << 0x10),
        Floette_Orange = 670 | (2 << 0x10),
        Floette_Blue = 670 | (3 << 0x10),
        Floette_White = 670 | (4 << 0x10),
        Floette_AZ = 670 | (5 << 0x10),
        Florges_Red = 671 | (0 << 0x10),
        Florges_Yellow = 671 | (1 << 0x10),
        Florges_Orange = 671 | (2 << 0x10),
        Florges_Blue = 671 | (3 << 0x10),
        Florges_White = 671 | (4 << 0x10),

        Skiddo = 672,
        Gogoat = 673,

        Pancham = 674,
        Pangoro = 675,

        Furfrou = 676 | (0 << 0x10),
        Furfrou_HeartCut = 676 | (1 << 0x10),
        Furfrou_StarCut = 676 | (2 << 0x10),
        Furfrou_DiamondCut = 676 | (3 << 0x10),
        Furfrou_QueenCut = 676 | (4 << 0x10),
        Furfrou_KabukiCut = 676 | (5 << 0x10),
        Furfrou_RulerCut = 676 | (6 << 0x10),
        Furfrou_MissCut = 676 | (7 << 0x10),
        Furfrou_LadyCut = 676 | (8 << 0x10),
        Furfrou_CavalierCut = 676 | (9 << 0x10),

        Espurr = 677,
        Meowstic = 678,

        Honedge = 679,
        Doublade = 680,
        Aegislash_Shield = 681 | (0 << 0x10),
        Aegislash_Blade = 681 | (1 << 0x10),

        Spritzee = 682,
        Aromatisse = 683,

        Swirlix = 684,
        Slurpuff = 685,

        Inkay = 686,
        Malamar = 687,

        Binacle = 688,
        Barbaracle = 689,

        Skrelp = 690,
        Dragalge = 691,

        Clauncher = 692,
        Clawitzer = 693,

        Helioptile = 694,
        Heliolisk = 695,

        Tyrunt = 696,
        Tyrantrum = 697,

        Amaura = 698,
        Aurorus = 699,

        Sylveon = 700,

        Hawlucha = 701,

        Dedenne = 702,

        Carbink = 703,

        Goomy = 704,
        Sliggoo = 705,
        Goodra = 706,

        Klefki = 707,

        Phantump = 708,
        Trevenant = 709,

        Pumpkaboo_S = 710 | (0 << 0x10),
        Pumpkaboo_M = 710 | (1 << 0x10),
        Pumpkaboo_L = 710 | (2 << 0x10),
        Pumpkaboo_XL = 710 | (3 << 0x10),
        Gourgeist_S = 711 | (0 << 0x10),
        Gourgeist_M = 711 | (1 << 0x10),
        Gourgeist_L = 711 | (2 << 0x10),
        Gourgeist_XL = 711 | (3 << 0x10),

        Bergmite = 712,
        Avalugg = 713,

        Noibat = 714,
        Noivern = 715,

        Xerneas = 716 | (0 << 0x10),
        Xerneas_Active = 716 | (1 << 0x10),
        Yveltal = 717,

        Zygarde_50 = 718 | (0 << 0x10),
        Zygarde_10 = 718 | (1 << 0x10),
        Zygarde_100 = 718 | (2 << 0x10),

        Diancie = 719 | (0 << 0x10),
        Mega_Diancie = 719 | (1 << 0x10),

        Hoopa = 720 | (0 << 0x10),
        Hoopa_Unbound = 720 | (0 << 0x10),

        Volcanion = 721,
        #endregion

        /// <summary>
        /// Gen. 7
        /// </summary>
        #region
        Rowlet = 722,
        Dartrix = 723,
        Decidueye = 724,

        Litten = 725,
        Torracat = 726,
        Incineroar = 727,

        Popplio = 728,
        Brionne = 729,
        Primarina = 730,

        Pikipek = 731,
        Trumbeak = 732,
        Toucannon = 733,

        Yungoos = 734,
        Gumshoos = 735,

        Grubbin = 736,
        Charjabug = 737,
        Vikavolt = 738,

        Crabrawler = 739,
        Crabominable = 740,

        Oricorio_Flamenco = 741 | (0 << 0x10),
        Oricorio_PomPom = 741 | (1 << 0x10),
        Oricorio_Hula = 741 | (2 << 0x10),
        Oricorio_Buyo = 741 | (3 << 0x10),

        Cutiefly = 742,
        Ribombee = 743,

        Rockruff = 744,
        Lycanroc_Day = 745 | (0 << 0x10),
        Lycanroc_Night = 745 | (1 << 0x10),
        Lycanroc_Twilight = 745 | (2 << 0x10),

        Wishiwashi = 746 | (0 << 0x10),
        Wishiwashi_School = 746 | (1 << 0x10),

        Mareanie = 747,
        Toxapex = 748,

        Mudbray = 749,
        Mudsdale = 750,

        Dewpider = 751,
        Araquanid = 752,

        Fomantis = 753,
        Lurantis = 754,

        Morelull = 755,
        Shiinotic = 756,

        Salandit = 757,
        Salazzle = 758,

        Stufful = 759,
        Bewear = 760,

        Bounsweet = 761,
        Steenee = 762,
        Tsareena = 763,

        Comfey = 764,

        Oranguru = 765,

        Passimian = 766,

        Wimpod = 767,
        Golisopod = 768,

        Sandygast = 769,
        Palossand = 770,

        Pyukumuku = 771,

        Type_Null = 772,
        Silvally = 773 | (0 << 0x10),
        Silvally_Fighting = 773 | (1 << 0x10),
        Silvally_Flying = 773 | (2 << 0x10),
        Silvally_Poison = 773 | (3 << 0x10),
        Silvally_Ground = 773 | (4 << 0x10),
        Silvally_Rock = 773 | (5 << 0x10),
        Silvally_Bug = 773 | (6 << 0x10),
        Silvally_Ghost = 773 | (7 << 0x10),
        Silvally_Steel = 773 | (8 << 0x10),
        Silvally_Fire = 773 | (9 << 0x10),
        Silvally_Water = 773 | (10 << 0x10),
        Silvally_Grass = 773 | (11 << 0x10),
        Silvally_Electric = 773 | (12 << 0x10),
        Silvally_Psychic = 773 | (13 << 0x10),
        Silvally_Ice = 773 | (14 << 0x10),
        Silvally_Dragon = 773 | (15 << 0x10),
        Silvally_Dark = 773 | (16 << 0x10),
        Silvally_Fairy = 773 | (17 << 0x10),

        Minior_Red = 774 | (0 << 0x10),
        Minior_Orange = 774 | (1 << 0x10),
        Minior_Yellow = 774 | (2 << 0x10),
        Minior_Green = 774 | (3 << 0x10),
        Minior_LightBlue = 774 | (4 << 0x10),
        Minior_Blue = 774 | (5 << 0x10),
        Minior_Purple = 774 | (6 << 0x10),
        Minior_Shield = 774 | (7 << 0x10),

        Komala = 775,

        Turtonator = 776,

        Togedemaru = 777,

        Mimikyu = 778 | (0 << 0x10),
        Mimikyu_Exposed = 778 | (1 << 0x10),

        Bruxish = 779,

        Drampa = 780,

        Dhelmise = 781,

        Jangmo_o = 782,
        Hakamo_o = 783,
        Kommo_o = 784,

        Tapu_Koko = 785,
        Tapu_Lele = 786,
        Tapu_Bulu = 787,
        Tapu_Fini = 788,

        Cosmog = 789,
        Cosmoem = 790,
        Solgaleo = 791,
        Lunala = 792,

        Nihilego = 793,
        Buzzwole = 794,
        Pheromosa = 795,
        Xurkitree = 796,
        Celesteela = 797,
        Kartana = 798,
        Guzzlord = 799,

        Necrozma = 800 | (0 << 0x10),
        Necrozma_Dawn = 800 | (1 << 0x10),
        Necrozma_Dusk = 800 | (2 << 0x10),
        Necrozma_Ultra = 800 | (3 << 0x10),

        Magearna = 801 | (0 << 0x10),
        Magearna_Original = 801 | (1 << 0x10),

        Marshadow = 802,

        Poipole = 803,
        Naganadel = 804,

        Stakataka = 805,
        Blacephalon = 806,

        Zeraora = 807,

        Meltan = 808,
        Melmetal = 809 | (0 << 0x10),
        Giga_Melmetal = 809 | (1 << 0x10),
        #endregion

        /// <summary>
        /// Gen. 8
        /// </summary>
        #region
        Grookey = 810,
        Thwackey = 811,
        Rillaboom = 812 | (0 << 0x10),
        Giga_Rillaboom = 812 | (1 << 0x10),

        Scorbunny = 813,
        Raboot = 814,
        Cinderace = 815 | (0 << 0x10),
        Giga_Cinderace = 815 | (1 << 0x10),

        Sobble = 816,
        Drizzile = 817,
        Inteleon = 818 | (0 << 0x10),
        Giga_Inteleon = 818 | (1 << 0x10),

        Skwovet = 819,
        Greedent = 820,

        Rookidee = 821,
        Corvisquire = 822,
        Corviknight = 823 | (0 << 0x10),
        Giga_Corviknight = 823 | (1 << 0x10),

        Blipbug = 824,
        Dottler = 825,
        Orbeetle = 826 | (0 << 0x10),
        Giga_Orbeetle = 826 | (1 << 0x10),

        Nickit = 827,
        Thievul = 828,

        Gossifleur = 829,
        Eldegoss = 830,

        Wooloo = 831,
        Dubwool = 832,

        Chewtle = 833,
        Drednaw = 834 | (0 << 0x10),
        Giga_Drednaw = 834 | (1 << 0x10),

        Yamper = 835,
        Boltund = 836,

        Rolycoly = 837,
        Carkol = 838,
        Coalossal = 839 | (0 << 0x10),
        Giga_Coalossal = 839 | (1 << 0x10),

        Applin = 840,
        Flapple = 841 | (0 << 0x10),
        Giga_Flapple = 841 | (1 << 0x10),
        Appletun = 842 | (0 << 0x10),
        Giga_Appletun = 842 | (1 << 0x10),

        Silicobra = 843,
        Sandaconda = 844 | (0 << 0x10),
        Giga_Sandaconda = 844 | (1 << 0x10),

        Cramorant = 845 | (0 << 0x10),
        Cramorant_Gulp = 845 | (1 << 0x10),
        Cramorant_Pikachu = 845 | (2 << 0x10),

        Arrokuda = 846,
        Barraskewda = 847,

        Toxel = 848,
        Toxtricity_Amp = 849 | (0 << 0x10),
        Toxtricity_Lowkey = 849 | (1 << 0x10),
        Giga_Toxtricity = 849 | (2 << 0x10),

        Sizzlipede = 850,
        Centiskorch = 851 | (0 << 0x10),
        Giga_Centiskorch = 851 | (1 << 0x10),

        Clobbopus = 852,
        Grapploct = 853,

        Sinistea = 854 | (0 << 0x10),
        Sinistea_Original = 854 | (1 << 0x10),
        Polteageist = 855 | (0 << 0x10),
        Polteageist_Original = 855 | (1 << 0x10),

        Hatenna = 856,
        Hattrem = 857,
        Hatterene = 858 | (0 << 0x10),
        Giga_Hatterene = 858 | (1 << 0x10),

        Impidimp = 859,
        Morgrem = 860,
        Grimmsnarl = 861 | (0 << 0x10),
        Giga_Grimmsnarl = 861 | (1 << 0x10),

        Obstagoon = 862,

        Perrserker = 863,

        Cursola = 864,

        Sirfetchd = 865,

        Mr_Rime = 866,

        Runerigus = 867,

        Milcery = 868,
        Alcremie_Vanilla_Berry = 869 | (0 << 0x10),
        Alcremie_Vanilla_Flower = 869 | (1 << 0x10),
        Alcremie_Vanilla_Strawberry = 869 | (2 << 0x10),
        Alcremie_Vanilla_Heart = 869 | (3 << 0x10),
        Alcremie_Vanilla_Clover = 869 | (4 << 0x10),
        Alcremie_Vanilla_Ribbon = 869 | (5 << 0x10),
        Alcremie_Vanilla_Star = 869 | (6 << 0x10),
        Alcremie_Ruby_Berry = 869 | (7 << 0x10),
        Alcremie_Ruby_Flower = 869 | (8 << 0x10),
        Alcremie_Ruby_Strawberry = 869 | (9 << 0x10),
        Alcremie_Ruby_Heart = 869 | (10 << 0x10),
        Alcremie_Ruby_Clover = 869 | (11 << 0x10),
        Alcremie_Ruby_Ribbon = 869 | (12 << 0x10),
        Alcremie_Ruby_Star = 869 | (13 << 0x10),
        Alcremie_Matcha_Berry = 869 | (14 << 0x10),
        Alcremie_Matcha_Flower = 869 | (15 << 0x10),
        Alcremie_Matcha_Strawberry = 869 | (16 << 0x10),
        Alcremie_Matcha_Heart = 869 | (17 << 0x10),
        Alcremie_Matcha_Clover = 869 | (18 << 0x10),
        Alcremie_Matcha_Ribbon = 869 | (19 << 0x10),
        Alcremie_Matcha_Star = 869 | (20 << 0x10),
        Alcremie_Mint_Berry = 869 | (21 << 0x10),
        Alcremie_Mint_Flower = 869 | (22 << 0x10),
        Alcremie_Mint_Strawberry = 869 | (23 << 0x10),
        Alcremie_Mint_Heart = 869 | (24 << 0x10),
        Alcremie_Mint_Clover = 869 | (25 << 0x10),
        Alcremie_Mint_Ribbon = 869 | (26 << 0x10),
        Alcremie_Mint_Star = 869 | (27 << 0x10),
        Alcremie_Citrus_Berry = 869 | (28 << 0x10),
        Alcremie_Citrus_Flower = 869 | (29 << 0x10),
        Alcremie_Citrus_Strawberry = 869 | (30 << 0x10),
        Alcremie_Citrus_Heart = 869 | (31 << 0x10),
        Alcremie_Citrus_Clover = 869 | (32 << 0x10),
        Alcremie_Citrus_Ribbon = 869 | (33 << 0x10),
        Alcremie_Citrus_Star = 869 | (34 << 0x10),
        Alcremie_Salt_Berry = 869 | (35 << 0x10),
        Alcremie_Salt_Flower = 869 | (36 << 0x10),
        Alcremie_Salt_Strawberry = 869 | (37 << 0x10),
        Alcremie_Salt_Heart = 869 | (38 << 0x10),
        Alcremie_Salt_Clover = 869 | (39 << 0x10),
        Alcremie_Salt_Ribbon = 869 | (40 << 0x10),
        Alcremie_Salt_Star = 869 | (41 << 0x10),
        Alcremie_RubyMix_Berry = 869 | (42 << 0x10),
        Alcremie_RubyMix_Flower = 869 | (43 << 0x10),
        Alcremie_RubyMix_Strawberry = 869 | (44 << 0x10),
        Alcremie_RubyMix_Heart = 869 | (45 << 0x10),
        Alcremie_RubyMix_Clover = 869 | (46 << 0x10),
        Alcremie_RubyMix_Ribbon = 869 | (47 << 0x10),
        Alcremie_RubyMix_Star = 869 | (48 << 0x10),
        Alcremie_Caramel_Berry = 869 | (49 << 0x10),
        Alcremie_Caramel_Flower = 869 | (50 << 0x10),
        Alcremie_Caramel_Strawberry = 869 | (51 << 0x10),
        Alcremie_Caramel_Heart = 869 | (52 << 0x10),
        Alcremie_Caramel_Clover = 869 | (53 << 0x10),
        Alcremie_Caramel_Ribbon = 869 | (54 << 0x10),
        Alcremie_Caramel_Star = 869 | (55 << 0x10),
        Alcremie_Trio_Berry = 869 | (56 << 0x10),
        Alcremie_Trio_Flower = 869 | (57 << 0x10),
        Alcremie_Trio_Strawberry = 869 | (58 << 0x10),
        Alcremie_Trio_Heart = 869 | (59 << 0x10),
        Alcremie_Trio_Clover = 869 | (60 << 0x10),
        Alcremie_Trio_Ribbon = 869 | (61 << 0x10),
        Alcremie_Trio_Star = 869 | (62 << 0x10),
        Giga_Alcremie = 869 | (63 << 0x10),

        Falinks = 870,

        Pincurchin = 871,

        Snom = 872,
        Frosmoth = 873,

        Stonjourner = 874,

        Eiscue = 875 | (0 << 0x10),
        Eiscue_Exposed = 875 | (1 << 0x10),

        Indeedee = 876,

        Morpeko = 877 | (0 << 0x10),
        Morpeko_Hangry = 877 | (1 << 0x10),

        Cufant = 878,
        Copperajah = 879 | (0 << 0x10),
        Giga_Copperajah = 879 | (1 << 0x10),

        Dracozolt = 880,
        Arctozolt = 881,
        Dracovish = 882,
        Arctovish = 883,

        Duraludon = 884 | (0 << 0x10),
        Giga_Duraludon = 884 | (1 << 0x10),

        Dreepy = 885,
        Drakloak = 886,
        Dragapult = 887,

        Zacian = 888 | (0 << 0x10),
        Zacian_KingsBlade = 888 | (1 << 0x10),

        Zamazenta = 889 | (0 << 0x10),
        Zamazenta_KingsShield = 889 | (1 << 0x10),

        Eternatus = 890 | (0 << 0x10),
        Giga_Eternatus = 890 | (1 << 0x10),


        #endregion
    }
}
