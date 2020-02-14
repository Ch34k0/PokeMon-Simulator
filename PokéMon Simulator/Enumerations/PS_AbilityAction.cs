namespace PokéMon_Simulator.Enumerations
{
    public enum PS_AbilityAction : byte
    {
        /// <summary>
        /// Die Fähigkeit wurde zum ersten Mal angekündigt.
        /// </summary>
        Announced = 0,

        /// <summary>
        /// Die Fähigkeit wurde geändert.
        /// </summary>
        Changed = 1,

        /// <summary>
        /// Die Fähigkeit sorgte dafür, dass ein PokéMon seine Gestalt geändert hat.
        /// </summary>
        ChangedAppearance = 2,

        /// <summary>
        /// Die Fähigkeit sorgte dafür, dass die Stats eines PokéMon geändert wurden.
        /// </summary>
        ChangedStats = 3,

        /// <summary>
        /// Die Fähigkeit sorgte dafür, dass der primäre oder sekundäre Status von PokéMon geändert wurde.
        /// </summary>
        ChangedStatus = 4,

        /// <summary>
        /// Die Fähigkeit hat was mit Schaden zu tun.
        /// </summary>
        Damage = 5,

        /// <summary>
        /// Die Fähigkeit sorgte dafür, dass ein PokéMon nicht mit einem primären oder sekundären Status befallen wurde.
        /// </summary>
        PreventedStatus = 6,

        /// <summary>
        /// Die Fähigkeit sorgte dafür, dass die KP eines PokéMon geheilt wurden.
        /// </summary>
        RestoredHP = 7,

        /// <summary>
        /// Saumselig ist zu Ende.
        /// </summary>
        SlowStart_Ended = 8,

        /// <summary> 
        /// Die Fähigkeit hat was mit Wetter zu tun.
        /// </summary>
        Weather = 9
    }
}
