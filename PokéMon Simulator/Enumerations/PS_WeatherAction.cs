namespace PokéMon_Simulator.Enumerations
{
    public enum PS_WeatherAction : byte
    {
        /// <summary>
        /// Das Wetter hat gestartet.
        /// </summary>
        Added = 0,

        /// <summary>
        /// Das Wetter hat Schaden verursacht.
        /// </summary>
        CausedDamage = 1,

        /// <summary>
        /// Das Wetter wurde entfernt.
        /// </summary>
        Ended = 2
    }
}
