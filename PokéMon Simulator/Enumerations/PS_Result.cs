namespace PokéMon_Simulator.Enumerations
{
    public enum PS_Result : byte
    {
        /// <summary>
        /// Kein Misserfolg.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Misserfolg wegen einer <see cref="PS_Ability"/>.
        /// </summary>
        Ineffective_Ability = 1,

        /// <summary>
        /// Misserfolg wegen eines <see cref="PS_Gender"/>.
        /// </summary>
        Ineffective_Gender = 2,

        /// <summary>
        /// Misserfolg wegen dem Level eines Pokémon's.
        /// </summary>
        Ineffective_Level = 3,

        /// <summary>
        /// Misserfolg wegen <see cref="PS_SecondaryStatus.MagnetRise"/>.
        /// </summary>
        Ineffective_MagnetRise = 4,

        /// <summary>
        /// Misserfolg wegen <see cref="PS_TeamStatus.Safeguard"/>.
        /// </summary>
        Ineffective_Safeguard = 5,

        /// <summary>
        /// Misserfolg wegen eines <see cref="PS_Stats"/>.
        /// </summary>
        Ineffective_Stat = 6,

        /// <summary>
        /// Misserfolg wegen <see cref="PS_PrimaryStatus"/>, <see cref="PS_SecondaryStatus"/>, <see cref="PS_TeamStatus"/>, <see cref="PS_BattleStatus"/>, oder <see cref="PS_Weather"/>.
        /// </summary>
        Ineffective_Status = 7,

        /// <summary>
        /// Misserfolg wegen <see cref="PS_SecondaryStatus.Substitute"/>.
        /// </summary>
        Ineffective_Substitute = 8,

        /// <summary>
        /// Misserfolg wegen eines <see cref="PS_Types"/>.
        /// </summary>
        Ineffective_Type = 9,

        /// <summary>
        /// Misserfolg wegen ungetroffen Voraussetzungen.
        /// </summary>
        InvalidConditions = 10,

        /// <summary>
        /// Misserfolg weil kein Ziel verfügbar ist.
        /// </summary>
        NoTarget = 11,

        /// <summary>
        /// Nicht sehr effektiv wegen dem <see cref="PS_Types"/> eines Pokémon's.
        /// </summary>
        NotVeryEffective_Type = 12,

        /// <summary>
        /// Sehr effektiv wegen dem <see cref="PS_Types"/> eines Pokémon's.
        /// </summary>
        SuperEffective_Type = 13
    }
}
