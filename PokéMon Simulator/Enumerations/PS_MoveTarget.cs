namespace PokéMon_Simulator.Enumerations
{
    public enum PS_MoveTarget : byte
    {
        All,                   // Alle PokéMon auf dem Feld.
        AllFoes,               // Alle Gegner
        AllFoesSurrounding,    // Alle Gegner in der Nähe
        AllSurrounding,        // Alle PokéMon in der Nähe
        AllTeam,               // Alle PokéMon des Spielers
        RandomFoeSurrounding,  // Ein zufälliger Gegner
        Self,                  // Sich selbst
        SelfOrAllySurrounding, // Sich selbst oder ein Teammitglied in der Nähe
        SingleAllySurrounding, // Teammitglied in der Nähe
        SingleNotSelf,         // Ein PokéMon außer sich selbst
        SingleFoeSurrounding,  // Ein Gegner in der Nähe
        SingleSurrounding,     // Ein PokéMon in der Nähe
        Varies                 // Ziele können varriieren (z.B. Fluch)
    }
}
